﻿
namespace GUI
{
    partial class NCC_NCCSP
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
            this.gct_dsncc = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ma_ncc = new DevExpress.XtraEditors.TextEdit();
            this.ten_ncc = new DevExpress.XtraEditors.TextEdit();
            this.dc = new DevExpress.XtraEditors.TextEdit();
            this.dt = new DevExpress.XtraEditors.TextEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.bt_them = new System.Windows.Forms.ToolStripButton();
            this.bt_sua = new System.Windows.Forms.ToolStripButton();
            this.bt_luu = new System.Windows.Forms.ToolStripButton();
            this.bt_xoa = new System.Windows.Forms.ToolStripButton();
            this.bt_load = new System.Windows.Forms.ToolStripButton();
            this.pnl_spncc = new System.Windows.Forms.Panel();
            this.gct_spncc = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.them = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.gb_thongtinnhacungcap = new System.Windows.Forms.GroupBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gct_dsncc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ma_ncc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ten_ncc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.pnl_spncc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gct_spncc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.gb_thongtinnhacungcap.SuspendLayout();
            this.SuspendLayout();
            // 
            // gct_dsncc
            // 
            this.gct_dsncc.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gct_dsncc.Location = new System.Drawing.Point(0, 2);
            this.gct_dsncc.MainView = this.gridView1;
            this.gct_dsncc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gct_dsncc.Name = "gct_dsncc";
            this.gct_dsncc.Size = new System.Drawing.Size(345, 699);
            this.gct_dsncc.TabIndex = 0;
            this.gct_dsncc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.gct_dsncc;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // ma_ncc
            // 
            this.ma_ncc.Location = new System.Drawing.Point(162, 26);
            this.ma_ncc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ma_ncc.Name = "ma_ncc";
            this.ma_ncc.Size = new System.Drawing.Size(341, 20);
            this.ma_ncc.TabIndex = 1;
            // 
            // ten_ncc
            // 
            this.ten_ncc.Location = new System.Drawing.Point(162, 63);
            this.ten_ncc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ten_ncc.Name = "ten_ncc";
            this.ten_ncc.Size = new System.Drawing.Size(341, 20);
            this.ten_ncc.TabIndex = 2;
            // 
            // dc
            // 
            this.dc.Location = new System.Drawing.Point(162, 98);
            this.dc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dc.Name = "dc";
            this.dc.Size = new System.Drawing.Size(341, 20);
            this.dc.TabIndex = 3;
            // 
            // dt
            // 
            this.dt.Location = new System.Drawing.Point(162, 132);
            this.dt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(341, 20);
            this.dt.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip2);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Location = new System.Drawing.Point(346, 176);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 37);
            this.panel1.TabIndex = 10;
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Location = new System.Drawing.Point(0, 27);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(693, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bt_them,
            this.bt_sua,
            this.bt_luu,
            this.bt_xoa,
            this.bt_load});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(693, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // bt_them
            // 
            this.bt_them.Image = global::GUI.Properties.Resources.themphieu;
            this.bt_them.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(64, 24);
            this.bt_them.Text = "Thêm";
            // 
            // bt_sua
            // 
            this.bt_sua.Image = global::GUI.Properties.Resources.suaphieu;
            this.bt_sua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(54, 24);
            this.bt_sua.Text = "Sửa";
            // 
            // bt_luu
            // 
            this.bt_luu.Image = global::GUI.Properties.Resources.loadphieu;
            this.bt_luu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(53, 24);
            this.bt_luu.Text = "Lưu";
            // 
            // bt_xoa
            // 
            this.bt_xoa.Image = global::GUI.Properties.Resources.xoaphieu;
            this.bt_xoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(55, 24);
            this.bt_xoa.Text = "Xóa";
            // 
            // bt_load
            // 
            this.bt_load.Image = global::GUI.Properties.Resources.loadphieu;
            this.bt_load.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_load.Name = "bt_load";
            this.bt_load.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_load.Size = new System.Drawing.Size(82, 24);
            this.bt_load.Text = "Làm mới";
            // 
            // pnl_spncc
            // 
            this.pnl_spncc.Controls.Add(this.gct_spncc);
            this.pnl_spncc.Location = new System.Drawing.Point(346, 200);
            this.pnl_spncc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_spncc.Name = "pnl_spncc";
            this.pnl_spncc.Size = new System.Drawing.Size(693, 501);
            this.pnl_spncc.TabIndex = 11;
            // 
            // gct_spncc
            // 
            this.gct_spncc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gct_spncc.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gct_spncc.Location = new System.Drawing.Point(0, 0);
            this.gct_spncc.MainView = this.gridView2;
            this.gct_spncc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gct_spncc.Name = "gct_spncc";
            this.gct_spncc.Size = new System.Drawing.Size(693, 501);
            this.gct_spncc.TabIndex = 0;
            this.gct_spncc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.DetailHeight = 284;
            this.gridView2.GridControl = this.gct_spncc;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // them
            // 
            this.them.BackColor = System.Drawing.Color.White;
            this.them.Location = new System.Drawing.Point(562, 28);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(111, 30);
            this.them.TabIndex = 13;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = false;
            // 
            // sua
            // 
            this.sua.BackColor = System.Drawing.Color.White;
            this.sua.Location = new System.Drawing.Point(562, 75);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(111, 30);
            this.sua.TabIndex = 14;
            this.sua.Text = "Sửa";
            this.sua.UseVisualStyleBackColor = false;
            // 
            // xoa
            // 
            this.xoa.BackColor = System.Drawing.Color.White;
            this.xoa.Location = new System.Drawing.Point(562, 122);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(111, 30);
            this.xoa.TabIndex = 15;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = false;
            // 
            // gb_thongtinnhacungcap
            // 
            this.gb_thongtinnhacungcap.BackColor = System.Drawing.Color.White;
            this.gb_thongtinnhacungcap.Controls.Add(this.sua);
            this.gb_thongtinnhacungcap.Controls.Add(this.xoa);
            this.gb_thongtinnhacungcap.Controls.Add(this.labelControl5);
            this.gb_thongtinnhacungcap.Controls.Add(this.labelControl6);
            this.gb_thongtinnhacungcap.Controls.Add(this.them);
            this.gb_thongtinnhacungcap.Controls.Add(this.labelControl7);
            this.gb_thongtinnhacungcap.Controls.Add(this.labelControl8);
            this.gb_thongtinnhacungcap.Controls.Add(this.ma_ncc);
            this.gb_thongtinnhacungcap.Controls.Add(this.ten_ncc);
            this.gb_thongtinnhacungcap.Controls.Add(this.dc);
            this.gb_thongtinnhacungcap.Controls.Add(this.dt);
            this.gb_thongtinnhacungcap.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_thongtinnhacungcap.Location = new System.Drawing.Point(346, 3);
            this.gb_thongtinnhacungcap.Name = "gb_thongtinnhacungcap";
            this.gb_thongtinnhacungcap.Size = new System.Drawing.Size(693, 171);
            this.gb_thongtinnhacungcap.TabIndex = 13;
            this.gb_thongtinnhacungcap.TabStop = false;
            this.gb_thongtinnhacungcap.Text = "Thông tin nhà cung cấp";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(26, 100);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(69, 15);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Số điện thoại";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(26, 134);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(36, 15);
            this.labelControl6.TabIndex = 8;
            this.labelControl6.Text = "Địa chỉ";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(26, 65);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(93, 15);
            this.labelControl7.TabIndex = 7;
            this.labelControl7.Text = "Tên nhà cung cấp";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(26, 28);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(92, 15);
            this.labelControl8.TabIndex = 6;
            this.labelControl8.Text = "Mã nhà cung cấp";
            // 
            // NCC_NCCSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gb_thongtinnhacungcap);
            this.Controls.Add(this.pnl_spncc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gct_dsncc);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NCC_NCCSP";
            this.Size = new System.Drawing.Size(1046, 703);
            ((System.ComponentModel.ISupportInitialize)(this.gct_dsncc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ma_ncc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ten_ncc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnl_spncc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gct_spncc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.gb_thongtinnhacungcap.ResumeLayout(false);
            this.gb_thongtinnhacungcap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gct_dsncc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit ma_ncc;
        private DevExpress.XtraEditors.TextEdit ten_ncc;
        private DevExpress.XtraEditors.TextEdit dc;
        private DevExpress.XtraEditors.TextEdit dt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton bt_them;
        private System.Windows.Forms.ToolStripButton bt_sua;
        private System.Windows.Forms.Panel pnl_spncc;
        private DevExpress.XtraGrid.GridControl gct_spncc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.ToolStripButton bt_luu;
        private System.Windows.Forms.ToolStripButton bt_xoa;
        private System.Windows.Forms.ToolStripButton bt_load;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.GroupBox gb_thongtinnhacungcap;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
    }
}
