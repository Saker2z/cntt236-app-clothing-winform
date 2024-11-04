﻿using DevExpress.XtraEditors;
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
    public partial class UC_NhapHangTheoSanPham : DevExpress.XtraEditors.XtraUserControl
    {
        public UC_NhapHangTheoSanPham()
        {
            InitializeComponent();
        }

        private void nhaphangsp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNhapHang frmNhapHang = new frmNhapHang();
            frmNhapHang.Show();
        }
    }
}
