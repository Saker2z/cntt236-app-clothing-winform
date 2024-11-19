
namespace GUI
{
    partial class UC_Quyen
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
            this.gct_nhom_quyen = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.quyen = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gct_nhom_quyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // gct_nhom_quyen
            // 
            this.gct_nhom_quyen.Location = new System.Drawing.Point(18, 74);
            this.gct_nhom_quyen.MainView = this.gridView1;
            this.gct_nhom_quyen.Name = "gct_nhom_quyen";
            this.gct_nhom_quyen.Size = new System.Drawing.Size(436, 504);
            this.gct_nhom_quyen.TabIndex = 0;
            this.gct_nhom_quyen.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gct_nhom_quyen;
            this.gridView1.Name = "gridView1";
            // 
            // quyen
            // 
            this.quyen.Location = new System.Drawing.Point(460, 56);
            this.quyen.MainView = this.gridView3;
            this.quyen.Name = "quyen";
            this.quyen.Size = new System.Drawing.Size(614, 522);
            this.quyen.TabIndex = 2;
            this.quyen.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.quyen;
            this.gridView3.Name = "gridView3";
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(558, 14);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(103, 36);
            this.bt_save.TabIndex = 3;
            this.bt_save.Text = "Lưu lại";
            this.bt_save.UseVisualStyleBackColor = true;
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(47, 27);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(75, 23);
            this.bt_them.TabIndex = 4;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            // 
            // bt_update
            // 
            this.bt_update.Location = new System.Drawing.Point(140, 27);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(75, 23);
            this.bt_update.TabIndex = 5;
            this.bt_update.Text = "Sửa";
            this.bt_update.UseVisualStyleBackColor = true;
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(246, 27);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(75, 23);
            this.bt_xoa.TabIndex = 6;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            // 
            // UC_Quyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_update);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.quyen);
            this.Controls.Add(this.gct_nhom_quyen);
            this.Name = "UC_Quyen";
            this.Size = new System.Drawing.Size(1126, 649);
            ((System.ComponentModel.ISupportInitialize)(this.gct_nhom_quyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gct_nhom_quyen;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl quyen;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Button bt_xoa;
    }
}
