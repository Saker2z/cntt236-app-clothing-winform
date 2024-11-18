
namespace GUI
{
    partial class frmThemSPVaoThongTin
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
            this.pnl_chinh = new System.Windows.Forms.Panel();
            this.cbb_mathongtin = new DevExpress.XtraEditors.ComboBoxEdit();
            this.pnl_gct_ctsp = new System.Windows.Forms.Panel();
            this.gct_ttsp = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btn_load = new DevExpress.XtraEditors.SimpleButton();
            this.btn_xoaspkhoitt = new DevExpress.XtraEditors.SimpleButton();
            this.btn_suasptrongtt = new DevExpress.XtraEditors.SimpleButton();
            this.btn_themspvaott = new DevExpress.XtraEditors.SimpleButton();
            this.cbb_masanpham = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lb_mathongtin = new DevExpress.XtraEditors.LabelControl();
            this.lb_masanpham = new DevExpress.XtraEditors.LabelControl();
            this.pnl_chinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_mathongtin.Properties)).BeginInit();
            this.pnl_gct_ctsp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gct_ttsp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_masanpham.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_chinh
            // 
            this.pnl_chinh.BackColor = System.Drawing.Color.White;
            this.pnl_chinh.Controls.Add(this.cbb_mathongtin);
            this.pnl_chinh.Controls.Add(this.pnl_gct_ctsp);
            this.pnl_chinh.Controls.Add(this.btn_load);
            this.pnl_chinh.Controls.Add(this.btn_xoaspkhoitt);
            this.pnl_chinh.Controls.Add(this.btn_suasptrongtt);
            this.pnl_chinh.Controls.Add(this.btn_themspvaott);
            this.pnl_chinh.Controls.Add(this.cbb_masanpham);
            this.pnl_chinh.Controls.Add(this.lb_mathongtin);
            this.pnl_chinh.Controls.Add(this.lb_masanpham);
            this.pnl_chinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_chinh.Location = new System.Drawing.Point(0, 0);
            this.pnl_chinh.Name = "pnl_chinh";
            this.pnl_chinh.Size = new System.Drawing.Size(709, 637);
            this.pnl_chinh.TabIndex = 0;
            // 
            // cbb_mathongtin
            // 
            this.cbb_mathongtin.Location = new System.Drawing.Point(470, 21);
            this.cbb_mathongtin.Name = "cbb_mathongtin";
            this.cbb_mathongtin.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cbb_mathongtin.Properties.Appearance.Options.UseFont = true;
            this.cbb_mathongtin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_mathongtin.Size = new System.Drawing.Size(180, 22);
            this.cbb_mathongtin.TabIndex = 46;
            // 
            // pnl_gct_ctsp
            // 
            this.pnl_gct_ctsp.Controls.Add(this.gct_ttsp);
            this.pnl_gct_ctsp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_gct_ctsp.Location = new System.Drawing.Point(0, 228);
            this.pnl_gct_ctsp.Name = "pnl_gct_ctsp";
            this.pnl_gct_ctsp.Size = new System.Drawing.Size(709, 409);
            this.pnl_gct_ctsp.TabIndex = 47;
            // 
            // gct_ttsp
            // 
            this.gct_ttsp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gct_ttsp.Location = new System.Drawing.Point(0, 0);
            this.gct_ttsp.MainView = this.gridView1;
            this.gct_ttsp.Name = "gct_ttsp";
            this.gct_ttsp.Size = new System.Drawing.Size(709, 409);
            this.gct_ttsp.TabIndex = 37;
            this.gct_ttsp.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gct_ttsp;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // btn_load
            // 
            this.btn_load.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_load.Location = new System.Drawing.Point(381, 145);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(269, 45);
            this.btn_load.TabIndex = 43;
            this.btn_load.Text = "Load";
            // 
            // btn_xoaspkhoitt
            // 
            this.btn_xoaspkhoitt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_xoaspkhoitt.Location = new System.Drawing.Point(381, 80);
            this.btn_xoaspkhoitt.Name = "btn_xoaspkhoitt";
            this.btn_xoaspkhoitt.Size = new System.Drawing.Size(269, 45);
            this.btn_xoaspkhoitt.TabIndex = 42;
            this.btn_xoaspkhoitt.Text = "Xóa Sản Phẩm Khỏi Thông Tin";
            // 
            // btn_suasptrongtt
            // 
            this.btn_suasptrongtt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_suasptrongtt.Location = new System.Drawing.Point(24, 145);
            this.btn_suasptrongtt.Name = "btn_suasptrongtt";
            this.btn_suasptrongtt.Size = new System.Drawing.Size(278, 45);
            this.btn_suasptrongtt.TabIndex = 41;
            this.btn_suasptrongtt.Text = "Sửa Sản Phẩm Trong Thông Tin";
            // 
            // btn_themspvaott
            // 
            this.btn_themspvaott.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_themspvaott.Location = new System.Drawing.Point(24, 80);
            this.btn_themspvaott.Name = "btn_themspvaott";
            this.btn_themspvaott.Size = new System.Drawing.Size(278, 45);
            this.btn_themspvaott.TabIndex = 40;
            this.btn_themspvaott.Text = "Thêm Sản Phẩm Vào Thông Tin";
            // 
            // cbb_masanpham
            // 
            this.cbb_masanpham.Location = new System.Drawing.Point(122, 21);
            this.cbb_masanpham.Name = "cbb_masanpham";
            this.cbb_masanpham.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cbb_masanpham.Properties.Appearance.Options.UseFont = true;
            this.cbb_masanpham.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_masanpham.Size = new System.Drawing.Size(180, 22);
            this.cbb_masanpham.TabIndex = 45;
            // 
            // lb_mathongtin
            // 
            this.lb_mathongtin.Location = new System.Drawing.Point(381, 26);
            this.lb_mathongtin.Name = "lb_mathongtin";
            this.lb_mathongtin.Size = new System.Drawing.Size(64, 13);
            this.lb_mathongtin.TabIndex = 44;
            this.lb_mathongtin.Text = "Mã Thông Tin";
            // 
            // lb_masanpham
            // 
            this.lb_masanpham.Location = new System.Drawing.Point(24, 26);
            this.lb_masanpham.Name = "lb_masanpham";
            this.lb_masanpham.Size = new System.Drawing.Size(64, 13);
            this.lb_masanpham.TabIndex = 39;
            this.lb_masanpham.Text = "Mã Sản Phẩm";
            // 
            // frmThemSPVaoThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 637);
            this.Controls.Add(this.pnl_chinh);
            this.Name = "frmThemSPVaoThongTin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThemSPVaoThongTin";
            this.pnl_chinh.ResumeLayout(false);
            this.pnl_chinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_mathongtin.Properties)).EndInit();
            this.pnl_gct_ctsp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gct_ttsp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_masanpham.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_chinh;
        private DevExpress.XtraEditors.ComboBoxEdit cbb_mathongtin;
        private System.Windows.Forms.Panel pnl_gct_ctsp;
        private DevExpress.XtraGrid.GridControl gct_ttsp;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btn_load;
        private DevExpress.XtraEditors.SimpleButton btn_xoaspkhoitt;
        private DevExpress.XtraEditors.SimpleButton btn_suasptrongtt;
        private DevExpress.XtraEditors.SimpleButton btn_themspvaott;
        private DevExpress.XtraEditors.ComboBoxEdit cbb_masanpham;
        private DevExpress.XtraEditors.LabelControl lb_mathongtin;
        private DevExpress.XtraEditors.LabelControl lb_masanpham;
    }
}