USE [GasStation]
GO

/****** Object:  Table [dbo].[UHFPermit]    Script Date: 2018-01-30 2:25:27 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[UHFPermit](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL CONSTRAINT [DF_UHFPermit_viewId]  DEFAULT (newid()),
	[userId] [int] NOT NULL,
	[uhfId] [int] NOT NULL,
 CONSTRAINT [PK_UHFPermit] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[UHFPermit]  WITH CHECK ADD  CONSTRAINT [FK_UHFPermit_UHF] FOREIGN KEY([uhfId])
REFERENCES [dbo].[UHF] ([id])
GO

ALTER TABLE [dbo].[UHFPermit] CHECK CONSTRAINT [FK_UHFPermit_UHF]
GO

ALTER TABLE [dbo].[UHFPermit]  WITH CHECK ADD  CONSTRAINT [FK_UHFPermit_User] FOREIGN KEY([userId])
REFERENCES [dbo].[User] ([id])
GO

ALTER TABLE [dbo].[UHFPermit] CHECK CONSTRAINT [FK_UHFPermit_User]
GO

/*
	UPDATE UHF TABLE
*/

/************/
ALTER TABLE [dbo].[UHF]	
	ADD  [name] [varchar](50) NULL

/*
	UPDATE Traffic TABLE
*/

ALTER TABLE [dbo].[Traffic]
	ADD [uhfId] [int] NULL
	
	
ALTER TABLE [dbo].[Traffic]  WITH CHECK ADD  CONSTRAINT [FK_Traffic_UHF] FOREIGN KEY([uhfId])
REFERENCES [dbo].[UHF] ([id])
GO


/*
	MODIFY Store PROCEDURE 
*/ 
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER  PROCEDURE [dbo].[spTrafficRegisterByService]
(
	@tagData		varchar(50),
	@antenaId		int,
	@insertedById	int,
	@trafficDate	datetime,
	@intervalTime	int				-- MINUTES
)
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE	@result	int;
	DECLARE	@tagId	int;

	-- Insert Tag
	SELECT
			@tagId = id
	FROM
			[Tag]
	WHERE
			(tag = @tagData);

	-- Insert if not exists
	IF (@tagId IS NULL)
		BEGIN
			INSERT INTO
					[tag]
					(tag, insertedById, insertDate)
			VALUES
					(@tagData, @insertedById, getDate());

			SET @tagId	= SCOPE_IDENTITY ();
		END

	-- Register Traffic
	IF (NOT EXISTS (
		SELECT
				*
		FROM
				(
					SELECT
							MAX (trafficDate) AS trafficDate
					FROM
							[Traffic]
					WHERE
							(tagId = @tagId)
				) AS tBase
		WHERE
				(DATEDIFF (MINUTE, trafficDate, GETDATE ()) < @intervalTime)
	))
		BEGIN	
			INSERT INTO
					[Traffic]
					(tagId, uhfId, trafficDate)
			VALUES
					(@tagId, @antenaId, @trafficDate);

			-- Set output
			SET	@result	= SCOPE_IDENTITY ();
		END
	ELSE
		SET	@result	= -1;	-- INTERVAL ERROR

	return  @result;
END




/*
	UPDATE DB VERSION
*/

DECLARE @version	varchar(50) = '96-11-10-1';

IF EXISTS (SELECT * FROM [System.Data] WHERE ([name] = 'DB-Version'))
	BEGIN
		UPDATE [System.Data] SET [value]=@version WHERE ([name] = 'DB-Version')
	END
ELSE
	BEGIN
		INSERT INTO [System.Data] ([name], [value]) VALUES ('DB-Version', @version)
	END



