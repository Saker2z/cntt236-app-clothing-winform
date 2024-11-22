
namespace GUI
{
    partial class them_ncc
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(them_ncc));
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dt = new DevExpress.XtraEditors.TextEdit();
            this.dc = new DevExpress.XtraEditors.TextEdit();
            this.ten_ncc = new DevExpress.XtraEditors.TextEdit();
            this.pnl_themncc = new System.Windows.Forms.Panel();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btthem = new DevExpress.XtraBars.BarButtonItem();
            this.btthoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.dt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ten_ncc.Properties)).BeginInit();
            this.pnl_themncc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(36, 159);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(79, 17);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "Số điện thoại";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(36, 97);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 17);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "Địa chỉ";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(36, 42);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(111, 17);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Tên nhà cung cấp";
            // 
            // dt
            // 
            this.dt.Location = new System.Drawing.Point(197, 151);
            this.dt.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(304, 22);
            this.dt.TabIndex = 12;
            // 
            // dc
            // 
            this.dc.Location = new System.Drawing.Point(197, 94);
            this.dc.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dc.Name = "dc";
            this.dc.Size = new System.Drawing.Size(304, 22);
            this.dc.TabIndex = 11;
            // 
            // ten_ncc
            // 
            this.ten_ncc.Location = new System.Drawing.Point(197, 38);
            this.ten_ncc.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ten_ncc.Name = "ten_ncc";
            this.ten_ncc.Size = new System.Drawing.Size(304, 22);
            this.ten_ncc.TabIndex = 10;
            // 
            // pnl_themncc
            // 
            this.pnl_themncc.BackColor = System.Drawing.Color.White;
            this.pnl_themncc.Controls.Add(this.labelControl2);
            this.pnl_themncc.Controls.Add(this.ten_ncc);
            this.pnl_themncc.Controls.Add(this.labelControl4);
            this.pnl_themncc.Controls.Add(this.dc);
            this.pnl_themncc.Controls.Add(this.labelControl3);
            this.pnl_themncc.Controls.Add(this.dt);
            this.pnl_themncc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_themncc.Location = new System.Drawing.Point(0, 30);
            this.pnl_themncc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_themncc.Name = "pnl_themncc";
            this.pnl_themncc.Size = new System.Drawing.Size(569, 228);
            this.pnl_themncc.TabIndex = 18;
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
            this.btthem,
            this.btthoat});
            this.barManager1.MaxItemId = 2;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btthem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btthoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btthem
            // 
            this.btthem.Caption = "Thêm Mới";
            this.btthem.Id = 0;
            this.btthem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btthem.ImageOptions.Image")));
            this.btthem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btthem.ImageOptions.LargeImage")));
            this.btthem.Name = "btthem";
            // 
            // btthoat
            // 
            this.btthoat.Caption = "Thoát";
            this.btthoat.Id = 1;
            this.btthoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btthoat.ImageOptions.Image")));
            this.btthoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btthoat.ImageOptions.LargeImage")));
            this.btthoat.Name = "btthoat";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(569, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 258);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(569, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 228);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(569, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 228);
            // 
            // them_ncc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 258);
            this.Controls.Add(this.pnl_themncc);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "them_ncc";
            this.Text = "them_ncc";
            ((System.ComponentModel.ISupportInitialize)(this.dt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ten_ncc.Properties)).EndInit();
            this.pnl_themncc.ResumeLayout(false);
            this.pnl_themncc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit dt;
        private DevExpress.XtraEditors.TextEdit dc;
        private DevExpress.XtraEditors.TextEdit ten_ncc;
        private System.Windows.Forms.Panel pnl_themncc;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btthem;
        private DevExpress.XtraBars.BarButtonItem btthoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}