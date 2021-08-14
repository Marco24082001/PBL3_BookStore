CREATE DATABASE QUAN_LY_HIEU_SACH
GO
USE QUAN_LY_HIEU_SACH

GO
CREATE TABLE NHA_XUAT_BAN
(
	MaNXB VARCHAR(5) PRIMARY KEY not null,
	TenNXB NVARCHAR(30) not null
)

CREATE TABLE LOAI_SACH
(
	MaLoaiSach VARCHAR(5) PRIMARY KEY not null,
	TenLoaiSach NVARCHAR(40) not null
)

CREATE TABLE SACH
(
	MaSach VARCHAR(5) PRIMARY KEY not null,
	TenSach NVARCHAR(30) not null,
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
	HoTen NVARCHAR(30) not null,
	DanToc NVARCHAR(10) not null,
	GioiTinh NVARCHAR(3) not null,
	CMND VARCHAR(12) not null,
	SoDienThoai VARCHAR(10) not null,
	QueQuan NVARCHAR(50) not null,
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
	HoTen NVARCHAR(30) not null,
)

CREATE TABLE HOA_DON_NHAP
(
	MaDonNhap INT Primary key not null,
	NgayNhap DATE not null,
)

CREATE TABLE CHI_TIET_HOA_DON_NHAP
( 
	ID INT IDENTITY(1,1) PRIMARY KEY not null,
	MaDonNhap int not null,
	MaSach VARCHAR(5) not null,
    FOREIGN KEY (MaSach)  REFERENCES SACH (MaSach),
	FOREIGN KEY (MaDonNhap) REFERENCES HOA_DON_NHAP (MaDonNhap),
	SoLuong INT not null,
	ThanhTien INT not null,
	UNIQUE(MaDonNhap,MaSach)
)


CREATE TABLE HOA_DON_BAN
(
	MaDonBan INT PRIMARY KEY not null,
	SDT_KH VARCHAR(10) not null,
	MaNhanVien VARCHAR(5) not null,
	FOREIGN KEY(MaNhanVien) REFERENCES NHAN_VIEN(MaNhanVien) ,
	FOREIGN KEY (SDT_KH) REFERENCES KHACH_HANG(SDT),
	NgayBan DATE not null
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
	DoanhThu INT not null,
	ThoiGian Date not null
)

CREATE TABLE DOANH_SO_BAN_HANG
(
	STT INT IDENTITY(1,1) PRIMARY KEY not null,
	MaNhanVien VARCHAR(5) not null,
	FOREIGN KEY (MaNhanVien) REFERENCES NHAN_VIEN(MaNhanVien),
	DoanhSoBan INT not null,
	ThoiGian Date not null
)

insert NHAN_VIEN values ('NV01', N'Phan Văn Bình', 'Kinh', 'Nam', '2012551678', '077121244', 'QuangNam', '12-12-2000', 1, 1)
insert NHAN_VIEN values ('NV02', N'Lê Văn Huy', 'Kinh', 'Nam', '2012551678', '077992244', 'QuangNam', '12-12-2000', 1, 0)
insert NHAN_VIEN values ('NV03', N'Nguyễn Thanh Cơ', 'Kinh', 'Nam', '2012551678', '077122244', 'QuangNam', '12-12-2000', 1, 0)
insert NHAN_VIEN values ('NV04', N'Võ Thành Vĩ', 'Kinh', 'Nam', '2012551678', '077125544', 'QuangNam', '12-12-2000', 1, 0)


insert TK_NHANVIEN values ('NV01', 'MK01')
insert TK_NHANVIEN values ('NV02', 'MK02')
insert TK_NHANVIEN values ('NV03', 'MK03')
insert TK_NHANVIEN values ('NV04', 'MK04')

insert NHA_XUAT_BAN values ('NXB01', N'Dale Carnegie')
insert NHA_XUAT_BAN values ('NXB02', N'Paulo Coelho')
insert NHA_XUAT_BAN values ('NXB03', N'Fyodor Dostoevsky')
insert NHA_XUAT_BAN values ('NXB04', N'Rosie Nguyễn')
insert NHA_XUAT_BAN values ('NXB05', N'Briane Bartes')



insert LOAI_SACH values ('L01', N'Tuổi trẻ')
insert LOAI_SACH values ('L02', N'Giáo dục')
insert LOAI_SACH values ('L03', N'Tâm lý-Xã hội')
insert LOAI_SACH values ('L04', N'Tình cảm')
insert LOAI_SACH values ('L05', N'Đời sống')


insert SACH values ('S001', N'Sống Đời Hạnh Phúc', 100000,80000, 220, 'NXB01', 'L01', 1)
insert SACH values ('S002', N'Đắc nhân tâm', 80000,60000, 310, 'NXB01', 'L03', 1)
insert SACH values ('S003', N'Nghệ Thuật Xử Thế', 100000,70000, 200, 'NXB01', 'L02', 1)
insert SACH values ('S004', N'Vui Sống Và Làm Việc', 80000,60000, 200, 'NXB01', 'L05',1 )
insert SACH values ('S005', N'Thuật Hùng Biện', 80000,60000, 150, 'NXB01', 'L02',1 )
insert SACH values ('S006', N'Ưu Thế Về Bán Hàng', 80000,60000, 350, 'NXB01', 'L02',1 )
insert SACH values ('S007', N'Nhà giả kim', 80000,60000, 330, 'NXB02', 'L02',1 )
insert SACH values ('S008', N'Ngoại tình', 100000,75000, 400, 'NXB02', 'L04',1 )
insert SACH values ('S009', N'Nỗi ám ảnh', 80000,60000, 250, 'NXB02', 'L03',1 )
insert SACH values ('S010', N'Mười một phút', 80000,60000, 340, 'NXB02', 'L03',1 )
insert SACH values ('S011', N'Tội ác và trừng phạt', 80000,60000, 400, 'NXB03', 'L05',1 )
insert SACH values ('S012', N'Nghèo Dân gian', 80000,60000, 400, 'NXB03', 'L03',1 )
insert SACH values ('S013', N'The Gambler', 80000,60000, 400, 'NXB03', 'L05',1 )
insert SACH values ('S014', N'Tuổi Trẻ Đáng Giá Bao Nhiêu?', 80000,60000, 400, 'NXB04', 'L01',1 )
insert SACH values ('S015', N'Ta Ba Lô Trên Đất Á', 80000,60000, 400, 'NXB04', 'L01',1 )
insert SACH values ('S016', N'Bài Học cuộc sống', 80000,60000, 400, 'NXB05', 'L05',1 )


INSERT INTO DOANH_SO_BAN_HANG(MaNhanVien,DoanhSoBan,ThoiGian) VALUES('NV02',500000,'20210706')
INSERT INTO DOANH_SO_BAN_HANG(MaNhanVien,DoanhSoBan,ThoiGian) VALUES('NV02',100000,'20210707')
INSERT INTO DOANH_SO_BAN_HANG(MaNhanVien,DoanhSoBan,ThoiGian) VALUES('NV02',95000,'20210713')
INSERT INTO DOANH_SO_BAN_HANG(MaNhanVien,DoanhSoBan,ThoiGian) VALUES('NV02',90000,'20210712')
INSERT INTO DOANH_SO_BAN_HANG(MaNhanVien,DoanhSoBan,ThoiGian) VALUES('NV03',600000,'20210701')
INSERT INTO DOANH_SO_BAN_HANG(MaNhanVien,DoanhSoBan,ThoiGian) VALUES('NV03',700000,'20210725')
INSERT INTO DOANH_SO_BAN_HANG(MaNhanVien,DoanhSoBan,ThoiGian) VALUES('NV03',700000,'20210726')
INSERT INTO DOANH_SO_BAN_HANG(MaNhanVien,DoanhSoBan,ThoiGian) VALUES('NV02',90000,'20210727')
INSERT INTO DOANH_SO_BAN_HANG(MaNhanVien,DoanhSoBan,ThoiGian) VALUES('NV04',700000,'20210730')
INSERT INTO DOANH_SO_BAN_HANG(MaNhanVien,DoanhSoBan,ThoiGian) VALUES('NV04',1200000,'20210729')
INSERT INTO DOANH_SO_BAN_HANG(MaNhanVien,DoanhSoBan,ThoiGian) VALUES('NV02',200000,'20200728')
INSERT INTO DOANH_SO_BAN_HANG(MaNhanVien,DoanhSoBan,ThoiGian) VALUES('NV02',100000,'20210801')
INSERT INTO DOANH_SO_BAN_HANG(MaNhanVien,DoanhSoBan,ThoiGian) VALUES('NV02',100000,'20210802')
INSERT INTO DOANH_SO_BAN_HANG(MaNhanVien,DoanhSoBan,ThoiGian) VALUES('NV02',100000,'20210803')
INSERT INTO DOANH_SO_BAN_HANG(MaNhanVien,DoanhSoBan,ThoiGian) VALUES('NV03',600000,'20210804')
INSERT INTO DOANH_SO_BAN_HANG(MaNhanVien,DoanhSoBan,ThoiGian) VALUES('NV03',700000,'20210805')
INSERT INTO DOANH_SO_BAN_HANG(MaNhanVien,DoanhSoBan,ThoiGian) VALUES('NV03',700000,'20210806')
INSERT INTO DOANH_SO_BAN_HANG(MaNhanVien,DoanhSoBan,ThoiGian) VALUES('NV02',90000,'20210807')
INSERT INTO DOANH_SO_BAN_HANG(MaNhanVien,DoanhSoBan,ThoiGian) VALUES('NV04',700000,'20210811')
INSERT INTO DOANH_SO_BAN_HANG(MaNhanVien,DoanhSoBan,ThoiGian) VALUES('NV04',1200000,'20210812')
INSERT INTO DOANH_SO_BAN_HANG(MaNhanVien,DoanhSoBan,ThoiGian) VALUES('NV02',200000,'20200814')


INSERT INTO DOANH_SO_BAN_HANG(MaNhanVien,DoanhSoBan,ThoiGian) VALUES('NV02',1200000,'20200901')
INSERT INTO DOANH_SO_BAN_HANG(MaNhanVien,DoanhSoBan,ThoiGian) VALUES('NV03',900000,'20200802')
INSERT INTO DOANH_SO_BAN_HANG(MaNhanVien,DoanhSoBan,ThoiGian) VALUES('NV03',750000,'20200718')
INSERT INTO DOANH_SO_BAN_HANG(MaNhanVien,DoanhSoBan,ThoiGian) VALUES('NV03',750000,'20200917')
INSERT INTO DOANH_SO_BAN_HANG(MaNhanVien,DoanhSoBan,ThoiGian) VALUES('NV02',680000,'20201116')
INSERT INTO DOANH_SO_BAN_HANG(MaNhanVien,DoanhSoBan,ThoiGian) VALUES('NV03',900000,'20201215')
INSERT INTO DOANH_SO_BAN_HANG(MaNhanVien,DoanhSoBan,ThoiGian) VALUES('NV03',100000,'20200212')
INSERT INTO DOANH_SO_BAN_HANG(MaNhanVien,DoanhSoBan,ThoiGian) VALUES('NV03',600000,'20200414')

INSERT INTO BAO_CAO_DOANH_THU(MaSach,GiaNhap,GiaBan,SoLuongBan,DoanhThu,ThoiGian) VALUES ('S001',80000,10000,5,100000,'20210814')
INSERT INTO BAO_CAO_DOANH_THU(MaSach,GiaNhap,GiaBan,SoLuongBan,DoanhThu,ThoiGian) VALUES ('S001',80000,10000,5,100000,'20210813')
INSERT INTO BAO_CAO_DOANH_THU(MaSach,GiaNhap,GiaBan,SoLuongBan,DoanhThu,ThoiGian) VALUES ('S001',80000,10000,2,100000,'20210812')
INSERT INTO BAO_CAO_DOANH_THU(MaSach,GiaNhap,GiaBan,SoLuongBan,DoanhThu,ThoiGian) VALUES ('S001',80000,10000,2,100000,'20210811')
INSERT INTO BAO_CAO_DOANH_THU(MaSach,GiaNhap,GiaBan,SoLuongBan,DoanhThu,ThoiGian) VALUES ('S002',80000,10000,5,100000,'20210810')
INSERT INTO BAO_CAO_DOANH_THU(MaSach,GiaNhap,GiaBan,SoLuongBan,DoanhThu,ThoiGian) VALUES ('S002',80000,10000,4,130000,'20210809')
INSERT INTO BAO_CAO_DOANH_THU(MaSach,GiaNhap,GiaBan,SoLuongBan,DoanhThu,ThoiGian) VALUES ('S003',80000,10000,1,310000,'20210808')
INSERT INTO BAO_CAO_DOANH_THU(MaSach,GiaNhap,GiaBan,SoLuongBan,DoanhThu,ThoiGian) VALUES ('S004',80000,10000,5,110000,'20210807')
INSERT INTO BAO_CAO_DOANH_THU(MaSach,GiaNhap,GiaBan,SoLuongBan,DoanhThu,ThoiGian) VALUES ('S005',80000,10000,1,200000,'20210805')
INSERT INTO BAO_CAO_DOANH_THU(MaSach,GiaNhap,GiaBan,SoLuongBan,DoanhThu,ThoiGian) VALUES ('S001',80000,10000,5,200000,'20210804')
INSERT INTO BAO_CAO_DOANH_THU(MaSach,GiaNhap,GiaBan,SoLuongBan,DoanhThu,ThoiGian) VALUES ('S004',80000,10000,5,150000,'20210803')
INSERT INTO BAO_CAO_DOANH_THU(MaSach,GiaNhap,GiaBan,SoLuongBan,DoanhThu,ThoiGian) VALUES ('S009',80000,10000,5,100000,'20210802')
INSERT INTO BAO_CAO_DOANH_THU(MaSach,GiaNhap,GiaBan,SoLuongBan,DoanhThu,ThoiGian) VALUES ('S002',80000,10000,6,700000,'20210801')
INSERT INTO BAO_CAO_DOANH_THU(MaSach,GiaNhap,GiaBan,SoLuongBan,DoanhThu,ThoiGian) VALUES ('S007',80000,10000,7,900000,'20210729')
INSERT INTO BAO_CAO_DOANH_THU(MaSach,GiaNhap,GiaBan,SoLuongBan,DoanhThu,ThoiGian) VALUES ('S008',80000,10000,1,980000,'20210725')
INSERT INTO BAO_CAO_DOANH_THU(MaSach,GiaNhap,GiaBan,SoLuongBan,DoanhThu,ThoiGian) VALUES ('S006',80000,10000,5,100000,'20210724')
