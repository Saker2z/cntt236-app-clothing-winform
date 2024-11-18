
namespace GUI
{
    partial class frmInGia
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
            this.dgvSanPham = new DevExpress.XtraGrid.GridControl();
            this.dgvDS = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TenSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenKT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenMau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaGiam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.x = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvSanPhamThem = new DevExpress.XtraGrid.GridControl();
            this.dgvDS2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPhamThem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5);
            this.dgvSanPham.Location = new System.Drawing.Point(753, 94);
            this.dgvSanPham.MainView = this.dgvDS;
            this.dgvSanPham.Margin = new System.Windows.Forms.Padding(5);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.x});
            this.dgvSanPham.Size = new System.Drawing.Size(720, 511);
            this.dgvSanPham.TabIndex = 71;
            this.dgvSanPham.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvDS,
            this.gridView3});
            // 
            // dgvDS
            // 
            this.dgvDS.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TenSP,
            this.TenKT,
            this.TenMau,
            this.GiaBan,
            this.GiaGiam,
            this.MaSP});
            this.dgvDS.DetailHeight = 546;
            this.dgvDS.GridControl = this.dgvSanPham;
            this.dgvDS.Name = "dgvDS";
            this.dgvDS.OptionsView.ColumnAutoWidth = false;
            this.dgvDS.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            // 
            // TenSP
            // 
            this.TenSP.Caption = "Tên sản phẩm";
            this.TenSP.FieldName = "TenSP";
            this.TenSP.MinWidth = 25;
            this.TenSP.Name = "TenSP";
            this.TenSP.Visible = true;
            this.TenSP.VisibleIndex = 1;
            this.TenSP.Width = 119;
            // 
            // TenKT
            // 
            this.TenKT.Caption = "Kích thước";
            this.TenKT.FieldName = "TenKT";
            this.TenKT.MinWidth = 25;
            this.TenKT.Name = "TenKT";
            this.TenKT.Visible = true;
            this.TenKT.VisibleIndex = 2;
            this.TenKT.Width = 94;
            // 
            // TenMau
            // 
            this.TenMau.Caption = "Màu sắc";
            this.TenMau.FieldName = "TenMau";
            this.TenMau.MinWidth = 25;
            this.TenMau.Name = "TenMau";
            this.TenMau.Visible = true;
            this.TenMau.VisibleIndex = 3;
            this.TenMau.Width = 94;
            // 
            // GiaBan
            // 
            this.GiaBan.Caption = "Giá bán";
            this.GiaBan.FieldName = "GiaBan";
            this.GiaBan.MinWidth = 25;
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.Visible = true;
            this.GiaBan.VisibleIndex = 4;
            this.GiaBan.Width = 94;
            // 
            // GiaGiam
            // 
            this.GiaGiam.Caption = "Giá giảm";
            this.GiaGiam.DisplayFormat.FormatString = "0,00";
            this.GiaGiam.FieldName = "GiaGiam";
            this.GiaGiam.MinWidth = 25;
            this.GiaGiam.Name = "GiaGiam";
            this.GiaGiam.Visible = true;
            this.GiaGiam.VisibleIndex = 5;
            this.GiaGiam.Width = 94;
            // 
            // MaSP
            // 
            this.MaSP.Caption = "Mã sản phẩm";
            this.MaSP.FieldName = "MaSP";
            this.MaSP.MinWidth = 25;
            this.MaSP.Name = "MaSP";
            this.MaSP.Visible = true;
            this.MaSP.VisibleIndex = 0;
            this.MaSP.Width = 94;
            // 
            // x
            // 
            this.x.AutoHeight = false;
            this.x.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.x.Name = "x";
            // 
            // gridView3
            // 
            this.gridView3.DetailHeight = 546;
            this.gridView3.GridControl = this.dgvSanPham;
            this.gridView3.Name = "gridView3";
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(23, 2);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(86, 36);
            this.btnIn.TabIndex = 72;
            this.btnIn.Text = "In giá";
            this.btnIn.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(628, 50);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(115, 36);
            this.btnThem.TabIndex = 74;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // dgvSanPhamThem
            // 
            this.dgvSanPhamThem.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5);
            this.dgvSanPhamThem.Location = new System.Drawing.Point(23, 94);
            this.dgvSanPhamThem.MainView = this.dgvDS2;
            this.dgvSanPhamThem.Margin = new System.Windows.Forms.Padding(5);
            this.dgvSanPhamThem.Name = "dgvSanPhamThem";
            this.dgvSanPhamThem.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.dgvSanPhamThem.Size = new System.Drawing.Size(720, 511);
            this.dgvSanPhamThem.TabIndex = 75;
            this.dgvSanPhamThem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvDS2,
            this.gridView2});
            // 
            // dgvDS2
            // 
            this.dgvDS2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn7});
            this.dgvDS2.DetailHeight = 546;
            this.dgvDS2.GridControl = this.dgvSanPhamThem;
            this.dgvDS2.Name = "dgvDS2";
            this.dgvDS2.OptionsView.ColumnAutoWidth = false;
            this.dgvDS2.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tên sản phẩm";
            this.gridColumn1.FieldName = "TenSP";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 119;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Kích thước";
            this.gridColumn2.FieldName = "TenKT";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 94;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Màu sắc";
            this.gridColumn3.FieldName = "TenMau";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 94;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Giá bán";
            this.gridColumn4.FieldName = "GiaBan";
            this.gridColumn4.MinWidth = 25;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            this.gridColumn4.Width = 94;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Giá giảm";
            this.gridColumn5.DisplayFormat.FormatString = "0,00";
            this.gridColumn5.FieldName = "GiaGiam";
            this.gridColumn5.MinWidth = 25;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            this.gridColumn5.Width = 94;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Mã sản phẩm";
            this.gridColumn7.FieldName = "MaSP";
            this.gridColumn7.MinWidth = 25;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
            this.gridColumn7.Width = 94;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // gridView2
            // 
            this.gridView2.DetailHeight = 546;
            this.gridView2.GridControl = this.dgvSanPhamThem;
            this.gridView2.Name = "gridView2";
            // 
            // frmTesttt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1510, 643);
            this.Controls.Add(this.dgvSanPhamThem);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.dgvSanPham);
            this.Name = "frmTesttt";
            this.Text = "frmTesttt";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPhamThem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvSanPham;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvDS;
        private DevExpress.XtraGrid.Columns.GridColumn TenSP;
        private DevExpress.XtraGrid.Columns.GridColumn TenKT;
        private DevExpress.XtraGrid.Columns.GridColumn TenMau;
        private DevExpress.XtraGrid.Columns.GridColumn GiaBan;
        private DevExpress.XtraGrid.Columns.GridColumn GiaGiam;
        private DevExpress.XtraGrid.Columns.GridColumn MaSP;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit x;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnThem;
        private DevExpress.XtraGrid.GridControl dgvSanPhamThem;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvDS2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
    }
}