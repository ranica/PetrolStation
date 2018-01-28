USE [GasStation]
GO
/****** Object:  Table [dbo].[Base.CarColor]    Script Date: 2018-01-28 2:58:22 PM ******/
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
/****** Object:  Table [dbo].[Base.CarFuel]    Script Date: 2018-01-28 2:58:22 PM ******/
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
/****** Object:  Table [dbo].[Base.CarLevel]    Script Date: 2018-01-28 2:58:22 PM ******/
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
/****** Object:  Table [dbo].[Base.CarSystem]    Script Date: 2018-01-28 2:58:22 PM ******/
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
/****** Object:  Table [dbo].[Base.CarType]    Script Date: 2018-01-28 2:58:22 PM ******/
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
/****** Object:  Table [dbo].[Base.GridHeader]    Script Date: 2018-01-28 2:58:22 PM ******/
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
/****** Object:  Table [dbo].[Base.Month]    Script Date: 2018-01-28 2:58:22 PM ******/
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
/****** Object:  Table [dbo].[Base.PlateCity]    Script Date: 2018-01-28 2:58:22 PM ******/
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
/****** Object:  Table [dbo].[Base.PlateCountry]    Script Date: 2018-01-28 2:58:22 PM ******/
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
/****** Object:  Table [dbo].[Base.PlateType]    Script Date: 2018-01-28 2:58:22 PM ******/
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
/****** Object:  Table [dbo].[Car]    Script Date: 2018-01-28 2:58:22 PM ******/
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
/****** Object:  Table [dbo].[CarOwner]    Script Date: 2018-01-28 2:58:22 PM ******/
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
/****** Object:  Table [dbo].[CarTag]    Script Date: 2018-01-28 2:58:22 PM ******/
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
/****** Object:  Table [dbo].[HC.Sexuality]    Script Date: 2018-01-28 2:58:22 PM ******/
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
/****** Object:  Table [dbo].[LegalOwner]    Script Date: 2018-01-28 2:58:22 PM ******/
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
/****** Object:  Table [dbo].[Lottery]    Script Date: 2018-01-28 2:58:22 PM ******/
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
	[updateById] [int] NULL,
	[updateDate] [datetime] NULL,
 CONSTRAINT [PK_Lottery] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Owner]    Script Date: 2018-01-28 2:58:22 PM ******/
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
/****** Object:  Table [dbo].[Plate]    Script Date: 2018-01-28 2:58:22 PM ******/
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
/****** Object:  Table [dbo].[System.Data]    Script Date: 2018-01-28 2:58:22 PM ******/
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
/****** Object:  Table [dbo].[Tag]    Script Date: 2018-01-28 2:58:22 PM ******/
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
/****** Object:  Table [dbo].[Traffic]    Script Date: 2018-01-28 2:58:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Traffic](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL CONSTRAINT [DF_Traffic_viewId]  DEFAULT (newid()),
	[tagId] [int] NOT NULL,
	[trafficDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Traffic] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UHF]    Script Date: 2018-01-28 2:58:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UHF](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL CONSTRAINT [DF_UHF_viewId]  DEFAULT (newid()),
	[IP] [varchar](15) NOT NULL,
	[Port] [int] NOT NULL,
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
/****** Object:  Table [dbo].[User]    Script Date: 2018-01-28 2:58:22 PM ******/
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
/****** Object:  View [dbo].[viewCustomer]    Script Date: 2018-01-28 2:58:22 PM ******/
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
SET IDENTITY_INSERT [dbo].[Base.CarColor] ON 

GO
INSERT [dbo].[Base.CarColor] ([id], [viewId], [color], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (14, N'62edce5b-5a90-44f5-bc1a-21bc6a799a16', N'قرمز', 2, CAST(N'2017-02-02 12:53:09.390' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.CarColor] ([id], [viewId], [color], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (15, N'869d20bd-e964-4005-9bbc-7075c3b9f767', N'سفيد', 2, CAST(N'2017-03-23 11:11:38.750' AS DateTime), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Base.CarColor] OFF
GO
SET IDENTITY_INSERT [dbo].[Base.CarFuel] ON 

GO
INSERT [dbo].[Base.CarFuel] ([id], [viewId], [fuel], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (7, N'dd1a7a3a-cf0f-4581-b3f9-d5e07a82b43c', N'گاز', 2, CAST(N'2016-11-25 15:19:56.077' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.CarFuel] ([id], [viewId], [fuel], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (8, N'993c16fd-0858-4909-9a1d-64c0186a2f93', N'بنزين', 2, CAST(N'2016-11-25 15:20:17.687' AS DateTime), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Base.CarFuel] OFF
GO
SET IDENTITY_INSERT [dbo].[Base.CarLevel] ON 

GO
INSERT [dbo].[Base.CarLevel] ([id], [viewId], [levelcar], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (7, N'f1263c84-e61e-4ae5-85bd-7e8b9ba267d4', N'سواري', 2, CAST(N'2017-02-02 12:53:23.970' AS DateTime), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Base.CarLevel] OFF
GO
SET IDENTITY_INSERT [dbo].[Base.CarSystem] ON 

GO
INSERT [dbo].[Base.CarSystem] ([id], [viewId], [system], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (9, N'e4d7120a-e229-42fd-bc0e-70ecca23def9', N'پژو', 2, CAST(N'2017-02-02 12:52:59.703' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.CarSystem] ([id], [viewId], [system], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (10, N'59285d6e-6442-4d64-a734-448a787c1210', N'206', 2, CAST(N'2017-03-28 17:43:40.050' AS DateTime), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Base.CarSystem] OFF
GO
SET IDENTITY_INSERT [dbo].[Base.CarType] ON 

GO
INSERT [dbo].[Base.CarType] ([id], [viewId], [type], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (3, N'3db513b9-06d5-4999-8c14-dd75f866d38f', N'سواري', 2, CAST(N'2016-11-30 16:19:40.897' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.CarType] ([id], [viewId], [type], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (4, N'b1ebb5e5-8a13-4b83-b333-7dae975fe0c0', N'وانت', 2, CAST(N'2016-11-30 17:11:51.300' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.CarType] ([id], [viewId], [type], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (5, N'96da2cae-a388-4095-9826-ce711e668db8', N'نيسان', 2, CAST(N'2016-11-30 17:11:55.667' AS DateTime), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Base.CarType] OFF
GO
SET IDENTITY_INSERT [dbo].[Base.GridHeader] ON 

GO
INSERT [dbo].[Base.GridHeader] ([id], [viewId], [name], [data]) VALUES (23, N'a532e2e3-4fe5-4423-9e8a-dc333a2f8a91', N'CarColorForm', N'{"columns":[{"field":"id","caption":"id","visible":false,"readOnly":true,"position":0,"width":150},{"field":"viewId","caption":"viewId","visible":false,"readOnly":true,"position":0,"width":150},{"field":"insertedById","caption":"insertedById","visible":false,"readOnly":true,"position":0,"width":150},{"field":"insertDate","caption":"insertDate","visible":false,"readOnly":true,"position":0,"width":150},{"field":"updatedById","caption":"updatedById","visible":false,"readOnly":true,"position":0,"width":150},{"field":"updateDate","caption":"updateDate","visible":false,"readOnly":true,"position":0,"width":150},{"field":"color","caption":"رنگ","visible":true,"readOnly":true,"position":1,"width":150}]}')
GO
INSERT [dbo].[Base.GridHeader] ([id], [viewId], [name], [data]) VALUES (24, N'32d8c503-8b2a-4f03-968a-fc6a545a143e', N'CarLevelForm', N'{"columns":[{"field":"id","caption":"id","visible":false,"readOnly":true,"position":0,"width":150},{"field":"viewId","caption":"viewId","visible":false,"readOnly":true,"position":0,"width":150},{"field":"insertedById","caption":"insertedById","visible":false,"readOnly":true,"position":0,"width":150},{"field":"insertDate","caption":"insertDate","visible":false,"readOnly":true,"position":0,"width":150},{"field":"updatedById","caption":"updatedById","visible":false,"readOnly":true,"position":0,"width":150},{"field":"updateDate","caption":"updateDate","visible":false,"readOnly":true,"position":0,"width":150},{"field":"levelcar","caption":"تيپ","visible":true,"readOnly":true,"position":1,"width":150}]}')
GO
INSERT [dbo].[Base.GridHeader] ([id], [viewId], [name], [data]) VALUES (25, N'8e3667d9-1c59-4a48-9492-4fd804ce85ac', N'CarFuelForm', N'{"columns":[{"field":"id","caption":"id","visible":false,"readOnly":true,"position":0,"width":150},{"field":"viewId","caption":"viewId","visible":false,"readOnly":true,"position":0,"width":150},{"field":"insertedById","caption":"insertedById","visible":false,"readOnly":true,"position":0,"width":150},{"field":"insertDate","caption":"insertDate","visible":false,"readOnly":true,"position":0,"width":150},{"field":"updatedById","caption":"updatedById","visible":false,"readOnly":true,"position":0,"width":150},{"field":"updateDate","caption":"updateDate","visible":false,"readOnly":true,"position":0,"width":150},{"field":"fuel","caption":"سوخت","visible":true,"readOnly":true,"position":1,"width":150}]}')
GO
INSERT [dbo].[Base.GridHeader] ([id], [viewId], [name], [data]) VALUES (26, N'2194f04f-f75c-4f41-8cf3-0c3f5b204ba5', N'CarSystemForm', N'{"columns":[{"field":"id","caption":"id","visible":false,"readOnly":true,"position":0,"width":150},{"field":"viewId","caption":"viewId","visible":false,"readOnly":true,"position":0,"width":150},{"field":"insertedById","caption":"insertedById","visible":false,"readOnly":true,"position":0,"width":150},{"field":"insertDate","caption":"insertDate","visible":false,"readOnly":true,"position":0,"width":150},{"field":"updatedById","caption":"updatedById","visible":false,"readOnly":true,"position":0,"width":150},{"field":"updateDate","caption":"updateDate","visible":false,"readOnly":true,"position":0,"width":150},{"field":"system","caption":"سيستم خودرو","visible":true,"readOnly":true,"position":1,"width":150}]}')
GO
INSERT [dbo].[Base.GridHeader] ([id], [viewId], [name], [data]) VALUES (27, N'7a408a70-c420-42a5-a2d0-42172d483b8c', N'CarTypeForm', N'{"columns":[{"field":"id","caption":"id","visible":false,"readOnly":true,"position":0,"width":150},{"field":"viewId","caption":"viewId","visible":false,"readOnly":true,"position":0,"width":150},{"field":"insertedById","caption":"insertedById","visible":false,"readOnly":true,"position":0,"width":150},{"field":"insertDate","caption":"insertDate","visible":false,"readOnly":true,"position":0,"width":150},{"field":"updatedById","caption":"updatedById","visible":false,"readOnly":true,"position":0,"width":150},{"field":"updateDate","caption":"updateDate","visible":false,"readOnly":true,"position":0,"width":150},{"field":"type","caption":"نوع خودرو","visible":true,"readOnly":true,"position":1,"width":150}]}')
GO
INSERT [dbo].[Base.GridHeader] ([id], [viewId], [name], [data]) VALUES (28, N'0225be78-1339-40e0-8fa8-4b1f139651c1', N'PlateTypeForm', N'{"columns":[{"field":"id","caption":"id","visible":false,"readOnly":true,"position":0,"width":150},{"field":"viewId","caption":"viewId","visible":false,"readOnly":true,"position":0,"width":150},{"field":"insertedById","caption":"insertedById","visible":false,"readOnly":true,"position":0,"width":150},{"field":"insertDate","caption":"insertDate","visible":false,"readOnly":true,"position":0,"width":150},{"field":"updatedById","caption":"updatedById","visible":false,"readOnly":true,"position":0,"width":150},{"field":"updateDate","caption":"updateDate","visible":false,"readOnly":true,"position":0,"width":150},{"field":"type","caption":"نوع پلاک","visible":true,"readOnly":true,"position":1,"width":150}]}')
GO
INSERT [dbo].[Base.GridHeader] ([id], [viewId], [name], [data]) VALUES (29, N'515b3287-0a0d-468d-9f7d-041356a4f133', N'PlateCityForm', N'{"columns":[{"field":"id","caption":"id","visible":false,"readOnly":true,"position":0,"width":150},{"field":"viewId","caption":"viewId","visible":false,"readOnly":true,"position":0,"width":150},{"field":"insertedById","caption":"insertedById","visible":false,"readOnly":true,"position":0,"width":150},{"field":"insertDate","caption":"insertDate","visible":false,"readOnly":true,"position":0,"width":150},{"field":"updatedById","caption":"updatedById","visible":false,"readOnly":true,"position":0,"width":150},{"field":"updateDate","caption":"updateDate","visible":false,"readOnly":true,"position":0,"width":150},{"field":"city","caption":"شهر","visible":true,"readOnly":true,"position":1,"width":150},{"field":"code","caption":"کد استان","visible":true,"readOnly":true,"position":1,"width":150}]}')
GO
INSERT [dbo].[Base.GridHeader] ([id], [viewId], [name], [data]) VALUES (30, N'849cfb95-7a22-4eaa-9351-1ac9b7ed0b7e', N'CustomerViewForm', N'{"columns":[{"field":"id","caption":"id","visible":false,"readOnly":true,"position":0,"width":150},{"field":"viewId","caption":"viewId","visible":false,"readOnly":true,"position":0,"width":150},{"field":"idCar","caption":"idCar","visible":false,"readOnly":true,"position":0,"width":150},{"field":"nationalCode","caption":"کد ملي","visible":true,"readOnly":true,"position":1,"width":150},{"field":"name","caption":"نام","visible":true,"readOnly":true,"position":2,"width":150},{"field":"lastname","caption":"نام خانوادگي","visible":true,"readOnly":true,"position":3,"width":150},{"field":"mobile","caption":"موبايل","visible":true,"readOnly":true,"position":4,"width":150},{"field":"plate","caption":"شماره پلاک","visible":true,"readOnly":true,"position":5,"width":150},{"field":"type","caption":"نوع پلاک","visible":true,"readOnly":true,"position":6,"width":150},{"field":"city","caption":"شهر پلاک","visible":true,"readOnly":true,"position":7,"width":150},{"field":"typeCar","caption":"نوع خودرو","visible":true,"readOnly":true,"position":8,"width":150},{"field":"system","caption":"سيستم خودرو","visible":true,"readOnly":true,"position":9,"width":150},{"field":"color","caption":"رنگ خودرو","visible":true,"readOnly":true,"position":10,"width":150},{"field":"levelcar","caption":"تيپ خودرو","visible":true,"readOnly":true,"position":11,"width":150},{"field":"model","caption":"مدل خودرو","visible":true,"readOnly":true,"position":12,"width":150}]}')
GO
INSERT [dbo].[Base.GridHeader] ([id], [viewId], [name], [data]) VALUES (31, N'43fbaba8-e7e1-4fb2-afd5-1244af93ed96', N'ReportTrafficForm', N'{"columns":[{"field":"id","caption":"id","visible":false,"readOnly":true,"position":0,"width":150},{"field":"name","caption":"نام","visible":true,"readOnly":true,"position":1,"width":150},{"field":"lastname","caption":"نام خانوادگي","visible":true,"readOnly":true,"position":2,"width":150},{"field":"mobile","caption":"موبايل","visible":true,"readOnly":true,"position":3,"width":150},{"field":"plate","caption":"شماره پلاک","visible":true,"readOnly":true,"position":4,"width":150},{"field":"trafficDate","caption":"تاريخ تردد","visible":false,"readOnly":true,"position":5,"width":150},{"field":"trafficDate_Shamsi","caption":"تاريخ تردد","visible":true,"readOnly":true,"position":6,"width":150}]}')
GO
INSERT [dbo].[Base.GridHeader] ([id], [viewId], [name], [data]) VALUES (32, N'b6e2b1d4-f104-4d17-a30f-e21cfe8cff87', N'CustomerViewForm_Search', N'{"columns":[{"field":"id","caption":"id","visible":false,"readOnly":true,"position":0,"width":150},{"field":"viewId","caption":"viewId","visible":false,"readOnly":true,"position":0,"width":150},{"field":"gen","caption":"gen","visible":false,"readOnly":true,"position":0,"width":150},{"field":"insertedById","caption":"insertedById","visible":false,"readOnly":true,"position":0,"width":150},{"field":"insertDate","caption":"insertDate","visible":false,"readOnly":true,"position":0,"width":150},{"field":"updatedById","caption":"updatedById","visible":false,"readOnly":true,"position":0,"width":150},{"field":"updateDate","caption":"updateDate","visible":false,"readOnly":true,"position":0,"width":150},{"field":"nationalCode","caption":"کد ملي","visible":true,"readOnly":true,"position":1,"width":150},{"field":"name","caption":"نام","visible":true,"readOnly":true,"position":2,"width":150},{"field":"lastname","caption":"نام خانوادگي","visible":true,"readOnly":true,"position":3,"width":150},{"field":"mobile","caption":"موبايل","visible":true,"readOnly":true,"position":4,"width":150},{"field":"birthdate","caption":"تاريخ تولد","visible":true,"readOnly":true,"position":4,"width":150},{"field":"birthdatelocal","caption":"محل تولد","visible":false,"readOnly":true,"position":5,"width":150},{"field":"phone","caption":"تلفن","visible":true,"readOnly":true,"position":6,"width":150},{"field":"address","caption":"آدرس","visible":true,"readOnly":true,"position":6,"width":150}]}')
GO
INSERT [dbo].[Base.GridHeader] ([id], [viewId], [name], [data]) VALUES (33, N'ea8230a9-459e-4d73-a56d-1d8b04cf98ea', N'OwnerUserControl', N'{"columns":[{"field":"id","caption":"id","visible":false,"readOnly":true,"position":0,"width":150},{"field":"viewId","caption":"viewId","visible":false,"readOnly":true,"position":0,"width":150},{"field":"gen","caption":"gen","visible":false,"readOnly":true,"position":0,"width":150},{"field":"insertedById","caption":"insertedById","visible":false,"readOnly":true,"position":0,"width":150},{"field":"insertDate","caption":"insertDate","visible":false,"readOnly":true,"position":0,"width":150},{"field":"updatedById","caption":"updatedById","visible":false,"readOnly":true,"position":0,"width":150},{"field":"updateDate","caption":"updateDate","visible":false,"readOnly":true,"position":0,"width":150},{"field":"nationalCode","caption":"کد ملي","visible":true,"readOnly":true,"position":1,"width":150},{"field":"name","caption":"نام","visible":true,"readOnly":true,"position":2,"width":150},{"field":"lastname","caption":"نام خانوادگي","visible":true,"readOnly":true,"position":3,"width":150},{"field":"mobile","caption":"موبايل","visible":true,"readOnly":true,"position":4,"width":150},{"field":"birthdate","caption":"تاريخ تولد","visible":true,"readOnly":true,"position":4,"width":150},{"field":"birthdatelocal","caption":"محل تولد","visible":false,"readOnly":true,"position":5,"width":150},{"field":"phone","caption":"تلفن","visible":true,"readOnly":true,"position":6,"width":150},{"field":"address","caption":"آدرس","visible":true,"readOnly":true,"position":6,"width":150}]}')
GO
INSERT [dbo].[Base.GridHeader] ([id], [viewId], [name], [data]) VALUES (34, N'2700a8e7-118c-415c-aa2f-f7d8eadabf8b', N'CarUserControl', N'{"columns":[{"field":"carType","caption":"نوع خودرو","visible":true,"readOnly":true,"position":0,"width":150},{"field":"color","caption":"رنگ خودرو","visible":true,"readOnly":true,"position":1,"width":150},{"field":"plate","caption":"شماره پلاک","visible":true,"readOnly":true,"position":2,"width":150},{"field":"city","caption":"شهر پلاک","visible":true,"readOnly":true,"position":3,"width":150},{"field":"platetype","caption":"نوع پلاک","visible":true,"readOnly":true,"position":4,"width":150},{"field":"tag","caption":"شماره برچسب","visible":true,"readOnly":true,"position":5,"width":150}]}')
GO
INSERT [dbo].[Base.GridHeader] ([id], [viewId], [name], [data]) VALUES (35, N'9cfcdab8-88b9-4d87-b15c-94093bc8fce1', N'TrafficUserControl', N'{"columns":[{"field":"trafficDate","caption":"تاريخ تردد","visible":false,"readOnly":true,"position":0,"width":150},{"field":"Row","caption":"رديف","visible":true,"readOnly":true,"position":1,"width":60},{"field":"plate","caption":"شماره پلاک","visible":true,"readOnly":true,"position":2,"width":150},{"field":"trafficDate_Shamsi","caption":"تاريخ تردد","visible":true,"readOnly":true,"position":3,"width":250}]}')
GO
INSERT [dbo].[Base.GridHeader] ([id], [viewId], [name], [data]) VALUES (36, N'3082b65e-194b-4699-9daf-1d8f4b8a2723', N'StateTrafficUserControl', N'{"columns":[{"field":"Row","caption":"رديف","visible":true,"readOnly":true,"position":0,"width":60},{"field":"name","caption":"نام","visible":true,"readOnly":true,"position":1,"width":150},{"field":"lastname","caption":"نام خانوادگي","visible":true,"readOnly":true,"position":2,"width":150},{"field":"mobile","caption":"موبايل","visible":true,"readOnly":true,"position":3,"width":100},{"field":"plate","caption":"شماره پلاک","visible":true,"readOnly":true,"position":4,"width":120},{"field":"trafficDate","caption":"تاريخ تردد","visible":false,"readOnly":true,"position":5,"width":120},{"field":"trafficDate_Shamsi","caption":"تاريخ تردد","visible":true,"readOnly":true,"position":6,"width":250}]}')
GO
INSERT [dbo].[Base.GridHeader] ([id], [viewId], [name], [data]) VALUES (37, N'13dae5f6-ca6a-479a-85af-ea9093441dcd', N'CountTrafficUserControl', N'{"columns":[{"field":"id","caption":"id","visible":false,"readOnly":true,"position":0,"width":60},{"field":"Row","caption":"رديف","visible":true,"readOnly":true,"position":1,"width":80},{"field":"name","caption":"نام","visible":true,"readOnly":true,"position":2,"width":100},{"field":"lastname","caption":"نام خانوادگي","visible":true,"readOnly":true,"position":3,"width":100},{"field":"nationalCode","caption":"کد ملي","visible":true,"readOnly":true,"position":4,"width":100},{"field":"mobile","caption":"موبايل","visible":true,"readOnly":true,"position":5,"width":100},{"field":"plate","caption":"شماره پلاک","visible":true,"readOnly":true,"position":6,"width":100},{"field":"total","caption":"تعداد تردد ها","visible":true,"readOnly":true,"position":7,"width":100}]}')
GO
INSERT [dbo].[Base.GridHeader] ([id], [viewId], [name], [data]) VALUES (38, N'5906054e-f95e-4656-bfc4-305066a7e176', N'LotteryForm', N'{"columns":[{"field":"id","caption":"id","visible":false,"readOnly":true,"position":0,"width":100},{"field":"Row","caption":"رديف","visible":true,"readOnly":true,"position":1,"width":60},{"field":"name","caption":"نام","visible":true,"readOnly":true,"position":2,"width":100},{"field":"lastname","caption":"نام خانوادگي","visible":true,"readOnly":true,"position":3,"width":100},{"field":"nationalCode","caption":"کد ملي","visible":true,"readOnly":true,"position":4,"width":100},{"field":"mobile","caption":"موبايل","visible":true,"readOnly":true,"position":5,"width":100},{"field":"plate","caption":"شماره پلاک","visible":true,"readOnly":true,"position":6,"width":100},{"field":"month","caption":"ماه قرعه کشي","visible":true,"readOnly":true,"position":7,"width":150},{"field":"total","caption":"تعداد تردد ها","visible":true,"readOnly":true,"position":8,"width":100}]}')
GO
SET IDENTITY_INSERT [dbo].[Base.GridHeader] OFF
GO
SET IDENTITY_INSERT [dbo].[Base.Month] ON 

GO
INSERT [dbo].[Base.Month] ([id], [viewId], [code], [month], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (1, N'32ed1883-de4b-4352-a026-4bd9d538a824', 1, N'فروردين', 2, CAST(N'2017-04-24 00:00:00.000' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.Month] ([id], [viewId], [code], [month], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (2, N'0c86dbf6-f4cd-4c63-abb4-04a76bd12aee', 2, N'ارديبهشت', 2, CAST(N'2017-04-24 00:00:00.000' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.Month] ([id], [viewId], [code], [month], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (3, N'e0dda961-67f4-4dd2-9522-ab3264bb0894', 3, N'خرداد', 2, CAST(N'2017-04-24 00:00:00.000' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.Month] ([id], [viewId], [code], [month], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (4, N'83563646-1077-4f63-b466-e6d9797f4660', 4, N'تير', 2, CAST(N'2017-04-24 00:00:00.000' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.Month] ([id], [viewId], [code], [month], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (5, N'79fc74da-8374-47c8-b0fb-295f3919008a', 5, N'مرداد', 2, CAST(N'2017-04-24 00:00:00.000' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.Month] ([id], [viewId], [code], [month], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (6, N'bfa17d24-2eb4-45e2-a481-ea4bc9b531e6', 6, N'شهريور', 2, CAST(N'2017-04-24 00:00:00.000' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.Month] ([id], [viewId], [code], [month], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (7, N'eb4ef5f6-31d3-494f-a125-2099519c36cb', 7, N'مهر', 2, CAST(N'2017-04-24 00:00:00.000' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.Month] ([id], [viewId], [code], [month], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (8, N'6a9b48c7-c56f-4503-9d67-867ae4775ea5', 8, N'آبان', 2, CAST(N'2017-04-24 00:00:00.000' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.Month] ([id], [viewId], [code], [month], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (9, N'aafaf7bf-3d63-4b27-b674-c6e686e84091', 9, N'آذر', 2, CAST(N'2017-04-24 00:00:00.000' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.Month] ([id], [viewId], [code], [month], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (10, N'1ddc47d7-cf9d-40fe-b6f3-09e4c63b5766', 10, N'دي', 2, CAST(N'2017-04-24 00:00:00.000' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.Month] ([id], [viewId], [code], [month], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (11, N'57d4cdad-fbb9-428c-adad-f866d28e70f9', 11, N'بهمن', 2, CAST(N'2017-04-24 00:00:00.000' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.Month] ([id], [viewId], [code], [month], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (12, N'3ad353a6-b7d0-45f5-8b3d-2941829df87b', 12, N'اسفند', 2, CAST(N'2017-04-24 00:00:00.000' AS DateTime), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Base.Month] OFF
GO
SET IDENTITY_INSERT [dbo].[Base.PlateCity] ON 

GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (166, N'd89f3e65-4614-42f1-90b4-116a4f68e9e4', N'11', N'تهران شمال', 2, CAST(N'2016-11-30 15:13:34.030' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (167, N'13580c42-81d3-4e88-ac47-0e8e024f4920', N'12', N'مشهد', 2, CAST(N'2016-11-30 15:13:34.030' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (168, N'fa56f2d6-b345-4818-adc4-f15d42a9bba1', N'13', N'اصفهان', 2, CAST(N'2016-11-30 15:13:34.033' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (169, N'17dccf50-8fc6-4dff-b2b9-c2b267d4b77d', N'14', N'اهواز', 2, CAST(N'2016-11-30 15:13:34.033' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (170, N'81f2d663-e19c-4044-9877-8a2d55e36c6a', N'15', N'تبريز', 2, CAST(N'2016-11-30 15:13:34.037' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (171, N'b85d1a14-b7b6-4be0-a0c5-90e52e9102c8', N'16', N'قم', 2, CAST(N'2016-11-30 15:13:34.037' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (172, N'972d9a92-46fb-41e9-8f24-56753fab5b50', N'17', N'اروميه', 2, CAST(N'2016-11-30 15:13:34.040' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (173, N'd62b0e6c-6a6b-42e8-a17e-e8db0bdf6501', N'18', N'همدان', 2, CAST(N'2016-11-30 15:13:34.040' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (174, N'dbdd3de0-af94-4cb6-ab8d-5b3c44f72d74', N'19', N'کرمانشاه', 2, CAST(N'2016-11-30 15:13:34.040' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (175, N'48f9c2b5-c812-4c02-ba43-15bcedf9771c', N'21', N'استان تهران', 2, CAST(N'2016-11-30 15:13:34.043' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (176, N'b0dee809-3e46-4e9b-98dd-b2e586e685e9', N'22', N'تهران مرکز', 2, CAST(N'2016-11-30 15:13:34.043' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (177, N'b04dbae6-1a7d-4ddd-b6ea-173af9f1da65', N'23', N'استان اصفهان', 2, CAST(N'2016-11-30 15:13:34.043' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (178, N'48335aae-6a91-45e1-8657-f523ac56db00', N'24', N'استان خوزستان', 2, CAST(N'2016-11-30 15:13:34.047' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (179, N'4d1e6965-8c9f-4cab-8e0d-10c62b691c2a', N'25', N'استان آذربايجان شرقي', 2, CAST(N'2016-11-30 15:13:34.047' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (180, N'cd3b580d-e649-49b9-a3a3-6188472bfd12', N'26', N'استان قم', 2, CAST(N'2016-11-30 15:13:34.050' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (181, N'a4b15a25-9f77-423c-934b-898ed12643a3', N'27', N'استان آربايجان غربي', 2, CAST(N'2016-11-30 15:13:34.050' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (182, N'37445188-1dab-4dce-abdf-facf6ed8d9b9', N'28', N'استان همدان', 2, CAST(N'2016-11-30 15:13:34.050' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (183, N'60d5c0c0-4b88-44ac-bd15-f80022dd9b3d', N'29', N'استان کرمانشاه', 2, CAST(N'2016-11-30 15:13:34.050' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (184, N'e415725c-ce86-4305-8366-cd2e1c1d155e', N'31', N'سنندج', 2, CAST(N'2016-11-30 15:13:34.053' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (185, N'0a0edc4f-5cbd-46c4-a169-d65c92f94ce1', N'32', N'استان خراسان', 2, CAST(N'2016-11-30 15:13:34.053' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (186, N'55834de5-744d-418a-85b8-e07f97a89e8b', N'33', N'تهران جنوب', 2, CAST(N'2016-11-30 15:13:34.053' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (190, N'b64df916-d05f-43c1-8993-81142dad7515', N'37', N'استان آذربايجان غربي', 2, CAST(N'2016-11-30 15:13:34.137' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (193, N'71212ea5-81df-4b98-8695-eed4d4429bc5', N'41', N'استان کردستان', 2, CAST(N'2016-11-30 15:13:34.143' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (197, N'859de2f5-1457-4219-97ac-f388839b6a3b', N'45', N'کرمان', 2, CAST(N'2016-11-30 15:13:34.163' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (198, N'f53c5c34-1876-4e95-aa62-19a7a2aa1dd0', N'46', N'رشت', 2, CAST(N'2016-11-30 15:13:34.167' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (199, N'9e959359-3cbf-4abc-a6fd-8e50454026f0', N'47', N'اراک', 2, CAST(N'2016-11-30 15:13:34.167' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (200, N'404d7e25-67b6-481d-98b6-46fa6cd38293', N'48', N'بوشهر', 2, CAST(N'2016-11-30 15:13:34.170' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (201, N'd36c8d08-e481-4fdc-bb2b-6df98b2f30b9', N'49', N'استان کهکيلويه و بوير احمد', 2, CAST(N'2016-11-30 15:13:34.170' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (202, N'e2c28ca4-1d6f-4243-a606-de919c50f136', N'51', N'خرم آباد', 2, CAST(N'2016-11-30 15:13:34.170' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (205, N'8710b474-9a56-43ed-a895-15d923ed91bc', N'54', N'يزد', 2, CAST(N'2016-11-30 15:13:34.173' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (206, N'6bb8f311-1b12-46a3-8497-2a38474be6dc', N'55', N'تهران مرکزي', 2, CAST(N'2016-11-30 15:13:34.177' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (207, N'4f1a41c4-594c-4ebb-9c78-b093ae9d1b8f', N'56', N'گيلان', 2, CAST(N'2016-11-30 15:13:34.177' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (208, N'dca07382-9cb8-4561-a74e-4bd710251a3f', N'57', N'استان مرکزي', 2, CAST(N'2016-11-30 15:13:34.177' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (209, N'cbf80c6d-eba4-4168-ba88-ce2ebe239483', N'58', N'استان بوشهر', 2, CAST(N'2016-11-30 15:13:34.180' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (210, N'c1c56ac3-5960-45d0-98c6-4e163fa43ead', N'59', N'گرگان', 2, CAST(N'2016-11-30 15:13:34.180' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (211, N'5cc3434a-59f1-425c-80bc-5c53870854ce', N'61', N'استان لرستان', 2, CAST(N'2016-11-30 15:13:34.180' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (212, N'73e3e333-2acf-4722-bb0b-83e2bf04fb96', N'62', N'ساري', 2, CAST(N'2016-11-30 15:13:34.180' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (213, N'21ffd625-4f7d-49a1-ac68-6649eb7faeaa', N'63', N'شيراز', 2, CAST(N'2016-11-30 15:13:34.180' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (214, N'886c7321-954e-4250-b779-71bd090ea8b4', N'64', N'استان يزد', 2, CAST(N'2016-11-30 15:13:34.183' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (215, N'e6cac1e3-bd5b-40c3-8bc4-1dd8d5507640', N'65', N'استان کرمان', 2, CAST(N'2016-11-30 15:13:34.183' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (218, N'6e5ee6e0-55e8-4dd4-a043-d2c35c144d95', N'68', N'کرج', 2, CAST(N'2016-11-30 15:13:34.187' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (219, N'7bcb20a2-f287-4bc2-9653-94ab67a5be93', N'69', N'استان گرگان', 2, CAST(N'2016-11-30 15:13:34.187' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (220, N'b0ee0e4f-0d89-4575-90fb-dd3cfbd7c488', N'71', N'شهرکرد', 2, CAST(N'2016-11-30 15:13:34.190' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (221, N'2dce554a-8272-4805-85f5-7e9a5f34dd5b', N'72', N'استان مازندران', 2, CAST(N'2016-11-30 15:13:34.190' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (222, N'e36e9e76-7427-470f-95b9-25a3963eaaa9', N'73', N'استان فارس', 2, CAST(N'2016-11-30 15:13:34.190' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (225, N'b8d54fe7-3584-4f02-9801-50ba84d73064', N'76', N'استان گيلان', 2, CAST(N'2016-11-30 15:13:34.193' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (227, N'7261c50b-23c7-40a1-9e71-3eb1cc125e7b', N'78', N'شهرستان هاي تهران', 2, CAST(N'2016-11-30 15:13:34.197' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (228, N'd140671e-f99d-4044-b984-851ef9fccadf', N'79', N'قزوين', 2, CAST(N'2016-11-30 15:13:34.197' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (229, N'42d92392-780b-47a1-8a33-1341252a5e11', N'81', N'استان چهار محال و بختياري', 2, CAST(N'2016-11-30 15:13:34.197' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (232, N'f1d08f21-4690-41b3-bdec-5f920c52ee74', N'84', N'بندرعباس', 2, CAST(N'2016-11-30 15:13:34.200' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (233, N'19935827-e134-4371-9171-b00891200bb1', N'85', N'زاهدان', 2, CAST(N'2016-11-30 15:13:34.200' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (234, N'd3c08b03-94cb-43d2-92bc-4ca7c5bf2104', N'86', N'سمنان', 2, CAST(N'2016-11-30 15:13:34.203' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (235, N'12a1126e-24f2-44ab-9507-26611a6d0160', N'87', N'زنجان', 2, CAST(N'2016-11-30 15:13:34.203' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (237, N'e5109647-b0c5-4587-a6da-587a15b29047', N'89', N'استان قزوين', 2, CAST(N'2016-11-30 15:13:34.207' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (238, N'ddc5677d-0fd6-4fe2-baff-7430389dfbc0', N'91', N'اردبيل', 2, CAST(N'2016-11-30 15:13:34.207' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (241, N'5695724b-9f54-45fa-9a95-bd7d6f67e652', N'94', N'استان هرمزگان', 2, CAST(N'2016-11-30 15:13:34.210' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (242, N'3fa1a814-c237-429c-8e08-a558084ee817', N'95', N'استان سيستان و بلوچستان', 2, CAST(N'2016-11-30 15:13:34.210' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (243, N'15df7003-a5cc-44e9-88e5-8c5e4230d44f', N'96', N'استان سمنان', 2, CAST(N'2016-11-30 15:13:34.213' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (244, N'4a8e8504-7539-4db7-8978-c20fabb72894', N'97', N'استان زنجان', 2, CAST(N'2016-11-30 15:13:34.213' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (245, N'7272f1f3-6df9-4616-b84d-bf25f5c55d0b', N'98', N'ايلام', 2, CAST(N'2016-11-30 15:13:34.213' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (249, N'7c8964a8-fdd3-4a1b-b7b5-b7d66ec3a87c', N'99', N'تهران جنوب', 2, CAST(N'2016-11-30 15:18:52.400' AS DateTime), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Base.PlateCity] OFF
GO
SET IDENTITY_INSERT [dbo].[Base.PlateCountry] ON 

GO
INSERT [dbo].[Base.PlateCountry] ([id], [viewId], [country], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (1, N'6b018379-cc17-4d3b-9ad8-aca7c679dbfe', N'ايران', 2, CAST(N'2016-11-19 00:52:44.863' AS DateTime), 2, CAST(N'2016-11-19 00:52:53.523' AS DateTime))
GO
INSERT [dbo].[Base.PlateCountry] ([id], [viewId], [country], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (2, N'c0f6d287-00f8-41e5-a42d-0e2dacbcdf44', N'ترکيه', 2, CAST(N'2016-11-19 00:52:49.507' AS DateTime), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Base.PlateCountry] OFF
GO
SET IDENTITY_INSERT [dbo].[Base.PlateType] ON 

GO
INSERT [dbo].[Base.PlateType] ([id], [viewId], [type], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (10, N'24a22ab1-17c2-4208-ade3-57a06a6271e6', N'عادي', 2, CAST(N'2016-12-02 12:05:11.277' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateType] ([id], [viewId], [type], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (11, N'48d690e1-3024-4d70-a47c-854bddda36ce', N'تاکسي', 2, CAST(N'2016-12-02 12:05:16.683' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateType] ([id], [viewId], [type], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (12, N'91d2d573-c10b-4cb4-908d-5113ca9dc9f6', N'دولتي', 2, CAST(N'2016-12-02 12:05:23.167' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateType] ([id], [viewId], [type], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (13, N'c91abdf8-d69d-42aa-9113-8a6af85fab8e', N'معلولين', 2, CAST(N'2016-12-02 12:06:45.820' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateType] ([id], [viewId], [type], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (14, N'b3078074-c59f-4481-88cb-6becc5aeb0ee', N'موتورسيکلت', 2, CAST(N'2016-12-02 12:06:56.460' AS DateTime), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Base.PlateType] OFF
GO
SET IDENTITY_INSERT [dbo].[Car] ON 

GO
INSERT [dbo].[Car] ([id], [viewId], [carTypeId], [carColorId], [carSystemId], [carLevelId], [carFuelId], [plateId], [model], [status], [capacity], [chasisCode], [engineCode], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (58, N'e1e8012b-7047-49c6-af22-1ad79e7d05b3', 3, 14, 9, 7, 7, 64, N'0', 1, 0, N'', N'', 2, CAST(N'2017-04-25 19:28:44.597' AS DateTime), 2, CAST(N'2017-04-30 14:54:12.790' AS DateTime))
GO
INSERT [dbo].[Car] ([id], [viewId], [carTypeId], [carColorId], [carSystemId], [carLevelId], [carFuelId], [plateId], [model], [status], [capacity], [chasisCode], [engineCode], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (59, N'e6bc6175-7e4a-49c5-97e3-6e9ac5affc24', 3, 14, 9, 7, 7, 65, N'0', 1, 0, N'', N'', 2, CAST(N'2017-04-29 22:05:18.383' AS DateTime), 2, CAST(N'2017-04-30 14:49:00.067' AS DateTime))
GO
INSERT [dbo].[Car] ([id], [viewId], [carTypeId], [carColorId], [carSystemId], [carLevelId], [carFuelId], [plateId], [model], [status], [capacity], [chasisCode], [engineCode], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (60, N'72d932fb-d550-4e2e-b93e-4f546c042be0', 3, 14, 9, 7, 7, 66, N'0', 1, 0, N'', N'', 2, CAST(N'2017-06-18 12:13:33.250' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Car] ([id], [viewId], [carTypeId], [carColorId], [carSystemId], [carLevelId], [carFuelId], [plateId], [model], [status], [capacity], [chasisCode], [engineCode], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (1060, N'06f0bf20-2b0c-44f3-880b-2842b887f029', 3, 14, 9, 7, 7, 1066, N'0', 1, 0, N'', N'', 2, CAST(N'2017-06-25 14:04:01.333' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Car] ([id], [viewId], [carTypeId], [carColorId], [carSystemId], [carLevelId], [carFuelId], [plateId], [model], [status], [capacity], [chasisCode], [engineCode], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (1061, N'3a8ad17f-0a30-480c-ab4d-12ac50c7e211', 3, 14, 9, 7, 7, 1067, N'0', 1, 0, N'', N'', 2, CAST(N'2017-06-25 14:04:40.230' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Car] ([id], [viewId], [carTypeId], [carColorId], [carSystemId], [carLevelId], [carFuelId], [plateId], [model], [status], [capacity], [chasisCode], [engineCode], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (1062, N'7a27192e-9856-4b79-9ca0-839d75681134', 3, 14, 9, 7, 7, 1068, N'0', 1, 0, N'', N'', 2, CAST(N'2017-06-25 14:05:22.497' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Car] ([id], [viewId], [carTypeId], [carColorId], [carSystemId], [carLevelId], [carFuelId], [plateId], [model], [status], [capacity], [chasisCode], [engineCode], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (1063, N'ac5353f6-f980-4c41-94b4-ed58a34c73cd', 3, 14, 9, 7, 7, 1069, N'0', 1, 0, N'', N'', 2, CAST(N'2017-06-25 14:06:04.290' AS DateTime), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Car] OFF
GO
SET IDENTITY_INSERT [dbo].[CarOwner] ON 

GO
INSERT [dbo].[CarOwner] ([id], [viewId], [carId], [ownerId], [type], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (59, N'e50704f1-e92b-462e-8fb5-1d6d2893a75b', 58, 54, 0, 2, CAST(N'2017-04-25 19:28:44.613' AS DateTime), 2, CAST(N'2017-04-30 14:54:12.803' AS DateTime))
GO
INSERT [dbo].[CarOwner] ([id], [viewId], [carId], [ownerId], [type], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (60, N'1eb2ed63-c790-4cf9-a9f4-7de0a86e1636', 59, 52, 0, 2, CAST(N'2017-04-29 22:05:18.400' AS DateTime), 2, CAST(N'2017-04-30 14:49:00.097' AS DateTime))
GO
INSERT [dbo].[CarOwner] ([id], [viewId], [carId], [ownerId], [type], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (61, N'84aa9182-fd8d-4cea-8c06-ff2839457ef6', 60, 53, 0, 2, CAST(N'2017-06-18 12:13:33.280' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[CarOwner] ([id], [viewId], [carId], [ownerId], [type], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (1061, N'f66ad572-6c12-43a0-871c-25992951fbb4', 1060, 55, 0, 2, CAST(N'2017-06-25 14:04:01.357' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[CarOwner] ([id], [viewId], [carId], [ownerId], [type], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (1062, N'19c5801b-7f94-4fd9-a84b-948a468dc97d', 1061, 56, 0, 2, CAST(N'2017-06-25 14:04:40.243' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[CarOwner] ([id], [viewId], [carId], [ownerId], [type], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (1063, N'b1fa297d-9877-45b3-a5d5-dabcae50d021', 1062, 57, 0, 2, CAST(N'2017-06-25 14:05:22.520' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[CarOwner] ([id], [viewId], [carId], [ownerId], [type], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (1064, N'6b5e1646-9c82-4c6a-a242-67dc8527701e', 1063, 58, 0, 2, CAST(N'2017-06-25 14:06:04.317' AS DateTime), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[CarOwner] OFF
GO
SET IDENTITY_INSERT [dbo].[CarTag] ON 

GO
INSERT [dbo].[CarTag] ([id], [viewId], [carId], [tagId], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (47, N'044b4b16-b69f-4601-932b-c28fcf205f63', 58, 59, 2, CAST(N'2017-04-25' AS Date), 2, CAST(N'2017-04-30' AS Date))
GO
INSERT [dbo].[CarTag] ([id], [viewId], [carId], [tagId], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (48, N'8ed02fde-e54d-43b0-b319-37e1287772b4', 59, 60, 2, CAST(N'2017-04-29' AS Date), 2, CAST(N'2017-04-30' AS Date))
GO
INSERT [dbo].[CarTag] ([id], [viewId], [carId], [tagId], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (49, N'139c8b56-ba82-420a-a300-1fbf87387e37', 60, 62, 2, CAST(N'2017-06-18' AS Date), NULL, NULL)
GO
INSERT [dbo].[CarTag] ([id], [viewId], [carId], [tagId], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (1049, N'db74d19f-b54f-4db8-aec2-7c86f6b12bc3', 1060, 1062, 2, CAST(N'2017-06-25' AS Date), NULL, NULL)
GO
INSERT [dbo].[CarTag] ([id], [viewId], [carId], [tagId], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (1050, N'0644a06c-2978-4bc8-b656-9fd792fcc519', 1061, 1063, 2, CAST(N'2017-06-25' AS Date), NULL, NULL)
GO
INSERT [dbo].[CarTag] ([id], [viewId], [carId], [tagId], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (1051, N'5673a40a-e76d-43d6-8aaf-6b45d586575f', 1062, 1064, 2, CAST(N'2017-06-25' AS Date), NULL, NULL)
GO
INSERT [dbo].[CarTag] ([id], [viewId], [carId], [tagId], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (1052, N'bd148757-a25a-4786-920b-f9be8d15fbb0', 1063, 1065, 2, CAST(N'2017-06-25' AS Date), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[CarTag] OFF
GO
SET IDENTITY_INSERT [dbo].[HC.Sexuality] ON 

GO
INSERT [dbo].[HC.Sexuality] ([id], [viewId], [gen]) VALUES (1, N'85217f29-a579-4bbe-a590-5a4fd262d3fa', N'مرد')
GO
INSERT [dbo].[HC.Sexuality] ([id], [viewId], [gen]) VALUES (2, N'0f56a913-e787-4929-a3bc-abf6105ea38e', N'زن')
GO
SET IDENTITY_INSERT [dbo].[HC.Sexuality] OFF
GO
SET IDENTITY_INSERT [dbo].[Lottery] ON 

GO
INSERT [dbo].[Lottery] ([id], [viewId], [ownerId], [startDate], [endDate], [lotteryDate], [total], [month], [insertedById], [insertDate], [updateById], [updateDate]) VALUES (1053, N'bf0db906-ed66-4303-b49c-2483a695f663', 56, CAST(N'2017-05-22 00:00:00.000' AS DateTime), CAST(N'2017-06-22 00:00:00.000' AS DateTime), CAST(N'2017-06-25 16:00:42.220' AS DateTime), 4, N'خرداد', 2, CAST(N'2017-06-25 16:00:42.220' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Lottery] ([id], [viewId], [ownerId], [startDate], [endDate], [lotteryDate], [total], [month], [insertedById], [insertDate], [updateById], [updateDate]) VALUES (1054, N'15f6ac1c-88d9-45aa-8afc-785cabe98e2c', 58, CAST(N'2017-05-22 00:00:00.000' AS DateTime), CAST(N'2017-06-22 00:00:00.000' AS DateTime), CAST(N'2017-06-25 16:00:42.247' AS DateTime), 4, N'خرداد', 2, CAST(N'2017-06-25 16:00:42.247' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Lottery] ([id], [viewId], [ownerId], [startDate], [endDate], [lotteryDate], [total], [month], [insertedById], [insertDate], [updateById], [updateDate]) VALUES (1055, N'08005b6f-f1c4-4613-b32c-e9e03e8b4eab', 54, CAST(N'2017-05-22 00:00:00.000' AS DateTime), CAST(N'2017-06-22 00:00:00.000' AS DateTime), CAST(N'2017-06-25 16:00:42.270' AS DateTime), 3, N'خرداد', 2, CAST(N'2017-06-25 16:00:42.270' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Lottery] ([id], [viewId], [ownerId], [startDate], [endDate], [lotteryDate], [total], [month], [insertedById], [insertDate], [updateById], [updateDate]) VALUES (1056, N'61954f16-d104-4359-bf98-1733a58c7b52', 52, CAST(N'2017-05-22 00:00:00.000' AS DateTime), CAST(N'2017-06-22 00:00:00.000' AS DateTime), CAST(N'2017-06-25 16:00:42.283' AS DateTime), 4, N'خرداد', 2, CAST(N'2017-06-25 16:00:42.283' AS DateTime), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Lottery] OFF
GO
SET IDENTITY_INSERT [dbo].[Owner] ON 

GO
INSERT [dbo].[Owner] ([id], [viewId], [nationalCode], [name], [lastname], [birthdate], [birthdatelocal], [gen], [phone], [mobile], [address], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (52, N'81c3ff86-5c46-498d-8934-4ebbc7d2c74b', N'4324260869', N'علي', N'رضايي', NULL, N'', 1, N'', N'09193862018', N'', 2, CAST(N'2017-04-25 11:34:41.823' AS DateTime), 2, CAST(N'2017-04-30 14:49:00.050' AS DateTime))
GO
INSERT [dbo].[Owner] ([id], [viewId], [nationalCode], [name], [lastname], [birthdate], [birthdatelocal], [gen], [phone], [mobile], [address], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (53, N'817648c6-9927-4706-89b7-5fb54dc3204d', N'4320686871', N'مرجان', N'قبادي', NULL, N'', 2, N'', N'09193862018', N'', 2, CAST(N'2017-04-25 19:27:29.267' AS DateTime), 2, CAST(N'2017-06-18 12:13:33.213' AS DateTime))
GO
INSERT [dbo].[Owner] ([id], [viewId], [nationalCode], [name], [lastname], [birthdate], [birthdatelocal], [gen], [phone], [mobile], [address], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (54, N'703d9659-2e77-45b1-a195-bce47d5e2f4b', N'4324234320', N'رضا', N'محمدي', NULL, N'', 1, N'', N'09121829155', N'', 2, CAST(N'2017-04-25 19:28:44.577' AS DateTime), 2, CAST(N'2017-04-30 14:54:12.750' AS DateTime))
GO
INSERT [dbo].[Owner] ([id], [viewId], [nationalCode], [name], [lastname], [birthdate], [birthdatelocal], [gen], [phone], [mobile], [address], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (55, N'4d8b7ded-8c37-4054-bede-2dcc12bcafa4', N'4000000000', N'علي', N'علوي', NULL, N'', 1, N'', N'09193332211', N'', 2, CAST(N'2017-06-25 14:04:01.313' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Owner] ([id], [viewId], [nationalCode], [name], [lastname], [birthdate], [birthdatelocal], [gen], [phone], [mobile], [address], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (56, N'8ff0eb4a-3ce7-41fb-9ae6-41f12fea85c7', N'4222222222', N'اکبر', N'اکبري', NULL, N'', 1, N'', N'09193332210', N'', 2, CAST(N'2017-06-25 14:04:40.210' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Owner] ([id], [viewId], [nationalCode], [name], [lastname], [birthdate], [birthdatelocal], [gen], [phone], [mobile], [address], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (57, N'5dc6a1ff-6110-48d5-a32e-a2ccfe74202f', N'4566666666', N'رضا', N'رضايي', NULL, N'', 1, N'', N'09123335665', N'', 2, CAST(N'2017-06-25 14:05:22.473' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Owner] ([id], [viewId], [nationalCode], [name], [lastname], [birthdate], [birthdatelocal], [gen], [phone], [mobile], [address], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (58, N'b5c376ac-6405-48e2-bea5-c731ad20dd3b', N'1212334455', N'محمد', N'محمدي', NULL, N'', 1, N'', N'09124567889', N'', 2, CAST(N'2017-06-25 14:06:04.253' AS DateTime), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Owner] OFF
GO
SET IDENTITY_INSERT [dbo].[Plate] ON 

GO
INSERT [dbo].[Plate] ([id], [viewId], [plateTypeId], [plateCityId], [plate], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (64, N'8c5adee2-880d-4121-883a-a8899849c34d', 10, 228, N'78_خ_555_79', 2, CAST(N'2017-04-25 19:28:44.567' AS DateTime), 2, CAST(N'2017-04-30 14:54:12.573' AS DateTime))
GO
INSERT [dbo].[Plate] ([id], [viewId], [plateTypeId], [plateCityId], [plate], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (65, N'54740a9a-c77a-4880-b778-2da96c04a423', 10, 228, N'17_ه_177_79', 2, CAST(N'2017-04-29 22:05:18.353' AS DateTime), 2, CAST(N'2017-04-30 14:49:00.020' AS DateTime))
GO
INSERT [dbo].[Plate] ([id], [viewId], [plateTypeId], [plateCityId], [plate], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (66, N'c8098d16-7212-49d9-b70d-ffdc1cfd56df', 11, 228, N'15_ت_155_79', 2, CAST(N'2017-06-18 12:13:33.180' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Plate] ([id], [viewId], [plateTypeId], [plateCityId], [plate], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (1066, N'daa39453-fce3-4e1d-b4a2-458bade8b52e', 11, 228, N'15_ت_123_79', 2, CAST(N'2017-06-25 14:04:01.287' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Plate] ([id], [viewId], [plateTypeId], [plateCityId], [plate], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (1067, N'db9950b2-3b11-4970-ac26-002046637a1a', 10, 228, N'14_م_111_79', 2, CAST(N'2017-06-25 14:04:40.187' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Plate] ([id], [viewId], [plateTypeId], [plateCityId], [plate], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (1068, N'4fbab47f-9d82-49f8-8af2-db752eacc464', 11, 228, N'48_ت_466_79', 2, CAST(N'2017-06-25 14:05:22.297' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Plate] ([id], [viewId], [plateTypeId], [plateCityId], [plate], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (1069, N'6c0d6a57-7d24-44ca-84b7-a08eec452a48', 11, 228, N'89_ت_123_79', 2, CAST(N'2017-06-25 14:06:04.063' AS DateTime), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Plate] OFF
GO
SET IDENTITY_INSERT [dbo].[System.Data] ON 

GO
INSERT [dbo].[System.Data] ([id], [viewId], [name], [value]) VALUES (3, N'dd010c7e-f228-467b-9eaa-42f4a94dad9c', N'DB-Version', N'96-04-03-1')
GO
SET IDENTITY_INSERT [dbo].[System.Data] OFF
GO
SET IDENTITY_INSERT [dbo].[Tag] ON 

GO
INSERT [dbo].[Tag] ([id], [viewId], [tag], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (59, N'd7ea5e56-669d-4937-822a-9c7d4b1aea6e', N'123456', 2, CAST(N'2017-04-25 19:28:44.623' AS DateTime), 2, CAST(N'2017-04-30 14:54:12.837' AS DateTime))
GO
INSERT [dbo].[Tag] ([id], [viewId], [tag], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (60, N'abbf6ffa-16d1-482d-bc07-4a6f7a7b0137', N'12345', 2, CAST(N'2017-04-29 22:05:18.413' AS DateTime), 2, CAST(N'2017-04-30 14:49:07.030' AS DateTime))
GO
INSERT [dbo].[Tag] ([id], [viewId], [tag], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (62, N'95fabe73-67e0-4abf-92c4-7a9a20397815', N'12345678', 2, CAST(N'2017-06-18 12:13:33.297' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Tag] ([id], [viewId], [tag], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (1062, N'8fe1edde-ac92-4346-890c-a9966dcb694a', N'1', 2, CAST(N'2017-06-25 14:04:01.383' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Tag] ([id], [viewId], [tag], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (1063, N'a58bee4a-2dd5-49c9-a475-c925fbc56fb2', N'12', 2, CAST(N'2017-06-25 14:04:40.263' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Tag] ([id], [viewId], [tag], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (1064, N'6227dd35-a169-463a-8ec9-8250b3ea456c', N'123', 2, CAST(N'2017-06-25 14:05:22.533' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Tag] ([id], [viewId], [tag], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (1065, N'f007db30-1b12-47ca-a49d-0f3fb289b4bb', N'1234', 2, CAST(N'2017-06-25 14:06:04.327' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Tag] ([id], [viewId], [tag], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (1066, N'a0e2c727-238e-4578-97b1-d7209b06205e', N'1234567', 4, CAST(N'2017-06-25 14:12:41.330' AS DateTime), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Tag] OFF
GO
SET IDENTITY_INSERT [dbo].[Traffic] ON 

GO
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [trafficDate]) VALUES (1082, N'c390d71e-3111-4aa0-9f2f-d246983ef399', 1062, CAST(N'2017-06-25 14:09:47.530' AS DateTime))
GO
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [trafficDate]) VALUES (1083, N'bef7bf5a-5492-4511-930a-50ef213ab3cb', 1063, CAST(N'2017-06-25 14:09:50.380' AS DateTime))
GO
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [trafficDate]) VALUES (1084, N'c20fed4b-5cc3-4b66-9349-0aa3704a4593', 1064, CAST(N'2017-06-25 14:09:51.330' AS DateTime))
GO
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [trafficDate]) VALUES (1085, N'91c2e50a-1ead-4782-9f93-eadacc3fd03e', 1065, CAST(N'2017-06-25 14:09:53.377' AS DateTime))
GO
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [trafficDate]) VALUES (1086, N'9a768aa8-6f43-401c-b7e0-d19375dffd68', 60, CAST(N'2017-06-25 14:09:54.447' AS DateTime))
GO
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [trafficDate]) VALUES (1087, N'bcec27f7-2c22-4474-97e9-01c24ba4ddeb', 59, CAST(N'2017-06-25 14:09:55.480' AS DateTime))
GO
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [trafficDate]) VALUES (1089, N'fb61a2c4-a0a3-4a4c-a5b1-39d95df0dfca', 62, CAST(N'2017-06-25 14:09:58.030' AS DateTime))
GO
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [trafficDate]) VALUES (1090, N'aceae945-9dab-471b-8c6b-e33b6c707d38', 62, CAST(N'2017-06-25 14:10:12.067' AS DateTime))
GO
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [trafficDate]) VALUES (1091, N'c401d7c4-6ea0-4058-a5cb-34ba6720c5c5', 1062, CAST(N'2017-06-25 14:10:15.893' AS DateTime))
GO
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [trafficDate]) VALUES (1092, N'5330376b-309e-4da8-adae-1eacc23c9b71', 1063, CAST(N'2017-06-25 14:10:18.160' AS DateTime))
GO
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [trafficDate]) VALUES (1093, N'4968d462-6b69-4a8d-8948-751cc6ec9da0', 1064, CAST(N'2017-06-25 14:10:19.453' AS DateTime))
GO
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [trafficDate]) VALUES (1094, N'eeaa613e-9217-4d3d-97f9-14ef159272a3', 1065, CAST(N'2017-06-25 14:10:20.353' AS DateTime))
GO
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [trafficDate]) VALUES (1095, N'c8c17f07-f59c-42b8-9445-773e70d807fe', 60, CAST(N'2017-06-25 14:10:21.903' AS DateTime))
GO
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [trafficDate]) VALUES (1096, N'2a99f349-e472-4ea1-b750-8eb9bdbb5cda', 59, CAST(N'2017-06-25 14:10:22.737' AS DateTime))
GO
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [trafficDate]) VALUES (1098, N'1c5eaf9e-d385-4b52-a08b-938440415a5e', 62, CAST(N'2017-06-22 14:09:47.000' AS DateTime))
GO
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [trafficDate]) VALUES (1099, N'525e1d16-e748-4987-8d82-e50b1bcfded6', 1062, CAST(N'2017-06-22 14:09:47.000' AS DateTime))
GO
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [trafficDate]) VALUES (1100, N'2a43d5ca-63f0-4f43-a77b-afe1d6201d7d', 1063, CAST(N'2017-06-22 14:09:47.000' AS DateTime))
GO
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [trafficDate]) VALUES (1101, N'a1c6fcda-b649-47b4-abb3-73f44604f0af', 1063, CAST(N'2017-06-22 14:09:47.000' AS DateTime))
GO
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [trafficDate]) VALUES (1102, N'ab5013a6-1b14-468c-8c44-792a4a222e67', 1064, CAST(N'2017-06-22 14:09:47.000' AS DateTime))
GO
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [trafficDate]) VALUES (1103, N'731669f6-8667-4038-8d76-fe186302b669', 1065, CAST(N'2017-06-22 14:09:47.000' AS DateTime))
GO
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [trafficDate]) VALUES (1104, N'4ccbca72-27e8-4aa4-980e-5d79460c13ff', 60, CAST(N'2017-06-22 14:09:47.000' AS DateTime))
GO
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [trafficDate]) VALUES (1105, N'08983ca4-17bf-449b-b347-cb2c81807e1f', 59, CAST(N'2017-06-22 14:09:47.000' AS DateTime))
GO
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [trafficDate]) VALUES (1106, N'ee9b1b6d-ef8f-4c2b-8016-dd3e7c675e81', 1066, CAST(N'2017-06-22 14:09:47.000' AS DateTime))
GO
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [trafficDate]) VALUES (1107, N'0712634c-cc13-4804-baa2-3ed6b1b79568', 62, CAST(N'2017-06-22 14:09:47.000' AS DateTime))
GO
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [trafficDate]) VALUES (1108, N'3af18ccf-ad20-4fdf-ac20-23620752b012', 62, CAST(N'2017-06-21 14:09:47.000' AS DateTime))
GO
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [trafficDate]) VALUES (1109, N'5aab8017-cfc7-4232-b6a0-f35b5544c08d', 1066, CAST(N'2017-06-21 14:09:47.000' AS DateTime))
GO
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [trafficDate]) VALUES (1110, N'db743775-52ab-478d-a40d-f94b3600afe4', 59, CAST(N'2017-06-21 14:09:47.000' AS DateTime))
GO
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [trafficDate]) VALUES (1111, N'd31bf11b-5cb3-404a-9eeb-82aabcc89e39', 60, CAST(N'2017-06-21 14:09:47.000' AS DateTime))
GO
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [trafficDate]) VALUES (1112, N'6630bb4f-46c2-4d73-a96d-b18fe76cd668', 1065, CAST(N'2017-06-21 14:09:47.000' AS DateTime))
GO
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [trafficDate]) VALUES (1113, N'b6196824-ec7e-430b-b831-12d9fffd4c39', 1064, CAST(N'2017-06-21 14:09:47.000' AS DateTime))
GO
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [trafficDate]) VALUES (1114, N'0322940a-797a-49ff-95b9-83e00289bad0', 1063, CAST(N'2017-06-21 14:09:47.000' AS DateTime))
GO
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [trafficDate]) VALUES (1115, N'f235f705-814b-4466-a98d-25cadb3e6b91', 1062, CAST(N'2017-06-21 14:09:47.000' AS DateTime))
GO
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [trafficDate]) VALUES (1116, N'61ce79be-93d8-45df-89ed-78f0afe3295e', 1063, CAST(N'2017-06-21 14:09:47.000' AS DateTime))
GO
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [trafficDate]) VALUES (1117, N'018ef807-808b-4b76-8301-967c3a1bd59a', 1064, CAST(N'2017-06-21 14:09:47.000' AS DateTime))
GO
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [trafficDate]) VALUES (1118, N'2f383709-78d8-4ded-9e22-0a82654a328c', 1065, CAST(N'2017-06-21 14:09:47.000' AS DateTime))
GO
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [trafficDate]) VALUES (1119, N'c2256aa4-6f95-4bdc-85dd-c67dbc3383a0', 60, CAST(N'2017-06-21 14:09:47.000' AS DateTime))
GO
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [trafficDate]) VALUES (1120, N'3fc28af5-2014-4da4-b119-c00ac71ba3b8', 59, CAST(N'2017-06-21 14:09:47.000' AS DateTime))
GO
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [trafficDate]) VALUES (1121, N'e22b67e3-72e7-4b72-8f58-9746e3d778e4', 1066, CAST(N'2017-06-21 14:09:47.000' AS DateTime))
GO
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [trafficDate]) VALUES (1122, N'2564bbad-a723-4a13-b5f8-0ad6f757129e', 1066, CAST(N'2017-06-19 14:09:47.000' AS DateTime))
GO
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [trafficDate]) VALUES (1123, N'4239eeda-d688-4339-9ef0-1e79e3098dcf', 59, CAST(N'2017-06-19 14:09:47.000' AS DateTime))
GO
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [trafficDate]) VALUES (1124, N'34ca341b-e071-46a2-bc71-ce4e4f6a2633', 60, CAST(N'2017-06-19 14:09:47.000' AS DateTime))
GO
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [trafficDate]) VALUES (1125, N'f67f6cd6-06b4-4799-8919-e3d953f5d53e', 1065, CAST(N'2017-06-19 14:09:47.000' AS DateTime))
GO
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [trafficDate]) VALUES (1126, N'df308507-3de5-44ae-b99d-b8173438e99c', 1064, CAST(N'2017-06-19 14:09:47.000' AS DateTime))
GO
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [trafficDate]) VALUES (1127, N'823eccb0-d920-4f24-9891-36a22294c92e', 1063, CAST(N'2017-06-19 14:09:47.000' AS DateTime))
GO
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [trafficDate]) VALUES (1128, N'1d4e4076-a9da-48b1-9ca6-7b78758b7e37', 1063, CAST(N'2017-06-11 14:09:47.000' AS DateTime))
GO
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [trafficDate]) VALUES (1129, N'1c533091-1474-4ff4-951b-bfe498d02f9c', 1064, CAST(N'2017-06-11 14:09:47.000' AS DateTime))
GO
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [trafficDate]) VALUES (1130, N'bb76abab-241a-44f6-85ec-e1c20fe34f26', 1065, CAST(N'2017-06-11 14:09:47.000' AS DateTime))
GO
INSERT [dbo].[Traffic] ([id], [viewId], [tagId], [trafficDate]) VALUES (1131, N'1ed3036c-81f0-421a-bd0b-83b3e6847c67', 60, CAST(N'2017-06-11 14:09:47.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Traffic] OFF
GO
SET IDENTITY_INSERT [dbo].[UHF] ON 

GO
INSERT [dbo].[UHF] ([id], [viewId], [IP], [Port], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (1, N'2cf20660-a678-48d2-9153-6fffc958e5da', N'192.168.1.201', 10001, 2, CAST(N'2016-03-12 00:00:00.000' AS DateTime), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[UHF] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

GO
INSERT [dbo].[User] ([id], [viewId], [name], [lastname], [username], [password], [inserted], [enable]) VALUES (2, N'6b5d6474-8382-47ba-9f2b-aa4edd7b9ee0', N'علي', N'محبوبي', N'admin', N'123', CAST(N'2016-11-25 10:30:50.900' AS DateTime), 1)
GO
INSERT [dbo].[User] ([id], [viewId], [name], [lastname], [username], [password], [inserted], [enable]) VALUES (3, N'b30586e2-ca38-4b1f-9ae9-4a8551e1afa0', N'مرجان', N'قبادي', N'mj', N'123', CAST(N'2016-11-30 15:10:58.400' AS DateTime), 1)
GO
INSERT [dbo].[User] ([id], [viewId], [name], [lastname], [username], [password], [inserted], [enable]) VALUES (4, N'0467305e-f37d-4945-aa08-92dd838c5fa7', N'Service', N'', N'ServiceUser', N'$3r\/Ic3U53R', CAST(N'2016-12-07 12:11:21.967' AS DateTime), 1)
GO
SET IDENTITY_INSERT [dbo].[User] OFF
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_LegalOwner]    Script Date: 2018-01-28 2:58:22 PM ******/
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
ALTER TABLE [dbo].[Lottery]  WITH CHECK ADD  CONSTRAINT [FK_Lottery_User_Modify] FOREIGN KEY([updateById])
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
/****** Object:  StoredProcedure [dbo].[spGetCarSearchByNationalcode]    Script Date: 2018-01-28 2:58:22 PM ******/
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

		inner join Car				ON Car.plateId = Plate.id	
		inner join [Base.PlateType] ON [Base.PlateType].id = Plate.plateTypeId
		inner join [Base.CarColor]	ON [Base.CarColor].id = Car.carColorId
		inner join [Base.CarType]	ON [Base.CarType].id = Car.carTypeId
		inner join [Base.PlateCity] ON [Base.PlateCity].id = Plate.plateCityId
		inner join CarOwner			ON CarOwner.carId = Car.id
		inner join Owner			ON Owner.id = CarOwner.ownerId
		inner join CarTag			ON CarTag.carId = Car.id
		inner join Tag				ON Tag.id = CarTag.tagId		

		WHERE nationalCode = @nationalCode
		GROUP BY [Base.CarType].type ,[Base.CarColor].color, plate,[Base.PlateCity].city, [Base.PlateType].type , Tag.tag
END


GO
/****** Object:  StoredProcedure [dbo].[spGetCarSearchByPlate]    Script Date: 2018-01-28 2:58:22 PM ******/
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

			inner join Car				ON Car.plateId = Plate.id	
			inner join [Base.PlateType] ON [Base.PlateType].id = Plate.plateTypeId
			inner join [Base.CarColor]	ON [Base.CarColor].id = Car.carColorId
			inner join [Base.CarType]	ON [Base.CarType].id = Car.carTypeId
			inner join [Base.PlateCity] ON [Base.PlateCity].id = Plate.plateCityId
			inner join CarOwner			ON CarOwner.carId = Car.id
			inner join [Owner]			ON [Owner].id = CarOwner.ownerId
			inner join CarTag			ON CarTag.carId = Car.id
			inner join Tag				ON Tag.id = CarTag.tagId		

			WHERE plate = @plate
			GROUP BY [Base.CarType].type, [Base.CarColor].color, plate,[Base.PlateCity].city, [Base.PlateType].type, Tag.tag
END


GO
/****** Object:  StoredProcedure [dbo].[spGetLottery]    Script Date: 2018-01-28 2:58:22 PM ******/
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
			ROW_NUMBER() OVER(ORDER BY [Owner].id DESC) AS Row,
			[Owner].id,
			[Owner].name,
			[Owner].lastname, 
			[Owner].nationalCode, 
			[Owner].mobile,
			plate,
			Lottery.[month],
			Lottery.total as total
			
			

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
			INNER JOIN Lottery			ON Lottery.ownerId = Owner.id
		

			WHERE 	
			
				(dbo.Lottery.startDate =  @startDate AND dbo.Lottery.endDate = @endDate)
			
			
			
			GROUP BY [Owner].id, [Owner].name, [owner].lastname, [Owner].nationalCode, [owner].mobile, plate,Lottery.[month], Lottery.total
			ORDER BY Lottery.total DESC
END

GO
/****** Object:  StoredProcedure [dbo].[spGetOwnerSearchByPlate]    Script Date: 2018-01-28 2:58:22 PM ******/
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
/****** Object:  StoredProcedure [dbo].[spGetReportTraffic]    Script Date: 2018-01-28 2:58:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spGetReportTraffic] 
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


GO
/****** Object:  StoredProcedure [dbo].[spGetReportTrafficByNationalcode]    Script Date: 2018-01-28 2:58:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spGetReportTrafficByNationalcode] 
	@startDate as datetime,
	@endDate	as datetime,
	@nationalcode as varchar(10)
AS
BEGIN

	SET NOCOUNT ON;
	SELECT 
		ROW_NUMBER() OVER(ORDER BY dbo.Traffic.trafficDate DESC) AS Row,
		dbo.Owner.name, 
		dbo.Owner.lastname,
		dbo.Owner.mobile,
		dbo.Plate.plate,		
		dbo.Traffic.trafficDate

		FROM

		dbo.Traffic

		inner join dbo.Tag			on dbo.Tag.id			= dbo.Traffic.tagId 
		inner join dbo.CarTag		on dbo.CarTag.tagId		= dbo.Traffic.tagId
		inner join dbo.Car			on dbo.Car.id			= dbo.CarTag.carId
		inner join dbo.Plate		on dbo.Plate.id			= dbo.Car.plateId
		inner join dbo.CarOwner		on dbo.CarOwner.carId	= dbo.Car.id
		inner join dbo.Owner		on dbo.Owner.id			= dbo.CarOwner.ownerId

		 WHERE 
			dbo.Traffic.trafficDate BETWEEN @startDate AND @endDate		
			AND nationalCode =  @nationalcode
END


GO
/****** Object:  StoredProcedure [dbo].[spGetReportTrafficByPlate]    Script Date: 2018-01-28 2:58:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spGetReportTrafficByPlate] 
	@startDate	as datetime,
	@endDate	as datetime,
	@plate		as varchar(50)
AS
BEGIN

	SET NOCOUNT ON;
	SELECT 
		ROW_NUMBER() OVER(ORDER BY dbo.Traffic.trafficDate DESC) AS Row,
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
			dbo.Traffic.trafficDate BETWEEN @startDate AND @endDate		
			AND plate =  @plate
END


GO
/****** Object:  StoredProcedure [dbo].[spGetReportTrafficCount]    Script Date: 2018-01-28 2:58:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Description:	Show  Count Traffic 
-- =============================================
CREATE PROCEDURE [dbo].[spGetReportTrafficCount]
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
		plate,
		--COUNT(*) as total,
		SUM(COUNT(*)) OVER (PARTITION BY [Owner].nationalCode ORDER BY [Owner].id ASC) AS 'total'
		

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

		WHERE 	
			
			(dbo.Traffic.trafficDate BETWEEN  @startDate AND  @endDate)
			
			
			
		GROUP BY [Owner].id, [Owner].name, [owner].lastname, [Owner].nationalCode, [Owner].mobile, plate
	
		ORDER BY [Owner].id, [Owner].name, [Owner].lastname, [Owner].nationalCode, [Owner].mobile, plate
END


GO
/****** Object:  StoredProcedure [dbo].[spGetReportTrafficCount1]    Script Date: 2018-01-28 2:58:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Description:	Show  Count Traffic 
-- =============================================
CREATE PROCEDURE [dbo].[spGetReportTrafficCount1]
	@startDate as Datetime,
	@endDate	as Datetime
	
AS
BEGIN
	SELECT  
		[Owner].id,
		[Owner].name,
		[Owner].lastname, 
		[Owner].nationalCode, 
		[Owner].mobile,
		plate,
		COUNT(*)as total
		

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

		WHERE 	
			
			(dbo.Traffic.trafficDate BETWEEN  @startDate AND  @endDate)
			
			
			
		GROUP BY [Owner].id, [Owner].name, [owner].lastname, [Owner].nationalCode, [owner].mobile, plate
		ORDER BY total DESC
END


GO
/****** Object:  StoredProcedure [dbo].[spGetReportTrafficCountByNationalcode]    Script Date: 2018-01-28 2:58:22 PM ******/
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
	@nationalcode varchar(10)
AS
BEGIN	

SELECT 
		ROW_NUMBER() OVER(PARTITION BY [Owner].nationalCode ORDER BY [Owner].id ASC) AS Row, 
		[Owner].id,
		[Owner].name,
		[Owner].lastname, 
		[Owner].nationalCode, 
		[Owner].mobile,
		plate,
		COUNT(*) as total

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

		WHERE 	
			
			(dbo.Traffic.trafficDate BETWEEN  @startDate AND  @endDate)
			AND nationalCode = @nationalcode 
			
		GROUP BY [Owner].id, [Owner].name, [owner].lastname, [Owner].nationalCode, [owner].mobile, plate

	
END


GO
/****** Object:  StoredProcedure [dbo].[spGetReportTrafficCountByPlate]    Script Date: 2018-01-28 2:58:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Description:	Get Traffic count By date and plate
-- =============================================
CREATE PROCEDURE [dbo].[spGetReportTrafficCountByPlate]
	@startDate datetime,
	@endDate datetime,
	@plate varchar(50)
AS
BEGIN	

SELECT  
		ROW_NUMBER() OVER(PARTITION BY [Owner].nationalCode ORDER BY [Owner].id ASC) AS Row, 
		[Owner].id,
		[Owner].name,
		[Owner].lastname, 
		[Owner].nationalCode, 
		[Owner].mobile,
		plate,
		COUNT(*) as total

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

		WHERE 	
			
			dbo.Traffic.trafficDate BETWEEN  @startDate AND  @endDate
			AND plate = @plate 
			
		GROUP BY [Owner].id,[Owner].name, [owner].lastname, [Owner].nationalCode, [owner].mobile, plate

	
END


GO
/****** Object:  StoredProcedure [dbo].[spGetTrafficSearchByNationalcode]    Script Date: 2018-01-28 2:58:22 PM ******/
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

			inner join Car				ON Car.plateId = Plate.id	
			inner join [Base.PlateType] ON [Base.PlateType].id = Plate.plateTypeId
			inner join [Base.CarColor]	ON [Base.CarColor].id = Car.carColorId
			inner join [Base.CarType]	ON [Base.CarType].id = Car.carTypeId
			inner join [Base.PlateCity] ON [Base.PlateCity].id = Plate.plateCityId
			inner join CarOwner			ON CarOwner.carId = Car.id
			inner join [Owner]			ON [Owner].id = CarOwner.ownerId
			inner join CarTag			ON CarTag.carId = Car.id
			inner join Tag				ON Tag.id = CarTag.tagId
			inner join Traffic			ON Traffic.tagId = Tag.id

			WHERE nationalCode = @nationalCode
			GROUP BY plate, Traffic.trafficDate
END


GO
/****** Object:  StoredProcedure [dbo].[spGetTrafficSerachByPlate]    Script Date: 2018-01-28 2:58:22 PM ******/
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

		inner join Car				ON Car.plateId = Plate.id	
		inner join [Base.PlateType] ON [Base.PlateType].id = Plate.plateTypeId
		inner join [Base.CarColor]	ON [Base.CarColor].id = Car.carColorId
		inner join [Base.CarType]	ON [Base.CarType].id = Car.carTypeId
		inner join [Base.PlateCity] ON [Base.PlateCity].id = Plate.plateCityId
		inner join CarOwner			ON CarOwner.carId = Car.id
		inner join [Owner]			ON [Owner].id = CarOwner.ownerId
		inner join CarTag			ON CarTag.carId = Car.id
		inner join Tag				ON Tag.id = CarTag.tagId
		inner join Traffic			ON Traffic.tagId = Tag.id

		WHERE plate = @plate
		GROUP BY plate, Traffic.trafficDate
END


GO
/****** Object:  StoredProcedure [dbo].[spOwnerSearchWithCode]    Script Date: 2018-01-28 2:58:22 PM ******/
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
/****** Object:  StoredProcedure [dbo].[spShowCustomer]    Script Date: 2018-01-28 2:58:22 PM ******/
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
		inner join dbo.[Base.PlateType]  ON dbo.[Base.PlateType].id = dbo.Plate.plateTypeId
		inner join dbo.[Base.PlateCity]  ON dbo.[Base.PlateCity].id = dbo.Plate.plateCityId
		inner join dbo.Car				 ON dbo.Car.plateId = dbo.Plate.id
		inner join dbo.[Base.CarColor]	 ON dbo.[Base.CarColor].id = dbo.Car.carColorId	
		inner join dbo.[Base.CarLevel]	 ON dbo.[Base.CarLevel].id = dbo.Car.carLevelId
		inner join dbo.[Base.CarType]	 ON dbo.[Base.CarType].id = dbo.Car.carTypeId
		inner join dbo.[Base.CarSystem]	 ON dbo.[Base.CarSystem].id = dbo.Car.carSystemId
		inner join dbo.CarOwner			 ON dbo.CarOwner.carId    = dbo.Car.id
		inner join dbo.Owner			 ON dbo.Owner.id = dbo.CarOwner.ownerId		
END


GO
/****** Object:  StoredProcedure [dbo].[spShowCustomerTag]    Script Date: 2018-01-28 2:58:22 PM ******/
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
			inner join CarTag	ON CarTag.tagId = Tag.id
			inner join Car		ON Car.id = CarTag.carId
			inner join Plate	ON Plate.id = Car.plateId
			inner join CarOwner	ON CarOwner.carId = Car.id
			inner join Owner	ON Owner.id = CarOwner.ownerId
END


GO
/****** Object:  StoredProcedure [dbo].[spTrafficDelete]    Script Date: 2018-01-28 2:58:22 PM ******/
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
/****** Object:  StoredProcedure [dbo].[spTrafficRegisterByService]    Script Date: 2018-01-28 2:58:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create  PROCEDURE [dbo].[spTrafficRegisterByService]
(
	@tagData		varchar(50),
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
					(tagId, trafficDate)
			VALUES
					(@tagId, @trafficDate);

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

DECLARE @version	varchar(50) = '96-01-02-1';

IF EXISTS (SELECT * FROM [System.Data] WHERE ([name] = 'DB-Version'))
	BEGIN
		UPDATE [System.Data] SET [value]=@version WHERE ([name] = 'DB-Version')
	END
ELSE
	BEGIN
		INSERT INTO [System.Data] ([name], [value]) VALUES ('DB-Version', @version)
	END


GO
/****** Object:  StoredProcedure [dbo].[spUserDelete]    Script Date: 2018-01-28 2:58:22 PM ******/
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
