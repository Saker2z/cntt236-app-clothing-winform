using DevExpress.XtraBars;
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
        UC_thuonghieu thuonghieu;
        UC_TaiKhoan taiKhoan;

        public frmMain()
        {
            InitializeComponent();
            pn_main.Dock = DockStyle.Fill;
            this.Load += FrmMain_Load;
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
                Application.Exit();
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
    }
}
