using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.Linq;  // Sử dụng LINQ
using System.Windows.Forms;
using DTO;
using BLL;
using DevExpress.XtraGrid.Views.Base;

namespace GUI
{
    public partial class frmDuyetSanPham : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private thuoc_tinh_sp_sql_BLL ttsp_bll;
        private chi_tiet_nhap_sql_BLL ctnhap_bll;
        private List<product> productList; // Sử dụng List<Product> thay vì List<dynamic>

        public frmDuyetSanPham()
        {
            InitializeComponent();
            ttsp_bll = new thuoc_tinh_sp_sql_BLL();
            this.Load += FrmDuyetSanPham_Load;
            // Lấy dữ liệu từ database và chuyển thành List<Product> để dễ xử lý

            ctnhap_bll = new chi_tiet_nhap_sql_BLL();
            dgv_dsnhap.Click += Dgv_dsnhap_Click;
        }

        private void Dgv_dsnhap_Click(object sender, EventArgs e)
        {
            
            GridView gridView = dgv_dsnhap.MainView as GridView;

            if (gridView != null)
            {
                // Lấy thông tin dòng đã click (dòng được chọn)
                int focusedRowHandle = gridView.FocusedRowHandle;

                // Kiểm tra nếu dòng không phải là -1 (dòng không hợp lệ)
                if (focusedRowHandle >= 0)
                {
                    // Lấy giá trị cột 'ma_san_pham' từ dòng đã click
                    var maSanPham = gridView.GetRowCellValue(focusedRowHandle, "ma_san_pham");
                   
                    if (maSanPham != null)
                    {
                        // Chuyển đổi maSanPham sang kiểu dữ liệu cần thiết và gọi phương thức xử lý tiếp theo
                        load_gdv_duyet_sp(int.Parse(maSanPham.ToString()));
                    }
                }
            }
        }

       

        // Xử lý sự kiện MouseClick
       

        private void FrmDuyetSanPham_Load(object sender, EventArgs e)
        {
            load_gdv_duyet_sp(0);
            load_dgv_sp(dgv_dsnhap, ctnhap_bll.get_ct_list_by_id(35));
        }

        void load_gdv_duyet_sp(int id)
        {
            var products = ttsp_bll.get_all_ttsp_by_id(id).ToList();
            SetupGridControl(gdv_duyet_sp, products);
        }
        void load_dgv_sp(GridControl gridControl, List<chi_tiet_nhap_hang> products)
        {
            GridView gridView = gridControl.MainView as GridView;
            if (gridView == null)
                return;
            gridControl.DataSource = products;
            gridView.OptionsBehavior.Editable = false;
            gridView.Columns["ma_nhap_hang"].Caption = "Mã Nhập Hàng";
            gridView.Columns["ma_san_pham"].Caption = "Mã Sản phẩm";
            gridView.Columns["so_luong"].Caption = "Số Lượng";
            gridView.Columns["gia_nhap"].Caption = "Giá Nhập";
            gridView.Columns["created_at"].Visible = false;
            gridView.Columns["updated_at"].Visible = false;
            gridView.Columns["nhap_hang"].Visible = false;
            gridView.Columns["san_pham"].Visible = false;

        }
        private void SetupGridControl(GridControl gridControl, List<product> products)
        {
            GridView gridView = gridControl.MainView as GridView;

            if (gridView == null)
                return;

            // Gán DataSource từ List<Product>
            gridControl.DataSource = products;

            // Cho phép chỉnh sửa trên GridView
            gridView.OptionsBehavior.Editable = true;

            // Thay đổi tiêu đề các cột
            gridView.Columns["ma_thuoc_tinh"].Caption = "Mã Thuộc Tính";
            gridView.Columns["ten_san_pham"].Caption = "Tên Sản Phẩm";
            gridView.Columns["ten_kich_thuoc"].Caption = "Tên Kích Thước";
            gridView.Columns["ten_mau_sac"].Caption = "Tên Màu Sắc";
            gridView.Columns["so_luong_ton"].Caption = "Số Lượng Tồn";

            // Căn chỉnh các cột tiêu đề và dữ liệu
            gridView.Columns["ma_thuoc_tinh"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView.Columns["ten_san_pham"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView.Columns["ten_kich_thuoc"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView.Columns["ten_mau_sac"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView.Columns["so_luong_ton"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            gridView.Columns["ma_thuoc_tinh"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView.Columns["ten_san_pham"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView.Columns["ten_kich_thuoc"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView.Columns["ten_mau_sac"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView.Columns["so_luong_ton"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            // Thiết lập chiều rộng cột tự động
            gridView.Columns["ten_san_pham"].BestFit();  // Cột 'Tên Sản Phẩm' sẽ có chiều rộng tối ưu theo dữ liệu

            // Căn chỉnh chiều rộng các cột còn lại để không bị quá hẹp
            gridView.Columns["ma_thuoc_tinh"].Width = 50;  // Chiều rộng cột Mã Thuộc Tính
            gridView.Columns["ten_kich_thuoc"].Width = 50; // Chiều rộng cột Tên Kích Thước
            gridView.Columns["ten_mau_sac"].Width = 50;    // Chiều rộng cột Tên Màu Sắc
            gridView.Columns["so_luong_ton"].Width = 70;   // Chiều rộng cột Số Lượng Tồn
            SetupSpinEditForColumn(gridView);

        }

        private void SetupSpinEditForColumn(GridView gridView)
        {
            // Kiểm tra và thiết lập SpinEdit cho cột "so_luong_ton"
            if (gridView.Columns.Contains(gridView.Columns["so_luong_ton"]))
            {
                RepositoryItemSpinEdit spinEdit = new RepositoryItemSpinEdit
                {
                    MinValue = 0,  // Giá trị tối thiểu
                    MaxValue = 1000,  // Giá trị tối đa
                    Increment = 1,  // Đơn vị tăng mỗi lần
                    EditMask = "N0" // Hiển thị định dạng số
                };

                // Gán RepositoryItemSpinEdit cho cột "so_luong_ton"
                gridView.Columns["so_luong_ton"].ColumnEdit = spinEdit;
            }
        }

        // Lắng nghe sự kiện khi giá trị cột thay đổi
        private void frmDuyetSanPham_Load(object sender, EventArgs e)
        {
            // Lắng nghe sự kiện CellValueChanged
            GridView gridView = gdv_duyet_sp.MainView as GridView;
            if (gridView != null)
            {
                gridView.CellValueChanged += GridView_CellValueChanged;
            }
        }

        private void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            // Kiểm tra nếu cột thay đổi là "so_luong_ton"
            if (e.Column.FieldName == "so_luong_ton")
            {
                var newSoLuongTon = e.Value;
                var rowIndex = e.RowHandle;

                // Cập nhật giá trị trong productList
                productList[rowIndex].so_luong_ton = (int)newSoLuongTon;

                // Cập nhật vào cơ sở dữ liệu hoặc xử lý dữ liệu khác ở đây
                Console.WriteLine($"Giá trị mới của Số Lượng Tồn: {newSoLuongTon}");
            }
        }
    }

 
   
}
