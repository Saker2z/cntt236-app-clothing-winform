
namespace GUI
{
    partial class frmDuyetDonOnline
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
            this.dgvDonHang = new System.Windows.Forms.DataGridView();
            this.txtMaDon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNgayDat = new System.Windows.Forms.TextBox();
            this.dgvCTDonHang = new System.Windows.Forms.DataGridView();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDuyetDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDonHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDonHang
            // 
            this.dgvDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonHang.Location = new System.Drawing.Point(32, 348);
            this.dgvDonHang.Name = "dgvDonHang";
            this.dgvDonHang.RowHeadersWidth = 51;
            this.dgvDonHang.RowTemplate.Height = 24;
            this.dgvDonHang.Size = new System.Drawing.Size(1427, 323);
            this.dgvDonHang.TabIndex = 0;
            // 
            // txtMaDon
            // 
            this.txtMaDon.Location = new System.Drawing.Point(191, 9);
            this.txtMaDon.Name = "txtMaDon";
            this.txtMaDon.Size = new System.Drawing.Size(270, 29);
            this.txtMaDon.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã đơn hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên khách hàng";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(191, 61);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(270, 29);
            this.txtTenKH.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(191, 113);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(270, 29);
            this.txtDiaChi.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số điện thoại";
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(191, 165);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(270, 29);
            this.txtsdt.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ngày đặt:";
            // 
            // txtNgayDat
            // 
            this.txtNgayDat.Location = new System.Drawing.Point(191, 217);
            this.txtNgayDat.Name = "txtNgayDat";
            this.txtNgayDat.Size = new System.Drawing.Size(270, 29);
            this.txtNgayDat.TabIndex = 9;
            // 
            // dgvCTDonHang
            // 
            this.dgvCTDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTDonHang.Location = new System.Drawing.Point(514, 12);
            this.dgvCTDonHang.Name = "dgvCTDonHang";
            this.dgvCTDonHang.RowHeadersWidth = 51;
            this.dgvCTDonHang.RowTemplate.Height = 24;
            this.dgvCTDonHang.Size = new System.Drawing.Size(937, 255);
            this.dgvCTDonHang.TabIndex = 11;
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Location = new System.Drawing.Point(264, 297);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(295, 29);
            this.cboTrangThai.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Trạng thái đơn hàng";
            // 
            // btnDuyetDon
            // 
            this.btnDuyetDon.Location = new System.Drawing.Point(592, 292);
            this.btnDuyetDon.Name = "btnDuyetDon";
            this.btnDuyetDon.Size = new System.Drawing.Size(128, 40);
            this.btnDuyetDon.TabIndex = 14;
            this.btnDuyetDon.Text = "Duyệt đơn";
            this.btnDuyetDon.UseVisualStyleBackColor = true;
            // 
            // frmDuyetDonOnline
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1510, 683);
            this.Controls.Add(this.btnDuyetDon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboTrangThai);
            this.Controls.Add(this.dgvCTDonHang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNgayDat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaDon);
            this.Controls.Add(this.dgvDonHang);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmDuyetDonOnline";
            this.Text = "Duyệt đơn hàng online";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDonHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDonHang;
        private System.Windows.Forms.TextBox txtMaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNgayDat;
        private System.Windows.Forms.DataGridView dgvCTDonHang;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDuyetDon;
    }
}