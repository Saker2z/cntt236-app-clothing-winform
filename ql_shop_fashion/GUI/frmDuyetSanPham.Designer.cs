
namespace GUI
{
    partial class frmDuyetSanPham
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
            this.lct_dsspcd = new DevExpress.XtraLayout.LayoutControl();
            this.gdv_duyet_sp = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.dgv_dsnhap = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.bt_duyet = new DevExpress.XtraEditors.CheckButton();
            this.bt_ht = new DevExpress.XtraEditors.CheckButton();
            ((System.ComponentModel.ISupportInitialize)(this.lct_dsspcd)).BeginInit();
            this.lct_dsspcd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_duyet_sp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsnhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // lct_dsspcd
            // 
            this.lct_dsspcd.BackColor = System.Drawing.Color.White;
            this.lct_dsspcd.Controls.Add(this.gdv_duyet_sp);
            this.lct_dsspcd.Location = new System.Drawing.Point(484, 36);
            this.lct_dsspcd.Name = "lct_dsspcd";
            this.lct_dsspcd.Root = this.Root;
            this.lct_dsspcd.Size = new System.Drawing.Size(483, 651);
            this.lct_dsspcd.TabIndex = 53;
            this.lct_dsspcd.Text = "layoutControl1";
            // 
            // gdv_duyet_sp
            // 
            this.gdv_duyet_sp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdv_duyet_sp.Location = new System.Drawing.Point(12, 32);
            this.gdv_duyet_sp.MainView = this.gridView1;
            this.gdv_duyet_sp.Name = "gdv_duyet_sp";
            this.gdv_duyet_sp.Size = new System.Drawing.Size(459, 607);
            this.gdv_duyet_sp.TabIndex = 4;
            this.gdv_duyet_sp.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gdv_duyet_sp;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(483, 651);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.gdv_duyet_sp;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(463, 631);
            this.layoutControlItem1.Text = "Danh sách sản phẩm cần duyệt";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(192, 17);
            // 
            // layoutControl2
            // 
            this.layoutControl2.BackColor = System.Drawing.Color.White;
            this.layoutControl2.Controls.Add(this.dgv_dsnhap);
            this.layoutControl2.Location = new System.Drawing.Point(-3, 7);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(538, 362, 650, 400);
            this.layoutControl2.Root = this.layoutControlGroup1;
            this.layoutControl2.Size = new System.Drawing.Size(493, 680);
            this.layoutControl2.TabIndex = 54;
            this.layoutControl2.Text = "lct_dsdsp";
            // 
            // dgv_dsnhap
            // 
            this.dgv_dsnhap.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_dsnhap.Location = new System.Drawing.Point(12, 32);
            this.dgv_dsnhap.MainView = this.gridView2;
            this.dgv_dsnhap.Name = "dgv_dsnhap";
            this.dgv_dsnhap.Size = new System.Drawing.Size(469, 636);
            this.dgv_dsnhap.TabIndex = 4;
            this.dgv_dsnhap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.dgv_dsnhap;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(493, 680);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Control = this.dgv_dsnhap;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem1";
            this.layoutControlItem2.Size = new System.Drawing.Size(473, 660);
            this.layoutControlItem2.Text = "Danh sách đơn sản phẩm";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(156, 17);
            // 
            // bt_duyet
            // 
            this.bt_duyet.Appearance.BackColor = System.Drawing.Color.Red;
            this.bt_duyet.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_duyet.Appearance.ForeColor = System.Drawing.Color.Black;
            this.bt_duyet.Appearance.Options.UseBackColor = true;
            this.bt_duyet.Appearance.Options.UseFont = true;
            this.bt_duyet.Appearance.Options.UseForeColor = true;
            this.bt_duyet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_duyet.Location = new System.Drawing.Point(736, 12);
            this.bt_duyet.Name = "bt_duyet";
            this.bt_duyet.Size = new System.Drawing.Size(219, 22);
            this.bt_duyet.TabIndex = 57;
            this.bt_duyet.Text = "Duyệt";
            // 
            // bt_ht
            // 
            this.bt_ht.Appearance.BackColor = System.Drawing.Color.Red;
            this.bt_ht.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ht.Appearance.ForeColor = System.Drawing.Color.Black;
            this.bt_ht.Appearance.Options.UseBackColor = true;
            this.bt_ht.Appearance.Options.UseFont = true;
            this.bt_ht.Appearance.Options.UseForeColor = true;
            this.bt_ht.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_ht.Location = new System.Drawing.Point(496, 12);
            this.bt_ht.Name = "bt_ht";
            this.bt_ht.Size = new System.Drawing.Size(227, 22);
            this.bt_ht.TabIndex = 60;
            this.bt_ht.Text = "Hoàn thành đơn";
            // 
            // frmDuyetSanPham
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 684);
            this.Controls.Add(this.bt_duyet);
            this.Controls.Add(this.layoutControl2);
            this.Controls.Add(this.bt_ht);
            this.Controls.Add(this.lct_dsspcd);
            this.Name = "frmDuyetSanPham";
            this.Text = "frmDuyetSanPham";
            ((System.ComponentModel.ISupportInitialize)(this.lct_dsspcd)).EndInit();
            this.lct_dsspcd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdv_duyet_sp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsnhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraLayout.LayoutControl lct_dsspcd;
        private DevExpress.XtraGrid.GridControl gdv_duyet_sp;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraGrid.GridControl dgv_dsnhap;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.CheckButton bt_duyet;
        private DevExpress.XtraEditors.CheckButton bt_ht;
    }
}