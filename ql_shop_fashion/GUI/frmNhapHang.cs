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

namespace GUI
{
    public partial class frmNhapHang : DevExpress.XtraEditors.XtraForm
    {
        private nhap_hang_sql_BLL nhap_bll;
        private nha_cung_cap_sql_BLL ncc_bll;
        private chi_tiet_nhap_sql_BLL ct_nhap_bll;
        public frmNhapHang()
        {
            InitializeComponent();
            this.Load += FrmNhapHang_Load;
            dgv_nh.CellClick += Dgv_nh_CellClick;
           
            
        }

       

        private void Dgv_nh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có chọn vào hàng hợp lệ không
            if (e.RowIndex >= 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow row = dgv_nh.Rows[e.RowIndex];
                int id = int.Parse(row.Cells["ma_nhap_hang"].Value.ToString());
               
                var hang = nhap_bll.get_nhap_hang_by_id(id).FirstOrDefault();

                if (hang != null)
                {
                    // Sử dụng reflection để lấy giá trị từ các thuộc tính của đối tượng ẩn danh
                    var maNhapHang = hang.GetType().GetProperty("ma_nhap_hang")?.GetValue(hang, null);
                    var ngayNhap = hang.GetType().GetProperty("ngay_nhap")?.GetValue(hang, null);
                    var tongTien = hang.GetType().GetProperty("tong_gia_tien")?.GetValue(hang, null);
                    var tenNhaCungCap = hang.GetType().GetProperty("ten_nha_cung_cap")?.GetValue(hang, null);
                    var tenNhanVien = hang.GetType().GetProperty("ten_nhan_vien")?.GetValue(hang, null);
                    var ghichu = hang.GetType().GetProperty("ghi_chu")?.GetValue(hang, null);
                    var tt = hang.GetType().GetProperty("trang_thai")?.GetValue(hang, null);
                    var tongsoluong = hang.GetType().GetProperty("tong_so_luong")?.GetValue(hang, null);

                    load_dgv_sp(maNhapHang);



                    // Hiển thị dữ liệu lên các TextBox
                    txt_manhaphang.Text = maNhapHang?.ToString();
                    ngaynhap.Text = ngayNhap?.ToString();
                    txt_tonggiatien.Text = tongTien?.ToString();
                    cbb_manhacungcap.Text = tenNhaCungCap?.ToString();
                    txt_manhanvien.Text = tenNhanVien?.ToString();
                    txt_ghichu.Text = ghichu?.ToString();
                    cbb_trangthai.Text = tt?.ToString();
                    txt_tongsoluong.Text=tongsoluong?.ToString();
                }
            }
        }
        void load_cbb_ncc()
        {
            ncc_bll = new nha_cung_cap_sql_BLL();
            List<string> ncc = ncc_bll.get_ncc_list_name ();
            cbb_manhacungcap.Properties.Items.Clear();
            cbb_manhacungcap.Properties.Items.AddRange(ncc);
        }
        void load_dgv_sp(int id)
        {
            ct_nhap_bll = new chi_tiet_nhap_sql_BLL();
            dgv_sanpham.DataSource = null;
            dgv_sanpham.DataSource = ct_nhap_bll.get_sp_by_phieu_nhap(id);
        }

        private void FrmNhapHang_Load(object sender, EventArgs e)
        {
            loaddgv_nhap_hang();
            load_cbb_ncc();
        }

        void loaddgv_nhap_hang()
        {
            nhap_bll = new nhap_hang_sql_BLL();
            dgv_nh.DataSource = nhap_bll.get_all_nhap_hang();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }
    }
}