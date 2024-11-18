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
    public partial class frmInGia : DevExpress.XtraEditors.XtraForm
    {
        BLL.thuoc_tinh_sp_sql_BLL ttsp_bll = new BLL.thuoc_tinh_sp_sql_BLL();

        public frmInGia()
        {
            InitializeComponent();
            this.Load += FrmTesttt_Load;
            btnIn.Click += BtnIn_Click;
            btnThem.Click += BtnThem_Click;
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            int focusedRowHandle = dgvDS.FocusedRowHandle;
            if (focusedRowHandle >= 0)
            {
                object MaSP = dgvDS.GetRowCellValue(focusedRowHandle, "MaSP");
                object TenSP = dgvDS.GetRowCellValue(focusedRowHandle, "TenSP");
                object TenKT = dgvDS.GetRowCellValue(focusedRowHandle, "TenKT");
                object TenMau = dgvDS.GetRowCellValue(focusedRowHandle, "TenMau");
                object giaBan = dgvDS.GetRowCellValue(focusedRowHandle, "GiaBan");
                decimal giaGiam = (decimal)(dgvDS.GetRowCellValue(focusedRowHandle, "GiaGiam"));


                if (!(dgvSanPhamThem.DataSource is DataTable dataTable))
                {
                    // Nếu DataSource chưa phải là DataTable, khởi tạo DataTable mới và cấu hình các cột
                    dataTable = new DataTable();
                    dataTable.Columns.Add("MaSP", typeof(int));
                    dataTable.Columns.Add("TenSP", typeof(string));
                    dataTable.Columns.Add("TenKT", typeof(string));
                    dataTable.Columns.Add("TenMau", typeof(string));
                    dataTable.Columns.Add("GiaBan", typeof(string));
                    dataTable.Columns.Add("GiaGiam", typeof(string));
                  
                    // Gán DataTable mới tạo vào DataSource của dgvDS
                    dgvSanPhamThem.DataSource = dataTable;
                }

                // Tạo một hàng mới và thêm dữ liệu vào DataTable
                DataRow newRow = dataTable.NewRow();
                newRow["MaSP"] = MaSP;
                newRow["TenSP"] = TenSP;
                newRow["TenKT"] = TenKT;
                newRow["TenMau"] = TenMau;
                newRow["GiaBan"] = giaBan;
                newRow["GiaGiam"] = giaGiam.ToString("0.##");


                // Thêm hàng mới vào DataTable
                dataTable.Rows.Add(newRow);
            }
            
        }

        private void BtnIn_Click(object sender, EventArgs e)
        {
            InBarcode rp = new InBarcode();
            rp.DataSource = dgvSanPhamThem.DataSource;
            rp.ShowPreviewDialog();
        }

        private void FrmTesttt_Load(object sender, EventArgs e)
        {
            load();
        }

        public void load()
        {
            dgvSanPham.DataSource = ttsp_bll.Get_SP_INGIA();

        }
    }
}