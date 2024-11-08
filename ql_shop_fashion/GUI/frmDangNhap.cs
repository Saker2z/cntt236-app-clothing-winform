using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace GUI
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        QL_SHOP_DATADataContext dataContext;
        public frmDangNhap()
        {
            InitializeComponent();
            dataContext = new QL_SHOP_DATADataContext();
        }

        private void LoadGifToPictureBox()
        {
            string filePath = @"..\..\Resources\background_dn.gif";
            if (File.Exists(filePath)) // Kiểm tra xem file có tồn tại không
            {
                background.Image = Image.FromFile(filePath);
                background.SizeMode = PictureBoxSizeMode.StretchImage; // Để ảnh lấp đầy PictureBox

                var path = new System.Drawing.Drawing2D.GraphicsPath();
                int radius = 20;
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
                path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
                path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
                this.Region = new Region(path);

                frmMain main = new frmMain();
                main.FormClosed += (s, args) => Application.Exit();
            }
            else
            {
                MessageBox.Show("Không tìm thấy file GIF!");
            }
        }


        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            LoadGifToPictureBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }

        }

        private void dangnhap_Click(object sender, EventArgs e)
        {
            string tk = nhaptk.Text;
            string mk = nhapmk.Text;
            int userRoleId;

            // Kiểm tra tài khoản hợp lệ
            if (IsLoginValid(tk, mk, out userRoleId)) // Kiểm tra tài khoản hợp lệ
            {
                MessageBox.Show("Đăng nhập thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                frmMain main = new frmMain();

                // Lấy danh sách các màn hình người dùng có quyền truy cập
                var accessibleScreens = dataContext.phan_quyens
                    .Where(p => p.id_nhom_quyen == userRoleId && p.co_quyen == true)
                    .Select(p => p.id_man_hinh)
                    .ToList();

                // Kiểm tra nếu người dùng là Admin (giả sử userRoleId = 1 là Admin)
                if (userRoleId == 1) // Admin
                {
                    // Admin có quyền xem tất cả các màn hình
                    accessibleScreens = dataContext.man_hinhs.Select(m => m.id_man_hinh).ToList();
                }

                // Gọi phương thức để hiển thị các màn hình được phép
                main.ShowScreens(accessibleScreens);

                // Ẩn form đăng nhập
                this.Hide();

                // Đảm bảo đóng form đăng nhập khi form chính (frmMain) đóng
                main.FormClosed += (s, args) => this.Close();
                main.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private bool IsLoginValid(string tk, string mk, out int userRoleId)
        {
            // Tìm tài khoản theo tên đăng nhập và mật khẩu
            var user = dataContext.tai_khoans
                .FirstOrDefault(u => u.ten_dang_nhap == tk && u.mat_khau_hash == mk); // Thực tế nên hash mật khẩu

            if (user != null && user.hoat_dong == true)
            {
                // Lấy id_nhom_quyen từ bảng tai_khoan_nhom_quyen
                var userGroup = dataContext.tai_khoan_nhom_quyens
                    .FirstOrDefault(ug => ug.id_tai_khoan == user.id); // Thay id bằng cột id của tài khoản

                userRoleId = userGroup?.id_nhom_quyen ?? 0; // Gán id_nhom_quyen hoặc 0 nếu không tìm thấy
                return true;
            }

            userRoleId = 0; // Gán 0 nếu không tìm thấy tài khoản
            return false; // Trả về false nếu không hợp lệ
        }


    }
}