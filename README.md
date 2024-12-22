# Hệ thống quản lý cửa hàng bán quần áo

## Giới thiệu chung
Hệ thống quản lý cửa hàng bán quần áo là một giải pháp phần mềm toàn diện dành cho các cửa hàng kinh doanh quần áo, giúp quản lý các hoạt động hằng ngày như quản lý sản phẩm, kho hàng, đơn hàng, khách hàng, và doanh thu. Phần mềm cung cấp giao diện dễ sử dụng trên cả hai nền tảng:  
- **Website**: Cho phép quản lý từ xa, theo dõi doanh thu.  
- **WinForm**: Hỗ trợ quản lý tại cửa hàng như nhập hàng, xuất hàng, và bán hàng trực tiếp.

Mục tiêu của phần mềm là tối ưu hóa quy trình quản lý, giúp chủ cửa hàng dễ dàng kiểm soát và theo dõi hoạt động của cửa hàng một cách hiệu quả và chính xác.

## Thành viên
**Tên nhóm**: DTD  

| STT | Họ tên                | Chức vụ    |
|-----|-----------------------|------------|
| 1   | Võ Danh Dự            | Nhóm trưởng|
| 2   | Nguyễn Quốc Dương     | Thành viên |
| 3   | Trà Thị Thanh Trúc    | Thành viên |

## Sử dụng
- **.NET Framework** version 4.8
- **Visual Studio 2019**

## Dự án
### Hệ thống quản lý cửa hàng bán quần áo

**Mô tả dự án**:  
Phần mềm này được xây dựng để giúp các cửa hàng bán quần áo quản lý hiệu quả các hoạt động như quản lý sản phẩm, đơn hàng, khách hàng, và doanh thu. Người dùng có thể sử dụng cả hai nền tảng: website để quản lý từ xa và WinForm để quản lý trực tiếp tại cửa hàng.

### Yêu cầu
- **AI**: Chatbox.
- **Web**: ASP.NET MVC, LINQ  
- **Ngôn ngữ**: Javascript, C#  
- **Framework**: Bootstrap

### Nghiệp vụ

#### Website

| STT | Nghiệp vụ                                                                         | Phân công |
|-----|-----------------------------------------------------------------------------------|-----------|
| 1   | Xem thông tin sản phẩm (Trang chủ, chi tiết sản phẩm, đánh giá)                   |           |
| 2   | Mua hàng                                                                          |           |
| 3   | Đánh giá                                                                          |           |


#### WinForm

| STT | Nghiệp vụ                                                                         | Phân công |
|-----|-----------------------------------------------------------------------------------|-----------|
| 1   | Đăng nhập + đăng xuất                                                             |           |
| 2   | Quản lý sản phẩm (Thêm, sửa, xóa, tìm kiếm sản phẩm)                              |           |
| 3   | Quản lý đơn hàng (Xem đơn hàng, trạng thái đơn hàng)                              |           |
| 4   | Thanh toán                                                                        |           |
| 5   | Phân quyền                                                                        |           |
| 6   | Thống kê + báo cáo doanh thu                                                      |           |
| 7   | Quản lý sản phẩm yêu thích                                                        |           |


## Chi tiết
- **Web**: ASP.NET MVC với LINQ để quản lý các nghiệp vụ liên quan đến sản phẩm và khách hàng từ xa.
- **WinForm**: Sử dụng cho các nghiệp vụ quản lý trực tiếp tại cửa hàng, bao gồm quản lý kho và thanh toán.
