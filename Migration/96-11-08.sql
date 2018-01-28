USE [GasStation]
GO
/****** Object:  StoredProcedure [dbo].[spGetReportTraffic]    Script Date: 2018-01-28 12:17:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[spGetReportTraffic] 
	@startDate  AS datetime,
	@endDate	AS datetime,
	@pageIndex  AS int,
	@pageSize   AS int
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
			dbo.Traffic.trafficDate

			FROM

			dbo.Traffic

			inner join dbo.Tag			on dbo.Tag.id			= dbo.Traffic.tagId 
			inner join dbo.CarTag		on dbo.CarTag.tagId		=  dbo.Traffic.tagId
			inner join dbo.Car			on dbo.Car.id			= dbo.CarTag.carId
			inner join dbo.Plate		on dbo.Plate.id			= dbo.Car.plateId
			inner join dbo.CarOwner		on dbo.CarOwner.carId	= dbo.Car.id
			inner join dbo.Owner		on dbo.Owner.id			= dbo.CarOwner.ownerId

			 WHERE 
				dbo.Traffic.trafficDate BETWEEN @startDate + '00:00:00.000' AND @endDate + '23:59:59.999'	
		)
	SELECT * FROM tx
		WHERE Row BETWEEN ((@PageIndex - 1) * @PageSize + 1)
						AND (@PageIndex * @PageSize) 
END

