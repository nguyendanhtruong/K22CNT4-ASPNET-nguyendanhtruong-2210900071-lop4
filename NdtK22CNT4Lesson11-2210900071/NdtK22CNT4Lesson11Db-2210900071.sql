USE [NdtK22CNT4Lesson11Db]
GO
/****** Object:  Table [dbo].[NdtCategory]    Script Date: 7/4/2024 10:05:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NdtCategory](
	[NdtID] [int] IDENTITY(1,1) NOT NULL,
	[NdtCateName] [nvarchar](50) NULL,
	[NdtStatus] [bit] NULL,
 CONSTRAINT [PK_NdtCategory] PRIMARY KEY CLUSTERED 
(
	[NdtID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NdtProduct]    Script Date: 7/4/2024 10:05:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NdtProduct](
	[Ndtid2210900071] [int] NOT NULL,
	[NdtProName] [nvarchar](50) NULL,
	[NdtQty] [int] NULL,
	[NdtPrice] [float] NULL,
	[NdtCateId] [int] NULL,
	[NdtActive] [bit] NULL,
 CONSTRAINT [PK_NdtProduct] PRIMARY KEY CLUSTERED 
(
	[Ndtid2210900071] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[NdtCategory] ON 

INSERT [dbo].[NdtCategory] ([NdtID], [NdtCateName], [NdtStatus]) VALUES (1, N'2210900071', 1)
INSERT [dbo].[NdtCategory] ([NdtID], [NdtCateName], [NdtStatus]) VALUES (2, N'iphone', 0)
SET IDENTITY_INSERT [dbo].[NdtCategory] OFF
GO
INSERT [dbo].[NdtProduct] ([Ndtid2210900071], [NdtProName], [NdtQty], [NdtPrice], [NdtCateId], [NdtActive]) VALUES (221090071, N'Nguyễn Danh Trường', 10, 1000, 1, 1)
GO
