USE [NdtK22CNTT4Lesson07Db]
GO
/****** Object:  Table [dbo].[NdtKhoa]    Script Date: 6/12/2024 2:52:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NdtKhoa](
	[NdtMaKH] [nchar](10) NOT NULL,
	[NdtTenKH] [nchar](50) NULL,
	[NdtTrangThai] [bit] NULL,
 CONSTRAINT [PK_NdtKhoa] PRIMARY KEY CLUSTERED 
(
	[NdtMaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NdtSinhVien]    Script Date: 6/12/2024 2:52:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NdtSinhVien](
	[NdtMaSv] [nchar](50) NOT NULL,
	[NdtHoSv] [nchar](50) NULL,
	[NdtTenSv] [nchar](50) NULL,
	[NdtNgaySinh] [date] NULL,
	[NdtPhai] [bit] NULL,
	[NdtPhone] [nchar](10) NULL,
	[NdtEmail] [nchar](50) NULL,
	[NdtMaKH] [nchar](10) NULL,
 CONSTRAINT [PK_NdtSinhVien] PRIMARY KEY CLUSTERED 
(
	[NdtMaSv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[NdtKhoa] ([NdtMaKH], [NdtTenKH], [NdtTrangThai]) VALUES (N'K22CNTT4  ', N'K22CNTT4                                          ', 1)
GO
INSERT [dbo].[NdtSinhVien] ([NdtMaSv], [NdtHoSv], [NdtTenSv], [NdtNgaySinh], [NdtPhai], [NdtPhone], [NdtEmail], [NdtMaKH]) VALUES (N'2210900071                                        ', N'Nguyễn Danh                                       ', N'Trường                                            ', CAST(N'2004-02-05' AS Date), 1, N'0797475264', N'truong626215@gmail.com                            ', N'K22CNTT4  ')
GO
