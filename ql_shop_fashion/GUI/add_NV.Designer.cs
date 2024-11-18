
namespace GUI
{
    partial class add_NV
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_add = new System.Windows.Forms.Button();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_dc = new System.Windows.Forms.TextBox();
            this.ngay_vl = new System.Windows.Forms.DateTimePicker();
            this.cbb_cv = new System.Windows.Forms.ComboBox();
            this.cbb_quyen = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ Tên Nhân Viên: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chức Vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số Điện Thoại: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa Chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày Vào Làm";
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(305, 495);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(154, 43);
            this.bt_add.TabIndex = 5;
            this.bt_add.Text = "Tạo Hồ Sơ";
            this.bt_add.UseVisualStyleBackColor = true;
            // 
            // txt_hoten
            // 
            this.txt_hoten.Location = new System.Drawing.Point(262, 94);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(302, 22);
            this.txt_hoten.TabIndex = 6;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(262, 207);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(302, 22);
            this.txt_sdt.TabIndex = 7;
            // 
            // txt_dc
            // 
            this.txt_dc.Location = new System.Drawing.Point(262, 257);
            this.txt_dc.Name = "txt_dc";
            this.txt_dc.Size = new System.Drawing.Size(302, 22);
            this.txt_dc.TabIndex = 8;
            // 
            // ngay_vl
            // 
            this.ngay_vl.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngay_vl.Location = new System.Drawing.Point(262, 304);
            this.ngay_vl.Name = "ngay_vl";
            this.ngay_vl.Size = new System.Drawing.Size(302, 22);
            this.ngay_vl.TabIndex = 9;
            // 
            // cbb_cv
            // 
            this.cbb_cv.FormattingEnabled = true;
            this.cbb_cv.Location = new System.Drawing.Point(262, 145);
            this.cbb_cv.Name = "cbb_cv";
            this.cbb_cv.Size = new System.Drawing.Size(302, 24);
            this.cbb_cv.TabIndex = 10;
            // 
            // cbb_quyen
            // 
            this.cbb_quyen.FormattingEnabled = true;
            this.cbb_quyen.Location = new System.Drawing.Point(262, 384);
            this.cbb_quyen.Name = "cbb_quyen";
            this.cbb_quyen.Size = new System.Drawing.Size(218, 24);
            this.cbb_quyen.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Quyền user:";
            // 
            // add_NV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 590);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbb_quyen);
            this.Controls.Add(this.cbb_cv);
            this.Controls.Add(this.ngay_vl);
            this.Controls.Add(this.txt_dc);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.txt_hoten);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "add_NV";
            this.Text = "add_NV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.TextBox txt_dc;
        private System.Windows.Forms.DateTimePicker ngay_vl;
        private System.Windows.Forms.ComboBox cbb_cv;
        private System.Windows.Forms.ComboBox cbb_quyen;
        private System.Windows.Forms.Label label6;
    }
}