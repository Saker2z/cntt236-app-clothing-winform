
namespace GUI
{
    partial class PhieuNhap
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
            this.dgv_sp = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.bbiNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.cbb_ncc = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txt_tennv = new DevExpress.XtraEditors.TextEdit();
            this.date_ngaynhap = new System.Windows.Forms.DateTimePicker();
            this.txt_ghichu = new DevExpress.XtraEditors.TextEdit();
            this.txt_tt = new DevExpress.XtraEditors.TextEdit();
            this.txt_tongsl = new DevExpress.XtraEditors.TextEdit();
            this.lb_thanhtien = new DevExpress.XtraEditors.LabelControl();
            this.cbb_tensp = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txt_sl = new DevExpress.XtraEditors.TextEdit();
            this.txt_gianhap = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txt_dg = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.buttonEdit1 = new DevExpress.XtraEditors.ButtonEdit();
            this.bt_them = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_ncc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tennv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ghichu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tongsl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_tensp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_gianhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_dg.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_sp
            // 
            this.dgv_sp.Location = new System.Drawing.Point(-8, 309);
            this.dgv_sp.MainView = this.gridView;
            this.dgv_sp.MenuManager = this.ribbonControl;
            this.dgv_sp.Name = "dgv_sp";
            this.dgv_sp.Size = new System.Drawing.Size(893, 258);
            this.dgv_sp.TabIndex = 2;
            this.dgv_sp.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView.GridControl = this.dgv_sp;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsBehavior.ReadOnly = true;
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.ribbonControl.SearchEditItem,
            this.bbiPrintPreview,
            this.bsiRecordsCount,
            this.bbiNew,
            this.bbiEdit,
            this.bbiDelete,
            this.bbiRefresh});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 20;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(885, 158);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiPrintPreview
            // 
            this.bbiPrintPreview.Caption = "Print Preview";
            this.bbiPrintPreview.Id = 14;
            this.bbiPrintPreview.ImageOptions.ImageUri.Uri = "Preview";
            this.bbiPrintPreview.Name = "bbiPrintPreview";
            this.bbiPrintPreview.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPrintPreview_ItemClick);
            // 
            // bsiRecordsCount
            // 
            this.bsiRecordsCount.Caption = "RECORDS : 0";
            this.bsiRecordsCount.Id = 15;
            this.bsiRecordsCount.Name = "bsiRecordsCount";
            // 
            // bbiNew
            // 
            this.bbiNew.Caption = "New";
            this.bbiNew.Id = 16;
            this.bbiNew.ImageOptions.ImageUri.Uri = "New";
            this.bbiNew.Name = "bbiNew";
            // 
            // bbiEdit
            // 
            this.bbiEdit.Caption = "Edit";
            this.bbiEdit.Id = 17;
            this.bbiEdit.ImageOptions.ImageUri.Uri = "Edit";
            this.bbiEdit.Name = "bbiEdit";
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Delete";
            this.bbiDelete.Id = 18;
            this.bbiDelete.ImageOptions.ImageUri.Uri = "Delete";
            this.bbiDelete.Name = "bbiDelete";
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "Refresh";
            this.bbiRefresh.Id = 19;
            this.bbiRefresh.ImageOptions.ImageUri.Uri = "Refresh";
            this.bbiRefresh.Name = "bbiRefresh";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.MergeOrder = 0;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiNew);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiDelete);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiRefresh);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tasks";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiPrintPreview);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Print and Export";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.bsiRecordsCount);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 600);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(885, 24);
            // 
            // cbb_ncc
            // 
            this.cbb_ncc.EditValue = "";
            this.cbb_ncc.Location = new System.Drawing.Point(125, 190);
            this.cbb_ncc.MenuManager = this.ribbonControl;
            this.cbb_ncc.Name = "cbb_ncc";
            this.cbb_ncc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_ncc.Size = new System.Drawing.Size(163, 20);
            this.cbb_ncc.TabIndex = 4;
            // 
            // txt_tennv
            // 
            this.txt_tennv.EditValue = "";
            this.txt_tennv.Location = new System.Drawing.Point(125, 164);
            this.txt_tennv.MenuManager = this.ribbonControl;
            this.txt_tennv.Name = "txt_tennv";
            this.txt_tennv.Size = new System.Drawing.Size(163, 20);
            this.txt_tennv.TabIndex = 5;
            // 
            // date_ngaynhap
            // 
            this.date_ngaynhap.Location = new System.Drawing.Point(125, 216);
            this.date_ngaynhap.Name = "date_ngaynhap";
            this.date_ngaynhap.Size = new System.Drawing.Size(163, 21);
            this.date_ngaynhap.TabIndex = 6;
            // 
            // txt_ghichu
            // 
            this.txt_ghichu.Location = new System.Drawing.Point(125, 243);
            this.txt_ghichu.MenuManager = this.ribbonControl;
            this.txt_ghichu.Name = "txt_ghichu";
            this.txt_ghichu.Size = new System.Drawing.Size(163, 20);
            this.txt_ghichu.TabIndex = 7;
            // 
            // txt_tt
            // 
            this.txt_tt.EditValue = "";
            this.txt_tt.Location = new System.Drawing.Point(125, 269);
            this.txt_tt.MenuManager = this.ribbonControl;
            this.txt_tt.Name = "txt_tt";
            this.txt_tt.Size = new System.Drawing.Size(163, 20);
            this.txt_tt.TabIndex = 8;
            // 
            // txt_tongsl
            // 
            this.txt_tongsl.Location = new System.Drawing.Point(125, 295);
            this.txt_tongsl.MenuManager = this.ribbonControl;
            this.txt_tongsl.Name = "txt_tongsl";
            this.txt_tongsl.Size = new System.Drawing.Size(163, 20);
            this.txt_tongsl.TabIndex = 9;
            // 
            // lb_thanhtien
            // 
            this.lb_thanhtien.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thanhtien.Appearance.Options.UseFont = true;
            this.lb_thanhtien.Location = new System.Drawing.Point(690, 573);
            this.lb_thanhtien.Name = "lb_thanhtien";
            this.lb_thanhtien.Size = new System.Drawing.Size(80, 21);
            this.lb_thanhtien.TabIndex = 10;
            this.lb_thanhtien.Text = "Tổng tiền: ";
            // 
            // cbb_tensp
            // 
            this.cbb_tensp.Location = new System.Drawing.Point(467, 173);
            this.cbb_tensp.MenuManager = this.ribbonControl;
            this.cbb_tensp.Name = "cbb_tensp";
            this.cbb_tensp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_tensp.Size = new System.Drawing.Size(163, 20);
            this.cbb_tensp.TabIndex = 11;
            // 
            // txt_sl
            // 
            this.txt_sl.Location = new System.Drawing.Point(467, 254);
            this.txt_sl.MenuManager = this.ribbonControl;
            this.txt_sl.Name = "txt_sl";
            this.txt_sl.Size = new System.Drawing.Size(163, 20);
            this.txt_sl.TabIndex = 12;
            // 
            // txt_gianhap
            // 
            this.txt_gianhap.Location = new System.Drawing.Point(467, 283);
            this.txt_gianhap.MenuManager = this.ribbonControl;
            this.txt_gianhap.Name = "txt_gianhap";
            this.txt_gianhap.Size = new System.Drawing.Size(163, 20);
            this.txt_gianhap.TabIndex = 13;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(375, 216);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(0, 13);
            this.labelControl2.TabIndex = 14;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(44, 167);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(75, 13);
            this.labelControl3.TabIndex = 15;
            this.labelControl3.Text = "Tên nhân viên :";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(27, 193);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(92, 13);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "Tên nhà cung cấp :";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(44, 222);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(52, 13);
            this.labelControl5.TabIndex = 17;
            this.labelControl5.Text = "Ngày nhập";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(44, 246);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(35, 13);
            this.labelControl6.TabIndex = 18;
            this.labelControl6.Text = "Ghi chú";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(44, 272);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(49, 13);
            this.labelControl7.TabIndex = 19;
            this.labelControl7.Text = "Trạng thái";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(44, 298);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(68, 13);
            this.labelControl8.TabIndex = 20;
            this.labelControl8.Text = "Tổng số lượng";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(386, 176);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(67, 13);
            this.labelControl9.TabIndex = 21;
            this.labelControl9.Text = "Tên sản phẩm";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(411, 257);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(42, 13);
            this.labelControl10.TabIndex = 22;
            this.labelControl10.Text = "Số lượng";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(411, 290);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(42, 13);
            this.labelControl11.TabIndex = 23;
            this.labelControl11.Text = "Giá nhập";
            // 
            // txt_dg
            // 
            this.txt_dg.Location = new System.Drawing.Point(467, 213);
            this.txt_dg.MenuManager = this.ribbonControl;
            this.txt_dg.Name = "txt_dg";
            this.txt_dg.Size = new System.Drawing.Size(163, 20);
            this.txt_dg.TabIndex = 24;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(411, 216);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(37, 13);
            this.labelControl12.TabIndex = 25;
            this.labelControl12.Text = "Đơn giá";
            // 
            // buttonEdit1
            // 
            this.buttonEdit1.Location = new System.Drawing.Point(-16, -15);
            this.buttonEdit1.MenuManager = this.ribbonControl;
            this.buttonEdit1.Name = "buttonEdit1";
            this.buttonEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.buttonEdit1.Size = new System.Drawing.Size(100, 20);
            this.buttonEdit1.TabIndex = 28;
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(690, 216);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(92, 48);
            this.bt_them.TabIndex = 29;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            // 
            // PhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 624);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.buttonEdit1);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.txt_dg);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txt_gianhap);
            this.Controls.Add(this.txt_sl);
            this.Controls.Add(this.cbb_tensp);
            this.Controls.Add(this.lb_thanhtien);
            this.Controls.Add(this.txt_tongsl);
            this.Controls.Add(this.txt_tt);
            this.Controls.Add(this.txt_ghichu);
            this.Controls.Add(this.date_ngaynhap);
            this.Controls.Add(this.txt_tennv);
            this.Controls.Add(this.cbb_ncc);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.dgv_sp);
            this.Controls.Add(this.ribbonControl);
            this.Name = "PhieuNhap";
            this.Ribbon = this.ribbonControl;
            this.StatusBar = this.ribbonStatusBar;
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_ncc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tennv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ghichu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tongsl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_tensp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_gianhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_dg.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl dgv_sp;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiPrintPreview;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
        private DevExpress.XtraBars.BarButtonItem bbiNew;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraEditors.ComboBoxEdit cbb_ncc;
        private DevExpress.XtraEditors.TextEdit txt_tennv;
        private System.Windows.Forms.DateTimePicker date_ngaynhap;
        private DevExpress.XtraEditors.TextEdit txt_ghichu;
        private DevExpress.XtraEditors.TextEdit txt_tt;
        private DevExpress.XtraEditors.TextEdit txt_tongsl;
        private DevExpress.XtraEditors.LabelControl lb_thanhtien;
        private DevExpress.XtraEditors.ComboBoxEdit cbb_tensp;
        private DevExpress.XtraEditors.TextEdit txt_sl;
        private DevExpress.XtraEditors.TextEdit txt_gianhap;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txt_dg;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.ButtonEdit buttonEdit1;
        private System.Windows.Forms.Button bt_them;
    }
}