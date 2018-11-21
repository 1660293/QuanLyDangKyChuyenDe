namespace QLCD.Views.TrangChu.Control
{
    partial class MenuGiaoVu
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
            this.btnThongTinChuyenDe = new System.Windows.Forms.Button();
            this.btnXemDSChuyenDe = new System.Windows.Forms.Button();
            this.btnXemTTDKChuyenDe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnThongTinChuyenDe
            // 
            this.btnThongTinChuyenDe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnThongTinChuyenDe.Location = new System.Drawing.Point(380, 17);
            this.btnThongTinChuyenDe.Name = "btnThongTinChuyenDe";
            this.btnThongTinChuyenDe.Size = new System.Drawing.Size(134, 65);
            this.btnThongTinChuyenDe.TabIndex = 5;
            this.btnThongTinChuyenDe.Text = "Xem Thông Tin Chuyên Đề";
            this.btnThongTinChuyenDe.UseVisualStyleBackColor = true;
            this.btnThongTinChuyenDe.Click += new System.EventHandler(this.btnXemTTChuyenDe_Click);
            // 
            // btnXemDSChuyenDe
            // 
            this.btnXemDSChuyenDe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnXemDSChuyenDe.Location = new System.Drawing.Point(187, 15);
            this.btnXemDSChuyenDe.Name = "btnXemDSChuyenDe";
            this.btnXemDSChuyenDe.Size = new System.Drawing.Size(139, 65);
            this.btnXemDSChuyenDe.TabIndex = 4;
            this.btnXemDSChuyenDe.Text = "Xem Danh Sách Chuyên Đề";
            this.btnXemDSChuyenDe.UseVisualStyleBackColor = true;
            this.btnXemDSChuyenDe.Click += new System.EventHandler(this.btnXemDSChuyenDe_Click);
            // 
            // btnXemTTDKChuyenDe
            // 
            this.btnXemTTDKChuyenDe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnXemTTDKChuyenDe.Location = new System.Drawing.Point(25, 16);
            this.btnXemTTDKChuyenDe.Name = "btnXemTTDKChuyenDe";
            this.btnXemTTDKChuyenDe.Size = new System.Drawing.Size(117, 65);
            this.btnXemTTDKChuyenDe.TabIndex = 3;
            this.btnXemTTDKChuyenDe.Text = "Xem Thông Tin Đăng ký Chuyên Đề";
            this.btnXemTTDKChuyenDe.UseVisualStyleBackColor = true;
            this.btnXemTTDKChuyenDe.Click += new System.EventHandler(this.btnXemTTDKChuyenDe_Click);
            // 
            // MenuGiaoVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.Controls.Add(this.btnThongTinChuyenDe);
            this.Controls.Add(this.btnXemDSChuyenDe);
            this.Controls.Add(this.btnXemTTDKChuyenDe);
            this.Name = "MenuGiaoVu";
            this.Size = new System.Drawing.Size(558, 100);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThongTinChuyenDe;
        private System.Windows.Forms.Button btnXemDSChuyenDe;
        private System.Windows.Forms.Button btnXemTTDKChuyenDe;
    }
}
