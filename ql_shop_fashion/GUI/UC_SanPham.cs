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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;

namespace GUI
{
    public partial class UC_SanPham : DevExpress.XtraEditors.XtraUserControl
    {
        private san_pham_sql_BLL sp_bll;
        public UC_SanPham()
        {
            InitializeComponent();
            this.Load += UC_SanPham_Load;
        }

        private void UC_SanPham_Load(object sender, EventArgs e)
        {
            load_gct_sp();
        }

        void load_gct_sp()
        {
            // Lấy GridView từ GridControl
            GridView gridView = gct_sp.MainView as GridView;
            if (gridView == null)
                return;

            // Khởi tạo đối tượng BLL và gán dữ liệu sản phẩm vào GridControl
            sp_bll = new san_pham_sql_BLL();
            gct_sp.DataSource = sp_bll.GetAllSanPham(); // Giả sử hàm GetAllSanPham trả về List<san_pham>

            // Thiết lập các thuộc tính hiển thị cho GridView
            gridView.OptionsBehavior.Editable = false;

            //// Đặt tiêu đề và độ rộng cho các cột tương ứng với bảng san_pham
            //gridView.Columns["ma_san_pham"].Caption = "Mã Sản Phẩm";
            //gridView.Columns["ma_san_pham"].Width = 100;

            //gridView.Columns["ten_san_pham"].Caption = "Tên Sản Phẩm";
            //gridView.Columns["ten_san_pham"].Width = 200;

            //gridView.Columns["gia_binh_quan"].Caption = "Giá Bình Quân";
            //gridView.Columns["gia_binh_quan"].Width = 120;

            //gridView.Columns["so_luong"].Caption = "Số Lượng";
            //gridView.Columns["so_luong"].Width = 100;

            //gridView.Columns["mo_ta"].Caption = "Mô Tả";
            //gridView.Columns["mo_ta"].Width = 250;

            // Ẩn các cột không cần thiết nếu có
            gridView.Columns["created_at"].Visible = false;
            gridView.Columns["updated_at"].Visible = false;

            // Tắt chế độ Master-Detail nếu không cần thiết và làm mới dữ liệu
            gridView.OptionsDetail.EnableMasterViewMode = false;
            gridView.ClearGrouping();
            gridView.RefreshData();

            // Tắt hiển thị dòng và ô được lấy nét (dòng được chọn)
            gridView.OptionsSelection.EnableAppearanceFocusedRow = false;
            gridView.OptionsSelection.EnableAppearanceFocusedCell = false;

            // Đặt `FocusedRowHandle` về `InvalidRowHandle` và xóa mọi lựa chọn
            gridView.FocusedRowHandle = GridControl.InvalidRowHandle;
            gridView.ClearSelection();

            // Sử dụng `BeginInvoke` để đảm bảo không có dòng nào được chọn sau khi dữ liệu đã tải
            gridView.GridControl.BeginInvoke(new Action(() =>
            {
                gridView.FocusedRowHandle = GridControl.InvalidRowHandle;
                gridView.ClearSelection();
            }));
        }


    }
}
