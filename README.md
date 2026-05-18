# App-quan-ly-chi-tieu-winform-app-
Lập trình .net
# 💰 Hệ Thống Quản Lý Chi Tiêu Cá Nhân (Expense Manager App)

Một ứng dụng Desktop Application được xây dựng bằng **C# .NET WinForms**, giúp người dùng theo dõi và quản lý dòng tiền cá nhân một cách trực quan, chi tiết và chính xác. 

Đồ án được phát triển nhằm đáp ứng các yêu cầu của môn học Lập trình .NET, ứng dụng mô hình kiến trúc phân lớp (3-Tier Architecture) và quản trị cơ sở dữ liệu qua SQL Server.

## 🚀 Các chức năng nổi bật (Core Features)

1. **Quản lý Tài Khoản/Ví (Payment Methods):**
   - Thêm, Sửa, Xóa các tài khoản/ví (Tiền mặt, Thẻ ngân hàng, MoMo...).
   - Hiển thị số dư hiện tại của từng ví theo thời gian thực.
2. **Quản lý Danh Mục Chi Tiêu (Categories):**
   - Phân loại rõ ràng 2 luồng tiền: `Income` (Thu) và `Expense` (Chi).
   - Cho phép định nghĩa không giới hạn các danh mục (Lương, Ăn uống, Giải trí...).
3. **Quản lý Giao Dịch (Transactions):**
   - Ghi nhận giao dịch với đầy đủ thông tin: Số tiền, Ngày tháng, Danh mục, Ví thực hiện, và Ghi chú.
   - **Đặc biệt:** Tích hợp logic tự động cộng/trừ số dư trong Ví khi một giao dịch được Thêm, Sửa, hoặc Xóa (Hoàn tác số dư).
4. **Tìm Kiếm Nâng Cao:**
   - Lọc giao dịch kết hợp theo **Khoảng thời gian** (Từ ngày - Đến ngày) và **Danh mục**.
5. **Báo Cáo & Thống Kê (Statistics):**
   - Trích xuất báo cáo thu chi chi tiết theo từng tháng/năm.
   - Hệ thống tự động tính toán tổng Thu, tổng Chi và Số dư lũy kế từ đầu đến hiện tại.

## 🛠 Nền tảng Công nghệ (Tech Stack)

- **Ngôn ngữ lập trình:** C#
- **Framework:** .NET 8 (Windows Forms)
- **Cơ sở dữ liệu:** Microsoft SQL Server
- **Thư viện phụ thuộc:** `Microsoft.Data.SqlClient` (Truy xuất DB)
- **Kiến trúc phần mềm:** Mô hình phân lớp (Data Access Layer, Business Logic Layer, UI Presentation Layer, DTOs).

## 📂 Hướng dẫn cài đặt và khởi chạy (Installation)

Để chạy dự án trên máy tính cá nhân hoặc máy tính của giảng viên, vui lòng làm theo các bước sau:

**Bước 1: Cài đặt Cơ sở dữ liệu**
1. Mở SQL Server Management Studio (SSMS).
2. Chạy đoạn script trong file `DatabaseScript.sql` (hoặc đính kèm file `.mdf`) để khởi tạo Database `ExpenseManagerDB` và các bảng dữ liệu mẫu.
```sql
CREATE DATABASE ExpenseManagerDB;
GO
USE ExpenseManagerDB;
GO

-- 1. Category Table
CREATE TABLE Category (
    CategoryID INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Type NVARCHAR(50) NOT NULL -- 'Income' or 'Expense'
);

-- 2. PaymentMethod Table (Sub Data Management)
CREATE TABLE PaymentMethod (
    MethodID INT IDENTITY(1,1) PRIMARY KEY,
    MethodName NVARCHAR(100) NOT NULL,
    Balance DECIMAL(18,2) NOT NULL DEFAULT 0 -- Cột lưu số dư hiện tại của ví
);

-- 3. Transaction Table
CREATE TABLE [Transaction] (
    TransactionID INT IDENTITY(1,1) PRIMARY KEY,
    TransactionDate DATETIME NOT NULL,
    Amount DECIMAL(18,2) NOT NULL,
    CategoryID INT FOREIGN KEY REFERENCES Category(CategoryID),
    MethodID INT FOREIGN KEY REFERENCES PaymentMethod(MethodID),
    Notes NVARCHAR(255),
    UserName NVARCHAR(100)
);

-- Insert Sample Data
INSERT INTO Category (Name, Type) VALUES (N'Food', 'Expense'), (N'Salary', 'Income'), (N'Utilities', 'Expense');
INSERT INTO PaymentMethod (MethodName, Balance) VALUES (N'Cash', 5000000), (N'Bank Transfer', 15000000);
INSERT INTO [Transaction] (TransactionDate, Amount, CategoryID, MethodID, Notes, UserName) VALUES 
(GETDATE(), 50000, 1, 1, N'Lunch', 'Duy Nguyen'),
(GETDATE(), 10000000, 2, 2, N'Monthly Salary', 'Duy Nguyen');
```
**Bước 2: Cấu hình kết nối (Chuỗi kết nối)**
1. Mở solution `ExpenseManagerApp.slnx` bằng Visual Studio.
2. Mở file `DatabaseConnection.cs`.
3. Thay đổi thông tin `Server=...` trong chuỗi kết nối (`connectionString`) cho khớp với tên Server SQL trên máy của bạn.

**Bước 3: Cài đặt thư viện và Khởi chạy**
1. Tại Visual Studio, chuột phải vào Solution -> Chọn `Restore NuGet Packages` để tải thư viện `Microsoft.Data.SqlClient`.
2. Chuyển chế độ Build sang **Release** (hoặc Debug).
3. Nhấn `Ctrl + Shift + B` để Build dự án.
4. Nhấn `F5` hoặc chạy file `ExpenseManagerApp.exe` trong thư mục `bin/Release/net8.0-windows` để bắt đầu sử dụng.

## 👥 Nhóm phát triển (Đội ngũ)

- **Nguyễn Đức Duy** (Nhóm trưởng) - *Kiến trúc hệ thống, Lập trình chức năng lõi & Giao diện, Kết nối CSDL.*
- **[Tên Thành Viên 2]** - *Thiết kế CSDL (ERD), Quản lý dữ liệu danh mục/ví & Kiểm thử hệ thống.*
- **[Tên Thành Viên 3]** - *Phân tích nghiệp vụ, Vẽ thiết kế UI & Viết tài liệu đặc tả.*
