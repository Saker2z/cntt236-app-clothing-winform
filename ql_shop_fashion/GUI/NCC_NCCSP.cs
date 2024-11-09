using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using DevExpress.DataProcessing;
using DevExpress.XtraEditors.Repository;

namespace GUI
{
    public partial class NCC_NCCSP : DevExpress.XtraEditors.XtraUserControl
    {
        private nha_cung_cap_sql_BLL ncc_bll;
        private ncc_sp_sql_BLL ncc_sp_bll;
        public san_pham_sql_BLL sp_bll;
        private int idncc = 0;
        int checkpoin = 0;
        public NCC_NCCSP()
        {
            InitializeComponent();
            this.Load += NCC_NCCSP_Load;
            GridView gridView = gct_dsncc.MainView as GridView;
            gridView.FocusedRowChanged += GridView_FocusedRowChanged;
            bt_them.Click += Bt_them_Click;
            bt_luu.Click += Bt_luu_Click;
        }

        private void Bt_luu_Click(object sender, EventArgs e)
        {
            if (checkpoin == 1)
            {
                SaveAllDataToDatabase();
              
                return;
            }
            else if (checkpoin == 2)
            {
                SaveUpdatedGiaCungCap();
                return;
            }
            else
            {
                MessageBox.Show("Lỗi sự kiện vui lòng chọn thêm hoặc sửa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
         
        }

        private void Bt_them_Click(object sender, EventArgs e)
        {
            sp_bll = new san_pham_sql_BLL();
            AddEmptyRowToGrid(sp_bll.get_all_sp());
            checkpoin = 1;
        }

        private void GridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GridView gridView = sender as GridView;
            if (gridView != null)
            {
                // Lấy dữ liệu của dòng hiện tại
                var maNhaCungCap = gridView.GetFocusedRowCellValue("ma_nha_cung_cap")?.ToString();
                var tenNhaCungCap = gridView.GetFocusedRowCellValue("ten_nha_cung_cap")?.ToString();
                var diaChi = gridView.GetFocusedRowCellValue("dia_chi")?.ToString();
                var dienThoai = gridView.GetFocusedRowCellValue("dien_thoai")?.ToString();

                // Gán dữ liệu vào các TextBox
                ma_ncc.Text = maNhaCungCap;
                ten_ncc.Text = tenNhaCungCap;
                dc.Text = diaChi;
                dt.Text = dienThoai;
                idncc = int.Parse(maNhaCungCap);
                load_dgv_nccsp(idncc);
                bt_sua.Click += Bt_sua_Click;

            }
        }

        private void Bt_sua_Click(object sender, EventArgs e)
        {

            EnableEditGiaCungCapForSelectedRow();
            checkpoin = 2;
        }
        public void EnableEditGiaCungCapForSelectedRow()
        {
            // Lấy GridView từ GridControl
            GridView gridView = gct_spncc.MainView as GridView;
            if (gridView == null)
                return;

            // Kiểm tra nếu có dòng nào đang được chọn
            int selectedRowHandle = gridView.FocusedRowHandle;
            if (selectedRowHandle < 0)
            {
                MessageBox.Show("Vui lòng chọn dòng để chỉnh sửa.");
                return;
            }

            // Bật chế độ cho phép chỉnh sửa toàn bộ GridView
            gridView.OptionsBehavior.Editable = true;

            // Đặt AllowEdit cho tất cả các cột là false trừ "gia_cung_cap"
            foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = column.FieldName == "gia_cung_cap";
            }

            // Đặt focus vào cột "gia_cung_cap" trong dòng hiện đang chọn và mở chế độ chỉnh sửa
            gridView.FocusedRowHandle = selectedRowHandle;
            gridView.FocusedColumn = gridView.Columns["gia_cung_cap"];
            gridView.ShowEditor();
        }



        public void SaveUpdatedGiaCungCap()
        {
            // Lấy GridView từ GridControl
            GridView gridView = gct_spncc.MainView as GridView;
            if (gridView == null)
                return;

            // Kiểm tra nếu có dòng nào đang được chọn
            int selectedRowHandle = gridView.FocusedRowHandle;
            if (selectedRowHandle < 0)
            {
                MessageBox.Show("Vui lòng chọn dòng để lưu chỉnh sửa.");
                return;
            }

            // Đảm bảo cập nhật giá trị đã chỉnh sửa từ ô vào GridView
            gridView.CloseEditor();
            gridView.UpdateCurrentRow();

            // Lấy giá trị của dòng hiện tại từ GridView
            int maNhaCungCap = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "ma_nha_cung_cap") ?? 0);
            int maSanPham = Convert.ToInt32(gridView.GetRowCellValue(selectedRowHandle, "ma_san_pham") ?? 0);
            decimal giaCungCap = Convert.ToDecimal(gridView.GetRowCellValue(selectedRowHandle, "gia_cung_cap") ?? 0);

            // Gọi hàm UpdateGiaNhap để lưu thay đổi vào cơ sở dữ liệu
            ncc_sp_bll = new ncc_sp_sql_BLL();
            bool result = ncc_sp_bll.UpdateGiaNhap(maNhaCungCap, maSanPham, giaCungCap);

            // Kiểm tra kết quả và hiển thị thông báo cho người dùng
            if (result)
            {
                MessageBox.Show("Cập nhật giá cung cấp thành công.", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cập nhật lại trạng thái
                checkpoin = 0;

                // Tải lại dữ liệu vào DataGridView để hiển thị thông tin mới
                load_dgv_nccsp(idncc);


                // Xuất thông tin chi tiết của dòng đã cập nhật: ma_nha_cung_cap, ma_san_pham, gia_cung_cap
                string message = $"Chi tiết dòng đã cập nhật:\n" +
                                 $"- Mã nhà cung cấp: {maNhaCungCap}\n" +
                                 $"- Mã sản phẩm: {maSanPham}\n" +
                                 $"- Giá cung cấp mới: {giaCungCap}";

                MessageBox.Show(message, "Thông tin cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Đặt trạng thái GridView về ban đầu (không cho phép chỉnh sửa)
                gridView.OptionsBehavior.Editable = false;
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi cập nhật giá cung cấp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






         



        private void NCC_NCCSP_Load(object sender, EventArgs e)
        {
            load_gct();
            clear_data();
        }
        void clear_data()
        {
            ma_ncc.Text = "";
            ten_ncc.Text = "";
            dc.Text = "";
            dt.Text = "";
        }

        void load_gct()
        {

            GridView gridView = gct_dsncc.MainView as GridView;
            if (gridView == null)
                return;


            ncc_bll = new nha_cung_cap_sql_BLL();


            gct_dsncc.DataSource = ncc_bll.get_all_ncc();
            gridView.OptionsBehavior.Editable = false;
            gridView.Columns["ma_nha_cung_cap"].Caption = "Mã Nhà Cung Cấp";
            gridView.Columns["ten_nha_cung_cap"].Caption = "Tên Nhà Cung Cấp";



            gridView.Columns["dia_chi"].Visible = false;
            gridView.Columns["dien_thoai"].Visible = false;
            gridView.Columns["created_at"].Visible = false;
            gridView.Columns["updated_at"].Visible = false;
            gridView.Columns["ma_nha_cung_cap"].Width = 150; // Đặt chiều rộng tùy ý cho cột "Mã Nhà Cung Cấp"
            gridView.Columns["ten_nha_cung_cap"].Width = 200;
            gridView.OptionsDetail.EnableMasterViewMode = false;
            gridView.ClearGrouping();


            gridView.RefreshData();
        }
        void load_dgv_nccsp(int id)
        {
            // Khởi tạo đối tượng BLL nếu chưa có
            ncc_sp_bll = new ncc_sp_sql_BLL();

            // Xóa dữ liệu và cấu hình hiện tại của `GridControl` trước khi tải mới
            gct_spncc.DataSource = null; // Xóa dữ liệu cũ nếu có
            GridView gridView = new GridView(gct_spncc); // Tạo mới `GridView`
            gct_spncc.MainView = gridView; // Gán `GridView` mới cho `GridControl`

            // Gán dữ liệu cho GridControl
            gct_spncc.DataSource = ncc_sp_bll.get_sp_nccsp_by_id(id);

            // Đặt các tùy chọn không cho phép chỉnh sửa dữ liệu trong GridView
            gridView.OptionsBehavior.Editable = false;

            // Thiết lập cột và cấu hình hiển thị
            gridView.Columns.Clear(); // Xóa các cột cũ để tránh xung đột

            // Thêm cột "ma_san_pham"
            var maSPColumn = gridView.Columns.AddVisible("ma_san_pham", "Mã Sản Phẩm");
            maSPColumn.Width = 100;
            maSPColumn.VisibleIndex = 0;

            // Thêm cột "ten_san_pham"
            var tenSPColumn = gridView.Columns.AddVisible("ten_san_pham", "Tên Sản Phẩm");
            tenSPColumn.Width = 200;
            tenSPColumn.VisibleIndex = 1;

            // Thêm cột "gia_cung_cap"
            var giaCungCapColumn = gridView.Columns.AddVisible("gia_cung_cap", "Giá Cung Cấp");
            giaCungCapColumn.Width = 150;
            giaCungCapColumn.VisibleIndex = 2;

            // Ẩn các cột không cần thiết
            gridView.Columns.AddField("created_at").Visible = false;
            gridView.Columns.AddField("ma_nha_cung_cap").Visible = false;
            gridView.Columns.AddField("updated_at").Visible = false;
            gridView.Columns.AddField("nha_cung_cap").Visible = false;
            gridView.Columns.AddField("san_pham").Visible = false;

            // Tự động điều chỉnh chiều rộng của tất cả các cột dựa trên nội dung của chúng
            gridView.BestFitColumns();

            // Làm mới lại `GridView` để cập nhật giao diện
            gridView.RefreshData();
        }

        public void AddEmptyRowToGrid(List<san_pham_custom> sanPhamList)
        {
            // Lấy GridView từ GridControl
            GridView gridView = gct_spncc.MainView as GridView;
            if (gridView == null)
                return;

            // Tạo RepositoryItemLookUpEdit cho ComboBox trong cột `ma_san_pham`
            RepositoryItemLookUpEdit repositoryComboBoxMaSP = new RepositoryItemLookUpEdit
            {
                DataSource = sanPhamList,
                DisplayMember = "ma_san_pham", // Hiển thị mã sản phẩm sau khi chọn
                ValueMember = "ma_san_pham",   // Giá trị là mã sản phẩm khi chọn
                NullText = "Chọn sản phẩm",
                AutoHeight = true
            };

            // Thiết lập cột hiển thị cả mã và tên sản phẩm trong danh sách ComboBox
            repositoryComboBoxMaSP.PopulateColumns();
            repositoryComboBoxMaSP.Columns["ma_san_pham"].Visible = true; // Hiển thị mã sản phẩm trong danh sách
            repositoryComboBoxMaSP.Columns["ten_san_pham"].Visible = true; // Hiển thị tên sản phẩm trong danh sách
            repositoryComboBoxMaSP.Columns["ma_san_pham"].Caption = "Mã Sản Phẩm";
            repositoryComboBoxMaSP.Columns["ten_san_pham"].Caption = "Tên Sản Phẩm";
            repositoryComboBoxMaSP.Columns["gia_binh_quan"].Caption = "Giá Bình Quân";
            repositoryComboBoxMaSP.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;

            // Kích hoạt tìm kiếm theo nhiều cột và tự động hoàn tất
            repositoryComboBoxMaSP.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter; // Kích hoạt tính năng tìm kiếm tự động
            repositoryComboBoxMaSP.AutoSearchColumnIndex = 1; // Mặc định tìm kiếm theo `ten_san_pham` (chỉ số cột bắt đầu từ 0)
            repositoryComboBoxMaSP.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard; // Cho phép nhập liệu vào ô tìm kiếm

            // Đăng ký RepositoryItem vào GridControl
            gct_spncc.RepositoryItems.Add(repositoryComboBoxMaSP);

            // Kiểm tra nếu `DataSource` là một danh sách (`List` hoặc `BindingList`)
            var dataSource = gct_spncc.DataSource as IList<nha_cung_cap_san_pham>;
            if (dataSource != null)
            {
                // Tạo một đối tượng mới và thêm vào danh sách nguồn dữ liệu
                nha_cung_cap_san_pham newRow = new nha_cung_cap_san_pham();
                dataSource.Add(newRow);

                // Cập nhật lại GridControl để hiển thị dòng mới
                gct_spncc.RefreshDataSource();

                // Đặt focus vào dòng mới để người dùng có thể bắt đầu nhập liệu
                int newRowHandle = gridView.GetRowHandle(dataSource.Count - 1);
                gridView.FocusedRowHandle = newRowHandle;

                // Gán RepositoryItem cho cột "ma_san_pham" chỉ trong dòng mới
                gridView.CustomRowCellEdit += (sender, e) =>
                {
                    if (e.RowHandle == newRowHandle && e.Column.FieldName == "ma_san_pham")
                    {
                        e.RepositoryItem = repositoryComboBoxMaSP;
                    }
                };

                // Xử lý sự kiện EditValueChanged để gán mã sản phẩm khi chọn trong ComboBox
                repositoryComboBoxMaSP.EditValueChanged += (sender, e) =>
                {
                    // Lấy giá trị mã sản phẩm từ ComboBox
                    var edit = sender as LookUpEdit;
                    if (edit != null && gridView.FocusedRowHandle == newRowHandle)
                    {
                        var selectedMaSanPham = edit.EditValue; // Lấy mã sản phẩm được chọn

                        // Gán mã sản phẩm vào cột "ma_san_pham" trong dòng mới
                        gridView.SetRowCellValue(newRowHandle, "ma_san_pham", selectedMaSanPham);

                        // Gán các thông tin khác dựa trên mã sản phẩm được chọn
                        var selectedProduct = sanPhamList.FirstOrDefault(p => p.ma_san_pham.Equals(selectedMaSanPham));
                        if (selectedProduct != null)
                        {
                            // Cập nhật các cột khác nếu cần
                            gridView.SetRowCellValue(newRowHandle, "ten_san_pham", selectedProduct.ten_san_pham);
                          
                        }
                    }
                };

                // Đặt chế độ cho phép chỉnh sửa trên GridView
                gridView.OptionsBehavior.Editable = true;
            }
            else
            {
                MessageBox.Show("DataSource của GridControl không phải là List hoặc BindingList.");
            }
        }
        public void SaveAllDataToDatabase()
        {
            // Lấy GridView từ GridControl
            GridView gridView = gct_spncc.MainView as GridView;
            if (gridView == null)
                return;

            // Buộc GridView xác nhận thay đổi hiện tại để lưu giá trị mới nhất
            gridView.CloseEditor();
            gridView.UpdateCurrentRow();

            // Tạo danh sách để lưu các sản phẩm từ GridControl
            List<nha_cung_cap_san_pham> productList = new List<nha_cung_cap_san_pham>();

            // Duyệt qua tất cả các dòng trong GridControl và thu thập dữ liệu
            for (int i = 0; i < gridView.DataRowCount; i++)
            {
                // Lấy dữ liệu từ từng dòng
                int? maSanPham = gridView.GetRowCellValue(i, "ma_san_pham") as int?;
                string tenSanPham = gridView.GetRowCellValue(i, "ten_san_pham") as string;
                decimal? giaCungCap = gridView.GetRowCellValue(i, "gia_cung_cap") as decimal?;
                int? maNhaCungCap = gridView.GetRowCellValue(i, "ma_nha_cung_cap") as int?;

                if (maSanPham.HasValue && maNhaCungCap.HasValue)
                {
                    // Tạo đối tượng nha_cung_cap_san_pham và thêm vào danh sách
                    nha_cung_cap_san_pham product = new nha_cung_cap_san_pham
                    {
                        ma_san_pham = maSanPham.Value,
                        ten_san_pham = tenSanPham,
                        gia_cung_cap = giaCungCap ?? 0,
                        ma_nha_cung_cap = idncc
                    };
                    productList.Add(product);
                }
            }

            // Kiểm tra dữ liệu trong productList
            StringBuilder debugInfo = new StringBuilder();
            debugInfo.AppendLine("Danh sách dữ liệu truyền vào hàm SaveProducts:");
            foreach (var product in productList)
            {
                debugInfo.AppendLine($"ma_san_pham: {product.ma_san_pham}, ten_san_pham: {product.ten_san_pham}, gia_cung_cap: {product.gia_cung_cap}, ma_nha_cung_cap: {product.ma_nha_cung_cap}");
            }

            // Hiển thị thông tin danh sách sản phẩm trong một MessageBox để kiểm tra
            MessageBox.Show(debugInfo.ToString(), "Thông tin dữ liệu trước khi lưu");

            // Tạo instance của BLL và gọi hàm lưu
            ncc_sp_bll = new ncc_sp_sql_BLL();
            bool result = ncc_sp_bll.SaveProducts(productList);

            // Hiển thị thông báo kết quả
            if (result)
            {
                MessageBox.Show("Lưu dữ liệu thành công!","Chúc mừng",MessageBoxButtons.OK,MessageBoxIcon.Information);
                load_dgv_nccsp(idncc);
                checkpoin = 0;
                return;
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra trong quá trình lưu dữ liệu.");
                return;
            }
        }















    }
}
