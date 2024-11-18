using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace GUI
{
    public partial class HoaDon : DevExpress.XtraReports.UI.XtraReport
    {
       public decimal tienKhachTra;
        public HoaDon()
        {
            InitializeComponent();
        }

        public decimal TienKhachTra { get => tienKhachTra; set => tienKhachTra = value; }
    }
    
}
