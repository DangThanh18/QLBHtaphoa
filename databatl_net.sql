create database dbbtl_net
go
use dbbtl_net
go
--------------------------------------------TẠO BẢNG----------------------------------------------------------
create table KhachHang 
(MaKH varchar(10) not null primary key,
TenKKH nvarchar(50) not null,
DiaChi nvarchar (50) not null,
Email nvarchar(50),
SDT nvarchar(50))

create table NhanVien
(MaNV varchar(10) not null primary key,
TenNV nvarchar(50) not null,
Diachi nvarchar(50) not null,
Matkhau varchar(15) not null,
Quyen nvarchar(50) not null)

create table Hanghoa
(Mahang varchar(10) not null primary key,
Maloai varchar(10) not null,
Tenhang nvarchar(50) not null,
DVT nvarchar(50) not null,
DonGia float not null
)

create table Hoadon
(SoHD varchar(10) not null primary key,
Ngayban date not null,
MaKH varchar(10) not null,
MaNV varchar(10) not null,
Tongtien float null)

create table CT_Hoadon
(SoHD varchar(10) not null primary key,
Mahang varchar(10) not null ,
Maloai varchar(10) not null,
Soluong int not null,
Dongia float not null,
CONSTRAINT unique_Mahang UNIQUE (Mahang))

create table Loaihang
(Maloai varchar(10) not null primary key,
Tenloai nvarchar(50) not null)
------------------------CHÈN THÔNG TIN---------------------------------------------------------
insert into KhachHang(MaKH,TenKKH,DiaChi,Email,SDT)
values
('KH001',N'Lê Tuyết Mai',N'Hà Nội','tuyetmaio@gmail.com','0399431525'),
('KH002',N'Lê Quang Huy',N'Nam Định','quanghuy@gmail.com','0965478215'),
('KH003',N'Nguyễn Thị Hương',N'Bắc Ninh','nguyenhuong@gmail.com','0831576294'),
('KH004',N'Phạm Thị Bích Ngọc',N'Ninh Bình','bichngoc@gmail.com','0354796214'),
('KH005',N'Vũ Hồng Quân',N'Thanh Hóa','hongquan@gmail.com','0842651735')

insert into NhanVien(MaNV,TenNV,Diachi,Matkhau,Quyen)
values
('NV001',N'Nguyễn Thị Linh',N'Hà Nội','linh123',N'Nhân viên'),
('NV002',N'Mai Hương Lý',N'Ninh Bình','ly243',N'Quản lý'),
('NV003', N'Đặng Tiến Thành','Hà Nội', 'thanh345', N'Nhân viên'),
('NV004',N'Nguyễn Minh Văn',N'Hà Nam','van456',N'Quản lý'),
('NV005',N'Phạm Văn Khánh',N'Nam Định','khanh567',N'Quản lý')

insert into Hanghoa(Mahang,Maloai,Tenhang,DVT,DonGia)
values
('hh001', 'VIP1' , N'Bút chì' , 'VND' , 10000),
('hh002', 'TH1',N'Nước giải khát', 'VND',15000),
('hh003', 'VIP1',N'Bánh quy', 'VND' ,8000),
('hh004', 'TH1',N'Vở', 'VND',10000 ),
('hh005', 'TH1',N'Mì tôm', 'VND',3000 )

insert into Hoadon(SoHD,Ngayban,MaKH,MaNV)
values
('hd001', '2023/09/05','KH001', 'NV001'),
('hd002', '2023/07/05','KH002', 'NV002'),
('hd003', '2023/08/05','KH003', 'NV003'),
('hd004', '2023/09/05','KH004', 'NV004'),
('hd005', '2023/02/05','KH005', 'NV005')

insert into CT_Hoadon(SoHD,Mahang,Maloai,Soluong,Dongia)
values
('hd001','hh001', 'BC01',3, 100000),
('hd002','hh002', 'NGK02',3, 200000),
('hd003','hh003', 'BQ03',2, 150000),
('hd004','hh004', 'Vo04',2, 180000),
('hd005','hh005', 'MT05',5, 250000)

insert into Loaihang(Maloai,Tenloai)
values
('VIP1', 'Vip'),
('TH1', 'Thuong')
-------------------------HIỂN THỊ BẢNG---------------------------------------------------------
select * from KhachHang
select * from NhanVien
select * from Hanghoa
select * from Hoadon
select * from CT_Hoadon
select * from Loaihang

alter table Hoadon add foreign key(MaKH) references KhachHang(MaKH)
alter table Hoadon add foreign key(MaNV) references NhanVien(MaNV)
alter table CT_Hoadon add foreign key(SoHD) references Hoadon(SoHD)
alter table CT_Hoadon add foreign key(MaHang) references Hanghoa(MaHang)
alter table Hanghoa add foreign key(Maloai) references Loaihang(Maloai)


---- Ket noi va cap nhat QH KhachHang va Hoadon
--ALTER TABLE Hoadon 
--ADD  CONSTRAINT FK_Ma_Hoadon
--FOREIGN key (MaKH) REFERENCES KhachHang(MaKH)

--go

---- Ket noi va cap nhat QH NhanVien va Hoadon
--ALTER TABLE Hoadon 
--ADD  CONSTRAINT FK_Ma_Hadon
--FOREIGN key (MaNV) REFERENCES NhanVien(MaNV)

--go

---- Ket noi va cap nhat QH CT_Hoadon va Hoadon
--ALTER TABLE CT_Hoadon
--ADD  CONSTRAINT FK_Ma_CT_Hoadon
--FOREIGN key (SoHD) REFERENCES Hoadon(SoHD)

--go

---- Ket noi va cap nhat QH CT_Hoadon va Hanghoa
--ALTER TABLE Hanghoa
--ADD  CONSTRAINT FK_Ma_Hanghoa
--FOREIGN key (Mahang) REFERENCES CT_Hoadon(Mahang)

--go

---- Ket noi va cap nhat QH Hanghoa va Loaihang
--alter table dbo.Hanghoa		add foreign key(Maloai)	references dbo.Loaihang(Maloai)
--go


SELECT * FROM KhachHang ORDER BY TenKKH ASC
CREATE PROCEDURE getHangHoaData
AS
BEGIN
   -- Câu lệnh SELECT để lấy dữ liệu từ các bảng
   SELECT 
      HangHoa.MaHang,
	  LoaiHang.TenLoai,
	  HangHoa.Tenhang,
	  HangHoa.DVT,
	  HangHoa.DonGia

   FROM 
      HangHoa
 
   INNER JOIN LoaiHang ON HangHoa.MaLoai = LoaiHang.MaLoai
END

CREATE PROCEDURE getHoaDonData
AS
BEGIN
   -- Câu lệnh SELECT để lấy dữ liệu từ các bảng
   SELECT 
      HoaDon.SoHD,
	  KhachHang.TenKKH,
	  HangHoa.Tenhang,
	  CT_Hoadon.Soluong,
	  CT_Hoadon.Dongia,
	  HoaDon.MaNV
   FROM 
      HoaDon
 
   INNER JOIN CT_Hoadon ON CT_Hoadon.SoHD = HoaDon.SoHD
   INNER JOIN KhachHang ON HoaDon.MaKH = KhachHang.MaKH
   INNER JOIN HangHoa ON CT_Hoadon.MaHang = HangHoa.MaHang
END

drop table Hoadon