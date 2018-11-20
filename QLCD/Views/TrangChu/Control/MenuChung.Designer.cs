namespace QLCD.Views.TrangChu.Control
{
    partial class MenuChung
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
            this.btnCapNhatMonHoc = new System.Windows.Forms.Button();
            this.btnXemDSMonHoc = new System.Windows.Forms.Button();
            this.btnXemTTChuyenDe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCapNhatMonHoc
            // 
            this.btnCapNhatMonHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnCapNhatMonHoc.Location = new System.Drawing.Point(380, 17);
            this.btnCapNhatMonHoc.Name = "btnCapNhatMonHoc";
            this.btnCapNhatMonHoc.Size = new System.Drawing.Size(134, 65);
            this.btnCapNhatMonHoc.TabIndex = 5;
            this.btnCapNhatMonHoc.Text = "Làm Gì Đó";
            this.btnCapNhatMonHoc.UseVisualStyleBackColor = true;
            this.btnCapNhatMonHoc.Click += new System.EventHandler(this.btnCapNhatMonHoc_Click);
            // 
            // btnXemDSMonHoc
            // 
            this.btnXemDSMonHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnXemDSMonHoc.Location = new System.Drawing.Point(187, 15);
            this.btnXemDSMonHoc.Name = "btnXemDSMonHoc";
            this.btnXemDSMonHoc.Size = new System.Drawing.Size(139, 65);
            this.btnXemDSMonHoc.TabIndex = 4;
            this.btnXemDSMonHoc.Text = "Xem Danh Sách Môn Học";
            this.btnXemDSMonHoc.UseVisualStyleBackColor = true;
            this.btnXemDSMonHoc.Click += new System.EventHandler(this.btnXemDSMonHoc_Click);
            // 
            // btnXemTTChuyenDe
            // 
            this.btnXemTTChuyenDe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnXemTTChuyenDe.Location = new System.Drawing.Point(25, 16);
            this.btnXemTTChuyenDe.Name = "btnXemTTChuyenDe";
            this.btnXemTTChuyenDe.Size = new System.Drawing.Size(117, 65);
            this.btnXemTTChuyenDe.TabIndex = 3;
            this.btnXemTTChuyenDe.Text = "Xem Thông Tin Chuyên Đề";
            this.btnXemTTChuyenDe.UseVisualStyleBackColor = true;
            this.btnXemTTChuyenDe.Click += new System.EventHandler(this.btnXemTTChuyenDe_Click);
            // 
            // MenuChung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.Controls.Add(this.btnCapNhatMonHoc);
            this.Controls.Add(this.btnXemDSMonHoc);
            this.Controls.Add(this.btnXemTTChuyenDe);
            this.Name = "MenuChung";
            this.Size = new System.Drawing.Size(558, 100);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCapNhatMonHoc;
        private System.Windows.Forms.Button btnXemDSMonHoc;
        private System.Windows.Forms.Button btnXemTTChuyenDe;
    }
}
