using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLL;

namespace GUI
{
    public partial class PhieuNhap : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private nha_cung_cap_sql_DLL ncc_dll;
        private chi_tiet_nhap_sql_DLL ct_sp_dll;
        public PhieuNhap()
        {
            InitializeComponent();


            this.Load += PhieuNhap_Load;
            cbb_ncc.SelectedIndexChanged += Cbb_ncc_SelectedIndexChanged;
        }
        void setDeflau()
        {
            txt_tt.Text = "Chưa xử lý";
            txt_tt.Enabled = false;
            date_ngaynhap.Value = DateTime.Now;
            date_ngaynhap.Enabled = false;
            txt_ghichu.Text = "Không có";
            txt_tongsl.Text = "0";
            txt_tongsl.Enabled = false;
            txt_tennv.Text = "Võ Danh Dự";
            txt_tennv.Enabled = false;
            lb_thanhtien.Text = lb_thanhtien.Text + " 0";
            dgv_sp.DataSource = null;
        }

        private void Cbb_ncc_SelectedIndexChanged(object sender, EventArgs e)
        {
            ncc_dll = new nha_cung_cap_sql_DLL();
            int ma = ncc_dll.get_id_ncc(cbb_ncc.SelectedItem.ToString());
            load_cbb_sp(ma);
        }
        void load_cbb_sp(int id)
        {
            cbb_tensp.SelectedIndex = -1;
            ct_sp_dll = new chi_tiet_nhap_sql_DLL();
            List<string> ctsp = ct_sp_dll.get_list_sp_by_id(id);
            cbb_tensp.Properties.Items.Clear();
            cbb_tensp.Properties.Items.AddRange(ctsp);
        }

        private void PhieuNhap_Load(object sender, EventArgs e)
        {
            load_cbb_ncc();
            setDeflau();
        }

        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            dgv_sp.ShowRibbonPrintPreview();
        }
        void load_cbb_ncc()
        {
            ncc_dll = new nha_cung_cap_sql_DLL();
            List<string> ncc = ncc_dll.get_ncc_list_name();
            cbb_ncc.Properties.Items.Clear();
            cbb_ncc.Properties.Items.AddRange(ncc);
        }

    }
}
