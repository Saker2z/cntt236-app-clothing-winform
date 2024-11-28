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

            chart_bc_tk.ObjectSelected += Chart_bc_tk_ObjectSelected;
        }

        private void Chart_bc_tk_ObjectSelected(object sender, DevExpress.XtraCharts.HotTrackEventArgs e)
        {
            if (e.HitInfo.InSeries)
            {
                var seriesPoint = e.HitInfo.SeriesPoint;
                MessageBox.Show($"Sản phẩm: {seriesPoint.Argument}\nSố lượng: {seriesPoint.Values[0]}");
            }
        }

        private void Bt_thongketheongay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DateTime today = DateTime.Now;
            var data = thongKeBLL.ThongKeTheoNgay(today);

            if (data == null || data.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu thống kê trong ngày hôm nay.");
                return;
            }

            // Hiển thị dữ liệu lên GridControl
            gct_hoadon.DataSource = data;

            // Vẽ biểu đồ
            DisplayDailyStatistics(data);
        }

        private void Bt_thongketheothang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DateTime today = DateTime.Now;
            var data = thongKeBLL.ThongKeTheoThang(today.Month, today.Year);
            DisplayMonthlyStatistics(data);
        }

        private void Bt_thongketheonam_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DateTime today = DateTime.Now;
            var data = thongKeBLL.ThongKeTheoNam(today.Year);
            DisplayYearlyStatistics(data);
        }


        private void DisplayDailyStatistics(List<thong_ke_theo_ngay_DTO> data)
        {
            chart_bc_tk.Series.Clear();
            var series = new DevExpress.XtraCharts.Series("Bán hàng theo ngày", DevExpress.XtraCharts.ViewType.Bar);

            foreach (var item in data)
            {
                series.Points.Add(new DevExpress.XtraCharts.SeriesPoint($"SP {item.ProductID}", item.TotalQuantity));
            }

            series.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            chart_bc_tk.Series.Add(series);

            chart_bc_tk.Titles.Clear();
            chart_bc_tk.Titles.Add(new DevExpress.XtraCharts.ChartTitle { Text = "Thống kê bán hàng theo ngày" });
        }



        private void DisplayMonthlyStatistics(List<thong_ke_theo_thang_DTO> data)
        {
            if (data == null || data.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để hiển thị.");
                return;
            }

            gct_hoadon.DataSource = data;

            chart_bc_tk.Series.Clear();
            var series = new DevExpress.XtraCharts.Series("Bán hàng theo tháng", DevExpress.XtraCharts.ViewType.Line);

            foreach (var item in data)
            {
                series.Points.Add(new DevExpress.XtraCharts.SeriesPoint($"SP {item.ProductID}", item.TotalQuantitySold));
            }

            series.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            chart_bc_tk.Series.Add(series);

            ConfigureChartAxis("Sản phẩm", "Số lượng");

            chart_bc_tk.Titles.Clear();
            chart_bc_tk.Titles.Add(new DevExpress.XtraCharts.ChartTitle { Text = "Thống kê bán hàng theo tháng" });
        }


        private void DisplayYearlyStatistics(List<thong_ke_theo_nam_DTO> data)
        {
            if (data == null || data.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để hiển thị.");
                return;
            }

            gct_hoadon.DataSource = data;

            chart_bc_tk.Series.Clear();
            var series = new DevExpress.XtraCharts.Series("Bán hàng theo năm", DevExpress.XtraCharts.ViewType.Pie);

            foreach (var item in data)
            {
                series.Points.Add(new DevExpress.XtraCharts.SeriesPoint($"SP {item.ProductID}", item.TotalQuantitySold));
            }

            series.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            chart_bc_tk.Series.Add(series);

            chart_bc_tk.Titles.Clear();
            chart_bc_tk.Titles.Add(new DevExpress.XtraCharts.ChartTitle { Text = "Thống kê bán hàng theo năm" });
        }


        private void ConfigureChartAxis(string xAxisTitle, string yAxisTitle)
        {
            var diagram = chart_bc_tk.Diagram as DevExpress.XtraCharts.XYDiagram;
            if (diagram != null)
            {
                // Cấu hình trục X
                diagram.AxisX.Title.Text = xAxisTitle;
                diagram.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
                diagram.AxisX.Title.Alignment = StringAlignment.Center;

                // Cấu hình trục Y
                diagram.AxisY.Title.Text = yAxisTitle;
                diagram.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;

                // Hiển thị lưới trục Y
                diagram.AxisY.GridLines.Visible = true;
            }
        }



    }
}
