using DevExpress.XtraReports.UI;
using System.Drawing;

namespace GUI
{
    public partial class nhaphang_rp : XtraReport
    {
        public nhaphang_rp()
        {
            InitializeComponent();

            // Tạo DetailBand để chứa toàn bộ nội dung và thêm vào báo cáo trước
            DetailBand detailBand = new DetailBand();
            this.Bands.Add(detailBand); // Đảm bảo thêm DetailBand vào báo cáo trước khi thêm các điều khiển vào

            // Tạo tiêu đề cho báo cáo
            XRLabel headerLabel = new XRLabel
            {
                Text = "PHIẾU NHẬP KHO",
                Font = new Font("Arial", 16, FontStyle.Bold),
                TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter,
                BoundsF = new RectangleF(0, 0, this.PageWidth - this.Margins.Left - this.Margins.Right, 30)
            };
            detailBand.Controls.Add(headerLabel);

            // Tạo bảng đơn giản với một dòng tiêu đề và một dòng dữ liệu
            XRTable table = new XRTable { BoundsF = new RectangleF(0, 40, this.PageWidth - this.Margins.Left - this.Margins.Right, 25) };
            table.BeginInit();

            XRTableRow headerRow = new XRTableRow();
            headerRow.Cells.Add(new XRTableCell { Text = "Mã sản phẩm" });
            headerRow.Cells.Add(new XRTableCell { Text = "Tên sản phẩm" });
            headerRow.Cells.Add(new XRTableCell { Text = "Số lượng" });
            headerRow.Cells.Add(new XRTableCell { Text = "Đơn giá" });
            headerRow.Cells.Add(new XRTableCell { Text = "Thành tiền" });
            table.Rows.Add(headerRow);

            XRTableRow dataRow = new XRTableRow();
            dataRow.Cells.Add(new XRTableCell { Text = "SP001" });
            dataRow.Cells.Add(new XRTableCell { Text = "Áo sơ mi" });
            dataRow.Cells.Add(new XRTableCell { Text = "10" });
            dataRow.Cells.Add(new XRTableCell { Text = "100.000" });
            dataRow.Cells.Add(new XRTableCell { Text = "1.000.000" });
            table.Rows.Add(dataRow);

            table.EndInit();
            detailBand.Controls.Add(table);
        }
    }
}
