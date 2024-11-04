
namespace GUI
{
    partial class UC_NhapHangTheoNCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_NhapHangTheoNCC));
            this.menuchucnang = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.themncc = new DevExpress.XtraBars.BarButtonItem();
            this.suancc = new DevExpress.XtraBars.BarButtonItem();
            this.xoancc = new DevExpress.XtraBars.BarButtonItem();
            this.nhaphangncc = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.txt_tenncc = new DevExpress.XtraEditors.TextEdit();
            this.timkiemncc = new DevExpress.XtraEditors.LabelControl();
            this.timkiemsanphamcuancc = new DevExpress.XtraEditors.LabelControl();
            this.txt_timkiemsanphamcuancc = new DevExpress.XtraEditors.TextEdit();
            this.panel_chinh = new System.Windows.Forms.Panel();
            this.dgv_ncc = new System.Windows.Forms.DataGridView();
            this.dgv_sanphamcuancc = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.menuchucnang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tenncc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_timkiemsanphamcuancc.Properties)).BeginInit();
            this.panel_chinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ncc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sanphamcuancc)).BeginInit();
            this.SuspendLayout();
            // 
            // menuchucnang
            // 
            this.menuchucnang.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.menuchucnang.DockControls.Add(this.barDockControlTop);
            this.menuchucnang.DockControls.Add(this.barDockControlBottom);
            this.menuchucnang.DockControls.Add(this.barDockControlLeft);
            this.menuchucnang.DockControls.Add(this.barDockControlRight);
            this.menuchucnang.Form = this;
            this.menuchucnang.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.themncc,
            this.suancc,
            this.xoancc,
            this.nhaphangncc});
            this.menuchucnang.MaxItemId = 5;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.themncc, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.suancc, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.xoancc, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.nhaphangncc, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // themncc
            // 
            this.themncc.Caption = "Thêm";
            this.themncc.Id = 0;
            this.themncc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("them.ImageOptions.Image")));
            this.themncc.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("them.ImageOptions.LargeImage")));
            this.themncc.Name = "themncc";
            this.themncc.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // suancc
            // 
            this.suancc.Caption = "Sửa";
            this.suancc.Id = 1;
            this.suancc.ImageOptions.DisabledImage = ((System.Drawing.Image)(resources.GetObject("sua.ImageOptions.DisabledImage")));
            this.suancc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sua.ImageOptions.Image")));
            this.suancc.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("sua.ImageOptions.LargeImage")));
            this.suancc.Name = "suancc";
            // 
            // xoancc
            // 
            this.xoancc.Caption = "Xóa";
            this.xoancc.Id = 2;
            this.xoancc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xoa.ImageOptions.Image")));
            this.xoancc.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("xoa.ImageOptions.LargeImage")));
            this.xoancc.Name = "xoancc";
            // 
            // nhaphangncc
            // 
            this.nhaphangncc.Caption = "Nhập Hàng";
            this.nhaphangncc.Id = 4;
            this.nhaphangncc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("nhaphang.ImageOptions.Image")));
            this.nhaphangncc.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("nhaphang.ImageOptions.LargeImage")));
            this.nhaphangncc.Name = "nhaphangncc";
            this.nhaphangncc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.nhaphang_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.menuchucnang;
            this.barDockControlTop.Size = new System.Drawing.Size(835, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 614);
            this.barDockControlBottom.Manager = this.menuchucnang;
            this.barDockControlBottom.Size = new System.Drawing.Size(835, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.menuchucnang;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 590);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(835, 24);
            this.barDockControlRight.Manager = this.menuchucnang;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 590);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Nhập Hàng";
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // txt_tenncc
            // 
            this.txt_tenncc.Location = new System.Drawing.Point(3, 30);
            this.txt_tenncc.MenuManager = this.menuchucnang;
            this.txt_tenncc.Name = "txt_tenncc";
            this.txt_tenncc.Size = new System.Drawing.Size(381, 20);
            this.txt_tenncc.TabIndex = 4;
            // 
            // timkiemncc
            // 
            this.timkiemncc.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.timkiemncc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("timkiemncc.ImageOptions.Image")));
            this.timkiemncc.Location = new System.Drawing.Point(390, 6);
            this.timkiemncc.Name = "timkiemncc";
            this.timkiemncc.Size = new System.Drawing.Size(23, 20);
            this.timkiemncc.TabIndex = 5;
            // 
            // timkiemsanphamcuancc
            // 
            this.timkiemsanphamcuancc.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.timkiemsanphamcuancc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("timkiemsanphamcuancc.ImageOptions.Image")));
            this.timkiemsanphamcuancc.Location = new System.Drawing.Point(809, 6);
            this.timkiemsanphamcuancc.Name = "timkiemsanphamcuancc";
            this.timkiemsanphamcuancc.Size = new System.Drawing.Size(23, 20);
            this.timkiemsanphamcuancc.TabIndex = 9;
            // 
            // txt_timkiemsanphamcuancc
            // 
            this.txt_timkiemsanphamcuancc.Location = new System.Drawing.Point(422, 6);
            this.txt_timkiemsanphamcuancc.MenuManager = this.menuchucnang;
            this.txt_timkiemsanphamcuancc.Name = "txt_timkiemsanphamcuancc";
            this.txt_timkiemsanphamcuancc.Size = new System.Drawing.Size(381, 20);
            this.txt_timkiemsanphamcuancc.TabIndex = 8;
            // 
            // panel_chinh
            // 
            this.panel_chinh.Controls.Add(this.dgv_ncc);
            this.panel_chinh.Controls.Add(this.dgv_sanphamcuancc);
            this.panel_chinh.Controls.Add(this.timkiemsanphamcuancc);
            this.panel_chinh.Controls.Add(this.txt_timkiemsanphamcuancc);
            this.panel_chinh.Controls.Add(this.timkiemncc);
            this.panel_chinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_chinh.Location = new System.Drawing.Point(0, 24);
            this.panel_chinh.Name = "panel_chinh";
            this.panel_chinh.Size = new System.Drawing.Size(835, 590);
            this.panel_chinh.TabIndex = 10;
            // 
            // dgv_ncc
            // 
            this.dgv_ncc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ncc.Location = new System.Drawing.Point(3, 32);
            this.dgv_ncc.Name = "dgv_ncc";
            this.dgv_ncc.Size = new System.Drawing.Size(410, 555);
            this.dgv_ncc.TabIndex = 11;
            // 
            // dgv_sanphamcuancc
            // 
            this.dgv_sanphamcuancc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sanphamcuancc.Location = new System.Drawing.Point(422, 32);
            this.dgv_sanphamcuancc.Name = "dgv_sanphamcuancc";
            this.dgv_sanphamcuancc.Size = new System.Drawing.Size(410, 555);
            this.dgv_sanphamcuancc.TabIndex = 10;
            // 
            // UC_NhapHangTheoNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_tenncc);
            this.Controls.Add(this.panel_chinh);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "UC_NhapHangTheoNCC";
            this.Size = new System.Drawing.Size(835, 614);
            ((System.ComponentModel.ISupportInitialize)(this.menuchucnang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tenncc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_timkiemsanphamcuancc.Properties)).EndInit();
            this.panel_chinh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ncc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sanphamcuancc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager menuchucnang;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem themncc;
        private DevExpress.XtraBars.BarButtonItem suancc;
        private DevExpress.XtraBars.BarButtonItem xoancc;
        private DevExpress.XtraBars.BarButtonItem nhaphangncc;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraEditors.TextEdit txt_tenncc;
        private DevExpress.XtraEditors.LabelControl timkiemncc;
        private DevExpress.XtraEditors.LabelControl timkiemsanphamcuancc;
        private DevExpress.XtraEditors.TextEdit txt_timkiemsanphamcuancc;
        private System.Windows.Forms.Panel panel_chinh;
        private System.Windows.Forms.DataGridView dgv_ncc;
        private System.Windows.Forms.DataGridView dgv_sanphamcuancc;
    }
}
