CREATE DATABASE [QL_NGAN_HANG]
GO

USE [QL_NGAN_HANG]
GO
ALTER TABLE [dbo].[SoTietKiem] DROP CONSTRAINT [FK_SoTietKiem_KhachHang]
GO
ALTER TABLE [dbo].[NhanVien] DROP CONSTRAINT [FK_NhanVien_ChiNhanh]
GO
ALTER TABLE [dbo].[KhachHang] DROP CONSTRAINT [FK_KhachHang_ChiNhanh]
GO
ALTER TABLE [dbo].[GiaoDichChuyenTien] DROP CONSTRAINT [FK_GiaoDichChuyenTien_NhanVien]
GO
ALTER TABLE [dbo].[GiaoDichChuyenTien] DROP CONSTRAINT [FK_GiaoDichChuyenTien_KhachHang1]
GO
ALTER TABLE [dbo].[GiaoDichChuyenTien] DROP CONSTRAINT [FK_GiaoDichChuyenTien_KhachHang]
GO
ALTER TABLE [dbo].[GiaoDich] DROP CONSTRAINT [FK_GiaoDich_NhanVien]
GO
ALTER TABLE [dbo].[GiaoDich] DROP CONSTRAINT [FK_GiaoDich_KhachHang]
GO
ALTER TABLE [dbo].[ChiNhanh] DROP CONSTRAINT [FK_ChiNhanh_TruSo]
GO
/****** Object:  Table [dbo].[TruSo]    Script Date: 4/15/2017 11:06:46 PM ******/
DROP TABLE [dbo].[TruSo]
GO
/****** Object:  Table [dbo].[TongKetGiaoDich]    Script Date: 4/15/2017 11:06:46 PM ******/
DROP TABLE [dbo].[TongKetGiaoDich]
GO
/****** Object:  Table [dbo].[SoTietKiem]    Script Date: 4/15/2017 11:06:46 PM ******/
DROP TABLE [dbo].[SoTietKiem]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 4/15/2017 11:06:46 PM ******/
DROP TABLE [dbo].[NhanVien]
GO
/****** Object:  Table [dbo].[LOG_XuLyFile]    Script Date: 4/15/2017 11:06:46 PM ******/
DROP TABLE [dbo].[LOG_XuLyFile]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 4/15/2017 11:06:46 PM ******/
DROP TABLE [dbo].[KhachHang]
GO
/****** Object:  Table [dbo].[GiaoDichChuyenTien]    Script Date: 4/15/2017 11:06:46 PM ******/
DROP TABLE [dbo].[GiaoDichChuyenTien]
GO
/****** Object:  Table [dbo].[GiaoDich]    Script Date: 4/15/2017 11:06:46 PM ******/
DROP TABLE [dbo].[GiaoDich]
GO
/****** Object:  Table [dbo].[ChiNhanh]    Script Date: 4/15/2017 11:06:46 PM ******/
DROP TABLE [dbo].[ChiNhanh]
GO
/****** Object:  Table [dbo].[ChiNhanh]    Script Date: 4/15/2017 11:06:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiNhanh](
	[MaChiNhanh] [int] IDENTITY(1,1) NOT NULL,
	[TenChiNhanh] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[SoDT] [varchar](20) NULL,
	[MaTruSoTrucThuoc] [int] NULL,
 CONSTRAINT [PK_ChiNhanh] PRIMARY KEY CLUSTERED 
(
	[MaChiNhanh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GiaoDich]    Script Date: 4/15/2017 11:06:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiaoDich](
	[MaGiaoDich] [int] IDENTITY(1,1) NOT NULL,
	[SoTienGiaoDich] [decimal](18, 0) NULL,
	[NgayGiaoDich] [datetime] NULL,
	[MaKHGiaoDich] [int] NULL,
	[MaGDVien] [int] NULL,
	[LoaiGD] [tinyint] NULL,
 CONSTRAINT [PK_GiaoDich] PRIMARY KEY CLUSTERED 
(
	[MaGiaoDich] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GiaoDichChuyenTien]    Script Date: 4/15/2017 11:06:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiaoDichChuyenTien](
	[MaGD] [int] IDENTITY(1,1) NOT NULL,
	[SoTienChuyen] [decimal](18, 0) NULL,
	[NgayChuyen] [datetime] NULL,
	[NoiDung] [nvarchar](100) NULL,
	[MaKHChuyen] [int] NULL,
	[MaKHNhan] [int] NULL,
	[MaGDVien] [int] NULL,
 CONSTRAINT [PK_GiaoDichChuyenTien] PRIMARY KEY CLUSTERED 
(
	[MaGD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 4/15/2017 11:06:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKhachHang] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](70) NULL,
	[SoDuTaiKhoan] [decimal](18, 0) NOT NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [bit] NULL,
	[DiaChiThuongTru] [nvarchar](250) NULL,
	[DiaChiLienLac] [nvarchar](250) NULL,
	[SoCMND] [varchar](20) NULL,
	[DienThoai] [varchar](20) NULL,
	[Email] [varchar](50) NULL,
	[TinhTrangHonNhan] [bit] NULL,
	[NgayLap] [datetime] NULL,
	[TinhTrangHoatDong] [bit] NULL,
	[MaCNDangky] [int] NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOG_XuLyFile]    Script Date: 4/15/2017 11:06:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LOG_XuLyFile](
	[MaXL] [int] IDENTITY(1,1) NOT NULL,
	[TenFile] [varchar](100) NULL,
	[NgayXuLy] [datetime] NULL,
	[TinhTrang] [tinyint] NULL,
	[ThongTinLoi] [varchar](250) NULL,
 CONSTRAINT [PK_LOG_XuLyFile] PRIMARY KEY CLUSTERED 
(
	[MaXL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 4/15/2017 11:06:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [int] IDENTITY(1,1) NOT NULL,
	[TenDangNhap] [varchar](30) NULL,
	[MatKhau] [varchar](30) NULL,
	[HoTen] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [bit] NULL,
	[DiaChi] [nvarchar](100) NULL,
	[SDT] [varchar](20) NULL,
	[MaCNLamViec] [int] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SoTietKiem]    Script Date: 4/15/2017 11:06:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SoTietKiem](
	[MaSoTietKiem] [int] IDENTITY(1,1) NOT NULL,
	[SoTienGui] [decimal](18, 0) NULL,
	[NgayGui] [datetime] NULL,
	[NgayDaoHan] [date] NULL,
	[KyHan] [int] NULL,
	[LaiSuat] [float] NULL,
	[MaKHGui] [int] NULL,
	[TinhTrang] [tinyint] NULL,
 CONSTRAINT [PK_SoTietKiem] PRIMARY KEY CLUSTERED 
(
	[MaSoTietKiem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TongKetGiaoDich]    Script Date: 4/15/2017 11:06:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TongKetGiaoDich](
	[NgayGiaoDich] [date] NULL,
	[ChiNhanh] [int] NULL,
	[TruSo] [int] NULL,
	[SL_GD_RutTien] [int] NULL,
	[SoTien_GD_RutTien] [decimal](18, 0) NULL,
	[SL_GD_GuiTien] [int] NULL,
	[SoTien_GD_GuiTien] [decimal](18, 0) NULL,
	[SL_GD_ChuyenTien] [int] NULL,
	[SoTien_GD_ChuyenTien] [decimal](18, 0) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TruSo]    Script Date: 4/15/2017 11:06:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TruSo](
	[MaTruSo] [int] IDENTITY(1,1) NOT NULL,
	[TenTruSo] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[SoDT] [varchar](20) NULL,
 CONSTRAINT [PK_TruSo] PRIMARY KEY CLUSTERED 
(
	[MaTruSo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[ChiNhanh]  WITH CHECK ADD  CONSTRAINT [FK_ChiNhanh_TruSo] FOREIGN KEY([MaTruSoTrucThuoc])
REFERENCES [dbo].[TruSo] ([MaTruSo])
GO
ALTER TABLE [dbo].[ChiNhanh] CHECK CONSTRAINT [FK_ChiNhanh_TruSo]
GO
ALTER TABLE [dbo].[GiaoDich]  WITH CHECK ADD  CONSTRAINT [FK_GiaoDich_KhachHang] FOREIGN KEY([MaKHGiaoDich])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[GiaoDich] CHECK CONSTRAINT [FK_GiaoDich_KhachHang]
GO
ALTER TABLE [dbo].[GiaoDich]  WITH CHECK ADD  CONSTRAINT [FK_GiaoDich_NhanVien] FOREIGN KEY([MaGDVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[GiaoDich] CHECK CONSTRAINT [FK_GiaoDich_NhanVien]
GO
ALTER TABLE [dbo].[GiaoDichChuyenTien]  WITH CHECK ADD  CONSTRAINT [FK_GiaoDichChuyenTien_KhachHang] FOREIGN KEY([MaKHChuyen])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[GiaoDichChuyenTien] CHECK CONSTRAINT [FK_GiaoDichChuyenTien_KhachHang]
GO
ALTER TABLE [dbo].[GiaoDichChuyenTien]  WITH CHECK ADD  CONSTRAINT [FK_GiaoDichChuyenTien_KhachHang1] FOREIGN KEY([MaKHNhan])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[GiaoDichChuyenTien] CHECK CONSTRAINT [FK_GiaoDichChuyenTien_KhachHang1]
GO
ALTER TABLE [dbo].[GiaoDichChuyenTien]  WITH CHECK ADD  CONSTRAINT [FK_GiaoDichChuyenTien_NhanVien] FOREIGN KEY([MaGDVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[GiaoDichChuyenTien] CHECK CONSTRAINT [FK_GiaoDichChuyenTien_NhanVien]
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [FK_KhachHang_ChiNhanh] FOREIGN KEY([MaCNDangky])
REFERENCES [dbo].[ChiNhanh] ([MaChiNhanh])
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [FK_KhachHang_ChiNhanh]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_ChiNhanh] FOREIGN KEY([MaCNLamViec])
REFERENCES [dbo].[ChiNhanh] ([MaChiNhanh])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_ChiNhanh]
GO
ALTER TABLE [dbo].[SoTietKiem]  WITH CHECK ADD  CONSTRAINT [FK_SoTietKiem_KhachHang] FOREIGN KEY([MaKHGui])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[SoTietKiem] CHECK CONSTRAINT [FK_SoTietKiem_KhachHang]
GO
