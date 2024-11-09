
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
            this.PageNhaCungCapSanPham = new DevExpress.XtraTab.XtraTabPage();
            this.datagridview_nccsp = new System.Windows.Forms.Panel();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_nhacungcap)).BeginInit();
            this.layoutControl_nhacungcap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhacungcap)).BeginInit();
            this.nhacungcap.SuspendLayout();
            this.PageNhaCungCapSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl_nhacungcap
            // 
            this.layoutControl_nhacungcap.Controls.Add(this.nhacungcap);
            this.layoutControl_nhacungcap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl_nhacungcap.Location = new System.Drawing.Point(0, 0);
            this.layoutControl_nhacungcap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layoutControl_nhacungcap.Name = "layoutControl_nhacungcap";
            this.layoutControl_nhacungcap.Root = this.Root;
            this.layoutControl_nhacungcap.Size = new System.Drawing.Size(986, 719);
            this.layoutControl_nhacungcap.TabIndex = 0;
            // 
            // nhacungcap
            // 
            this.nhacungcap.Location = new System.Drawing.Point(14, 14);
            this.nhacungcap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nhacungcap.Name = "nhacungcap";
            this.nhacungcap.SelectedTabPage = this.PageNhaCungCap;
            this.nhacungcap.Size = new System.Drawing.Size(958, 691);
            this.nhacungcap.TabIndex = 4;
            this.nhacungcap.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.PageNhaCungCap,
            this.PageNhaCungCapSanPham});
            // 
            // PageNhaCungCap
            // 
            this.PageNhaCungCap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PageNhaCungCap.Name = "PageNhaCungCap";
            this.PageNhaCungCap.Size = new System.Drawing.Size(956, 660);
            this.PageNhaCungCap.Text = "Nhà Cung Cấp";
            // 
            // PageNhaCungCapSanPham
            // 
            this.PageNhaCungCapSanPham.Controls.Add(this.datagridview_nccsp);
            this.PageNhaCungCapSanPham.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PageNhaCungCapSanPham.Name = "PageNhaCungCapSanPham";
            this.PageNhaCungCapSanPham.Size = new System.Drawing.Size(956, 660);
            this.PageNhaCungCapSanPham.Text = "Nhà Cung Cấp Sản Phẩm";
            // 
            // datagridview_nccsp
            // 
            this.datagridview_nccsp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridview_nccsp.Location = new System.Drawing.Point(0, 0);
            this.datagridview_nccsp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.datagridview_nccsp.Name = "datagridview_nccsp";
            this.datagridview_nccsp.Size = new System.Drawing.Size(956, 660);
            this.datagridview_nccsp.TabIndex = 3;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(986, 719);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.nhacungcap;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(962, 695);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // UC_NhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl_nhacungcap);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UC_NhaCungCap";
            this.Size = new System.Drawing.Size(986, 719);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_nhacungcap)).EndInit();
            this.layoutControl_nhacungcap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nhacungcap)).EndInit();
            this.nhacungcap.ResumeLayout(false);
            this.PageNhaCungCapSanPham.ResumeLayout(false);
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
        private System.Windows.Forms.Panel datagridview_nccsp;
    }
}
