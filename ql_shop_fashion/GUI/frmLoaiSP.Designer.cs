
namespace GUI
{
    partial class frmLoaiSP
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
            this.pnl_LoaiSP = new System.Windows.Forms.Panel();
            this.gb_loaisp = new System.Windows.Forms.GroupBox();
            this.gct_loaisp = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.thongtinnhomloai = new System.Windows.Forms.Panel();
            this.cbb_tennhomloai = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lb_tennhomloai = new DevExpress.XtraEditors.LabelControl();
            this.btn_loadloaisp = new DevExpress.XtraEditors.SimpleButton();
            this.btn_xoaloaisp = new DevExpress.XtraEditors.SimpleButton();
            this.btn_sualoaisp = new DevExpress.XtraEditors.SimpleButton();
            this.btn_themloaisp = new DevExpress.XtraEditors.SimpleButton();
            this.txt_chitiet = new DevExpress.XtraEditors.TextEdit();
            this.lb_chitiet = new DevExpress.XtraEditors.LabelControl();
            this.txt_tenloai = new DevExpress.XtraEditors.TextEdit();
            this.txt_maloai = new DevExpress.XtraEditors.TextEdit();
            this.lb_tenloai = new DevExpress.XtraEditors.LabelControl();
            this.lb_maloai = new DevExpress.XtraEditors.LabelControl();
            this.pnl_LoaiSP.SuspendLayout();
            this.gb_loaisp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gct_loaisp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.thongtinnhomloai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_tennhomloai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_chitiet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tenloai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_maloai.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_LoaiSP
            // 
            this.pnl_LoaiSP.Controls.Add(this.gb_loaisp);
            this.pnl_LoaiSP.Controls.Add(this.thongtinnhomloai);
            this.pnl_LoaiSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_LoaiSP.Location = new System.Drawing.Point(0, 0);
            this.pnl_LoaiSP.Name = "pnl_LoaiSP";
            this.pnl_LoaiSP.Size = new System.Drawing.Size(706, 602);
            this.pnl_LoaiSP.TabIndex = 0;
            // 
            // gb_loaisp
            // 
            this.gb_loaisp.BackColor = System.Drawing.Color.White;
            this.gb_loaisp.Controls.Add(this.gct_loaisp);
            this.gb_loaisp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_loaisp.Location = new System.Drawing.Point(0, 283);
            this.gb_loaisp.Name = "gb_loaisp";
            this.gb_loaisp.Size = new System.Drawing.Size(706, 319);
            this.gb_loaisp.TabIndex = 42;
            this.gb_loaisp.TabStop = false;
            this.gb_loaisp.Text = "Danh sách loại sản phẩm";
            // 
            // gct_loaisp
            // 
            this.gct_loaisp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gct_loaisp.Location = new System.Drawing.Point(3, 17);
            this.gct_loaisp.MainView = this.gridView2;
            this.gct_loaisp.Name = "gct_loaisp";
            this.gct_loaisp.Size = new System.Drawing.Size(700, 299);
            this.gct_loaisp.TabIndex = 39;
            this.gct_loaisp.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gct_loaisp;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // thongtinnhomloai
            // 
            this.thongtinnhomloai.BackColor = System.Drawing.Color.White;
            this.thongtinnhomloai.Controls.Add(this.cbb_tennhomloai);
            this.thongtinnhomloai.Controls.Add(this.lb_tennhomloai);
            this.thongtinnhomloai.Controls.Add(this.btn_loadloaisp);
            this.thongtinnhomloai.Controls.Add(this.btn_xoaloaisp);
            this.thongtinnhomloai.Controls.Add(this.btn_sualoaisp);
            this.thongtinnhomloai.Controls.Add(this.btn_themloaisp);
            this.thongtinnhomloai.Controls.Add(this.txt_chitiet);
            this.thongtinnhomloai.Controls.Add(this.lb_chitiet);
            this.thongtinnhomloai.Controls.Add(this.txt_tenloai);
            this.thongtinnhomloai.Controls.Add(this.txt_maloai);
            this.thongtinnhomloai.Controls.Add(this.lb_tenloai);
            this.thongtinnhomloai.Controls.Add(this.lb_maloai);
            this.thongtinnhomloai.Dock = System.Windows.Forms.DockStyle.Top;
            this.thongtinnhomloai.Location = new System.Drawing.Point(0, 0);
            this.thongtinnhomloai.Name = "thongtinnhomloai";
            this.thongtinnhomloai.Size = new System.Drawing.Size(706, 283);
            this.thongtinnhomloai.TabIndex = 5;
            // 
            // cbb_tennhomloai
            // 
            this.cbb_tennhomloai.Location = new System.Drawing.Point(145, 158);
            this.cbb_tennhomloai.Name = "cbb_tennhomloai";
            this.cbb_tennhomloai.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_tennhomloai.Size = new System.Drawing.Size(338, 20);
            this.cbb_tennhomloai.TabIndex = 47;
            // 
            // lb_tennhomloai
            // 
            this.lb_tennhomloai.Location = new System.Drawing.Point(22, 161);
            this.lb_tennhomloai.Name = "lb_tennhomloai";
            this.lb_tennhomloai.Size = new System.Drawing.Size(70, 13);
            this.lb_tennhomloai.TabIndex = 46;
            this.lb_tennhomloai.Text = "Tên Nhóm Loại";
            // 
            // btn_loadloaisp
            // 
            this.btn_loadloaisp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_loadloaisp.Location = new System.Drawing.Point(535, 206);
            this.btn_loadloaisp.Name = "btn_loadloaisp";
            this.btn_loadloaisp.Size = new System.Drawing.Size(118, 35);
            this.btn_loadloaisp.TabIndex = 45;
            this.btn_loadloaisp.Text = "Load Loại Sản Phẩm";
            // 
            // btn_xoaloaisp
            // 
            this.btn_xoaloaisp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_xoaloaisp.Location = new System.Drawing.Point(535, 143);
            this.btn_xoaloaisp.Name = "btn_xoaloaisp";
            this.btn_xoaloaisp.Size = new System.Drawing.Size(118, 35);
            this.btn_xoaloaisp.TabIndex = 44;
            this.btn_xoaloaisp.Text = "Xóa Loại Sản Phẩm";
            // 
            // btn_sualoaisp
            // 
            this.btn_sualoaisp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sualoaisp.Location = new System.Drawing.Point(535, 80);
            this.btn_sualoaisp.Name = "btn_sualoaisp";
            this.btn_sualoaisp.Size = new System.Drawing.Size(118, 35);
            this.btn_sualoaisp.TabIndex = 43;
            this.btn_sualoaisp.Text = "Sửa Loại Sản Phẩm";
            // 
            // btn_themloaisp
            // 
            this.btn_themloaisp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_themloaisp.Location = new System.Drawing.Point(535, 17);
            this.btn_themloaisp.Name = "btn_themloaisp";
            this.btn_themloaisp.Size = new System.Drawing.Size(118, 35);
            this.btn_themloaisp.TabIndex = 42;
            this.btn_themloaisp.Text = "Thêm Loại Sản Phẩm";
            // 
            // txt_chitiet
            // 
            this.txt_chitiet.Location = new System.Drawing.Point(145, 221);
            this.txt_chitiet.Name = "txt_chitiet";
            this.txt_chitiet.Size = new System.Drawing.Size(338, 20);
            this.txt_chitiet.TabIndex = 7;
            // 
            // lb_chitiet
            // 
            this.lb_chitiet.Location = new System.Drawing.Point(22, 224);
            this.lb_chitiet.Name = "lb_chitiet";
            this.lb_chitiet.Size = new System.Drawing.Size(36, 13);
            this.lb_chitiet.TabIndex = 6;
            this.lb_chitiet.Text = "Chi Tiết";
            // 
            // txt_tenloai
            // 
            this.txt_tenloai.Location = new System.Drawing.Point(145, 95);
            this.txt_tenloai.Name = "txt_tenloai";
            this.txt_tenloai.Size = new System.Drawing.Size(338, 20);
            this.txt_tenloai.TabIndex = 5;
            // 
            // txt_maloai
            // 
            this.txt_maloai.Location = new System.Drawing.Point(145, 25);
            this.txt_maloai.Name = "txt_maloai";
            this.txt_maloai.Size = new System.Drawing.Size(338, 20);
            this.txt_maloai.TabIndex = 4;
            // 
            // lb_tenloai
            // 
            this.lb_tenloai.Location = new System.Drawing.Point(22, 98);
            this.lb_tenloai.Name = "lb_tenloai";
            this.lb_tenloai.Size = new System.Drawing.Size(40, 13);
            this.lb_tenloai.TabIndex = 1;
            this.lb_tenloai.Text = "Tên Loại";
            // 
            // lb_maloai
            // 
            this.lb_maloai.Location = new System.Drawing.Point(22, 28);
            this.lb_maloai.Name = "lb_maloai";
            this.lb_maloai.Size = new System.Drawing.Size(36, 13);
            this.lb_maloai.TabIndex = 0;
            this.lb_maloai.Text = "Mã Loại";
            // 
            // frmLoaiSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 602);
            this.Controls.Add(this.pnl_LoaiSP);
            this.Name = "frmLoaiSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLoaiSP";
            this.pnl_LoaiSP.ResumeLayout(false);
            this.gb_loaisp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gct_loaisp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.thongtinnhomloai.ResumeLayout(false);
            this.thongtinnhomloai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_tennhomloai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_chitiet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tenloai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_maloai.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_LoaiSP;
        private System.Windows.Forms.Panel thongtinnhomloai;
        private DevExpress.XtraEditors.TextEdit txt_chitiet;
        private DevExpress.XtraEditors.LabelControl lb_chitiet;
        private DevExpress.XtraEditors.TextEdit txt_tenloai;
        private DevExpress.XtraEditors.TextEdit txt_maloai;
        private DevExpress.XtraEditors.LabelControl lb_tenloai;
        private DevExpress.XtraEditors.LabelControl lb_maloai;
        private System.Windows.Forms.GroupBox gb_loaisp;
        private DevExpress.XtraGrid.GridControl gct_loaisp;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SimpleButton btn_loadloaisp;
        private DevExpress.XtraEditors.SimpleButton btn_xoaloaisp;
        private DevExpress.XtraEditors.SimpleButton btn_sualoaisp;
        private DevExpress.XtraEditors.SimpleButton btn_themloaisp;
        private DevExpress.XtraEditors.LabelControl lb_tennhomloai;
        private DevExpress.XtraEditors.ComboBoxEdit cbb_tennhomloai;
    }
}