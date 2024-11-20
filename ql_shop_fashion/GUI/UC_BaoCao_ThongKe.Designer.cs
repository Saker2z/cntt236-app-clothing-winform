
namespace GUI
{
    partial class UC_BaoCao_ThongKe
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            this.pnl_chinh = new System.Windows.Forms.Panel();
            this.gct_hoadondoitra = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bt_thongketheongay = new DevExpress.XtraBars.BarButtonItem();
            this.bt_thongketheothang = new DevExpress.XtraBars.BarButtonItem();
            this.bt_thongketheonam = new DevExpress.XtraBars.BarButtonItem();
            this.bt_xuatbaocao = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gct_hoadon = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.chart_bc_tk = new DevExpress.XtraCharts.ChartControl();
            this.pnl_chinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gct_hoadondoitra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gct_hoadon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_bc_tk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_chinh
            // 
            this.pnl_chinh.Controls.Add(this.gct_hoadondoitra);
            this.pnl_chinh.Controls.Add(this.gct_hoadon);
            this.pnl_chinh.Controls.Add(this.chart_bc_tk);
            this.pnl_chinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_chinh.Location = new System.Drawing.Point(0, 20);
            this.pnl_chinh.Name = "pnl_chinh";
            this.pnl_chinh.Size = new System.Drawing.Size(995, 599);
            this.pnl_chinh.TabIndex = 0;
            // 
            // gct_hoadondoitra
            // 
            this.gct_hoadondoitra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gct_hoadondoitra.Location = new System.Drawing.Point(489, 295);
            this.gct_hoadondoitra.MainView = this.gridView2;
            this.gct_hoadondoitra.MenuManager = this.barManager1;
            this.gct_hoadondoitra.Name = "gct_hoadondoitra";
            this.gct_hoadondoitra.Size = new System.Drawing.Size(506, 304);
            this.gct_hoadondoitra.TabIndex = 2;
            this.gct_hoadondoitra.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gct_hoadondoitra;
            this.gridView2.Name = "gridView2";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bt_thongketheongay,
            this.bt_thongketheothang,
            this.bt_thongketheonam,
            this.bt_xuatbaocao});
            this.barManager1.MaxItemId = 4;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bt_thongketheongay),
            new DevExpress.XtraBars.LinkPersistInfo(this.bt_thongketheothang),
            new DevExpress.XtraBars.LinkPersistInfo(this.bt_thongketheonam),
            new DevExpress.XtraBars.LinkPersistInfo(this.bt_xuatbaocao)});
            this.bar1.Text = "Tools";
            // 
            // bt_thongketheongay
            // 
            this.bt_thongketheongay.Caption = "Thống kê theo ngày";
            this.bt_thongketheongay.Id = 0;
            this.bt_thongketheongay.Name = "bt_thongketheongay";
            // 
            // bt_thongketheothang
            // 
            this.bt_thongketheothang.Caption = "Thống kê theo tháng";
            this.bt_thongketheothang.Id = 1;
            this.bt_thongketheothang.Name = "bt_thongketheothang";
            // 
            // bt_thongketheonam
            // 
            this.bt_thongketheonam.Caption = "Thống kê theo năm";
            this.bt_thongketheonam.Id = 2;
            this.bt_thongketheonam.Name = "bt_thongketheonam";
            // 
            // bt_xuatbaocao
            // 
            this.bt_xuatbaocao.Caption = "Xuất báo cáo";
            this.bt_xuatbaocao.Id = 3;
            this.bt_xuatbaocao.Name = "bt_xuatbaocao";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(995, 20);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 619);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(995, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 599);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(995, 20);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 599);
            // 
            // gct_hoadon
            // 
            this.gct_hoadon.Dock = System.Windows.Forms.DockStyle.Left;
            this.gct_hoadon.Location = new System.Drawing.Point(0, 295);
            this.gct_hoadon.MainView = this.gridView1;
            this.gct_hoadon.MenuManager = this.barManager1;
            this.gct_hoadon.Name = "gct_hoadon";
            this.gct_hoadon.Size = new System.Drawing.Size(489, 304);
            this.gct_hoadon.TabIndex = 1;
            this.gct_hoadon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gct_hoadon;
            this.gridView1.Name = "gridView1";
            // 
            // chart_bc_tk
            // 
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chart_bc_tk.Diagram = xyDiagram1;
            this.chart_bc_tk.Dock = System.Windows.Forms.DockStyle.Top;
            this.chart_bc_tk.Legend.Name = "Default Legend";
            this.chart_bc_tk.Location = new System.Drawing.Point(0, 0);
            this.chart_bc_tk.Name = "chart_bc_tk";
            series1.Name = "Series 1";
            this.chart_bc_tk.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chart_bc_tk.Size = new System.Drawing.Size(995, 295);
            this.chart_bc_tk.TabIndex = 0;
            // 
            // UC_BaoCao_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_chinh);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "UC_BaoCao_ThongKe";
            this.Size = new System.Drawing.Size(995, 619);
            this.pnl_chinh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gct_hoadondoitra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gct_hoadon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_bc_tk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_chinh;
        private DevExpress.XtraCharts.ChartControl chart_bc_tk;
        private DevExpress.XtraGrid.GridControl gct_hoadon;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem bt_thongketheongay;
        private DevExpress.XtraBars.BarButtonItem bt_thongketheothang;
        private DevExpress.XtraBars.BarButtonItem bt_thongketheonam;
        private DevExpress.XtraBars.BarButtonItem bt_xuatbaocao;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gct_hoadondoitra;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
    }
}
