CREATE DATABASE QuanLyBaoVangBuGV_TDTU_IT

DROP DATABASE QuanLyBaoVangBuGV_TDTU_IT

USE QuanLyBaoVangBuGV_TDTU_IT

CREATE TABLE Khoa (
ID_Khoa CHAR(10) PRIMARY KEY,
Ten_Khoa NVARCHAR(50) NOT NULL,
Truong_Khoa NVARCHAR(50) NOT NULL,
SDT NVARCHAR(15) NOT NULL,
Email NVARCHAR(50) NOT NULL UNIQUE
);

CREATE TABLE GiangVien (
ID_GV CHAR(10) PRIMARY KEY,
HoTen NVARCHAR(50) NOT NULL,
Email NVARCHAR(50) NOT NULL UNIQUE,
SDT NVARCHAR(15) NOT NULL,
MatKhau NVARCHAR(50) NOT NULL,
Ma_Khoa CHAR(10) DEFAULT 'CNTT',
PhanQuyen CHAR(5) NOT NULL,
FOREIGN KEY (Ma_Khoa) REFERENCES Khoa(ID_Khoa)
);

CREATE TABLE MonHoc (
ID_MH CHAR(10) PRIMARY KEY,
Ten_MH NVARCHAR(50) NOT NULL,
Thu NVARCHAR(20) NOT NULL,
Ca INT NOT NULL CHECK (Ca>0 AND Ca<5),
Ma_Khoa CHAR(10) DEFAULT 'CNTT',
Ma_GV CHAR(10) NOT NULL,
FOREIGN KEY (Ma_Khoa) REFERENCES Khoa(ID_Khoa),
FOREIGN KEY (Ma_GV) REFERENCES GiangVien(ID_GV)
);

CREATE TABLE SinhVien (
ID_SV CHAR(10) PRIMARY KEY,
HoTen NVARCHAR(50) NOT NULL,
Email NVARCHAR(50) NOT NULL UNIQUE,
SDT NVARCHAR(15) NOT NULL,
MatKhau NVARCHAR(50) NOT NULL,
PhanQuyen CHAR(5) DEFAULT 'S',
);

CREATE TABLE Lop (
ID_Lop CHAR(10) PRIMARY KEY,
Ma_MH CHAR(10) NOT NULL,
Ma_SV CHAR(10) NOT NULL,
FOREIGN KEY (Ma_MH) REFERENCES MonHoc(ID_MH),
FOREIGN KEY (Ma_SV) REFERENCES SinhVien(ID_SV),
);

CREATE TABLE PhieuVang (
ID_PV CHAR(10) PRIMARY KEY,
NgayVang DATE NOT NULL,
LyDo NVARCHAR(200) NOT NULL,
TrangThai NVARCHAR(50) NOT NULL DEFAULT N'Chưa chấp thuận',
Ma_MH CHAR(10) NOT NULL,
FOREIGN KEY (Ma_MH) REFERENCES MonHoc(ID_MH),
);

CREATE TABLE PhieuBu (
ID_PB CHAR(10) PRIMARY KEY,
NgayBu DATE NOT NULL,
TrangThai NVARCHAR(50) DEFAULT N'Chưa chấp thuận',
Ma_PV CHAR(10) NOT NULL,
FOREIGN KEY (Ma_PV) REFERENCES PhieuVang(ID_PV)
);


-- Insert Data Khoa
INSERT INTO Khoa(ID_Khoa, Ten_Khoa, Truong_Khoa, SDT, Email) VALUES
('CNTT', N'Công nghệ thông tin', N'Phạm Văn Huy', '09029309008', 'phamvanhuy@tdtu.edu.vn')

-- Insert Data GiangVien
INSERT INTO GiangVien(ID_GV, HoTen, Email, SDT, MatKhau, PhanQuyen) VALUES
('GV001', N'Phạm Văn Huy', 'phamvanhuy@tdtu.edu.vn', '0000000001', 'asd123', 'G'),
('GV002', N'Lê Anh Cường', 'leanhcuong@tdtu.edu.vn', '0000000002', 'asd123', 'G'),
('GV003', N'Trần Thanh Phước', 'tranthanhphuoc@tdtu.edu.vn', '0000000003', 'asd123', 'G'),
('GV004', N'Trương Đình Tú', 'truongdinhtu@tdtu.edu.vn', '0000000004', 'asd123', 'G'),
('GV005', N'Lê Văn Vang', 'levanvang@tdtu.edu.vn', '0000000005', 'asd123', 'G'),
('GV006', N'Nguyễn Chí Thiện', 'nguyenchithien@tdtu.edu.vn', '0000000006', 'asd123', 'G'),
('GV007', N'Huỳnh Ngọc Tú', 'huynhngoctu@tdtu.edu.vn', '0000000007', 'asd123', 'G'),
('GV008', N'Bùi Quy Anh', 'buiquyanh@tdtu.edu.vn', '0000000008', 'asd123', 'G'),
('GV009', N'Trần Trung Tín', 'trantrungtin@tdtu.edu.vn', '0000000009', 'asd123', 'G'),
('GV010', N'Trần Thanh Nam', 'tranthanhnam1@tdtu.edu.vn', '0000000010', 'asd123', 'G'),
('GV011', N'Nguyễn Văn A', 'nguyenvana@tdtu.edu.vn', '0000000011', 'asd123', 'K')

-- Insert Data MonHoc
INSERT INTO MonHoc(ID_MH, Ten_MH, Ma_GV, Thu, Ca) VALUES
('MH001', N'Công nghệ phần mềm', 'GV003', N'Thứ 2', 2),
('MH002', N'Công nghệ Java', 'GV005', N'Thứ 7', 3),
('MH003', N'IoT cơ bản', 'GV009', N'Thứ 3', 1),
('MH004', N'Phân tích và thiết kế yêu cầu', 'GV006', N'Thứ 5', 1),
('MH005', N'IoT nâng cao', 'GV008', N'Thứ 5', 4),
('MH006', N'Giao thức mạng máy tính', 'GV004', N'Thứ 3', 2),
('MH007', N'Bảo mật máy tính', 'GV010', N'Thứ 6', 2)

-- Insert Data SinhVien
INSERT INTO SinhVien(ID_SV, HoTen, Email, SDT, MatKhau) VALUES
('SV001', N'Nguyễn Văn A', 'nguyenvana@student.tdtu.edu.vn', '1', 'sv123'),
('SV002', N'Nguyễn Văn B', 'nguyenvanb@student.tdtu.edu.vn', '2', 'sv123'),
('SV003', N'Nguyễn Văn C', 'nguyenvanc@student.tdtu.edu.vn', '3', 'sv123'),
('SV004', N'Nguyễn Văn D', 'nguyenvand@student.tdtu.edu.vn', '4', 'sv123'),
('SV005', N'Nguyễn Văn E', 'nguyenvane@student.tdtu.edu.vn', '5', 'sv123'),
('SV006', N'Nguyễn Văn F', 'nguyenvanf@student.tdtu.edu.vn', '6', 'sv123'),
('SV007', N'Nguyễn Văn G', 'nguyenvang@student.tdtu.edu.vn', '7', 'sv123'),
('SV008', N'Nguyễn Văn H', 'nguyenvanh@student.tdtu.edu.vn', '8', 'sv123')

-- Insert Data Lop
INSERT INTO Lop(ID_Lop, Ma_MH, Ma_SV) VALUES
('MH001SV001', 'MH001', 'SV001'),
('MH002SV001', 'MH002', 'SV001'),
('MH004SV001', 'MH004', 'SV001'),
('MH003SV002', 'MH003', 'SV002'),
('MH005SV002', 'MH005', 'SV002'),
('MH001SV003', 'MH001', 'SV003'),
('MH005SV003', 'MH005', 'SV003'),
('MH002SV004', 'MH002', 'SV004'),
('MH001SV005', 'MH001', 'SV005'),
('MH005SV005', 'MH005', 'SV005')

--INSERT INTO PhieuVang(ID_PV, NgayVang, LyDo, Ma_MH) VALUES
--('PV001', '02/11/2002', N'Ngủ quên', 'MH001')

SELECT Lop.Ma_MH, Ten_MH, Thu, Ca, NgayVang, LyDo FROM Lop, MonHoc, PhieuVang WHERE Lop.Ma_MH = MonHoc.ID_MH AND MonHoc.ID_MH = PhieuVang.Ma_MH AND Ma_SV = 'SV001' AND TrangThai = N'Chấp thuận'
