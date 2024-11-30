using System;
using System.Windows.Forms;

namespace GUI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                // Tải chuỗi kết nối từ JSON
                DTO.DatabaseConfig.LoadConnectionString();
            }
            catch (Exception ex)
            {
                // Yêu cầu người dùng nhập thông tin kết nối nếu không có file JSON hoặc chuỗi không hợp lệ
                MessageBox.Show(ex.Message, "Cấu hình kết nối", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                using (frm_knoi frm = new frm_knoi())
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        // Sau khi lưu, thử kết nối lại
                        MessageBox.Show("Cấu hình thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ứng dụng cần cấu hình kết nối để chạy.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            // Chạy form chính
            Application.Run(new frmDangNhap());
        }
    }
}
