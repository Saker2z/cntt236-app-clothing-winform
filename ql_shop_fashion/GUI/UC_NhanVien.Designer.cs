
namespace GUI
{
    partial class UC_NhanVien
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
            this.gct_nv = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bt_them = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ngay_vl = new System.Windows.Forms.DateTimePicker();
            this.cbb_cv = new System.Windows.Forms.ComboBox();
            this.txt_sdt = new System.Windows.Forms.MaskedTextBox();
            this.txt_dc = new System.Windows.Forms.MaskedTextBox();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_mk = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_tk = new System.Windows.Forms.TextBox();
            this.bt_rs_pass = new System.Windows.Forms.Button();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gct_nv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gct_nv
            // 
            this.gct_nv.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gct_nv.Location = new System.Drawing.Point(13, 332);
            this.gct_nv.MainView = this.gridView1;
            this.gct_nv.Margin = new System.Windows.Forms.Padding(2);
            this.gct_nv.Name = "gct_nv";
            this.gct_nv.Size = new System.Drawing.Size(782, 348);
            this.gct_nv.TabIndex = 0;
            this.gct_nv.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.gct_nv;
            this.gridView1.Name = "gridView1";
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(828, 574);
            this.bt_them.Margin = new System.Windows.Forms.Padding(2);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(124, 52);
            this.bt_them.TabIndex = 1;
            this.bt_them.Text = "Tạo hồ sơ nhân viên";
            this.bt_them.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ngay_vl);
            this.groupBox1.Controls.Add(this.cbb_cv);
            this.groupBox1.Controls.Add(this.txt_sdt);
            this.groupBox1.Controls.Add(this.txt_dc);
            this.groupBox1.Controls.Add(this.txt_hoten);
            this.groupBox1.Location = new System.Drawing.Point(13, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 310);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin cá nhân";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ngày Vào Làm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số Điện Thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Địa Chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Chức Vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Họ Và Tên ";
            // 
            // ngay_vl
            // 
            this.ngay_vl.Location = new System.Drawing.Point(142, 248);
            this.ngay_vl.Name = "ngay_vl";
            this.ngay_vl.Size = new System.Drawing.Size(375, 20);
            this.ngay_vl.TabIndex = 0;
            // 
            // cbb_cv
            // 
            this.cbb_cv.FormattingEnabled = true;
            this.cbb_cv.Location = new System.Drawing.Point(142, 93);
            this.cbb_cv.Name = "cbb_cv";
            this.cbb_cv.Size = new System.Drawing.Size(375, 21);
            this.cbb_cv.TabIndex = 3;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(142, 193);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(375, 20);
            this.txt_sdt.TabIndex = 2;
            // 
            // txt_dc
            // 
            this.txt_dc.Location = new System.Drawing.Point(142, 140);
            this.txt_dc.Name = "txt_dc";
            this.txt_dc.Size = new System.Drawing.Size(375, 20);
            this.txt_dc.TabIndex = 1;
            // 
            // txt_hoten
            // 
            this.txt_hoten.Location = new System.Drawing.Point(142, 51);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(375, 20);
            this.txt_hoten.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_rs_pass);
            this.groupBox2.Controls.Add(this.txt_mk);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_tk);
            this.groupBox2.Location = new System.Drawing.Point(630, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 279);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin tài khoản";
            // 
            // txt_mk
            // 
            this.txt_mk.Location = new System.Drawing.Point(78, 96);
            this.txt_mk.Name = "txt_mk";
            this.txt_mk.Size = new System.Drawing.Size(173, 20);
            this.txt_mk.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Mật Khẩu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tài khoản";
            // 
            // txt_tk
            // 
            this.txt_tk.Location = new System.Drawing.Point(78, 46);
            this.txt_tk.Name = "txt_tk";
            this.txt_tk.Size = new System.Drawing.Size(173, 20);
            this.txt_tk.TabIndex = 9;
            // 
            // bt_rs_pass
            // 
            this.bt_rs_pass.Location = new System.Drawing.Point(113, 139);
            this.bt_rs_pass.Name = "bt_rs_pass";
            this.bt_rs_pass.Size = new System.Drawing.Size(120, 23);
            this.bt_rs_pass.TabIndex = 12;
            this.bt_rs_pass.Text = "Tạo mới mật khẩu";
            this.bt_rs_pass.UseVisualStyleBackColor = true;
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(828, 488);
            this.bt_save.Margin = new System.Windows.Forms.Padding(2);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(124, 52);
            this.bt_save.TabIndex = 4;
            this.bt_save.Text = "Cập Nhật Mới";
            this.bt_save.UseVisualStyleBackColor = true;
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(828, 402);
            this.bt_xoa.Margin = new System.Windows.Forms.Padding(2);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(124, 52);
            this.bt_xoa.TabIndex = 5;
            this.bt_xoa.Text = "Xóa Hồ Sơ Nhân Viên";
            this.bt_xoa.UseVisualStyleBackColor = true;
            // 
            // UC_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.gct_nv);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_NhanVien";
            this.Size = new System.Drawing.Size(966, 693);
            ((System.ComponentModel.ISupportInitialize)(this.gct_nv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gct_nv;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker ngay_vl;
        private System.Windows.Forms.ComboBox cbb_cv;
        private System.Windows.Forms.MaskedTextBox txt_sdt;
        private System.Windows.Forms.MaskedTextBox txt_dc;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.TextBox txt_mk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_tk;
        private System.Windows.Forms.Button bt_rs_pass;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_xoa;
    }
}
