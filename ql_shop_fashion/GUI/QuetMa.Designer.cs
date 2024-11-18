
namespace GUI
{
    partial class QuetMa
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
            this.components = new System.ComponentModel.Container();
            this.cboCam = new System.Windows.Forms.ComboBox();
            this.picHinh = new System.Windows.Forms.PictureBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picHinh)).BeginInit();
            this.SuspendLayout();
            // 
            // cboCam
            // 
            this.cboCam.FormattingEnabled = true;
            this.cboCam.Location = new System.Drawing.Point(95, 13);
            this.cboCam.Name = "cboCam";
            this.cboCam.Size = new System.Drawing.Size(121, 24);
            this.cboCam.TabIndex = 0;
            // 
            // picHinh
            // 
            this.picHinh.Location = new System.Drawing.Point(95, 79);
            this.picHinh.Name = "picHinh";
            this.picHinh.Size = new System.Drawing.Size(930, 659);
            this.picHinh.TabIndex = 1;
            this.picHinh.TabStop = false;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(223, 867);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(295, 22);
            this.txtMa.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(579, 814);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 90);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // QuetMa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 1055);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.picHinh);
            this.Controls.Add(this.cboCam);
            this.Name = "QuetMa";
            this.Text = "QuetMa";
            this.Load += new System.EventHandler(this.QuetMa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCam;
        private System.Windows.Forms.PictureBox picHinh;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}