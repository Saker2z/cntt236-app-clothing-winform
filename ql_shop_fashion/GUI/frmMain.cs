﻿using DevExpress.XtraBars;
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
        UC_BaoCao_ThongKe bctk;
        frmNhapHang nhapHang;
        BanHang banHang;
        DoiTraHang doiTraHang;
        UC_CaNhan canhan;

        public frmMain()
        {
            InitializeComponent();
            this.Load += FrmMain_Load;

            ace_manhinhchinh.Click += Ace_manhinhchinh_Click;
            ace_nhanvien.Click += Ace_nhanvien_Click;
            ace_taikhoan.Click += Ace_taikhoan_Click;
            ace_thongtincanhan.Click += Ace_thongtincanhan_Click;
            ace_nhacungcap.Click += Ace_nhacungcap_Click;
            ace_hoadon.Click += Ace_hoadon_Click;
            ace_sanpham.Click += Ace_sanpham_Click;
            ace_baocaothongke.Click += Ace_baocaothongke_Click;
            ace_quyen.Click += Ace_quyen_Click;
            ace_dangxuat.Click += Ace_dangxuat_Click;
            ace_banhang.Click += Ace_banhang_Click;
            ace_thongtincanhan.Click += Ace_thongtincanhan_Click1;
         

        }

        private void Ace_thongtincanhan_Click1(object sender, EventArgs e)
        {
            canhan = new UC_CaNhan(Properties.Settings.Default.id_user_login);
            panel_chinh.Controls.Clear();

            // Tạo instance của UC_NhanVien và thêm vào pn_main

            canhan.Dock = DockStyle.Fill; // Đặt dock nếu muốn chiếm toàn bộ diện tích panel

            panel_chinh.Controls.Add(canhan); // Thêm UC_NhanVien vào panel pn_main
        }

        private void Ace_banhang_Click(object sender, EventArgs e)
        {
            pn_main.Controls.Clear();

            // Tạo instance của UC_NhanVien và thêm vào pn_main
            banHang = new BanHang(Properties.Settings.Default.id_user_login);
            //nhapHang.Dock = DockStyle.Fill; // Đặt dock nếu muốn chiếm toàn bộ diện tích panel
            banHang.Show();
        }

        private void Ace_quyen_Click(object sender, EventArgs e)
        {
            panel_chinh.Controls.Clear();

            // Tạo instance của UC_NhanVien và thêm vào pn_main
            quyen = new UC_Quyen();
            quyen.Dock = DockStyle.Fill; // Đặt dock nếu muốn chiếm toàn bộ diện tích panel

            panel_chinh.Controls.Add(quyen); // Thêm UC_NhanVien vào panel pn_main
        }

        private void Ace_baocaothongke_Click(object sender, EventArgs e)
        {
            panel_chinh.Controls.Clear();

            // Tạo instance của UC_NhanVien và thêm vào pn_main
            bctk = new UC_BaoCao_ThongKe();
            bctk.Dock = DockStyle.Fill; // Đặt dock nếu muốn chiếm toàn bộ diện tích panel

            panel_chinh.Controls.Add(bctk); // Thêm UC_NhanVien vào panel pn_main
        }

        private void Ace_sanpham_Click(object sender, EventArgs e)
        {
            panel_chinh.Controls.Clear();

            // Tạo instance của UC_NhanVien và thêm vào pn_main
            sanPham = new UC_SanPham();
            sanPham.Dock = DockStyle.Fill; // Đặt dock nếu muốn chiếm toàn bộ diện tích panel

            panel_chinh.Controls.Add(sanPham); // Thêm UC_NhanVien vào panel pn_main
        }

        private void Ace_dangxuat_Click(object sender, EventArgs e)
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

        private void Ace_manhinhchinh_Click(object sender, EventArgs e)
        {
            panel_chinh.Controls.Clear();
            panel_chinh.Controls.Add(pn_main);
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
            panel_chinh.Controls.Clear();

            // Tạo instance của UC_NhanVien và thêm vào pn_main
            ncc_sp = new NCC_NCCSP();
            ncc_sp.Dock = DockStyle.Fill; // Đặt dock nếu muốn chiếm toàn bộ diện tích panel

            panel_chinh.Controls.Add(ncc_sp); // Thêm UC_NhanVien vào panel pn_main
        }

        private void Ace_thongtincanhan_Click(object sender, EventArgs e)
        {
            
        }

        private void Ace_taikhoan_Click(object sender, EventArgs e)
        {
            panel_chinh.Controls.Clear();

            // Tạo instance của UC_NhanVien và thêm vào pn_main
            taiKhoan = new UC_TaiKhoan(Properties.Settings.Default.name_role);
            taiKhoan.Dock = DockStyle.Fill; // Đặt dock nếu muốn chiếm toàn bộ diện tích panel

            panel_chinh.Controls.Add(taiKhoan); // Thêm UC_NhanVien vào panel pn_main
        }

        private void Ace_nhanvien_Click(object sender, EventArgs e)
        {
            // Kiểm tra và xóa các control hiện có trên panel (nếu muốn thay thế hoàn toàn)
            panel_chinh.Controls.Clear();

            // Tạo instance của UC_NhanVien và thêm vào pn_main
            uc_nv = new UC_NhanVien(Properties.Settings.Default.name_role);
            uc_nv.Dock = DockStyle.Fill; // Đặt dock nếu muốn chiếm toàn bộ diện tích panel

            panel_chinh.Controls.Add(uc_nv); // Thêm UC_NhanVien vào panel pn_main
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
