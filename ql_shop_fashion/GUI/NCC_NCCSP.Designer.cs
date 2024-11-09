
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.bt_them = new System.Windows.Forms.ToolStripButton();
            this.bt_sua = new System.Windows.Forms.ToolStripButton();
            this.bt_luu = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gct_spncc = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gct_dsncc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ma_ncc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ten_ncc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gct_spncc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gct_dsncc
            // 
            this.gct_dsncc.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gct_dsncc.Location = new System.Drawing.Point(0, 2);
            this.gct_dsncc.MainView = this.gridView1;
            this.gct_dsncc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gct_dsncc.Name = "gct_dsncc";
            this.gct_dsncc.Size = new System.Drawing.Size(345, 626);
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
            this.ma_ncc.Location = new System.Drawing.Point(441, 16);
            this.ma_ncc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ma_ncc.Name = "ma_ncc";
            this.ma_ncc.Size = new System.Drawing.Size(290, 20);
            this.ma_ncc.TabIndex = 1;
            // 
            // ten_ncc
            // 
            this.ten_ncc.Location = new System.Drawing.Point(447, 50);
            this.ten_ncc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ten_ncc.Name = "ten_ncc";
            this.ten_ncc.Size = new System.Drawing.Size(290, 20);
            this.ten_ncc.TabIndex = 2;
            // 
            // dc
            // 
            this.dc.Location = new System.Drawing.Point(441, 80);
            this.dc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dc.Name = "dc";
            this.dc.Size = new System.Drawing.Size(290, 20);
            this.dc.TabIndex = 3;
            // 
            // dt
            // 
            this.dt.Location = new System.Drawing.Point(441, 111);
            this.dt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(290, 20);
            this.dt.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(346, 19);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(81, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Mã nhà cung cấp";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(346, 52);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(85, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Tên nhà cung cấp";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(362, 84);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(32, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Địa chỉ";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(362, 114);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(62, 13);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Số điện thoại";
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
            this.bt_luu});
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
            this.bt_them.Size = new System.Drawing.Size(61, 24);
            this.bt_them.Text = "Thêm";
            // 
            // bt_sua
            // 
            this.bt_sua.Image = global::GUI.Properties.Resources.suaphieu;
            this.bt_sua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(50, 24);
            this.bt_sua.Text = "Sửa";
            // 
            // bt_luu
            // 
            this.bt_luu.Image = global::GUI.Properties.Resources.loadphieu;
            this.bt_luu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(51, 24);
            this.bt_luu.Text = "Lưu";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gct_spncc);
            this.panel2.Location = new System.Drawing.Point(346, 200);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(674, 468);
            this.panel2.TabIndex = 11;
            // 
            // gct_spncc
            // 
            this.gct_spncc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gct_spncc.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gct_spncc.Location = new System.Drawing.Point(0, 0);
            this.gct_spncc.MainView = this.gridView2;
            this.gct_spncc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gct_spncc.Name = "gct_spncc";
            this.gct_spncc.Size = new System.Drawing.Size(674, 468);
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
            // NCC_NCCSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dt);
            this.Controls.Add(this.dc);
            this.Controls.Add(this.ten_ncc);
            this.Controls.Add(this.ma_ncc);
            this.Controls.Add(this.gct_dsncc);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NCC_NCCSP";
            this.Size = new System.Drawing.Size(1126, 722);
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
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gct_spncc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gct_dsncc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit ma_ncc;
        private DevExpress.XtraEditors.TextEdit ten_ncc;
        private DevExpress.XtraEditors.TextEdit dc;
        private DevExpress.XtraEditors.TextEdit dt;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton bt_them;
        private System.Windows.Forms.ToolStripButton bt_sua;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gct_spncc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.ToolStripButton bt_luu;
    }
}
