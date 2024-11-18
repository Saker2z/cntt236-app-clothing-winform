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
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;


namespace GUI
{
    public partial class frmThemSPVaoThongTin : DevExpress.XtraEditors.XtraForm
    {
        private san_pham_sql_BLL sp_bll;
        private thong_tin_sp_sql_BLL thong_tin_bll;
        public frmThemSPVaoThongTin()
        {
            InitializeComponent();
            this.Load += FrmThemSPVaoThongTin_Load;
            thong_tin_bll = new thong_tin_sp_sql_BLL();
            sp_bll = new san_pham_sql_BLL();

            btn_themspvaott.Click += Btn_themspvaott_Click;
            btn_xoaspkhoitt.Click += Btn_xoaspkhoitt_Click;
            btn_suasptrongtt.Click += Btn_suasptrongtt_Click;
            btn_load.Click += Btn_load_Click;

            GridView gv_ttsp = gct_ttsp.MainView as GridView;
            gv_ttsp.Click += Gv_ttsp_Click;
        }

        private void Gv_ttsp_Click(object sender, EventArgs e)
        {
            loadTTSPLenControls();
        }

        private void Btn_load_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void Btn_suasptrongtt_Click(object sender, EventArgs e)
        {
            suaSPTrongTT();
        }

        private void Btn_xoaspkhoitt_Click(object sender, EventArgs e)
        {
            xoaSPKhoiTT();
        }

        private void Btn_themspvaott_Click(object sender, EventArgs e)
        {
            themSPVaoTT();
        }

        private void FrmThemSPVaoThongTin_Load(object sender, EventArgs e)
        {
            loadThongTinSP();
            loadMaThongTinLenCombobox();
            loadMaSanPhamLenCombobox();
        }


        private void loadThongTinSP()
        {
            try
            {
                // Khởi tạo lớp BLL và lấy dữ liệu sản phẩm
                thong_tin_bll = new thong_tin_sp_sql_BLL();
                var allRecords = thong_tin_bll.get_all_ttsp();

                // Gắn dữ liệu vào GridControl
                gct_ttsp.DataSource = allRecords;

                // Cấu hình GridView
                GridView gridView = gct_ttsp.MainView as GridView;
                if (gridView != null)
                {
                    gridView.OptionsBehavior.Editable = false;

                    // Đặt tên hiển thị cho các cột
                    gridView.Columns["ma_thong_tin_san_pham"].Caption = "Mã Thông Tin Sản Phẩm";
                    gridView.Columns["ma_san_pham"].Caption = "Mã Sản Phẩm";
                    gridView.Columns["key_attribute"].Caption = "Thuộc Tính";
                    gridView.Columns["value_attribute"].Caption = "Thông Tin Của Thuộc Tính";

                    // Tự động điều chỉnh kích thước các cột
                    gridView.BestFitColumns();

                    // Đảm bảo các cột không thể chỉnh sửa
                    foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView.Columns)
                    {
                        column.OptionsColumn.AllowEdit = false;
                        column.OptionsColumn.AllowFocus = false;
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Lỗi khi tải thông tin sản phẩm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void loadMaThongTinLenCombobox()
        {
            try
            {
                List<thong_tin_sanpham_DTO> List = thong_tin_bll.get_all_ttsp();

                // Xóa các item cũ
                cbb_mathongtin.Properties.Items.Clear();

                // Thêm dữ liệu vào ComboBoxEdit thủ công
                foreach (var nhomLoai in List)
                {
                    cbb_mathongtin.Properties.Items.Add(nhomLoai.ma_thong_tin_san_pham);
                }

                // Không chọn mục nào mặc định
                cbb_mathongtin.EditValue = null;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void loadMaSanPhamLenCombobox()
        {
            try
            {
                List<san_pham_DTO> List = sp_bll.get_all_sp();

                // Xóa các item cũ
                cbb_masanpham.Properties.Items.Clear();

                // Thêm dữ liệu vào ComboBoxEdit thủ công
                foreach (var nhomLoai in List)
                {
                    cbb_masanpham.Properties.Items.Add(nhomLoai.ma_san_pham);
                }

                // Không chọn mục nào mặc định
                cbb_masanpham.EditValue = null;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void loadTTSPLenControls()
        {
            GridView gridView = gct_ttsp.MainView as GridView;
            if (gridView != null && gridView.FocusedRowHandle >= 0)
            {
                // Get the selected "ma_san_pham" and "ma_thong_tin_san_pham"
                int maSanPham = Convert.ToInt32(gridView.GetFocusedRowCellValue("ma_san_pham"));
                int maThongTin = Convert.ToInt32(gridView.GetFocusedRowCellValue("ma_thong_tin_san_pham"));

                // Set the combo box values based on the selected row
                cbb_masanpham.EditValue = maSanPham;
                cbb_mathongtin.EditValue = maThongTin;
            }
        }



        private void clear()
        {
            cbb_masanpham.EditValue = null;
            cbb_mathongtin.EditValue = null;
        }

        private bool kiemTra()
        {

            // Kiểm tra ComboBox Mã Loại
            if (cbb_masanpham.SelectedItem == null)
            {
                XtraMessageBox.Show("Vui lòng chọn mã sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbb_masanpham.Focus();
                return false;
            }

            // Kiểm tra ComboBox Mã Thương Hiệu
            if (cbb_mathongtin.SelectedItem == null)
            {
                XtraMessageBox.Show("Vui lòng chọn mã thông tin sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbb_mathongtin.Focus();
                return false;
            }

            // Nếu tất cả các kiểm tra đều hợp lệ
            return true;
        }


        private void themSPVaoTT()
        {
            if (!kiemTra())
            {
                return;
            }

            try
            {
                // Validate input
                if (int.TryParse(cbb_masanpham.EditValue?.ToString(), out int newMaSanPham) &&
                    int.TryParse(cbb_mathongtin.EditValue?.ToString(), out int selectedMaThongTin))
                {
                    // Retrieve the existing record for the selected ma_thong_tin_san_pham
                    var existingInfo = thong_tin_bll.getThongTinSanPhamByMaTT(selectedMaThongTin);

                    if (existingInfo != null)
                    {
                        // Automatically increment the ma_thong_tin_san_pham for the new record
                        int newMaThongTin = thong_tin_bll.getNextMaThongTin();

                        // Create a new record using the retrieved information
                        thong_tin_sanpham_DTO newInfo = new thong_tin_sanpham_DTO
                        {
                            ma_thong_tin_san_pham = newMaThongTin,
                            ma_san_pham = newMaSanPham,
                            key_attribute = existingInfo.key_attribute,
                            value_attribute = existingInfo.value_attribute
                        };

                        // Add the new record to the database
                        if (thong_tin_bll.addThongTinSanPham(newInfo))
                        {
                            MessageBox.Show("Thêm thông tin sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadThongTinSP();
                            clear();
                        }
                        else
                        {
                            XtraMessageBox.Show("Thêm thông tin sản phẩm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Không tìm thấy thông tin sản phẩm với mã thông tin được chọn.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    XtraMessageBox.Show("Dữ liệu không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void suaSPTrongTT()
        {
            try
            {
                if (int.TryParse(cbb_masanpham.EditValue?.ToString(), out int maSanPham) &&
                    int.TryParse(cbb_mathongtin.EditValue?.ToString(), out int maThongTin))
                {
                    // Get the corresponding key_attribute from the mapping
                    if (!attributeMapping.TryGetValue(maThongTin, out string keyAttribute))
                    {
                        XtraMessageBox.Show("Mã thông tin không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    thong_tin_sanpham_DTO updatedInfo = new thong_tin_sanpham_DTO
                    {
                        ma_thong_tin_san_pham = maThongTin,
                        ma_san_pham = maSanPham,
                        key_attribute = keyAttribute,
                        value_attribute = "Giá trị đã chỉnh sửa" // Default or user-input value
                    };

                    if (thong_tin_bll.updateThongTinSanPham(updatedInfo))
                    {
                        XtraMessageBox.Show("Cập nhật thông tin sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadThongTinSP();
                        clear();
                    }
                    else
                    {
                        XtraMessageBox.Show("Cập nhật thông tin sản phẩm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    XtraMessageBox.Show("Vui lòng chọn thông tin hợp lệ để sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void xoaSPKhoiTT()
        {
            try
            {
                if (int.TryParse(cbb_mathongtin.EditValue?.ToString(), out int maThongTin))
                {
                    if (thong_tin_bll.deleteThongTinSanPham(maThongTin))
                    {
                        XtraMessageBox.Show("Xóa thông tin sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadThongTinSP();
                        clear();
                    }
                    else
                    {
                        XtraMessageBox.Show("Xóa thông tin sản phẩm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    XtraMessageBox.Show("Vui lòng chọn thông tin hợp lệ để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        


        private Dictionary<int, string> attributeMapping = new Dictionary<int, string>
        {
            { 1, "Kích thước" },
            { 2, "Màu sắc" },
            { 3, "Chất liệu" },
            { 4, "Phong cách" },
            { 5, "Hướng dẫn bảo quản" },
            { 6, "Đối tượng sử dụng" },
            { 7, "Xuất xứ" },
            { 8, "Thời gian bảo hành" }
        };

    }
}