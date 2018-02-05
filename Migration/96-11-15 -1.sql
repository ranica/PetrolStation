
USE [GasStation]
GO
/****** Object:  StoredProcedure [dbo].[spTrafficRegisterByService]    Script Date: 2018-02-05 11:07:25 AM ******/
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



USE [GasStation]
GO
/****** Object:  StoredProcedure [dbo].[spGetTraffic]    Script Date: 2018-02-05 11:05:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Description:	Get Traffic By Date 
-- =============================================
ALTER PROCEDURE [dbo].[spGetTraffic] 

	@startDate  AS datetime,
	@endDate	AS datetime,
	@pageIndex  AS int,
	@pageSize   AS int,
	@userId		AS int
AS
BEGIN

	SET NOCOUNT ON;
	WITH tx 
	AS
	(
		SELECT 
			ROW_NUMBER() OVER(ORDER BY dbo.Traffic.trafficDate DESC) AS Row,
			COUNT(*) OVER() AS total,
			dbo.Owner.name, 
			dbo.Owner.lastname,
			dbo.Owner.mobile,
			dbo.Plate.plate,	
			dbo.UHF.name as nameUHF,	
			dbo.Traffic.trafficDate

			FROM

			dbo.Traffic

			INNER JOIN dbo.Tag			on dbo.Tag.id			= dbo.Traffic.tagId 
			INNER JOIN dbo.CarTag		on dbo.CarTag.tagId		=  dbo.Traffic.tagId
			INNER JOIN dbo.Car			on dbo.Car.id			= dbo.CarTag.carId
			INNER JOIN dbo.Plate		on dbo.Plate.id			= dbo.Car.plateId
			INNER JOIN dbo.CarOwner		on dbo.CarOwner.carId	= dbo.Car.id
			INNER JOIN dbo.Owner		on dbo.Owner.id			= dbo.CarOwner.ownerId
			INNER JOIN dbo.UHF		    on dbo.UHF.id			= dbo.Traffic.uhfId

			 WHERE 
				(dbo.Traffic.trafficDate BETWEEN @startDate + '00:00:00.000' AND @endDate + '23:59:59.999'	)
				AND
				(dbo.Traffic.uhfId IN (SELECT uhfId FROM dbo.UHFPermit
												WHERE userId = @userId))	
		)
	SELECT * FROM tx
		WHERE Row BETWEEN ((@PageIndex - 1) * @PageSize + 1)
						AND (@PageIndex * @PageSize) 
END




USE [GasStation]
GO
/****** Object:  StoredProcedure [dbo].[spGetReportTrafficCount]    Script Date: 2018-02-05 10:09:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Description:	Show  Count Traffic 
-- =============================================
ALTER PROCEDURE [dbo].[spGetReportTrafficCount]
	@startDate as Datetime,
	@endDate	as Datetime,
	@pageIndex  AS int,
	@pageSize   AS int,
	@userId		AS int
	
AS
BEGIN
	SELECT 
		ROW_NUMBER() OVER( ORDER BY [Owner].id ASC) AS Row,
		COUNT(*) OVER() AS total,
		[Owner].id,
		[Owner].name,
		[Owner].lastname, 
		[Owner].nationalCode, 
		[Owner].mobile,
		plate,
		dbo.UHF.name as nameUHF,
		--COUNT(*) as total,
		SUM(COUNT(*)) OVER (PARTITION BY [Owner].nationalCode ORDER BY [Owner].id ASC) AS 'totalTraffic'
		

	FROM 
		Plate

		INNER JOIN Car				ON Car.plateId			= Plate.id	
		INNER JOIN [Base.PlateType] ON [Base.PlateType].id	= Plate.plateTypeId
		INNER JOIN [Base.CarColor]	ON [Base.CarColor].id	= Car.carColorId
		INNER JOIN [Base.CarType]	ON [Base.CarType].id	= Car.carTypeId
		INNER JOIN [Base.PlateCity] ON [Base.PlateCity].id	= Plate.plateCityId
		INNER JOIN CarOwner			ON CarOwner.carId		= Car.id
		INNER JOIN [Owner]			ON [Owner].id			= CarOwner.ownerId
		INNER JOIN CarTag			ON CarTag.carId			= Car.id
		INNER JOIN Tag				ON Tag.id				= CarTag.tagId
		INNER JOIN Traffic			ON Traffic.tagId		= Tag.id
		INNER JOIN dbo.UHF		    ON dbo.UHF.id			= dbo.Traffic.uhfId

		WHERE 	
			
			(dbo.Traffic.trafficDate BETWEEN @startDate + '00:00:00.000' AND @endDate + '23:59:59.999')
			AND
			(dbo.Traffic.uhfId IN (SELECT uhfId FROM dbo.UHFPermit
												WHERE userId = @userId))
			
			
			
		GROUP BY [Owner].id, [Owner].name, [owner].lastname, [Owner].nationalCode, [Owner].mobile, plate ,dbo.UHF.name
	
		ORDER BY [Owner].id, [Owner].name, [Owner].lastname, [Owner].nationalCode, [Owner].mobile, plate, dbo.UHF.name
END


USE [GasStation]
GO
/****** Object:  StoredProcedure [dbo].[spGetReportTrafficByNationalcode]    Script Date: 2018-02-05 10:34:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Description:	Show  Traffic By National Code
-- =============================================

ALTER PROCEDURE [dbo].[spGetReportTrafficByNationalcode] 
	@startDate		AS datetime,
	@endDate		AS datetime,
	@nationalcode	AS varchar(10),
	@pageIndex		AS int,
	@pageSize		AS int,
	@userId			AS int
AS
BEGIN

	SET NOCOUNT ON;
	SELECT 
		ROW_NUMBER() OVER(ORDER BY dbo.Traffic.trafficDate DESC) AS Row,
		COUNT(*) OVER() AS total,
		dbo.Owner.name, 
		dbo.Owner.lastname,
		dbo.Owner.mobile,
		dbo.Plate.plate,		
		dbo.Traffic.trafficDate,
		dbo.UHF.name as nameUHF

		FROM

		dbo.Traffic

		INNER JOIN dbo.Tag			ON dbo.Tag.id			= dbo.Traffic.tagId 
		INNER JOIN dbo.CarTag		ON dbo.CarTag.tagId		= dbo.Traffic.tagId
		INNER JOIN dbo.Car			ON dbo.Car.id			= dbo.CarTag.carId
		INNER JOIN dbo.Plate		ON dbo.Plate.id			= dbo.Car.plateId
		INNER JOIN dbo.CarOwner		ON dbo.CarOwner.carId	= dbo.Car.id
		INNER JOIN dbo.Owner		ON dbo.Owner.id			= dbo.CarOwner.ownerId
		INNER JOIN dbo.UHF		    ON dbo.UHF.id			= dbo.Traffic.uhfId

		 WHERE 
			(dbo.Traffic.trafficDate BETWEEN @startDate + '00:00:00.000' AND @endDate + '23:59:59.999')
			AND
			(dbo.Traffic.uhfId IN (SELECT uhfId FROM dbo.UHFPermit
												WHERE userId = @userId))				
			AND nationalCode =  @nationalcode
END





USE [GasStation]
GO
/****** Object:  StoredProcedure [dbo].[spGetReportTrafficCountByNationalcode]    Script Date: 2018-02-05 11:08:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Description:	Get Traffic count By date and nationalcode
-- =============================================
ALTER PROCEDURE [dbo].[spGetReportTrafficCountByNationalcode]
	@startDate		AS datetime,
	@endDate		AS datetime,
	@nationalcode	AS varchar(10),
	@pageIndex		AS int,
	@pageSize		AS int,
	@userId			AS int
AS
BEGIN	

SELECT 
		ROW_NUMBER() OVER(PARTITION BY [Owner].nationalCode ORDER BY [Owner].id ASC) AS Row, 
		COUNT(*) OVER() AS total,
		[Owner].id,
		[Owner].name,
		[Owner].lastname, 
		[Owner].nationalCode, 
		[Owner].mobile,
		plate,
		dbo.UHF.name AS nameUHF
		

	FROM 
		Plate

		INNER JOIN Car				ON Car.plateId = Plate.id	
		INNER JOIN [Base.PlateType] ON [Base.PlateType].id = Plate.plateTypeId
		INNER JOIN [Base.CarColor]	ON [Base.CarColor].id = Car.carColorId
		INNER JOIN [Base.CarType]	ON [Base.CarType].id = Car.carTypeId
		INNER JOIN [Base.PlateCity] ON [Base.PlateCity].id = Plate.plateCityId
		INNER JOIN CarOwner			ON CarOwner.carId = Car.id
		INNER JOIN [Owner]			ON [Owner].id = CarOwner.ownerId
		INNER JOIN CarTag			ON CarTag.carId = Car.id
		INNER JOIN Tag				ON Tag.id = CarTag.tagId
		INNER JOIN Traffic			ON Traffic.tagId = Tag.id
		INNER JOIN dbo.UHF		    ON dbo.UHF.id			= dbo.Traffic.uhfId

		WHERE 	
			
			(dbo.Traffic.trafficDate BETWEEN @startDate + '00:00:00.000' AND @endDate + '23:59:59.999')
			AND
			(dbo.Traffic.uhfId IN (SELECT uhfId FROM dbo.UHFPermit
												WHERE userId = @userId))				
			AND nationalCode =  @nationalcode
			
		GROUP BY [Owner].id, [Owner].name, [owner].lastname, [Owner].nationalCode, [owner].mobile, plate, dbo.UHF.name

	
END



SELECT 
		ROW_NUMBER() OVER(PARTITION BY [Owner].nationalCode ORDER BY [Owner].id ASC) AS Row, 
		COUNT(*) OVER() AS total,
		[Owner].id,
		[Owner].name,
		[Owner].lastname, 
		[Owner].nationalCode, 
		[Owner].mobile,
		plate,
		dbo.UHF.name AS nameUHF
		

	FROM 
		Plate

		INNER JOIN Car				ON Car.plateId = Plate.id	
		INNER JOIN [Base.PlateType] ON [Base.PlateType].id = Plate.plateTypeId
		INNER JOIN [Base.CarColor]	ON [Base.CarColor].id = Car.carColorId
		INNER JOIN [Base.CarType]	ON [Base.CarType].id = Car.carTypeId
		INNER JOIN [Base.PlateCity] ON [Base.PlateCity].id = Plate.plateCityId
		INNER JOIN CarOwner			ON CarOwner.carId = Car.id
		INNER JOIN [Owner]			ON [Owner].id = CarOwner.ownerId
		INNER JOIN CarTag			ON CarTag.carId = Car.id
		INNER JOIN Tag				ON Tag.id = CarTag.tagId
		INNER JOIN Traffic			ON Traffic.tagId = Tag.id
		INNER JOIN dbo.UHF		    ON dbo.UHF.id			= dbo.Traffic.uhfId

		WHERE 	
			
			(dbo.Traffic.trafficDate BETWEEN @startDate + '00:00:00.000' AND @endDate + '23:59:59.999')
			AND
			(dbo.Traffic.uhfId IN (SELECT uhfId FROM dbo.UHFPermit
												WHERE userId = @userId))				
			AND nationalCode =  @nationalcode
			
		GROUP BY [Owner].id, [Owner].name, [owner].lastname, [Owner].nationalCode, [owner].mobile, plate

	
END


USE [GasStation]
GO
/****** Object:  StoredProcedure [dbo].[spGetReportTrafficByPlate]    Script Date: 2018-02-05 2:22:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Description:	Show  Traffic By Plate
-- =============================================

ALTER PROCEDURE [dbo].[spGetReportTrafficByPlate] 
	@startDate		AS datetime,
	@endDate		AS datetime,
	@plate			AS varchar(50),
	@pageIndex		AS int,
	@pageSize		AS int,
	@userId			AS int

AS
BEGIN

	SET NOCOUNT ON;
	SELECT 
		ROW_NUMBER() OVER(ORDER BY dbo.Traffic.trafficDate DESC) AS Row,
		COUNT(*) OVER() AS total,
		dbo.Owner.name, 
		dbo.Owner.lastname,
		dbo.Owner.mobile,
		dbo.Plate.plate,		
		dbo.Traffic.trafficDate,
		dbo.UHF.name AS nameUHF

		FROM

		dbo.Traffic

		INNER JOIN dbo.Tag			ON dbo.Tag.id			= dbo.Traffic.tagId 
		INNER JOIN dbo.CarTag		ON dbo.CarTag.tagId		=  dbo.Traffic.tagId
		INNER JOIN dbo.Car			ON dbo.Car.id			= dbo.CarTag.carId
		INNER JOIN dbo.Plate		ON dbo.Plate.id			= dbo.Car.plateId
		INNER JOIN dbo.CarOwner		ON dbo.CarOwner.carId	= dbo.Car.id
		INNER JOIN dbo.Owner		ON dbo.Owner.id			= dbo.CarOwner.ownerId
		INNER JOIN dbo.UHF		    ON dbo.UHF.id			= dbo.Traffic.uhfId

		 WHERE 
			(dbo.Traffic.trafficDate BETWEEN @startDate + '00:00:00.000' AND @endDate + '23:59:59.999')
			AND
			(dbo.Traffic.uhfId IN (SELECT uhfId FROM dbo.UHFPermit
												WHERE userId = @userId))				
			
			AND plate =  @plate
END



USE [GasStation]
GO
/****** Object:  StoredProcedure [dbo].[spGetReportTrafficCountByPlate]    Script Date: 2018-02-05 2:40:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Description:	Get Traffic count By date and plate
-- =============================================
ALTER PROCEDURE [dbo].[spGetReportTrafficCountByPlate]
	@startDate		AS datetime,
	@endDate		AS datetime,
	@plate			AS varchar(50),
	@pageIndex		AS int,
	@pageSize		AS int,
	@userId			AS int
AS
BEGIN	

SELECT  
		ROW_NUMBER() OVER(PARTITION BY [Owner].nationalCode ORDER BY [Owner].id ASC) AS Row,
		COUNT(*) OVER() AS total, 
		[Owner].id,
		[Owner].name,
		[Owner].lastname, 
		[Owner].nationalCode, 
		[Owner].mobile,
		plate,
		dbo.UHF.name AS nameUHF

	FROM 
		Plate

		INNER JOIN Car				ON Car.plateId = Plate.id	
		INNER JOIN [Base.PlateType] ON [Base.PlateType].id = Plate.plateTypeId
		INNER JOIN [Base.CarColor]	ON [Base.CarColor].id = Car.carColorId
		INNER JOIN [Base.CarType]	ON [Base.CarType].id = Car.carTypeId
		INNER JOIN [Base.PlateCity] ON [Base.PlateCity].id = Plate.plateCityId
		INNER JOIN CarOwner			ON CarOwner.carId = Car.id
		INNER JOIN [Owner]			ON [Owner].id = CarOwner.ownerId
		INNER JOIN CarTag			ON CarTag.carId = Car.id
		INNER JOIN Tag				ON Tag.id = CarTag.tagId
		INNER JOIN Traffic			ON Traffic.tagId = Tag.id
		INNER JOIN dbo.UHF		    ON dbo.UHF.id			= dbo.Traffic.uhfId

		WHERE 	
			
			(dbo.Traffic.trafficDate BETWEEN @startDate + '00:00:00.000' AND @endDate + '23:59:59.999')
			AND
			(dbo.Traffic.uhfId IN (SELECT uhfId FROM dbo.UHFPermit
												WHERE userId = @userId))				
			
			AND plate =  @plate
			
		GROUP BY [Owner].id,[Owner].name, [owner].lastname, [Owner].nationalCode, [owner].mobile, plate, dbo.UHF.name

	
END







/*
	UPDATE DB VERSION
*/

DECLARE @version	varchar(50) = '96-11-15-1';

IF EXISTS (SELECT * FROM [System.Data] WHERE ([name] = 'DB-Version'))
	BEGIN
		UPDATE [System.Data] SET [value]=@version WHERE ([name] = 'DB-Version')
	END
ELSE
	BEGIN
		INSERT INTO [System.Data] ([name], [value]) VALUES ('DB-Version', @version)
	END

