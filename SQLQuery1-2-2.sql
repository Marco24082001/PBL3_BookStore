CREATE DATABASE QUAN_LY_HIEU_SACH
GO
USE QUAN_LY_HIEU_SACH

GO
CREATE TABLE NHA_XUAT_BAN
(
	MaNXB VARCHAR(5) PRIMARY KEY not null,
	TenNXB VARCHAR(30) not null
)

CREATE TABLE LOAI_SACH
(
	MaLoaiSach VARCHAR(5) PRIMARY KEY not null,
	TenLoaiSach VARCHAR(30) not null
)

CREATE TABLE SACH
(
	MaSach VARCHAR(5) PRIMARY KEY not null,
	TenSach VARCHAR(30) not null,
	GiaBan INT not null,
	GiaNhap INT not null,
	SoLuong INT not null,
	MaNXB VARCHAR(5) not null,
	FOREIGN KEY (MaNXB) REFERENCES NHA_XUAT_BAN(MaNXB),
	MaLoaiSach VARCHAR(5) not null,
	FOREIGN KEY (MaLoaiSach) REFERENCES LOAI_SACH(MaLoaiSach),
	TrangThai bit not null
)

CREATE TABLE NHAN_VIEN
(
	MaNhanVien VARCHAR(5) PRIMARY KEY not null,
	HoTen VARCHAR(30) not null,
	DanToc VARCHAR(10) not null,
	GioiTinh VARCHAR(3) not null,
	CMND VARCHAR(12) not null,
	SoDienThoai VARCHAR(10) not null,
	QueQuan VARCHAR(50) not null,
	NgaySinh DATE not null,
	TrangThai bit not null,
	isAdmin bit not null
)

CREATE TABLE TK_NHANVIEN
(
	TKNV VARCHAR(5) PRIMARY KEY not null,
	FOREIGN KEY (TKNV) REFERENCES  NHAN_VIEN(MaNhanVien),
	Pass VARCHAR(10) not null
)

CREATE TABLE KHACH_HANG
(
	SDT VARCHAR(10) PRIMARY KEY not null,
	HoTen VARCHAR(30) not null,
)

CREATE TABLE HOA_DON_NHAP
(
	MaDonNhap int Primary key not null,
	NgayNhap DATE,
	GhiChu VARCHAR(60),
)

CREATE TABLE CHI_TIET_HOA_DON_NHAP
( 
	ID INT IDENTITY(1,1) PRIMARY KEY not null,
	MaDonNhap int not null,
	MaSach VARCHAR(5) not null,
    FOREIGN KEY (MaSach)  REFERENCES SACH (MaSach),
	FOREIGN KEY (MaDonNhap) REFERENCES HOA_DON_NHAP (MaDonNhap),
	SoLuong INT,
	ThanhTien INT ,
	UNIQUE(MaDonNhap,MaSach)
)


CREATE TABLE HOA_DON_BAN
(
	MaDonBan int PRIMARY KEY not null,
	SDT_KH VARCHAR(10) not null,
	MaNhanVien VARCHAR(5) not null,
	FOREIGN KEY(MaNhanVien) REFERENCES NHAN_VIEN(MaNhanVien) ,
	FOREIGN KEY (SDT_KH) REFERENCES KHACH_HANG(SDT),
	NgayBan DATE
)

CREATE TABLE CHI_TIET_HOA_DON_BAN
(
	ID INT IDENTITY(1,1) PRIMARY KEY not null,
	MaDonBan int not null,
	MaSach VARCHAR(5) not null,
	FOREIGN KEY (MaSach) REFERENCES SACH (MaSach),
	FOREIGN KEY (MaDonBan) REFERENCES HOA_DON_BAN(MaDonBan),
	SoLuong INT not null,
	DonGia INT not null,
	ThanhTien INT not null,
	UNIQUE (MaDonBan,MaSach)
)

CREATE TABLE BAO_CAO_DOANH_THU
(
	STT INT IDENTITY(1,1) PRIMARY KEY not null,
	MaSach VARCHAR(5) not null,
	FOREIGN KEY (MaSach) REFERENCES SACH(MaSach),
	GiaNhap INT not null,
	GiaBan INT not null,
	SoLuongBan	INT not null,
	DoanhThu INT,
	ThoiGian Date
)

CREATE TABLE DOANH_SO_BAN_HANG
(
	STT INT IDENTITY(1,1) PRIMARY KEY not null,
	MaNhanVien VARCHAR(5),
	FOREIGN KEY (MaNhanVien) REFERENCES NHAN_VIEN(MaNhanVien),
	DoanhSoBan INT,
	ThoiGian Date
)

insert NHAN_VIEN values ('NV01', 'NVA', 'Kinh', 'Nam', '206', '0941', 'QuangNam', '12-12-2000', 1, 1)
insert NHAN_VIEN values ('NV02', 'NVB', 'Kinh', 'Nam', '206', '0941', 'QuangNam', '12-12-2000', 1, 0)

insert TK_NHANVIEN values ('NV01', 'MK01')
insert TK_NHANVIEN values ('NV02', 'MK02')

insert NHA_XUAT_BAN values ('NXB01', 'NXBA')
insert NHA_XUAT_BAN values ('NXB02', 'NXBB')

insert LOAI_SACH values ('S01', 'SachA')
insert LOAI_SACH values ('S02', 'SachB')

insert SACH values ('S1', 'SachA', 100000,80000, 2, 'NXB01', 'S01', 1)
insert SACH values ('S2', 'SachB', 80000,60000, 4, 'NXB02', 'S02', 1)
insert SACH values ('S3', 'SachA', 100000,70000, 200, 'NXB01', 'S01', 1)
insert SACH values ('S4', 'SachB', 80000,60000, 400, 'NXB02', 'S02',1 )


select * from CHI_TIET_HOA_DON_BAN