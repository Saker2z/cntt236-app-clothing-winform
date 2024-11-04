using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void LoadGifToPictureBox(string filePath)
        {
            if (File.Exists(filePath)) // Kiểm tra xem file có tồn tại không
            {
                background.Image = Image.FromFile(filePath);
                background.SizeMode = PictureBoxSizeMode.StretchImage; // Để ảnh lấp đầy PictureBox
            }
            else
            {
                MessageBox.Show("Không tìm thấy file GIF!");
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            string filePath = @"..\..\Resources\background_dn.gif"; // Đường dẫn đến ảnh GIF của bạn
            LoadGifToPictureBox(filePath);

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int radius = 20;

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);

            this.Region = new Region(path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }

        }

        private void dangnhap_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            this.Hide();
            main.Show();
            main.FormClosed += (s, args) => this.Close();
        }
    }
}