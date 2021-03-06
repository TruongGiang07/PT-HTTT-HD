USE [QLNganHang]
GO
/****** Object:  ForeignKey [FK_PhieuGiaoDich_REF_LoaiGiaoDich]    Script Date: 03/20/2017 22:09:01 ******/
ALTER TABLE [dbo].[PhieuGiaoDich] DROP CONSTRAINT [FK_PhieuGiaoDich_REF_LoaiGiaoDich]
GO
/****** Object:  ForeignKey [FK_PhieuGiaoDich_SoTietKiem]    Script Date: 03/20/2017 22:09:01 ******/
ALTER TABLE [dbo].[PhieuGiaoDich] DROP CONSTRAINT [FK_PhieuGiaoDich_SoTietKiem]
GO
/****** Object:  ForeignKey [FK_PhieuGiaoDich_TaiKhoan]    Script Date: 03/20/2017 22:09:01 ******/
ALTER TABLE [dbo].[PhieuGiaoDich] DROP CONSTRAINT [FK_PhieuGiaoDich_TaiKhoan]
GO
/****** Object:  ForeignKey [FK_SoTietKiem_TaiKhoan]    Script Date: 03/20/2017 22:09:01 ******/
ALTER TABLE [dbo].[SoTietKiem] DROP CONSTRAINT [FK_SoTietKiem_TaiKhoan]
GO
/****** Object:  Table [dbo].[PhieuGiaoDich]    Script Date: 03/20/2017 22:09:01 ******/
ALTER TABLE [dbo].[PhieuGiaoDich] DROP CONSTRAINT [FK_PhieuGiaoDich_REF_LoaiGiaoDich]
GO
ALTER TABLE [dbo].[PhieuGiaoDich] DROP CONSTRAINT [FK_PhieuGiaoDich_SoTietKiem]
GO
ALTER TABLE [dbo].[PhieuGiaoDich] DROP CONSTRAINT [FK_PhieuGiaoDich_TaiKhoan]
GO
DROP TABLE [dbo].[PhieuGiaoDich]
GO
/****** Object:  Table [dbo].[SoTietKiem]    Script Date: 03/20/2017 22:09:01 ******/
ALTER TABLE [dbo].[SoTietKiem] DROP CONSTRAINT [FK_SoTietKiem_TaiKhoan]
GO
DROP TABLE [dbo].[SoTietKiem]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 03/20/2017 22:09:01 ******/
DROP TABLE [dbo].[TaiKhoan]
GO
/****** Object:  Table [dbo].[ThamSo]    Script Date: 03/20/2017 22:09:02 ******/
DROP TABLE [dbo].[ThamSo]
GO
/****** Object:  Table [dbo].[REF_LoaiGiaoDich]    Script Date: 03/20/2017 22:09:01 ******/
DROP TABLE [dbo].[REF_LoaiGiaoDich]
GO
/****** Object:  Table [dbo].[Log_XuLyFile]    Script Date: 03/20/2017 22:09:01 ******/
DROP TABLE [dbo].[Log_XuLyFile]
GO
/****** Object:  Table [dbo].[Log_XuLyFile]    Script Date: 03/20/2017 22:09:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Log_XuLyFile](
	[TenFile] [varchar](50) NULL,
	[TrangThai] [varchar](10) NULL,
	[NgayXuLy] [datetime] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[REF_LoaiGiaoDich]    Script Date: 03/20/2017 22:09:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[REF_LoaiGiaoDich](
	[MaLoaiGiaoDich] [int] NOT NULL,
	[TenLoaiGiaoDich] [varchar](50) NULL,
 CONSTRAINT [PK_REF_LoaiGiaoDich] PRIMARY KEY CLUSTERED 
(
	[MaLoaiGiaoDich] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ThamSo]    Script Date: 03/20/2017 22:09:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ThamSo](
	[TenThamSo] [varchar](50) NULL,
	[GiaTri] [varchar](50) NULL,
	[KieuDuLieu] [varchar](20) NULL,
	[TrangThai] [bit] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 03/20/2017 22:09:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[MaTK] [int] NOT NULL,
	[CMND] [varchar](20) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[NgayLap] [datetime] NULL,
	[LoaiTK] [int] NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[MaTK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SoTietKiem]    Script Date: 03/20/2017 22:09:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SoTietKiem](
	[MaSoTK] [int] NOT NULL,
	[LoaiSoTK] [int] NULL,
	[MaKhachHang] [int] NULL,
	[NgayMoSo] [datetime] NULL,
	[SoTien] [decimal](18, 0) NULL,
 CONSTRAINT [PK_SoTietKiem] PRIMARY KEY CLUSTERED 
(
	[MaSoTK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuGiaoDich]    Script Date: 03/20/2017 22:09:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuGiaoDich](
	[MaPhieuGD] [int] NOT NULL,
	[MaSoTK] [int] NULL,
	[MaKH] [int] NULL,
	[NgayMo] [datetime] NULL,
	[SoTien] [decimal](18, 0) NULL,
	[LoaiGiaoDich] [int] NULL,
 CONSTRAINT [PK_PhieuGiaoDich] PRIMARY KEY CLUSTERED 
(
	[MaPhieuGD] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_PhieuGiaoDich_REF_LoaiGiaoDich]    Script Date: 03/20/2017 22:09:01 ******/
ALTER TABLE [dbo].[PhieuGiaoDich]  WITH CHECK ADD  CONSTRAINT [FK_PhieuGiaoDich_REF_LoaiGiaoDich] FOREIGN KEY([LoaiGiaoDich])
REFERENCES [dbo].[REF_LoaiGiaoDich] ([MaLoaiGiaoDich])
GO
ALTER TABLE [dbo].[PhieuGiaoDich] CHECK CONSTRAINT [FK_PhieuGiaoDich_REF_LoaiGiaoDich]
GO
/****** Object:  ForeignKey [FK_PhieuGiaoDich_SoTietKiem]    Script Date: 03/20/2017 22:09:01 ******/
ALTER TABLE [dbo].[PhieuGiaoDich]  WITH CHECK ADD  CONSTRAINT [FK_PhieuGiaoDich_SoTietKiem] FOREIGN KEY([MaSoTK])
REFERENCES [dbo].[SoTietKiem] ([MaSoTK])
GO
ALTER TABLE [dbo].[PhieuGiaoDich] CHECK CONSTRAINT [FK_PhieuGiaoDich_SoTietKiem]
GO
/****** Object:  ForeignKey [FK_PhieuGiaoDich_TaiKhoan]    Script Date: 03/20/2017 22:09:01 ******/
ALTER TABLE [dbo].[PhieuGiaoDich]  WITH CHECK ADD  CONSTRAINT [FK_PhieuGiaoDich_TaiKhoan] FOREIGN KEY([MaKH])
REFERENCES [dbo].[TaiKhoan] ([MaTK])
GO
ALTER TABLE [dbo].[PhieuGiaoDich] CHECK CONSTRAINT [FK_PhieuGiaoDich_TaiKhoan]
GO
/****** Object:  ForeignKey [FK_SoTietKiem_TaiKhoan]    Script Date: 03/20/2017 22:09:01 ******/
ALTER TABLE [dbo].[SoTietKiem]  WITH CHECK ADD  CONSTRAINT [FK_SoTietKiem_TaiKhoan] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[TaiKhoan] ([MaTK])
GO
ALTER TABLE [dbo].[SoTietKiem] CHECK CONSTRAINT [FK_SoTietKiem_TaiKhoan]
GO
