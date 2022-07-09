-- Lấy thông tin khách hàng
CREATE PROCEDURE getInfoKhachHang(@MaKH INT)
AS
SELECT *
FROM KHACHHANG
WHERE MAKH = @MaKH;

-- Lấy thông tin nhân viên
CREATE PROCEDURE getInfoNhanVien (@MaNV INT)
AS
SELECT *
FROM NHANVIEN
WHERE MANV = @MaNV

-- EXEC getInfoKhachHang @MaKH = 123

-- Thêm khách hàng
CREATE PROCEDURE themKhachHang(@MaKH INT, @HoTen NVARCHAR(20), @GioiTinh NVARCHAR(3), @DIACHI NVARCHAR(50), @SDT CHAR(10), @NGAYSINH DATE)
AS
INSERT INTO KHACHHANG(MAKH, HOVATEN, GIOITINH, DIACHI, SDT, NGAYSINH) 
VALUES (@MaKH, @HoTen, @GioiTinh, @DIACHI, @SDT, @NGAYSINH);
GO;

-- DROP PROCEDURE themKhachHang
-- EXEC themKhachHang @MaKH = 123, @HoTen = N'Lê Bảo Chấn Phát', @GioiTinh = N'Nam', @DiaChi = N'82 Võ Trường Toản', @SDT = '0948013193', @NGAYSINH = '01/24/2001';
-- select * from KHACHHANG WHERE MAKH = 123;

CREATE PROCEDURE themPhieuDKTiem(@MaKH INT, @MaPhieu INT, @Goi NVARCHAR(50), @NgayTiem DATE, @TinhTrang NVARCHAR(10))
AS
BEGIN
	IF EXISTS(SELECT MAKH FROM KHACHHANG WHERE MAKH = @MaKH)
		IF EXISTS(SELECT MAPHIEU FROM PHIEUDKTIEM WHERE MAPHIEU = @MaPhieu)
			RAISERROR(N'Đã tồn tại phiếu',9,1);
	ELSE
		INSERT INTO PHIEUDKTIEM(MAKH, MAPHIEU, GOI, NGAYTIEM, TINHTRANG)
		VALUES (@MaKH, @MaPhieu, @Goi, @NgayTiem, @TinhTrang);
END;

-- DROP PROCEDURE themPhieuDKTiem
-- EXEC themPhieuDKTiem @MaKH = 123, @MaPhieu = 123, @Goi = N'Gói phụ nữ mang thai', @NgayTiem = '01/24/2022', @TinhTrang = N'CD'

CREATE PROCEDURE getLogin(@username INT, @password NVARCHAR(36))
AS
BEGIN
SELECT k.MAKH, k.SDT, n.MANV, n.SDT
FROM KHACHHANG k, NHANVIEN n
WHERE (k.MAKH = @username AND k.SDT = @password) OR (n.MANV = @username AND n.SDT = @password);
END;

-- EXEC getLogin @username = 123, @password = '123'

CREATE or ALTER PROCEDURE searchCustomer(@bar nvarchar(100))
AS
BEGIN
	SELECT * FROM KHACHHANG
	WHERE MAKH like '%' + @bar + '%' or
	HOVATEN like '%' + @bar + '%' or
	DIACHI like '%' + @bar + '%' or
	SDT like '%' + @bar + '%' or
	NGAYSINH like '%' + @bar + '%'
end
	
EXEC searchCustomer @bar = ''

--select * from NHANVIEN

--select * from NGUOIGIAMHO WHERE MANGH = 565742042

CREATE OR ALTER PROCEDURE  getGiamHo(@kh int)
AS
BEGIN
	SELECT * FROM NGUOIGIAMHO
	WHERE MANGH = @kh
END

--EXEC getGiamHo @kh = 565742042

CREATE OR ALTER PROCEDURE  getPhieuDk(@kh int)
AS
BEGIN
	SELECT * FROM PHIEUDKTIEM
	WHERE MAKH = @kh
END

--EXEC getPhieuDk @kh = 67280102

CREATE or ALTER PROCEDURE searchEmployee(@bar nvarchar(100))
AS
BEGIN
	SELECT * FROM NHANVIEN
	WHERE MANV like '%' + @bar + '%' or
	HOTEN like '%' + @bar + '%' or
	DIACHI like '%' + @bar + '%' or
	SDT like '%' + @bar + '%' or
	NGAYSINH like '%' + @bar + '%'
end

CREATE OR ALTER PROCEDURE  getBangCap(@kh int)
AS
BEGIN
	SELECT * FROM BANGCAP
	WHERE BC_MANV = @kh
END
SELECT * FROM NHANVIEN
CREATE OR ALTER PROCEDURE getdetailInfoNV(@nv int)
AS
BEGIN
	SELECT * FROM NHANVIEN NV JOIN TRUNGTAM TT ON (NV.TRUNGTAM = TT.STT)
	WHERE MANV = @nv
END

create procedure sp_THANHTOAN (@mahd int, @hinhthuc nvarchar(10), @thanhtien float, @thoigian datetime, @makh int, @maphieu int)
as
begin tran
	INSERT INTO DBO.HOADON (MAHD, HINHTHUCTHANHTOAN, THANHTIEN, THOIGIANTHANHTOAN,HD_MAKH, HD_MAPHIEU) VALUES (@mahd,@hinhthuc,@thanhtien,@thoigian,@makh, @maphieu)
	update PHIEUDKTIEM
	set TINHTRANG = N'2'
	where MAPHIEU = @maphieu
commit tran
return 0;
