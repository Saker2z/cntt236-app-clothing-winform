
namespace GUI
{
    partial class frmNhapHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapHang));
            this.menuchucnang = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.them = new DevExpress.XtraBars.BarButtonItem();
            this.sua = new DevExpress.XtraBars.BarButtonItem();
            this.xoa = new DevExpress.XtraBars.BarButtonItem();
            this.thoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.txt_manhaphang = new DevExpress.XtraEditors.TextEdit();
            this.txt_manhanvien = new DevExpress.XtraEditors.TextEdit();
            this.txt_ghichu = new DevExpress.XtraEditors.TextEdit();
            this.txt_tongsoluong = new DevExpress.XtraEditors.TextEdit();
            this.txt_tonggiatien = new DevExpress.XtraEditors.TextEdit();
            this.cbb_manhacungcap = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbb_trangthai = new DevExpress.XtraEditors.ComboBoxEdit();
            this.panel_chinh = new System.Windows.Forms.Panel();
            this.dgv_sanpham = new System.Windows.Forms.DataGridView();
            this.timkiemsanpham = new DevExpress.XtraEditors.LabelControl();
            this.txt_sanpham = new DevExpress.XtraEditors.TextEdit();
            this.timkiemncc = new DevExpress.XtraEditors.LabelControl();
            this.txt_tenncc = new DevExpress.XtraEditors.TextEdit();
            this.dgv_nh = new System.Windows.Forms.DataGridView();
            this.lb_trangthai = new DevExpress.XtraEditors.LabelControl();
            this.lb_tongtien = new DevExpress.XtraEditors.LabelControl();
            this.lb_tongsoluong = new DevExpress.XtraEditors.LabelControl();
            this.lb_ghichu = new DevExpress.XtraEditors.LabelControl();
            this.lb_manhacungcap = new DevExpress.XtraEditors.LabelControl();
            this.lb_ngaynhap = new DevExpress.XtraEditors.LabelControl();
            this.lb_manhanvien = new DevExpress.XtraEditors.LabelControl();
            this.lb_manhaphang = new DevExpress.XtraEditors.LabelControl();
            this.ngaynhap = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.menuchucnang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_manhaphang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_manhanvien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ghichu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tongsoluong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tonggiatien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_manhacungcap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_trangthai.Properties)).BeginInit();
            this.panel_chinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sanpham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sanpham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tenncc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngaynhap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngaynhap.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // menuchucnang
            // 
            this.menuchucnang.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.menuchucnang.DockControls.Add(this.barDockControlTop);
            this.menuchucnang.DockControls.Add(this.barDockControlBottom);
            this.menuchucnang.DockControls.Add(this.barDockControlLeft);
            this.menuchucnang.DockControls.Add(this.barDockControlRight);
            this.menuchucnang.Form = this;
            this.menuchucnang.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.them,
            this.sua,
            this.xoa,
            this.thoat});
            this.menuchucnang.MaxItemId = 4;
            this.menuchucnang.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.them, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.sua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.xoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.thoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // them
            // 
            this.them.Caption = "Thêm";
            this.them.Id = 0;
            this.them.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("them.ImageOptions.Image")));
            this.them.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("them.ImageOptions.LargeImage")));
            this.them.Name = "them";
            // 
            // sua
            // 
            this.sua.Caption = "Sửa";
            this.sua.Id = 1;
            this.sua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sua.ImageOptions.Image")));
            this.sua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("sua.ImageOptions.LargeImage")));
            this.sua.Name = "sua";
            // 
            // xoa
            // 
            this.xoa.Caption = "Xóa";
            this.xoa.Id = 2;
            this.xoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xoa.ImageOptions.Image")));
            this.xoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("xoa.ImageOptions.LargeImage")));
            this.xoa.Name = "xoa";
            // 
            // thoat
            // 
            this.thoat.Caption = "Thoát";
            this.thoat.Id = 3;
            this.thoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("thoat.ImageOptions.Image")));
            this.thoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("thoat.ImageOptions.LargeImage")));
            this.thoat.Name = "thoat";
            this.thoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.thoat_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.menuchucnang;
            this.barDockControlTop.Size = new System.Drawing.Size(1098, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 622);
            this.barDockControlBottom.Manager = this.menuchucnang;
            this.barDockControlBottom.Size = new System.Drawing.Size(1098, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.menuchucnang;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 598);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1098, 24);
            this.barDockControlRight.Manager = this.menuchucnang;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 598);
            // 
            // txt_manhaphang
            // 
            this.txt_manhaphang.Location = new System.Drawing.Point(147, 16);
            this.txt_manhaphang.MenuManager = this.menuchucnang;
            this.txt_manhaphang.Name = "txt_manhaphang";
            this.txt_manhaphang.Size = new System.Drawing.Size(384, 20);
            this.txt_manhaphang.TabIndex = 0;
            this.txt_manhaphang.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // txt_manhanvien
            // 
            this.txt_manhanvien.Location = new System.Drawing.Point(147, 63);
            this.txt_manhanvien.MenuManager = this.menuchucnang;
            this.txt_manhanvien.Name = "txt_manhanvien";
            this.txt_manhanvien.Size = new System.Drawing.Size(384, 20);
            this.txt_manhanvien.TabIndex = 1;
            // 
            // txt_ghichu
            // 
            this.txt_ghichu.Location = new System.Drawing.Point(693, 16);
            this.txt_ghichu.MenuManager = this.menuchucnang;
            this.txt_ghichu.Name = "txt_ghichu";
            this.txt_ghichu.Size = new System.Drawing.Size(384, 20);
            this.txt_ghichu.TabIndex = 3;
            // 
            // txt_tongsoluong
            // 
            this.txt_tongsoluong.Location = new System.Drawing.Point(693, 63);
            this.txt_tongsoluong.MenuManager = this.menuchucnang;
            this.txt_tongsoluong.Name = "txt_tongsoluong";
            this.txt_tongsoluong.Size = new System.Drawing.Size(384, 20);
            this.txt_tongsoluong.TabIndex = 4;
            // 
            // txt_tonggiatien
            // 
            this.txt_tonggiatien.Location = new System.Drawing.Point(693, 109);
            this.txt_tonggiatien.MenuManager = this.menuchucnang;
            this.txt_tonggiatien.Name = "txt_tonggiatien";
            this.txt_tonggiatien.Size = new System.Drawing.Size(384, 20);
            this.txt_tonggiatien.TabIndex = 5;
            // 
            // cbb_manhacungcap
            // 
            this.cbb_manhacungcap.Location = new System.Drawing.Point(147, 159);
            this.cbb_manhacungcap.MenuManager = this.menuchucnang;
            this.cbb_manhacungcap.Name = "cbb_manhacungcap";
            this.cbb_manhacungcap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_manhacungcap.Size = new System.Drawing.Size(384, 20);
            this.cbb_manhacungcap.TabIndex = 6;
            // 
            // cbb_trangthai
            // 
            this.cbb_trangthai.Location = new System.Drawing.Point(693, 159);
            this.cbb_trangthai.MenuManager = this.menuchucnang;
            this.cbb_trangthai.Name = "cbb_trangthai";
            this.cbb_trangthai.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_trangthai.Size = new System.Drawing.Size(384, 20);
            this.cbb_trangthai.TabIndex = 7;
            // 
            // panel_chinh
            // 
            this.panel_chinh.Controls.Add(this.dgv_sanpham);
            this.panel_chinh.Controls.Add(this.timkiemsanpham);
            this.panel_chinh.Controls.Add(this.txt_sanpham);
            this.panel_chinh.Controls.Add(this.timkiemncc);
            this.panel_chinh.Controls.Add(this.txt_tenncc);
            this.panel_chinh.Controls.Add(this.dgv_nh);
            this.panel_chinh.Controls.Add(this.lb_trangthai);
            this.panel_chinh.Controls.Add(this.lb_tongtien);
            this.panel_chinh.Controls.Add(this.lb_tongsoluong);
            this.panel_chinh.Controls.Add(this.lb_ghichu);
            this.panel_chinh.Controls.Add(this.lb_manhacungcap);
            this.panel_chinh.Controls.Add(this.lb_ngaynhap);
            this.panel_chinh.Controls.Add(this.lb_manhanvien);
            this.panel_chinh.Controls.Add(this.lb_manhaphang);
            this.panel_chinh.Controls.Add(this.ngaynhap);
            this.panel_chinh.Controls.Add(this.cbb_trangthai);
            this.panel_chinh.Controls.Add(this.cbb_manhacungcap);
            this.panel_chinh.Controls.Add(this.txt_tonggiatien);
            this.panel_chinh.Controls.Add(this.txt_tongsoluong);
            this.panel_chinh.Controls.Add(this.txt_ghichu);
            this.panel_chinh.Controls.Add(this.txt_manhanvien);
            this.panel_chinh.Controls.Add(this.txt_manhaphang);
            this.panel_chinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_chinh.Location = new System.Drawing.Point(0, 24);
            this.panel_chinh.Name = "panel_chinh";
            this.panel_chinh.Size = new System.Drawing.Size(1098, 598);
            this.panel_chinh.TabIndex = 0;
            // 
            // dgv_sanpham
            // 
            this.dgv_sanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sanpham.Location = new System.Drawing.Point(741, 254);
            this.dgv_sanpham.Name = "dgv_sanpham";
            this.dgv_sanpham.Size = new System.Drawing.Size(336, 284);
            this.dgv_sanpham.TabIndex = 22;
            // 
            // timkiemsanpham
            // 
            this.timkiemsanpham.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.timkiemsanpham.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("timkiemsanpham.ImageOptions.Image")));
            this.timkiemsanpham.Location = new System.Drawing.Point(1054, 208);
            this.timkiemsanpham.Name = "timkiemsanpham";
            this.timkiemsanpham.Size = new System.Drawing.Size(23, 20);
            this.timkiemsanpham.TabIndex = 21;
            // 
            // txt_sanpham
            // 
            this.txt_sanpham.Location = new System.Drawing.Point(567, 209);
            this.txt_sanpham.MenuManager = this.menuchucnang;
            this.txt_sanpham.Name = "txt_sanpham";
            this.txt_sanpham.Size = new System.Drawing.Size(481, 20);
            this.txt_sanpham.TabIndex = 20;
            // 
            // timkiemncc
            // 
            this.timkiemncc.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.timkiemncc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("timkiemncc.ImageOptions.Image")));
            this.timkiemncc.Location = new System.Drawing.Point(508, 208);
            this.timkiemncc.Name = "timkiemncc";
            this.timkiemncc.Size = new System.Drawing.Size(23, 20);
            this.timkiemncc.TabIndex = 19;
            // 
            // txt_tenncc
            // 
            this.txt_tenncc.Location = new System.Drawing.Point(21, 209);
            this.txt_tenncc.MenuManager = this.menuchucnang;
            this.txt_tenncc.Name = "txt_tenncc";
            this.txt_tenncc.Size = new System.Drawing.Size(481, 20);
            this.txt_tenncc.TabIndex = 18;
            // 
            // dgv_nh
            // 
            this.dgv_nh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nh.Location = new System.Drawing.Point(21, 254);
            this.dgv_nh.Name = "dgv_nh";
            this.dgv_nh.Size = new System.Drawing.Size(662, 284);
            this.dgv_nh.TabIndex = 17;
            // 
            // lb_trangthai
            // 
            this.lb_trangthai.Location = new System.Drawing.Point(567, 162);
            this.lb_trangthai.Name = "lb_trangthai";
            this.lb_trangthai.Size = new System.Drawing.Size(49, 13);
            this.lb_trangthai.TabIndex = 16;
            this.lb_trangthai.Text = "Trạng thái";
            // 
            // lb_tongtien
            // 
            this.lb_tongtien.Location = new System.Drawing.Point(567, 112);
            this.lb_tongtien.Name = "lb_tongtien";
            this.lb_tongtien.Size = new System.Drawing.Size(62, 13);
            this.lb_tongtien.TabIndex = 15;
            this.lb_tongtien.Text = "Tổng giá tiền";
            // 
            // lb_tongsoluong
            // 
            this.lb_tongsoluong.Location = new System.Drawing.Point(567, 66);
            this.lb_tongsoluong.Name = "lb_tongsoluong";
            this.lb_tongsoluong.Size = new System.Drawing.Size(68, 13);
            this.lb_tongsoluong.TabIndex = 14;
            this.lb_tongsoluong.Text = "Tổng số lượng";
            // 
            // lb_ghichu
            // 
            this.lb_ghichu.Location = new System.Drawing.Point(567, 19);
            this.lb_ghichu.Name = "lb_ghichu";
            this.lb_ghichu.Size = new System.Drawing.Size(35, 13);
            this.lb_ghichu.TabIndex = 13;
            this.lb_ghichu.Text = "Ghi chú";
            // 
            // lb_manhacungcap
            // 
            this.lb_manhacungcap.Location = new System.Drawing.Point(21, 162);
            this.lb_manhacungcap.Name = "lb_manhacungcap";
            this.lb_manhacungcap.Size = new System.Drawing.Size(81, 13);
            this.lb_manhacungcap.TabIndex = 12;
            this.lb_manhacungcap.Text = "Mã nhà cung cấp";
            // 
            // lb_ngaynhap
            // 
            this.lb_ngaynhap.Location = new System.Drawing.Point(21, 112);
            this.lb_ngaynhap.Name = "lb_ngaynhap";
            this.lb_ngaynhap.Size = new System.Drawing.Size(52, 13);
            this.lb_ngaynhap.TabIndex = 11;
            this.lb_ngaynhap.Text = "Ngày nhập";
            // 
            // lb_manhanvien
            // 
            this.lb_manhanvien.Location = new System.Drawing.Point(21, 66);
            this.lb_manhanvien.Name = "lb_manhanvien";
            this.lb_manhanvien.Size = new System.Drawing.Size(68, 13);
            this.lb_manhanvien.TabIndex = 10;
            this.lb_manhanvien.Text = "Tên nhân viên";
            // 
            // lb_manhaphang
            // 
            this.lb_manhaphang.Location = new System.Drawing.Point(21, 19);
            this.lb_manhaphang.Name = "lb_manhaphang";
            this.lb_manhaphang.Size = new System.Drawing.Size(68, 13);
            this.lb_manhaphang.TabIndex = 9;
            this.lb_manhaphang.Text = "Mã nhập hàng";
            // 
            // ngaynhap
            // 
            this.ngaynhap.EditValue = null;
            this.ngaynhap.Location = new System.Drawing.Point(147, 109);
            this.ngaynhap.MenuManager = this.menuchucnang;
            this.ngaynhap.Name = "ngaynhap";
            this.ngaynhap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngaynhap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngaynhap.Size = new System.Drawing.Size(384, 20);
            this.ngaynhap.TabIndex = 8;
            // 
            // frmNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 642);
            this.Controls.Add(this.panel_chinh);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmNhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNhapHang";
            ((System.ComponentModel.ISupportInitialize)(this.menuchucnang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_manhaphang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_manhanvien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ghichu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tongsoluong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tonggiatien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_manhacungcap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_trangthai.Properties)).EndInit();
            this.panel_chinh.ResumeLayout(false);
            this.panel_chinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sanpham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sanpham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tenncc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngaynhap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngaynhap.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarManager menuchucnang;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem them;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem sua;
        private DevExpress.XtraBars.BarButtonItem xoa;
        private DevExpress.XtraBars.BarButtonItem thoat;
        private System.Windows.Forms.Panel panel_chinh;
        private DevExpress.XtraEditors.ComboBoxEdit cbb_trangthai;
        private DevExpress.XtraEditors.ComboBoxEdit cbb_manhacungcap;
        private DevExpress.XtraEditors.TextEdit txt_tonggiatien;
        private DevExpress.XtraEditors.TextEdit txt_tongsoluong;
        private DevExpress.XtraEditors.TextEdit txt_ghichu;
        private DevExpress.XtraEditors.TextEdit txt_manhanvien;
        private DevExpress.XtraEditors.TextEdit txt_manhaphang;
        private DevExpress.XtraEditors.LabelControl lb_trangthai;
        private DevExpress.XtraEditors.LabelControl lb_tongtien;
        private DevExpress.XtraEditors.LabelControl lb_tongsoluong;
        private DevExpress.XtraEditors.LabelControl lb_ghichu;
        private DevExpress.XtraEditors.LabelControl lb_manhacungcap;
        private DevExpress.XtraEditors.LabelControl lb_ngaynhap;
        private DevExpress.XtraEditors.LabelControl lb_manhanvien;
        private DevExpress.XtraEditors.LabelControl lb_manhaphang;
        private DevExpress.XtraEditors.DateEdit ngaynhap;
        private System.Windows.Forms.DataGridView dgv_nh;
        private DevExpress.XtraEditors.LabelControl timkiemsanpham;
        private DevExpress.XtraEditors.TextEdit txt_sanpham;
        private DevExpress.XtraEditors.LabelControl timkiemncc;
        private DevExpress.XtraEditors.TextEdit txt_tenncc;
        private System.Windows.Forms.DataGridView dgv_sanpham;
    }
}