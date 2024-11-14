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

        public frmMain()
        {
            InitializeComponent();
            ace_nhanvien.Click += Ace_nhanvien_Click;

        }

        private void Ace_nhanvien_Click(object sender, EventArgs e)
        {
            // Kiểm tra và xóa các control hiện có trên panel (nếu muốn thay thế hoàn toàn)
            pn_main.Controls.Clear();

            // Tạo instance của UC_NhanVien và thêm vào pn_main
            uc_nv = new UC_NhanVien();
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
