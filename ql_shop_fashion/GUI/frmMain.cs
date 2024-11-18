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

        public frmMain()
        {
            InitializeComponent();
            pn_main.Dock = DockStyle.Fill;
            ace_sanpham.Click += Ace_sanpham_Click;
            ace_manhinhchinh.Click += Manhinhchinh_Click;
            ace_hoadon.Click += Theonhacungcap_Click;
            ace_kiemduyetsanpham.Click += Theosanpham_Click;
            ace_nhacungcap.Click += Nhacungcap_Click;
            this.Load += FrmMain_Load;
        }

        private void Ace_sanpham_Click(object sender, EventArgs e)
        {
            panel_chinh.Controls.Clear();

            if (sanPham == null)
            {
                sanPham = new UC_SanPham();
                sanPham.Dock = DockStyle.Fill;
            }
            panel_chinh.Controls.Add(sanPham);
            sanPham.BringToFront();
        }

        private void LoadGifToPanel(string filePath)
        {
            if (File.Exists(filePath)) // Kiểm tra xem file có tồn tại không
            {
                try
                {
                    // Tải hình ảnh từ file và gán cho BackgroundImage của panel
                    pn_main.BackgroundImage = Image.FromFile(filePath);
                    pn_main.BackgroundImageLayout = ImageLayout.Stretch; // Để ảnh lấp đầy Panel
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tải ảnh: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy file GIF!");
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadGifToPanel(@"..\..\Resources\background_mhc.jpg");
        }



        private void Nhacungcap_Click(object sender, EventArgs e)
        {
            panel_chinh.Controls.Clear();

            if (nCC_NCCSP == null)
            {
                nCC_NCCSP = new NCC_NCCSP();
                nCC_NCCSP.Dock = DockStyle.Fill;
            }
            panel_chinh.Controls.Add(nCC_NCCSP);
            nCC_NCCSP.BringToFront();
        }

        private void Manhinhchinh_Click(object sender, EventArgs e)
        {
            panel_chinh.Controls.Clear();
            panel_chinh.Controls.Add(pn_main);
        }

        private void Theosanpham_Click(object sender, EventArgs e)
        {
            panel_chinh.Controls.Clear();

            if (nhapHangTheoSanPham == null)
            {
                nhapHangTheoSanPham = new UC_NhapHangTheoSanPham();
                nhapHangTheoSanPham.Dock = DockStyle.Fill;
            }
            panel_chinh.Controls.Add(nhapHangTheoSanPham);
            nhapHangTheoSanPham.BringToFront();
        }

        private void Theonhacungcap_Click(object sender, EventArgs e)
        {
            panel_chinh.Controls.Clear();

            if (nhapHangTheoNCC == null)
            {
                nhapHangTheoNCC = new UC_NhapHangTheoNCC();
                nhapHangTheoNCC.Dock = DockStyle.Fill;
            }
            panel_chinh.Controls.Add(nhapHangTheoNCC);
            nhapHangTheoNCC.BringToFront();
        }



        private void thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                frmDangNhap main = new frmDangNhap();
                this.Hide();
                main.Show();
                main.FormClosed += (s, args) => this.Close();
            }
            else
            {
                return;
            }
        }

        private void taikhoan_Click(object sender, EventArgs e)
        {
            panel_chinh.Controls.Clear();

            if (taiKhoan == null)
            {
                taiKhoan = new UC_TaiKhoan();
                taiKhoan.Dock = DockStyle.Fill;
            }
            panel_chinh.Controls.Add(taiKhoan);
            taiKhoan.BringToFront();
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

        private void sanpham_Click(object sender, EventArgs e)
        {

        }
    }
}
