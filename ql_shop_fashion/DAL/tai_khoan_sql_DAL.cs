using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using BCrypt.Net;

namespace DAL
{
    public class tai_khoan_sql_DAL
    {
        QL_SHOP_DATADataContext data;
        passwordHelper passwordHelper;
        public tai_khoan_sql_DAL()
        {
            data = new QL_SHOP_DATADataContext();
            passwordHelper = new passwordHelper();
        }
        public bool CheckLogin(string tk, string mk, out int userRoleId)
        {
            // Tìm tài khoản theo tên đăng nhập
            var user = data.tai_khoans.FirstOrDefault(u => u.ten_dang_nhap == tk);
            
            // Kiểm tra nếu tài khoản tồn tại và đang hoạt động
            if (user != null && user.hoat_dong == true)
            {
                // Kiểm tra mật khẩu nhập vào có khớp với hash mật khẩu đã lưu hay không
                bool isPasswordCorrect = passwordHelper.VerifyPassword(mk, user.mat_khau_hash);



                if (isPasswordCorrect)
                {
                    // Lấy id_nhom_quyen từ bảng tai_khoan_nhom_quyen
                    var userGroup = data.tai_khoan_nhom_quyens
                        .FirstOrDefault(ug => ug.id_tai_khoan == user.id);

                    // Gán id_nhom_quyen cho userRoleId hoặc 0 nếu không tìm thấy
                    userRoleId = userGroup?.id_nhom_quyen ?? 0;
                    return true; // Đăng nhập thành công
                }
            }

            userRoleId = 0; // Gán 0 nếu không tìm thấy tài khoản hoặc mật khẩu không đúng
            return false; // Trả về false nếu tài khoản không hợp lệ hoặc mật khẩu sai
        }
        // Phương thức lấy danh sách màn hình mà người dùng có quyền truy cập
        public List<int> GetAccessibleScreens(int userRoleId, out string name)
        {
            // Lấy tên nhóm quyền từ cơ sở dữ liệu
            var roleName = data.nhom_quyens
                .Where(nq => nq.id_nhom_quyen == userRoleId)
                .Select(nq => nq.ten_nhom)
                .FirstOrDefault();

            // Gán tên nhóm quyền vào tham số out
            name = roleName;

            if (roleName == "Admin")
            {
                // Nếu là Admin, có quyền truy cập tất cả các màn hình
                return data.man_hinhs.Select(m => m.id_man_hinh).ToList();
            }
            else
            {
                // Nếu không phải Admin, chỉ có quyền truy cập các màn hình được cấp phép
                return data.phan_quyens
                    .Where(p => p.id_nhom_quyen == userRoleId && p.co_quyen == true)
                    .Select(p => p.id_man_hinh)
                    .ToList();
            }
        }


        public int get_id_nv_by_tk(string nametk)
        {
            var id = (from i in data.tai_khoans
                      join k in data.nhan_viens on i.id equals k.tai_khoan_id
                      where i.ten_dang_nhap == nametk
                      select k.ma_nhan_vien).FirstOrDefault();

            return id;
        }


    }
}
