using System;
using System.Linq;
using DTO;

namespace DAL
{
    public class nhan_vien_sql_DAL
    {
        private QL_SHOP_DATADataContext data;

        public nhan_vien_sql_DAL()
        {
            data = new QL_SHOP_DATADataContext();
        }

        public bool add_nv_tk_user(nhan_vien a, string tenNhomQuyen)
        {
            try
            {
                // 1. Thêm nhân viên vào bảng nhan_vien
                data.nhan_viens.InsertOnSubmit(a);
                data.SubmitChanges();

                // Lấy ID của nhân viên vừa thêm (được tự động tạo trong cơ sở dữ liệu)
                int maNhanVien = a.ma_nhan_vien;

                // 2. Tạo tên đăng nhập và mật khẩu tự động cho nhân viên
                string tenDangNhap = $"user"+a.ma_nhan_vien;
               
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(tenDangNhap);

                // 3. Tạo tài khoản cho nhân viên trong bảng tai_khoan
                var taiKhoan = new tai_khoan
                {
                    ten_dang_nhap = tenDangNhap,
                    mat_khau_hash = hashedPassword,
                    hoat_dong = true,
                    is_oauth = false
                };
                data.tai_khoans.InsertOnSubmit(taiKhoan);
                data.SubmitChanges();

                // Lấy ID của tài khoản vừa thêm
                int idTaiKhoan = taiKhoan.id;

                // 4. Gán tài khoản với nhân viên
                a.tai_khoan_id = idTaiKhoan;
                data.SubmitChanges();

                // 5. Lấy ID của nhóm quyền dựa trên tên nhóm quyền
                var nhomQuyen = data.nhom_quyens.FirstOrDefault(nq => nq.ten_nhom == tenNhomQuyen);
                if (nhomQuyen == null)
                {
                    throw new Exception("Tên nhóm quyền không tồn tại.");
                }

                int idNhomQuyen = nhomQuyen.id_nhom_quyen;

                // 6. Gán quyền cho tài khoản trong bảng tai_khoan_nhom_quyen
                var taiKhoanNhomQuyen = new tai_khoan_nhom_quyen
                {
                    id_tai_khoan = idTaiKhoan,
                    id_nhom_quyen = idNhomQuyen,
                    create_at = DateTime.Now
                };
                data.tai_khoan_nhom_quyens.InsertOnSubmit(taiKhoanNhomQuyen);
                data.SubmitChanges();

                return true; // Thêm thành công
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                Console.WriteLine($"Lỗi khi thêm nhân viên và tài khoản: {ex.Message}");
                return false; // Thêm thất bại
            }
        }
    }
}
