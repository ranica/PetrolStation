USE [GasStation]
GO
/****** Object:  Table [dbo].[Base.CarColor]    Script Date: 2018-03-28 11:47:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Base.CarColor](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL CONSTRAINT [DF_Base.CarColor_viewId]  DEFAULT (newid()),
	[color] [varchar](50) NOT NULL,
	[insertedById] [int] NOT NULL,
	[insertDate] [datetime] NOT NULL,
	[updatedById] [int] NULL,
	[updateDate] [datetime] NULL,
 CONSTRAINT [PK_Base.CarColor] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Base.CarFuel]    Script Date: 2018-03-28 11:47:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Base.CarFuel](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL CONSTRAINT [DF_Base.CarFuel_viewId]  DEFAULT (newid()),
	[fuel] [varchar](50) NOT NULL,
	[insertedById] [int] NOT NULL,
	[insertDate] [datetime] NOT NULL,
	[updatedById] [int] NULL,
	[updateDate] [datetime] NULL,
 CONSTRAINT [PK_Base.CarFuel] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Base.CarLevel]    Script Date: 2018-03-28 11:47:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Base.CarLevel](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL CONSTRAINT [DF_Base.CarLevel_viewId]  DEFAULT (newid()),
	[levelcar] [varchar](50) NOT NULL,
	[insertedById] [int] NOT NULL,
	[insertDate] [datetime] NOT NULL,
	[updatedById] [int] NULL,
	[updateDate] [datetime] NULL,
 CONSTRAINT [PK_Base.CarLevel] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Base.CarSystem]    Script Date: 2018-03-28 11:47:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Base.CarSystem](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL CONSTRAINT [DF_Base.CarModel_viewId]  DEFAULT (newid()),
	[system] [varchar](50) NOT NULL,
	[insertedById] [int] NOT NULL,
	[insertDate] [datetime] NOT NULL,
	[updatedById] [int] NULL,
	[updateDate] [datetime] NULL,
 CONSTRAINT [PK_Base.CarModel] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Base.CarType]    Script Date: 2018-03-28 11:47:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Base.CarType](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL CONSTRAINT [DF_Base.CarType_viewId]  DEFAULT (newid()),
	[type] [varchar](50) NOT NULL,
	[insertedById] [int] NOT NULL,
	[insertDate] [datetime] NOT NULL,
	[updatedById] [int] NULL,
	[updateDate] [datetime] NULL,
 CONSTRAINT [PK_Base.CarType] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Base.GridHeader]    Script Date: 2018-03-28 11:47:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Base.GridHeader](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL CONSTRAINT [DF_Base.GridHeader_viewId]  DEFAULT (newid()),
	[name] [varchar](255) NOT NULL,
	[data] [text] NOT NULL,
 CONSTRAINT [PK_Base.GridHeader] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Base.Month]    Script Date: 2018-03-28 11:47:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Base.Month](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL CONSTRAINT [DF_Base.Month_viewId]  DEFAULT (newid()),
	[code] [int] NULL,
	[month] [varchar](50) NULL,
	[insertedById] [int] NULL,
	[insertDate] [datetime] NULL,
	[updatedById] [int] NULL,
	[updateDate] [datetime] NULL,
 CONSTRAINT [PK_Base.Month] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Base.PlateCity]    Script Date: 2018-03-28 11:47:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Base.PlateCity](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL CONSTRAINT [DF_Base.PlateCity_viewId]  DEFAULT (newid()),
	[code] [varchar](3) NOT NULL,
	[city] [varchar](50) NOT NULL,
	[insertedById] [int] NOT NULL,
	[insertDate] [datetime] NOT NULL CONSTRAINT [DF_Base.PlateCity_insertDate]  DEFAULT (getdate()),
	[updatedById] [int] NULL,
	[updateDate] [datetime] NULL,
 CONSTRAINT [PK_Base.PlateCity] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Base.PlateCountry]    Script Date: 2018-03-28 11:47:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Base.PlateCountry](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL CONSTRAINT [DF_Base.PlateCountry_viewId]  DEFAULT (newid()),
	[country] [varchar](50) NOT NULL,
	[insertedById] [int] NOT NULL,
	[insertDate] [datetime] NOT NULL,
	[updatedById] [int] NULL,
	[updateDate] [datetime] NULL,
 CONSTRAINT [PK_Base.PlateCountry] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Base.PlateType]    Script Date: 2018-03-28 11:47:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Base.PlateType](
	[id] [int] IDENTITY(10,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL CONSTRAINT [DF_Base.PlateType_viewId]  DEFAULT (newid()),
	[type] [varchar](50) NOT NULL,
	[insertedById] [int] NOT NULL,
	[insertDate] [datetime] NOT NULL,
	[updatedById] [int] NULL,
	[updateDate] [datetime] NULL,
 CONSTRAINT [PK_Base.PlateType] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Car]    Script Date: 2018-03-28 11:47:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Car](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL CONSTRAINT [DF_Car_viewId]  DEFAULT (newid()),
	[carTypeId] [int] NOT NULL,
	[carColorId] [int] NOT NULL,
	[carSystemId] [int] NOT NULL,
	[carLevelId] [int] NOT NULL,
	[carFuelId] [int] NOT NULL,
	[plateId] [int] NOT NULL,
	[model] [varchar](5) NOT NULL,
	[status] [bit] NOT NULL,
	[capacity] [smallint] NOT NULL CONSTRAINT [DF_Car_capacity]  DEFAULT ((0)),
	[chasisCode] [varchar](50) NOT NULL,
	[engineCode] [varchar](50) NOT NULL,
	[insertedById] [int] NOT NULL,
	[insertDate] [datetime] NOT NULL,
	[updatedById] [int] NULL,
	[updateDate] [datetime] NULL,
 CONSTRAINT [PK_Car] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CarOwner]    Script Date: 2018-03-28 11:47:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarOwner](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL CONSTRAINT [DF_CarOwner_viewId]  DEFAULT (newid()),
	[carId] [int] NOT NULL,
	[ownerId] [int] NOT NULL,
	[type] [bit] NOT NULL,
	[insertedById] [int] NOT NULL,
	[insertDate] [datetime] NOT NULL,
	[updatedById] [int] NULL,
	[updateDate] [datetime] NULL,
 CONSTRAINT [PK_CarOwner] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CarTag]    Script Date: 2018-03-28 11:47:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarTag](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL CONSTRAINT [DF_CarTag_viewId]  DEFAULT (newid()),
	[carId] [int] NOT NULL,
	[tagId] [int] NOT NULL,
	[insertedById] [int] NOT NULL,
	[insertDate] [date] NOT NULL,
	[updatedById] [int] NULL,
	[updateDate] [date] NULL,
 CONSTRAINT [PK_CarTag] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Error]    Script Date: 2018-03-28 11:47:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Error](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NULL CONSTRAINT [DF_Error_viewId]  DEFAULT (newid()),
	[error] [text] NULL,
	[eSource] [text] NULL,
	[eInnerExecption] [text] NULL,
	[eStackTrace] [text] NULL,
	[eTargetSite] [text] NULL,
	[eTargetSiteName] [text] NULL,
	[eTargetSiteModule] [text] NULL,
	[eDate] [datetime] NULL,
 CONSTRAINT [PK_Error] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HC.Sexuality]    Script Date: 2018-03-28 11:47:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HC.Sexuality](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL CONSTRAINT [DF_HC.Sexuality_viewId]  DEFAULT (newid()),
	[gen] [varchar](50) NOT NULL,
 CONSTRAINT [PK_HC.Sexuality] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LegalOwner]    Script Date: 2018-03-28 11:47:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LegalOwner](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL,
	[carOwnerId] [int] NOT NULL,
	[OrganizationCode] [varchar](50) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[insertedById] [int] NOT NULL,
	[insertDate] [datetime] NOT NULL,
	[updatedById] [int] NULL,
	[updateDate] [datetime] NULL,
 CONSTRAINT [PK_LegalOwner] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Lottery]    Script Date: 2018-03-28 11:47:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lottery](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NULL CONSTRAINT [DF_Lottery_viewId]  DEFAULT (newid()),
	[ownerId] [int] NULL,
	[startDate] [datetime] NULL,
	[endDate] [datetime] NULL,
	[lotteryDate] [datetime] NULL,
	[total] [int] NULL,
	[month] [nvarchar](50) NULL,
	[insertedById] [int] NULL,
	[insertDate] [datetime] NULL,
	[updatedById] [int] NULL,
	[updateDate] [datetime] NULL,
 CONSTRAINT [PK_Lottery] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Owner]    Script Date: 2018-03-28 11:47:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Owner](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL CONSTRAINT [DF_Owner_viewId]  DEFAULT (newid()),
	[nationalCode] [varchar](10) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[lastname] [varchar](50) NOT NULL,
	[birthdate] [date] NULL,
	[birthdatelocal] [varchar](50) NULL,
	[gen] [int] NULL,
	[phone] [varchar](50) NULL,
	[mobile] [varchar](50) NOT NULL,
	[address] [varchar](50) NULL,
	[insertedById] [int] NOT NULL,
	[insertDate] [datetime] NOT NULL,
	[updatedById] [int] NULL,
	[updateDate] [datetime] NULL,
 CONSTRAINT [PK_Owner] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Plate]    Script Date: 2018-03-28 11:47:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Plate](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL CONSTRAINT [DF_Plate_viewId]  DEFAULT (newid()),
	[plateTypeId] [int] NOT NULL,
	[plateCityId] [int] NOT NULL,
	[plate] [varchar](50) NOT NULL,
	[insertedById] [int] NOT NULL,
	[insertDate] [datetime] NOT NULL,
	[updatedById] [int] NULL,
	[updateDate] [datetime] NULL,
 CONSTRAINT [PK_Plate] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[System.Data]    Script Date: 2018-03-28 11:47:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[System.Data](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL CONSTRAINT [DF_System_Data_viewId]  DEFAULT (newid()),
	[name] [varchar](50) NOT NULL,
	[value] [text] NOT NULL,
 CONSTRAINT [PK_System_Data] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tag]    Script Date: 2018-03-28 11:47:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tag](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL CONSTRAINT [DF_Tag_viewId]  DEFAULT (newid()),
	[tag] [varchar](50) NOT NULL,
	[insertedById] [int] NOT NULL,
	[insertDate] [datetime] NOT NULL,
	[updatedById] [int] NULL,
	[updateDate] [datetime] NULL,
 CONSTRAINT [PK_Tag] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Traffic]    Script Date: 2018-03-28 11:47:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Traffic](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL CONSTRAINT [DF_Traffic_viewId]  DEFAULT (newid()),
	[tagId] [int] NOT NULL,
	[uhfId] [int] NULL,
	[trafficDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Traffic] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UHF]    Script Date: 2018-03-28 11:47:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UHF](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL CONSTRAINT [DF_UHF_viewId]  DEFAULT (newid()),
	[name] [varchar](50) NULL,
	[IP] [varchar](15) NOT NULL,
	[Port] [int] NOT NULL,
	[netStatus] [bit] NULL,
	[serviceStatus] [varchar](50) NULL,
	[insertedById] [int] NOT NULL,
	[insertDate] [datetime] NOT NULL,
	[updatedById] [int] NULL,
	[updateDate] [datetime] NULL,
 CONSTRAINT [PK_UHF] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UHFPermit]    Script Date: 2018-03-28 11:47:20 AM ******/
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
/****** Object:  Table [dbo].[User]    Script Date: 2018-03-28 11:47:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL CONSTRAINT [DF_User_viewId]  DEFAULT (newid()),
	[name] [varchar](50) NOT NULL,
	[lastname] [varchar](50) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[inserted] [datetime] NOT NULL CONSTRAINT [DF_User_createdate]  DEFAULT (getdate()),
	[enable] [tinyint] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[viewCustomer]    Script Date: 2018-03-28 11:47:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[viewCustomer]
AS
SELECT dbo.Car.id AS idCar, dbo.Owner.id, dbo.Owner.viewId, dbo.Owner.nationalCode, dbo.Owner.name, dbo.Owner.lastname, dbo.Owner.mobile, dbo.Plate.plate, dbo.[Base.PlateCity].city, dbo.[Base.PlateType].type, 
                  dbo.[Base.CarSystem].system, dbo.[Base.CarLevel].levelcar, dbo.[Base.CarColor].color, dbo.[Base.CarType].type AS typeCar
FROM     dbo.[Base.CarLevel] INNER JOIN
                  dbo.Plate INNER JOIN
                  dbo.Car ON dbo.Plate.id = dbo.Car.plateId INNER JOIN
                  dbo.[Base.PlateType] ON dbo.Plate.plateTypeId = dbo.[Base.PlateType].id INNER JOIN
                  dbo.[Base.PlateCity] ON dbo.Plate.plateCityId = dbo.[Base.PlateCity].id INNER JOIN
                  dbo.[Base.CarType] ON dbo.Car.carTypeId = dbo.[Base.CarType].id INNER JOIN
                  dbo.[Base.CarSystem] ON dbo.Car.carSystemId = dbo.[Base.CarSystem].id ON dbo.[Base.CarLevel].id = dbo.Car.carLevelId INNER JOIN
                  dbo.[Base.CarColor] ON dbo.Car.carColorId = dbo.[Base.CarColor].id INNER JOIN
                  dbo.CarOwner ON dbo.Car.id = dbo.CarOwner.carId INNER JOIN
                  dbo.Owner ON dbo.CarOwner.ownerId = dbo.Owner.id



GO
/****** Object:  View [dbo].[viwReportTraffic]    Script Date: 2018-03-28 11:47:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE view [dbo].[viwReportTraffic]
as

	SELECT 
		ROW_NUMBER() OVER(ORDER BY dbo.Traffic.trafficDate DESC) AS Row,
		dbo.Owner.name, 
		dbo.Owner.lastname,
		dbo.Owner.mobile,
		dbo.Plate.plate,		
		dbo.Traffic.trafficDate,
		dbo.Owner.nationalCode

		FROM

		dbo.Traffic

		inner join dbo.Tag			on dbo.Tag.id			= dbo.Traffic.tagId 
		inner join dbo.CarTag		on dbo.CarTag.tagId		= dbo.Traffic.tagId
		inner join dbo.Car			on dbo.Car.id			= dbo.CarTag.carId
		inner join dbo.Plate		on dbo.Plate.id			= dbo.Car.plateId
		inner join dbo.CarOwner		on dbo.CarOwner.carId	= dbo.Car.id
		inner join dbo.Owner		on dbo.Owner.id			= dbo.CarOwner.ownerId

GO
SET IDENTITY_INSERT [dbo].[Base.CarColor] ON 

INSERT [dbo].[Base.CarColor] ([id], [viewId], [color], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (14, N'62edce5b-5a90-44f5-bc1a-21bc6a799a16', N'قرمز', 2, CAST(N'2017-02-02 12:53:09.390' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.CarColor] ([id], [viewId], [color], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (15, N'869d20bd-e964-4005-9bbc-7075c3b9f767', N'سفيد', 2, CAST(N'2017-03-23 11:11:38.750' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Base.CarColor] OFF
SET IDENTITY_INSERT [dbo].[Base.CarFuel] ON 

INSERT [dbo].[Base.CarFuel] ([id], [viewId], [fuel], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (7, N'dd1a7a3a-cf0f-4581-b3f9-d5e07a82b43c', N'گاز', 2, CAST(N'2016-11-25 15:19:56.077' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.CarFuel] ([id], [viewId], [fuel], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (8, N'993c16fd-0858-4909-9a1d-64c0186a2f93', N'بنزين', 2, CAST(N'2016-11-25 15:20:17.687' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Base.CarFuel] OFF
SET IDENTITY_INSERT [dbo].[Base.CarLevel] ON 

INSERT [dbo].[Base.CarLevel] ([id], [viewId], [levelcar], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (7, N'f1263c84-e61e-4ae5-85bd-7e8b9ba267d4', N'سواري', 2, CAST(N'2017-02-02 12:53:23.970' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Base.CarLevel] OFF
SET IDENTITY_INSERT [dbo].[Base.CarSystem] ON 

INSERT [dbo].[Base.CarSystem] ([id], [viewId], [system], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (9, N'e4d7120a-e229-42fd-bc0e-70ecca23def9', N'پژو', 2, CAST(N'2017-02-02 12:52:59.703' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.CarSystem] ([id], [viewId], [system], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (10, N'59285d6e-6442-4d64-a734-448a787c1210', N'206', 2, CAST(N'2017-03-28 17:43:40.050' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Base.CarSystem] OFF
SET IDENTITY_INSERT [dbo].[Base.CarType] ON 

INSERT [dbo].[Base.CarType] ([id], [viewId], [type], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (3, N'3db513b9-06d5-4999-8c14-dd75f866d38f', N'سواري', 2, CAST(N'2016-11-30 16:19:40.897' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.CarType] ([id], [viewId], [type], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (4, N'b1ebb5e5-8a13-4b83-b333-7dae975fe0c0', N'وانت', 2, CAST(N'2016-11-30 17:11:51.300' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.CarType] ([id], [viewId], [type], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (5, N'96da2cae-a388-4095-9826-ce711e668db8', N'نيسان', 2, CAST(N'2016-11-30 17:11:55.667' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Base.CarType] OFF
SET IDENTITY_INSERT [dbo].[Base.GridHeader] ON 

INSERT [dbo].[Base.GridHeader] ([id], [viewId], [name], [data]) VALUES (39, N'f4d15279-f495-473a-93bd-3ac4075b9a39', N'CarColorForm', N'{"columns":[{"field":"id","caption":"id","visible":false,"readOnly":true,"position":0,"width":150},{"field":"viewId","caption":"viewId","visible":false,"readOnly":true,"position":0,"width":150},{"field":"insertedById","caption":"insertedById","visible":false,"readOnly":true,"position":0,"width":150},{"field":"insertDate","caption":"insertDate","visible":false,"readOnly":true,"position":0,"width":150},{"field":"updatedById","caption":"updatedById","visible":false,"readOnly":true,"position":0,"width":150},{"field":"updateDate","caption":"updateDate","visible":false,"readOnly":true,"position":0,"width":150},{"field":"color","caption":"رنگ","visible":true,"readOnly":true,"position":1,"width":150}]}')
INSERT [dbo].[Base.GridHeader] ([id], [viewId], [name], [data]) VALUES (40, N'39943fd2-d2d1-46ff-b46d-2b980bf00bba', N'CarLevelForm', N'{"columns":[{"field":"id","caption":"id","visible":false,"readOnly":true,"position":0,"width":150},{"field":"viewId","caption":"viewId","visible":false,"readOnly":true,"position":0,"width":150},{"field":"insertedById","caption":"insertedById","visible":false,"readOnly":true,"position":0,"width":150},{"field":"insertDate","caption":"insertDate","visible":false,"readOnly":true,"position":0,"width":150},{"field":"updatedById","caption":"updatedById","visible":false,"readOnly":true,"position":0,"width":150},{"field":"updateDate","caption":"updateDate","visible":false,"readOnly":true,"position":0,"width":150},{"field":"levelcar","caption":"تيپ","visible":true,"readOnly":true,"position":1,"width":150}]}')
INSERT [dbo].[Base.GridHeader] ([id], [viewId], [name], [data]) VALUES (41, N'bb4a1a6a-5d97-4812-ac08-15eac41b87b2', N'CarFuelForm', N'{"columns":[{"field":"id","caption":"id","visible":false,"readOnly":true,"position":0,"width":150},{"field":"viewId","caption":"viewId","visible":false,"readOnly":true,"position":0,"width":150},{"field":"insertedById","caption":"insertedById","visible":false,"readOnly":true,"position":0,"width":150},{"field":"insertDate","caption":"insertDate","visible":false,"readOnly":true,"position":0,"width":150},{"field":"updatedById","caption":"updatedById","visible":false,"readOnly":true,"position":0,"width":150},{"field":"updateDate","caption":"updateDate","visible":false,"readOnly":true,"position":0,"width":150},{"field":"fuel","caption":"سوخت","visible":true,"readOnly":true,"position":1,"width":150}]}')
INSERT [dbo].[Base.GridHeader] ([id], [viewId], [name], [data]) VALUES (42, N'27d6ea16-3dc1-49d5-87c4-e3f760307c64', N'CarSystemForm', N'{"columns":[{"field":"id","caption":"id","visible":false,"readOnly":true,"position":0,"width":150},{"field":"viewId","caption":"viewId","visible":false,"readOnly":true,"position":0,"width":150},{"field":"insertedById","caption":"insertedById","visible":false,"readOnly":true,"position":0,"width":150},{"field":"insertDate","caption":"insertDate","visible":false,"readOnly":true,"position":0,"width":150},{"field":"updatedById","caption":"updatedById","visible":false,"readOnly":true,"position":0,"width":150},{"field":"updateDate","caption":"updateDate","visible":false,"readOnly":true,"position":0,"width":150},{"field":"system","caption":"سيستم خودرو","visible":true,"readOnly":true,"position":1,"width":150}]}')
INSERT [dbo].[Base.GridHeader] ([id], [viewId], [name], [data]) VALUES (43, N'8d8c1f75-bd58-49f2-9f2a-d90b548f0821', N'CarTypeForm', N'{"columns":[{"field":"id","caption":"id","visible":false,"readOnly":true,"position":0,"width":150},{"field":"viewId","caption":"viewId","visible":false,"readOnly":true,"position":0,"width":150},{"field":"insertedById","caption":"insertedById","visible":false,"readOnly":true,"position":0,"width":150},{"field":"insertDate","caption":"insertDate","visible":false,"readOnly":true,"position":0,"width":150},{"field":"updatedById","caption":"updatedById","visible":false,"readOnly":true,"position":0,"width":150},{"field":"updateDate","caption":"updateDate","visible":false,"readOnly":true,"position":0,"width":150},{"field":"type","caption":"نوع خودرو","visible":true,"readOnly":true,"position":1,"width":150}]}')
INSERT [dbo].[Base.GridHeader] ([id], [viewId], [name], [data]) VALUES (44, N'e53e0824-381d-4997-86a5-64bafdec891f', N'PlateTypeForm', N'{"columns":[{"field":"id","caption":"id","visible":false,"readOnly":true,"position":0,"width":150},{"field":"viewId","caption":"viewId","visible":false,"readOnly":true,"position":0,"width":150},{"field":"insertedById","caption":"insertedById","visible":false,"readOnly":true,"position":0,"width":150},{"field":"insertDate","caption":"insertDate","visible":false,"readOnly":true,"position":0,"width":150},{"field":"updatedById","caption":"updatedById","visible":false,"readOnly":true,"position":0,"width":150},{"field":"updateDate","caption":"updateDate","visible":false,"readOnly":true,"position":0,"width":150},{"field":"type","caption":"نوع پلاک","visible":true,"readOnly":true,"position":1,"width":150}]}')
INSERT [dbo].[Base.GridHeader] ([id], [viewId], [name], [data]) VALUES (45, N'f7f108d1-356b-4bcd-87e2-daf4754461a5', N'PlateCityForm', N'{"columns":[{"field":"id","caption":"id","visible":false,"readOnly":true,"position":0,"width":150},{"field":"viewId","caption":"viewId","visible":false,"readOnly":true,"position":0,"width":150},{"field":"insertedById","caption":"insertedById","visible":false,"readOnly":true,"position":0,"width":150},{"field":"insertDate","caption":"insertDate","visible":false,"readOnly":true,"position":0,"width":150},{"field":"updatedById","caption":"updatedById","visible":false,"readOnly":true,"position":0,"width":150},{"field":"updateDate","caption":"updateDate","visible":false,"readOnly":true,"position":0,"width":150},{"field":"city","caption":"شهر","visible":true,"readOnly":true,"position":1,"width":150},{"field":"code","caption":"کد استان","visible":true,"readOnly":true,"position":1,"width":150}]}')
INSERT [dbo].[Base.GridHeader] ([id], [viewId], [name], [data]) VALUES (46, N'31517398-3d96-4410-935a-1d864e822c8e', N'CustomerViewForm', N'{"columns":[{"field":"id","caption":"id","visible":false,"readOnly":true,"position":0,"width":150},{"field":"viewId","caption":"viewId","visible":false,"readOnly":true,"position":0,"width":150},{"field":"idCar","caption":"idCar","visible":false,"readOnly":true,"position":0,"width":150},{"field":"nationalCode","caption":"کد ملي","visible":true,"readOnly":true,"position":1,"width":150},{"field":"name","caption":"نام","visible":true,"readOnly":true,"position":2,"width":150},{"field":"lastname","caption":"نام خانوادگي","visible":true,"readOnly":true,"position":3,"width":150},{"field":"mobile","caption":"موبايل","visible":true,"readOnly":true,"position":4,"width":150},{"field":"plate","caption":"شماره پلاک","visible":true,"readOnly":true,"position":5,"width":150},{"field":"type","caption":"نوع پلاک","visible":true,"readOnly":true,"position":6,"width":150},{"field":"city","caption":"شهر پلاک","visible":true,"readOnly":true,"position":7,"width":150},{"field":"typeCar","caption":"نوع خودرو","visible":true,"readOnly":true,"position":8,"width":150},{"field":"system","caption":"سيستم خودرو","visible":true,"readOnly":true,"position":9,"width":150},{"field":"color","caption":"رنگ خودرو","visible":true,"readOnly":true,"position":10,"width":150},{"field":"levelcar","caption":"تيپ خودرو","visible":true,"readOnly":true,"position":11,"width":150},{"field":"model","caption":"مدل خودرو","visible":true,"readOnly":true,"position":12,"width":150}]}')
INSERT [dbo].[Base.GridHeader] ([id], [viewId], [name], [data]) VALUES (47, N'b715adbe-e1de-4efb-a5d0-5405a616c601', N'ReportTrafficForm', N'{"columns":[{"field":"id","caption":"id","visible":false,"readOnly":true,"position":0,"width":150},{"field":"name","caption":"نام","visible":true,"readOnly":true,"position":1,"width":150},{"field":"lastname","caption":"نام خانوادگي","visible":true,"readOnly":true,"position":2,"width":150},{"field":"mobile","caption":"موبايل","visible":true,"readOnly":true,"position":3,"width":150},{"field":"plate","caption":"شماره پلاک","visible":true,"readOnly":true,"position":4,"width":150},{"field":"trafficDate","caption":"تاريخ تردد","visible":false,"readOnly":true,"position":5,"width":150},{"field":"trafficDate_Shamsi","caption":"تاريخ تردد","visible":true,"readOnly":true,"position":6,"width":150}]}')
INSERT [dbo].[Base.GridHeader] ([id], [viewId], [name], [data]) VALUES (48, N'955e45a7-3a03-477a-840e-8141c40ed7f2', N'CustomerViewForm_Search', N'{"columns":[{"field":"id","caption":"id","visible":false,"readOnly":true,"position":0,"width":150},{"field":"viewId","caption":"viewId","visible":false,"readOnly":true,"position":0,"width":150},{"field":"gen","caption":"gen","visible":false,"readOnly":true,"position":0,"width":150},{"field":"insertedById","caption":"insertedById","visible":false,"readOnly":true,"position":0,"width":150},{"field":"insertDate","caption":"insertDate","visible":false,"readOnly":true,"position":0,"width":150},{"field":"updatedById","caption":"updatedById","visible":false,"readOnly":true,"position":0,"width":150},{"field":"updateDate","caption":"updateDate","visible":false,"readOnly":true,"position":0,"width":150},{"field":"nationalCode","caption":"کد ملي","visible":true,"readOnly":true,"position":1,"width":150},{"field":"name","caption":"نام","visible":true,"readOnly":true,"position":2,"width":150},{"field":"lastname","caption":"نام خانوادگي","visible":true,"readOnly":true,"position":3,"width":150},{"field":"mobile","caption":"موبايل","visible":true,"readOnly":true,"position":4,"width":150},{"field":"birthdate","caption":"تاريخ تولد","visible":true,"readOnly":true,"position":4,"width":150},{"field":"birthdatelocal","caption":"محل تولد","visible":false,"readOnly":true,"position":5,"width":150},{"field":"phone","caption":"تلفن","visible":true,"readOnly":true,"position":6,"width":150},{"field":"address","caption":"آدرس","visible":true,"readOnly":true,"position":6,"width":150}]}')
INSERT [dbo].[Base.GridHeader] ([id], [viewId], [name], [data]) VALUES (49, N'5de5ebee-2f51-46d2-b62d-31855a6e9aaf', N'OwnerUserControl', N'{"columns":[{"field":"id","caption":"id","visible":false,"readOnly":true,"position":0,"width":150},{"field":"viewId","caption":"viewId","visible":false,"readOnly":true,"position":0,"width":150},{"field":"gen","caption":"gen","visible":false,"readOnly":true,"position":0,"width":150},{"field":"insertedById","caption":"insertedById","visible":false,"readOnly":true,"position":0,"width":150},{"field":"insertDate","caption":"insertDate","visible":false,"readOnly":true,"position":0,"width":150},{"field":"updatedById","caption":"updatedById","visible":false,"readOnly":true,"position":0,"width":150},{"field":"updateDate","caption":"updateDate","visible":false,"readOnly":true,"position":0,"width":150},{"field":"nationalCode","caption":"کد ملي","visible":true,"readOnly":true,"position":1,"width":150},{"field":"name","caption":"نام","visible":true,"readOnly":true,"position":2,"width":150},{"field":"lastname","caption":"نام خانوادگي","visible":true,"readOnly":true,"position":3,"width":150},{"field":"mobile","caption":"موبايل","visible":true,"readOnly":true,"position":4,"width":150},{"field":"birthdate","caption":"تاريخ تولد","visible":true,"readOnly":true,"position":4,"width":150},{"field":"birthdatelocal","caption":"محل تولد","visible":false,"readOnly":true,"position":5,"width":150},{"field":"phone","caption":"تلفن","visible":true,"readOnly":true,"position":6,"width":150},{"field":"address","caption":"آدرس","visible":true,"readOnly":true,"position":6,"width":150}]}')
INSERT [dbo].[Base.GridHeader] ([id], [viewId], [name], [data]) VALUES (50, N'286d6e5d-36a7-43c5-93a8-02df01e2cc1b', N'CarUserControl', N'{"columns":[{"field":"carType","caption":"نوع خودرو","visible":true,"readOnly":true,"position":0,"width":150},{"field":"color","caption":"رنگ خودرو","visible":true,"readOnly":true,"position":1,"width":150},{"field":"plate","caption":"شماره پلاک","visible":true,"readOnly":true,"position":2,"width":150},{"field":"city","caption":"شهر پلاک","visible":true,"readOnly":true,"position":3,"width":150},{"field":"platetype","caption":"نوع پلاک","visible":true,"readOnly":true,"position":4,"width":150},{"field":"tag","caption":"شماره برچسب","visible":true,"readOnly":true,"position":5,"width":150}]}')
INSERT [dbo].[Base.GridHeader] ([id], [viewId], [name], [data]) VALUES (51, N'3208ab02-d459-4e65-9e63-a9a9ae5f742d', N'TrafficUserControl', N'{"columns":[{"field":"trafficDate","caption":"تاريخ تردد","visible":false,"readOnly":true,"position":0,"width":150},{"field":"Row","caption":"رديف","visible":true,"readOnly":true,"position":1,"width":60},{"field":"plate","caption":"شماره پلاک","visible":true,"readOnly":true,"position":2,"width":150},{"field":"trafficDate_Shamsi","caption":"تاريخ تردد","visible":true,"readOnly":true,"position":3,"width":250}]}')
INSERT [dbo].[Base.GridHeader] ([id], [viewId], [name], [data]) VALUES (52, N'6b3f9d85-7a5b-4442-8a71-f1c8205c6dd2', N'StateTrafficUserControl', N'{"columns":[{"field":"trafficDate","caption":"تاريخ تردد","visible":false,"readOnly":true,"position":0,"width":150},{"field":"total","caption":"کل رکورد ها","visible":false,"readOnly":true,"position":0,"width":150},{"field":"Row","caption":"رديف","visible":true,"readOnly":true,"position":0,"width":60},{"field":"name","caption":"نام","visible":true,"readOnly":true,"position":1,"width":100},{"field":"lastname","caption":"نام خانوادگي","visible":true,"readOnly":true,"position":2,"width":120},{"field":"plate","caption":"شماره پلاک","visible":true,"readOnly":true,"position":3,"width":120},{"field":"trafficDate_Shamsi","caption":"تاريخ تردد","visible":true,"readOnly":true,"position":4,"width":180},{"field":"nameUHF","caption":"نام جايگاه","visible":true,"readOnly":true,"position":5,"width":80},{"field":"nationalCode","caption":"کد ملي","visible":true,"readOnly":true,"position":6,"width":100},{"field":"mobile","caption":"موبايل","visible":true,"readOnly":true,"position":7,"width":100}]}')
INSERT [dbo].[Base.GridHeader] ([id], [viewId], [name], [data]) VALUES (53, N'4822a74b-1636-4b28-a0c2-a71f29258328', N'CountTrafficUserControl', N'{"columns":[{"field":"id","caption":"id","visible":false,"readOnly":true,"position":0,"width":60},{"field":"total","caption":"کل رکوردها","visible":false,"readOnly":true,"position":0,"width":60},{"field":"plateId","caption":"کد پلاک","visible":false,"readOnly":true,"position":0,"width":60},{"field":"Row","caption":"رديف","visible":true,"readOnly":true,"position":0,"width":60},{"field":"name","caption":"نام","visible":true,"readOnly":true,"position":1,"width":100},{"field":"lastname","caption":"نام خانوادگي","visible":true,"readOnly":true,"position":2,"width":100},{"field":"nationalCode","caption":"کد ملي","visible":true,"readOnly":true,"position":3,"width":100},{"field":"mobile","caption":"موبايل","visible":true,"readOnly":true,"position":4,"width":100},{"field":"plate","caption":"شماره پلاک","visible":true,"readOnly":true,"position":5,"width":100},{"field":"nameUHF","caption":"نام جايگاه","visible":true,"readOnly":true,"position":6,"width":100},{"field":"totalTraffic","caption":"تعداد تردد ها","visible":true,"readOnly":true,"position":7,"width":100}]}')
INSERT [dbo].[Base.GridHeader] ([id], [viewId], [name], [data]) VALUES (54, N'5bbfca62-77b8-4071-afea-80707c31fd3a', N'LotteryForm', N'{"columns":[{"field":"Row","caption":"رديف","visible":true,"readOnly":true,"position":0,"width":60},{"field":"name","caption":"نام","visible":true,"readOnly":true,"position":1,"width":100},{"field":"lastname","caption":"نام خانوادگي","visible":true,"readOnly":true,"position":2,"width":100},{"field":"nationalCode","caption":"کد ملي","visible":true,"readOnly":true,"position":3,"width":100},{"field":"mobile","caption":"موبايل","visible":true,"readOnly":true,"position":4,"width":100},{"field":"plate","caption":"شماره پلاک","visible":true,"readOnly":true,"position":5,"width":100},{"field":"month","caption":"ماه قرعه کشي","visible":true,"readOnly":true,"position":6,"width":150},{"field":"total","caption":"تعداد تردد ها","visible":true,"readOnly":true,"position":7,"width":100}]}')
INSERT [dbo].[Base.GridHeader] ([id], [viewId], [name], [data]) VALUES (55, N'eb6b748d-176b-48a5-abfa-d1577bbfe05c', N'DashboardUserControl', N'{"columns":[{"field":"trafficDate","caption":"تاريخ تردد","visible":false,"readOnly":true,"position":0,"width":150},{"field":"total","caption":"کل رکورد ها","visible":false,"readOnly":true,"position":0,"width":150},{"field":"nameUHF","caption":"نام جايگاه","visible":false,"readOnly":true,"position":0,"width":80},{"field":"nationalCode","caption":"کد ملي","visible":false,"readOnly":true,"position":0,"width":100},{"field":"Row","caption":"رديف","visible":true,"readOnly":true,"position":0,"width":50},{"field":"name","caption":"نام","visible":true,"readOnly":true,"position":1,"width":100},{"field":"lastname","caption":"نام خانوادگي","visible":true,"readOnly":true,"position":2,"width":115},{"field":"plate","caption":"شماره پلاک","visible":true,"readOnly":true,"position":3,"width":105},{"field":"trafficDate_Shamsi","caption":"تاريخ تردد","visible":true,"readOnly":true,"position":4,"width":170},{"field":"mobile","caption":"موبايل","visible":true,"readOnly":true,"position":5,"width":100}]}')
INSERT [dbo].[Base.GridHeader] ([id], [viewId], [name], [data]) VALUES (56, N'630f0f0b-f23f-435f-a855-3f48071ecb81', N'CumulativeForm', N'{"columns":[{"field":"Row","caption":"رديف","visible":true,"readOnly":true,"position":0,"width":60},{"field":"name","caption":"نام","visible":true,"readOnly":true,"position":1,"width":100},{"field":"lastname","caption":"نام خانوادگي","visible":true,"readOnly":true,"position":2,"width":100},{"field":"nationalCode","caption":"کد ملي","visible":true,"readOnly":true,"position":3,"width":100},{"field":"mobile","caption":"موبايل","visible":true,"readOnly":true,"position":4,"width":100},{"field":"plate","caption":"شماره پلاک","visible":true,"readOnly":true,"position":5,"width":100},{"field":"month","caption":"ماه قرعه کشي","visible":true,"readOnly":true,"position":6,"width":150},{"field":"total","caption":"امتياز تردد","visible":true,"readOnly":true,"position":7,"width":100}]}')
SET IDENTITY_INSERT [dbo].[Base.GridHeader] OFF
SET IDENTITY_INSERT [dbo].[Base.Month] ON 

INSERT [dbo].[Base.Month] ([id], [viewId], [code], [month], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (1, N'32ed1883-de4b-4352-a026-4bd9d538a824', 1, N'فروردين', 2, CAST(N'2017-04-24 00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.Month] ([id], [viewId], [code], [month], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (2, N'0c86dbf6-f4cd-4c63-abb4-04a76bd12aee', 2, N'ارديبهشت', 2, CAST(N'2017-04-24 00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.Month] ([id], [viewId], [code], [month], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (3, N'e0dda961-67f4-4dd2-9522-ab3264bb0894', 3, N'خرداد', 2, CAST(N'2017-04-24 00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.Month] ([id], [viewId], [code], [month], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (4, N'83563646-1077-4f63-b466-e6d9797f4660', 4, N'تير', 2, CAST(N'2017-04-24 00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.Month] ([id], [viewId], [code], [month], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (5, N'79fc74da-8374-47c8-b0fb-295f3919008a', 5, N'مرداد', 2, CAST(N'2017-04-24 00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.Month] ([id], [viewId], [code], [month], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (6, N'bfa17d24-2eb4-45e2-a481-ea4bc9b531e6', 6, N'شهريور', 2, CAST(N'2017-04-24 00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.Month] ([id], [viewId], [code], [month], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (7, N'eb4ef5f6-31d3-494f-a125-2099519c36cb', 7, N'مهر', 2, CAST(N'2017-04-24 00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.Month] ([id], [viewId], [code], [month], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (8, N'6a9b48c7-c56f-4503-9d67-867ae4775ea5', 8, N'آبان', 2, CAST(N'2017-04-24 00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.Month] ([id], [viewId], [code], [month], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (9, N'aafaf7bf-3d63-4b27-b674-c6e686e84091', 9, N'آذر', 2, CAST(N'2017-04-24 00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.Month] ([id], [viewId], [code], [month], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (10, N'1ddc47d7-cf9d-40fe-b6f3-09e4c63b5766', 10, N'دي', 2, CAST(N'2017-04-24 00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.Month] ([id], [viewId], [code], [month], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (11, N'57d4cdad-fbb9-428c-adad-f866d28e70f9', 11, N'بهمن', 2, CAST(N'2017-04-24 00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.Month] ([id], [viewId], [code], [month], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (12, N'3ad353a6-b7d0-45f5-8b3d-2941829df87b', 12, N'اسفند', 2, CAST(N'2017-04-24 00:00:00.000' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Base.Month] OFF
SET IDENTITY_INSERT [dbo].[Base.PlateCity] ON 

INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (166, N'd89f3e65-4614-42f1-90b4-116a4f68e9e4', N'11', N'تهران شمال', 2, CAST(N'2016-11-30 15:13:34.030' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (167, N'13580c42-81d3-4e88-ac47-0e8e024f4920', N'12', N'مشهد', 2, CAST(N'2016-11-30 15:13:34.030' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (168, N'fa56f2d6-b345-4818-adc4-f15d42a9bba1', N'13', N'اصفهان', 2, CAST(N'2016-11-30 15:13:34.033' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (169, N'17dccf50-8fc6-4dff-b2b9-c2b267d4b77d', N'14', N'اهواز', 2, CAST(N'2016-11-30 15:13:34.033' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (170, N'81f2d663-e19c-4044-9877-8a2d55e36c6a', N'15', N'تبريز', 2, CAST(N'2016-11-30 15:13:34.037' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (171, N'b85d1a14-b7b6-4be0-a0c5-90e52e9102c8', N'16', N'قم', 2, CAST(N'2016-11-30 15:13:34.037' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (172, N'972d9a92-46fb-41e9-8f24-56753fab5b50', N'17', N'اروميه', 2, CAST(N'2016-11-30 15:13:34.040' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (173, N'd62b0e6c-6a6b-42e8-a17e-e8db0bdf6501', N'18', N'همدان', 2, CAST(N'2016-11-30 15:13:34.040' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (174, N'dbdd3de0-af94-4cb6-ab8d-5b3c44f72d74', N'19', N'کرمانشاه', 2, CAST(N'2016-11-30 15:13:34.040' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (175, N'48f9c2b5-c812-4c02-ba43-15bcedf9771c', N'21', N'استان تهران', 2, CAST(N'2016-11-30 15:13:34.043' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (176, N'b0dee809-3e46-4e9b-98dd-b2e586e685e9', N'22', N'تهران مرکز', 2, CAST(N'2016-11-30 15:13:34.043' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (177, N'b04dbae6-1a7d-4ddd-b6ea-173af9f1da65', N'23', N'استان اصفهان', 2, CAST(N'2016-11-30 15:13:34.043' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (178, N'48335aae-6a91-45e1-8657-f523ac56db00', N'24', N'استان خوزستان', 2, CAST(N'2016-11-30 15:13:34.047' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (179, N'4d1e6965-8c9f-4cab-8e0d-10c62b691c2a', N'25', N'استان آذربايجان شرقي', 2, CAST(N'2016-11-30 15:13:34.047' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (180, N'cd3b580d-e649-49b9-a3a3-6188472bfd12', N'26', N'استان قم', 2, CAST(N'2016-11-30 15:13:34.050' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (181, N'a4b15a25-9f77-423c-934b-898ed12643a3', N'27', N'استان آربايجان غربي', 2, CAST(N'2016-11-30 15:13:34.050' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (182, N'37445188-1dab-4dce-abdf-facf6ed8d9b9', N'28', N'استان همدان', 2, CAST(N'2016-11-30 15:13:34.050' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (183, N'60d5c0c0-4b88-44ac-bd15-f80022dd9b3d', N'29', N'استان کرمانشاه', 2, CAST(N'2016-11-30 15:13:34.050' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (184, N'e415725c-ce86-4305-8366-cd2e1c1d155e', N'31', N'سنندج', 2, CAST(N'2016-11-30 15:13:34.053' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (185, N'0a0edc4f-5cbd-46c4-a169-d65c92f94ce1', N'32', N'استان خراسان', 2, CAST(N'2016-11-30 15:13:34.053' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (186, N'55834de5-744d-418a-85b8-e07f97a89e8b', N'33', N'تهران جنوب', 2, CAST(N'2016-11-30 15:13:34.053' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (190, N'b64df916-d05f-43c1-8993-81142dad7515', N'37', N'استان آذربايجان غربي', 2, CAST(N'2016-11-30 15:13:34.137' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (193, N'71212ea5-81df-4b98-8695-eed4d4429bc5', N'41', N'استان کردستان', 2, CAST(N'2016-11-30 15:13:34.143' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (197, N'859de2f5-1457-4219-97ac-f388839b6a3b', N'45', N'کرمان', 2, CAST(N'2016-11-30 15:13:34.163' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (198, N'f53c5c34-1876-4e95-aa62-19a7a2aa1dd0', N'46', N'رشت', 2, CAST(N'2016-11-30 15:13:34.167' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (199, N'9e959359-3cbf-4abc-a6fd-8e50454026f0', N'47', N'اراک', 2, CAST(N'2016-11-30 15:13:34.167' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (200, N'404d7e25-67b6-481d-98b6-46fa6cd38293', N'48', N'بوشهر', 2, CAST(N'2016-11-30 15:13:34.170' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (201, N'd36c8d08-e481-4fdc-bb2b-6df98b2f30b9', N'49', N'استان کهکيلويه و بوير احمد', 2, CAST(N'2016-11-30 15:13:34.170' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (202, N'e2c28ca4-1d6f-4243-a606-de919c50f136', N'51', N'خرم آباد', 2, CAST(N'2016-11-30 15:13:34.170' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (205, N'8710b474-9a56-43ed-a895-15d923ed91bc', N'54', N'يزد', 2, CAST(N'2016-11-30 15:13:34.173' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (206, N'6bb8f311-1b12-46a3-8497-2a38474be6dc', N'55', N'تهران مرکزي', 2, CAST(N'2016-11-30 15:13:34.177' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (207, N'4f1a41c4-594c-4ebb-9c78-b093ae9d1b8f', N'56', N'گيلان', 2, CAST(N'2016-11-30 15:13:34.177' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (208, N'dca07382-9cb8-4561-a74e-4bd710251a3f', N'57', N'استان مرکزي', 2, CAST(N'2016-11-30 15:13:34.177' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (209, N'cbf80c6d-eba4-4168-ba88-ce2ebe239483', N'58', N'استان بوشهر', 2, CAST(N'2016-11-30 15:13:34.180' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (210, N'c1c56ac3-5960-45d0-98c6-4e163fa43ead', N'59', N'گرگان', 2, CAST(N'2016-11-30 15:13:34.180' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (211, N'5cc3434a-59f1-425c-80bc-5c53870854ce', N'61', N'استان لرستان', 2, CAST(N'2016-11-30 15:13:34.180' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (212, N'73e3e333-2acf-4722-bb0b-83e2bf04fb96', N'62', N'ساري', 2, CAST(N'2016-11-30 15:13:34.180' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (213, N'21ffd625-4f7d-49a1-ac68-6649eb7faeaa', N'63', N'شيراز', 2, CAST(N'2016-11-30 15:13:34.180' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (214, N'886c7321-954e-4250-b779-71bd090ea8b4', N'64', N'استان يزد', 2, CAST(N'2016-11-30 15:13:34.183' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (215, N'e6cac1e3-bd5b-40c3-8bc4-1dd8d5507640', N'65', N'استان کرمان', 2, CAST(N'2016-11-30 15:13:34.183' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (218, N'6e5ee6e0-55e8-4dd4-a043-d2c35c144d95', N'68', N'کرج', 2, CAST(N'2016-11-30 15:13:34.187' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (219, N'7bcb20a2-f287-4bc2-9653-94ab67a5be93', N'69', N'استان گرگان', 2, CAST(N'2016-11-30 15:13:34.187' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (220, N'b0ee0e4f-0d89-4575-90fb-dd3cfbd7c488', N'71', N'شهرکرد', 2, CAST(N'2016-11-30 15:13:34.190' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (221, N'2dce554a-8272-4805-85f5-7e9a5f34dd5b', N'72', N'استان مازندران', 2, CAST(N'2016-11-30 15:13:34.190' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (222, N'e36e9e76-7427-470f-95b9-25a3963eaaa9', N'73', N'استان فارس', 2, CAST(N'2016-11-30 15:13:34.190' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (225, N'b8d54fe7-3584-4f02-9801-50ba84d73064', N'76', N'استان گيلان', 2, CAST(N'2016-11-30 15:13:34.193' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (227, N'7261c50b-23c7-40a1-9e71-3eb1cc125e7b', N'78', N'شهرستان هاي تهران', 2, CAST(N'2016-11-30 15:13:34.197' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (228, N'd140671e-f99d-4044-b984-851ef9fccadf', N'79', N'قزوين', 2, CAST(N'2016-11-30 15:13:34.197' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (229, N'42d92392-780b-47a1-8a33-1341252a5e11', N'81', N'استان چهار محال و بختياري', 2, CAST(N'2016-11-30 15:13:34.197' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (232, N'f1d08f21-4690-41b3-bdec-5f920c52ee74', N'84', N'بندرعباس', 2, CAST(N'2016-11-30 15:13:34.200' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (233, N'19935827-e134-4371-9171-b00891200bb1', N'85', N'زاهدان', 2, CAST(N'2016-11-30 15:13:34.200' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (234, N'd3c08b03-94cb-43d2-92bc-4ca7c5bf2104', N'86', N'سمنان', 2, CAST(N'2016-11-30 15:13:34.203' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (235, N'12a1126e-24f2-44ab-9507-26611a6d0160', N'87', N'زنجان', 2, CAST(N'2016-11-30 15:13:34.203' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (237, N'e5109647-b0c5-4587-a6da-587a15b29047', N'89', N'استان قزوين', 2, CAST(N'2016-11-30 15:13:34.207' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (238, N'ddc5677d-0fd6-4fe2-baff-7430389dfbc0', N'91', N'اردبيل', 2, CAST(N'2016-11-30 15:13:34.207' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (241, N'5695724b-9f54-45fa-9a95-bd7d6f67e652', N'94', N'استان هرمزگان', 2, CAST(N'2016-11-30 15:13:34.210' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (242, N'3fa1a814-c237-429c-8e08-a558084ee817', N'95', N'استان سيستان و بلوچستان', 2, CAST(N'2016-11-30 15:13:34.210' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (243, N'15df7003-a5cc-44e9-88e5-8c5e4230d44f', N'96', N'استان سمنان', 2, CAST(N'2016-11-30 15:13:34.213' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (244, N'4a8e8504-7539-4db7-8978-c20fabb72894', N'97', N'استان زنجان', 2, CAST(N'2016-11-30 15:13:34.213' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (245, N'7272f1f3-6df9-4616-b84d-bf25f5c55d0b', N'98', N'ايلام', 2, CAST(N'2016-11-30 15:13:34.213' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (249, N'7c8964a8-fdd3-4a1b-b7b5-b7d66ec3a87c', N'99', N'تهران جنوب', 2, CAST(N'2016-11-30 15:18:52.400' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Base.PlateCity] OFF
SET IDENTITY_INSERT [dbo].[Base.PlateCountry] ON 

INSERT [dbo].[Base.PlateCountry] ([id], [viewId], [country], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (1, N'6b018379-cc17-4d3b-9ad8-aca7c679dbfe', N'ايران', 2, CAST(N'2016-11-19 00:52:44.863' AS DateTime), 2, CAST(N'2016-11-19 00:52:53.523' AS DateTime))
INSERT [dbo].[Base.PlateCountry] ([id], [viewId], [country], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (2, N'c0f6d287-00f8-41e5-a42d-0e2dacbcdf44', N'ترکيه', 2, CAST(N'2016-11-19 00:52:49.507' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Base.PlateCountry] OFF
SET IDENTITY_INSERT [dbo].[Base.PlateType] ON 

INSERT [dbo].[Base.PlateType] ([id], [viewId], [type], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (10, N'24a22ab1-17c2-4208-ade3-57a06a6271e6', N'عادي', 2, CAST(N'2016-12-02 12:05:11.277' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateType] ([id], [viewId], [type], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (11, N'48d690e1-3024-4d70-a47c-854bddda36ce', N'تاکسي', 2, CAST(N'2016-12-02 12:05:16.683' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateType] ([id], [viewId], [type], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (12, N'91d2d573-c10b-4cb4-908d-5113ca9dc9f6', N'دولتي', 2, CAST(N'2016-12-02 12:05:23.167' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateType] ([id], [viewId], [type], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (13, N'c91abdf8-d69d-42aa-9113-8a6af85fab8e', N'معلولين', 2, CAST(N'2016-12-02 12:06:45.820' AS DateTime), NULL, NULL)
INSERT [dbo].[Base.PlateType] ([id], [viewId], [type], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (14, N'b3078074-c59f-4481-88cb-6becc5aeb0ee', N'موتورسيکلت', 2, CAST(N'2016-12-02 12:06:56.460' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Base.PlateType] OFF
SET IDENTITY_INSERT [dbo].[Car] ON 

INSERT [dbo].[Car] ([id], [viewId], [carTypeId], [carColorId], [carSystemId], [carLevelId], [carFuelId], [plateId], [model], [status], [capacity], [chasisCode], [engineCode], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (57, N'4d9343ee-6146-4a8f-af14-2b2dad745e36', 3, 14, 9, 7, 7, 63, N'0', 1, 0, N'', N'', 2, CAST(N'2017-04-25 19:27:29.287' AS DateTime), 2, CAST(N'2017-04-29 21:31:38.320' AS DateTime))
INSERT [dbo].[Car] ([id], [viewId], [carTypeId], [carColorId], [carSystemId], [carLevelId], [carFuelId], [plateId], [model], [status], [capacity], [chasisCode], [engineCode], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (58, N'e1e8012b-7047-49c6-af22-1ad79e7d05b3', 3, 14, 9, 7, 7, 64, N'0', 1, 0, N'', N'', 2, CAST(N'2017-04-25 19:28:44.597' AS DateTime), 2, CAST(N'2017-04-30 14:54:12.790' AS DateTime))
INSERT [dbo].[Car] ([id], [viewId], [carTypeId], [carColorId], [carSystemId], [carLevelId], [carFuelId], [plateId], [model], [status], [capacity], [chasisCode], [engineCode], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (59, N'e6bc6175-7e4a-49c5-97e3-6e9ac5affc24', 3, 14, 9, 7, 7, 65, N'0', 1, 0, N'', N'', 2, CAST(N'2017-04-29 22:05:18.383' AS DateTime), 2, CAST(N'2017-04-30 14:49:00.067' AS DateTime))
INSERT [dbo].[Car] ([id], [viewId], [carTypeId], [carColorId], [carSystemId], [carLevelId], [carFuelId], [plateId], [model], [status], [capacity], [chasisCode], [engineCode], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (60, N'72d932fb-d550-4e2e-b93e-4f546c042be0', 3, 14, 9, 7, 7, 66, N'0', 1, 0, N'', N'', 2, CAST(N'2017-06-18 12:13:33.250' AS DateTime), NULL, NULL)
INSERT [dbo].[Car] ([id], [viewId], [carTypeId], [carColorId], [carSystemId], [carLevelId], [carFuelId], [plateId], [model], [status], [capacity], [chasisCode], [engineCode], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (61, N'de347e71-4c56-4901-b674-05b7049dfd91', 3, 14, 9, 7, 7, 67, N'0', 1, 0, N'', N'', 2, CAST(N'2017-09-18 10:28:57.043' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Car] OFF
SET IDENTITY_INSERT [dbo].[CarOwner] ON 

INSERT [dbo].[CarOwner] ([id], [viewId], [carId], [ownerId], [type], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (58, N'7a50721f-a9cf-4068-b741-450960a46d19', 57, 53, 0, 2, CAST(N'2017-04-25 19:27:29.303' AS DateTime), 2, CAST(N'2017-04-29 21:31:38.383' AS DateTime))
INSERT [dbo].[CarOwner] ([id], [viewId], [carId], [ownerId], [type], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (59, N'e50704f1-e92b-462e-8fb5-1d6d2893a75b', 58, 54, 0, 2, CAST(N'2017-04-25 19:28:44.613' AS DateTime), 2, CAST(N'2017-04-30 14:54:12.803' AS DateTime))
INSERT [dbo].[CarOwner] ([id], [viewId], [carId], [ownerId], [type], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (60, N'1eb2ed63-c790-4cf9-a9f4-7de0a86e1636', 59, 52, 0, 2, CAST(N'2017-04-29 22:05:18.400' AS DateTime), 2, CAST(N'2017-04-30 14:49:00.097' AS DateTime))
INSERT [dbo].[CarOwner] ([id], [viewId], [carId], [ownerId], [type], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (61, N'84aa9182-fd8d-4cea-8c06-ff2839457ef6', 60, 53, 0, 2, CAST(N'2017-06-18 12:13:33.280' AS DateTime), NULL, NULL)
INSERT [dbo].[CarOwner] ([id], [viewId], [carId], [ownerId], [type], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (62, N'535b3c1e-a53e-4d45-8cfa-2109d8cf9690', 61, 55, 0, 2, CAST(N'2017-09-18 10:28:57.180' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[CarOwner] OFF
SET IDENTITY_INSERT [dbo].[CarTag] ON 

INSERT [dbo].[CarTag] ([id], [viewId], [carId], [tagId], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (46, N'3deae91d-a872-4c4e-b7c3-3725d7288a1f', 57, 58, 2, CAST(N'2017-04-25' AS Date), NULL, NULL)
INSERT [dbo].[CarTag] ([id], [viewId], [carId], [tagId], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (47, N'044b4b16-b69f-4601-932b-c28fcf205f63', 58, 59, 2, CAST(N'2017-04-25' AS Date), 2, CAST(N'2017-04-30' AS Date))
INSERT [dbo].[CarTag] ([id], [viewId], [carId], [tagId], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (48, N'8ed02fde-e54d-43b0-b319-37e1287772b4', 59, 60, 2, CAST(N'2017-04-29' AS Date), 2, CAST(N'2017-04-30' AS Date))
INSERT [dbo].[CarTag] ([id], [viewId], [carId], [tagId], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (49, N'139c8b56-ba82-420a-a300-1fbf87387e37', 60, 62, 2, CAST(N'2017-06-18' AS Date), NULL, NULL)
INSERT [dbo].[CarTag] ([id], [viewId], [carId], [tagId], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (50, N'03cb1414-3df6-4537-9770-25ea74a21e6c', 61, 63, 2, CAST(N'2017-09-18' AS Date), NULL, NULL)
SET IDENTITY_INSERT [dbo].[CarTag] OFF
SET IDENTITY_INSERT [dbo].[Error] ON 

INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (37, N'cafed20f-8557-4dee-835f-3a7affbefc84', N'System.ComponentModel.Win32Exception: The interface is unknown
   at System.Diagnostics.EventLog.InternalWriteEvent(UInt32 eventID, UInt16 category, EventLogEntryType type, String[] strings, Byte[] rawData, String currentMachineName)
   at System.Diagnostics.EventLog.WriteEntry(String message, EventLogEntryType type, Int32 eventID, Int16 category, Byte[] rawData)
   at System.Diagnostics.EventLog.WriteEntry(String message)
   at AntennaService.AntennaService.writeLog(String log) in E:\Projects\Project GasStation\GasStation\AntennaService\AntennaService.cs:line 129
   at AntennaService.AntennaService.connectToAntenna(String host, Int32 port) in E:\Projects\Project GasStation\GasStation\AntennaService\AntennaService.cs:line 437
   at AntennaService.AntennaService.connectToAntenna() in E:\Projects\Project GasStation\GasStation\AntennaService\AntennaService.cs:line 249
   at System.Threading.ThreadHelper.ThreadStart_Context(Object state)
   at System.Threading.ExecutionContext.Run(ExecutionContext executionContext, ContextCallback callback, Object state)
   at System.Threading.ThreadHelper.ThreadStart()', N'System', N'', N'   at System.Diagnostics.EventLog.InternalWriteEvent(UInt32 eventID, UInt16 category, EventLogEntryType type, String[] strings, Byte[] rawData, String currentMachineName)
   at System.Diagnostics.EventLog.WriteEntry(String message, EventLogEntryType type, Int32 eventID, Int16 category, Byte[] rawData)
   at System.Diagnostics.EventLog.WriteEntry(String message)
   at AntennaService.AntennaService.writeLog(String log) in E:\Projects\Project GasStation\GasStation\AntennaService\AntennaService.cs:line 129
   at AntennaService.AntennaService.connectToAntenna(String host, Int32 port) in E:\Projects\Project GasStation\GasStation\AntennaService\AntennaService.cs:line 437
   at AntennaService.AntennaService.connectToAntenna() in E:\Projects\Project GasStation\GasStation\AntennaService\AntennaService.cs:line 249
   at System.Threading.ThreadHelper.ThreadStart_Context(Object state)
   at System.Threading.ExecutionContext.Run(ExecutionContext executionContext, ContextCallback callback, Object state)
   at System.Threading.ThreadHelper.ThreadStart()', N'Void InternalWriteEvent(UInt32, UInt16, System.Diagnostics.EventLogEntryType, System.String[], Byte[], System.String)', N'InternalWriteEvent', N'System.dll', CAST(N'2017-08-24 10:48:10.687' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (38, N'fdddac17-6516-47a2-a452-8d49b5a36f93', N'System.ComponentModel.Win32Exception: The RPC server is unavailable
   at System.Diagnostics.EventLog.InternalWriteEvent(UInt32 eventID, UInt16 category, EventLogEntryType type, String[] strings, Byte[] rawData, String currentMachineName)
   at System.Diagnostics.EventLog.WriteEntry(String message, EventLogEntryType type, Int32 eventID, Int16 category, Byte[] rawData)
   at System.Diagnostics.EventLog.WriteEntry(String message)
   at CommittedService.CommittedService.writeLog(String log) in E:\Projects\Project GasStation\GasStation\CommittedService\CommittedService.cs:line 129', N'System', N'', N'   at System.Diagnostics.EventLog.InternalWriteEvent(UInt32 eventID, UInt16 category, EventLogEntryType type, String[] strings, Byte[] rawData, String currentMachineName)
   at System.Diagnostics.EventLog.WriteEntry(String message, EventLogEntryType type, Int32 eventID, Int16 category, Byte[] rawData)
   at System.Diagnostics.EventLog.WriteEntry(String message)
   at CommittedService.CommittedService.writeLog(String log) in E:\Projects\Project GasStation\GasStation\CommittedService\CommittedService.cs:line 129', N'Void InternalWriteEvent(UInt32, UInt16, System.Diagnostics.EventLogEntryType, System.String[], Byte[], System.String)', N'InternalWriteEvent', N'System.dll', CAST(N'2017-08-24 10:48:11.297' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (39, N'a68f8134-4377-4122-aa16-b1d31a772a10', N'System.ComponentModel.Win32Exception: The RPC server is unavailable
   at System.Diagnostics.EventLog.InternalWriteEvent(UInt32 eventID, UInt16 category, EventLogEntryType type, String[] strings, Byte[] rawData, String currentMachineName)
   at System.Diagnostics.EventLog.WriteEntry(String message, EventLogEntryType type, Int32 eventID, Int16 category, Byte[] rawData)
   at System.Diagnostics.EventLog.WriteEntry(String message)
   at CommittedService.CommittedService.writeLog(String log) in E:\Projects\Project GasStation\GasStation\CommittedService\CommittedService.cs:line 129', N'System', N'', N'   at System.Diagnostics.EventLog.InternalWriteEvent(UInt32 eventID, UInt16 category, EventLogEntryType type, String[] strings, Byte[] rawData, String currentMachineName)
   at System.Diagnostics.EventLog.WriteEntry(String message, EventLogEntryType type, Int32 eventID, Int16 category, Byte[] rawData)
   at System.Diagnostics.EventLog.WriteEntry(String message)
   at CommittedService.CommittedService.writeLog(String log) in E:\Projects\Project GasStation\GasStation\CommittedService\CommittedService.cs:line 129', N'Void InternalWriteEvent(UInt32, UInt16, System.Diagnostics.EventLogEntryType, System.String[], Byte[], System.String)', N'InternalWriteEvent', N'System.dll', CAST(N'2017-08-24 10:48:11.687' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (40, N'5a024b1c-3ed0-4f71-a06a-69f05ef6658b', N'System.InvalidOperationException: Cannot open Service Control Manager on computer ''127.0.0.1''. This operation might require other privileges. ---> System.ComponentModel.Win32Exception: The RPC server is unavailable
   --- End of inner exception stack trace ---
   at System.ServiceProcess.ServiceController.GetDataBaseHandleWithAccess(String machineName, Int32 serviceControlManaqerAccess)
   at System.ServiceProcess.ServiceController.GetDataBaseHandleWithConnectAccess()
   at System.ServiceProcess.ServiceController.GenerateNames()
   at System.ServiceProcess.ServiceController.get_ServiceName()
   at System.ServiceProcess.ServiceController.GenerateStatus()
   at System.ServiceProcess.ServiceController.get_Status()
   at Common.Helper.Windows.ServiceHelper.startService(String serviceName, String machineName) in E:\Projects\Project GasStation\GasStation\Common\Helper\Windows\ServiceHelper.cs:line 59', N'System.ServiceProcess', N'System.ComponentModel.Win32Exception: The RPC server is unavailable', N'   at System.ServiceProcess.ServiceController.GetDataBaseHandleWithAccess(String machineName, Int32 serviceControlManaqerAccess)
   at System.ServiceProcess.ServiceController.GetDataBaseHandleWithConnectAccess()
   at System.ServiceProcess.ServiceController.GenerateNames()
   at System.ServiceProcess.ServiceController.get_ServiceName()
   at System.ServiceProcess.ServiceController.GenerateStatus()
   at System.ServiceProcess.ServiceController.get_Status()
   at Common.Helper.Windows.ServiceHelper.startService(String serviceName, String machineName) in E:\Projects\Project GasStation\GasStation\Common\Helper\Windows\ServiceHelper.cs:line 59', N'IntPtr GetDataBaseHandleWithAccess(System.String, Int32)', N'GetDataBaseHandleWithAccess', N'System.ServiceProcess.dll', CAST(N'2017-08-24 10:48:12.017' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (41, N'7fb07f49-da7c-46d0-8346-1b34beedf997', N'System.ArgumentException: An item with the same key has already been added.
   at System.ThrowHelper.ThrowArgumentException(ExceptionResource resource)
   at System.Collections.Generic.Dictionary`2.Insert(TKey key, TValue value, Boolean add)
   at System.Collections.Generic.Dictionary`2.Add(TKey key, TValue value)
   at Common.Initializer.init(String loggerFilename, String exePath) in E:\Projects\Project GasStation\GasStation\Common\Initializer.cs:line 27
   at GasStation.__Program.Main() in E:\Projects\Project GasStation\GasStation\GasStation\__Program.cs:line 27
   at System.AppDomain._nExecuteAssembly(Assembly assembly, String[] args)
   at System.AppDomain.ExecuteAssembly(String assemblyFile, Evidence assemblySecurity, String[] args)
   at Microsoft.VisualStudio.HostingProcess.HostProc.RunUsersAssembly()
   at System.Threading.ThreadHelper.ThreadStart_Context(Object state)
   at System.Threading.ExecutionContext.Run(ExecutionContext executionContext, ContextCallback callback, Object state)
   at System.Threading.ThreadHelper.ThreadStart()', N'mscorlib', N'', N'   at System.ThrowHelper.ThrowArgumentException(ExceptionResource resource)
   at System.Collections.Generic.Dictionary`2.Insert(TKey key, TValue value, Boolean add)
   at System.Collections.Generic.Dictionary`2.Add(TKey key, TValue value)
   at Common.Initializer.init(String loggerFilename, String exePath) in E:\Projects\Project GasStation\GasStation\Common\Initializer.cs:line 27
   at GasStation.__Program.Main() in E:\Projects\Project GasStation\GasStation\GasStation\__Program.cs:line 27
   at System.AppDomain._nExecuteAssembly(Assembly assembly, String[] args)
   at System.AppDomain.ExecuteAssembly(String assemblyFile, Evidence assemblySecurity, String[] args)
   at Microsoft.VisualStudio.HostingProcess.HostProc.RunUsersAssembly()
   at System.Threading.ThreadHelper.ThreadStart_Context(Object state)
   at System.Threading.ExecutionContext.Run(ExecutionContext executionContext, ContextCallback callback, Object state)
   at System.Threading.ThreadHelper.ThreadStart()', N'Void ThrowArgumentException(System.ExceptionResource)', N'ThrowArgumentException', N'CommonLanguageRuntimeLibrary', CAST(N'2017-09-17 18:50:25.683' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (42, N'887ce248-48d8-4919-af47-83159f5ca6bd', N'System.Threading.ThreadAbortException: Thread was being aborted.
   at System.Threading.Thread.SleepInternal(Int32 millisecondsTimeout)
   at System.Threading.Thread.Sleep(TimeSpan timeout)
   at GasStation.Forms.Reports.ReportTrafficForm.<tryToReadTraffic>b__13_0() in E:\Projects\Project GasStation\GasStation-Petrol\GasStation\Forms\Reports\ReportTrafficForm.cs:line 105', N'mscorlib', N'', N'   at System.Threading.Thread.SleepInternal(Int32 millisecondsTimeout)
   at System.Threading.Thread.Sleep(TimeSpan timeout)
   at GasStation.Forms.Reports.ReportTrafficForm.<tryToReadTraffic>b__13_0() in E:\Projects\Project GasStation\GasStation-Petrol\GasStation\Forms\Reports\ReportTrafficForm.cs:line 105', N'Void SleepInternal(Int32)', N'SleepInternal', N'CommonLanguageRuntimeLibrary', CAST(N'2018-01-26 17:36:09.707' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (43, N'b3fd1839-042e-42c3-aa6b-c6c101318da2', N'System.Threading.ThreadAbortException: Thread was being aborted.
   at System.Threading.Thread.SleepInternal(Int32 millisecondsTimeout)
   at System.Threading.Thread.Sleep(TimeSpan timeout)
   at GasStation.Forms.Reports.ReportTrafficForm.<tryToReadTraffic>b__13_0() in E:\Projects\Project GasStation\GasStation-Petrol\GasStation\Forms\Reports\ReportTrafficForm.cs:line 105', N'mscorlib', N'', N'   at System.Threading.Thread.SleepInternal(Int32 millisecondsTimeout)
   at System.Threading.Thread.Sleep(TimeSpan timeout)
   at GasStation.Forms.Reports.ReportTrafficForm.<tryToReadTraffic>b__13_0() in E:\Projects\Project GasStation\GasStation-Petrol\GasStation\Forms\Reports\ReportTrafficForm.cs:line 105', N'Void SleepInternal(Int32)', N'SleepInternal', N'CommonLanguageRuntimeLibrary', CAST(N'2018-01-26 17:47:21.330' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (44, N'dc7eab42-9fe7-48e5-903a-eaf71726c545', N'System.FormatException: Input string was not in a correct format.
   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at GasStation.Forms.Reports.ReportTrafficForm.loadTraffic(DateTime date1, DateTime date2) in E:\Projects\Project GasStation\GasStation-Petrol\GasStation\Forms\Reports\ReportTrafficForm.cs:line 491', N'System.Windows.Forms', N'', N'   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at GasStation.Forms.Reports.ReportTrafficForm.loadTraffic(DateTime date1, DateTime date2) in E:\Projects\Project GasStation\GasStation-Petrol\GasStation\Forms\Reports\ReportTrafficForm.cs:line 491', N'System.Object MarshaledInvoke(System.Windows.Forms.Control, System.Delegate, System.Object[], Boolean)', N'MarshaledInvoke', N'System.Windows.Forms.dll', CAST(N'2018-01-27 21:43:00.510' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (45, N'b81175f5-ba5c-4228-979d-2ec15384883f', N'System.InvalidOperationException: Invoke or BeginInvoke cannot be called on a control until the window handle has been created.
   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at GasStation.Forms.Reports.ReportTrafficForm.loadTraffic(DateTime date1, DateTime date2) in E:\Projects\Project GasStation\GasStation-Petrol\GasStation\Forms\Reports\ReportTrafficForm.cs:line 497', N'System.Windows.Forms', N'', N'   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at GasStation.Forms.Reports.ReportTrafficForm.loadTraffic(DateTime date1, DateTime date2) in E:\Projects\Project GasStation\GasStation-Petrol\GasStation\Forms\Reports\ReportTrafficForm.cs:line 497', N'System.Object MarshaledInvoke(System.Windows.Forms.Control, System.Delegate, System.Object[], Boolean)', N'MarshaledInvoke', N'System.Windows.Forms.dll', CAST(N'2018-01-27 21:49:32.023' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (46, N'ba38b45e-ed2f-4c87-bc9d-0eb80431a1d0', N'System.IndexOutOfRangeException: There is no row at position 1.
   at System.Data.RBTree`1.GetNodeByIndex(Int32 userIndex)
   at System.Data.RBTree`1.get_Item(Int32 index)
   at System.Data.DataRowCollection.get_Item(Int32 index)
   at GasStation.Forms.Reports.ReportTrafficForm.loadTraffic(DateTime date1, DateTime date2) in E:\Projects\Project GasStation\GasStation-Petrol\GasStation\Forms\Reports\ReportTrafficForm.cs:line 508', N'System.Data', N'', N'   at System.Data.RBTree`1.GetNodeByIndex(Int32 userIndex)
   at System.Data.RBTree`1.get_Item(Int32 index)
   at System.Data.DataRowCollection.get_Item(Int32 index)
   at GasStation.Forms.Reports.ReportTrafficForm.loadTraffic(DateTime date1, DateTime date2) in E:\Projects\Project GasStation\GasStation-Petrol\GasStation\Forms\Reports\ReportTrafficForm.cs:line 508', N'NodePath GetNodeByIndex(Int32)', N'GetNodeByIndex', N'System.Data.dll', CAST(N'2018-01-27 21:50:48.903' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (47, N'1e1227cf-d174-419a-ba01-c4d88e5cab64', N'System.InvalidOperationException: Cross-thread operation not valid: Control ''mainTabControl'' accessed from a thread other than the thread it was created on.
   at System.Windows.Forms.Control.get_Handle()
   at System.Windows.Forms.Control.SendMessage(Int32 msg, Int32 wparam, Int32 lparam)
   at System.Windows.Forms.TabControl.get_SelectedIndex()
   at System.Windows.Forms.TabControl.get_SelectedTabInternal()
   at System.Windows.Forms.TabControl.get_SelectedTab()
   at PetrolStation.Forms.Reports.ReportTrafficForm.loadTraffic(DateTime begindate, DateTime enddate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Reports\ReportTrafficForm.cs:line 576', N'System.Windows.Forms', N'', N'   at System.Windows.Forms.Control.get_Handle()
   at System.Windows.Forms.Control.SendMessage(Int32 msg, Int32 wparam, Int32 lparam)
   at System.Windows.Forms.TabControl.get_SelectedIndex()
   at System.Windows.Forms.TabControl.get_SelectedTabInternal()
   at System.Windows.Forms.TabControl.get_SelectedTab()
   at PetrolStation.Forms.Reports.ReportTrafficForm.loadTraffic(DateTime begindate, DateTime enddate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Reports\ReportTrafficForm.cs:line 576', N'IntPtr get_Handle()', N'get_Handle', N'System.Windows.Forms.dll', CAST(N'2018-02-10 16:23:25.607' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (48, N'2df483c3-f994-4b92-8d7d-cc7d2dc0fe65', N'System.InvalidOperationException: Cross-thread operation not valid: Control ''pageIndexComboBox'' accessed from a thread other than the thread it was created on.
   at System.Windows.Forms.Control.get_Handle()
   at System.Windows.Forms.Control.SendMessage(Int32 msg, Int32 wparam, Int32 lparam)
   at System.Windows.Forms.ComboBox.get_SelectedIndex()
   at System.Windows.Forms.ComboBox.get_SelectedItem()
   at System.Windows.Forms.ComboBox.get_Text()
   at PetrolStation.Forms.Reports.ReportTrafficForm.loadTraffic(DateTime begindate, DateTime enddate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Reports\ReportTrafficForm.cs:line 549', N'System.Windows.Forms', N'', N'   at System.Windows.Forms.Control.get_Handle()
   at System.Windows.Forms.Control.SendMessage(Int32 msg, Int32 wparam, Int32 lparam)
   at System.Windows.Forms.ComboBox.get_SelectedIndex()
   at System.Windows.Forms.ComboBox.get_SelectedItem()
   at System.Windows.Forms.ComboBox.get_Text()
   at PetrolStation.Forms.Reports.ReportTrafficForm.loadTraffic(DateTime begindate, DateTime enddate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Reports\ReportTrafficForm.cs:line 549', N'IntPtr get_Handle()', N'get_Handle', N'System.Windows.Forms.dll', CAST(N'2018-02-10 16:23:55.903' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (49, N'0a152892-2109-4eb5-8bb6-98771d24299e', N'System.InvalidOperationException: Cross-thread operation not valid: Control ''pageIndexComboBox'' accessed from a thread other than the thread it was created on.
   at System.Windows.Forms.Control.get_Handle()
   at System.Windows.Forms.Control.SendMessage(Int32 msg, Int32 wparam, Int32 lparam)
   at System.Windows.Forms.ComboBox.get_SelectedIndex()
   at System.Windows.Forms.ComboBox.get_SelectedItem()
   at System.Windows.Forms.ComboBox.get_Text()
   at PetrolStation.Forms.Reports.ReportTrafficForm.loadTraffic(DateTime begindate, DateTime enddate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Reports\ReportTrafficForm.cs:line 549', N'System.Windows.Forms', N'', N'   at System.Windows.Forms.Control.get_Handle()
   at System.Windows.Forms.Control.SendMessage(Int32 msg, Int32 wparam, Int32 lparam)
   at System.Windows.Forms.ComboBox.get_SelectedIndex()
   at System.Windows.Forms.ComboBox.get_SelectedItem()
   at System.Windows.Forms.ComboBox.get_Text()
   at PetrolStation.Forms.Reports.ReportTrafficForm.loadTraffic(DateTime begindate, DateTime enddate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Reports\ReportTrafficForm.cs:line 549', N'IntPtr get_Handle()', N'get_Handle', N'System.Windows.Forms.dll', CAST(N'2018-02-10 16:24:25.950' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (50, N'185db35a-0673-42c2-83c9-f0814e6b13db', N'System.Threading.ThreadAbortException: Thread was being aborted.
   at System.Threading.Thread.SleepInternal(Int32 millisecondsTimeout)
   at System.Threading.Thread.Sleep(TimeSpan timeout)
   at PetrolStation.Forms.Reports.ReportTrafficForm.<tryToReadTraffic>b__14_0() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Reports\ReportTrafficForm.cs:line 128', N'mscorlib', N'', N'   at System.Threading.Thread.SleepInternal(Int32 millisecondsTimeout)
   at System.Threading.Thread.Sleep(TimeSpan timeout)
   at PetrolStation.Forms.Reports.ReportTrafficForm.<tryToReadTraffic>b__14_0() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Reports\ReportTrafficForm.cs:line 128', N'Void SleepInternal(Int32)', N'SleepInternal', N'CommonLanguageRuntimeLibrary', CAST(N'2018-02-10 16:24:48.473' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (51, N'8bc0427e-0b05-4079-97cd-2151a72ed7e8', N'System.InvalidOperationException: Invoke or BeginInvoke cannot be called on a control until the window handle has been created.
   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Reports.ReportTrafficForm.loadTraffic(DateTime begindate, DateTime enddate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Reports\ReportTrafficForm.cs:line 570', N'System.Windows.Forms', N'', N'   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Reports.ReportTrafficForm.loadTraffic(DateTime begindate, DateTime enddate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Reports\ReportTrafficForm.cs:line 570', N'System.Object MarshaledInvoke(System.Windows.Forms.Control, System.Delegate, System.Object[], Boolean)', N'MarshaledInvoke', N'System.Windows.Forms.dll', CAST(N'2018-02-10 16:34:43.497' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (52, N'e6b5550e-d6f9-44a7-a516-83574e5fd541', N'System.InvalidOperationException: Invoke or BeginInvoke cannot be called on a control until the window handle has been created.
   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Reports.ReportTrafficForm.loadTraffic(DateTime begindate, DateTime enddate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Reports\ReportTrafficForm.cs:line 570', N'System.Windows.Forms', N'', N'   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Reports.ReportTrafficForm.loadTraffic(DateTime begindate, DateTime enddate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Reports\ReportTrafficForm.cs:line 570', N'System.Object MarshaledInvoke(System.Windows.Forms.Control, System.Delegate, System.Object[], Boolean)', N'MarshaledInvoke', N'System.Windows.Forms.dll', CAST(N'2018-02-10 16:36:17.340' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (53, N'8dc42ed3-6c50-4d65-a453-c61ec0245cf6', N'System.InvalidOperationException: Cross-thread operation not valid: Control ''pageIndexComboBox'' accessed from a thread other than the thread it was created on.
   at System.Windows.Forms.Control.get_Handle()
   at System.Windows.Forms.Control.SendMessage(Int32 msg, Int32 wparam, Int32 lparam)
   at System.Windows.Forms.ComboBox.get_SelectedIndex()
   at System.Windows.Forms.ComboBox.get_SelectedItem()
   at System.Windows.Forms.ComboBox.get_Text()
   at PetrolStation.Forms.Reports.ReportTrafficForm.loadTraffic(DateTime begindate, DateTime enddate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Reports\ReportTrafficForm.cs:line 573', N'System.Windows.Forms', N'', N'   at System.Windows.Forms.Control.get_Handle()
   at System.Windows.Forms.Control.SendMessage(Int32 msg, Int32 wparam, Int32 lparam)
   at System.Windows.Forms.ComboBox.get_SelectedIndex()
   at System.Windows.Forms.ComboBox.get_SelectedItem()
   at System.Windows.Forms.ComboBox.get_Text()
   at PetrolStation.Forms.Reports.ReportTrafficForm.loadTraffic(DateTime begindate, DateTime enddate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Reports\ReportTrafficForm.cs:line 573', N'IntPtr get_Handle()', N'get_Handle', N'System.Windows.Forms.dll', CAST(N'2018-02-10 16:38:33.380' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (54, N'262ca82d-395e-451b-bbbd-c0b2a1804a1a', N'System.InvalidOperationException: Cross-thread operation not valid: Control ''pageIndexComboBox'' accessed from a thread other than the thread it was created on.
   at System.Windows.Forms.Control.get_Handle()
   at System.Windows.Forms.Control.SendMessage(Int32 msg, Int32 wparam, Int32 lparam)
   at System.Windows.Forms.ComboBox.get_SelectedIndex()
   at System.Windows.Forms.ComboBox.get_SelectedItem()
   at System.Windows.Forms.ComboBox.get_Text()
   at PetrolStation.Forms.Reports.ReportTrafficForm.loadTraffic(DateTime begindate, DateTime enddate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Reports\ReportTrafficForm.cs:line 573', N'System.Windows.Forms', N'', N'   at System.Windows.Forms.Control.get_Handle()
   at System.Windows.Forms.Control.SendMessage(Int32 msg, Int32 wparam, Int32 lparam)
   at System.Windows.Forms.ComboBox.get_SelectedIndex()
   at System.Windows.Forms.ComboBox.get_SelectedItem()
   at System.Windows.Forms.ComboBox.get_Text()
   at PetrolStation.Forms.Reports.ReportTrafficForm.loadTraffic(DateTime begindate, DateTime enddate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Reports\ReportTrafficForm.cs:line 573', N'IntPtr get_Handle()', N'get_Handle', N'System.Windows.Forms.dll', CAST(N'2018-02-10 16:39:06.967' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (55, N'a492a259-b4a8-46e4-8d4b-28e931a55313', N'System.Threading.ThreadAbortException: Thread was being aborted.
   at System.Threading.Thread.SleepInternal(Int32 millisecondsTimeout)
   at System.Threading.Thread.Sleep(TimeSpan timeout)
   at PetrolStation.Forms.Reports.ReportTrafficForm.<startLoadThread>b__17_0() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Reports\ReportTrafficForm.cs:line 167', N'mscorlib', N'', N'   at System.Threading.Thread.SleepInternal(Int32 millisecondsTimeout)
   at System.Threading.Thread.Sleep(TimeSpan timeout)
   at PetrolStation.Forms.Reports.ReportTrafficForm.<startLoadThread>b__17_0() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Reports\ReportTrafficForm.cs:line 167', N'Void SleepInternal(Int32)', N'SleepInternal', N'CommonLanguageRuntimeLibrary', CAST(N'2018-02-10 16:48:16.200' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (56, N'7db02640-4d53-4d50-987a-47c65b8bf0a1', N'System.Threading.ThreadAbortException: Thread was being aborted.
   at System.Threading.Thread.SleepInternal(Int32 millisecondsTimeout)
   at System.Threading.Thread.Sleep(TimeSpan timeout)
   at PetrolStation.Forms.Reports.ReportTrafficForm.<startLoadThread>b__17_0() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Reports\ReportTrafficForm.cs:line 166', N'mscorlib', N'', N'   at System.Threading.Thread.SleepInternal(Int32 millisecondsTimeout)
   at System.Threading.Thread.Sleep(TimeSpan timeout)
   at PetrolStation.Forms.Reports.ReportTrafficForm.<startLoadThread>b__17_0() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Reports\ReportTrafficForm.cs:line 166', N'Void SleepInternal(Int32)', N'SleepInternal', N'CommonLanguageRuntimeLibrary', CAST(N'2018-02-10 17:03:51.303' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (57, N'a92fb047-1da9-4908-b144-4cae31da9328', N'System.Threading.ThreadAbortException: Thread was being aborted.
   at System.Threading.Thread.SleepInternal(Int32 millisecondsTimeout)
   at System.Threading.Thread.Sleep(TimeSpan timeout)
   at PetrolStation.Forms.Reports.ReportTrafficForm.<startLoadThread>b__16_0() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Reports\ReportTrafficForm.cs:line 161', N'mscorlib', N'', N'   at System.Threading.Thread.SleepInternal(Int32 millisecondsTimeout)
   at System.Threading.Thread.Sleep(TimeSpan timeout)
   at PetrolStation.Forms.Reports.ReportTrafficForm.<startLoadThread>b__16_0() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Reports\ReportTrafficForm.cs:line 161', N'Void SleepInternal(Int32)', N'SleepInternal', N'CommonLanguageRuntimeLibrary', CAST(N'2018-02-10 17:07:23.113' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (58, N'69735a68-37ef-49ae-b84d-27d6d3f6f57e', N'System.Threading.ThreadAbortException: Thread was being aborted.
   at System.Threading.Thread.SleepInternal(Int32 millisecondsTimeout)
   at System.Threading.Thread.Sleep(TimeSpan timeout)
   at PetrolStation.Forms.Reports.ReportTrafficForm.<startLoadThread>b__16_0() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Reports\ReportTrafficForm.cs:line 161', N'mscorlib', N'', N'   at System.Threading.Thread.SleepInternal(Int32 millisecondsTimeout)
   at System.Threading.Thread.Sleep(TimeSpan timeout)
   at PetrolStation.Forms.Reports.ReportTrafficForm.<startLoadThread>b__16_0() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Reports\ReportTrafficForm.cs:line 161', N'Void SleepInternal(Int32)', N'SleepInternal', N'CommonLanguageRuntimeLibrary', CAST(N'2018-02-10 17:08:58.663' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (59, N'cf05ba5f-983b-4fb1-9d9e-da16f8009714', N'System.Threading.ThreadAbortException: Thread was being aborted.
   at System.Threading.Thread.SleepInternal(Int32 millisecondsTimeout)
   at System.Threading.Thread.Sleep(TimeSpan timeout)
   at PetrolStation.Forms.Reports.ReportTrafficForm.<startLoadThread>b__16_0() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Reports\ReportTrafficForm.cs:line 161', N'mscorlib', N'', N'   at System.Threading.Thread.SleepInternal(Int32 millisecondsTimeout)
   at System.Threading.Thread.Sleep(TimeSpan timeout)
   at PetrolStation.Forms.Reports.ReportTrafficForm.<startLoadThread>b__16_0() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Reports\ReportTrafficForm.cs:line 161', N'Void SleepInternal(Int32)', N'SleepInternal', N'CommonLanguageRuntimeLibrary', CAST(N'2018-02-10 17:11:15.917' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (60, N'5043c386-e807-4506-a21d-eec4c5cc813a', N'System.InvalidOperationException: Invoke or BeginInvoke cannot be called on a control until the window handle has been created.
   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 203', N'System.Windows.Forms', N'', N'   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 203', N'System.Object MarshaledInvoke(System.Windows.Forms.Control, System.Delegate, System.Object[], Boolean)', N'MarshaledInvoke', N'System.Windows.Forms.dll', CAST(N'2018-02-10 22:06:28.137' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (61, N'aa3768b4-7fee-43af-b7c8-91cf4d332a63', N'System.InvalidOperationException: Invoke or BeginInvoke cannot be called on a control until the window handle has been created.
   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 205', N'System.Windows.Forms', N'', N'   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 205', N'System.Object MarshaledInvoke(System.Windows.Forms.Control, System.Delegate, System.Object[], Boolean)', N'MarshaledInvoke', N'System.Windows.Forms.dll', CAST(N'2018-02-10 22:22:47.317' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (62, N'a0754fd1-3f14-4e10-81c3-370a98083689', N'System.InvalidOperationException: Invoke or BeginInvoke cannot be called on a control until the window handle has been created.
   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 205', N'System.Windows.Forms', N'', N'   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 205', N'System.Object MarshaledInvoke(System.Windows.Forms.Control, System.Delegate, System.Object[], Boolean)', N'MarshaledInvoke', N'System.Windows.Forms.dll', CAST(N'2018-02-10 22:28:42.773' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (63, N'b61a8c22-ad3b-402c-8319-ef8d865bc766', N'System.InvalidOperationException: Invoke or BeginInvoke cannot be called on a control until the window handle has been created.
   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 205', N'System.Windows.Forms', N'', N'   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 205', N'System.Object MarshaledInvoke(System.Windows.Forms.Control, System.Delegate, System.Object[], Boolean)', N'MarshaledInvoke', N'System.Windows.Forms.dll', CAST(N'2018-02-10 22:29:12.867' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (64, N'949cb899-64e0-44b9-abfb-247e2627b530', N'System.InvalidOperationException: Invoke or BeginInvoke cannot be called on a control until the window handle has been created.
   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 205', N'System.Windows.Forms', N'', N'   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 205', N'System.Object MarshaledInvoke(System.Windows.Forms.Control, System.Delegate, System.Object[], Boolean)', N'MarshaledInvoke', N'System.Windows.Forms.dll', CAST(N'2018-02-10 22:29:42.900' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (65, N'2be0cd8c-7923-4d51-9726-4222550e5f1b', N'System.InvalidOperationException: Invoke or BeginInvoke cannot be called on a control until the window handle has been created.
   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 205', N'System.Windows.Forms', N'', N'   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 205', N'System.Object MarshaledInvoke(System.Windows.Forms.Control, System.Delegate, System.Object[], Boolean)', N'MarshaledInvoke', N'System.Windows.Forms.dll', CAST(N'2018-02-10 22:30:13.010' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (66, N'5795e1b1-becf-4a24-a2e2-3c0828a8ed06', N'System.InvalidOperationException: Invoke or BeginInvoke cannot be called on a control until the window handle has been created.
   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 205', N'System.Windows.Forms', N'', N'   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 205', N'System.Object MarshaledInvoke(System.Windows.Forms.Control, System.Delegate, System.Object[], Boolean)', N'MarshaledInvoke', N'System.Windows.Forms.dll', CAST(N'2018-02-10 22:30:43.053' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (67, N'9dd8d9db-b323-4cba-871f-ecf6423cac07', N'System.InvalidOperationException: Invoke or BeginInvoke cannot be called on a control until the window handle has been created.
   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 205', N'System.Windows.Forms', N'', N'   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 205', N'System.Object MarshaledInvoke(System.Windows.Forms.Control, System.Delegate, System.Object[], Boolean)', N'MarshaledInvoke', N'System.Windows.Forms.dll', CAST(N'2018-02-10 22:31:13.140' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (68, N'646431be-90e7-4b43-91c2-64e32f02b510', N'System.InvalidOperationException: Invoke or BeginInvoke cannot be called on a control until the window handle has been created.
   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 205', N'System.Windows.Forms', N'', N'   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 205', N'System.Object MarshaledInvoke(System.Windows.Forms.Control, System.Delegate, System.Object[], Boolean)', N'MarshaledInvoke', N'System.Windows.Forms.dll', CAST(N'2018-02-10 22:31:43.207' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (69, N'490192cc-ee3b-4657-acfc-6d4ff6082b3b', N'System.InvalidOperationException: Invoke or BeginInvoke cannot be called on a control until the window handle has been created.
   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 205', N'System.Windows.Forms', N'', N'   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 205', N'System.Object MarshaledInvoke(System.Windows.Forms.Control, System.Delegate, System.Object[], Boolean)', N'MarshaledInvoke', N'System.Windows.Forms.dll', CAST(N'2018-02-10 22:32:13.307' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (70, N'9d0e0ccc-d4c3-4f40-818a-07c078aefd8d', N'System.InvalidOperationException: Invoke or BeginInvoke cannot be called on a control until the window handle has been created.
   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 205', N'System.Windows.Forms', N'', N'   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 205', N'System.Object MarshaledInvoke(System.Windows.Forms.Control, System.Delegate, System.Object[], Boolean)', N'MarshaledInvoke', N'System.Windows.Forms.dll', CAST(N'2018-02-10 22:32:43.350' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (71, N'069aa7f0-053f-45e5-9d54-d56299b8018d', N'System.InvalidOperationException: Invoke or BeginInvoke cannot be called on a control until the window handle has been created.
   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 205', N'System.Windows.Forms', N'', N'   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 205', N'System.Object MarshaledInvoke(System.Windows.Forms.Control, System.Delegate, System.Object[], Boolean)', N'MarshaledInvoke', N'System.Windows.Forms.dll', CAST(N'2018-02-10 22:33:13.463' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (72, N'11ba3d12-54fb-40e4-8f68-0eaea89122c0', N'System.InvalidOperationException: Invoke or BeginInvoke cannot be called on a control until the window handle has been created.
   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 205', N'System.Windows.Forms', N'', N'   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 205', N'System.Object MarshaledInvoke(System.Windows.Forms.Control, System.Delegate, System.Object[], Boolean)', N'MarshaledInvoke', N'System.Windows.Forms.dll', CAST(N'2018-02-10 22:33:43.520' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (73, N'a616bfb1-3bc1-4c83-879b-db80639356e4', N'System.InvalidOperationException: Invoke or BeginInvoke cannot be called on a control until the window handle has been created.
   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 205', N'System.Windows.Forms', N'', N'   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 205', N'System.Object MarshaledInvoke(System.Windows.Forms.Control, System.Delegate, System.Object[], Boolean)', N'MarshaledInvoke', N'System.Windows.Forms.dll', CAST(N'2018-02-10 22:34:13.577' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (74, N'19c0eabf-49bd-41b2-ae3e-f94a55147b18', N'System.InvalidOperationException: Invoke or BeginInvoke cannot be called on a control until the window handle has been created.
   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 205', N'System.Windows.Forms', N'', N'   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 205', N'System.Object MarshaledInvoke(System.Windows.Forms.Control, System.Delegate, System.Object[], Boolean)', N'MarshaledInvoke', N'System.Windows.Forms.dll', CAST(N'2018-02-10 22:34:43.677' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (75, N'99c15292-2708-4c4c-b220-343ad543a5e2', N'System.InvalidOperationException: Invoke or BeginInvoke cannot be called on a control until the window handle has been created.
   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 205', N'System.Windows.Forms', N'', N'   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 205', N'System.Object MarshaledInvoke(System.Windows.Forms.Control, System.Delegate, System.Object[], Boolean)', N'MarshaledInvoke', N'System.Windows.Forms.dll', CAST(N'2018-02-10 22:35:13.720' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (76, N'3e58f8c3-c85d-450e-a822-6031dc6000ab', N'System.InvalidOperationException: Invoke or BeginInvoke cannot be called on a control until the window handle has been created.
   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 205', N'System.Windows.Forms', N'', N'   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 205', N'System.Object MarshaledInvoke(System.Windows.Forms.Control, System.Delegate, System.Object[], Boolean)', N'MarshaledInvoke', N'System.Windows.Forms.dll', CAST(N'2018-02-10 22:35:43.830' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (77, N'49c9c107-a455-4e59-8da8-7ac3448c6828', N'System.InvalidOperationException: Invoke or BeginInvoke cannot be called on a control until the window handle has been created.
   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 205', N'System.Windows.Forms', N'', N'   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 205', N'System.Object MarshaledInvoke(System.Windows.Forms.Control, System.Delegate, System.Object[], Boolean)', N'MarshaledInvoke', N'System.Windows.Forms.dll', CAST(N'2018-02-10 22:36:13.863' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (78, N'0e14e616-08ad-4d11-920c-673178d17b2d', N'System.InvalidOperationException: Invoke or BeginInvoke cannot be called on a control until the window handle has been created.
   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 205', N'System.Windows.Forms', N'', N'   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 205', N'System.Object MarshaledInvoke(System.Windows.Forms.Control, System.Delegate, System.Object[], Boolean)', N'MarshaledInvoke', N'System.Windows.Forms.dll', CAST(N'2018-02-10 22:36:43.943' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (79, N'81aee64d-fa0c-493d-ab4b-1b5305907b1b', N'System.InvalidOperationException: Invoke or BeginInvoke cannot be called on a control until the window handle has been created.
   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 205', N'System.Windows.Forms', N'', N'   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 205', N'System.Object MarshaledInvoke(System.Windows.Forms.Control, System.Delegate, System.Object[], Boolean)', N'MarshaledInvoke', N'System.Windows.Forms.dll', CAST(N'2018-02-10 22:37:13.987' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (80, N'b074d828-8563-434b-af91-d8df25e49e06', N'System.InvalidOperationException: Invoke or BeginInvoke cannot be called on a control until the window handle has been created.
   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 205', N'System.Windows.Forms', N'', N'   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 205', N'System.Object MarshaledInvoke(System.Windows.Forms.Control, System.Delegate, System.Object[], Boolean)', N'MarshaledInvoke', N'System.Windows.Forms.dll', CAST(N'2018-02-10 22:37:44.073' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (81, N'1480b72a-bcc0-47ba-9eef-75e3800bdaeb', N'System.InvalidOperationException: Invoke or BeginInvoke cannot be called on a control until the window handle has been created.
   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 205', N'System.Windows.Forms', N'', N'   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 205', N'System.Object MarshaledInvoke(System.Windows.Forms.Control, System.Delegate, System.Object[], Boolean)', N'MarshaledInvoke', N'System.Windows.Forms.dll', CAST(N'2018-02-10 22:38:14.100' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (82, N'cf43f9cd-3a3f-4a66-ae87-2a9ba4546e25', N'System.InvalidOperationException: Invoke or BeginInvoke cannot be called on a control until the window handle has been created.
   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 205', N'System.Windows.Forms', N'', N'   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 205', N'System.Object MarshaledInvoke(System.Windows.Forms.Control, System.Delegate, System.Object[], Boolean)', N'MarshaledInvoke', N'System.Windows.Forms.dll', CAST(N'2018-02-10 22:38:44.193' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (83, N'0d9732ca-68db-42a8-a7a7-61adb947b9f7', N'System.InvalidOperationException: Invoke or BeginInvoke cannot be called on a control until the window handle has been created.
   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 205', N'System.Windows.Forms', N'', N'   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 205', N'System.Object MarshaledInvoke(System.Windows.Forms.Control, System.Delegate, System.Object[], Boolean)', N'MarshaledInvoke', N'System.Windows.Forms.dll', CAST(N'2018-02-10 23:40:20.250' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (84, N'b2b8b992-337b-4d20-af9b-aad9a59551bb', N'System.InvalidOperationException: Invoke or BeginInvoke cannot be called on a control until the window handle has been created.
   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 246', N'System.Windows.Forms', N'', N'   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 246', N'System.Object MarshaledInvoke(System.Windows.Forms.Control, System.Delegate, System.Object[], Boolean)', N'MarshaledInvoke', N'System.Windows.Forms.dll', CAST(N'2018-02-10 23:54:59.760' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (85, N'52cad175-0f9d-47b2-bcfe-8827abaf55bd', N'System.ArgumentException: A chart element with the name ''Salary'' could not be found in the ''SeriesCollection''.
   at System.Windows.Forms.DataVisualization.Charting.ChartNamedElementCollection`1.get_Item(String name)
   at PetrolStation.Forms.Forms.MainForm.fillChart() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 154
   at PetrolStation.Forms.Forms.MainForm.prepare() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 139
   at PetrolStation.Forms.Forms.MainForm.init() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 70
   at PetrolStation.Forms.Forms.MainForm..ctor() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 61
   at PetrolStation.__Program.Main() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\__Program.cs:line 42
   at System.AppDomain._nExecuteAssembly(RuntimeAssembly assembly, String[] args)
   at System.AppDomain.ExecuteAssembly(String assemblyFile, Evidence assemblySecurity, String[] args)
   at Microsoft.VisualStudio.HostingProcess.HostProc.RunUsersAssembly()
   at System.Threading.ThreadHelper.ThreadStart_Context(Object state)
   at System.Threading.ExecutionContext.RunInternal(ExecutionContext executionContext, ContextCallback callback, Object state, Boolean preserveSyncCtx)
   at System.Threading.ExecutionContext.Run(ExecutionContext executionContext, ContextCallback callback, Object state, Boolean preserveSyncCtx)
   at System.Threading.ExecutionContext.Run(ExecutionContext executionContext, ContextCallback callback, Object state)
   at System.Threading.ThreadHelper.ThreadStart()', N'System.Windows.Forms.DataVisualization', N'', N'   at System.Windows.Forms.DataVisualization.Charting.ChartNamedElementCollection`1.get_Item(String name)
   at PetrolStation.Forms.Forms.MainForm.fillChart() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 154
   at PetrolStation.Forms.Forms.MainForm.prepare() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 139
   at PetrolStation.Forms.Forms.MainForm.init() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 70
   at PetrolStation.Forms.Forms.MainForm..ctor() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 61
   at PetrolStation.__Program.Main() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\__Program.cs:line 42
   at System.AppDomain._nExecuteAssembly(RuntimeAssembly assembly, String[] args)
   at System.AppDomain.ExecuteAssembly(String assemblyFile, Evidence assemblySecurity, String[] args)
   at Microsoft.VisualStudio.HostingProcess.HostProc.RunUsersAssembly()
   at System.Threading.ThreadHelper.ThreadStart_Context(Object state)
   at System.Threading.ExecutionContext.RunInternal(ExecutionContext executionContext, ContextCallback callback, Object state, Boolean preserveSyncCtx)
   at System.Threading.ExecutionContext.Run(ExecutionContext executionContext, ContextCallback callback, Object state, Boolean preserveSyncCtx)
   at System.Threading.ExecutionContext.Run(ExecutionContext executionContext, ContextCallback callback, Object state)
   at System.Threading.ThreadHelper.ThreadStart()', N'T get_Item(System.String)', N'get_Item', N'System.Windows.Forms.DataVisualization.dll', CAST(N'2018-02-10 23:54:59.830' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (86, N'50272d78-cecf-4289-a757-eb3033624e76', N'System.InvalidOperationException: Invoke or BeginInvoke cannot be called on a control until the window handle has been created.
   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 246', N'System.Windows.Forms', N'', N'   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 246', N'System.Object MarshaledInvoke(System.Windows.Forms.Control, System.Delegate, System.Object[], Boolean)', N'MarshaledInvoke', N'System.Windows.Forms.dll', CAST(N'2018-02-10 23:55:26.653' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (87, N'a674dac1-f49b-4fa8-bdff-0685fd66bd8f', N'System.ArgumentException: A chart element with the name ''Salary'' could not be found in the ''SeriesCollection''.
   at System.Windows.Forms.DataVisualization.Charting.ChartNamedElementCollection`1.get_Item(String name)
   at PetrolStation.Forms.Forms.MainForm.fillChart() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 156
   at PetrolStation.Forms.Forms.MainForm.prepare() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 139
   at PetrolStation.Forms.Forms.MainForm.init() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 70
   at PetrolStation.Forms.Forms.MainForm..ctor() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 61
   at PetrolStation.__Program.Main() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\__Program.cs:line 42
   at System.AppDomain._nExecuteAssembly(RuntimeAssembly assembly, String[] args)
   at System.AppDomain.ExecuteAssembly(String assemblyFile, Evidence assemblySecurity, String[] args)
   at Microsoft.VisualStudio.HostingProcess.HostProc.RunUsersAssembly()
   at System.Threading.ThreadHelper.ThreadStart_Context(Object state)
   at System.Threading.ExecutionContext.RunInternal(ExecutionContext executionContext, ContextCallback callback, Object state, Boolean preserveSyncCtx)
   at System.Threading.ExecutionContext.Run(ExecutionContext executionContext, ContextCallback callback, Object state, Boolean preserveSyncCtx)
   at System.Threading.ExecutionContext.Run(ExecutionContext executionContext, ContextCallback callback, Object state)
   at System.Threading.ThreadHelper.ThreadStart()', N'System.Windows.Forms.DataVisualization', N'', N'   at System.Windows.Forms.DataVisualization.Charting.ChartNamedElementCollection`1.get_Item(String name)
   at PetrolStation.Forms.Forms.MainForm.fillChart() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 156
   at PetrolStation.Forms.Forms.MainForm.prepare() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 139
   at PetrolStation.Forms.Forms.MainForm.init() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 70
   at PetrolStation.Forms.Forms.MainForm..ctor() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 61
   at PetrolStation.__Program.Main() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\__Program.cs:line 42
   at System.AppDomain._nExecuteAssembly(RuntimeAssembly assembly, String[] args)
   at System.AppDomain.ExecuteAssembly(String assemblyFile, Evidence assemblySecurity, String[] args)
   at Microsoft.VisualStudio.HostingProcess.HostProc.RunUsersAssembly()
   at System.Threading.ThreadHelper.ThreadStart_Context(Object state)
   at System.Threading.ExecutionContext.RunInternal(ExecutionContext executionContext, ContextCallback callback, Object state, Boolean preserveSyncCtx)
   at System.Threading.ExecutionContext.Run(ExecutionContext executionContext, ContextCallback callback, Object state, Boolean preserveSyncCtx)
   at System.Threading.ExecutionContext.Run(ExecutionContext executionContext, ContextCallback callback, Object state)
   at System.Threading.ThreadHelper.ThreadStart()', N'T get_Item(System.String)', N'get_Item', N'System.Windows.Forms.DataVisualization.dll', CAST(N'2018-02-10 23:55:26.700' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (88, N'283c9200-ecbc-4b9b-a410-52c8b04c2a7a', N'System.InvalidOperationException: Invoke or BeginInvoke cannot be called on a control until the window handle has been created.
   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 246', N'System.Windows.Forms', N'', N'   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 246', N'System.Object MarshaledInvoke(System.Windows.Forms.Control, System.Delegate, System.Object[], Boolean)', N'MarshaledInvoke', N'System.Windows.Forms.dll', CAST(N'2018-02-10 23:56:15.907' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (89, N'4ffbcf3f-c02e-4f41-b4f5-cdb4f2a7206a', N'System.ArgumentException: A chart element with the name ''dat'' could not be found in the ''SeriesCollection''.
   at System.Windows.Forms.DataVisualization.Charting.ChartNamedElementCollection`1.get_Item(String name)
   at PetrolStation.Forms.Forms.MainForm.fillChart() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 154
   at PetrolStation.Forms.Forms.MainForm.prepare() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 139
   at PetrolStation.Forms.Forms.MainForm.init() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 70
   at PetrolStation.Forms.Forms.MainForm..ctor() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 61
   at PetrolStation.__Program.Main() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\__Program.cs:line 42
   at System.AppDomain._nExecuteAssembly(RuntimeAssembly assembly, String[] args)
   at System.AppDomain.ExecuteAssembly(String assemblyFile, Evidence assemblySecurity, String[] args)
   at Microsoft.VisualStudio.HostingProcess.HostProc.RunUsersAssembly()
   at System.Threading.ThreadHelper.ThreadStart_Context(Object state)
   at System.Threading.ExecutionContext.RunInternal(ExecutionContext executionContext, ContextCallback callback, Object state, Boolean preserveSyncCtx)
   at System.Threading.ExecutionContext.Run(ExecutionContext executionContext, ContextCallback callback, Object state, Boolean preserveSyncCtx)
   at System.Threading.ExecutionContext.Run(ExecutionContext executionContext, ContextCallback callback, Object state)
   at System.Threading.ThreadHelper.ThreadStart()', N'System.Windows.Forms.DataVisualization', N'', N'   at System.Windows.Forms.DataVisualization.Charting.ChartNamedElementCollection`1.get_Item(String name)
   at PetrolStation.Forms.Forms.MainForm.fillChart() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 154
   at PetrolStation.Forms.Forms.MainForm.prepare() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 139
   at PetrolStation.Forms.Forms.MainForm.init() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 70
   at PetrolStation.Forms.Forms.MainForm..ctor() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 61
   at PetrolStation.__Program.Main() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\__Program.cs:line 42
   at System.AppDomain._nExecuteAssembly(RuntimeAssembly assembly, String[] args)
   at System.AppDomain.ExecuteAssembly(String assemblyFile, Evidence assemblySecurity, String[] args)
   at Microsoft.VisualStudio.HostingProcess.HostProc.RunUsersAssembly()
   at System.Threading.ThreadHelper.ThreadStart_Context(Object state)
   at System.Threading.ExecutionContext.RunInternal(ExecutionContext executionContext, ContextCallback callback, Object state, Boolean preserveSyncCtx)
   at System.Threading.ExecutionContext.Run(ExecutionContext executionContext, ContextCallback callback, Object state, Boolean preserveSyncCtx)
   at System.Threading.ExecutionContext.Run(ExecutionContext executionContext, ContextCallback callback, Object state)
   at System.Threading.ThreadHelper.ThreadStart()', N'T get_Item(System.String)', N'get_Item', N'System.Windows.Forms.DataVisualization.dll', CAST(N'2018-02-10 23:56:15.910' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (90, N'1601aceb-93d6-4160-b0c1-dbe427437131', N'System.ArgumentException: A chart element with the name ''dat_WeekDay'' could not be found in the ''SeriesCollection''.
   at System.Windows.Forms.DataVisualization.Charting.ChartNamedElementCollection`1.get_Item(String name)
   at PetrolStation.Forms.testForm.fillChartByDB() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\testForm.cs:line 40
   at PetrolStation.Forms.testForm..ctor() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\testForm.cs:line 26
   at PetrolStation.__Program.Main() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\__Program.cs:line 34
   at System.AppDomain._nExecuteAssembly(RuntimeAssembly assembly, String[] args)
   at System.AppDomain.ExecuteAssembly(String assemblyFile, Evidence assemblySecurity, String[] args)
   at Microsoft.VisualStudio.HostingProcess.HostProc.RunUsersAssembly()
   at System.Threading.ThreadHelper.ThreadStart_Context(Object state)
   at System.Threading.ExecutionContext.RunInternal(ExecutionContext executionContext, ContextCallback callback, Object state, Boolean preserveSyncCtx)
   at System.Threading.ExecutionContext.Run(ExecutionContext executionContext, ContextCallback callback, Object state, Boolean preserveSyncCtx)
   at System.Threading.ExecutionContext.Run(ExecutionContext executionContext, ContextCallback callback, Object state)
   at System.Threading.ThreadHelper.ThreadStart()', N'System.Windows.Forms.DataVisualization', N'', N'   at System.Windows.Forms.DataVisualization.Charting.ChartNamedElementCollection`1.get_Item(String name)
   at PetrolStation.Forms.testForm.fillChartByDB() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\testForm.cs:line 40
   at PetrolStation.Forms.testForm..ctor() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\testForm.cs:line 26
   at PetrolStation.__Program.Main() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\__Program.cs:line 34
   at System.AppDomain._nExecuteAssembly(RuntimeAssembly assembly, String[] args)
   at System.AppDomain.ExecuteAssembly(String assemblyFile, Evidence assemblySecurity, String[] args)
   at Microsoft.VisualStudio.HostingProcess.HostProc.RunUsersAssembly()
   at System.Threading.ThreadHelper.ThreadStart_Context(Object state)
   at System.Threading.ExecutionContext.RunInternal(ExecutionContext executionContext, ContextCallback callback, Object state, Boolean preserveSyncCtx)
   at System.Threading.ExecutionContext.Run(ExecutionContext executionContext, ContextCallback callback, Object state, Boolean preserveSyncCtx)
   at System.Threading.ExecutionContext.Run(ExecutionContext executionContext, ContextCallback callback, Object state)
   at System.Threading.ThreadHelper.ThreadStart()', N'T get_Item(System.String)', N'get_Item', N'System.Windows.Forms.DataVisualization.dll', CAST(N'2018-02-11 10:54:02.040' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (91, N'ef9892ac-6b3f-4206-9223-11becc8a0d4a', N'System.ArgumentException: A chart element with the name ''dat_WeekDay'' could not be found in the ''SeriesCollection''.
   at System.Windows.Forms.DataVisualization.Charting.ChartNamedElementCollection`1.get_Item(String name)
   at PetrolStation.Forms.testForm.fillChartByDB() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\testForm.cs:line 44
   at PetrolStation.Forms.testForm..ctor() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\testForm.cs:line 26
   at PetrolStation.__Program.Main() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\__Program.cs:line 34
   at System.AppDomain._nExecuteAssembly(RuntimeAssembly assembly, String[] args)
   at System.AppDomain.ExecuteAssembly(String assemblyFile, Evidence assemblySecurity, String[] args)
   at Microsoft.VisualStudio.HostingProcess.HostProc.RunUsersAssembly()
   at System.Threading.ThreadHelper.ThreadStart_Context(Object state)
   at System.Threading.ExecutionContext.RunInternal(ExecutionContext executionContext, ContextCallback callback, Object state, Boolean preserveSyncCtx)
   at System.Threading.ExecutionContext.Run(ExecutionContext executionContext, ContextCallback callback, Object state, Boolean preserveSyncCtx)
   at System.Threading.ExecutionContext.Run(ExecutionContext executionContext, ContextCallback callback, Object state)
   at System.Threading.ThreadHelper.ThreadStart()', N'System.Windows.Forms.DataVisualization', N'', N'   at System.Windows.Forms.DataVisualization.Charting.ChartNamedElementCollection`1.get_Item(String name)
   at PetrolStation.Forms.testForm.fillChartByDB() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\testForm.cs:line 44
   at PetrolStation.Forms.testForm..ctor() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\testForm.cs:line 26
   at PetrolStation.__Program.Main() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\__Program.cs:line 34
   at System.AppDomain._nExecuteAssembly(RuntimeAssembly assembly, String[] args)
   at System.AppDomain.ExecuteAssembly(String assemblyFile, Evidence assemblySecurity, String[] args)
   at Microsoft.VisualStudio.HostingProcess.HostProc.RunUsersAssembly()
   at System.Threading.ThreadHelper.ThreadStart_Context(Object state)
   at System.Threading.ExecutionContext.RunInternal(ExecutionContext executionContext, ContextCallback callback, Object state, Boolean preserveSyncCtx)
   at System.Threading.ExecutionContext.Run(ExecutionContext executionContext, ContextCallback callback, Object state, Boolean preserveSyncCtx)
   at System.Threading.ExecutionContext.Run(ExecutionContext executionContext, ContextCallback callback, Object state)
   at System.Threading.ThreadHelper.ThreadStart()', N'T get_Item(System.String)', N'get_Item', N'System.Windows.Forms.DataVisualization.dll', CAST(N'2018-02-11 11:42:50.700' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (92, N'd17afd57-09bc-40f2-931f-fd3f73c9a253', N'System.InvalidOperationException: Chart Area Axes - The chart area contains incompatible chart types. For example, bar charts and column charts cannot exist in the same chart area.
   at System.Windows.Forms.DataVisualization.Charting.ChartArea.SetData(Boolean initializeAxes, Boolean checkIndexedAligned)
   at System.Windows.Forms.DataVisualization.Charting.ChartArea.ReCalcInternal()
   at System.Windows.Forms.DataVisualization.Charting.ChartPicture.Paint(Graphics graph, Boolean paintTopLevelElementOnly)
   at System.Windows.Forms.DataVisualization.Charting.Chart.OnPaint(PaintEventArgs e)
   at System.Windows.Forms.Control.PaintWithErrorHandling(PaintEventArgs e, Int16 layer)
   at System.Windows.Forms.Control.WmPaint(Message& m)
   at System.Windows.Forms.Control.WndProc(Message& m)
   at System.Windows.Forms.Control.ControlNativeWindow.OnMessage(Message& m)
   at System.Windows.Forms.Control.ControlNativeWindow.WndProc(Message& m)
   at System.Windows.Forms.NativeWindow.Callback(IntPtr hWnd, Int32 msg, IntPtr wparam, IntPtr lparam)', N'System.Windows.Forms.DataVisualization', N'', N'   at System.Windows.Forms.DataVisualization.Charting.ChartArea.SetData(Boolean initializeAxes, Boolean checkIndexedAligned)
   at System.Windows.Forms.DataVisualization.Charting.ChartArea.ReCalcInternal()
   at System.Windows.Forms.DataVisualization.Charting.ChartPicture.Paint(Graphics graph, Boolean paintTopLevelElementOnly)
   at System.Windows.Forms.DataVisualization.Charting.Chart.OnPaint(PaintEventArgs e)
   at System.Windows.Forms.Control.PaintWithErrorHandling(PaintEventArgs e, Int16 layer)
   at System.Windows.Forms.Control.WmPaint(Message& m)
   at System.Windows.Forms.Control.WndProc(Message& m)
   at System.Windows.Forms.Control.ControlNativeWindow.OnMessage(Message& m)
   at System.Windows.Forms.Control.ControlNativeWindow.WndProc(Message& m)
   at System.Windows.Forms.NativeWindow.Callback(IntPtr hWnd, Int32 msg, IntPtr wparam, IntPtr lparam)', N'Void SetData(Boolean, Boolean)', N'SetData', N'System.Windows.Forms.DataVisualization.dll', CAST(N'2018-02-11 11:54:11.773' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (93, N'3012d11e-2bbd-4ece-97c6-b7f61fba7ca7', N'System.InvalidOperationException: Chart Area Axes - The chart area contains incompatible chart types. For example, bar charts and column charts cannot exist in the same chart area.
   at System.Windows.Forms.DataVisualization.Charting.ChartArea.SetData(Boolean initializeAxes, Boolean checkIndexedAligned)
   at System.Windows.Forms.DataVisualization.Charting.ChartArea.ReCalcInternal()
   at System.Windows.Forms.DataVisualization.Charting.ChartPicture.Paint(Graphics graph, Boolean paintTopLevelElementOnly)
   at System.Windows.Forms.DataVisualization.Charting.Chart.OnPaint(PaintEventArgs e)
   at System.Windows.Forms.Control.PaintWithErrorHandling(PaintEventArgs e, Int16 layer)
   at System.Windows.Forms.Control.WmPaint(Message& m)
   at System.Windows.Forms.Control.WndProc(Message& m)
   at System.Windows.Forms.Control.ControlNativeWindow.OnMessage(Message& m)
   at System.Windows.Forms.Control.ControlNativeWindow.WndProc(Message& m)
   at System.Windows.Forms.NativeWindow.Callback(IntPtr hWnd, Int32 msg, IntPtr wparam, IntPtr lparam)', N'System.Windows.Forms.DataVisualization', N'', N'   at System.Windows.Forms.DataVisualization.Charting.ChartArea.SetData(Boolean initializeAxes, Boolean checkIndexedAligned)
   at System.Windows.Forms.DataVisualization.Charting.ChartArea.ReCalcInternal()
   at System.Windows.Forms.DataVisualization.Charting.ChartPicture.Paint(Graphics graph, Boolean paintTopLevelElementOnly)
   at System.Windows.Forms.DataVisualization.Charting.Chart.OnPaint(PaintEventArgs e)
   at System.Windows.Forms.Control.PaintWithErrorHandling(PaintEventArgs e, Int16 layer)
   at System.Windows.Forms.Control.WmPaint(Message& m)
   at System.Windows.Forms.Control.WndProc(Message& m)
   at System.Windows.Forms.Control.ControlNativeWindow.OnMessage(Message& m)
   at System.Windows.Forms.Control.ControlNativeWindow.WndProc(Message& m)
   at System.Windows.Forms.NativeWindow.Callback(IntPtr hWnd, Int32 msg, IntPtr wparam, IntPtr lparam)', N'Void SetData(Boolean, Boolean)', N'SetData', N'System.Windows.Forms.DataVisualization.dll', CAST(N'2018-02-11 13:47:31.097' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (94, N'c7202f8d-d5de-42f8-abc1-124299df1d1b', N'System.InvalidOperationException: Funnel chart cannot be combined with any other chart type in a single chart area.
   at System.Windows.Forms.DataVisualization.Charting.ChartTypes.FunnelChart.GetDataSeries()
   at System.Windows.Forms.DataVisualization.Charting.ChartTypes.FunnelChart.GetDataPointValuesStatistic()
   at System.Windows.Forms.DataVisualization.Charting.ChartTypes.FunnelChart.Paint(ChartGraphics graph, CommonElements common, ChartArea area, Series seriesToDraw)
   at System.Windows.Forms.DataVisualization.Charting.ChartArea.Paint(ChartGraphics graph)
   at System.Windows.Forms.DataVisualization.Charting.ChartPicture.Paint(Graphics graph, Boolean paintTopLevelElementOnly)
   at System.Windows.Forms.DataVisualization.Charting.Chart.OnPaint(PaintEventArgs e)
   at System.Windows.Forms.Control.PaintWithErrorHandling(PaintEventArgs e, Int16 layer)
   at System.Windows.Forms.Control.WmPaint(Message& m)
   at System.Windows.Forms.Control.WndProc(Message& m)
   at System.Windows.Forms.Control.ControlNativeWindow.OnMessage(Message& m)
   at System.Windows.Forms.Control.ControlNativeWindow.WndProc(Message& m)
   at System.Windows.Forms.NativeWindow.Callback(IntPtr hWnd, Int32 msg, IntPtr wparam, IntPtr lparam)', N'System.Windows.Forms.DataVisualization', N'', N'   at System.Windows.Forms.DataVisualization.Charting.ChartTypes.FunnelChart.GetDataSeries()
   at System.Windows.Forms.DataVisualization.Charting.ChartTypes.FunnelChart.GetDataPointValuesStatistic()
   at System.Windows.Forms.DataVisualization.Charting.ChartTypes.FunnelChart.Paint(ChartGraphics graph, CommonElements common, ChartArea area, Series seriesToDraw)
   at System.Windows.Forms.DataVisualization.Charting.ChartArea.Paint(ChartGraphics graph)
   at System.Windows.Forms.DataVisualization.Charting.ChartPicture.Paint(Graphics graph, Boolean paintTopLevelElementOnly)
   at System.Windows.Forms.DataVisualization.Charting.Chart.OnPaint(PaintEventArgs e)
   at System.Windows.Forms.Control.PaintWithErrorHandling(PaintEventArgs e, Int16 layer)
   at System.Windows.Forms.Control.WmPaint(Message& m)
   at System.Windows.Forms.Control.WndProc(Message& m)
   at System.Windows.Forms.Control.ControlNativeWindow.OnMessage(Message& m)
   at System.Windows.Forms.Control.ControlNativeWindow.WndProc(Message& m)
   at System.Windows.Forms.NativeWindow.Callback(IntPtr hWnd, Int32 msg, IntPtr wparam, IntPtr lparam)', N'System.Windows.Forms.DataVisualization.Charting.Series GetDataSeries()', N'GetDataSeries', N'System.Windows.Forms.DataVisualization.dll', CAST(N'2018-02-11 13:47:49.090' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (95, N'12420e55-1b9b-47e8-8791-f1a8d35e2ae7', N'System.InvalidOperationException: Series with chart type ''Column'' cannot be displayed in the chart area. Only Radar chart types can be used.
   at System.Windows.Forms.DataVisualization.Charting.ChartTypes.RadarChart.ProcessChartType(Boolean selection, ChartGraphics graph, CommonElements common, ChartArea area, Series seriesToDraw)
   at System.Windows.Forms.DataVisualization.Charting.ChartTypes.RadarChart.Paint(ChartGraphics graph, CommonElements common, ChartArea area, Series seriesToDraw)
   at System.Windows.Forms.DataVisualization.Charting.ChartArea.Paint(ChartGraphics graph)
   at System.Windows.Forms.DataVisualization.Charting.ChartPicture.Paint(Graphics graph, Boolean paintTopLevelElementOnly)
   at System.Windows.Forms.DataVisualization.Charting.Chart.OnPaint(PaintEventArgs e)
   at System.Windows.Forms.Control.PaintWithErrorHandling(PaintEventArgs e, Int16 layer)
   at System.Windows.Forms.Control.WmPaint(Message& m)
   at System.Windows.Forms.Control.WndProc(Message& m)
   at System.Windows.Forms.Control.ControlNativeWindow.OnMessage(Message& m)
   at System.Windows.Forms.Control.ControlNativeWindow.WndProc(Message& m)
   at System.Windows.Forms.NativeWindow.Callback(IntPtr hWnd, Int32 msg, IntPtr wparam, IntPtr lparam)', N'System.Windows.Forms.DataVisualization', N'', N'   at System.Windows.Forms.DataVisualization.Charting.ChartTypes.RadarChart.ProcessChartType(Boolean selection, ChartGraphics graph, CommonElements common, ChartArea area, Series seriesToDraw)
   at System.Windows.Forms.DataVisualization.Charting.ChartTypes.RadarChart.Paint(ChartGraphics graph, CommonElements common, ChartArea area, Series seriesToDraw)
   at System.Windows.Forms.DataVisualization.Charting.ChartArea.Paint(ChartGraphics graph)
   at System.Windows.Forms.DataVisualization.Charting.ChartPicture.Paint(Graphics graph, Boolean paintTopLevelElementOnly)
   at System.Windows.Forms.DataVisualization.Charting.Chart.OnPaint(PaintEventArgs e)
   at System.Windows.Forms.Control.PaintWithErrorHandling(PaintEventArgs e, Int16 layer)
   at System.Windows.Forms.Control.WmPaint(Message& m)
   at System.Windows.Forms.Control.WndProc(Message& m)
   at System.Windows.Forms.Control.ControlNativeWindow.OnMessage(Message& m)
   at System.Windows.Forms.Control.ControlNativeWindow.WndProc(Message& m)
   at System.Windows.Forms.NativeWindow.Callback(IntPtr hWnd, Int32 msg, IntPtr wparam, IntPtr lparam)', N'Void ProcessChartType(Boolean, System.Windows.Forms.DataVisualization.Charting.ChartGraphics, System.Windows.Forms.DataVisualization.Charting.CommonElements, System.Windows.Forms.DataVisualization.Charting.ChartArea, System.Windows.Forms.DataVisualization.Charting.Series)', N'ProcessChartType', N'System.Windows.Forms.DataVisualization.dll', CAST(N'2018-02-11 13:48:00.917' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (96, N'8f580437-0aab-4ecb-9f51-71f14a78f2d0', N'System.ArgumentException: A chart element with the name ''تردد ها'' already exists in the ''SeriesCollection''.
   at System.Windows.Forms.DataVisualization.Charting.ChartNamedElementCollection`1.InsertItem(Int32 index, T item)
   at System.Collections.ObjectModel.Collection`1.Add(T item)
   at PetrolStation.Forms.testForm.fillChartByDB() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\testForm.cs:line 43
   at PetrolStation.Forms.testForm..ctor() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\testForm.cs:line 26
   at PetrolStation.__Program.Main() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\__Program.cs:line 34
   at System.AppDomain._nExecuteAssembly(RuntimeAssembly assembly, String[] args)
   at System.AppDomain.ExecuteAssembly(String assemblyFile, Evidence assemblySecurity, String[] args)
   at Microsoft.VisualStudio.HostingProcess.HostProc.RunUsersAssembly()
   at System.Threading.ThreadHelper.ThreadStart_Context(Object state)
   at System.Threading.ExecutionContext.RunInternal(ExecutionContext executionContext, ContextCallback callback, Object state, Boolean preserveSyncCtx)
   at System.Threading.ExecutionContext.Run(ExecutionContext executionContext, ContextCallback callback, Object state, Boolean preserveSyncCtx)
   at System.Threading.ExecutionContext.Run(ExecutionContext executionContext, ContextCallback callback, Object state)
   at System.Threading.ThreadHelper.ThreadStart()', N'System.Windows.Forms.DataVisualization', N'', N'   at System.Windows.Forms.DataVisualization.Charting.ChartNamedElementCollection`1.InsertItem(Int32 index, T item)
   at System.Collections.ObjectModel.Collection`1.Add(T item)
   at PetrolStation.Forms.testForm.fillChartByDB() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\testForm.cs:line 43
   at PetrolStation.Forms.testForm..ctor() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\testForm.cs:line 26
   at PetrolStation.__Program.Main() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\__Program.cs:line 34
   at System.AppDomain._nExecuteAssembly(RuntimeAssembly assembly, String[] args)
   at System.AppDomain.ExecuteAssembly(String assemblyFile, Evidence assemblySecurity, String[] args)
   at Microsoft.VisualStudio.HostingProcess.HostProc.RunUsersAssembly()
   at System.Threading.ThreadHelper.ThreadStart_Context(Object state)
   at System.Threading.ExecutionContext.RunInternal(ExecutionContext executionContext, ContextCallback callback, Object state, Boolean preserveSyncCtx)
   at System.Threading.ExecutionContext.Run(ExecutionContext executionContext, ContextCallback callback, Object state, Boolean preserveSyncCtx)
   at System.Threading.ExecutionContext.Run(ExecutionContext executionContext, ContextCallback callback, Object state)
   at System.Threading.ThreadHelper.ThreadStart()', N'Void InsertItem(Int32, T)', N'InsertItem', N'System.Windows.Forms.DataVisualization.dll', CAST(N'2018-02-11 13:54:22.157' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (97, N'5d1d1830-f181-4715-b69b-6fb933bc6599', N'System.InvalidOperationException: Invoke or BeginInvoke cannot be called on a control until the window handle has been created.
   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 234', N'System.Windows.Forms', N'', N'   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 234', N'System.Object MarshaledInvoke(System.Windows.Forms.Control, System.Delegate, System.Object[], Boolean)', N'MarshaledInvoke', N'System.Windows.Forms.dll', CAST(N'2018-02-11 14:01:00.410' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (98, N'8bdeba05-a7e2-479c-8795-a549b2c07337', N'System.InvalidOperationException: Invoke or BeginInvoke cannot be called on a control until the window handle has been created.
   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 234', N'System.Windows.Forms', N'', N'   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 234', N'System.Object MarshaledInvoke(System.Windows.Forms.Control, System.Delegate, System.Object[], Boolean)', N'MarshaledInvoke', N'System.Windows.Forms.dll', CAST(N'2018-02-11 14:03:00.873' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (99, N'7989f66c-a971-41fd-9685-0d9e70cfca72', N'System.InvalidOperationException: Invoke or BeginInvoke cannot be called on a control until the window handle has been created.
   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 234', N'System.Windows.Forms', N'', N'   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 234', N'System.Object MarshaledInvoke(System.Windows.Forms.Control, System.Delegate, System.Object[], Boolean)', N'MarshaledInvoke', N'System.Windows.Forms.dll', CAST(N'2018-02-11 14:03:30.947' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (100, N'd8d925a8-8b3b-4ac6-8c20-a225cf21b27e', N'System.ArgumentException: A chart element with the name ''تردد ها'' already exists in the ''SeriesCollection''.
   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.fillChart() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 154
   at PetrolStation.Forms.Forms.MainForm.<startLoadThread>b__12_0() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 187', N'System.Windows.Forms', N'', N'   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.fillChart() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 154
   at PetrolStation.Forms.Forms.MainForm.<startLoadThread>b__12_0() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 187', N'System.Object MarshaledInvoke(System.Windows.Forms.Control, System.Delegate, System.Object[], Boolean)', N'MarshaledInvoke', N'System.Windows.Forms.dll', CAST(N'2018-02-11 14:11:23.757' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (101, N'2a4a87aa-0b97-453b-bba9-dbd714c10c79', N'System.InvalidOperationException: Cross-thread operation not valid: Control ''trafficChart'' accessed from a thread other than the thread it was created on.
   at System.Windows.Forms.Control.get_Handle()
   at System.Windows.Forms.Control.Invalidate(Boolean invalidateChildren)
   at System.Windows.Forms.DataVisualization.Charting.Chart.Invalidate()
   at System.Windows.Forms.DataVisualization.Charting.Data.DataManager.Invalidate()
   at System.Windows.Forms.DataVisualization.Charting.ChartElement.System.Windows.Forms.DataVisualization.Charting.IChartElement.Invalidate()
   at System.Windows.Forms.DataVisualization.Charting.ChartElementCollection`1.Invalidate()
   at System.Windows.Forms.DataVisualization.Charting.ChartElementCollection`1.System.Windows.Forms.DataVisualization.Charting.IChartElement.Invalidate()
   at System.Windows.Forms.DataVisualization.Charting.ChartElement.Invalidate()
   at System.Windows.Forms.DataVisualization.Charting.ChartElement.System.Windows.Forms.DataVisualization.Charting.IChartElement.Invalidate()
   at System.Windows.Forms.DataVisualization.Charting.ChartElementCollection`1.Invalidate()
   at System.Windows.Forms.DataVisualization.Charting.ChartElementCollection`1.ResumeUpdates()
   at System.Windows.Forms.DataVisualization.Charting.ChartElementCollection`1.ClearItems()
   at System.Windows.Forms.DataVisualization.Charting.DataPointCollection.ClearItems()
   at System.Collections.ObjectModel.Collection`1.Clear()
   at PetrolStation.Forms.Forms.MainForm.fillChart() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 165
   at PetrolStation.Forms.Forms.MainForm.<startLoadThread>b__14_0() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 200', N'System.Windows.Forms', N'', N'   at System.Windows.Forms.Control.get_Handle()
   at System.Windows.Forms.Control.Invalidate(Boolean invalidateChildren)
   at System.Windows.Forms.DataVisualization.Charting.Chart.Invalidate()
   at System.Windows.Forms.DataVisualization.Charting.Data.DataManager.Invalidate()
   at System.Windows.Forms.DataVisualization.Charting.ChartElement.System.Windows.Forms.DataVisualization.Charting.IChartElement.Invalidate()
   at System.Windows.Forms.DataVisualization.Charting.ChartElementCollection`1.Invalidate()
   at System.Windows.Forms.DataVisualization.Charting.ChartElementCollection`1.System.Windows.Forms.DataVisualization.Charting.IChartElement.Invalidate()
   at System.Windows.Forms.DataVisualization.Charting.ChartElement.Invalidate()
   at System.Windows.Forms.DataVisualization.Charting.ChartElement.System.Windows.Forms.DataVisualization.Charting.IChartElement.Invalidate()
   at System.Windows.Forms.DataVisualization.Charting.ChartElementCollection`1.Invalidate()
   at System.Windows.Forms.DataVisualization.Charting.ChartElementCollection`1.ResumeUpdates()
   at System.Windows.Forms.DataVisualization.Charting.ChartElementCollection`1.ClearItems()
   at System.Windows.Forms.DataVisualization.Charting.DataPointCollection.ClearItems()
   at System.Collections.ObjectModel.Collection`1.Clear()
   at PetrolStation.Forms.Forms.MainForm.fillChart() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 165
   at PetrolStation.Forms.Forms.MainForm.<startLoadThread>b__14_0() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 200', N'IntPtr get_Handle()', N'get_Handle', N'System.Windows.Forms.dll', CAST(N'2018-02-11 14:16:15.170' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (102, N'7b7e0f54-4b06-4d21-ba97-2cd0f0e490d2', N'System.InvalidOperationException: Invoke or BeginInvoke cannot be called on a control until the window handle has been created.
   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 249', N'System.Windows.Forms', N'', N'   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 249', N'System.Object MarshaledInvoke(System.Windows.Forms.Control, System.Delegate, System.Object[], Boolean)', N'MarshaledInvoke', N'System.Windows.Forms.dll', CAST(N'2018-02-11 14:23:22.330' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (103, N'47e0e5a0-eba3-4c60-871e-040048b2f8e1', N'System.InvalidOperationException: Invoke or BeginInvoke cannot be called on a control until the window handle has been created.
   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.fillChart() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 174
   at PetrolStation.Forms.Forms.MainForm.<startLoadThread>b__14_0() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 203', N'System.Windows.Forms', N'', N'   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.fillChart() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 174
   at PetrolStation.Forms.Forms.MainForm.<startLoadThread>b__14_0() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 203', N'System.Object MarshaledInvoke(System.Windows.Forms.Control, System.Delegate, System.Object[], Boolean)', N'MarshaledInvoke', N'System.Windows.Forms.dll', CAST(N'2018-02-11 14:23:22.407' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (104, N'21327f3a-da74-4288-8f32-349ffba3077e', N'System.InvalidOperationException: Invoke or BeginInvoke cannot be called on a control until the window handle has been created.
   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 250', N'System.Windows.Forms', N'', N'   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 250', N'System.Object MarshaledInvoke(System.Windows.Forms.Control, System.Delegate, System.Object[], Boolean)', N'MarshaledInvoke', N'System.Windows.Forms.dll', CAST(N'2018-02-11 14:23:55.360' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (105, N'bc7b74ec-6d84-44b6-9f0c-272a74fded73', N'System.InvalidOperationException: Invoke or BeginInvoke cannot be called on a control until the window handle has been created.
   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 248', N'System.Windows.Forms', N'', N'   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 248', N'System.Object MarshaledInvoke(System.Windows.Forms.Control, System.Delegate, System.Object[], Boolean)', N'MarshaledInvoke', N'System.Windows.Forms.dll', CAST(N'2018-02-11 14:36:05.437' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (106, N'f0748ff2-215e-468b-bf67-fb1a7f28744b', N'System.InvalidOperationException: Invoke or BeginInvoke cannot be called on a control until the window handle has been created.
   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.fillChart() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 173
   at PetrolStation.Forms.Forms.MainForm.<startLoadThread>b__14_0() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 202', N'System.Windows.Forms', N'', N'   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.fillChart() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 173
   at PetrolStation.Forms.Forms.MainForm.<startLoadThread>b__14_0() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 202', N'System.Object MarshaledInvoke(System.Windows.Forms.Control, System.Delegate, System.Object[], Boolean)', N'MarshaledInvoke', N'System.Windows.Forms.dll', CAST(N'2018-02-11 14:36:05.543' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (107, N'4394d4bc-1ddf-48ec-9ad5-5b842890af77', N'System.IndexOutOfRangeException: There is no row at position 2.
   at System.Data.RBTree`1.GetNodeByIndex(Int32 userIndex)
   at System.Data.DataRowCollection.get_Item(Int32 index)
   at PetrolStation.Forms.testForm.button2_Click(Object sender, EventArgs e) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\testForm.cs:line 168
   at System.Windows.Forms.Control.OnClick(EventArgs e)
   at System.Windows.Forms.Button.OnClick(EventArgs e)
   at System.Windows.Forms.Button.OnMouseUp(MouseEventArgs mevent)
   at System.Windows.Forms.Control.WmMouseUp(Message& m, MouseButtons button, Int32 clicks)
   at System.Windows.Forms.Control.WndProc(Message& m)
   at System.Windows.Forms.ButtonBase.WndProc(Message& m)
   at System.Windows.Forms.Button.WndProc(Message& m)
   at System.Windows.Forms.Control.ControlNativeWindow.OnMessage(Message& m)
   at System.Windows.Forms.Control.ControlNativeWindow.WndProc(Message& m)
   at System.Windows.Forms.NativeWindow.Callback(IntPtr hWnd, Int32 msg, IntPtr wparam, IntPtr lparam)', N'System.Data', N'', N'   at System.Data.RBTree`1.GetNodeByIndex(Int32 userIndex)
   at System.Data.DataRowCollection.get_Item(Int32 index)
   at PetrolStation.Forms.testForm.button2_Click(Object sender, EventArgs e) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\testForm.cs:line 168
   at System.Windows.Forms.Control.OnClick(EventArgs e)
   at System.Windows.Forms.Button.OnClick(EventArgs e)
   at System.Windows.Forms.Button.OnMouseUp(MouseEventArgs mevent)
   at System.Windows.Forms.Control.WmMouseUp(Message& m, MouseButtons button, Int32 clicks)
   at System.Windows.Forms.Control.WndProc(Message& m)
   at System.Windows.Forms.ButtonBase.WndProc(Message& m)
   at System.Windows.Forms.Button.WndProc(Message& m)
   at System.Windows.Forms.Control.ControlNativeWindow.OnMessage(Message& m)
   at System.Windows.Forms.Control.ControlNativeWindow.WndProc(Message& m)
   at System.Windows.Forms.NativeWindow.Callback(IntPtr hWnd, Int32 msg, IntPtr wparam, IntPtr lparam)', N'NodePath GetNodeByIndex(Int32)', N'GetNodeByIndex', N'System.Data.dll', CAST(N'2018-02-17 09:55:41.250' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (108, N'7049114b-a2e5-41f6-8f1c-dc60dd6b69fa', N'System.ArgumentException: Column ''total'' does not belong to table .
   at System.Data.DataRow.GetDataColumn(String columnName)
   at System.Data.DataRow.get_Item(String columnName)
   at PetrolStation.Forms.testForm.button2_Click(Object sender, EventArgs e) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\testForm.cs:line 168
   at System.Windows.Forms.Control.OnClick(EventArgs e)
   at System.Windows.Forms.Button.OnClick(EventArgs e)
   at System.Windows.Forms.Button.OnMouseUp(MouseEventArgs mevent)
   at System.Windows.Forms.Control.WmMouseUp(Message& m, MouseButtons button, Int32 clicks)
   at System.Windows.Forms.Control.WndProc(Message& m)
   at System.Windows.Forms.ButtonBase.WndProc(Message& m)
   at System.Windows.Forms.Button.WndProc(Message& m)
   at System.Windows.Forms.Control.ControlNativeWindow.OnMessage(Message& m)
   at System.Windows.Forms.Control.ControlNativeWindow.WndProc(Message& m)
   at System.Windows.Forms.NativeWindow.Callback(IntPtr hWnd, Int32 msg, IntPtr wparam, IntPtr lparam)', N'System.Data', N'', N'   at System.Data.DataRow.GetDataColumn(String columnName)
   at System.Data.DataRow.get_Item(String columnName)
   at PetrolStation.Forms.testForm.button2_Click(Object sender, EventArgs e) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\testForm.cs:line 168
   at System.Windows.Forms.Control.OnClick(EventArgs e)
   at System.Windows.Forms.Button.OnClick(EventArgs e)
   at System.Windows.Forms.Button.OnMouseUp(MouseEventArgs mevent)
   at System.Windows.Forms.Control.WmMouseUp(Message& m, MouseButtons button, Int32 clicks)
   at System.Windows.Forms.Control.WndProc(Message& m)
   at System.Windows.Forms.ButtonBase.WndProc(Message& m)
   at System.Windows.Forms.Button.WndProc(Message& m)
   at System.Windows.Forms.Control.ControlNativeWindow.OnMessage(Message& m)
   at System.Windows.Forms.Control.ControlNativeWindow.WndProc(Message& m)
   at System.Windows.Forms.NativeWindow.Callback(IntPtr hWnd, Int32 msg, IntPtr wparam, IntPtr lparam)', N'System.Data.DataColumn GetDataColumn(System.String)', N'GetDataColumn', N'System.Data.dll', CAST(N'2018-02-17 09:56:42.857' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (109, N'15fbb1f1-eae5-4430-b668-4ac71c82b405', N'System.ArgumentException: Column ''total'' does not belong to table .
   at System.Data.DataRow.GetDataColumn(String columnName)
   at System.Data.DataRow.get_Item(String columnName)
   at PetrolStation.Forms.testForm.button2_Click(Object sender, EventArgs e) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\testForm.cs:line 168
   at System.Windows.Forms.Control.OnClick(EventArgs e)
   at System.Windows.Forms.Button.OnClick(EventArgs e)
   at System.Windows.Forms.Button.OnMouseUp(MouseEventArgs mevent)
   at System.Windows.Forms.Control.WmMouseUp(Message& m, MouseButtons button, Int32 clicks)
   at System.Windows.Forms.Control.WndProc(Message& m)
   at System.Windows.Forms.ButtonBase.WndProc(Message& m)
   at System.Windows.Forms.Button.WndProc(Message& m)
   at System.Windows.Forms.Control.ControlNativeWindow.OnMessage(Message& m)
   at System.Windows.Forms.Control.ControlNativeWindow.WndProc(Message& m)
   at System.Windows.Forms.NativeWindow.Callback(IntPtr hWnd, Int32 msg, IntPtr wparam, IntPtr lparam)', N'System.Data', N'', N'   at System.Data.DataRow.GetDataColumn(String columnName)
   at System.Data.DataRow.get_Item(String columnName)
   at PetrolStation.Forms.testForm.button2_Click(Object sender, EventArgs e) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\testForm.cs:line 168
   at System.Windows.Forms.Control.OnClick(EventArgs e)
   at System.Windows.Forms.Button.OnClick(EventArgs e)
   at System.Windows.Forms.Button.OnMouseUp(MouseEventArgs mevent)
   at System.Windows.Forms.Control.WmMouseUp(Message& m, MouseButtons button, Int32 clicks)
   at System.Windows.Forms.Control.WndProc(Message& m)
   at System.Windows.Forms.ButtonBase.WndProc(Message& m)
   at System.Windows.Forms.Button.WndProc(Message& m)
   at System.Windows.Forms.Control.ControlNativeWindow.OnMessage(Message& m)
   at System.Windows.Forms.Control.ControlNativeWindow.WndProc(Message& m)
   at System.Windows.Forms.NativeWindow.Callback(IntPtr hWnd, Int32 msg, IntPtr wparam, IntPtr lparam)', N'System.Data.DataColumn GetDataColumn(System.String)', N'GetDataColumn', N'System.Data.dll', CAST(N'2018-02-17 09:57:39.493' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (110, N'44993a12-4798-4451-81d2-1db0ad673d68', N'System.ArgumentException: Column ''total'' does not belong to table .
   at System.Data.DataRow.GetDataColumn(String columnName)
   at System.Data.DataRow.get_Item(String columnName)
   at PetrolStation.Forms.testForm.button2_Click(Object sender, EventArgs e) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\testForm.cs:line 167
   at System.Windows.Forms.Control.OnClick(EventArgs e)
   at System.Windows.Forms.Button.OnClick(EventArgs e)
   at System.Windows.Forms.Button.OnMouseUp(MouseEventArgs mevent)
   at System.Windows.Forms.Control.WmMouseUp(Message& m, MouseButtons button, Int32 clicks)
   at System.Windows.Forms.Control.WndProc(Message& m)
   at System.Windows.Forms.ButtonBase.WndProc(Message& m)
   at System.Windows.Forms.Button.WndProc(Message& m)
   at System.Windows.Forms.Control.ControlNativeWindow.OnMessage(Message& m)
   at System.Windows.Forms.Control.ControlNativeWindow.WndProc(Message& m)
   at System.Windows.Forms.NativeWindow.Callback(IntPtr hWnd, Int32 msg, IntPtr wparam, IntPtr lparam)', N'System.Data', N'', N'   at System.Data.DataRow.GetDataColumn(String columnName)
   at System.Data.DataRow.get_Item(String columnName)
   at PetrolStation.Forms.testForm.button2_Click(Object sender, EventArgs e) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\testForm.cs:line 167
   at System.Windows.Forms.Control.OnClick(EventArgs e)
   at System.Windows.Forms.Button.OnClick(EventArgs e)
   at System.Windows.Forms.Button.OnMouseUp(MouseEventArgs mevent)
   at System.Windows.Forms.Control.WmMouseUp(Message& m, MouseButtons button, Int32 clicks)
   at System.Windows.Forms.Control.WndProc(Message& m)
   at System.Windows.Forms.ButtonBase.WndProc(Message& m)
   at System.Windows.Forms.Button.WndProc(Message& m)
   at System.Windows.Forms.Control.ControlNativeWindow.OnMessage(Message& m)
   at System.Windows.Forms.Control.ControlNativeWindow.WndProc(Message& m)
   at System.Windows.Forms.NativeWindow.Callback(IntPtr hWnd, Int32 msg, IntPtr wparam, IntPtr lparam)', N'System.Data.DataColumn GetDataColumn(System.String)', N'GetDataColumn', N'System.Data.dll', CAST(N'2018-02-17 09:58:12.953' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (111, N'8ea56e28-2def-4919-a0f5-0b479548a3d9', N'System.ArgumentException: Column ''total'' does not belong to table .
   at System.Data.DataRow.GetDataColumn(String columnName)
   at System.Data.DataRow.get_Item(String columnName)
   at PetrolStation.Forms.testForm.button2_Click(Object sender, EventArgs e) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\testForm.cs:line 167
   at System.Windows.Forms.Control.OnClick(EventArgs e)
   at System.Windows.Forms.Button.OnClick(EventArgs e)
   at System.Windows.Forms.Button.OnMouseUp(MouseEventArgs mevent)
   at System.Windows.Forms.Control.WmMouseUp(Message& m, MouseButtons button, Int32 clicks)
   at System.Windows.Forms.Control.WndProc(Message& m)
   at System.Windows.Forms.ButtonBase.WndProc(Message& m)
   at System.Windows.Forms.Button.WndProc(Message& m)
   at System.Windows.Forms.Control.ControlNativeWindow.OnMessage(Message& m)
   at System.Windows.Forms.Control.ControlNativeWindow.WndProc(Message& m)
   at System.Windows.Forms.NativeWindow.Callback(IntPtr hWnd, Int32 msg, IntPtr wparam, IntPtr lparam)', N'System.Data', N'', N'   at System.Data.DataRow.GetDataColumn(String columnName)
   at System.Data.DataRow.get_Item(String columnName)
   at PetrolStation.Forms.testForm.button2_Click(Object sender, EventArgs e) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\testForm.cs:line 167
   at System.Windows.Forms.Control.OnClick(EventArgs e)
   at System.Windows.Forms.Button.OnClick(EventArgs e)
   at System.Windows.Forms.Button.OnMouseUp(MouseEventArgs mevent)
   at System.Windows.Forms.Control.WmMouseUp(Message& m, MouseButtons button, Int32 clicks)
   at System.Windows.Forms.Control.WndProc(Message& m)
   at System.Windows.Forms.ButtonBase.WndProc(Message& m)
   at System.Windows.Forms.Button.WndProc(Message& m)
   at System.Windows.Forms.Control.ControlNativeWindow.OnMessage(Message& m)
   at System.Windows.Forms.Control.ControlNativeWindow.WndProc(Message& m)
   at System.Windows.Forms.NativeWindow.Callback(IntPtr hWnd, Int32 msg, IntPtr wparam, IntPtr lparam)', N'System.Data.DataColumn GetDataColumn(System.String)', N'GetDataColumn', N'System.Data.dll', CAST(N'2018-02-17 09:58:20.203' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (112, N'0347634b-100f-414c-bd7b-9d6c6d3f98c5', N'System.ArgumentException: Column ''total'' does not belong to table .
   at System.Data.DataRow.GetDataColumn(String columnName)
   at System.Data.DataRow.get_Item(String columnName)
   at PetrolStation.Forms.testForm.button2_Click(Object sender, EventArgs e) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\testForm.cs:line 168
   at System.Windows.Forms.Control.OnClick(EventArgs e)
   at System.Windows.Forms.Button.OnClick(EventArgs e)
   at System.Windows.Forms.Button.OnMouseUp(MouseEventArgs mevent)
   at System.Windows.Forms.Control.WmMouseUp(Message& m, MouseButtons button, Int32 clicks)
   at System.Windows.Forms.Control.WndProc(Message& m)
   at System.Windows.Forms.ButtonBase.WndProc(Message& m)
   at System.Windows.Forms.Button.WndProc(Message& m)
   at System.Windows.Forms.Control.ControlNativeWindow.OnMessage(Message& m)
   at System.Windows.Forms.Control.ControlNativeWindow.WndProc(Message& m)
   at System.Windows.Forms.NativeWindow.Callback(IntPtr hWnd, Int32 msg, IntPtr wparam, IntPtr lparam)', N'System.Data', N'', N'   at System.Data.DataRow.GetDataColumn(String columnName)
   at System.Data.DataRow.get_Item(String columnName)
   at PetrolStation.Forms.testForm.button2_Click(Object sender, EventArgs e) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\testForm.cs:line 168
   at System.Windows.Forms.Control.OnClick(EventArgs e)
   at System.Windows.Forms.Button.OnClick(EventArgs e)
   at System.Windows.Forms.Button.OnMouseUp(MouseEventArgs mevent)
   at System.Windows.Forms.Control.WmMouseUp(Message& m, MouseButtons button, Int32 clicks)
   at System.Windows.Forms.Control.WndProc(Message& m)
   at System.Windows.Forms.ButtonBase.WndProc(Message& m)
   at System.Windows.Forms.Button.WndProc(Message& m)
   at System.Windows.Forms.Control.ControlNativeWindow.OnMessage(Message& m)
   at System.Windows.Forms.Control.ControlNativeWindow.WndProc(Message& m)
   at System.Windows.Forms.NativeWindow.Callback(IntPtr hWnd, Int32 msg, IntPtr wparam, IntPtr lparam)', N'System.Data.DataColumn GetDataColumn(System.String)', N'GetDataColumn', N'System.Data.dll', CAST(N'2018-02-17 10:02:15.640' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (113, N'8124c606-9c52-4e15-89df-425ee2471133', N'System.ArgumentException: Column ''id'' does not belong to table .
   at System.Data.DataRow.GetDataColumn(String columnName)
   at System.Data.DataRow.get_Item(String columnName)
   at PetrolStation.Forms.Forms.CumulativeForm.StartButton_Click(Object sender, EventArgs e) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\CumulativeForm.cs:line 162', N'System.Data', N'', N'   at System.Data.DataRow.GetDataColumn(String columnName)
   at System.Data.DataRow.get_Item(String columnName)
   at PetrolStation.Forms.Forms.CumulativeForm.StartButton_Click(Object sender, EventArgs e) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\CumulativeForm.cs:line 162', N'System.Data.DataColumn GetDataColumn(System.String)', N'GetDataColumn', N'System.Data.dll', CAST(N'2018-02-17 14:25:26.547' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (114, N'b0c06fa0-27b7-4bb4-a087-5af1b4370d0f', N'System.InvalidOperationException: Invoke or BeginInvoke cannot be called on a control until the window handle has been created.
   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 262', N'System.Windows.Forms', N'', N'   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 262', N'System.Object MarshaledInvoke(System.Windows.Forms.Control, System.Delegate, System.Object[], Boolean)', N'MarshaledInvoke', N'System.Windows.Forms.dll', CAST(N'2018-02-17 15:40:00.110' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (115, N'd5fb5d7c-8815-4a55-904a-761c787e0904', N'System.InvalidOperationException: Invoke or BeginInvoke cannot be called on a control until the window handle has been created.
   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.fillChart() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 187
   at PetrolStation.Forms.Forms.MainForm.<startLoadThread>b__14_0() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 216', N'System.Windows.Forms', N'', N'   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.fillChart() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 187
   at PetrolStation.Forms.Forms.MainForm.<startLoadThread>b__14_0() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 216', N'System.Object MarshaledInvoke(System.Windows.Forms.Control, System.Delegate, System.Object[], Boolean)', N'MarshaledInvoke', N'System.Windows.Forms.dll', CAST(N'2018-02-17 15:40:00.337' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (116, N'4f64eabe-8c92-41a1-a78a-b18ff1a170e9', N'System.ArgumentException: Column ''id'' does not belong to table .
   at System.Data.DataRow.GetDataColumn(String columnName)
   at System.Data.DataRow.get_Item(String columnName)
   at PetrolStation.Forms.Forms.CumulativeForm.StartButton_Click(Object sender, EventArgs e) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\CumulativeForm.cs:line 162', N'System.Data', N'', N'   at System.Data.DataRow.GetDataColumn(String columnName)
   at System.Data.DataRow.get_Item(String columnName)
   at PetrolStation.Forms.Forms.CumulativeForm.StartButton_Click(Object sender, EventArgs e) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\CumulativeForm.cs:line 162', N'System.Data.DataColumn GetDataColumn(System.String)', N'GetDataColumn', N'System.Data.dll', CAST(N'2018-02-17 15:41:57.587' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (117, N'cae393b3-16fb-414c-8717-b7e414abef0b', N'System.InvalidOperationException: Invoke or BeginInvoke cannot be called on a control until the window handle has been created.
   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 262', N'System.Windows.Forms', N'', N'   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 262', N'System.Object MarshaledInvoke(System.Windows.Forms.Control, System.Delegate, System.Object[], Boolean)', N'MarshaledInvoke', N'System.Windows.Forms.dll', CAST(N'2018-02-18 00:22:44.290' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (118, N'bb115fb6-85c9-4f75-a04a-e755f36fa328', N'System.InvalidOperationException: Invoke or BeginInvoke cannot be called on a control until the window handle has been created.
   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.fillChart() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 187
   at PetrolStation.Forms.Forms.MainForm.<startLoadThread>b__14_0() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 216', N'System.Windows.Forms', N'', N'   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.fillChart() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 187
   at PetrolStation.Forms.Forms.MainForm.<startLoadThread>b__14_0() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 216', N'System.Object MarshaledInvoke(System.Windows.Forms.Control, System.Delegate, System.Object[], Boolean)', N'MarshaledInvoke', N'System.Windows.Forms.dll', CAST(N'2018-02-18 00:22:44.383' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (119, N'eae8cefd-bd81-4d74-a839-38bacd6f5ad3', N'System.Threading.ThreadAbortException: Thread was being aborted.
   at System.Threading.Thread.SleepInternal(Int32 millisecondsTimeout)
   at System.Threading.Thread.Sleep(Int32 millisecondsTimeout)
   at System.Threading.Thread.Sleep(TimeSpan timeout)
   at PetrolStation.Forms.Forms.MainForm.<startLoadThread>b__14_0() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 212', N'mscorlib', N'', N'   at System.Threading.Thread.SleepInternal(Int32 millisecondsTimeout)
   at System.Threading.Thread.Sleep(Int32 millisecondsTimeout)
   at System.Threading.Thread.Sleep(TimeSpan timeout)
   at PetrolStation.Forms.Forms.MainForm.<startLoadThread>b__14_0() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 212', N'Void SleepInternal(Int32)', N'SleepInternal', N'CommonLanguageRuntimeLibrary', CAST(N'2018-02-18 00:29:56.230' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (120, N'eda61005-e0e7-4319-9d02-1bdd6c37b8b5', N'System.Threading.ThreadAbortException: Thread was being aborted.
   at System.Threading.Thread.SleepInternal(Int32 millisecondsTimeout)
   at System.Threading.Thread.Sleep(Int32 millisecondsTimeout)
   at System.Threading.Thread.Sleep(TimeSpan timeout)
   at PetrolStation.Forms.Forms.MainForm.<startLoadThread>b__14_0() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 212', N'mscorlib', N'', N'   at System.Threading.Thread.SleepInternal(Int32 millisecondsTimeout)
   at System.Threading.Thread.Sleep(Int32 millisecondsTimeout)
   at System.Threading.Thread.Sleep(TimeSpan timeout)
   at PetrolStation.Forms.Forms.MainForm.<startLoadThread>b__14_0() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 212', N'Void SleepInternal(Int32)', N'SleepInternal', N'CommonLanguageRuntimeLibrary', CAST(N'2018-02-18 00:30:27.390' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (121, N'd84c293e-45f8-4165-a7a4-ca31ff2f771f', N'System.Threading.ThreadAbortException: Thread was being aborted.
   at System.Threading.Thread.SleepInternal(Int32 millisecondsTimeout)
   at System.Threading.Thread.Sleep(Int32 millisecondsTimeout)
   at System.Threading.Thread.Sleep(TimeSpan timeout)
   at PetrolStation.Forms.Forms.MainForm.<startLoadThread>b__14_0() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 212', N'mscorlib', N'', N'   at System.Threading.Thread.SleepInternal(Int32 millisecondsTimeout)
   at System.Threading.Thread.Sleep(Int32 millisecondsTimeout)
   at System.Threading.Thread.Sleep(TimeSpan timeout)
   at PetrolStation.Forms.Forms.MainForm.<startLoadThread>b__14_0() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 212', N'Void SleepInternal(Int32)', N'SleepInternal', N'CommonLanguageRuntimeLibrary', CAST(N'2018-02-18 00:30:54.727' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (122, N'5c868f75-191d-4eed-9b95-80271c6a93f6', N'System.InvalidOperationException: Invoke or BeginInvoke cannot be called on a control until the window handle has been created.
   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 262', N'System.Windows.Forms', N'', N'   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.loadTraffic(DateTime begindate) in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 262', N'System.Object MarshaledInvoke(System.Windows.Forms.Control, System.Delegate, System.Object[], Boolean)', N'MarshaledInvoke', N'System.Windows.Forms.dll', CAST(N'2018-03-27 09:04:41.213' AS DateTime))
INSERT [dbo].[Error] ([id], [viewId], [error], [eSource], [eInnerExecption], [eStackTrace], [eTargetSite], [eTargetSiteName], [eTargetSiteModule], [eDate]) VALUES (123, N'8cd203d3-479d-4bc9-b624-ff9ccb0ea452', N'System.InvalidOperationException: Invoke or BeginInvoke cannot be called on a control until the window handle has been created.
   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.fillChart() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 187
   at PetrolStation.Forms.Forms.MainForm.<startLoadThread>b__14_0() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 216', N'System.Windows.Forms', N'', N'   at System.Windows.Forms.Control.MarshaledInvoke(Control caller, Delegate method, Object[] args, Boolean synchronous)
   at System.Windows.Forms.Control.Invoke(Delegate method, Object[] args)
   at System.Windows.Forms.Control.Invoke(Delegate method)
   at PetrolStation.Forms.Forms.MainForm.fillChart() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 187
   at PetrolStation.Forms.Forms.MainForm.<startLoadThread>b__14_0() in E:\Projects\ProjectGasStation\PetrolStation\PetrolStation\PetrolStation\Forms\Forms\MainForm.cs:line 216', N'System.Object MarshaledInvoke(System.Windows.Forms.Control, System.Delegate, System.Object[], Boolean)', N'MarshaledInvoke', N'System.Windows.Forms.dll', CAST(N'2018-03-27 09:04:41.277' AS DateTime))
SET IDENTITY_INSERT [dbo].[Error] OFF
SET IDENTITY_INSERT [dbo].[HC.Sexuality] ON 

INSERT [dbo].[HC.Sexuality] ([id], [viewId], [gen]) VALUES (1, N'85217f29-a579-4bbe-a590-5a4fd262d3fa', N'مرد')
INSERT [dbo].[HC.Sexuality] ([id], [viewId], [gen]) VALUES (2, N'0f56a913-e787-4929-a3bc-abf6105ea38e', N'زن')
SET IDENTITY_INSERT [dbo].[HC.Sexuality] OFF
SET IDENTITY_INSERT [dbo].[Lottery] ON 

INSERT [dbo].[Lottery] ([id], [viewId], [ownerId], [startDate], [endDate], [lotteryDate], [total], [month], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (1047, N'5b0f8fd4-a441-4fce-9018-c7ca0987e84a', 52, CAST(N'2018-01-21 00:00:00.000' AS DateTime), CAST(N'2018-02-19 00:00:00.000' AS DateTime), CAST(N'2018-02-18 00:18:55.130' AS DateTime), 41, N'بهمن', 2, CAST(N'2018-02-18 00:18:55.130' AS DateTime), NULL, NULL)
INSERT [dbo].[Lottery] ([id], [viewId], [ownerId], [startDate], [endDate], [lotteryDate], [total], [month], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (1048, N'59722e77-21e7-4e1d-9884-9dc8ee232dd1', 53, CAST(N'2018-01-21 00:00:00.000' AS DateTime), CAST(N'2018-02-19 00:00:00.000' AS DateTime), CAST(N'2018-02-18 00:18:55.210' AS DateTime), 20, N'بهمن', 2, CAST(N'2018-02-18 00:18:55.210' AS DateTime), NULL, NULL)
INSERT [dbo].[Lottery] ([id], [viewId], [ownerId], [startDate], [endDate], [lotteryDate], [total], [month], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (1049, N'c7e1d160-396d-4efc-9cef-0186b4a1a163', 54, CAST(N'2018-01-21 00:00:00.000' AS DateTime), CAST(N'2018-02-19 00:00:00.000' AS DateTime), CAST(N'2018-02-18 00:18:55.240' AS DateTime), 31, N'بهمن', 2, CAST(N'2018-02-18 00:18:55.240' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Lottery] OFF
SET IDENTITY_INSERT [dbo].[Owner] ON 

INSERT [dbo].[Owner] ([id], [viewId], [nationalCode], [name], [lastname], [birthdate], [birthdatelocal], [gen], [phone], [mobile], [address], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (52, N'81c3ff86-5c46-498d-8934-4ebbc7d2c74b', N'4324260869', N'علي', N'رضايي', NULL, N'', 1, N'', N'09193862018', N'', 2, CAST(N'2017-04-25 11:34:41.823' AS DateTime), 2, CAST(N'2017-04-30 14:49:00.050' AS DateTime))
INSERT [dbo].[Owner] ([id], [viewId], [nationalCode], [name], [lastname], [birthdate], [birthdatelocal], [gen], [phone], [mobile], [address], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (53, N'817648c6-9927-4706-89b7-5fb54dc3204d', N'4320686871', N'مرجان', N'قبادي', NULL, N'', 2, N'', N'09193862018', N'', 2, CAST(N'2017-04-25 19:27:29.267' AS DateTime), 2, CAST(N'2017-06-18 12:13:33.213' AS DateTime))
INSERT [dbo].[Owner] ([id], [viewId], [nationalCode], [name], [lastname], [birthdate], [birthdatelocal], [gen], [phone], [mobile], [address], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (54, N'703d9659-2e77-45b1-a195-bce47d5e2f4b', N'4324234320', N'رضا', N'محمدي', NULL, N'', 1, N'', N'09121829155', N'', 2, CAST(N'2017-04-25 19:28:44.577' AS DateTime), 2, CAST(N'2017-04-30 14:54:12.750' AS DateTime))
INSERT [dbo].[Owner] ([id], [viewId], [nationalCode], [name], [lastname], [birthdate], [birthdatelocal], [gen], [phone], [mobile], [address], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (55, N'846317cc-9541-4a88-9651-9d1b5f2a2f20', N'4444444444', N'حسين', N'پينو', NULL, N'', 1, N'', N'09123654547', N'', 2, CAST(N'2017-09-18 10:28:56.983' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Owner] OFF
SET IDENTITY_INSERT [dbo].[Plate] ON 

INSERT [dbo].[Plate] ([id], [viewId], [plateTypeId], [plateCityId], [plate], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (63, N'05e87e2b-9166-44eb-b6f7-60d6d491ffce', 10, 228, N'88_ه_456_79', 2, CAST(N'2017-04-25 19:27:29.250' AS DateTime), 2, CAST(N'2017-04-29 21:31:38.197' AS DateTime))
INSERT [dbo].[Plate] ([id], [viewId], [plateTypeId], [plateCityId], [plate], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (64, N'8c5adee2-880d-4121-883a-a8899849c34d', 10, 228, N'78_خ_555_79', 2, CAST(N'2017-04-25 19:28:44.567' AS DateTime), 2, CAST(N'2017-04-30 14:54:12.573' AS DateTime))
INSERT [dbo].[Plate] ([id], [viewId], [plateTypeId], [plateCityId], [plate], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (65, N'54740a9a-c77a-4880-b778-2da96c04a423', 10, 228, N'17_ه_177_79', 2, CAST(N'2017-04-29 22:05:18.353' AS DateTime), 2, CAST(N'2017-04-30 14:49:00.020' AS DateTime))
INSERT [dbo].[Plate] ([id], [viewId], [plateTypeId], [plateCityId], [plate], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (66, N'c8098d16-7212-49d9-b70d-ffdc1cfd56df', 11, 228, N'15_ت_155_79', 2, CAST(N'2017-06-18 12:13:33.180' AS DateTime), NULL, NULL)
INSERT [dbo].[Plate] ([id], [viewId], [plateTypeId], [plateCityId], [plate], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (67, N'8eb25601-2e76-4b18-95e7-c05114c8e534', 10, 228, N'12_ح_123_79', 2, CAST(N'2017-09-18 10:28:56.927' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Plate] OFF
SET IDENTITY_INSERT [dbo].[System.Data] ON 

INSERT [dbo].[System.Data] ([id], [viewId], [name], [value]) VALUES (3, N'dd010c7e-f228-467b-9eaa-42f4a94dad9c', N'DB-Version', N'96-11-15-1')
SET IDENTITY_INSERT [dbo].[System.Data] OFF
SET IDENTITY_INSERT [dbo].[Tag] ON 

INSERT [dbo].[Tag] ([id], [viewId], [tag], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (58, N'eefa23ad-7167-4e1b-bb92-651cfc882054', N'test2', 2, CAST(N'2017-04-25 19:27:29.363' AS DateTime), NULL, NULL)
INSERT [dbo].[Tag] ([id], [viewId], [tag], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (59, N'd7ea5e56-669d-4937-822a-9c7d4b1aea6e', N'testnew', 2, CAST(N'2017-04-25 19:28:44.623' AS DateTime), 2, CAST(N'2017-04-30 14:54:12.837' AS DateTime))
INSERT [dbo].[Tag] ([id], [viewId], [tag], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (60, N'abbf6ffa-16d1-482d-bc07-4a6f7a7b0137', N'12345', 2, CAST(N'2017-04-29 22:05:18.413' AS DateTime), 2, CAST(N'2017-04-30 14:49:07.030' AS DateTime))
INSERT [dbo].[Tag] ([id], [viewId], [tag], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (62, N'95fabe73-67e0-4abf-92c4-7a9a20397815', N'Label2', 2, CAST(N'2017-06-18 12:13:33.297' AS DateTime), NULL, NULL)
INSERT [dbo].[Tag] ([id], [viewId], [tag], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (63, N'f294cbc0-0b0e-45ba-9367-deecefe534b5', N'test5', 2, CAST(N'2017-09-18 10:28:57.667' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Tag] OFF
SET IDENTITY_INSERT [dbo].[Traffic] ON 

INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [uhfId], [trafficDate]) VALUES (58, N'b411f3c2-064e-488a-a1a7-c17ab5295dc8', 58, 1, CAST(N'2018-02-17 14:25:16.490' AS DateTime))
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [uhfId], [trafficDate]) VALUES (59, N'3f257aaa-40ee-4ad4-bd28-f8b1836bcc05', 58, 1, CAST(N'2018-02-17 14:25:16.490' AS DateTime))
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [uhfId], [trafficDate]) VALUES (60, N'1c43b4e6-c285-4257-af4a-a70280039e93', 58, 1, CAST(N'2018-02-17 14:25:16.490' AS DateTime))
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [uhfId], [trafficDate]) VALUES (61, N'a3605690-5805-4f5e-9839-337ca2da1b66', 58, 1, CAST(N'2018-02-17 14:25:16.490' AS DateTime))
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [uhfId], [trafficDate]) VALUES (62, N'3e4863c3-34e3-46cc-97e6-c6f9cd6e10c9', 58, 1, CAST(N'2018-02-17 14:25:16.490' AS DateTime))
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [uhfId], [trafficDate]) VALUES (63, N'05a99d8c-2e31-47a1-aae1-65fa8f323f3b', 59, 1, CAST(N'2018-02-17 14:25:16.490' AS DateTime))
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [uhfId], [trafficDate]) VALUES (64, N'a5f6b33d-a4a4-4408-b25a-6c6b339f4fbc', 59, 1, CAST(N'2018-02-17 14:25:16.490' AS DateTime))
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [uhfId], [trafficDate]) VALUES (65, N'c536e72e-2576-41fd-840a-6504848c80f2', 59, 1, CAST(N'2018-02-17 14:25:16.490' AS DateTime))
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [uhfId], [trafficDate]) VALUES (66, N'677ddaa6-338f-4aa2-9b58-fdc2aa9c8266', 59, 1, CAST(N'2018-02-17 14:25:16.490' AS DateTime))
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [uhfId], [trafficDate]) VALUES (67, N'd2340074-7d66-4601-9711-d0b9cece4b1d', 59, 1, CAST(N'2018-02-17 14:25:16.490' AS DateTime))
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [uhfId], [trafficDate]) VALUES (68, N'830f2e2e-fd12-4cd3-a793-a6eeef28d249', 59, 1, CAST(N'2018-02-17 14:25:16.490' AS DateTime))
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [uhfId], [trafficDate]) VALUES (69, N'75f44a07-e6fe-4657-bcf1-c27327ff5322', 59, 1, CAST(N'2018-02-17 14:25:16.490' AS DateTime))
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [uhfId], [trafficDate]) VALUES (70, N'07a00283-2886-46a0-9633-3a77358bdae6', 59, 1, CAST(N'2018-02-17 14:25:16.490' AS DateTime))
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [uhfId], [trafficDate]) VALUES (71, N'a29e5e2d-7ac5-4f73-88a6-a6766d49bd7e', 59, 1, CAST(N'2018-02-17 14:25:16.490' AS DateTime))
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [uhfId], [trafficDate]) VALUES (72, N'8e7a9674-2e59-4a02-b5c0-233313bdb427', 59, 1, CAST(N'2018-02-17 14:25:16.490' AS DateTime))
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [uhfId], [trafficDate]) VALUES (73, N'1f75c91b-4511-4154-af6e-7ab124aa5648', 59, 1, CAST(N'2018-02-17 14:25:16.490' AS DateTime))
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [uhfId], [trafficDate]) VALUES (74, N'30a5079b-4799-4861-bd5a-33c941f0d0b1', 58, 1, CAST(N'2018-02-17 14:25:16.490' AS DateTime))
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [uhfId], [trafficDate]) VALUES (75, N'0edf0c48-a4c7-466a-adf9-3f0646266b0b', 58, 1, CAST(N'2018-02-17 14:25:16.490' AS DateTime))
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [uhfId], [trafficDate]) VALUES (76, N'5b3963a7-cfee-4ea2-b246-a697e70b7c31', 58, 1, CAST(N'2018-02-17 14:25:16.490' AS DateTime))
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [uhfId], [trafficDate]) VALUES (77, N'01c0d7fb-17ac-44ec-a66d-005a586979f1', 62, 1, CAST(N'2018-02-17 14:25:16.490' AS DateTime))
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [uhfId], [trafficDate]) VALUES (1077, N'97f40f17-9d63-433c-aaf3-b8ecb7104703', 60, 1, CAST(N'2018-02-17 14:25:16.490' AS DateTime))
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [uhfId], [trafficDate]) VALUES (1078, N'b7677c11-a67a-46f1-b194-9b16f163d01e', 62, 1, CAST(N'2018-02-17 14:25:16.490' AS DateTime))
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [uhfId], [trafficDate]) VALUES (1079, N'0b749bd9-77f1-4160-985a-8fcb83fa112e', 62, 1, CAST(N'2018-02-17 14:25:16.490' AS DateTime))
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [uhfId], [trafficDate]) VALUES (1080, N'a521d487-ca2e-4509-b815-508057dd967c', 60, 1, CAST(N'2018-02-17 14:25:16.490' AS DateTime))
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [uhfId], [trafficDate]) VALUES (1081, N'd6753847-6e00-41e2-91aa-bd6bc91330fb', 60, 1, CAST(N'2018-02-17 14:25:16.490' AS DateTime))
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [uhfId], [trafficDate]) VALUES (1082, N'9012ff45-5712-49e9-bcf1-cdc837c592b7', 60, 1, CAST(N'2018-02-17 14:25:16.490' AS DateTime))
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [uhfId], [trafficDate]) VALUES (1083, N'5b15ab1d-1f72-46a0-b2fe-445d06d7592d', 60, 1, CAST(N'2018-02-17 14:25:16.490' AS DateTime))
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [uhfId], [trafficDate]) VALUES (1084, N'c52ddc01-115a-487f-aa3b-8c47644fd3a1', 58, 1, CAST(N'2018-02-17 14:25:16.490' AS DateTime))
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [uhfId], [trafficDate]) VALUES (1085, N'829a937c-782d-4754-8089-ceefe7172873', 58, 1, CAST(N'2018-02-17 14:25:16.490' AS DateTime))
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [uhfId], [trafficDate]) VALUES (1086, N'53f63183-af4f-4ba3-b062-dfd4013c0f33', 58, 1, CAST(N'2018-02-17 14:25:16.490' AS DateTime))
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [uhfId], [trafficDate]) VALUES (1087, N'b30d2b8b-269e-4a4f-ad5c-c0e4add4e726', 58, 1, CAST(N'2018-02-17 14:25:16.490' AS DateTime))
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [uhfId], [trafficDate]) VALUES (1088, N'7c09943c-a97c-4b8d-acf9-121fb100694f', 60, 1, CAST(N'2018-02-17 14:25:16.490' AS DateTime))
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [uhfId], [trafficDate]) VALUES (1090, N'5490e53b-e8ff-4814-b183-f85817ad29aa', 58, 1, CAST(N'2018-02-17 14:25:16.490' AS DateTime))
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [uhfId], [trafficDate]) VALUES (1091, N'97f4fdc5-d783-490c-8e35-6f0d5cc17502', 62, 1, CAST(N'2018-02-17 14:25:16.490' AS DateTime))
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [uhfId], [trafficDate]) VALUES (1092, N'21a48ecc-8d7e-4d6b-9ec2-a75f4ebd63ed', 62, 1, CAST(N'2018-02-17 14:25:16.490' AS DateTime))
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [uhfId], [trafficDate]) VALUES (1093, N'9e64098c-4743-439b-9dc0-0826bb659db1', 60, 1, CAST(N'2018-02-17 14:25:16.490' AS DateTime))
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [uhfId], [trafficDate]) VALUES (1094, N'f701b6d3-b072-462a-85cf-731c5a248913', 58, 1, CAST(N'2018-02-17 14:25:16.490' AS DateTime))
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [uhfId], [trafficDate]) VALUES (1095, N'64b5e422-2134-4435-9626-894e392c02da', 58, 1, CAST(N'2018-02-17 14:25:16.490' AS DateTime))
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [uhfId], [trafficDate]) VALUES (1096, N'db8a69b1-8b93-49a9-90da-ed4e394f6a21', 60, 1, CAST(N'2018-02-17 14:25:16.490' AS DateTime))
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [uhfId], [trafficDate]) VALUES (1097, N'5f27cfcc-9a92-4190-9d9d-761fe6ea2249', 60, 1, CAST(N'2018-02-17 14:25:16.490' AS DateTime))
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [uhfId], [trafficDate]) VALUES (1098, N'c7343ffd-b376-410a-8994-3c7bf2604df2', 60, 1, CAST(N'2018-02-17 14:25:16.490' AS DateTime))
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [uhfId], [trafficDate]) VALUES (1100, N'2d9e9e0a-8f66-4857-80f9-e33851b4a19e', 60, 1, CAST(N'2018-03-27 00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Traffic] OFF
SET IDENTITY_INSERT [dbo].[UHF] ON 

INSERT [dbo].[UHF] ([id], [viewId], [name], [IP], [Port], [netStatus], [serviceStatus], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (1, N'2cf20660-a678-48d2-9153-6fffc958e5da', NULL, N'127.0.0.1', 10001, 1, N'Stopped', 2, CAST(N'2016-03-12 00:00:00.000' AS DateTime), 4, CAST(N'2017-08-24 10:48:11.657' AS DateTime))
SET IDENTITY_INSERT [dbo].[UHF] OFF
SET IDENTITY_INSERT [dbo].[UHFPermit] ON 

INSERT [dbo].[UHFPermit] ([id], [viewId], [userId], [uhfId]) VALUES (1, N'dce378f4-7dcc-42ec-a3ff-cd8231f94d60', 2, 1)
SET IDENTITY_INSERT [dbo].[UHFPermit] OFF
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([id], [viewId], [name], [lastname], [username], [password], [inserted], [enable]) VALUES (2, N'6b5d6474-8382-47ba-9f2b-aa4edd7b9ee0', N'علي', N'محبوبي', N'admin', N'123', CAST(N'2016-11-25 10:30:50.900' AS DateTime), 1)
INSERT [dbo].[User] ([id], [viewId], [name], [lastname], [username], [password], [inserted], [enable]) VALUES (3, N'b30586e2-ca38-4b1f-9ae9-4a8551e1afa0', N'مرجان', N'قبادي', N'mj', N'123', CAST(N'2016-11-30 15:10:58.400' AS DateTime), 1)
INSERT [dbo].[User] ([id], [viewId], [name], [lastname], [username], [password], [inserted], [enable]) VALUES (4, N'0467305e-f37d-4945-aa08-92dd838c5fa7', N'Service', N'', N'ServiceUser', N'$3r\/Ic3U53R', CAST(N'2016-12-07 12:11:21.967' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[User] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_LegalOwner]    Script Date: 2018-03-28 11:47:20 AM ******/
ALTER TABLE [dbo].[LegalOwner] ADD  CONSTRAINT [IX_LegalOwner] UNIQUE NONCLUSTERED 
(
	[OrganizationCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[LegalOwner] ADD  CONSTRAINT [DF_LegalOwner_viewId]  DEFAULT (newid()) FOR [viewId]
GO
ALTER TABLE [dbo].[Base.CarColor]  WITH CHECK ADD  CONSTRAINT [FK_Base.CarColor_User_Insert] FOREIGN KEY([insertedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[Base.CarColor] CHECK CONSTRAINT [FK_Base.CarColor_User_Insert]
GO
ALTER TABLE [dbo].[Base.CarColor]  WITH CHECK ADD  CONSTRAINT [FK_Base.CarColor_User_Modify] FOREIGN KEY([updatedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[Base.CarColor] CHECK CONSTRAINT [FK_Base.CarColor_User_Modify]
GO
ALTER TABLE [dbo].[Base.CarFuel]  WITH CHECK ADD  CONSTRAINT [FK_Base.CarFuel_User_Insert] FOREIGN KEY([insertedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[Base.CarFuel] CHECK CONSTRAINT [FK_Base.CarFuel_User_Insert]
GO
ALTER TABLE [dbo].[Base.CarFuel]  WITH CHECK ADD  CONSTRAINT [FK_Base.CarFuel_User_Modify] FOREIGN KEY([updatedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[Base.CarFuel] CHECK CONSTRAINT [FK_Base.CarFuel_User_Modify]
GO
ALTER TABLE [dbo].[Base.CarLevel]  WITH CHECK ADD  CONSTRAINT [FK_Base.CarLevel_User_Insert] FOREIGN KEY([insertedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[Base.CarLevel] CHECK CONSTRAINT [FK_Base.CarLevel_User_Insert]
GO
ALTER TABLE [dbo].[Base.CarLevel]  WITH CHECK ADD  CONSTRAINT [FK_Base.CarLevel_User_Modify] FOREIGN KEY([updatedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[Base.CarLevel] CHECK CONSTRAINT [FK_Base.CarLevel_User_Modify]
GO
ALTER TABLE [dbo].[Base.CarSystem]  WITH CHECK ADD  CONSTRAINT [FK_Base.CarModel_User_Insert] FOREIGN KEY([insertedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[Base.CarSystem] CHECK CONSTRAINT [FK_Base.CarModel_User_Insert]
GO
ALTER TABLE [dbo].[Base.CarSystem]  WITH CHECK ADD  CONSTRAINT [FK_Base.CarModel_User_Modify] FOREIGN KEY([updatedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[Base.CarSystem] CHECK CONSTRAINT [FK_Base.CarModel_User_Modify]
GO
ALTER TABLE [dbo].[Base.CarType]  WITH CHECK ADD  CONSTRAINT [FK_Base.CarType_User_Insert] FOREIGN KEY([insertedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[Base.CarType] CHECK CONSTRAINT [FK_Base.CarType_User_Insert]
GO
ALTER TABLE [dbo].[Base.CarType]  WITH CHECK ADD  CONSTRAINT [FK_Base.CarType_User_Modify] FOREIGN KEY([updatedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[Base.CarType] CHECK CONSTRAINT [FK_Base.CarType_User_Modify]
GO
ALTER TABLE [dbo].[Base.Month]  WITH CHECK ADD  CONSTRAINT [FK_Base.Month_User_Insert] FOREIGN KEY([insertedById])
REFERENCES [dbo].[User] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Base.Month] CHECK CONSTRAINT [FK_Base.Month_User_Insert]
GO
ALTER TABLE [dbo].[Base.Month]  WITH CHECK ADD  CONSTRAINT [FK_Base.Month_User_Modify] FOREIGN KEY([updatedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[Base.Month] CHECK CONSTRAINT [FK_Base.Month_User_Modify]
GO
ALTER TABLE [dbo].[Base.PlateCity]  WITH CHECK ADD  CONSTRAINT [FK_Base.PlateCity_User_Insert] FOREIGN KEY([insertedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[Base.PlateCity] CHECK CONSTRAINT [FK_Base.PlateCity_User_Insert]
GO
ALTER TABLE [dbo].[Base.PlateCity]  WITH CHECK ADD  CONSTRAINT [FK_Base.PlateCity_User_Modify] FOREIGN KEY([updatedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[Base.PlateCity] CHECK CONSTRAINT [FK_Base.PlateCity_User_Modify]
GO
ALTER TABLE [dbo].[Base.PlateType]  WITH CHECK ADD  CONSTRAINT [FK_Base.PlateType_User_Insert] FOREIGN KEY([insertedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[Base.PlateType] CHECK CONSTRAINT [FK_Base.PlateType_User_Insert]
GO
ALTER TABLE [dbo].[Base.PlateType]  WITH CHECK ADD  CONSTRAINT [FK_Base.PlateType_User_Modify] FOREIGN KEY([updatedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[Base.PlateType] CHECK CONSTRAINT [FK_Base.PlateType_User_Modify]
GO
ALTER TABLE [dbo].[Car]  WITH CHECK ADD  CONSTRAINT [FK_Car_Base.CarColor] FOREIGN KEY([carColorId])
REFERENCES [dbo].[Base.CarColor] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Car] CHECK CONSTRAINT [FK_Car_Base.CarColor]
GO
ALTER TABLE [dbo].[Car]  WITH CHECK ADD  CONSTRAINT [FK_Car_Base.CarFuel] FOREIGN KEY([carFuelId])
REFERENCES [dbo].[Base.CarFuel] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Car] CHECK CONSTRAINT [FK_Car_Base.CarFuel]
GO
ALTER TABLE [dbo].[Car]  WITH CHECK ADD  CONSTRAINT [FK_Car_Base.CarLevel] FOREIGN KEY([carLevelId])
REFERENCES [dbo].[Base.CarLevel] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Car] CHECK CONSTRAINT [FK_Car_Base.CarLevel]
GO
ALTER TABLE [dbo].[Car]  WITH CHECK ADD  CONSTRAINT [FK_Car_Base.CarSystem] FOREIGN KEY([carSystemId])
REFERENCES [dbo].[Base.CarSystem] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Car] CHECK CONSTRAINT [FK_Car_Base.CarSystem]
GO
ALTER TABLE [dbo].[Car]  WITH CHECK ADD  CONSTRAINT [FK_Car_Base.CarType] FOREIGN KEY([carTypeId])
REFERENCES [dbo].[Base.CarType] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Car] CHECK CONSTRAINT [FK_Car_Base.CarType]
GO
ALTER TABLE [dbo].[Car]  WITH CHECK ADD  CONSTRAINT [FK_Car_Plate] FOREIGN KEY([plateId])
REFERENCES [dbo].[Plate] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Car] CHECK CONSTRAINT [FK_Car_Plate]
GO
ALTER TABLE [dbo].[Car]  WITH CHECK ADD  CONSTRAINT [FK_Car_User_Insert] FOREIGN KEY([insertedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[Car] CHECK CONSTRAINT [FK_Car_User_Insert]
GO
ALTER TABLE [dbo].[Car]  WITH CHECK ADD  CONSTRAINT [FK_Car_User_Modify] FOREIGN KEY([updatedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[Car] CHECK CONSTRAINT [FK_Car_User_Modify]
GO
ALTER TABLE [dbo].[CarOwner]  WITH CHECK ADD  CONSTRAINT [FK_CarOwner_Car] FOREIGN KEY([carId])
REFERENCES [dbo].[Car] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[CarOwner] CHECK CONSTRAINT [FK_CarOwner_Car]
GO
ALTER TABLE [dbo].[CarOwner]  WITH CHECK ADD  CONSTRAINT [FK_CarOwner_Owner] FOREIGN KEY([ownerId])
REFERENCES [dbo].[Owner] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[CarOwner] CHECK CONSTRAINT [FK_CarOwner_Owner]
GO
ALTER TABLE [dbo].[CarOwner]  WITH CHECK ADD  CONSTRAINT [FK_CarOwner_User_Insert] FOREIGN KEY([insertedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[CarOwner] CHECK CONSTRAINT [FK_CarOwner_User_Insert]
GO
ALTER TABLE [dbo].[CarOwner]  WITH CHECK ADD  CONSTRAINT [FK_CarOwner_User_Modify] FOREIGN KEY([updatedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[CarOwner] CHECK CONSTRAINT [FK_CarOwner_User_Modify]
GO
ALTER TABLE [dbo].[CarTag]  WITH CHECK ADD  CONSTRAINT [FK_CarTag_Car] FOREIGN KEY([carId])
REFERENCES [dbo].[Car] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[CarTag] CHECK CONSTRAINT [FK_CarTag_Car]
GO
ALTER TABLE [dbo].[CarTag]  WITH CHECK ADD  CONSTRAINT [FK_CarTag_Tag] FOREIGN KEY([tagId])
REFERENCES [dbo].[Tag] ([id])
GO
ALTER TABLE [dbo].[CarTag] CHECK CONSTRAINT [FK_CarTag_Tag]
GO
ALTER TABLE [dbo].[CarTag]  WITH CHECK ADD  CONSTRAINT [FK_CarTag_User_Insert] FOREIGN KEY([insertedById])
REFERENCES [dbo].[User] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[CarTag] CHECK CONSTRAINT [FK_CarTag_User_Insert]
GO
ALTER TABLE [dbo].[CarTag]  WITH CHECK ADD  CONSTRAINT [FK_CarTag_User_Modify] FOREIGN KEY([updatedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[CarTag] CHECK CONSTRAINT [FK_CarTag_User_Modify]
GO
ALTER TABLE [dbo].[LegalOwner]  WITH CHECK ADD  CONSTRAINT [FK_LegalOwner_CarOwner] FOREIGN KEY([carOwnerId])
REFERENCES [dbo].[CarOwner] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[LegalOwner] CHECK CONSTRAINT [FK_LegalOwner_CarOwner]
GO
ALTER TABLE [dbo].[LegalOwner]  WITH CHECK ADD  CONSTRAINT [FK_LegalOwner_User_Insert] FOREIGN KEY([insertedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[LegalOwner] CHECK CONSTRAINT [FK_LegalOwner_User_Insert]
GO
ALTER TABLE [dbo].[LegalOwner]  WITH CHECK ADD  CONSTRAINT [FK_LegalOwner_User_Modify] FOREIGN KEY([updatedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[LegalOwner] CHECK CONSTRAINT [FK_LegalOwner_User_Modify]
GO
ALTER TABLE [dbo].[Lottery]  WITH CHECK ADD  CONSTRAINT [FK_Lottery_Owner] FOREIGN KEY([ownerId])
REFERENCES [dbo].[Owner] ([id])
GO
ALTER TABLE [dbo].[Lottery] CHECK CONSTRAINT [FK_Lottery_Owner]
GO
ALTER TABLE [dbo].[Lottery]  WITH CHECK ADD  CONSTRAINT [FK_Lottery_User_Insert] FOREIGN KEY([insertedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[Lottery] CHECK CONSTRAINT [FK_Lottery_User_Insert]
GO
ALTER TABLE [dbo].[Lottery]  WITH CHECK ADD  CONSTRAINT [FK_Lottery_User_Modify] FOREIGN KEY([updatedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[Lottery] CHECK CONSTRAINT [FK_Lottery_User_Modify]
GO
ALTER TABLE [dbo].[Owner]  WITH CHECK ADD  CONSTRAINT [FK_Owner_User_Insert] FOREIGN KEY([insertedById])
REFERENCES [dbo].[User] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Owner] CHECK CONSTRAINT [FK_Owner_User_Insert]
GO
ALTER TABLE [dbo].[Owner]  WITH CHECK ADD  CONSTRAINT [FK_Owner_User_Modify] FOREIGN KEY([updatedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[Owner] CHECK CONSTRAINT [FK_Owner_User_Modify]
GO
ALTER TABLE [dbo].[Plate]  WITH CHECK ADD  CONSTRAINT [FK_Plate_Base.PlateCity] FOREIGN KEY([plateCityId])
REFERENCES [dbo].[Base.PlateCity] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Plate] CHECK CONSTRAINT [FK_Plate_Base.PlateCity]
GO
ALTER TABLE [dbo].[Plate]  WITH CHECK ADD  CONSTRAINT [FK_Plate_Base.PlateType] FOREIGN KEY([plateTypeId])
REFERENCES [dbo].[Base.PlateType] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Plate] CHECK CONSTRAINT [FK_Plate_Base.PlateType]
GO
ALTER TABLE [dbo].[Plate]  WITH CHECK ADD  CONSTRAINT [FK_Plate_User_Insert] FOREIGN KEY([insertedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[Plate] CHECK CONSTRAINT [FK_Plate_User_Insert]
GO
ALTER TABLE [dbo].[Plate]  WITH CHECK ADD  CONSTRAINT [FK_Plate_User_Modify] FOREIGN KEY([updatedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[Plate] CHECK CONSTRAINT [FK_Plate_User_Modify]
GO
ALTER TABLE [dbo].[Tag]  WITH CHECK ADD  CONSTRAINT [FK_Tag_User_Insert] FOREIGN KEY([insertedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[Tag] CHECK CONSTRAINT [FK_Tag_User_Insert]
GO
ALTER TABLE [dbo].[Tag]  WITH CHECK ADD  CONSTRAINT [FK_Tag_User_Modify] FOREIGN KEY([updatedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[Tag] CHECK CONSTRAINT [FK_Tag_User_Modify]
GO
ALTER TABLE [dbo].[Traffic]  WITH CHECK ADD  CONSTRAINT [FK_Traffic_Tag] FOREIGN KEY([tagId])
REFERENCES [dbo].[Tag] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Traffic] CHECK CONSTRAINT [FK_Traffic_Tag]
GO
ALTER TABLE [dbo].[Traffic]  WITH CHECK ADD  CONSTRAINT [FK_Traffic_UHF] FOREIGN KEY([uhfId])
REFERENCES [dbo].[UHF] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Traffic] CHECK CONSTRAINT [FK_Traffic_UHF]
GO
ALTER TABLE [dbo].[UHF]  WITH CHECK ADD  CONSTRAINT [FK_UHF_User_Insert] FOREIGN KEY([insertedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[UHF] CHECK CONSTRAINT [FK_UHF_User_Insert]
GO
ALTER TABLE [dbo].[UHF]  WITH CHECK ADD  CONSTRAINT [FK_UHF_User_Modify] FOREIGN KEY([updatedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[UHF] CHECK CONSTRAINT [FK_UHF_User_Modify]
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
/****** Object:  StoredProcedure [dbo].[spChartTraffic]    Script Date: 2018-03-28 11:47:20 AM ******/
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
/****** Object:  StoredProcedure [dbo].[spCumulative]    Script Date: 2018-03-28 11:47:20 AM ******/
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
/****** Object:  StoredProcedure [dbo].[spCumulative1]    Script Date: 2018-03-28 11:47:20 AM ******/
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
/****** Object:  StoredProcedure [dbo].[spGetCarSearchByNationalcode]    Script Date: 2018-03-28 11:47:20 AM ******/
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
/****** Object:  StoredProcedure [dbo].[spGetCarSearchByPlate]    Script Date: 2018-03-28 11:47:20 AM ******/
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
/****** Object:  StoredProcedure [dbo].[spGetLottery]    Script Date: 2018-03-28 11:47:20 AM ******/
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
/****** Object:  StoredProcedure [dbo].[spGetOwnerSearchByPlate]    Script Date: 2018-03-28 11:47:20 AM ******/
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
/****** Object:  StoredProcedure [dbo].[spGetPaginetTraffic]    Script Date: 2018-03-28 11:47:20 AM ******/
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
/****** Object:  StoredProcedure [dbo].[spGetReportTraffic]    Script Date: 2018-03-28 11:47:20 AM ******/
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
/****** Object:  StoredProcedure [dbo].[spGetReportTrafficByNationalcode]    Script Date: 2018-03-28 11:47:20 AM ******/
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
/****** Object:  StoredProcedure [dbo].[spGetReportTrafficByPlate]    Script Date: 2018-03-28 11:47:20 AM ******/
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
/****** Object:  StoredProcedure [dbo].[spGetReportTrafficCount]    Script Date: 2018-03-28 11:47:20 AM ******/
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
/****** Object:  StoredProcedure [dbo].[spGetReportTrafficCountByNationalcode]    Script Date: 2018-03-28 11:47:20 AM ******/
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
/****** Object:  StoredProcedure [dbo].[spGetReportTrafficCountByPlate]    Script Date: 2018-03-28 11:47:20 AM ******/
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
/****** Object:  StoredProcedure [dbo].[spGetTraffic]    Script Date: 2018-03-28 11:47:20 AM ******/
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
/****** Object:  StoredProcedure [dbo].[spGetTrafficSearchByNationalcode]    Script Date: 2018-03-28 11:47:20 AM ******/
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
/****** Object:  StoredProcedure [dbo].[spGetTrafficSerachByPlate]    Script Date: 2018-03-28 11:47:20 AM ******/
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
/****** Object:  StoredProcedure [dbo].[spOwnerSearchWithCode]    Script Date: 2018-03-28 11:47:20 AM ******/
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
/****** Object:  StoredProcedure [dbo].[spShowCustomer]    Script Date: 2018-03-28 11:47:20 AM ******/
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
/****** Object:  StoredProcedure [dbo].[spShowCustomerTag]    Script Date: 2018-03-28 11:47:20 AM ******/
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
/****** Object:  StoredProcedure [dbo].[spTrafficDelete]    Script Date: 2018-03-28 11:47:20 AM ******/
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
/****** Object:  StoredProcedure [dbo].[spTrafficRegisterByService]    Script Date: 2018-03-28 11:47:20 AM ******/
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
/****** Object:  StoredProcedure [dbo].[spUserDelete]    Script Date: 2018-03-28 11:47:20 AM ******/
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
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[54] 4[5] 2[11] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = -74
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Base.CarLevel"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Plate"
            Begin Extent = 
               Top = 258
               Left = 283
               Bottom = 459
               Right = 477
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "Car"
            Begin Extent = 
               Top = 168
               Left = 668
               Bottom = 550
               Right = 862
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "Base.PlateType"
            Begin Extent = 
               Top = 175
               Left = 48
               Bottom = 338
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Base.PlateCity"
            Begin Extent = 
               Top = 343
               Left = 48
               Bottom = 506
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Base.CarType"
            Begin Extent = 
               Top = 511
               Left = 48
               Bottom = 674
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Base.CarSystem"
            Begin Extent = 
               Top = 679
               Left = 48
               Bottom = 842
               Right = 242
            End
    ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'viewCustomer'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'        DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Base.CarColor"
            Begin Extent = 
               Top = 847
               Left = 48
               Bottom = 1010
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "CarOwner"
            Begin Extent = 
               Top = 6
               Left = 415
               Bottom = 169
               Right = 609
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "Owner"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 268
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 4
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 15
         Width = 284
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1428
         Width = 1980
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 2256
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'viewCustomer'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'viewCustomer'
GO
