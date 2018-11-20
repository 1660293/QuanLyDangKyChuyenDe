namespace QLCD.Views.TrangChu.Control
{
    partial class MenuGiaoVien
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
            this.btnGiaoVien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGiaoVien
            // 
<<<<<<< HEAD
            this.btnGiaoVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnGiaoVien.Location = new System.Drawing.Point(0, 18);
            this.btnGiaoVien.Name = "btnGiaoVien";
            this.btnGiaoVien.Size = new System.Drawing.Size(126, 48);
            this.btnGiaoVien.TabIndex = 0;
            this.btnGiaoVien.Text = "Giáo Viên";
            this.btnGiaoVien.UseVisualStyleBackColor = true;
            this.btnGiaoVien.Click += new System.EventHandler(this.btnGiaoVu_Click);
=======
            this.btnGiaoVu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnGiaoVu.Location = new System.Drawing.Point(0, 18);
            this.btnGiaoVu.Name = "btnGiaoVu";
            this.btnGiaoVu.Size = new System.Drawing.Size(126, 48);
            this.btnGiaoVu.TabIndex = 0;
            this.btnGiaoVu.Text = "Cập Nhật Và Giao Chuyên Đề";
            this.btnGiaoVu.UseVisualStyleBackColor = true;
            this.btnGiaoVu.Click += new System.EventHandler(this.btnGiaoVu_Click);
>>>>>>> update UI
            // 
            // MenuGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.Controls.Add(this.btnGiaoVien);
=======
            this.Controls.Add(this.btnGiaoVu);
>>>>>>> update UI
            this.Name = "MenuGiaoVien";
            this.Size = new System.Drawing.Size(142, 84);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGiaoVien;
    }
}
