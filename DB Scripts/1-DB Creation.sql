USE [FutureAgroSQL]
GO
/****** Object:  Table [dbo].[Boundary]    Script Date: 2019-10-09 8:33:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Boundary](
	[BoundaryId] [int] IDENTITY(1,1) NOT NULL,
	[PlantTypeId] [int] NOT NULL,
	[MinDO] [int] NULL,
	[MaxDO] [int] NULL,
	[OptDO] [int] NULL,
	[UnitDO] [nvarchar](5) NULL,
	[MinPH] [decimal](3, 1) NULL,
	[MaxPH] [decimal](3, 1) NULL,
	[OptPH] [decimal](3, 1) NULL,
	[UnitPH] [nvarchar](5) NULL,
	[MinEC] [int] NULL,
	[MaxEC] [int] NULL,
	[OptEC] [int] NULL,
	[UnitEC] [nvarchar](5) NULL,
	[MinORP] [int] NULL,
	[MaxORP] [int] NULL,
	[OptORP] [int] NULL,
	[UnitORP] [nvarchar](5) NULL,
	[MinTemp] [int] NOT NULL,
	[MaxTemp] [int] NOT NULL,
	[OptTemp] [int] NULL,
	[UnitTemp] [nvarchar](5) NULL,
	[MinLum] [int] NOT NULL,
	[MaxLum] [int] NOT NULL,
 CONSTRAINT [PK_ParamPlant] PRIMARY KEY CLUSTERED 
(
	[BoundaryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Crop]    Script Date: 2019-10-09 8:33:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Crop](
	[CropId] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](20) NOT NULL,
	[PlantTypeId] [int] NOT NULL,
 CONSTRAINT [PK_Crop] PRIMARY KEY CLUSTERED 
(
	[CropId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Plant]    Script Date: 2019-10-09 8:33:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Plant](
	[PlantId] [int] IDENTITY(1,1) NOT NULL,
	[TrayXCropId] [int] NOT NULL,
	[PlantTypeId] [int] NOT NULL,
	[IsAlive] [bit] NOT NULL,
	[Growth] [int] NOT NULL,
 CONSTRAINT [PK_Plant] PRIMARY KEY CLUSTERED 
(
	[PlantId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PlantType]    Script Date: 2019-10-09 8:33:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PlantType](
	[PlantTypeId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_PlantType] PRIMARY KEY CLUSTERED 
(
	[PlantTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tray]    Script Date: 2019-10-09 8:33:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tray](
	[TrayId] [int] IDENTITY(1,1) NOT NULL,
	[Capacity] [int] NOT NULL,
 CONSTRAINT [PK_Tray] PRIMARY KEY CLUSTERED 
(
	[TrayId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TrayXCrop]    Script Date: 2019-10-09 8:33:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrayXCrop](
	[TrayXCropId] [int] IDENTITY(1,1) NOT NULL,
	[CropId] [int] NOT NULL,
	[TrayId] [int] NOT NULL,
	[CreationDate] [date] NOT NULL,
 CONSTRAINT [PK_TrayXCrop] PRIMARY KEY CLUSTERED 
(
	[TrayXCropId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User]    Script Date: 2019-10-09 8:33:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](120) NOT NULL,
	[Password] [nvarchar](256) NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Plant] ADD  CONSTRAINT [DF_Plant_IsAlive]  DEFAULT ((1)) FOR [IsAlive]
GO
ALTER TABLE [dbo].[Boundary]  WITH CHECK ADD  CONSTRAINT [FK_Boundary_PlantType] FOREIGN KEY([PlantTypeId])
REFERENCES [dbo].[PlantType] ([PlantTypeId])
GO
ALTER TABLE [dbo].[Boundary] CHECK CONSTRAINT [FK_Boundary_PlantType]
GO
ALTER TABLE [dbo].[Crop]  WITH CHECK ADD  CONSTRAINT [FK_Crop_PlantType] FOREIGN KEY([PlantTypeId])
REFERENCES [dbo].[PlantType] ([PlantTypeId])
GO
ALTER TABLE [dbo].[Crop] CHECK CONSTRAINT [FK_Crop_PlantType]
GO
ALTER TABLE [dbo].[Plant]  WITH CHECK ADD  CONSTRAINT [FK_Plant_PlantType] FOREIGN KEY([PlantTypeId])
REFERENCES [dbo].[PlantType] ([PlantTypeId])
GO
ALTER TABLE [dbo].[Plant] CHECK CONSTRAINT [FK_Plant_PlantType]
GO
ALTER TABLE [dbo].[Plant]  WITH CHECK ADD  CONSTRAINT [FK_Plant_TrayXCrop] FOREIGN KEY([TrayXCropId])
REFERENCES [dbo].[TrayXCrop] ([TrayXCropId])
GO
ALTER TABLE [dbo].[Plant] CHECK CONSTRAINT [FK_Plant_TrayXCrop]
GO
ALTER TABLE [dbo].[TrayXCrop]  WITH CHECK ADD  CONSTRAINT [FK_TrayXCrop_Crop] FOREIGN KEY([CropId])
REFERENCES [dbo].[Crop] ([CropId])
GO
ALTER TABLE [dbo].[TrayXCrop] CHECK CONSTRAINT [FK_TrayXCrop_Crop]
GO
ALTER TABLE [dbo].[TrayXCrop]  WITH CHECK ADD  CONSTRAINT [FK_TrayXCrop_Tray] FOREIGN KEY([TrayId])
REFERENCES [dbo].[Tray] ([TrayId])
GO
ALTER TABLE [dbo].[TrayXCrop] CHECK CONSTRAINT [FK_TrayXCrop_Tray]
GO
