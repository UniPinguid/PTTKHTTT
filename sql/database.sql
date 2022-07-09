--DROP DATABASE AnBinh
create database AnBinh
GO
USE AnBinh
GO
--NHANVIEN
CREATE TABLE NHANVIEN (
	MANV INT,
	HOTEN NVARCHAR(30),
	NGAYSINH DATE,
	CMND CHAR(15),
	SDT CHAR(10),
	EMAIL VARCHAR(25),
	DIACHI NVARCHAR(50),
	VITRI NVARCHAR(20),
	LUONG FLOAT,
	VAITRO NVARCHAR(20),
	TRUNGTAM INT,
	SOBUOITRUCTOITHIEU INT,
	PRIMARY KEY (MANV)
);

CREATE TABLE TRUNGTAM (
	STT INT,
	DIACHI NVARCHAR(50),
	NGAYBATDAU DATE,
	PRIMARY KEY (STT)
);

ALTER TABLE NHANVIEN
ADD CONSTRAINT FK_TRUNGTAM_NHANVIEN FOREIGN KEY (TRUNGTAM) REFERENCES TRUNGTAM(STT);

CREATE TABLE BANGCAP(
	BC_MANV INT NOT NULL,
	MABANGCAP INT NOT NULL,
	TENBANG NVARCHAR(20),
	NOICAP NVARCHAR(20),
	CAPBAC NVARCHAR(20),
	LINHVUC NVARCHAR(20)
);

ALTER TABLE BANGCAP
ADD CONSTRAINT FK_NHANVIEN_BANGCAP FOREIGN KEY (BC_MANV) REFERENCES NHANVIEN(MANV);

ALTER TABLE BANGCAP
ADD CONSTRAINT PK_BANGCAP PRIMARY KEY (BC_MANV, MABANGCAP);


CREATE TABLE LICHLAMVIEC(
	MALICHLV INT NOT NULL,
	NGAYBATDAU DATE,
	NGAYKETTHUC DATE,
	THOIGIANTAO DATETIME,
	LV_MANV INT NOT NULL,
);

ALTER TABLE LICHLAMVIEC
ADD CONSTRAINT FK_NHANVIEN_LICHLAMVIEC FOREIGN KEY (LV_MANV) REFERENCES NHANVIEN(MANV);
ALTER TABLE LICHLAMVIEC
ADD CONSTRAINT PK_LICHLAMVIEC PRIMARY KEY (MALICHLV);


CREATE TABLE LICHCATRUC(
	MACATRUC INT NOT NULL,
	MALICHLV INT NOT NULL,
	NGAY DATE,
	THU NVARCHAR(10),
	BUOI NVARCHAR(6),
);

ALTER TABLE LICHCATRUC
ADD CONSTRAINT FK_LICHLAMVIEC_LICHCATRUC FOREIGN KEY (MALICHLV) REFERENCES LICHLAMVIEC(MALICHLV);

ALTER TABLE LICHCATRUC
ADD CONSTRAINT PK_LICHCATRUC PRIMARY KEY (MACATRUC, MALICHLV);

create table PHANCONG (
	MACATRUC int not null,
	MALLV int not null,
	MANV int not null
);

alter table PHANCONG
add constraint pk_phancong primary key (MACATRUC,MALLV,MANV);

alter table PHANCONG
add constraint fk_lichcatruc foreign key (MACATRUC, MALLV) references lichcatruc(MACATRUC, MALICHLV);

alter table PHANCONG
add constraint fk_nhanvien foreign key (MANV) references nhanvien(MANV);

CREATE TABLE LICHRANH(
	MALICHRANH INT NOT NULL, --ADDED TO USE CHITIETLICHRANH
	THOIGIANDANGKY DATETIME,
	NGAYBATDAU DATE,
	NGAYKETTHUC DATE,
	LR_MANV INT NOT NULL,
	SOBUOIRANH INT
);


ALTER TABLE LICHRANH
ADD CONSTRAINT FK_NHANVIEN_LICHRANH FOREIGN KEY (LR_MANV) REFERENCES NHANVIEN(MANV);
ALTER TABLE LICHRANH
ADD CONSTRAINT PK_LICHRANH PRIMARY KEY (MALICHRANH);


CREATE TABLE CHITIETLICHRANH(
	SOTHUTU INT NOT NULL,
	MALICHRANH INT NOT NULL,
	THU NVARCHAR(8),
	NGAY DATE,
	CA NVARCHAR(6),

);

ALTER TABLE CHITIETLICHRANH
ADD CONSTRAINT FK_LICHRANH_CHITIET FOREIGN KEY (MALICHRANH) REFERENCES LICHRANH(MALICHRANH)

ALTER TABLE CHITIETLICHRANH
ADD CONSTRAINT PK_CTLICHRANH PRIMARY KEY (SOTHUTU, MALICHRANH);
--KHACHHANG

CREATE TABLE KHACHHANG(
	MAKH INT,
	HOVATEN NVARCHAR(20),
	GIOITINH NVARCHAR(3),
	DIACHI NVARCHAR(50),
	SDT CHAR(10),
	NGAYSINH DATE,
	PRIMARY KEY (MAKH)
);

CREATE TABLE NGUOIGIAMHO(
	MANGH INT,
	TEN_NGH VARCHAR(30),
	MQH VARCHAR(10),
	SDTGIAMHO CHAR(10)
);

ALTER TABLE NGUOIGIAMHO
ADD CONSTRAINT FK_KHACHHANG_NGUOIGIAMHO FOREIGN KEY (MANGH) REFERENCES KHACHHANG(MAKH);

CREATE TABLE VACCINE(
	MAVACCINE INT,
	TENVACCINE NVARCHAR(15),
	SOLUONG INT,
	PRIMARY KEY (MAVACCINE)
);

CREATE TABLE LOVACCINE(
	MALO INT NOT NULL,
	LO_MAVACCINE INT,
	NGAYNHAP DATE,
	SOLIEUCONLAI INT,
	HANSUDUNG DATE,
	--PRIMARY KEY (MALO)
);

ALTER TABLE LOVACCINE
ADD CONSTRAINT FK_VACCINE_LOVACCINE FOREIGN KEY (LO_MAVACCINE) REFERENCES VACCINE(MAVACCINE);

ALTER TABLE LOVACCINE 
ADD CONSTRAINT PK_LOVACCINE PRIMARY KEY (MALO)

CREATE TABLE PHIEUDKTIEM(
	MAKH INT NOT NULL,
	MAPHIEU INT NOT NULL,
	GOI NVARCHAR(50),
	NGAYTIEM DATE,
	TINHTRANG NVARCHAR(10)
)

ALTER TABLE PHIEUDKTIEM
ADD CONSTRAINT FK_KHACHHANG_PHIEUDK FOREIGN KEY (MAKH) REFERENCES KHACHHANG(MAKH);
ALTER TABLE PHIEUDKTIEM
ADD CONSTRAINT PK_PHIEUDKTIEM PRIMARY KEY (MAKH,MAPHIEU)
CREATE TABLE TIEMLE(
	TL_MAKH INT NOT NULL,
	MAPHIEU INT NOT NULL,
	THOIGIANTIEM DATETIME,
	MAVACCINE INT
)
ALTER TABLE TIEMLE 
ADD CONSTRAINT FK_PHIEUDK_TIEMLE FOREIGN KEY (TL_MAKH, MAPHIEU) REFERENCES PHIEUDKTIEM(MAKH, MAPHIEU)

ALTER TABLE TIEMLE
ADD CONSTRAINT PK_TIEMLE PRIMARY KEY (TL_MAKH, MAPHIEU)

CREATE TABLE HOADON(
	MAHD INT,
	HINHTHUCTHANHTOAN NVARCHAR(15),
	THANHTIEN FLOAT,
	THOIGIANTHANHTOAN DATETIME, --THOI GIAN HAY THOI DIEM?
	HD_MAKH INT,
	HD_MAPHIEU INT,
	PRIMARY KEY (MAHD)
);

ALTER TABLE HOADON
ADD CONSTRAINT FK_PHIEUDK_HOADON FOREIGN KEY (HD_MAKH,HD_MAPHIEU) REFERENCES PHIEUDKTIEM(MAKH, MAPHIEU);




CREATE TABLE PHIEUNHAPHANG(
	MAPHIEU INT NOT NULL,
	NH_MAVACCINE INT,
	NHACUNGCAP NVARCHAR(100),
	SOLUONG INT,
	PRIMARY KEY (MAPHIEU)
);

ALTER TABLE PHIEUNHAPHANG
ADD CONSTRAINT FK_VACCINE_PHIEUNHAPHANG FOREIGN KEY (NH_MAVACCINE) REFERENCES VACCINE(MAVACCINE);

CREATE TABLE PHIEUDATMUA(
	MAPHIEUMUA INT,
	DM_MAVACCINE INT,
	PRIMARY KEY (MAPHIEUMUA)
);
ALTER TABLE PHIEUDATMUA
ADD CONSTRAINT FK_VACCINE_PHIEUDATMUA FOREIGN KEY (DM_MAVACCINE) REFERENCES VACCINE(MAVACCINE);

CREATE TABLE BAOCAOTIEMNGUA(
	BCTN_MAKH INT NOT NULL,
	STT INT NOT NULL,
	NGAYTIEM DATE,
	BCTN_MAVACCINE INT,
	BCTN_MALO INT,
	TRIEUCHUNG NVARCHAR(100)
);

ALTER TABLE BAOCAOTIEMNGUA
ADD CONSTRAINT FK_KHACHHANG_BAOCAO FOREIGN KEY (BCTN_MAKH) REFERENCES KHACHHANG(MAKH);

ALTER TABLE BAOCAOTIEMNGUA
ADD CONSTRAINT FK_VACCINE_BAOCAO FOREIGN KEY (BCTN_MAVACCINE) REFERENCES VACCINE(MAVACCINE);

ALTER TABLE BAOCAOTIEMNGUA
ADD CONSTRAINT FK_LOVACCINE_BAOCAO FOREIGN KEY (BCTN_MALO) REFERENCES LOVACCINE(MALO);

ALTER TABLE BAOCAOTIEMNGUA
ADD CONSTRAINT PK_BAOCAO PRIMARY KEY (BCTN_MAKH, STT) 
--need help on this constraint :(

alter table VACCINE add DONGIA INT;

create table GOITIEMCHUNG (
	TEN_GTC NVARCHAR(50),
	MOTA NVARCHAR(100),
	DONGIA INT,
	CONSTRAINT PK_GOITIEMCHUNG PRIMARY KEY (TEN_GTC))

alter table PHIEUDKTIEM
add constraint FK_PHIEUDK_GOITC
foreign key (GOI)
references GOITIEMCHUNG(TEN_GTC)

create table CHITIETGOITC (
	TEN_GTC NVARCHAR(10),
	MAVACCINE INT,
	SOMUI INT,
	CONSTRAINT PK_CHITIETGTC PRIMARY KEY (TEN_GTC,MAVACCINE))

alter table CHITIETGOITC
add constraint FK_CHITIETGTC_VACCINE
foreign key (MAVACCINE)
references VACCINE(MAVACCINE)