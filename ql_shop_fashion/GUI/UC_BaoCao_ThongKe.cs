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

namespace GUI
{
    public partial class UC_BaoCao_ThongKe : UserControl
    {
        private thong_ke_sql_BLL thongKeBLL;
        public UC_BaoCao_ThongKe()
        {
            InitializeComponent();
            thongKeBLL = new thong_ke_sql_BLL();

            bt_thongketheongay.ItemClick += Bt_thongketheongay_ItemClick;
            bt_thongketheothang.ItemClick += Bt_thongketheothang_ItemClick;
            bt_thongketheonam.ItemClick += Bt_thongketheonam_ItemClick;        
        }

        private void Bt_thongketheothang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DateTime today = DateTime.Now;
            DateTime firstDayOfMonth = new DateTime(today.Year, today.Month, 1);
            DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
            LoadThongKe(firstDayOfMonth, lastDayOfMonth);
        }

        private void Bt_thongketheonam_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DateTime today = DateTime.Now;
            DateTime firstDayOfYear = new DateTime(today.Year, 1, 1);
            DateTime lastDayOfYear = new DateTime(today.Year, 12, 31);
            LoadThongKe(firstDayOfYear, lastDayOfYear);
        }

        private void Bt_thongketheongay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DateTime today = DateTime.Now;
            LoadThongKe(today, today);
        }

        private void LoadThongKe(DateTime fromDate, DateTime toDate)
        {
            // Hiển thị thống kê hóa đơn bán hàng
            var dataHoaDon = thongKeBLL.ThongKeHoaDon(fromDate, toDate);
            gct_hoadon.DataSource = dataHoaDon;

            // Hiển thị thống kê hóa đơn đổi trả
            var dataHoaDonDoiTra = thongKeBLL.ThongKeHoaDonDoiTra(fromDate, toDate);
            gct_hoadondoitra.DataSource = dataHoaDonDoiTra;

            // Cập nhật dữ liệu cho ChartControl
            LoadChart(dataHoaDon, dataHoaDonDoiTra);
        }


        private void LoadChart(List<hoa_don_DTO> dataHoaDon, List<hoa_don_doi_tra_DTO> dataHoaDonDoiTra)
        {
            chart_bc_tk.Series.Clear();

            // Series 1: Hóa đơn bán hàng
            DevExpress.XtraCharts.Series seriesHoaDon = new DevExpress.XtraCharts.Series("Hóa đơn bán hàng", DevExpress.XtraCharts.ViewType.Bar);
            foreach (var item in dataHoaDon)
            {
                seriesHoaDon.Points.Add(new DevExpress.XtraCharts.SeriesPoint($"Mã {item.MaHoaDon}", item.TongSoLuongMua));
            }
            chart_bc_tk.Series.Add(seriesHoaDon);

            // Series 2: Hóa đơn đổi trả
            DevExpress.XtraCharts.Series seriesHoaDonDoiTra = new DevExpress.XtraCharts.Series("Hóa đơn đổi trả", DevExpress.XtraCharts.ViewType.Bar);
            foreach (var item in dataHoaDonDoiTra)
            {
                seriesHoaDonDoiTra.Points.Add(new DevExpress.XtraCharts.SeriesPoint($"Mã {item.MaHoaDon}", item.TongSoLuongTra));
            }
            chart_bc_tk.Series.Add(seriesHoaDonDoiTra);

            // Tùy chỉnh giao diện biểu đồ (tùy chọn)
            chart_bc_tk.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            chart_bc_tk.Titles.Clear();
            chart_bc_tk.Titles.Add(new DevExpress.XtraCharts.ChartTitle { Text = "Thống kê bán hàng và đổi trả" });
        }

    }
}
