USE [GasStation]
GO
/****** Object:  StoredProcedure [dbo].[spChartTraffic]    Script Date: 2018-02-18 12:38:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Description:	Show Chart in Dashboard
-- =============================================
CREATE PROCEDURE [dbo].[spChartTraffic] 
	
	@beginDate as datetime,	
	@userId as int
AS
BEGIN
	DECLARE @SaturdayDateFirstValue INT = 6
	
	DECLARE @CurrentDate DATE			= GETDATE() 
	declare @SaturdayStartOfWeek  as datetime;
	declare @SaturdayEndOfWeek	as datetime;

	SET @SaturdayDateFirstValue		= 7 - @SaturdayDateFirstValue - 1
	

	SET DATEFIRST 6 -- notice this is saturday

	SET @SaturdayStartOfWeek = DATEADD(DAY, 0 - (@@DATEFIRST + @SaturdayDateFirstValue + DATEPART(dw,@CurrentDate)) % 7, @CurrentDate);
    SET @SaturdayEndOfWeek  = DATEADD(DAY, 6 - (@@DATEFIRST + @SaturdayDateFirstValue + DATEPART(dw,@CurrentDate)) % 7, @CurrentDate);
	

	

	WITH  t AS
	(
		SELECT  CONVERT(DATE, trafficDate) AS dat, * FROM Traffic
	
	)


	SELECT  dat , COUNT(dat) AS count  FROM t
		WHERE dat BETWEEN CONVERT(date, @SaturdayStartOfWeek)  AND  CONVERT(date, @SaturdayEndOfWeek)
		--WHERE dat BETWEEN CONVERT(date, @beginDate)  AND  CONVERT(date, @beginDate)
					AND (t.uhfId IN (SELECT uhfId FROM dbo.UHFPermit
									WHERE userId = @userId))
GROUP BY dat

END

GO
/****** Object:  StoredProcedure [dbo].[spCumulative]    Script Date: 2018-02-18 12:38:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
CREATE PROCEDURE [dbo].[spCumulative]

	@startDate AS Datetime,
	@endDate	AS Datetime
AS
BEGIN
	
WITH t AS 
(
	SELECT 
			[Owner].id,
			[Owner].name,
			[Owner].lAStname, 
			[Owner].natiONalCode, 
			[Owner].mobile


		FROM 
			Plate

			INNER JOIN Car				ON Car.plateId			= Plate.id	
			INNER JOIN [BASe.PlateType] ON [BASe.PlateType].id	= Plate.plateTypeId
			INNER JOIN [BASe.CarColor]	ON [BASe.CarColor].id	= Car.carColorId
			INNER JOIN [BASe.CarType]	ON [BASe.CarType].id	= Car.carTypeId
			INNER JOIN [BASe.PlateCity] ON [BASe.PlateCity].id	= Plate.plateCityId
			INNER JOIN CarOwner			ON CarOwner.carId		= Car.id
			INNER JOIN [Owner]			ON [Owner].id			= CarOwner.ownerId
			INNER JOIN CarTag			ON CarTag.carId			= Car.id
			INNER JOIN Tag				ON Tag.id				= CarTag.tagId
			INNER JOIN Traffic			ON Traffic.tagId		= Tag.id

		
			WHERE 	
			
				(dbo.Traffic.trafficDate BETWEEN  @startDate +' 00:00:00.000' AND @endDate +' 23:59:59.999')

				 AND NOT EXISTS ( SELECT ownerId FROM Lottery
										WHERE ownerId = [Owner].id)

		),

		t2 AS (
		SELECT top 100 percent
			t.id, t.natiONalCode,
			count(*) AS countValue
		FROM t
		GROUP BY t.natiONalCode, t.id
		ORDER BY natiONalCode
		),


		r AS (
		SELECT 
			t2.id, t2.natiONalCode, sum(t3.countValue)  AS total
		FROM 
			t2 inner join t2 AS t3 ON (t2.natiONalCode >= t3.natiONalCode)
			GROUP BY t2.natiONalCode, t2.id
		)

	--,temp AS 
	--(
	--	SELECT CAST (@rnd * SUM(t) AS bigint) - 1 AS randNumber
	--	FROM r
	--)

	--SELECT * FROM t
	--SELECT top 1 * FROM r WHERE r.t >= (SELECT TOP 1 randNumber FROM temp)

	SELECT top 10 * FROM r

END

GO
/****** Object:  StoredProcedure [dbo].[spCumulative1]    Script Date: 2018-02-18 12:38:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
CREATE PROCEDURE [dbo].[spCumulative1]

	@startDate as Datetime,
	@endDate	as Datetime
AS
BEGIN
	SELECT 
		ROW_NUMBER() OVER( ORDER BY [Owner].id ASC) AS Row,
		[Owner].id,
		[Owner].name,
		[Owner].lastname, 
		[Owner].nationalCode, 
		[Owner].mobile,	
		SUM(COUNT(*)) OVER (PARTITION BY [Owner].nationalCode ORDER BY [Owner].id ASC) AS 'total'
		

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

		WHERE 	
			
			(dbo.Traffic.trafficDate BETWEEN  @startDate +' 00:00:00.000' AND @endDate +' 23:59:59.999')

			 AND NOT EXISTS ( SELECT ownerId FROM Lottery
									WHERE ownerId = [Owner].id)		
			
			
			
		GROUP BY [Owner].id, [Owner].name, [owner].lastname, [Owner].nationalCode, [Owner].mobile
	
		ORDER BY [Owner].id, [Owner].name, [Owner].lastname, [Owner].nationalCode, [Owner].mobile
END

GO
/****** Object:  StoredProcedure [dbo].[spGetCarSearchByNationalcode]    Script Date: 2018-02-18 12:38:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spGetCarSearchByNationalcode]
	@nationalCode varchar(10)
AS
BEGIN
	SELECT  
			[Base.CarType].type as carType,
			[Base.CarColor].color, 
			plate,
			[Base.PlateCity].city,	
			[Base.PlateType].type as platetype, 
			Tag.tag

	FROM 
	Plate

		inner join Car				ON Car.plateId			= Plate.id	
		inner join [Base.PlateType] ON [Base.PlateType].id	= Plate.plateTypeId
		inner join [Base.CarColor]	ON [Base.CarColor].id	= Car.carColorId
		inner join [Base.CarType]	ON [Base.CarType].id	= Car.carTypeId
		inner join [Base.PlateCity] ON [Base.PlateCity].id	= Plate.plateCityId
		inner join CarOwner			ON CarOwner.carId		= Car.id
		inner join Owner			ON Owner.id				= CarOwner.ownerId
		inner join CarTag			ON CarTag.carId			= Car.id
		inner join Tag				ON Tag.id				= CarTag.tagId		

		WHERE nationalCode = @nationalCode
		GROUP BY [Base.CarType].type ,[Base.CarColor].color, plate,[Base.PlateCity].city, [Base.PlateType].type , Tag.tag
END



GO
/****** Object:  StoredProcedure [dbo].[spGetCarSearchByPlate]    Script Date: 2018-02-18 12:38:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Description: Get Report Info car' Owner by plate number
-- =============================================
CREATE PROCEDURE [dbo].[spGetCarSearchByPlate]
	@plate varchar(50)
AS
BEGIN
	SELECT  
			[Base.CarType].type as carType,
			[Base.CarColor].color, 
			plate,
			[Base.PlateCity].city,	
			[Base.PlateType].type as platetype, 
			Tag.tag

	FROM 
		Plate

			inner join Car				ON Car.plateId			= Plate.id	
			inner join [Base.PlateType] ON [Base.PlateType].id	= Plate.plateTypeId
			inner join [Base.CarColor]	ON [Base.CarColor].id	= Car.carColorId
			inner join [Base.CarType]	ON [Base.CarType].id	= Car.carTypeId
			inner join [Base.PlateCity] ON [Base.PlateCity].id	= Plate.plateCityId
			inner join CarOwner			ON CarOwner.carId		= Car.id
			inner join [Owner]			ON [Owner].id			= CarOwner.ownerId
			inner join CarTag			ON CarTag.carId			= Car.id
			inner join Tag				ON Tag.id				= CarTag.tagId		

			WHERE plate = @plate
			GROUP BY [Base.CarType].type, [Base.CarColor].color, plate,[Base.PlateCity].city, [Base.PlateType].type, Tag.tag
END



GO
/****** Object:  StoredProcedure [dbo].[spGetLottery]    Script Date: 2018-02-18 12:38:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spGetLottery]

	@startDate as Datetime,
	@endDate	as Datetime
AS
BEGIN
	
	SELECT  
			
			ROW_NUMBER() OVER(ORDER BY Lottery.id DESC) AS Row,
			
			(SELECT name			FROM [Owner] WHERE id	= Lottery.ownerId)  as name,
			(SELECT lastname		FROM [Owner] WHERE id	= Lottery.ownerId)  as lastname,
			(SELECT nationalCode	FROM [Owner] WHERE id= Lottery.ownerId)  as nationalCode,
			(SELECT mobile			FROM [Owner] WHERE id= Lottery.ownerId)  as mobile,
			(SELECT plate			FROM Plate  WHERE id in 
					(SELECT plateId FROM Car WHERE id in	
						(SELECT top(1) carId FROM CarOwner WHERE ownerId = Lottery.ownerId))) as plate,		
			Lottery.[month],
			Lottery.total as total
			

		FROM 			
			Lottery
						
			WHERE 	
			
				(dbo.Lottery.[startDate]= @startDate AND dbo.Lottery.[endDate]= @endDate)				
			
END


GO
/****** Object:  StoredProcedure [dbo].[spGetOwnerSearchByPlate]    Script Date: 2018-02-18 12:38:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spGetOwnerSearchByPlate]
	@plate varchar(50)
AS
BEGIN	

SELECT  
		[Owner].id,
		[Owner].name,
		[Owner].lastname, 
		[Owner].nationalCode, 
		[Owner].mobile,
		[Owner].birthdate,
		[Owner].birthdatelocal,
		[Owner].gen,
		[Owner].phone,
		[Owner].mobile,
		[Owner].address,
		[Owner].insertedById,
		[Owner].insertDate,
		[Owner].updatedById,
		[Owner].updateDate		

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

		WHERE 		 plate = @plate
			
		GROUP BY	[Owner].id,
					[Owner].name,
					[Owner].lastname, 
					[Owner].nationalCode, 
					[Owner].mobile,
					[Owner].birthdate,
					[Owner].birthdatelocal,
					[Owner].gen,
					[Owner].phone,
					[Owner].mobile,
					[Owner].address,
					[Owner].insertedById,
					[Owner].insertDate,
					[Owner].updatedById,
					[Owner].updateDate

	
END



GO
/****** Object:  StoredProcedure [dbo].[spGetPaginetTraffic]    Script Date: 2018-02-18 12:38:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetPaginetTraffic]
	@pageIndex int ,
	@pageSize int
AS
BEGIN	


	with tx as
(
	SELECT 
		ROW_NUMBER() OVER(ORDER BY dbo.Traffic.trafficDate DESC) AS Row,
		Count(*) over() as total,
		dbo.Owner.name, 
		dbo.Owner.lastname,
		dbo.Owner.mobile,
		dbo.Plate.plate,		
		dbo.Traffic.trafficDate,
		dbo.Owner.nationalCode

	FROM
		dbo.Traffic

		inner join dbo.Tag			on dbo.Tag.id			= dbo.Traffic.tagId 
		inner join dbo.CarTag		on dbo.CarTag.tagId		=  dbo.Traffic.tagId
		inner join dbo.Car			on dbo.Car.id			= dbo.CarTag.carId
		inner join dbo.Plate		on dbo.Plate.id			= dbo.Car.plateId
		inner join dbo.CarOwner		on dbo.CarOwner.carId	= dbo.Car.id
		inner join dbo.Owner		on dbo.Owner.id			= dbo.CarOwner.ownerId

)

SELECT * FROM tx
WHERE ROW BETWEEN (((@pageIndex - 1) * @pageSize ) + 1) and (((@pageIndex - 1) * @pageSize) + @pageSize)

END
GO
/****** Object:  StoredProcedure [dbo].[spGetReportTraffic]    Script Date: 2018-02-18 12:38:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spGetReportTraffic] 
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
				dbo.Traffic.trafficDate BETWEEN @startDate + '00:00:00.000' AND @endDate + '23:59:59.999'
				AND
				(dbo.Traffic.uhfId IN (SELECT uhfId FROM dbo.UHFPermit
												WHERE userId = @userId))		
		)
	SELECT * FROM tx
		WHERE Row BETWEEN ((@PageIndex - 1) * @PageSize + 1)
						AND (@PageIndex * @PageSize) 
END


GO
/****** Object:  StoredProcedure [dbo].[spGetReportTrafficByNationalcode]    Script Date: 2018-02-18 12:38:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Description:	Show  Traffic By National Code
-- =============================================

CREATE PROCEDURE [dbo].[spGetReportTrafficByNationalcode] 
	@startDate		AS datetime,
	@endDate		AS datetime,
	@nationalcode	AS varchar(10),
	@pageIndex		AS int,
	@pageSize		AS int,
	@userId			AS int
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
		)

		SELECT * FROM tx
		WHERE Row BETWEEN ((@PageIndex - 1) * @PageSize + 1)
						AND (@PageIndex * @PageSize) 
END







GO
/****** Object:  StoredProcedure [dbo].[spGetReportTrafficByPlate]    Script Date: 2018-02-18 12:38:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Description:	Show  Traffic By Plate
-- =============================================

CREATE PROCEDURE [dbo].[spGetReportTrafficByPlate] 
	@startDate		AS datetime,
	@endDate		AS datetime,
	@plate			AS varchar(50),
	@pageIndex		AS int,
	@pageSize		AS int,
	@userId			AS int

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

	)
	SELECT * FROM tx
		WHERE Row BETWEEN ((@PageIndex - 1) * @PageSize + 1)
						AND (@PageIndex * @PageSize) 
END




GO
/****** Object:  StoredProcedure [dbo].[spGetReportTrafficCount]    Script Date: 2018-02-18 12:38:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Description:	Show  Count Traffic 
-- =============================================
CREATE PROCEDURE [dbo].[spGetReportTrafficCount]
	@startDate as Datetime,
	@endDate	as Datetime,
	@pageIndex  AS int,
	@pageSize   AS int,
	@userId		AS int
	
AS
BEGIN
	WITH tx 
		AS
		(
			SELECT 
				ROW_NUMBER() OVER( ORDER BY [Owner].id ASC) AS Row,
				COUNT(*) OVER() AS total,
				dbo.[Owner].id,
				dbo.Plate.id as plateId,
				[Owner].name,
				[Owner].lastname, 
				[Owner].nationalCode, 
				[Owner].mobile,
				plate,
				dbo.UHF.name as nameUHF,
				SUM(COUNT(*)) OVER (PARTITION BY plate.id ORDER BY dbo.[Owner].id ASC) AS 'totalTraffic'
		

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
			
			
			
				GROUP BY [Owner].id, [Owner].name, [owner].lastname, [Owner].nationalCode, [Owner].mobile, plate ,dbo.UHF.name, dbo.Plate.id
							
	
				--ORDER BY [Owner].id, [Owner].name, [Owner].lastname, [Owner].nationalCode, [Owner].mobile, plate, dbo.UHF.name, dbo.Plate.id

		)
		SELECT * FROM tx
			WHERE Row BETWEEN ((@PageIndex - 1) * @PageSize + 1)
						AND (@PageIndex * @PageSize) 
END




GO
/****** Object:  StoredProcedure [dbo].[spGetReportTrafficCountByNationalcode]    Script Date: 2018-02-18 12:38:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Description:	Get Traffic count By date and nationalcode
-- =============================================
CREATE PROCEDURE [dbo].[spGetReportTrafficCountByNationalcode]
	@startDate datetime,
	@endDate datetime,
	@nationalcode varchar(10),
	@pageIndex		AS int,
	@pageSize		AS int,
	@userId			AS int
AS
BEGIN	
WITH tx 
		AS
		(
			SELECT 
				ROW_NUMBER() OVER( ORDER BY [Owner].id ASC) AS Row,
				COUNT(*) OVER() AS total,
				dbo.[Owner].id,
				dbo.Plate.id as plateId,
				[Owner].name,
				[Owner].lastname, 
				[Owner].nationalCode, 
				[Owner].mobile,
				plate,
				dbo.UHF.name as nameUHF,
				SUM(COUNT(*)) OVER (PARTITION BY plate.id ORDER BY dbo.[Owner].id ASC) AS 'totalTraffic'

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
						AND nationalCode =  @nationalcode
			
					GROUP BY [Owner].id, [Owner].name, [owner].lastname, [Owner].nationalCode, [owner].mobile, plate, dbo.UHF.name, dbo.Plate.id

			)
			SELECT * FROM tx
				WHERE Row BETWEEN ((@PageIndex - 1) * @PageSize + 1)
						AND (@PageIndex * @PageSize) 
END



GO
/****** Object:  StoredProcedure [dbo].[spGetReportTrafficCountByPlate]    Script Date: 2018-02-18 12:38:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Description:	Get Traffic count By date and plate
-- =============================================
CREATE PROCEDURE [dbo].[spGetReportTrafficCountByPlate]
	@startDate		AS datetime,
	@endDate		AS datetime,
	@plate			AS varchar(50),
	@pageIndex		AS int,
	@pageSize		AS int,
	@userId			AS int
AS
BEGIN	
	WITH tx 
		AS
		(

			SELECT  
				ROW_NUMBER() OVER( ORDER BY [Owner].id ASC) AS Row,
				COUNT(*) OVER() AS total,
				dbo.[Owner].id,
				dbo.Plate.id as plateId,
				[Owner].name,
				[Owner].lastname, 
				[Owner].nationalCode, 
				[Owner].mobile,
				plate,
				dbo.UHF.name as nameUHF,
				SUM(COUNT(*)) OVER (PARTITION BY plate.id ORDER BY dbo.[Owner].id ASC) AS 'totalTraffic'

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
			
						AND plate =  @plate
			
					GROUP BY [Owner].id,[Owner].name, [owner].lastname, [Owner].nationalCode, [owner].mobile, plate, dbo.UHF.name, dbo.Plate.id
		
			)
			SELECT * FROM tx
				WHERE Row BETWEEN ((@PageIndex - 1) * @PageSize + 1)
						AND (@PageIndex * @PageSize) 

	
END



GO
/****** Object:  StoredProcedure [dbo].[spGetTraffic]    Script Date: 2018-02-18 12:38:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Description:	Get Traffic By Date 
-- =============================================
CREATE PROCEDURE [dbo].[spGetTraffic] 

	@startDate	AS datetime,	
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
				(dbo.Traffic.trafficDate BETWEEN @startDate + '00:00:00.000' AND @startDate + '23:59:59.999'	)
				AND
				(dbo.Traffic.uhfId IN (SELECT uhfId FROM dbo.UHFPermit
												WHERE userId = @userId))	
		)
	SELECT top(15) * FROM tx
		
END






GO
/****** Object:  StoredProcedure [dbo].[spGetTrafficSearchByNationalcode]    Script Date: 2018-02-18 12:38:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Description:	Report Traffic by nationalcode
-- =============================================
CREATE PROCEDURE [dbo].[spGetTrafficSearchByNationalcode]
	@nationalCode varchar(10)
AS
BEGIN
	SELECT  
			ROW_NUMBER() OVER(ORDER BY dbo.Traffic.trafficDate DESC) AS Row,
			plate,
			Traffic.trafficDate 

	FROM 
		Plate

			inner join Car				ON Car.plateId			= Plate.id	
			inner join [Base.PlateType] ON [Base.PlateType].id	= Plate.plateTypeId
			inner join [Base.CarColor]	ON [Base.CarColor].id	= Car.carColorId
			inner join [Base.CarType]	ON [Base.CarType].id	= Car.carTypeId
			inner join [Base.PlateCity] ON [Base.PlateCity].id	= Plate.plateCityId
			inner join CarOwner			ON CarOwner.carId		= Car.id
			inner join [Owner]			ON [Owner].id			= CarOwner.ownerId
			inner join CarTag			ON CarTag.carId			= Car.id
			inner join Tag				ON Tag.id				= CarTag.tagId
			inner join Traffic			ON Traffic.tagId		= Tag.id

			WHERE nationalCode = @nationalCode
			GROUP BY plate, Traffic.trafficDate
END



GO
/****** Object:  StoredProcedure [dbo].[spGetTrafficSerachByPlate]    Script Date: 2018-02-18 12:38:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spGetTrafficSerachByPlate]
	@plate varchar(50)
AS
BEGIN
	SELECT 
		ROW_NUMBER() OVER(ORDER BY dbo.Traffic.trafficDate DESC) AS Row,
		plate,
		Traffic.trafficDate 

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

		WHERE plate = @plate
		GROUP BY plate, Traffic.trafficDate
END



GO
/****** Object:  StoredProcedure [dbo].[spOwnerSearchWithCode]    Script Date: 2018-02-18 12:38:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spOwnerSearchWithCode]
	@nationalCode  nvarchar(10)
AS
BEGIN
	SELECT	
				(SELECT plate		FROM Plate				WHERE id = plateId)			AS plate
			,	(SELECT city		FROM [Base.PlateCity]	WHERE id IN 
					(SELECT plateCityId FROM Plate WHERE id IN 
						(SELECT plateId FROM Car  WHERE id IN (Car.id))))				AS cityPlate

			,	(SELECT [type]		FROM [Base.PlateType] WHERE id IN 
					(SELECT plateTypeId FROM Plate WHERE id IN 
						(SELECT plateId FROM Car  WHERE id IN (Car.id))))				AS [typePlate]

			,	(SELECT color		FROM [Base.CarColor]	WHERE id = carColorId )		AS Color
			,	(SELECT fuel		FROM [Base.CarFuel]		WHERE id = carFuelId)		AS Fuel
			,	(SELECT levelcar	FROM [Base.CarLevel]	WHERE id = carLevelId)		AS LevelCar
			,	(SELECT [system]	FROM [Base.CarSystem]	WHERE id = carSystemId)		AS SystemCar
			,	(SELECT [type]		FROM [Base.CarType]		WHERE id = carTypeId)		AS typeCar
						
			FROM Car
				WHERE id IN (
					SELECT carId FROM CarOwner 		WHERE ownerId =
						 (SELECT id FROM [Owner]	WHERE nationalCode = @nationalCode))

END



GO
/****** Object:  StoredProcedure [dbo].[spShowCustomer]    Script Date: 2018-02-18 12:38:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spShowCustomer]	
AS
BEGIN

	SET NOCOUNT ON;
	SELECT 
		ROW_NUMBER() OVER(PARTITION BY [Owner].nationalCode ORDER BY [Owner].id ASC) AS Row, 
		dbo.Owner.name,
		dbo.Owner.lastname,
		dbo.Owner.nationalCode,
		dbo.Owner.mobile,
		dbo.Plate.plate,
		dbo.[Base.PlateCity].city,
		dbo.[Base.PlateType].type ,
		dbo.[Base.CarSystem].system,
		dbo.[Base.CarLevel].levelcar,
		dbo.[Base.CarColor].color,
		dbo.[Base.CarType].type as typeCar,
		dbo.Car.model
	

	FROM  Plate
		INNER JOIN dbo.[Base.PlateType]  ON dbo.[Base.PlateType].id		= dbo.Plate.plateTypeId
		INNER JOIN dbo.[Base.PlateCity]  ON dbo.[Base.PlateCity].id		= dbo.Plate.plateCityId
		INNER JOIN dbo.Car				 ON dbo.Car.plateId				= dbo.Plate.id
		INNER JOIN dbo.[Base.CarColor]	 ON dbo.[Base.CarColor].id		= dbo.Car.carColorId	
		INNER JOIN dbo.[Base.CarLevel]	 ON dbo.[Base.CarLevel].id		= dbo.Car.carLevelId
		INNER JOIN dbo.[Base.CarType]	 ON dbo.[Base.CarType].id		= dbo.Car.carTypeId
		INNER JOIN dbo.[Base.CarSystem]	 ON dbo.[Base.CarSystem].id		= dbo.Car.carSystemId
		INNER JOIN dbo.CarOwner			 ON dbo.CarOwner.carId			= dbo.Car.id
		INNER JOIN dbo.Owner			 ON dbo.Owner.id				= dbo.CarOwner.ownerId		
END



GO
/****** Object:  StoredProcedure [dbo].[spShowCustomerTag]    Script Date: 2018-02-18 12:38:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spShowCustomerTag]

AS
BEGIN
		SET NOCOUNT ON;

		SELECT 
			ROW_NUMBER() OVER(PARTITION BY [Owner].nationalCode ORDER BY [Owner].id ASC) AS Row, 
			Tag.tag,
			Plate.plate,
			Owner.name,
			Owner.lastname,
			Owner.nationalCode,
			Owner.mobile	

		FROM  Tag 
			INNER JOIN CarTag	ON CarTag.tagId		= Tag.id
			INNER JOIN Car		ON Car.id			= CarTag.carId
			INNER JOIN Plate	ON Plate.id			= Car.plateId
			INNER JOIN CarOwner	ON CarOwner.carId	= Car.id
			INNER JOIN Owner	ON Owner.id			= CarOwner.ownerId
END



GO
/****** Object:  StoredProcedure [dbo].[spTrafficDelete]    Script Date: 2018-02-18 12:38:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spTrafficDelete]
(
	@tagId	int
)
AS
BEGIN

	SET NOCOUNT ON;

    
	DELETE FROM 
			[Traffic]
	WHERE
			(tagId = @tagId);

	SELECT @@ROWCOUNT;
END



GO
/****** Object:  StoredProcedure [dbo].[spTrafficRegisterByService]    Script Date: 2018-02-18 12:38:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  PROCEDURE [dbo].[spTrafficRegisterByService]
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





GO
/****** Object:  StoredProcedure [dbo].[spUserDelete]    Script Date: 2018-02-18 12:38:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUserDelete]
(
	@userId	int
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM 
			[User]
	WHERE
			(id = @userId);

	SELECT @@ROWCOUNT;
END



GO
