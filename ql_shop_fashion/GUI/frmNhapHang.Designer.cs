
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapHang));
            this.txt_manhaphang = new DevExpress.XtraEditors.TextEdit();
            this.txt_manhanvien = new DevExpress.XtraEditors.TextEdit();
            this.txt_ghichu = new DevExpress.XtraEditors.TextEdit();
            this.txt_tongsoluong = new DevExpress.XtraEditors.TextEdit();
            this.txt_tonggiatien = new DevExpress.XtraEditors.TextEdit();
            this.cbb_manhacungcap = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbb_trangthai = new DevExpress.XtraEditors.ComboBoxEdit();
            this.panel_chinh = new System.Windows.Forms.Panel();
            this.menuchucnang = new System.Windows.Forms.ToolStrip();
            this.chon = new System.Windows.Forms.ToolStripDropDownButton();
            this.them = new System.Windows.Forms.ToolStripMenuItem();
            this.sua = new System.Windows.Forms.ToolStripMenuItem();
            this.xoa = new System.Windows.Forms.ToolStripMenuItem();
            this.load = new System.Windows.Forms.ToolStripMenuItem();
            this.duyet = new System.Windows.Forms.ToolStripButton();
            this.inphieu = new System.Windows.Forms.ToolStripButton();
            this.thoat = new System.Windows.Forms.ToolStripButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.txt_manhaphang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_manhanvien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ghichu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tongsoluong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tonggiatien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_manhacungcap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_trangthai.Properties)).BeginInit();
            this.panel_chinh.SuspendLayout();
            this.menuchucnang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sanpham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sanpham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tenncc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngaynhap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngaynhap.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_manhaphang
            // 
            this.txt_manhaphang.Location = new System.Drawing.Point(147, 41);
            this.txt_manhaphang.Name = "txt_manhaphang";
            this.txt_manhaphang.Size = new System.Drawing.Size(482, 20);
            this.txt_manhaphang.TabIndex = 0;
            this.txt_manhaphang.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // txt_manhanvien
            // 
            this.txt_manhanvien.Location = new System.Drawing.Point(147, 88);
            this.txt_manhanvien.Name = "txt_manhanvien";
            this.txt_manhanvien.Size = new System.Drawing.Size(482, 20);
            this.txt_manhanvien.TabIndex = 1;
            // 
            // txt_ghichu
            // 
            this.txt_ghichu.Location = new System.Drawing.Point(785, 41);
            this.txt_ghichu.Name = "txt_ghichu";
            this.txt_ghichu.Size = new System.Drawing.Size(292, 20);
            this.txt_ghichu.TabIndex = 3;
            // 
            // txt_tongsoluong
            // 
            this.txt_tongsoluong.Location = new System.Drawing.Point(785, 88);
            this.txt_tongsoluong.Name = "txt_tongsoluong";
            this.txt_tongsoluong.Size = new System.Drawing.Size(292, 20);
            this.txt_tongsoluong.TabIndex = 4;
            // 
            // txt_tonggiatien
            // 
            this.txt_tonggiatien.Location = new System.Drawing.Point(785, 134);
            this.txt_tonggiatien.Name = "txt_tonggiatien";
            this.txt_tonggiatien.Size = new System.Drawing.Size(292, 20);
            this.txt_tonggiatien.TabIndex = 5;
            // 
            // cbb_manhacungcap
            // 
            this.cbb_manhacungcap.Location = new System.Drawing.Point(147, 184);
            this.cbb_manhacungcap.Name = "cbb_manhacungcap";
            this.cbb_manhacungcap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_manhacungcap.Size = new System.Drawing.Size(482, 20);
            this.cbb_manhacungcap.TabIndex = 6;
            // 
            // cbb_trangthai
            // 
            this.cbb_trangthai.Location = new System.Drawing.Point(785, 184);
            this.cbb_trangthai.Name = "cbb_trangthai";
            this.cbb_trangthai.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_trangthai.Size = new System.Drawing.Size(292, 20);
            this.cbb_trangthai.TabIndex = 7;
            // 
            // panel_chinh
            // 
            this.panel_chinh.Controls.Add(this.menuchucnang);
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
            this.panel_chinh.Location = new System.Drawing.Point(0, 0);
            this.panel_chinh.Name = "panel_chinh";
            this.panel_chinh.Size = new System.Drawing.Size(1098, 642);
            this.panel_chinh.TabIndex = 0;
            // 
            // menuchucnang
            // 
            this.menuchucnang.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chon,
            this.duyet,
            this.inphieu,
            this.thoat});
            this.menuchucnang.Location = new System.Drawing.Point(0, 0);
            this.menuchucnang.Name = "menuchucnang";
            this.menuchucnang.Size = new System.Drawing.Size(1098, 25);
            this.menuchucnang.TabIndex = 23;
            this.menuchucnang.Text = "MenuChucNang";
            // 
            // chon
            // 
            this.chon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.them,
            this.sua,
            this.xoa,
            this.load});
            this.chon.Image = global::GUI.Properties.Resources.chon;
            this.chon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.chon.Name = "chon";
            this.chon.Size = new System.Drawing.Size(67, 22);
            this.chon.Text = "Chọn";
            // 
            // them
            // 
            this.them.Image = global::GUI.Properties.Resources.themphieu;
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(180, 22);
            this.them.Text = "Thêm";
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // sua
            // 
            this.sua.Image = global::GUI.Properties.Resources.suaphieu;
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(180, 22);
            this.sua.Text = "Sửa";
            // 
            // xoa
            // 
            this.xoa.Image = global::GUI.Properties.Resources.xoaphieu;
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(180, 22);
            this.xoa.Text = "Xóa";
            // 
            // load
            // 
            this.load.Image = global::GUI.Properties.Resources.loadphieu;
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(180, 22);
            this.load.Text = "Load";
            // 
            // duyet
            // 
            this.duyet.Image = global::GUI.Properties.Resources.duyet;
            this.duyet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.duyet.Name = "duyet";
            this.duyet.Size = new System.Drawing.Size(61, 22);
            this.duyet.Text = "Duyệt";
            this.duyet.Click += new System.EventHandler(this.duyet_Click);
            // 
            // inphieu
            // 
            this.inphieu.Image = global::GUI.Properties.Resources.inphieu;
            this.inphieu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.inphieu.Name = "inphieu";
            this.inphieu.Size = new System.Drawing.Size(73, 22);
            this.inphieu.Text = "In Phiếu";
            // 
            // thoat
            // 
            this.thoat.Image = global::GUI.Properties.Resources.thoat;
            this.thoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(61, 22);
            this.thoat.Text = "Thoát";
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // dgv_sanpham
            // 
            this.dgv_sanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sanpham.Location = new System.Drawing.Point(693, 287);
            this.dgv_sanpham.Name = "dgv_sanpham";
            this.dgv_sanpham.Size = new System.Drawing.Size(384, 284);
            this.dgv_sanpham.TabIndex = 22;
            // 
            // timkiemsanpham
            // 
            this.timkiemsanpham.Appearance.BackColor = System.Drawing.Color.White;
            this.timkiemsanpham.Appearance.Options.UseBackColor = true;
            this.timkiemsanpham.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.timkiemsanpham.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.timkiemsanpham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.timkiemsanpham.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("timkiemsanpham.ImageOptions.Image")));
            this.timkiemsanpham.Location = new System.Drawing.Point(1054, 235);
            this.timkiemsanpham.Name = "timkiemsanpham";
            this.timkiemsanpham.Size = new System.Drawing.Size(23, 20);
            this.timkiemsanpham.TabIndex = 21;
            // 
            // txt_sanpham
            // 
            this.txt_sanpham.Location = new System.Drawing.Point(693, 234);
            this.txt_sanpham.Name = "txt_sanpham";
            this.txt_sanpham.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sanpham.Properties.Appearance.Options.UseFont = true;
            this.txt_sanpham.Size = new System.Drawing.Size(384, 22);
            this.txt_sanpham.TabIndex = 20;
            // 
            // timkiemncc
            // 
            this.timkiemncc.Appearance.BackColor = System.Drawing.Color.White;
            this.timkiemncc.Appearance.Options.UseBackColor = true;
            this.timkiemncc.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.timkiemncc.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.timkiemncc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.timkiemncc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("timkiemncc.ImageOptions.Image")));
            this.timkiemncc.Location = new System.Drawing.Point(606, 235);
            this.timkiemncc.Name = "timkiemncc";
            this.timkiemncc.Size = new System.Drawing.Size(23, 20);
            this.timkiemncc.TabIndex = 19;
            // 
            // txt_tenncc
            // 
            this.txt_tenncc.Location = new System.Drawing.Point(21, 234);
            this.txt_tenncc.Name = "txt_tenncc";
            this.txt_tenncc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenncc.Properties.Appearance.Options.UseFont = true;
            this.txt_tenncc.Size = new System.Drawing.Size(608, 22);
            this.txt_tenncc.TabIndex = 18;
            // 
            // dgv_nh
            // 
            this.dgv_nh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nh.Location = new System.Drawing.Point(21, 287);
            this.dgv_nh.Name = "dgv_nh";
            this.dgv_nh.Size = new System.Drawing.Size(608, 284);
            this.dgv_nh.TabIndex = 17;
            // 
            // lb_trangthai
            // 
            this.lb_trangthai.Location = new System.Drawing.Point(693, 187);
            this.lb_trangthai.Name = "lb_trangthai";
            this.lb_trangthai.Size = new System.Drawing.Size(49, 13);
            this.lb_trangthai.TabIndex = 16;
            this.lb_trangthai.Text = "Trạng thái";
            // 
            // lb_tongtien
            // 
            this.lb_tongtien.Location = new System.Drawing.Point(693, 137);
            this.lb_tongtien.Name = "lb_tongtien";
            this.lb_tongtien.Size = new System.Drawing.Size(62, 13);
            this.lb_tongtien.TabIndex = 15;
            this.lb_tongtien.Text = "Tổng giá tiền";
            // 
            // lb_tongsoluong
            // 
            this.lb_tongsoluong.Location = new System.Drawing.Point(693, 91);
            this.lb_tongsoluong.Name = "lb_tongsoluong";
            this.lb_tongsoluong.Size = new System.Drawing.Size(68, 13);
            this.lb_tongsoluong.TabIndex = 14;
            this.lb_tongsoluong.Text = "Tổng số lượng";
            // 
            // lb_ghichu
            // 
            this.lb_ghichu.Location = new System.Drawing.Point(693, 44);
            this.lb_ghichu.Name = "lb_ghichu";
            this.lb_ghichu.Size = new System.Drawing.Size(35, 13);
            this.lb_ghichu.TabIndex = 13;
            this.lb_ghichu.Text = "Ghi chú";
            // 
            // lb_manhacungcap
            // 
            this.lb_manhacungcap.Location = new System.Drawing.Point(21, 187);
            this.lb_manhacungcap.Name = "lb_manhacungcap";
            this.lb_manhacungcap.Size = new System.Drawing.Size(81, 13);
            this.lb_manhacungcap.TabIndex = 12;
            this.lb_manhacungcap.Text = "Mã nhà cung cấp";
            // 
            // lb_ngaynhap
            // 
            this.lb_ngaynhap.Location = new System.Drawing.Point(21, 137);
            this.lb_ngaynhap.Name = "lb_ngaynhap";
            this.lb_ngaynhap.Size = new System.Drawing.Size(52, 13);
            this.lb_ngaynhap.TabIndex = 11;
            this.lb_ngaynhap.Text = "Ngày nhập";
            // 
            // lb_manhanvien
            // 
            this.lb_manhanvien.Location = new System.Drawing.Point(21, 91);
            this.lb_manhanvien.Name = "lb_manhanvien";
            this.lb_manhanvien.Size = new System.Drawing.Size(68, 13);
            this.lb_manhanvien.TabIndex = 10;
            this.lb_manhanvien.Text = "Tên nhân viên";
            // 
            // lb_manhaphang
            // 
            this.lb_manhaphang.Location = new System.Drawing.Point(21, 44);
            this.lb_manhaphang.Name = "lb_manhaphang";
            this.lb_manhaphang.Size = new System.Drawing.Size(68, 13);
            this.lb_manhaphang.TabIndex = 9;
            this.lb_manhaphang.Text = "Mã nhập hàng";
            // 
            // ngaynhap
            // 
            this.ngaynhap.EditValue = null;
            this.ngaynhap.Location = new System.Drawing.Point(147, 134);
            this.ngaynhap.Name = "ngaynhap";
            this.ngaynhap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngaynhap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngaynhap.Size = new System.Drawing.Size(482, 20);
            this.ngaynhap.TabIndex = 8;
            // 
            // frmNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 642);
            this.Controls.Add(this.panel_chinh);
            this.Name = "frmNhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNhapHang";
            ((System.ComponentModel.ISupportInitialize)(this.txt_manhaphang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_manhanvien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ghichu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tongsoluong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tonggiatien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_manhacungcap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_trangthai.Properties)).EndInit();
            this.panel_chinh.ResumeLayout(false);
            this.panel_chinh.PerformLayout();
            this.menuchucnang.ResumeLayout(false);
            this.menuchucnang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sanpham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sanpham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tenncc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngaynhap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngaynhap.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.ToolStrip menuchucnang;
        private System.Windows.Forms.ToolStripDropDownButton chon;
        private System.Windows.Forms.ToolStripMenuItem them;
        private System.Windows.Forms.ToolStripMenuItem sua;
        private System.Windows.Forms.ToolStripMenuItem xoa;
        private System.Windows.Forms.ToolStripMenuItem load;
        private System.Windows.Forms.ToolStripButton duyet;
        private System.Windows.Forms.ToolStripButton inphieu;
        private System.Windows.Forms.ToolStripButton thoat;
    }
}