# QUẢN LÝ CỬA HÀNG SÁCH

## 1. Giới thiệu
Ứng dụng quản lý cửa hàng sách được xây dựng bằng C# Windows Forms, sử dụng SQL Server và LINQ.

## 2. Công nghệ sử dụng
- C# Windows Forms
- .NET Framework 4.7.2
- SQL Server / LocalDB
- LINQ to SQL
- RDLC Report
- VietQR

## 3. Thành viên nhóm DevUp

## 4. Cài đặt và chạy chương trình

### Bước 1: Cài đặt môi trường
- Visual Studio có hỗ trợ Windows Forms và .NET Framework 4.7.2.
- SQL Server hoặc SQL Server LocalDB.

### Bước 2: Tạo cơ sở dữ liệu
1. Mở SQL Server Management Studio (SSMS).
2. Kết nối đến SQL Server.
3. Mở file `Database_QuanLyNhaSach/QuanLyCuaHangSach_Full.sql`.
4. Thực thi toàn bộ script để tạo cơ sở dữ liệu và dữ liệu mẫu.

### Bước 3: Cấu hình kết nối
1. Mở solution `WindowsFormsApp2.slnx` bằng Visual Studio.
2. Build project.
3. Chạy ứng dụng.
4. Chọn chức năng cấu hình kết nối cơ sở dữ liệu tại màn hình đăng nhập.
5. Nhập Server và Database tương ứng với SQL Server trên máy.
6. Kiểm tra kết nối và lưu cấu hình.

### Bước 4: Đăng nhập
Sử dụng tài khoản demo được cung cấp trong cơ sở dữ liệu hoặc tài khoản do nhóm thiết lập.
admin || 123456
nhanvien || 123456

## 5. Chức năng chính
- Quản lý sách và thể loại.
- Quản lý khách hàng.
- Quản lý nhân viên và phân quyền.
- Quản lý nhà cung cấp.
- Nhập hàng.
- Bán hàng và lập hóa đơn.
- Tra cứu và in hóa đơn.
- Thanh toán QR.
- Báo cáo thống kê.

## 6. Source code
Repository GitHub: https://github.com/tranhoang19801123-hash/QuanLyCuaHangSach

