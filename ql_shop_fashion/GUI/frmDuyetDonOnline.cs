using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using DevExpress.XtraReports.UI;

namespace GUI
{
    public partial class frmDuyetDonOnline : DevExpress.XtraEditors.XtraForm
    {
        BLL.thuoc_tinh_sp_sql_BLL ttsp_bll = new BLL.thuoc_tinh_sp_sql_BLL();
        don_dat_hang_web_BLL dh_bll = new don_dat_hang_web_BLL();
        chi_tiet_don_web_BLL ctdh_bll = new chi_tiet_don_web_BLL();

        public frmDuyetDonOnline()
        {
            InitializeComponent();
            this.Load += FrmDuyetDonOnline_Load;
            dgvDonHang.CellClick += DgvDonHang_CellClick;
            btnDuyetDon.Click += BtnDuyetDon_Click;
            cboTrangThai.SelectedIndexChanged += CboTrangThai_SelectedIndexChanged;
          
        }

        private void CboTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTrangThai.SelectedItem != null)
            {
                dgvDonHang.DataSource = dh_bll.getDonHangOnl(cboTrangThai.SelectedItem.ToString());
            }
        }

        private void BtnDuyetDon_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn trong DataGridView không
            if (dgvDonHang.CurrentRow != null)
            {
                // Lấy dòng hiện tại được chọn
                DataGridViewRow row = dgvDonHang.CurrentRow;

                // Lấy trạng thái và mã đơn hàng từ các ô trong dòng
                string trangThai = row.Cells["trangThai"].Value?.ToString();
                string maDonHang = row.Cells["id_don_hang"].Value?.ToString();

                // Kiểm tra trạng thái là "Chưa duyệt"
                if (trangThai == "Chưa duyệt")
                {
                    // Hiển thị MessageBox xác nhận duyệt đơn hàng
                    DialogResult result = MessageBox.Show(
                        $"Bạn có muốn duyệt đơn hàng có mã {maDonHang} không?",
                        "Xác nhận duyệt đơn",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    // Nếu người dùng chọn Yes
                    if (result == DialogResult.Yes)
                    {
                        if (dh_bll.updateTrangThaiGiaoHang(int.Parse(maDonHang)))
                        {
                            XtraMessageBox.Show("Duyệt đơn hàng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadFrm();
                        }
                        else
                        {
                            XtraMessageBox.Show("Duyệt đơn hàng không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    // Hiển thị thông báo nếu đơn hàng đã được duyệt trước đó
                    MessageBox.Show($"Đơn hàng có mã {maDonHang} đã được duyệt trước đó!",
                                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                // Thông báo nếu không có dòng nào được chọn
                MessageBox.Show("Vui lòng chọn một đơn hàng cần duyệt!",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void loadCBO()
        {
            cboTrangThai.Items.Add("Tất cả");
            cboTrangThai.Items.Add("Chưa duyệt");
            cboTrangThai.Items.Add("Đã giao cho đơn vị vận chuyển");
        }    
        private void DgvDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có chọn đúng dòng không
            if (e.RowIndex >= 0)
            {
                // Lấy dòng hiện tại được chọn
                DataGridViewRow row = this.dgvDonHang.Rows[e.RowIndex];

                // Gán giá trị từ từng cột vào các TextBox
                txtMaDon.Text = row.Cells["id_don_hang"].Value.ToString();
                txtTenKH.Text = row.Cells["ho_ten"].Value.ToString();
                txtDiaChi.Text = row.Cells["dia_chi"].Value.ToString();
                txtsdt.Text = row.Cells["so_dien_thoai"].Value.ToString();
                txtNgayDat.Text = row.Cells["thoi_gian_dat"].Value.ToString();
            }

            dgvCTDonHang.DataSource = ctdh_bll.layChiTietDonHang(int.Parse(txtMaDon.Text));
        }
        private void loadFrm()
        {
            dgvDonHang.DataSource = dh_bll.getDonHangOnl(null);
        }
        private void FrmDuyetDonOnline_Load(object sender, EventArgs e)
        {
            loadFrm();
            loadCBO();
        }
    }
}