using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        UC_NhapHangTheoNCC nhapHangTheoNCC;
        UC_NhapHangTheoSanPham nhapHangTheoSanPham;
        UC_TaiKhoan taiKhoan;
        UC_SanPham sanPham;
        NCC_NCCSP nCC_NCCSP;
        UC_NhanVien uc_nv;
        UC_Quyen quyen;
        NCC_NCCSP ncc_sp;
        frmNhapHang nhapHang;

        public frmMain()
        {
            InitializeComponent();
            ace_nhanvien.Click += Ace_nhanvien_Click;
            ace_taikhoan.Click += Ace_taikhoan_Click;
            ace_thongtincanhan.Click += Ace_thongtincanhan_Click;
            ace_nhacungcap.Click += Ace_nhacungcap_Click;
            ace_hoadon.Click += Ace_hoadon_Click;

        }

        private void Ace_hoadon_Click(object sender, EventArgs e)
        {
            pn_main.Controls.Clear();

            // Tạo instance của UC_NhanVien và thêm vào pn_main
            nhapHang = new frmNhapHang(Properties.Settings.Default.id_user_login);
            nhapHang.Dock = DockStyle.Fill; // Đặt dock nếu muốn chiếm toàn bộ diện tích panel
            nhapHang.Show();
            // Thêm UC_NhanVien vào panel pn_main
        }

        private void Ace_nhacungcap_Click(object sender, EventArgs e)
        {
            pn_main.Controls.Clear();

            // Tạo instance của UC_NhanVien và thêm vào pn_main
            ncc_sp = new NCC_NCCSP();
            ncc_sp.Dock = DockStyle.Fill; // Đặt dock nếu muốn chiếm toàn bộ diện tích panel

            pn_main.Controls.Add(ncc_sp); // Thêm UC_NhanVien vào panel pn_main
        }

        private void Ace_thongtincanhan_Click(object sender, EventArgs e)
        {
            pn_main.Controls.Clear();

            // Tạo instance của UC_NhanVien và thêm vào pn_main
            quyen = new UC_Quyen();
            quyen.Dock = DockStyle.Fill; // Đặt dock nếu muốn chiếm toàn bộ diện tích panel

            pn_main.Controls.Add(quyen); // Thêm UC_NhanVien vào panel pn_main
        }

        private void Ace_taikhoan_Click(object sender, EventArgs e)
        {
            pn_main.Controls.Clear();

            // Tạo instance của UC_NhanVien và thêm vào pn_main
            taiKhoan = new UC_TaiKhoan(Properties.Settings.Default.name_role);
            taiKhoan.Dock = DockStyle.Fill; // Đặt dock nếu muốn chiếm toàn bộ diện tích panel

            pn_main.Controls.Add(taiKhoan); // Thêm UC_NhanVien vào panel pn_main
        }

        private void Ace_nhanvien_Click(object sender, EventArgs e)
        {
            // Kiểm tra và xóa các control hiện có trên panel (nếu muốn thay thế hoàn toàn)
            pn_main.Controls.Clear();

            // Tạo instance của UC_NhanVien và thêm vào pn_main
            uc_nv = new UC_NhanVien(Properties.Settings.Default.name_role);
            uc_nv.Dock = DockStyle.Fill; // Đặt dock nếu muốn chiếm toàn bộ diện tích panel

            pn_main.Controls.Add(uc_nv); // Thêm UC_NhanVien vào panel pn_main
        }


        public void ShowScreens(List<int> accessibleScreens)
        {
            // Gọi phương thức đệ quy để xử lý hiển thị quyền truy cập cho tất cả các phần tử
            SetElementVisibility(ac_thongtin.Elements, accessibleScreens);
        }

        // Phương thức đệ quy để duyệt qua các AccordionControlElement và các phần tử con
        private void SetElementVisibility(AccordionControlElementCollection elements, List<int> accessibleScreens)
        {
            foreach (AccordionControlElement element in elements)
            {
                if (element != null && element.Tag != null)
                {
                    // Lấy id_man_hinh từ Tag của AccordionControlElement
                    int elementId = Convert.ToInt32(element.Tag);

                    // Kiểm tra quyền truy cập
                    element.Visible = accessibleScreens.Contains(elementId);
                }
                else
                {
                    // Nếu không có Tag hoặc là null, ẩn phần tử
                    element.Visible = false;
                }

                // Kiểm tra nếu phần tử có các phần tử con (sub-elements)
                if (element.Elements.Count > 0)
                {
                    // Đệ quy gọi lại phương thức SetElementVisibility cho các phần tử con
                    SetElementVisibility(element.Elements, accessibleScreens);
                }
            }
        }

     
    }
}
