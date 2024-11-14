using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class UC_NhanVien : UserControl
    {
        public UC_NhanVien()
        {
            InitializeComponent();
            bt_them.Click += Bt_them_Click;
        }

        private void Bt_them_Click(object sender, EventArgs e)
        {
            add_NV them_nv = new add_NV(Properties.Settings.Default.name_role);
            them_nv.ShowDialog();
        }
    }
}
