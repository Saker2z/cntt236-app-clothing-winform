﻿
namespace GUI
{
    partial class UC_NhaCungCap
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
            this.layoutControl_nhacungcap = new DevExpress.XtraLayout.LayoutControl();
            this.nhacungcap = new DevExpress.XtraTab.XtraTabControl();
            this.PageNhaCungCap = new DevExpress.XtraTab.XtraTabPage();
            this.datagridview_ncc = new System.Windows.Forms.Panel();
            this.dgv_nhacungcap = new System.Windows.Forms.DataGridView();
            this.thongtin = new System.Windows.Forms.Panel();
            this.btn_load = new DevExpress.XtraEditors.SimpleButton();
            this.btn_xoa = new DevExpress.XtraEditors.SimpleButton();
            this.btn_sua = new DevExpress.XtraEditors.SimpleButton();
            this.btn_them = new DevExpress.XtraEditors.SimpleButton();
            this.txt_sdt = new DevExpress.XtraEditors.TextEdit();
            this.txt_diachi = new DevExpress.XtraEditors.TextEdit();
            this.txt_tennhacungcap = new DevExpress.XtraEditors.TextEdit();
            this.txt_manhacungcap = new DevExpress.XtraEditors.TextEdit();
            this.lb_sodienthoai = new DevExpress.XtraEditors.LabelControl();
            this.lb_diachi = new DevExpress.XtraEditors.LabelControl();
            this.lb_tennhacungcap = new DevExpress.XtraEditors.LabelControl();
            this.lb_manhacungcap = new DevExpress.XtraEditors.LabelControl();
            this.PageNhaCungCapSanPham = new DevExpress.XtraTab.XtraTabPage();
            this.datagridview_nccsp = new System.Windows.Forms.Panel();
            this.dgv_sp = new System.Windows.Forms.DataGridView();
            this.dgv_ncc = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_masanpham = new DevExpress.XtraEditors.TextEdit();
            this.txt_giacungcap = new DevExpress.XtraEditors.TextEdit();
            this.txt_manhacungcapsanpham = new DevExpress.XtraEditors.TextEdit();
            this.lb_masanpham = new DevExpress.XtraEditors.LabelControl();
            this.lb_giacungcap = new DevExpress.XtraEditors.LabelControl();
            this.lb_manhacungcapsanpham = new DevExpress.XtraEditors.LabelControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_nhacungcap)).BeginInit();
            this.layoutControl_nhacungcap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhacungcap)).BeginInit();
            this.nhacungcap.SuspendLayout();
            this.PageNhaCungCap.SuspendLayout();
            this.datagridview_ncc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhacungcap)).BeginInit();
            this.thongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sdt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_diachi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tennhacungcap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_manhacungcap.Properties)).BeginInit();
            this.PageNhaCungCapSanPham.SuspendLayout();
            this.datagridview_nccsp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ncc)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_masanpham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_giacungcap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_manhacungcapsanpham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl_nhacungcap
            // 
            this.layoutControl_nhacungcap.Controls.Add(this.nhacungcap);
            this.layoutControl_nhacungcap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl_nhacungcap.Location = new System.Drawing.Point(0, 0);
            this.layoutControl_nhacungcap.Name = "layoutControl_nhacungcap";
            this.layoutControl_nhacungcap.Root = this.Root;
            this.layoutControl_nhacungcap.Size = new System.Drawing.Size(845, 584);
            this.layoutControl_nhacungcap.TabIndex = 0;
            // 
            // nhacungcap
            // 
            this.nhacungcap.Location = new System.Drawing.Point(12, 12);
            this.nhacungcap.Name = "nhacungcap";
            this.nhacungcap.SelectedTabPage = this.PageNhaCungCap;
            this.nhacungcap.Size = new System.Drawing.Size(821, 560);
            this.nhacungcap.TabIndex = 4;
            this.nhacungcap.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.PageNhaCungCap,
            this.PageNhaCungCapSanPham});
            // 
            // PageNhaCungCap
            // 
            this.PageNhaCungCap.Controls.Add(this.datagridview_ncc);
            this.PageNhaCungCap.Controls.Add(this.thongtin);
            this.PageNhaCungCap.Name = "PageNhaCungCap";
            this.PageNhaCungCap.Size = new System.Drawing.Size(819, 535);
            this.PageNhaCungCap.Text = "Nhà Cung Cấp";
            // 
            // datagridview_ncc
            // 
            this.datagridview_ncc.Controls.Add(this.dgv_nhacungcap);
            this.datagridview_ncc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridview_ncc.Location = new System.Drawing.Point(0, 218);
            this.datagridview_ncc.Name = "datagridview_ncc";
            this.datagridview_ncc.Size = new System.Drawing.Size(819, 317);
            this.datagridview_ncc.TabIndex = 2;
            // 
            // dgv_nhacungcap
            // 
            this.dgv_nhacungcap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nhacungcap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_nhacungcap.Location = new System.Drawing.Point(0, 0);
            this.dgv_nhacungcap.Name = "dgv_nhacungcap";
            this.dgv_nhacungcap.Size = new System.Drawing.Size(819, 317);
            this.dgv_nhacungcap.TabIndex = 0;
            // 
            // thongtin
            // 
            this.thongtin.Controls.Add(this.btn_load);
            this.thongtin.Controls.Add(this.btn_xoa);
            this.thongtin.Controls.Add(this.btn_sua);
            this.thongtin.Controls.Add(this.btn_them);
            this.thongtin.Controls.Add(this.txt_sdt);
            this.thongtin.Controls.Add(this.txt_diachi);
            this.thongtin.Controls.Add(this.txt_tennhacungcap);
            this.thongtin.Controls.Add(this.txt_manhacungcap);
            this.thongtin.Controls.Add(this.lb_sodienthoai);
            this.thongtin.Controls.Add(this.lb_diachi);
            this.thongtin.Controls.Add(this.lb_tennhacungcap);
            this.thongtin.Controls.Add(this.lb_manhacungcap);
            this.thongtin.Dock = System.Windows.Forms.DockStyle.Top;
            this.thongtin.Location = new System.Drawing.Point(0, 0);
            this.thongtin.Name = "thongtin";
            this.thongtin.Size = new System.Drawing.Size(819, 218);
            this.thongtin.TabIndex = 1;
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(642, 131);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(123, 44);
            this.btn_load.TabIndex = 11;
            this.btn_load.Text = "Load Nhà Cung Cấp";
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(426, 131);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(123, 44);
            this.btn_xoa.TabIndex = 10;
            this.btn_xoa.Text = "Xóa Nhà Cung Cấp";
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(220, 131);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(123, 44);
            this.btn_sua.TabIndex = 9;
            this.btn_sua.Text = "Sửa Nhà Cung Cấp";
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(22, 131);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(123, 44);
            this.btn_them.TabIndex = 8;
            this.btn_them.Text = "Thêm Nhà Cung Cấp";
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(567, 64);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(198, 20);
            this.txt_sdt.TabIndex = 7;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(567, 14);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(198, 20);
            this.txt_diachi.TabIndex = 6;
            // 
            // txt_tennhacungcap
            // 
            this.txt_tennhacungcap.Location = new System.Drawing.Point(145, 64);
            this.txt_tennhacungcap.Name = "txt_tennhacungcap";
            this.txt_tennhacungcap.Size = new System.Drawing.Size(198, 20);
            this.txt_tennhacungcap.TabIndex = 5;
            // 
            // txt_manhacungcap
            // 
            this.txt_manhacungcap.Location = new System.Drawing.Point(145, 14);
            this.txt_manhacungcap.Name = "txt_manhacungcap";
            this.txt_manhacungcap.Size = new System.Drawing.Size(198, 20);
            this.txt_manhacungcap.TabIndex = 4;
            // 
            // lb_sodienthoai
            // 
            this.lb_sodienthoai.Location = new System.Drawing.Point(447, 67);
            this.lb_sodienthoai.Name = "lb_sodienthoai";
            this.lb_sodienthoai.Size = new System.Drawing.Size(66, 13);
            this.lb_sodienthoai.TabIndex = 3;
            this.lb_sodienthoai.Text = "Số Điện Thoại";
            // 
            // lb_diachi
            // 
            this.lb_diachi.Location = new System.Drawing.Point(447, 17);
            this.lb_diachi.Name = "lb_diachi";
            this.lb_diachi.Size = new System.Drawing.Size(34, 13);
            this.lb_diachi.TabIndex = 2;
            this.lb_diachi.Text = "Địa Chỉ";
            // 
            // lb_tennhacungcap
            // 
            this.lb_tennhacungcap.Location = new System.Drawing.Point(22, 67);
            this.lb_tennhacungcap.Name = "lb_tennhacungcap";
            this.lb_tennhacungcap.Size = new System.Drawing.Size(90, 13);
            this.lb_tennhacungcap.TabIndex = 1;
            this.lb_tennhacungcap.Text = "Tên Nhà Cung Cấp";
            // 
            // lb_manhacungcap
            // 
            this.lb_manhacungcap.Location = new System.Drawing.Point(22, 17);
            this.lb_manhacungcap.Name = "lb_manhacungcap";
            this.lb_manhacungcap.Size = new System.Drawing.Size(86, 13);
            this.lb_manhacungcap.TabIndex = 0;
            this.lb_manhacungcap.Text = "Mã Nhà Cung Cấp";
            // 
            // PageNhaCungCapSanPham
            // 
            this.PageNhaCungCapSanPham.Controls.Add(this.datagridview_nccsp);
            this.PageNhaCungCapSanPham.Controls.Add(this.panel1);
            this.PageNhaCungCapSanPham.Name = "PageNhaCungCapSanPham";
            this.PageNhaCungCapSanPham.Size = new System.Drawing.Size(819, 535);
            this.PageNhaCungCapSanPham.Text = "Nhà Cung Cấp Sản Phẩm";
            // 
            // datagridview_nccsp
            // 
            this.datagridview_nccsp.Controls.Add(this.dgv_sp);
            this.datagridview_nccsp.Controls.Add(this.dgv_ncc);
            this.datagridview_nccsp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridview_nccsp.Location = new System.Drawing.Point(0, 124);
            this.datagridview_nccsp.Name = "datagridview_nccsp";
            this.datagridview_nccsp.Size = new System.Drawing.Size(819, 411);
            this.datagridview_nccsp.TabIndex = 3;
            // 
            // dgv_sp
            // 
            this.dgv_sp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sp.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgv_sp.Location = new System.Drawing.Point(390, 0);
            this.dgv_sp.Name = "dgv_sp";
            this.dgv_sp.Size = new System.Drawing.Size(429, 411);
            this.dgv_sp.TabIndex = 1;
            // 
            // dgv_ncc
            // 
            this.dgv_ncc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ncc.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgv_ncc.Location = new System.Drawing.Point(0, 0);
            this.dgv_ncc.Name = "dgv_ncc";
            this.dgv_ncc.Size = new System.Drawing.Size(392, 411);
            this.dgv_ncc.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_masanpham);
            this.panel1.Controls.Add(this.txt_giacungcap);
            this.panel1.Controls.Add(this.txt_manhacungcapsanpham);
            this.panel1.Controls.Add(this.lb_masanpham);
            this.panel1.Controls.Add(this.lb_giacungcap);
            this.panel1.Controls.Add(this.lb_manhacungcapsanpham);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 124);
            this.panel1.TabIndex = 2;
            // 
            // txt_masanpham
            // 
            this.txt_masanpham.Location = new System.Drawing.Point(567, 14);
            this.txt_masanpham.Name = "txt_masanpham";
            this.txt_masanpham.Size = new System.Drawing.Size(198, 20);
            this.txt_masanpham.TabIndex = 6;
            // 
            // txt_giacungcap
            // 
            this.txt_giacungcap.Location = new System.Drawing.Point(145, 64);
            this.txt_giacungcap.Name = "txt_giacungcap";
            this.txt_giacungcap.Size = new System.Drawing.Size(620, 20);
            this.txt_giacungcap.TabIndex = 5;
            // 
            // txt_manhacungcapsanpham
            // 
            this.txt_manhacungcapsanpham.Location = new System.Drawing.Point(145, 14);
            this.txt_manhacungcapsanpham.Name = "txt_manhacungcapsanpham";
            this.txt_manhacungcapsanpham.Size = new System.Drawing.Size(198, 20);
            this.txt_manhacungcapsanpham.TabIndex = 4;
            // 
            // lb_masanpham
            // 
            this.lb_masanpham.Location = new System.Drawing.Point(447, 17);
            this.lb_masanpham.Name = "lb_masanpham";
            this.lb_masanpham.Size = new System.Drawing.Size(64, 13);
            this.lb_masanpham.TabIndex = 2;
            this.lb_masanpham.Text = "Mã Sản Phẩm";
            // 
            // lb_giacungcap
            // 
            this.lb_giacungcap.Location = new System.Drawing.Point(22, 67);
            this.lb_giacungcap.Name = "lb_giacungcap";
            this.lb_giacungcap.Size = new System.Drawing.Size(65, 13);
            this.lb_giacungcap.TabIndex = 1;
            this.lb_giacungcap.Text = "Giá Cung Cấp";
            // 
            // lb_manhacungcapsanpham
            // 
            this.lb_manhacungcapsanpham.Location = new System.Drawing.Point(22, 17);
            this.lb_manhacungcapsanpham.Name = "lb_manhacungcapsanpham";
            this.lb_manhacungcapsanpham.Size = new System.Drawing.Size(86, 13);
            this.lb_manhacungcapsanpham.TabIndex = 0;
            this.lb_manhacungcapsanpham.Text = "Mã Nhà Cung Cấp";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(845, 584);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.nhacungcap;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(825, 564);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // UC_NhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl_nhacungcap);
            this.Name = "UC_NhaCungCap";
            this.Size = new System.Drawing.Size(845, 584);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_nhacungcap)).EndInit();
            this.layoutControl_nhacungcap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nhacungcap)).EndInit();
            this.nhacungcap.ResumeLayout(false);
            this.PageNhaCungCap.ResumeLayout(false);
            this.datagridview_ncc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhacungcap)).EndInit();
            this.thongtin.ResumeLayout(false);
            this.thongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sdt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_diachi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tennhacungcap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_manhacungcap.Properties)).EndInit();
            this.PageNhaCungCapSanPham.ResumeLayout(false);
            this.datagridview_nccsp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ncc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_masanpham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_giacungcap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_manhacungcapsanpham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl_nhacungcap;
        private DevExpress.XtraTab.XtraTabControl nhacungcap;
        private DevExpress.XtraTab.XtraTabPage PageNhaCungCap;
        private DevExpress.XtraTab.XtraTabPage PageNhaCungCapSanPham;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.Panel datagridview_ncc;
        private System.Windows.Forms.Panel thongtin;
        private System.Windows.Forms.DataGridView dgv_nhacungcap;
        private DevExpress.XtraEditors.TextEdit txt_sdt;
        private DevExpress.XtraEditors.TextEdit txt_diachi;
        private DevExpress.XtraEditors.TextEdit txt_tennhacungcap;
        private DevExpress.XtraEditors.TextEdit txt_manhacungcap;
        private DevExpress.XtraEditors.LabelControl lb_sodienthoai;
        private DevExpress.XtraEditors.LabelControl lb_diachi;
        private DevExpress.XtraEditors.LabelControl lb_tennhacungcap;
        private DevExpress.XtraEditors.LabelControl lb_manhacungcap;
        private DevExpress.XtraEditors.SimpleButton btn_load;
        private DevExpress.XtraEditors.SimpleButton btn_xoa;
        private DevExpress.XtraEditors.SimpleButton btn_sua;
        private DevExpress.XtraEditors.SimpleButton btn_them;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit txt_masanpham;
        private DevExpress.XtraEditors.TextEdit txt_giacungcap;
        private DevExpress.XtraEditors.TextEdit txt_manhacungcapsanpham;
        private DevExpress.XtraEditors.LabelControl lb_masanpham;
        private DevExpress.XtraEditors.LabelControl lb_giacungcap;
        private DevExpress.XtraEditors.LabelControl lb_manhacungcapsanpham;
        private System.Windows.Forms.Panel datagridview_nccsp;
        private System.Windows.Forms.DataGridView dgv_ncc;
        private System.Windows.Forms.DataGridView dgv_sp;
    }
}