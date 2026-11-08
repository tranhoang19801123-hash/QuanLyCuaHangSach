USE [master]
GO

IF DB_ID(N'QuanLyCuaHangSach') IS NULL
BEGIN
    CREATE DATABASE [QuanLyCuaHangSach];
END
GO

USE [QuanLyCuaHangSach]
GO

/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 07/11/2026 9:28:15 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaHD] [varchar](20) NOT NULL,
	[MaSP] [varchar](20) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[DonGia] [decimal](18, 2) NOT NULL,
	[ThanhTien] [decimal](18, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietPhieuNhap]    Script Date: 07/11/2026 9:28:15 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuNhap](
	[MaPN] [varchar](20) NOT NULL,
	[MaSP] [varchar](20) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[GiaNhap] [decimal](18, 0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChucNang]    Script Date: 07/11/2026 9:28:15 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucNang](
	[MaChucNang] [varchar](50) NOT NULL,
	[TenChucNang] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChucNang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HangThanhVien]    Script Date: 07/11/2026 9:28:15 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HangThanhVien](
	[MaHang] [varchar](20) NOT NULL,
	[TenHang] [nvarchar](50) NOT NULL,
	[PhanTramGiam] [real] NOT NULL,
	[DiemToiThieu] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 07/11/2026 9:28:15 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [varchar](20) NOT NULL,
	[NgayLap] [datetime] NULL,
	[MaKH] [varchar](20) NULL,
	[MaNV] [varchar](20) NULL,
	[TongTien] [decimal](18, 2) NULL,
	[GiamGia] [decimal](18, 2) NULL,
	[ThanhTien] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 07/11/2026 9:28:15 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [varchar](20) NOT NULL,
	[HoTen] [nvarchar](100) NOT NULL,
	[DienThoai] [varchar](15) NULL,
	[DiemTichLuy] [int] NULL,
	[HangThanhVien] [nvarchar](50) NULL,
	[MaHang] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 07/11/2026 9:28:15 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiDung](
	[TenDangNhap] [varchar](50) NOT NULL,
	[MatKhau] [varchar](255) NOT NULL,
	[Salt] [varchar](100) NOT NULL,
	[HoTen] [nvarchar](100) NOT NULL,
	[Email] [varchar](100) NULL,
	[MaQuyen] [int] NULL,
	[TrangThai] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 07/11/2026 9:28:15 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] [varchar](20) NOT NULL,
	[TenNCC] [nvarchar](150) NOT NULL,
	[DienThoai] [varchar](15) NULL,
	[DiaChi] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 07/11/2026 9:28:15 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [varchar](20) NOT NULL,
	[HoTen] [nvarchar](100) NOT NULL,
	[DienThoai] [varchar](15) NULL,
	[Email] [varchar](100) NULL,
	[DiaChi] [nvarchar](255) NULL,
	[TenDangNhap] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhanQuyen]    Script Date: 07/11/2026 9:28:15 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanQuyen](
	[MaQuyen] [int] IDENTITY(1,1) NOT NULL,
	[TenQuyen] [nvarchar](50) NOT NULL,
	[MoTa] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaQuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhanQuyen_ChucNang]    Script Date: 07/11/2026 9:28:15 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanQuyen_ChucNang](
	[MaQuyen] [int] NOT NULL,
	[MaChucNang] [varchar](50) NOT NULL,
	[CoQuyen] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaQuyen] ASC,
	[MaChucNang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 07/11/2026 9:28:15 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[MaPN] [varchar](20) NOT NULL,
	[NgayNhap] [datetime] NOT NULL,
	[MaNCC] [varchar](20) NOT NULL,
	[MaNV] [varchar](20) NOT NULL,
	[TongTien] [decimal](18, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 07/11/2026 9:28:15 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [varchar](20) NOT NULL,
	[TenSP] [nvarchar](150) NOT NULL,
	[TheLoai] [nvarchar](50) NULL,
	[TacGia] [nvarchar](100) NULL,
	[GiaNhap] [decimal](18, 2) NULL,
	[GiaBan] [decimal](18, 2) NULL,
	[SoLuongTon] [int] NULL,
	[MaNCC] [varchar](20) NULL,
	[MaTL] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TheLoai]    Script Date: 07/11/2026 9:28:15 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TheLoai](
	[MaTL] [varchar](20) NOT NULL,
	[TenTL] [nvarchar](100) NOT NULL,
	[MoTa] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD20261104001', N'S005', 10, CAST(86000.00 AS Decimal(18, 2)), CAST(860000.00 AS Decimal(18, 2)))
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD20261104001', N'S008', 20, CAST(98000.00 AS Decimal(18, 2)), CAST(1960000.00 AS Decimal(18, 2)))
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD20261104002', N'S007', 5, CAST(310000.00 AS Decimal(18, 2)), CAST(1550000.00 AS Decimal(18, 2)))
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD20261104003', N'S007', 4, CAST(310000.00 AS Decimal(18, 2)), CAST(1240000.00 AS Decimal(18, 2)))
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD20261104003', N'S008', 3, CAST(98000.00 AS Decimal(18, 2)), CAST(294000.00 AS Decimal(18, 2)))
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD20261105001', N'S008', 7, CAST(98000.00 AS Decimal(18, 2)), CAST(686000.00 AS Decimal(18, 2)))
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD20261105002', N'S008', 7, CAST(98000.00 AS Decimal(18, 2)), CAST(686000.00 AS Decimal(18, 2)))
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD20261105003', N'S001', 11, CAST(62000.00 AS Decimal(18, 2)), CAST(682000.00 AS Decimal(18, 2)))
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD20261105004', N'S010', 10, CAST(22000.00 AS Decimal(18, 2)), CAST(220000.00 AS Decimal(18, 2)))
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD20261105005', N'S010', 8, CAST(22000.00 AS Decimal(18, 2)), CAST(176000.00 AS Decimal(18, 2)))
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD20261105006', N'S004', 1, CAST(79000.00 AS Decimal(18, 2)), CAST(79000.00 AS Decimal(18, 2)))
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD20261105006', N'S006', 1, CAST(189000.00 AS Decimal(18, 2)), CAST(189000.00 AS Decimal(18, 2)))
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD20261105006', N'S010', 9, CAST(22000.00 AS Decimal(18, 2)), CAST(198000.00 AS Decimal(18, 2)))
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD20261105007', N'S005', 6, CAST(86000.00 AS Decimal(18, 2)), CAST(516000.00 AS Decimal(18, 2)))
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD20261105008', N'S002', 10, CAST(75000.00 AS Decimal(18, 2)), CAST(750000.00 AS Decimal(18, 2)))
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD20261105009', N'S008', 2, CAST(98000.00 AS Decimal(18, 2)), CAST(196000.00 AS Decimal(18, 2)))
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD20261105010', N'S005', 5, CAST(86000.00 AS Decimal(18, 2)), CAST(430000.00 AS Decimal(18, 2)))
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD20261105011', N'S005', 1, CAST(86000.00 AS Decimal(18, 2)), CAST(86000.00 AS Decimal(18, 2)))
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD20261105012', N'S001', 1, CAST(62000.00 AS Decimal(18, 2)), CAST(62000.00 AS Decimal(18, 2)))
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD20261105013', N'S001', 1, CAST(62000.00 AS Decimal(18, 2)), CAST(62000.00 AS Decimal(18, 2)))
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD20261105013', N'S005', 2, CAST(86000.00 AS Decimal(18, 2)), CAST(172000.00 AS Decimal(18, 2)))
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD20261105014', N'S005', 1, CAST(86000.00 AS Decimal(18, 2)), CAST(86000.00 AS Decimal(18, 2)))
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD20261106001', N'S005', 1, CAST(86000.00 AS Decimal(18, 2)), CAST(86000.00 AS Decimal(18, 2)))
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HD20261106002', N'S001', 1, CAST(62000.00 AS Decimal(18, 2)), CAST(62000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [GiaNhap]) VALUES (N'PN20261104001', N'S008', 3, CAST(70000 AS Decimal(18, 0)))
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaSP], [SoLuong], [GiaNhap]) VALUES (N'PN20261104002', N'S008', 1, CAST(70000 AS Decimal(18, 0)))
GO
INSERT [dbo].[ChucNang] ([MaChucNang], [TenChucNang]) VALUES (N'BAN_HANG', N'Bán hàng')
INSERT [dbo].[ChucNang] ([MaChucNang], [TenChucNang]) VALUES (N'BAO_CAO', N'Báo cáo thống kê')
INSERT [dbo].[ChucNang] ([MaChucNang], [TenChucNang]) VALUES (N'DM_KHACHHANG', N'Quản lý khách hàng')
INSERT [dbo].[ChucNang] ([MaChucNang], [TenChucNang]) VALUES (N'DM_NCC', N'Quản lý nhà cung cấp')
INSERT [dbo].[ChucNang] ([MaChucNang], [TenChucNang]) VALUES (N'DM_NHANVIEN', N'Quản lý nhân viên')
INSERT [dbo].[ChucNang] ([MaChucNang], [TenChucNang]) VALUES (N'DM_SACH', N'Quản lý sách')
INSERT [dbo].[ChucNang] ([MaChucNang], [TenChucNang]) VALUES (N'DM_THELOAI', N'Quản lý thể loại')
INSERT [dbo].[ChucNang] ([MaChucNang], [TenChucNang]) VALUES (N'DS_HOADON', N'Tra cứu hóa đơn')
INSERT [dbo].[ChucNang] ([MaChucNang], [TenChucNang]) VALUES (N'HT_NGUOIDUNG', N'Quản lý người dùng')
INSERT [dbo].[ChucNang] ([MaChucNang], [TenChucNang]) VALUES (N'HT_PHANQUYEN', N'Phân quyền')
INSERT [dbo].[ChucNang] ([MaChucNang], [TenChucNang]) VALUES (N'NHAP_HANG', N'Nhập hàng')
GO
INSERT [dbo].[HangThanhVien] ([MaHang], [TenHang], [PhanTramGiam], [DiemToiThieu]) VALUES (N'H01', N'Thành viên', 0, 0)
INSERT [dbo].[HangThanhVien] ([MaHang], [TenHang], [PhanTramGiam], [DiemToiThieu]) VALUES (N'H02', N'Bạc', 3, 200)
INSERT [dbo].[HangThanhVien] ([MaHang], [TenHang], [PhanTramGiam], [DiemToiThieu]) VALUES (N'H03', N'Vàng', 5, 500)
INSERT [dbo].[HangThanhVien] ([MaHang], [TenHang], [PhanTramGiam], [DiemToiThieu]) VALUES (N'H04', N'Kim cương', 10, 1000)
GO
INSERT [dbo].[HoaDon] ([MaHD], [NgayLap], [MaKH], [MaNV], [TongTien], [GiamGia], [ThanhTien]) VALUES (N'HD20261104001', CAST(N'2026-11-04T07:15:49.773' AS DateTime), NULL, N'NV001', CAST(2820000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(2820000.00 AS Decimal(18, 2)))
INSERT [dbo].[HoaDon] ([MaHD], [NgayLap], [MaKH], [MaNV], [TongTien], [GiamGia], [ThanhTien]) VALUES (N'HD20261104002', CAST(N'2026-11-04T08:39:04.443' AS DateTime), NULL, N'NV001', CAST(1550000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(1550000.00 AS Decimal(18, 2)))
INSERT [dbo].[HoaDon] ([MaHD], [NgayLap], [MaKH], [MaNV], [TongTien], [GiamGia], [ThanhTien]) VALUES (N'HD20261104003', CAST(N'2026-11-04T09:36:05.810' AS DateTime), N'KH004', N'NV001', CAST(1534000.00 AS Decimal(18, 2)), CAST(153400.00 AS Decimal(18, 2)), CAST(1380600.00 AS Decimal(18, 2)))
INSERT [dbo].[HoaDon] ([MaHD], [NgayLap], [MaKH], [MaNV], [TongTien], [GiamGia], [ThanhTien]) VALUES (N'HD20261105001', CAST(N'2026-11-05T13:29:24.720' AS DateTime), NULL, N'NV001', CAST(686000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(686000.00 AS Decimal(18, 2)))
INSERT [dbo].[HoaDon] ([MaHD], [NgayLap], [MaKH], [MaNV], [TongTien], [GiamGia], [ThanhTien]) VALUES (N'HD20261105002', CAST(N'2026-11-05T13:29:44.990' AS DateTime), NULL, N'NV001', CAST(686000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(686000.00 AS Decimal(18, 2)))
INSERT [dbo].[HoaDon] ([MaHD], [NgayLap], [MaKH], [MaNV], [TongTien], [GiamGia], [ThanhTien]) VALUES (N'HD20261105003', CAST(N'2026-11-05T13:31:59.467' AS DateTime), NULL, N'NV001', CAST(682000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(682000.00 AS Decimal(18, 2)))
INSERT [dbo].[HoaDon] ([MaHD], [NgayLap], [MaKH], [MaNV], [TongTien], [GiamGia], [ThanhTien]) VALUES (N'HD20261105004', CAST(N'2026-11-05T16:47:23.447' AS DateTime), NULL, N'NV001', CAST(220000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(220000.00 AS Decimal(18, 2)))
INSERT [dbo].[HoaDon] ([MaHD], [NgayLap], [MaKH], [MaNV], [TongTien], [GiamGia], [ThanhTien]) VALUES (N'HD20261105005', CAST(N'2026-11-05T17:36:28.443' AS DateTime), NULL, N'NV001', CAST(176000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(176000.00 AS Decimal(18, 2)))
INSERT [dbo].[HoaDon] ([MaHD], [NgayLap], [MaKH], [MaNV], [TongTien], [GiamGia], [ThanhTien]) VALUES (N'HD20261105006', CAST(N'2026-11-05T17:46:23.787' AS DateTime), NULL, N'NV001', CAST(466000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(466000.00 AS Decimal(18, 2)))
INSERT [dbo].[HoaDon] ([MaHD], [NgayLap], [MaKH], [MaNV], [TongTien], [GiamGia], [ThanhTien]) VALUES (N'HD20261105007', CAST(N'2026-11-05T17:48:06.387' AS DateTime), NULL, N'NV001', CAST(516000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(516000.00 AS Decimal(18, 2)))
INSERT [dbo].[HoaDon] ([MaHD], [NgayLap], [MaKH], [MaNV], [TongTien], [GiamGia], [ThanhTien]) VALUES (N'HD20261105008', CAST(N'2026-11-05T17:59:36.107' AS DateTime), NULL, N'NV001', CAST(750000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(750000.00 AS Decimal(18, 2)))
INSERT [dbo].[HoaDon] ([MaHD], [NgayLap], [MaKH], [MaNV], [TongTien], [GiamGia], [ThanhTien]) VALUES (N'HD20261105009', CAST(N'2026-11-05T18:04:35.053' AS DateTime), NULL, N'NV001', CAST(196000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(196000.00 AS Decimal(18, 2)))
INSERT [dbo].[HoaDon] ([MaHD], [NgayLap], [MaKH], [MaNV], [TongTien], [GiamGia], [ThanhTien]) VALUES (N'HD20261105010', CAST(N'2026-11-05T18:58:29.477' AS DateTime), NULL, N'NV001', CAST(430000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(430000.00 AS Decimal(18, 2)))
INSERT [dbo].[HoaDon] ([MaHD], [NgayLap], [MaKH], [MaNV], [TongTien], [GiamGia], [ThanhTien]) VALUES (N'HD20261105011', CAST(N'2026-11-05T19:01:43.617' AS DateTime), NULL, N'NV001', CAST(86000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(86000.00 AS Decimal(18, 2)))
INSERT [dbo].[HoaDon] ([MaHD], [NgayLap], [MaKH], [MaNV], [TongTien], [GiamGia], [ThanhTien]) VALUES (N'HD20261105012', CAST(N'2026-11-05T19:10:48.673' AS DateTime), NULL, N'NV001', CAST(62000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(62000.00 AS Decimal(18, 2)))
INSERT [dbo].[HoaDon] ([MaHD], [NgayLap], [MaKH], [MaNV], [TongTien], [GiamGia], [ThanhTien]) VALUES (N'HD20261105013', CAST(N'2026-11-05T19:18:27.000' AS DateTime), N'KH004', N'NV001', CAST(234000.00 AS Decimal(18, 2)), CAST(23400.00 AS Decimal(18, 2)), CAST(210600.00 AS Decimal(18, 2)))
INSERT [dbo].[HoaDon] ([MaHD], [NgayLap], [MaKH], [MaNV], [TongTien], [GiamGia], [ThanhTien]) VALUES (N'HD20261105014', CAST(N'2026-11-05T19:28:51.207' AS DateTime), N'KH003', N'NV001', CAST(86000.00 AS Decimal(18, 2)), CAST(4300.00 AS Decimal(18, 2)), CAST(81700.00 AS Decimal(18, 2)))
INSERT [dbo].[HoaDon] ([MaHD], [NgayLap], [MaKH], [MaNV], [TongTien], [GiamGia], [ThanhTien]) VALUES (N'HD20261106001', CAST(N'2026-11-06T17:53:20.730' AS DateTime), NULL, N'NV001', CAST(86000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(86000.00 AS Decimal(18, 2)))
INSERT [dbo].[HoaDon] ([MaHD], [NgayLap], [MaKH], [MaNV], [TongTien], [GiamGia], [ThanhTien]) VALUES (N'HD20261106002', CAST(N'2026-11-06T17:53:40.327' AS DateTime), NULL, N'NV001', CAST(62000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(62000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [DienThoai], [DiemTichLuy], [HangThanhVien], [MaHang]) VALUES (N'KH001', N'Nguyễn Văn An', N'0901234567', 120, N'Thành viên', N'H01')
INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [DienThoai], [DiemTichLuy], [HangThanhVien], [MaHang]) VALUES (N'KH002', N'Trần Thị Bình', N'0912345678', 260, N'Bạc', N'H02')
INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [DienThoai], [DiemTichLuy], [HangThanhVien], [MaHang]) VALUES (N'KH003', N'Lê Hoàng Cường', N'0987654321', 658, N'Vàng', N'H03')
INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [DienThoai], [DiemTichLuy], [HangThanhVien], [MaHang]) VALUES (N'KH004', N'Phạm Minh Dũng', N'0933333333', 1359, N'Kim cương', N'H04')
INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [DienThoai], [DiemTichLuy], [HangThanhVien], [MaHang]) VALUES (N'KH005', N'Võ Thu Hà', N'0944444444', 0, N'Thành viên', N'H01')
GO
INSERT [dbo].[NguoiDung] ([TenDangNhap], [MatKhau], [Salt], [HoTen], [Email], [MaQuyen], [TrangThai]) VALUES (N'admin', N'9Owf1t1JExqFQB6AFaSXSeAEjS8G9rqHYNn3oxppmwE=', N'Qm9va1N0b3JlU2FsdC0wMQ==', N'Quản Trị Viên', N'admin@bookstore.com', 4, 1)
INSERT [dbo].[NguoiDung] ([TenDangNhap], [MatKhau], [Salt], [HoTen], [Email], [MaQuyen], [TrangThai]) VALUES (N'nhanvien', N'/OePO9742KmFnFMcHxYfVUSLtMcVIRvxVSWy0JrBNc4=', N'NhanVien2026Salt', N'Nhân viên', N'nhanvien@gmail.com', 3, 1)
GO
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DienThoai], [DiaChi]) VALUES (N'NCC01', N'NXB Trẻ', N'02839316289', N'161B Lý Chính Thắng, Quận 3, TP.HCM')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DienThoai], [DiaChi]) VALUES (N'NCC02', N'NXB Kim Đồng', N'02439434730', N'55 Quang Trung, Hai Bà Trưng, Hà Nội')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DienThoai], [DiaChi]) VALUES (N'NCC03', N'Nhã Nam', N'02435146876', N'59 Đỗ Quang, Cầu Giấy, Hà Nội')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DienThoai], [DiaChi]) VALUES (N'NCC04', N'Fahasa', N'19006656', N'60-62 Lê Lợi, Quận 1, TP.HCM')
GO
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [DienThoai], [Email], [DiaChi], [TenDangNhap]) VALUES (N'NV001', N'Đặng Quốc Huy', N'0905111222', N'huy@bookstore.vn', N'Quận 1, TP.HCM', N'admin')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [DienThoai], [Email], [DiaChi], [TenDangNhap]) VALUES (N'NV002', N'Ngô Thanh Mai', N'0905333444', N'mai@bookstore.vn', N'Quận 7, TP.HCM', N'nhanvien')
GO
SET IDENTITY_INSERT [dbo].[PhanQuyen] ON 

INSERT [dbo].[PhanQuyen] ([MaQuyen], [TenQuyen], [MoTa]) VALUES (3, N'Nhân viên bán hàng', N'Bán hàng, hóa đơn')
INSERT [dbo].[PhanQuyen] ([MaQuyen], [TenQuyen], [MoTa]) VALUES (4, N'Quản trị viên', N'Toàn quyền hệ thống')
SET IDENTITY_INSERT [dbo].[PhanQuyen] OFF
GO
INSERT [dbo].[PhanQuyen_ChucNang] ([MaQuyen], [MaChucNang], [CoQuyen]) VALUES (3, N'BAN_HANG', 1)
INSERT [dbo].[PhanQuyen_ChucNang] ([MaQuyen], [MaChucNang], [CoQuyen]) VALUES (3, N'DM_KHACHHANG', 1)
INSERT [dbo].[PhanQuyen_ChucNang] ([MaQuyen], [MaChucNang], [CoQuyen]) VALUES (3, N'DM_SACH', 1)
INSERT [dbo].[PhanQuyen_ChucNang] ([MaQuyen], [MaChucNang], [CoQuyen]) VALUES (3, N'DS_HOADON', 1)
INSERT [dbo].[PhanQuyen_ChucNang] ([MaQuyen], [MaChucNang], [CoQuyen]) VALUES (4, N'BAN_HANG', 1)
INSERT [dbo].[PhanQuyen_ChucNang] ([MaQuyen], [MaChucNang], [CoQuyen]) VALUES (4, N'BAO_CAO', 1)
INSERT [dbo].[PhanQuyen_ChucNang] ([MaQuyen], [MaChucNang], [CoQuyen]) VALUES (4, N'DM_KHACHHANG', 1)
INSERT [dbo].[PhanQuyen_ChucNang] ([MaQuyen], [MaChucNang], [CoQuyen]) VALUES (4, N'DM_NCC', 1)
INSERT [dbo].[PhanQuyen_ChucNang] ([MaQuyen], [MaChucNang], [CoQuyen]) VALUES (4, N'DM_NHANVIEN', 1)
INSERT [dbo].[PhanQuyen_ChucNang] ([MaQuyen], [MaChucNang], [CoQuyen]) VALUES (4, N'DM_SACH', 1)
INSERT [dbo].[PhanQuyen_ChucNang] ([MaQuyen], [MaChucNang], [CoQuyen]) VALUES (4, N'DM_THELOAI', 1)
INSERT [dbo].[PhanQuyen_ChucNang] ([MaQuyen], [MaChucNang], [CoQuyen]) VALUES (4, N'DS_HOADON', 1)
INSERT [dbo].[PhanQuyen_ChucNang] ([MaQuyen], [MaChucNang], [CoQuyen]) VALUES (4, N'HT_NGUOIDUNG', 1)
INSERT [dbo].[PhanQuyen_ChucNang] ([MaQuyen], [MaChucNang], [CoQuyen]) VALUES (4, N'HT_PHANQUYEN', 1)
INSERT [dbo].[PhanQuyen_ChucNang] ([MaQuyen], [MaChucNang], [CoQuyen]) VALUES (4, N'NHAP_HANG', 1)
GO
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNCC], [MaNV], [TongTien]) VALUES (N'PN20261104001', CAST(N'2026-11-04T07:17:24.000' AS DateTime), N'NCC03', N'NV001', CAST(210000 AS Decimal(18, 0)))
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNCC], [MaNV], [TongTien]) VALUES (N'PN20261104002', CAST(N'2026-11-04T08:40:07.927' AS DateTime), N'NCC03', N'NV001', CAST(70000 AS Decimal(18, 0)))
GO
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [TheLoai], [TacGia], [GiaNhap], [GiaBan], [SoLuongTon], [MaNCC], [MaTL]) VALUES (N'S001', N'Dế Mèn phiêu lưu ký', N'Thiếu nhi', N'Tô Hoài', CAST(45000.00 AS Decimal(18, 2)), CAST(62000.00 AS Decimal(18, 2)), 26, N'NCC02', N'TL05')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [TheLoai], [TacGia], [GiaNhap], [GiaBan], [SoLuongTon], [MaNCC], [MaTL]) VALUES (N'S002', N'Số đỏ', N'Văn học Việt Nam', N'Vũ Trọng Phụng', CAST(52000.00 AS Decimal(18, 2)), CAST(75000.00 AS Decimal(18, 2)), 15, N'NCC01', N'TL01')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [TheLoai], [TacGia], [GiaNhap], [GiaBan], [SoLuongTon], [MaNCC], [MaTL]) VALUES (N'S003', N'Tắt đèn', N'Văn học Việt Nam', N'Ngô Tất Tố', CAST(38000.00 AS Decimal(18, 2)), CAST(55000.00 AS Decimal(18, 2)), 8, N'NCC01', N'TL01')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [TheLoai], [TacGia], [GiaNhap], [GiaBan], [SoLuongTon], [MaNCC], [MaTL]) VALUES (N'S004', N'Nhà giả kim', N'Văn học nước ngoài', N'Paulo Coelho', CAST(55000.00 AS Decimal(18, 2)), CAST(79000.00 AS Decimal(18, 2)), 29, N'NCC03', N'TL02')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [TheLoai], [TacGia], [GiaNhap], [GiaBan], [SoLuongTon], [MaNCC], [MaTL]) VALUES (N'S005', N'Đắc nhân tâm', N'Kỹ năng sống', N'Dale Carnegie', CAST(60000.00 AS Decimal(18, 2)), CAST(86000.00 AS Decimal(18, 2)), 24, N'NCC03', N'TL03')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [TheLoai], [TacGia], [GiaNhap], [GiaBan], [SoLuongTon], [MaNCC], [MaTL]) VALUES (N'S006', N'Sapiens: Lược sử loài người', N'Khoa học - Công nghệ', N'Yuval Noah Harari', CAST(140000.00 AS Decimal(18, 2)), CAST(189000.00 AS Decimal(18, 2)), 5, N'NCC03', N'TL04')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [TheLoai], [TacGia], [GiaNhap], [GiaBan], [SoLuongTon], [MaNCC], [MaTL]) VALUES (N'S007', N'Clean Code', N'Khoa học - Công nghệ', N'Robert C. Martin', CAST(230000.00 AS Decimal(18, 2)), CAST(310000.00 AS Decimal(18, 2)), 3, N'NCC04', N'TL04')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [TheLoai], [TacGia], [GiaNhap], [GiaBan], [SoLuongTon], [MaNCC], [MaTL]) VALUES (N'S008', N'Cha giàu cha nghèo', N'Kinh tế', N'Robert T. Kiyosaki', CAST(70000.00 AS Decimal(18, 2)), CAST(98000.00 AS Decimal(18, 2)), 0, N'NCC04', N'TL06')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [TheLoai], [TacGia], [GiaNhap], [GiaBan], [SoLuongTon], [MaNCC], [MaTL]) VALUES (N'S009', N'Tuổi trẻ đáng giá bao nhiêu', N'Kỹ năng sống', N'Rosie Nguyễn', CAST(58000.00 AS Decimal(18, 2)), CAST(80000.00 AS Decimal(18, 2)), 4, N'NCC01', N'TL03')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [TheLoai], [TacGia], [GiaNhap], [GiaBan], [SoLuongTon], [MaNCC], [MaTL]) VALUES (N'S010', N'Doraemon - Tập 1', N'Thiếu nhi', N'Fujiko F. Fujio', CAST(16000.00 AS Decimal(18, 2)), CAST(22000.00 AS Decimal(18, 2)), 73, N'NCC02', N'TL05')
GO
INSERT [dbo].[TheLoai] ([MaTL], [TenTL], [MoTa]) VALUES (N'TL01', N'Văn học Việt Nam', N'Tiểu thuyết, truyện ngắn trong nước')
INSERT [dbo].[TheLoai] ([MaTL], [TenTL], [MoTa]) VALUES (N'TL02', N'Văn học nước ngoài', N'Tác phẩm dịch')
INSERT [dbo].[TheLoai] ([MaTL], [TenTL], [MoTa]) VALUES (N'TL03', N'Kỹ năng sống', N'Phát triển bản thân')
INSERT [dbo].[TheLoai] ([MaTL], [TenTL], [MoTa]) VALUES (N'TL04', N'Khoa học - Công nghệ', N'Sách chuyên ngành, lập trình')
INSERT [dbo].[TheLoai] ([MaTL], [TenTL], [MoTa]) VALUES (N'TL05', N'Thiếu nhi', N'Truyện tranh, sách cho trẻ em')
INSERT [dbo].[TheLoai] ([MaTL], [TenTL], [MoTa]) VALUES (N'TL06', N'Kinh tế', N'Kinh doanh, tài chính')
GO
ALTER TABLE [dbo].[HoaDon] ADD  DEFAULT (getdate()) FOR [NgayLap]
GO
ALTER TABLE [dbo].[KhachHang] ADD  DEFAULT ((0)) FOR [DiemTichLuy]
GO
ALTER TABLE [dbo].[KhachHang] ADD  DEFAULT (N'Thường') FOR [HangThanhVien]
GO
ALTER TABLE [dbo].[NguoiDung] ADD  DEFAULT ((1)) FOR [TrangThai]
GO
ALTER TABLE [dbo].[PhanQuyen_ChucNang] ADD  DEFAULT ((0)) FOR [CoQuyen]
GO
ALTER TABLE [dbo].[SanPham] ADD  DEFAULT ((0)) FOR [SoLuongTon]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_CTPN_PhieuNhap] FOREIGN KEY([MaPN])
REFERENCES [dbo].[PhieuNhap] ([MaPN])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_CTPN_PhieuNhap]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_CTPN_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_CTPN_SanPham]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [FK_KhachHang_HangThanhVien] FOREIGN KEY([MaHang])
REFERENCES [dbo].[HangThanhVien] ([MaHang])
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [FK_KhachHang_HangThanhVien]
GO
ALTER TABLE [dbo].[NguoiDung]  WITH CHECK ADD FOREIGN KEY([MaQuyen])
REFERENCES [dbo].[PhanQuyen] ([MaQuyen])
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD FOREIGN KEY([TenDangNhap])
REFERENCES [dbo].[NguoiDung] ([TenDangNhap])
GO
ALTER TABLE [dbo].[PhanQuyen_ChucNang]  WITH CHECK ADD  CONSTRAINT [FK_PQCN_ChucNang] FOREIGN KEY([MaChucNang])
REFERENCES [dbo].[ChucNang] ([MaChucNang])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PhanQuyen_ChucNang] CHECK CONSTRAINT [FK_PQCN_ChucNang]
GO
ALTER TABLE [dbo].[PhanQuyen_ChucNang]  WITH CHECK ADD  CONSTRAINT [FK_PQCN_PhanQuyen] FOREIGN KEY([MaQuyen])
REFERENCES [dbo].[PhanQuyen] ([MaQuyen])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PhanQuyen_ChucNang] CHECK CONSTRAINT [FK_PQCN_PhanQuyen]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_NhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_NhaCungCap]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_NhanVien]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_TheLoai] FOREIGN KEY([MaTL])
REFERENCES [dbo].[TheLoai] ([MaTL])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_TheLoai]
GO
GO

-- =====================================================================
-- Dữ liệu mẫu HÓA ĐƠN cho Thống kê / Biểu đồ
--  - 36 hóa đơn rải đều ~13 tháng gần nhất (cách nhau 11 ngày, không có hóa đơn hôm nay)
--  - Giảm giá theo hạng thành viên của khách; khách NULL = khách lẻ (0%)
--  - KHÔNG trừ tồn kho; chạy lại nhiều lần vẫn an toàn (hóa đơn đã có sẽ bị bỏ qua)
-- =====================================================================
SET NOCOUNT ON;

IF NOT EXISTS (SELECT 1 FROM SanPham) OR NOT EXISTS (SELECT 1 FROM NhanVien) OR NOT EXISTS (SELECT 1 FROM KhachHang)
BEGIN
    PRINT N'Thiếu dữ liệu Sách / Nhân viên / Khách hàng. Hãy chạy phần dữ liệu mẫu phía trên trước.';
END
ELSE
BEGIN
    IF OBJECT_ID('tempdb..#SP') IS NOT NULL DROP TABLE #SP;
    IF OBJECT_ID('tempdb..#NV') IS NOT NULL DROP TABLE #NV;
    IF OBJECT_ID('tempdb..#KH') IS NOT NULL DROP TABLE #KH;
    IF OBJECT_ID('tempdb..#HD') IS NOT NULL DROP TABLE #HD;
    IF OBJECT_ID('tempdb..#CT') IS NOT NULL DROP TABLE #CT;

    SELECT ROW_NUMBER() OVER (ORDER BY MaSP) - 1 AS idx, MaSP, ISNULL(GiaBan, 0) AS GiaBan INTO #SP FROM SanPham;
    SELECT ROW_NUMBER() OVER (ORDER BY MaNV) - 1 AS idx, MaNV INTO #NV FROM NhanVien;
    SELECT ROW_NUMBER() OVER (ORDER BY MaKH) - 1 AS idx, MaKH INTO #KH FROM KhachHang;

    DECLARE @nSP int = (SELECT COUNT(*) FROM #SP);
    DECLARE @nNV int = (SELECT COUNT(*) FROM #NV);
    DECLARE @nKH int = (SELECT COUNT(*) FROM #KH);

    -- 1) Danh sách hóa đơn cần tạo (bỏ qua mã đã tồn tại)
    ;WITH n AS (SELECT 1 AS i UNION ALL SELECT i + 1 FROM n WHERE i < 36)
    SELECT i,
           'HD' + CONVERT(char(8), DATEADD(DAY, -11 * i, GETDATE()), 112) + '9' + RIGHT('00' + CAST(i AS varchar(3)), 2) AS MaHD,
           DATEADD(HOUR, 8 + (i % 10), CAST(CAST(DATEADD(DAY, -11 * i, GETDATE()) AS date) AS datetime)) AS NgayLap,
           i % @nNV AS idxNV,
           i % (@nKH + 1) AS idxKH                 -- = @nKH nghĩa là khách lẻ
    INTO #HD
    FROM n
    OPTION (MAXRECURSION 100);

    DELETE FROM #HD WHERE MaHD IN (SELECT MaHD FROM HoaDon);

    -- 2) Chi tiết: mỗi hóa đơn 1-3 dòng, sách khác nhau, số lượng 1-4
    ;WITH L AS (SELECT 0 AS ln UNION ALL SELECT 1 UNION ALL SELECT 2)
    SELECT h.MaHD, s.MaSP,
           1 + ((h.i + L.ln) % 4)                          AS SoLuong,
           s.GiaBan                                        AS DonGia,
           (1 + ((h.i + L.ln) % 4)) * s.GiaBan             AS ThanhTien
    INTO #CT
    FROM #HD h
    JOIN L ON L.ln <= (h.i % 3)
    JOIN #SP s ON s.idx = ((h.i * 2 + L.ln) % @nSP);

    BEGIN TRY
        BEGIN TRAN;

        -- 3) Hóa đơn: tổng tiền, giảm giá theo hạng, thành tiền
        INSERT INTO HoaDon (MaHD, NgayLap, MaKH, MaNV, TongTien, GiamGia, ThanhTien)
        SELECT h.MaHD, h.NgayLap, k.MaKH, nv.MaNV, t.Tong, g.Giam, t.Tong - g.Giam
        FROM #HD h
        JOIN #NV nv ON nv.idx = h.idxNV
        LEFT JOIN #KH k ON k.idx = h.idxKH
        LEFT JOIN KhachHang kh ON kh.MaKH = k.MaKH
        LEFT JOIN HangThanhVien ht ON ht.MaHang = kh.MaHang
        CROSS APPLY (SELECT SUM(c.ThanhTien) AS Tong FROM #CT c WHERE c.MaHD = h.MaHD) t
        CROSS APPLY (SELECT ROUND(CAST(t.Tong AS decimal(18,2)) * ISNULL(ht.PhanTramGiam, 0) / 100.0, 0) AS Giam) g;

        INSERT INTO ChiTietHoaDon (MaHD, MaSP, SoLuong, DonGia, ThanhTien)
        SELECT MaHD, MaSP, SoLuong, DonGia, ThanhTien FROM #CT;

        COMMIT;
        PRINT N'Đã thêm ' + CAST((SELECT COUNT(*) FROM #HD) AS nvarchar(10)) + N' hóa đơn mẫu.';
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        PRINT N'Lỗi, đã hoàn tác: ' + ERROR_MESSAGE();
    END CATCH
END
GO
