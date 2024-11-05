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

using DevExpress.XtraGrid.Views.Grid; // Để sử dụng GridView
using DevExpress.XtraEditors.Repository; // Để sử dụng RepositoryItemComboBox
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Controls;
using BLL;

// Namespace cho GridView


namespace GUI
{
    public partial class PhieuNhap : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private nha_cung_cap_sql_BLL ncc_bll;
        private chi_tiet_nhap_sql_BLL ct_sp_bll;
        private san_pham_sql_BLL sp_bll;
        private ncc_sp_sql_BLL nccsp_bll;
        public PhieuNhap()
        {
            InitializeComponent();

           
            this.Load += PhieuNhap_Load;
    
            cbb_ncc.TextChanged += Cbb_ncc_TextChanged;
            cbb_tensp.TextChanged += Cbb_tensp_TextChanged;
            cbb_tensp.SelectedIndexChanged += Cbb_tensp_SelectedIndexChanged;
            cbb_ncc.SelectedIndexChanged += Cbb_ncc_SelectedIndexChanged;
            

        }

        private void Cbb_ncc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbb_ncc.SelectedIndex==-1)
            {
                if (cbb_tensp.SelectedIndex != -1)
                {
                    sp_bll = new san_pham_sql_BLL();
                    load_cbb_ncc(sp_bll.get_id_sp_by_name(cbb_tensp.SelectedItem.ToString()));
                    
                }
                txt_dg.Text = "0";
                return;
            }    
            load_gia();
          
              
        }

        private void Cbb_tensp_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_ncc.Properties.Items.Clear();
            cbb_ncc.SelectedIndex = -1;
            txt_dg.Text = "0";
            try
            {
                if (cbb_tensp.SelectedItem != null)
                {
                   
                    sp_bll = new san_pham_sql_BLL();
                    int? id = sp_bll.get_id_sp_by_name(cbb_tensp.SelectedItem.ToString());
                   
                    if (id.HasValue)
                    {
                        
                        load_dgv_sp_ss(id.Value);
                      
                        load_cbb_ncc(id.Value);
                    }else
                    {
                        
                    }    
                    
                }
                else
                {
                   
                    txt_dg.Text = "";
                    cbb_ncc.Properties.Items.Clear();
                    cbb_ncc.SelectedIndex = -1;
                    return;
                }
            }
            catch(Exception ex)
            {
                return;
            }
        }
        void load_gia()
        {

            // Kiểm tra nếu không có dòng nào trong DataGridView thì thoát hàm
            if (dgv_gia.Rows.Count == 0)
            {
                txt_dg.Text = "0";
                return;
            }

            // Lấy giá trị cần tìm từ cbb_ncc
            string selectedValue = cbb_ncc.SelectedItem?.ToString();

            // Sử dụng LINQ để tìm dòng có giá trị "ten_nha_cung_cap" phù hợp
            var foundRow = dgv_gia.Rows.Cast<DataGridViewRow>()
                .FirstOrDefault(row => row.Cells["ten_nha_cung_cap"].Value?.ToString()
                .Equals(selectedValue, StringComparison.OrdinalIgnoreCase) == true);

            if (foundRow != null)
            {
                // Nếu tìm thấy dòng, lấy giá trị "gia_cung_cap"
                txt_dg.Text = foundRow.Cells["gia_cung_cap"].Value?.ToString();
            }
            else
            {
                // Nếu không tìm thấy dòng nào phù hợp
                txt_dg.Text = "0";
            }

        }
        void load_cbb_sp()
        {
            sp_bll = new san_pham_sql_BLL();
            List<string> ctsp = sp_bll.get_sp_all_name();
            cbb_tensp.Properties.Items.Clear();
            cbb_tensp.Properties.Items.AddRange(ctsp);
        }

        void load_dgv_sp_ss(int id)
        {
            nccsp_bll = new ncc_sp_sql_BLL();
            dgv_gia.DataSource = null;
            dgv_gia.DataSource = nccsp_bll.get_nccsp_by_id_sp(id);
        }
        private void Cbb_tensp_TextChanged(object sender, EventArgs e)
        {
            var comboBox = sender as ComboBoxEdit;
            var filterText = comboBox.Text.ToLower();
            sp_bll = new san_pham_sql_BLL();
            List<string> ctsp = sp_bll.get_sp_all_name();

            var filteredItems = ctsp
                .Where(item => item.ToLower().Contains(filterText))
                .ToList();

            comboBox.Properties.Items.BeginUpdate();
            comboBox.Properties.Items.Clear();
            comboBox.Properties.Items.AddRange(filteredItems);
            comboBox.Properties.Items.EndUpdate();

            comboBox.ShowPopup();
        }

        private void Cbb_ncc_TextChanged(object sender, EventArgs e)
        {
            var comboBox = sender as ComboBoxEdit;
            var filterText = comboBox.Text.ToLower();

            // Kiểm tra nếu không có mục nào được chọn trong cbb_tensp
            if (cbb_tensp.SelectedItem == null || string.IsNullOrEmpty(filterText))
            {
                return;
            }

            // Khởi tạo BLL và lấy danh sách tên nhà cung cấp
            nccsp_bll = new ncc_sp_sql_BLL();
            List<string> ncc = nccsp_bll.get_list_name_ncc_id_sp(sp_bll.get_id_sp_by_name(cbb_tensp.SelectedItem.ToString()));

            // Lọc danh sách nhà cung cấp theo filterText
            var filteredItems = ncc
                .Where(item => item.ToLower().Contains(filterText))
                .ToList();

            // Cập nhật lại danh sách trong ComboBoxEdit
            comboBox.Properties.Items.BeginUpdate();
            comboBox.Properties.Items.Clear();
            comboBox.Properties.Items.AddRange(filteredItems);
            comboBox.Properties.Items.EndUpdate();

            // Hiển thị popup với các mục đã lọc
            comboBox.ShowPopup();
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
            cbb_sl.Properties.Items.Clear();
            txt_dg.Text = "0";

            // Thêm số từ 100 đến 1000 với khoảng cách 100
            for (int i = 0; i <= 1000; i += 100)
            {
                cbb_sl.Properties.Items.Add(i);
            }
            cbb_sl.SelectedIndex = 0;

        }

     
      

        private void PhieuNhap_Load(object sender, EventArgs e)
        {
            load_cbb_sp();
            setDeflau();
           // LoadDataGridView(dgv_sp);
        }

      
        void load_cbb_ncc(int id)
        {
            nccsp_bll = new ncc_sp_sql_BLL();
            List<string> ncc = nccsp_bll.get_list_name_ncc_id_sp(id);
            cbb_ncc.Properties.Items.Clear();
            cbb_ncc.Properties.Items.AddRange(ncc);
        }
    



    }
}
