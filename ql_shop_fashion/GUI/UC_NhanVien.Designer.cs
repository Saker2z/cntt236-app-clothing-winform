
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
            ((System.ComponentModel.ISupportInitialize)(this.gct_nv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gct_nv
            // 
            this.gct_nv.Location = new System.Drawing.Point(23, 426);
            this.gct_nv.MainView = this.gridView1;
            this.gct_nv.Name = "gct_nv";
            this.gct_nv.Size = new System.Drawing.Size(1037, 424);
            this.gct_nv.TabIndex = 0;
            this.gct_nv.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gct_nv;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(786, 188);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(166, 64);
            this.bt_them.TabIndex = 1;
            this.bt_them.Text = "Tạo hồ sơ nhân viên";
            this.bt_them.UseVisualStyleBackColor = true;
            // 
            // UC_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.gct_nv);
            this.Name = "UC_NhanVien";
            this.Size = new System.Drawing.Size(1288, 853);
            ((System.ComponentModel.ISupportInitialize)(this.gct_nv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gct_nv;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button bt_them;
    }
}
