
namespace GUI
{
    partial class UC_checkSP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_checkSP));
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.dgv_sp = new System.Windows.Forms.DataGridView();
            this.dgv_sp_add = new System.Windows.Forms.DataGridView();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txt_tk = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_xuatfiles = new DevExpress.XtraEditors.SimpleButton();
            this.bt_load = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sp_add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(0, 0);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(12, 1231);
            this.splitterControl1.TabIndex = 3;
            this.splitterControl1.TabStop = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.dgv_sp_add);
            this.panelControl1.Controls.Add(this.dgv_sp);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(12, 278);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(2154, 953);
            this.panelControl1.TabIndex = 4;
            // 
            // dgv_sp
            // 
            this.dgv_sp.AllowUserToAddRows = false;
            this.dgv_sp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sp.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgv_sp.Location = new System.Drawing.Point(2, 2);
            this.dgv_sp.Name = "dgv_sp";
            this.dgv_sp.RowHeadersWidth = 51;
            this.dgv_sp.RowTemplate.Height = 24;
            this.dgv_sp.Size = new System.Drawing.Size(1389, 949);
            this.dgv_sp.TabIndex = 0;
            // 
            // dgv_sp_add
            // 
            this.dgv_sp_add.AllowUserToAddRows = false;
            this.dgv_sp_add.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sp_add.Location = new System.Drawing.Point(1397, 5);
            this.dgv_sp_add.Name = "dgv_sp_add";
            this.dgv_sp_add.RowHeadersWidth = 51;
            this.dgv_sp_add.RowTemplate.Height = 24;
            this.dgv_sp_add.Size = new System.Drawing.Size(752, 1199);
            this.dgv_sp_add.TabIndex = 1;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Controls.Add(this.comboBox1);
            this.panelControl2.Controls.Add(this.txt_tk);
            this.panelControl2.Location = new System.Drawing.Point(12, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1391, 272);
            this.panelControl2.TabIndex = 5;
            // 
            // txt_tk
            // 
            this.txt_tk.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tk.Location = new System.Drawing.Point(250, 98);
            this.txt_tk.Multiline = true;
            this.txt_tk.Name = "txt_tk";
            this.txt_tk.Size = new System.Drawing.Size(808, 65);
            this.txt_tk.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "-- Lọc sản phẩm theo --"});
            this.comboBox1.Location = new System.Drawing.Point(1122, 199);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(264, 34);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = " Tìm kiếm";
            // 
            // bt_xuatfiles
            // 
            this.bt_xuatfiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_xuatfiles.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemSPTra.ImageOptions.Image")));
            this.bt_xuatfiles.Location = new System.Drawing.Point(1841, 98);
            this.bt_xuatfiles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_xuatfiles.Name = "bt_xuatfiles";
            this.bt_xuatfiles.Size = new System.Drawing.Size(186, 85);
            this.bt_xuatfiles.TabIndex = 69;
            this.bt_xuatfiles.Text = "Xuất files ";
            // 
            // bt_load
            // 
            this.bt_load.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_load.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.bt_load.Location = new System.Drawing.Point(1566, 98);
            this.bt_load.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_load.Name = "bt_load";
            this.bt_load.Size = new System.Drawing.Size(186, 85);
            this.bt_load.TabIndex = 70;
            this.bt_load.Text = "Làm mới";
            // 
            // UC_checkSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bt_load);
            this.Controls.Add(this.bt_xuatfiles);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.splitterControl1);
            this.Name = "UC_checkSP";
            this.Size = new System.Drawing.Size(2166, 1231);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sp_add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.DataGridView dgv_sp_add;
        private System.Windows.Forms.DataGridView dgv_sp;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.TextBox txt_tk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private DevExpress.XtraEditors.SimpleButton bt_xuatfiles;
        private DevExpress.XtraEditors.SimpleButton bt_load;
    }
}
