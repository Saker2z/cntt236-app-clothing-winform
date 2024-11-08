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
using DTO;

namespace GUI
{
    public partial class frmMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        UC_NhapHangTheoNCC nhapHangTheoNCC;
        UC_NhapHangTheoSanPham nhapHangTheoSanPham;
        UC_thuonghieu thuonghieu;
        UC_TaiKhoan taiKhoan;
        UC_NhaCungCap nhaCungCap;
        UC_SanPham sanPham;
        QL_SHOP_DATADataContext dataContext;

        public frmMain()
        {
            InitializeComponent();
            pn_main.Dock = DockStyle.Fill;
            this.Load += FrmMain_Load;
            nhacungcap.Click += Nhacungcap_Click;
            sanpham.Click += SanPham_Click;
            dataContext = new QL_SHOP_DATADataContext();
        }

        private void SanPham_Click(object sender, EventArgs e)
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

        private void Nhacungcap_Click(object sender, EventArgs e)
        {
            panel_chinh.Controls.Clear();

            if (nhaCungCap == null)
            {
                nhaCungCap = new UC_NhaCungCap();
                nhaCungCap.Dock = DockStyle.Fill;
            }
            panel_chinh.Controls.Add(nhaCungCap);
            nhaCungCap.BringToFront();
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

        private void aothun_Click(object sender, EventArgs e)
        {
            panel_chinh.Controls.Clear();

            if (thuonghieu == null)
            {
                thuonghieu = new UC_thuonghieu();
                thuonghieu.Dock = DockStyle.Fill;
            }
            panel_chinh.Controls.Add(thuonghieu);
            thuonghieu.BringToFront();
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

        private void nam_Click(object sender, EventArgs e)
        {

        }

        private void manhinhchinh_Click(object sender, EventArgs e)
        {

            panel_chinh.Controls.Clear();
            panel_chinh.Controls.Add(pn_main);
           // pn_main.Dock = DockStyle.Fill;


        }

        private void theonhacungcap_Click(object sender, EventArgs e)
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

        private void theosanpham_Click(object sender, EventArgs e)
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

        public void ShowScreens(List<int> accessibleScreens)
        {
            // Gọi phương thức đệ quy để xử lý hiển thị quyền truy cập cho tất cả các phần tử
            SetElementVisibility(accordionControl1.Elements, accessibleScreens);
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
