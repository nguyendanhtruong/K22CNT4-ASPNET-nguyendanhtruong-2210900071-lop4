USE [qlsinhvien]
GO
/****** Object:  Table [dbo].[ketqua]    Script Date: 6/26/2024 4:02:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ketqua](
	[MaSV] [int] NOT NULL,
	[MaMH] [int] NOT NULL,
	[Diem] [decimal](18, 0) NULL,
 CONSTRAINT [PK_ketqua] PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[khoa]    Script Date: 6/26/2024 4:02:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[khoa](
	[MaKhoa] [int] NOT NULL,
	[TenKhoa] [nchar](10) NULL,
 CONSTRAINT [PK_khoa] PRIMARY KEY CLUSTERED 
(
	[MaKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Monhoc]    Script Date: 6/26/2024 4:02:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Monhoc](
	[MaMH] [int] NOT NULL,
	[TenMH] [nvarchar](50) NULL,
	[SoTiet] [int] NULL,
 CONSTRAINT [PK_Monhoc] PRIMARY KEY CLUSTERED 
(
	[MaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 6/26/2024 4:02:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[MaSv] [int] NOT NULL,
	[HoSV] [varchar](50) NULL,
	[TenSV] [varchar](50) NULL,
	[Phai] [varchar](50) NULL,
	[NgaySinh] [date] NULL,
	[NoiSinh] [nchar](10) NULL,
	[MaKh] [int] NULL,
	[HocBong] [decimal](10, 2) NULL,
	[DiemTrungBinh] [decimal](3, 2) NULL,
 CONSTRAINT [PK_SinhVien] PRIMARY KEY CLUSTERED 
(
	[MaSv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ketqua]  WITH CHECK ADD  CONSTRAINT [FK_ketqua_MaMH] FOREIGN KEY([MaMH])
REFERENCES [dbo].[Monhoc] ([MaMH])
GO
ALTER TABLE [dbo].[ketqua] CHECK CONSTRAINT [FK_ketqua_MaMH]
GO
