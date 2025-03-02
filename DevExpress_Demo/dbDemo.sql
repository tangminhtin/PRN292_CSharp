USE [dbDemo]
GO
/****** Object:  Table [dbo].[tbDemo]    Script Date: 10/21/2020 8:34:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbDemo](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[uName] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SoDienThoai] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbDemo] ON 

INSERT [dbo].[tbDemo] ([ID], [uName], [DiaChi], [SoDienThoai]) VALUES (1, N'minhtin', N'Tien Giang', N'0394328223')
INSERT [dbo].[tbDemo] ([ID], [uName], [DiaChi], [SoDienThoai]) VALUES (2, N'vinh', N'Can Tho', N'0393485768')
INSERT [dbo].[tbDemo] ([ID], [uName], [DiaChi], [SoDienThoai]) VALUES (3, N'hao', N'Ben Tre', N'0245667893')
INSERT [dbo].[tbDemo] ([ID], [uName], [DiaChi], [SoDienThoai]) VALUES (4, N'tu', N'An Giang', N'0286573829')
INSERT [dbo].[tbDemo] ([ID], [uName], [DiaChi], [SoDienThoai]) VALUES (5, N'nhien', N'Hau Giang', N'0349634758')
SET IDENTITY_INSERT [dbo].[tbDemo] OFF
GO
