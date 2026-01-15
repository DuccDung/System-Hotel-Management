# SystemHotelManagement (WinForms PMS)

Hệ thống quản lý khách sạn (**Property Management System – PMS**) được xây dựng bằng **WinForms (.NET 9)**, hỗ trợ đầy đủ các nghiệp vụ cơ bản của khách sạn.

## Tính năng chính

- **Quản lý phòng**
  - Phòng trống
  - Phòng đang sử dụng
  - Phòng đã đặt trước
  - Phòng bảo trì
- **Đặt phòng**
  - Booking
  - Check-in
  - Check-out
- **Quản lý khách hàng**
  - Khách lẻ
  - Hội viên
- **Quản lý nhân viên**
  - Thông tin nhân viên
  - Tài khoản đăng nhập
- **Quản lý dịch vụ phát sinh**
- **Thu / Chi – Doanh thu – Lợi nhuận**
  - Dựa trên `Payments` & `CashTransactions`

---

## 1️ Yêu cầu môi trường

- **Hệ điều hành**: Windows 10 / 11  
- **IDE**: Visual Studio 2022 (khuyến nghị bản mới nhất)  
- **.NET SDK**: 9.0  
  - Target framework: `net9.0-windows`
- **Cơ sở dữ liệu**: SQL Server  
  - Express / Developer / Standard đều dùng được
- **Công cụ quản lý DB**: SQL Server Management Studio (SSMS)

---

## 2️ Cấu trúc thư mục (tham khảo)

```text
SystemHotelManagement/
├─ assets/
│  └─ logo.png
├─ View/
│  ├─ FrmLogin.cs
│  └─ ...
├─ Scripts/
│  └─ SystemHotelManagement.sql
└─ SystemHotelManagement.csproj
