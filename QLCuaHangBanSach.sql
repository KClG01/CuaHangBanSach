USE [master]
CREATE DATABASE QLCuaHangBanSach
GO

USE [QLCuaHangBanSach]
GO

-- TẠO BẢNG KHÁCH HÀNG
CREATE TABLE KHACH_HANG
(
	MAKH CHAR(5),
	TENKH NVARCHAR(256),
	SDT CHAR(10), 
	EMAIL VARCHAR(50),
	DIACHI NVARCHAR(256),
	NGAYTAO DATE DEFAULT(GETDATE()),
	TRANGTHAI INT,
	CONSTRAINT PK_KHACHHANG PRIMARY KEY(MAKH)
)
-- TẠO BẢNG SẢN PHẨM
CREATE TABLE SAN_PHAM
(
	MASP INT,
	TENSP CHAR(256),
	MA_TACGIA CHAR(5),
	MA_NXB CHAR(5),
	MA_LOAI Char(5),
	GIANHAP MONEY,
	GIABAN MONEY,
	SLTON INT,
	HINHANH VARCHAR(256),
	TRANGTHAI BIT,
	CONSTRAINT PK_SANPHAM PRIMARY KEY(MASP),
	CONSTRAINT CK_SANPHAM_GIABAN CHECK(GIABAN >0),
	CONSTRAINT UN_SANPHAM_TENSP UNIQUE(TENSP)
)
-- TẠO BẢNG HÓA ĐƠN
CREATE TABLE HOA_DON
(
	MAHD CHAR(5),
	MANV CHAR(5),
	MAKH CHAR(5),
	NGAYBAN DATETIME DEFAULT GETDATE(),
	TIENNHAN MONEY,
	TIENTRA MONEY,
	THANHTIEN MONEY,
	TRANGTHAI BIT,
	CONSTRAINT PK_HOADON PRIMARY KEY(MAHD),
	CONSTRAINT FK_HOADON_KHACHHANG FOREIGN KEY (MAKH) REFERENCES KHACH_HANG(MAKH)
)
-- TẠO BẢNG NHÂN VIÊN
CREATE TABLE NHAN_VIEN
(
	MA_NV CHAR(5),
	TEN_NV NVARCHAR(256),
	MA_NQL CHAR(5),
	GIOITINH Bit,
	SDT CHAR(12),
	EMAIL CHAR(20),
	DIACHI NVARCHAR(256),
	LUONG MONEY,
	NGAYTAO DATE DEFAULT GETDATE(),
	NGAYSINH DATE,
	PASSWORD CHAR(20),
	TRANGTHAI BIT,
	CONSTRAINT PK_NHANVIEN PRIMARY KEY (MA_NV),
	CONSTRAINT FK_NHANVIEN_QL FOREIGN KEY (MA_NQL) REFERENCES  NHAN_VIEN(MA_NV)
)
-- TẠO BẢNG CHI TIẾT HÓA ĐƠN
CREATE TABLE CT_HOADON
(
	MAHD CHAR(5),
	MASP INT,
	SOLUONG INT,
	DONGIA MONEY,
	KHUYENMAI FLOAT,
	THANHTIEN MONEY,
	CONSTRAINT PK_CTHOADON PRIMARY KEY (MAHD,MASP),
	CONSTRAINT CK_CT_KHUYENMAI CHECK(KHUYENMAI > 0),
)
-- TẠO BẢNG SẢN PHẨM
CREATE TABLE LOAI_SP
(
	MA_LOAI CHAR(5),
	TENLOAI NVARCHAR(50),
	CONSTRAINT FK_LOAISP PRIMARY KEY (MA_LOAI)
)
-- TẠO BẢNG NHÀ XUẤT BẢN
CREATE TABLE NHA_XUAT_BAN
	(
	MA_NXB CHAR(5),
	TEN_NXB NVARCHAR(50),
	LIENHE CHAR(12),
	DIACHI NVARCHAR(256)
	CONSTRAINT PK_MANXB PRIMARY KEY(MA_NXB)
)
-- TẠO BẢNG TÁC GIẢ
CREATE TABLE TAC_GIA
(
	MA_TC CHAR(5),
	BUTDANH NVARCHAR(50),
	TEN_TC NVARCHAR(50),
	NGSINH DATE,
	LIENHE CHAR(10),
	DIACHI NVARCHAR(256) 

	CONSTRAINT PK_MATC PRIMARY KEY(MA_TC)
)

-- ALTER TABLE

ALTER TABLE HOA_DON
	ADD CONSTRAINT FK_HOADON_NHANVIEN
	FOREIGN KEY (MANV) REFERENCES NHAN_VIEN(MA_NV)


ALTER TABLE CT_HOADON
	ADD CONSTRAINT FK_CT_HOADON
	FOREIGN KEY (MAHD) REFERENCES HOA_DON(MAHD)

ALTER TABLE CT_HOADON
	ADD CONSTRAINT FK_CT_SANPHAM
	FOREIGN KEY (MASP) REFERENCES SAN_PHAM(MASP)

ALTER TABLE SAN_PHAM
	ADD CONSTRAINT FK_SANPHAM_LOAISP
	FOREIGN KEY (MA_LOAI) REFERENCES LOAI_SP(MA_LOAI)

ALTER TABLE SAN_PHAM
	ADD CONSTRAINT FK_SP_NXB
	FOREIGN KEY(MA_NXB) REFERENCES NHA_XUAT_BAN(MA_NXB)

ALTER TABLE SAN_PHAM
	ADD CONSTRAINT FK_SP_TC
	FOREIGN KEY(MA_TACGIA) REFERENCES TAC_GIA(MA_TC)


-- INSERT
-- Chèn dữ liệu vào bảng KHACH_HANG
INSERT INTO KHACH_HANG (MAKH, TENKH, SDT, EMAIL, DIACHI, TRANGTHAI) VALUES
('KH01', N'Nguyễn Văn An', '0912345678', 'an.nguyen@example.com', N'123 Đường ABC, Hà Nội', 1),
('KH02', N'Trần Thị Bình', '0987654321', 'binh.tran@example.com', N'456 Đường XYZ, TP.HCM', 1),
('KH03', N'Lê Hoàng Nam', '0934567890', 'nam.le@example.com', N'789 Đường DEF, Đà Nẵng', 1),
('KH04', N'Phạm Thị Hương', '0968765432', 'huong.pham@example.com', N'101 Đường GHI, Cần Thơ', 1),
('KH05', N'Vũ Đức Mạnh', '0945678901', 'manh.vu@example.com', N'234 Đường JKL, Hải Phòng', 1),
('KH06', N'Đỗ Thị Quỳnh', '0923456789', 'quynh.do@example.com', N'567 Đường MNO, Hà Nội', 1),
('KH07', N'Hoàng Minh Tuấn', '0978901234', 'tuan.hoang@example.com', N'890 Đường PQR, TP.HCM', 1),
('KH08', N'Cao Thị Trang', '0956789012', 'trang.cao@example.com', N'123 Đường STU, Đà Nẵng', 1),
('KH09', N'Đinh Văn Việt', '0912345670', 'viet.dinh@example.com', N'456 Đường VWX, Cần Thơ', 1),
('KH10', N'Nguyễn Ngọc Lan', '0987654320', 'lan.nguyen@example.com', N'789 Đường YZ, Hải Phòng', 1),
('KH11', N'Trần Văn Nam', '0934567891', 'nam.tran@example.com', N'111 Đường AAA, Hà Nội', 1),
('KH12', N'Lê Thị Mai', '0968765431', 'mai.le@example.com', N'222 Đường BBB, TP.HCM', 1),
('KH13', N'Phạm Hoàng Anh', '0945678902', 'anh.pham@example.com', N'333 Đường CCC, Đà Nẵng', 1),
('KH14', N'Vũ Thị Thảo', '0923456780', 'thao.vu@example.com', N'444 Đường DDD, Cần Thơ', 1),
('KH15', N'Đỗ Đức Mạnh', '0978901235', 'manh.do@example.com', N'555 Đường EEE, Hải Phòng', 1),
('KH16', N'Hoàng Thị Phương', '0956789013', 'phuong.hoang@example.com', N'666 Đường FFF, Hà Nội', 1),
('KH17', N'Cao Minh Tuấn', '0912345671', 'tuan.cao@example.com', N'777 Đường GGG, TP.HCM', 1),
('KH18', N'Đinh Thị Ngọc', '0987654322', 'ngoc.dinh@example.com', N'888 Đường HHH, Đà Nẵng', 1),
('KH19', N'Nguyễn Văn Bình', '0934567892', 'binh.nguyen@example.com', N'999 Đường III, Cần Thơ', 1),
('KH20', N'Trần Ngọc Lan', '0968765433', 'lan.tran@example.com', N'100 Đường KKK, Hải Phòng', 1),
('KH21', N'Lê Hoàng Anh', '0945678903', 'anh.le@example.com', N'102 Đường LLL, Hà Nội', 1),
('KH22', N'Phạm Thị Thu', '0923456781', 'thu.pham@example.com', N'104 Đường MMM, TP.HCM', 1),
('KH23', N'Vũ Đức Trung', '0978901236', 'trung.vu@example.com', N'106 Đường NNN, Đà Nẵng', 1),
('KH24', N'Đỗ Thị Hà', '0956789014', 'ha.do@example.com', N'108 Đường OOO, Cần Thơ', 1),
('KH25', N'Hoàng Minh Đức', '0912345672', 'duc.hoang@example.com', N'110 Đường PPP, Hải Phòng', 1),
('KH26', N'Cao Thị Hồng', '0987654323', 'hong.cao@example.com', N'112 Đường QQQ, Hà Nội', 1),
('KH27', N'Đinh Văn Hoàng', '0934567893', 'hoang.dinh@example.com', N'114 Đường RRR, TP.HCM', 1),
('KH28', N'Nguyễn Ngọc Diệp', '0968765434', 'diep.nguyen@example.com', N'116 Đường SSS, Đà Nẵng', 1),
('KH29', N'Trần Văn Hải', '0945678904', 'hai.tran@example.com', N'118 Đường TTT, Cần Thơ', 1),
('KH30', N'Lê Thị Phương Anh', '0923456782', 'phuonganh.le@example.com', N'120 Đường UUU, Hải Phòng', 1),
('KH31', N'Phạm Hoàng Nam', '0978901237', 'nam.pham@example.com', N'122 Đường VVV, Hà Nội', 1),
('KH32', N'Vũ Thị Thanh', '0956789015', 'thanh.vu@example.com', N'124 Đường XXX, TP.HCM', 1),
('KH33', N'Đỗ Đức Mạnh', '0912345673', 'manh.do@example.com', N'126 Đường YYY, Đà Nẵng', 1),
('KH34', N'Hoàng Thị Thúy', '0987654324', 'thuy.hoang@example.com', N'128 Đường ZZZ, Cần Thơ', 1),
('KH35', N'Cao Minh Đức', '0934567894', 'duc.cao@example.com', N'130 Đường AAA, Hải Phòng', 1),
('KH36', N'Đinh Thị Phương Anh', '0968765435', 'phuonganh.dinh@example.com', N'132 Đường BBB, Hà Nội', 1),
('KH37', N'Nguyễn Văn Hoàng', '0945678905', 'hoang.nguyen@example.com', N'134 Đường CCC, TP.HCM', 1),
('KH38', N'Trần Ngọc Hà', '0923456783', 'ha.tran@example.com', N'136 Đường DDD, Đà Nẵng', 1),
('KH39', N'Lê Hoàng Minh', '0978901238', 'minh.le@example.com', N'138 Đường EEE, Cần Thơ', 1),
('KH40', N'Phạm Thị Hương Giang', '0956789016', 'huonggiang.pham@example.com', N'140 Đường FFF, Hải Phòng', 1);

-- Chèn dữ liệu vào bảng LOAI_SP
INSERT INTO LOAI_SP (MA_LOAI, TENLOAI) VALUES
('TL01', N'Khoa học viễn tưởng'),
('TL02', N'Lãng mạn'),
('TL03', N'Trinh thám'),
('TL04', N'Kinh dị'),
('TL05', N'Tiểu thuyết lịch sử'),
('TL06', N'Hài hước'),
('TL07', N'Phiêu lưu'),
('TL08', N'Tự lực'),
('TL09', N'Nấu ăn'),
('TL10', N'Thiếu nhi'),
('TL11', N'Tâm lý'),
('TL12', N'Kinh doanh'),
('TL13', N'Công nghệ'),
('TL14', N'Thể thao'),
('TL15', N'Du lịch'),
('TL16', N'Nghệ thuật'),
('TL17', N'Âm nhạc'),
('TL18', N'Tôn giáo'),
('TL19', N'Triết học'),
('TL20', N'Sách giáo trình');


-- Chèn dữ liệu vào bảng NHA_XUAT_BAN
INSERT INTO NHA_XUAT_BAN (MA_NXB, TEN_NXB, LIENHE, DIACHI) VALUES
('NX01', N'Nhà Xuất Bản Trẻ', '0911222333', N'161B Lý Chính Thắng, Quận 3, TP.HCM'),
('NX02', N'Nhà Xuất Bản Kim Đồng', '0922333444', N'55 Quang Trung, Quận Gò Vấp, TP.HCM'),
('NX03', N'Nhà Xuất Bản Tổng Hợp', '0933444555', N'62 Nguyễn Thị Minh Khai, Quận 1, TP.HCM'),
('NX04', N'Nhà Xuất Bản Lao Động', '0944555666', N'34 Tôn Đức Thắng, Quận 1, TP.HCM'),
('NX05', N'Nhà Xuất Bản Văn Học', '0955666777', N'223 Nguyễn Văn Cừ, Quận 5, TP.HCM');


-- Chèn dữ liệu vào bảng TAC_GIA
INSERT INTO TAC_GIA (MA_TC, BUTDANH, TEN_TC, NGSINH, LIENHE, DIACHI) VALUES
('TG01', N'Frank H.', N'Frank Herbert', '1920-10-08', '0911000001', N'Oregon, USA'),
('TG02', N'Nicholas S.', N'Nicholas Sparks', '1965-12-31', '0911000002', N'North Carolina, USA'),
('TG03', N'Gillian F.', N'Gillian Flynn', '1971-02-24', '0911000003', N'Chicago, USA'),
('TG04', N'Bram S.', N'Bram Stoker', '1847-11-08', '0911000004', N'Dublin, Ireland'),
('TG05', N'Kristin H.', N'Kristin Hannah', '1960-09-25', '0911000005', N'California, USA'),
('TG06', N'Tina F.', N'Tina Fey', '1970-05-18', '0911000006', N'Pennsylvania, USA'),
('TG07', N'Jon K.', N'Jon Krakauer', '1954-04-12', '0911000007', N'Massachusetts, USA'),
('TG08', N'Stephen C.', N'Stephen Covey', '1932-10-24', '0911000008', N'Utah, USA'),
('TG09', N'Julia C.', N'Julia Child', '1912-08-15', '0911000009', N'California, USA'),
('TG10', N'Dr. Seuss', N'Theodor Seuss Geisel', '1904-03-02', '0911000010', N'Springfield, USA'),
('TG11', N'Alex M.', N'Alex Michaelides', '1977-09-04', '0911000011', N'Cyprus'),
('TG12', N'Robert K.', N'Robert Kiyosaki', '1947-04-08', '0911000012', N'Hawaii, USA'),
('TG13', N'Walter I.', N'Walter Isaacson', '1952-05-20', '0911000013', N'New Orleans, USA'),
('TG14', N'Michael L.', N'Michael Lewis', '1960-10-15', '0911000014', N'New Orleans, USA'),
('TG15', N'Elizabeth G.', N'Elizabeth Gilbert', '1969-07-18', '0911000015', N'Connecticut, USA'),
('TG16', N'Donna T.', N'Donna Tartt', '1963-12-23', '0911000016', N'Mississippi, USA'),
('TG17', N'Bruce S.', N'Bruce Springsteen', '1949-09-23', '0911000017', N'New Jersey, USA'),
('TG18', N'Bui Huy Khang', N'BHK9', '2005-09-25', '0911000018', N'Toàn cầu'),
('TG19', N'Marcus A.', N'Marcus Aurelius', '2011-04-26', '0911000019', N'Rome, Italy'),
('TG20', N'James S.', N'James Stewart', '1950-01-01', '0911000020', N'USA'),
('TG21', N'J.R.R. T.', N'J.R.R. Tolkien', '1892-01-03', '0911000021', N'Bloemfontein, South Africa'),
('TG22', N'Jane A.', N'Jane Austen', '1775-12-16', '0911000022', N'Steventon, England'),
('TG23', N'Stieg L.', N'Stieg Larsson', '1954-08-15', '0911000023', N'Sweden'),
('TG24', N'Stephen K.', N'Stephen King', '1947-09-21', '0911000024', N'Maine, USA'),
('TG25', N'Markus Z.', N'Markus Zusak', '1975-06-23', '0911000025', N'Sydney, Australia'),
('TG26', N'Amy P.', N'Amy Poehler', '1971-09-16', '0911000026', N'Massachusetts, USA'),
('TG27', N'Andy W.', N'Andy Weir', '1972-06-16', '0911000027', N'California, USA'),
('TG28', N'Brené B.', N'Brené Brown', '1965-11-18', '0911000028', N'Texas, USA'),
('TG29', N'Samin N.', N'Samin Nosrat', '1979-11-07', '0911000029', N'California, USA'),
('TG30', N'Maurice S.', N'Maurice Sendak', '1928-06-10', '0911000030', N'New York, USA'),
('TG31', N'Paula H.', N'Paula Hawkins', '1972-08-26', '0911000031', N'Zimbabwe/UK'),
('TG32', N'Eric R.', N'Eric Ries', '1978-09-22', '0911000032', N'California, USA'),
('TG33', N'Peter T.', N'Peter Thiel', '1967-10-11', '0911000033', N'Germany/USA'),
('TG34', N'Yuval H.', N'Yuval Noah Harari', '1976-02-24', '0911000034', N'Israel'),
('TG35', N'Yuval H.', N'Yuval Noah Harari', '1976-02-24', '0911000035', N'Israel'),
('TG36', N'Yuval H.', N'Yuval Noah Harari', '1976-02-24', '0911000036', N'Israel'),
('TG37', N'Albert E.', N'Albert Einstein', '1879-03-14', '0911000037', N'Ulm, Germany'),
('TG38', N'Friedrich H.', N'Friedrich Hayek', '1899-05-08', '0911000038', N'Austria'),
('TG39', N'Thomas P.', N'Thomas Piketty', '1971-05-07', '0911000039', N'France'),
('TG40', N'Daniel K.', N'Daniel Kahneman', '1934-03-05', '0911000040', N'Israel/USA');


-- Chèn dữ liệu vào bảng SAN_PHAM
INSERT INTO SAN_PHAM (MASP, TENSP, MA_TACGIA, MA_NXB, MA_LOAI, GIANHAP, GIABAN, SLTON, HINHANH, TRANGTHAI) VALUES
(1, N'Dune', 'TG01', 'NX01', 'TL01', 50000, 70000, 10, 'dune.jpg', 1),
(2, N'The Notebook', 'TG02', 'NX02', 'TL02', 40000, 60000, 5, 'the_notebook.jpg', 1),
(3, N'Gone Girl', 'TG03', 'NX03', 'TL03', 45000, 65000, 8, 'gone_girl.jpg', 1),
(4, N'Dracula', 'TG04', 'NX01', 'TL04', 35000, 50000, 3, 'dracula.jpg', 1),
(5, N'The Nightingale', 'TG05', 'NX02', 'TL05', 47000, 69000, 7, 'the_nightingale.jpg', 1),
(6, N'Bossypants', 'TG06', 'NX03', 'TL06', 48000, 70000, 6, 'bossypants.jpg', 1),
(7, N'Into the Wild', 'TG07', 'NX01', 'TL07', 40000, 60000, 4, 'into_the_wild.jpg', 1),
(8, N'The 7 Habits of Highly Effective People', 'TG08', 'NX02', 'TL08', 55000, 80000, 9, '7habits.jpg', 1),
(9, N'Mastering the Art of French Cooking', 'TG09', 'NX03', 'TL09', 50000, 75000, 2, 'french_cooking.jpg', 1),
(10, N'The Cat in the Hat', 'TG10', 'NX01', 'TL10', 30000, 45000, 12, 'cat_in_hat.jpg', 1),
(11, N'The Silent Patient', 'TG11', 'NX02', 'TL11', 49000, 72000, 11, 'silent_patient.jpg', 1),
(12, N'Rich Dad Poor Dad', 'TG12', 'NX03', 'TL12', 47000, 68000, 15, 'rich_dad.jpg', 1),
(13, N'Steve Jobs', 'TG13', 'NX01', 'TL13', 53000, 78000, 13, 'steve_jobs.jpg', 1),
(14, N'Moneyball', 'TG14', 'NX02', 'TL14', 52000, 76000, 14, 'moneyball.jpg', 1),
(15, N'Eat, Pray, Love', 'TG15', 'NX03', 'TL15', 49000, 73000, 16, 'eat_pray_love.jpg', 1),
(16, N'The Goldfinch', 'TG16', 'NX01', 'TL16', 51000, 77000, 17, 'goldfinch.jpg', 1),
(17, N'Born to Run', 'TG17', 'NX02', 'TL17', 46000, 69000, 18, 'born_to_run.jpg', 1),
(18, N'The Bible', 'TG18', 'NX03', 'TL18', 50000, 80000, 20, 'bible.jpg', 1),
(19, N'Meditations', 'TG19', 'NX01', 'TL19', 44000, 67000, 19, 'meditations.jpg', 1),
(20, N'Calculus', 'TG20', 'NX02', 'TL20', 55000, 82000, 21, 'calculus.jpg', 1),
(21, N'The Lord of the Rings', 'TG21', 'NX04', 'TL01', 60000, 85000, 22, 'lotr.jpg', 1),
(22, N'Pride and Prejudice', 'TG22', 'NX05', 'TL02', 35000, 50000, 23, 'pride_prejudice.jpg', 1),
(23, N'The Girl with the Dragon Tattoo', 'TG23', 'NX04', 'TL03', 47000, 69000, 24, 'dragon_tattoo.jpg', 1),
(24, N'IT', 'TG24', 'NX05', 'TL04', 53000, 79000, 25, 'it.jpg', 1),
(25, N'The Book Thief', 'TG25', 'NX04', 'TL05', 50000, 74000, 26, 'book_thief.jpg', 1),
(26, N'Yes Please', 'TG26', 'NX05', 'TL06', 49000, 73000, 27, 'yes_please.jpg', 1),
(27, N'The Martian', 'TG27', 'NX04', 'TL07', 55000, 79000, 28, 'martian.jpg', 1),
(28, N'Daring Greatly', 'TG28', 'NX05', 'TL08', 51000, 76000, 29, 'daring_greatly.jpg', 1),
(29, N'Salt, Fat, Acid, Heat', 'TG29', 'NX04', 'TL09', 52000, 77000, 30, 'salt_fat_acid_heat.jpg', 1),
(30, N'Where the Wild Things Are', 'TG30', 'NX05', 'TL10', 30000, 46000, 31, 'wild_things.jpg', 1),
(31, N'The Girl on the Train', 'TG31', 'NX04', 'TL11', 48000, 72000, 32, 'girl_on_train.jpg', 1),
(32, N'The Lean Startup', 'TG32', 'NX05', 'TL12', 52000, 77000, 33, 'lean_startup.jpg', 1),
(33, N'Zero to One', 'TG33', 'NX04', 'TL12', 49000, 74000, 34, 'zero_to_one.jpg', 1),
(34, N'Sapiens: A Brief History of Humankind', 'TG34', 'NX05', 'TL19', 58000, 82000, 35, 'sapiens.jpg', 1),
(35, N'Homo Deus: A Brief History of Tomorrow', 'TG35', 'NX04', 'TL19', 59000, 83000, 36, 'homo_deus.jpg', 1),
(36, N'21 Lessons for the 21st Century', 'TG36', 'NX05', 'TL19', 57000, 81000, 37, '21_lessons.jpg', 1),
(37, N'The World as I See It', 'TG37', 'NX04', 'TL19', 42000, 60000, 38, 'einstein_world.jpg', 1),
(38, N'The Road to Serfdom', 'TG38', 'NX05', 'TL19', 45000, 65000, 39, 'serfdom.jpg', 1),
(39, N'Capital in the Twenty-First Century', 'TG39', 'NX04', 'TL12', 55000, 80000, 40, 'capital_21c.jpg', 1),
(40, N'Thinking, Fast and Slow', 'TG40', 'NX05', 'TL11', 56000, 82000, 41, 'fast_slow.jpg', 1);


-- Chèn dữ liệu vào bảng NHAN_VIEN
INSERT INTO NHAN_VIEN (MA_NV, TEN_NV, MA_NQL, GIOITINH, SDT, EMAIL, DIACHI, LUONG, PASSWORD, TRANGTHAI)
VALUES 
('NV001', N'Nguyễn Văn C', NULL, 1, '0123456789', 'c@gmail.com', N'456 Đường MNO, Quận 5', 5000000, 123, 1),
('NV002', N'Trần Thị D', 'NV001', 0, '0987654321', 'd@gmail.com', N'789 Đường PQR, Quận 6', 6000000, 123, 1),
('NV003', N'Lê Văn E', 'NV001', 1, '0123456782', 'e@gmail.com', N'321 Đường STU, Quận 7', 5500000, 123, 1),
('NV004', N'Phạm Thị F', 'NV001', 0, '0987654323', 'f@gmail.com', N'654 Đường VWX, Quận 8', 5800000, 123, 1),
('NV005', N'Nguyễn Văn G', 'NV002', 1, '0123456784', 'g@gmail.com', N'852 Đường YZ, Quận 9', 6200000, 123, 1),
('NV006', N'Trần Thị H', 'NV002', 0, '0987654325', 'h@gmail.com', N'963 Đường AB, Quận 10', 6400000, 123, 1),
('NV007', N'Lê Văn I', 'NV002', 1, '0123456786', 'i@gmail.com', N'147 Đường CD, Quận 11', 6700000, 123, 1),
('NV008', N'Phạm Thị J', 'NV002', 0, '0987654327', 'j@gmail.com', N'258 Đường EF, Quận 12', 6900000, 123, 1),
('NV009', N'Nguyễn Văn K', 'NV003', 1, '0123456788', 'k@gmail.com', N'369 Đường GH, Quận 13', 7100000, 123, 1),
('NV010', N'Trần Thị L', 'NV003', 0, '0987654329', 'l@gmail.com', N'741 Đường IJ, Quận 14', 7300000, 123, 1);


INSERT INTO HOA_DON (MAHD, MANV, MAKH, TIENNHAN, TIENTRA, THANHTIEN, TRANGTHAI)
VALUES
('HD01', 'NV001', 'KH01', 300000, 280000, 280000, 1),
('HD02', 'NV002', 'KH02', 500000, 500000, 500000, 1),
('HD03', 'NV003', 'KH03', 450000, 420000, 420000, 1),
('HD04', 'NV001', 'KH04', 600000, 580000, 580000, 1),
('HD05', 'NV004', 'KH05', 320000, 320000, 320000, 1),
('HD06', 'NV005', 'KH06', 700000, 650000, 650000, 1),
('HD07', 'NV002', 'KH07', 400000, 400000, 400000, 1),
('HD08', 'NV003', 'KH08', 550000, 500000, 500000, 1),
('HD09', 'NV004', 'KH09', 600000, 600000, 600000, 1),
('HD10', 'NV001', 'KH10', 200000, 200000, 200000, 1),
('HD11', 'NV002', 'KH11', 350000, 340000, 340000, 1),
('HD12', 'NV003', 'KH12', 800000, 750000, 750000, 1),
('HD13', 'NV004', 'KH13', 270000, 270000, 270000, 1),
('HD14', 'NV005', 'KH14', 500000, 500000, 500000, 1),
('HD15', 'NV001', 'KH15', 620000, 600000, 600000, 1),
('HD16', 'NV002', 'KH16', 450000, 450000, 450000, 1),
('HD17', 'NV003', 'KH17', 380000, 360000, 360000, 1),
('HD18', 'NV004', 'KH18', 700000, 700000, 700000, 1),
('HD19', 'NV005', 'KH19', 1000000, 950000, 950000, 1),
('HD20', 'NV001', 'KH20', 250000, 250000, 250000, 1);

INSERT INTO CT_HOADON (MAHD, MASP, SOLUONG, DONGIA, KHUYENMAI, THANHTIEN)
VALUES
('HD11', 1, 2, 70000, 0.1, 2 * 70000 * (1 - 0.1)),
('HD11', 5, 1, 69000, 0.05, 1 * 69000 * (1 - 0.05)),
('HD02', 2, 3, 60000, 0.15, 3 * 60000 * (1 - 0.15)),
('HD02', 10, 1, 45000, 0.2, 1 * 45000 * (1 - 0.2)),
('HD03', 3, 2, 65000, 0.1, 2 * 65000 * (1 - 0.1)),
('HD03', 6, 1, 70000, 0.05, 1 * 70000 * (1 - 0.05)),
('HD04', 4, 1, 50000, 0.1, 1 * 50000 * (1 - 0.1)),
('HD04', 7, 2, 60000, 0.1, 2 * 60000 * (1 - 0.1)),
('HD05', 8, 1, 80000, 0.2, 1 * 80000 * (1 - 0.2)),
('HD05', 9, 1, 75000, 0.15, 1 * 75000 * (1 - 0.15)),
('HD06', 12, 2, 68000, 0.1, 2 * 68000 * (1 - 0.1)),
('HD06', 13, 1, 78000, 0.05, 1 * 78000 * (1 - 0.05)),
('HD07', 15, 1, 73000, 0.1, 1 * 73000 * (1 - 0.1)),
('HD07', 18, 1, 80000, 0.2, 1 * 80000 * (1 - 0.2)),
('HD08', 20, 1, 82000, 0.1, 1 * 82000 * (1 - 0.1)),
('HD08', 21, 2, 85000, 0.05, 2 * 85000 * (1 - 0.05)),
('HD09', 22, 1, 50000, 0.2, 1 * 50000 * (1 - 0.2)),
('HD09', 24, 2, 79000, 0.15, 2 * 79000 * (1 - 0.15)),
('HD10', 27, 1, 79000, 0.1, 1 * 79000 * (1 - 0.1)),
('HD10', 30, 1, 46000, 0.1, 1 * 46000 * (1 - 0.1));
