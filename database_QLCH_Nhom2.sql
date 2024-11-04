CREATE DATABASE DOAN_QLCHQA;
GO
USE DOAN_QLCHQA;


-- Tạo bảng nhà cung cấp
CREATE TABLE NhaCungCap (
    MaNhaCungCap INT PRIMARY KEY,
    TenNhaCungCap VARCHAR(255) NOT NULL,
    DiaChi VARCHAR(255),
    DienThoai VARCHAR(20)
);

-- Tạo bảng loại sản phẩm
CREATE TABLE LoaiSanPham (
    MaLoai INT PRIMARY KEY,
    TenLoai VARCHAR(255) NOT NULL
);

-- Tạo bảng danh mục
CREATE TABLE DanhMuc (
    MaDanhMuc INT PRIMARY KEY,
    TenDanhMuc VARCHAR(255) NOT NULL,
    MoTa VARCHAR(255)
);

-- Tạo bảng kích thước
CREATE TABLE KichThuoc (
    MaKichThuoc INT PRIMARY KEY,
    TenKichThuoc VARCHAR(50) NOT NULL
);

-- Tạo bảng màu sắc
CREATE TABLE MauSac (
    MaMauSac INT PRIMARY KEY,
    TenMauSac VARCHAR(50) NOT NULL
);

-- Tạo bảng sản phẩm
CREATE TABLE SanPham (
    MaSanPham INT PRIMARY KEY,
    TenSanPham VARCHAR(255) NOT NULL,
    MaLoai INT,
    MaDanhMuc INT,
    ThuongHieu VARCHAR(255),
    HinhAnh VARCHAR(255),
    GiaBan DECIMAL(10, 2) NOT NULL,
    GiaNhap DECIMAL(10, 2) NOT NULL,
    GiamGia DECIMAL(5, 2) DEFAULT 0,
    FOREIGN KEY (MaLoai) REFERENCES LoaiSanPham(MaLoai),
    FOREIGN KEY (MaDanhMuc) REFERENCES DanhMuc(MaDanhMuc)
);

-- Tạo bảng chi tiết sản phẩm
CREATE TABLE ChiTietSanPham (
    MaChiTiet INT PRIMARY KEY,
    MaSanPham INT,
    MaKichThuoc INT,
    MaMauSac INT,
    SoLuong INT DEFAULT 0,
    FOREIGN KEY (MaSanPham) REFERENCES SanPham(MaSanPham),
    FOREIGN KEY (MaKichThuoc) REFERENCES KichThuoc(MaKichThuoc),
    FOREIGN KEY (MaMauSac) REFERENCES MauSac(MaMauSac)
);

-- Tạo bảng khách hàng
CREATE TABLE KhachHang (
    MaKhachHang INT PRIMARY KEY,
    TenKhachHang VARCHAR(255) NOT NULL,
    DienThoai VARCHAR(20),
    DiaChi VARCHAR(255),
    DiemThuong INT DEFAULT 0
);

-- Tạo bảng nhân viên
CREATE TABLE NhanVien (
    MaNhanVien INT PRIMARY KEY,
    TenNhanVien VARCHAR(255) NOT NULL,
    ChucVu VARCHAR(50),
    Sdt VARCHAR(255),
    DiaChi VARCHAR(255),
    NgayVaoLam DATE
);

-- Tạo bảng khuyến mãi
CREATE TABLE KhuyenMai (
    MaKhuyenMai INT PRIMARY KEY,
    Ten VARCHAR(255) NOT NULL,
    GiaTri DECIMAL(10, 2) NOT NULL,
    ThoiGianBatDau DATE,
    ThoiGianKetThuc DATE,
    SoLuong INT,
    TinhTrang VARCHAR(50),
    GhiChu VARCHAR(255)
);
--24/09/2024--Thêm vài thuộc tính
-- Tạo bảng hóa đơn
CREATE TABLE HoaDon (
    MaHoaDon INT PRIMARY KEY,
    MaKhachHang INT,
    MaNhanVien INT,
    NgayLap DATETIME,
    TongGiaTri DECIMAL(10, 2) NOT NULL,
    MaKhuyenMai INT,
    TienGiam DECIMAL(10, 2) DEFAULT 0,
    --TrangThai VARCHAR(50),--Cho là trạng thái đổi trả chưa(sẽ có 2 trường hợp là bình thường và đã đổi,
-- khi đổi hàng sẽ chuyển trạng thái từ BT sang Đã đổi,nếu trạng thái là đã đổi thì không cho đổi hàng nữa)
    HinhThucThanhToan NVARCHAR(50),
    TongSoLuongMua INT,
    --NgayDoiTra DATETIME,
    --TongTienSauKhiDoi DECIMAL(10, 2) DEFAULT NULL,
    FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKhachHang),
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien),
    FOREIGN KEY (MaKhuyenMai) REFERENCES KhuyenMai(MaKhuyenMai)
);

-- Tạo bảng chi tiết hóa đơn
CREATE TABLE ChiTietHoaDon (
    MaHoaDon INT,
    MaChiTiet INT,
    DoLuong INT NOT NULL,
    Gia DECIMAL(10, 2) NOT NULL,
    ThanhTien DECIMAL(10, 2),
--  TrangThai VARCHAR(50),(mặc định sẽ là "bình thường" là lúc mua thêm vô, trả sẽ chuyển thành "trả",
--nếu sản phẩm được thêm vô lúc trả để mua sản phẩm mới thì chuyển là "đổi".
    PRIMARY KEY (MaHoaDon, MaChiTiet),
    FOREIGN KEY (MaHoaDon) REFERENCES HoaDon(MaHoaDon),
    FOREIGN KEY (MaChiTiet) REFERENCES ChiTietSanPham(MaChiTiet)
);

-- Tạo bảng nhập kho
CREATE TABLE NhapHang (
    MaNhapHang INT PRIMARY KEY,
    MaNhanVien INT,
    MaNhaCungCap INT,
    NgayNhap DATE NOT NULL,
    TrangThai VARCHAR(50),
    GhiChu VARCHAR(255),
    TongSoLuong INT NOT NULL,
    TongGiaTien DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (MaNhaCungCap) REFERENCES NhaCungCap(MaNhaCungCap),
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)
);

-- Tạo bảng chi tiết nhập kho
CREATE TABLE ChiTietNhapHang (
    MaNhapHang INT,
    MaChiTiet INT,
    SoLuong INT NOT NULL,
    GiaNhap DECIMAL(10, 2) NOT NULL,
    PRIMARY KEY (MaNhapHang, MaChiTiet),
    FOREIGN KEY (MaNhapHang) REFERENCES NhapHang(MaNhapHang),
    FOREIGN KEY (MaChiTiet) REFERENCES ChiTietSanPham(MaChiTiet)
);

-- Tạo bảng tài khoản
CREATE TABLE TaiKhoan (
    TenDangNhap VARCHAR(255) NOT NULL UNIQUE,
    MatKhauHash VARCHAR(255) NOT NULL,
    VaiTro VARCHAR(50)
);

