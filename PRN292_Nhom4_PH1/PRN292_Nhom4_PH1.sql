USE [PRN292_Demo4]
GO
/****** Object:  Table [dbo].[CTDT]    Script Date: 10/16/2020 7:08:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTDT](
	[IDMH] [varchar](50) NOT NULL,
	[Ma_Nganh] [varchar](50) NULL,
 CONSTRAINT [PK_CTDT] PRIMARY KEY CLUSTERED 
(
	[IDMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HocKy]    Script Date: 10/16/2020 7:08:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HocKy](
	[Ma_HK] [varchar](50) NOT NULL,
	[Ma_NH] [varchar](50) NULL,
	[Hocky] [varchar](50) NULL,
 CONSTRAINT [PK_HocKy] PRIMARY KEY CLUSTERED 
(
	[Ma_HK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 10/16/2020 7:08:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonHoc](
	[IDMH] [varchar](50) NOT NULL,
	[Ma_HK] [varchar](50) NULL,
	[TenMH] [varchar](50) NULL,
	[SoTC] [int] NOT NULL,
	[LyThuyet] [int] NULL,
	[ThucHanh] [int] NULL,
 CONSTRAINT [PK_MonHoc] PRIMARY KEY CLUSTERED 
(
	[IDMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NamHoc]    Script Date: 10/16/2020 7:08:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NamHoc](
	[Ma_NH] [varchar](50) NOT NULL,
	[Ten_NH] [varchar](50) NULL,
 CONSTRAINT [PK_NamHoc] PRIMARY KEY CLUSTERED 
(
	[Ma_NH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CTDT] ([IDMH], [Ma_Nganh]) VALUES (N'LAB301', N'CE')
INSERT [dbo].[CTDT] ([IDMH], [Ma_Nganh]) VALUES (N'PRN292', N'CE')
INSERT [dbo].[CTDT] ([IDMH], [Ma_Nganh]) VALUES (N'SWT301', N'CE')
GO
INSERT [dbo].[HocKy] ([Ma_HK], [Ma_NH], [Hocky]) VALUES (N'FA20', N'FA2020', N'Fall')
INSERT [dbo].[HocKy] ([Ma_HK], [Ma_NH], [Hocky]) VALUES (N'SP19', N'SP2019', N'Spring')
INSERT [dbo].[HocKy] ([Ma_HK], [Ma_NH], [Hocky]) VALUES (N'SP20', N'SP2020', N'Spring')
GO
INSERT [dbo].[MonHoc] ([IDMH], [Ma_HK], [TenMH], [SoTC], [LyThuyet], [ThucHanh]) VALUES (N'PRN292', N'FA20', N'C#.NET', 1, 1, 1)
INSERT [dbo].[MonHoc] ([IDMH], [Ma_HK], [TenMH], [SoTC], [LyThuyet], [ThucHanh]) VALUES (N'SWE301', N'FA20', N'Software requirement', 2, 3, 0)
INSERT [dbo].[MonHoc] ([IDMH], [Ma_HK], [TenMH], [SoTC], [LyThuyet], [ThucHanh]) VALUES (N'SWR302', N'FA20', N'sf ware', 3, 0, 0)
INSERT [dbo].[MonHoc] ([IDMH], [Ma_HK], [TenMH], [SoTC], [LyThuyet], [ThucHanh]) VALUES (N'SWT301', N'FA20', N'Software testing', 3, 2, 1)
GO
INSERT [dbo].[NamHoc] ([Ma_NH], [Ten_NH]) VALUES (N'FA20', N'Fall')
INSERT [dbo].[NamHoc] ([Ma_NH], [Ten_NH]) VALUES (N'SP20', N'Spring')
GO
