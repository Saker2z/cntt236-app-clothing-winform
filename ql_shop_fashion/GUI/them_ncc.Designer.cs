
namespace GUI
{
    partial class them_ncc
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
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dt = new DevExpress.XtraEditors.TextEdit();
            this.dc = new DevExpress.XtraEditors.TextEdit();
            this.ten_ncc = new DevExpress.XtraEditors.TextEdit();
            this.btthem = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ten_ncc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(55, 165);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(62, 13);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "Số điện thoại";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(55, 135);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(32, 13);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "Địa chỉ";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(39, 103);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(85, 13);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Tên nhà cung cấp";
            // 
            // dt
            // 
            this.dt.Location = new System.Drawing.Point(134, 162);
            this.dt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(290, 20);
            this.dt.TabIndex = 12;
            // 
            // dc
            // 
            this.dc.Location = new System.Drawing.Point(134, 131);
            this.dc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dc.Name = "dc";
            this.dc.Size = new System.Drawing.Size(290, 20);
            this.dc.TabIndex = 11;
            // 
            // ten_ncc
            // 
            this.ten_ncc.Location = new System.Drawing.Point(134, 101);
            this.ten_ncc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ten_ncc.Name = "ten_ncc";
            this.ten_ncc.Size = new System.Drawing.Size(290, 20);
            this.ten_ncc.TabIndex = 10;
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(94, 301);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(106, 69);
            this.btthem.TabIndex = 16;
            this.btthem.Text = "Thêm mới";
            this.btthem.UseVisualStyleBackColor = true;
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(263, 301);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(106, 69);
            this.btthoat.TabIndex = 17;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            // 
            // them_ncc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 451);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.dt);
            this.Controls.Add(this.dc);
            this.Controls.Add(this.ten_ncc);
            this.Name = "them_ncc";
            this.Text = "them_ncc";
            ((System.ComponentModel.ISupportInitialize)(this.dt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ten_ncc.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit dt;
        private DevExpress.XtraEditors.TextEdit dc;
        private DevExpress.XtraEditors.TextEdit ten_ncc;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button btthoat;
    }
}