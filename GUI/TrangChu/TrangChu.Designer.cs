namespace QLCD.Views.TrangChu
{
    partial class TrangChu
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
            this.spcGiaoVuGiaoVien = new System.Windows.Forms.SplitContainer();
            this.pnlChinh = new System.Windows.Forms.Panel();
            this.spChucNang = new System.Windows.Forms.SplitContainer();
            this.lbPhanHe = new System.Windows.Forms.Label();
            this.btnDangXuat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spcGiaoVuGiaoVien)).BeginInit();
            this.spcGiaoVuGiaoVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spChucNang)).BeginInit();
            this.spChucNang.Panel2.SuspendLayout();
            this.spChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // spcGiaoVuGiaoVien
            // 
            this.spcGiaoVuGiaoVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcGiaoVuGiaoVien.Location = new System.Drawing.Point(0, 0);
            this.spcGiaoVuGiaoVien.Name = "spcGiaoVuGiaoVien";
            // 
            // spcGiaoVuGiaoVien.Panel1
            // 
            this.spcGiaoVuGiaoVien.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.spcGiaoVuGiaoVien.Panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            // 
            // spcGiaoVuGiaoVien.Panel2
            // 
            this.spcGiaoVuGiaoVien.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.spcChucNang_Panel2_Paint);
            this.spcGiaoVuGiaoVien.Size = new System.Drawing.Size(557, 100);
            this.spcGiaoVuGiaoVien.SplitterDistance = 417;
            this.spcGiaoVuGiaoVien.TabIndex = 0;
            // 
            // pnlChinh
            // 
            this.pnlChinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlChinh.AutoSize = true;
            this.pnlChinh.BackColor = System.Drawing.SystemColors.Control;
            this.pnlChinh.BackgroundImage = global::QLCD.Properties.Resources.DefaultPhanHe;
            this.pnlChinh.Location = new System.Drawing.Point(1, 142);
            this.pnlChinh.Name = "pnlChinh";
            this.pnlChinh.Size = new System.Drawing.Size(725, 434);
            this.pnlChinh.TabIndex = 2;
            this.pnlChinh.TabStop = true;
            // 
            // spChucNang
            // 
            this.spChucNang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.spChucNang.Location = new System.Drawing.Point(1, 36);
            this.spChucNang.Name = "spChucNang";
            // 
            // spChucNang.Panel2
            // 
            this.spChucNang.Panel2.Controls.Add(this.spcGiaoVuGiaoVien);
            this.spChucNang.Size = new System.Drawing.Size(719, 100);
            this.spChucNang.SplitterDistance = 158;
            this.spChucNang.TabIndex = 3;
            // 
            // lbPhanHe
            // 
            this.lbPhanHe.AutoSize = true;
            this.lbPhanHe.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhanHe.Location = new System.Drawing.Point(13, 13);
            this.lbPhanHe.Name = "lbPhanHe";
            this.lbPhanHe.Size = new System.Drawing.Size(87, 19);
            this.lbPhanHe.TabIndex = 4;
            this.lbPhanHe.Text = "Giáo Viên";
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Location = new System.Drawing.Point(637, 8);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(75, 23);
            this.btnDangXuat.TabIndex = 5;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 575);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.lbPhanHe);
            this.Controls.Add(this.spChucNang);
            this.Controls.Add(this.pnlChinh);
            this.Name = "TrangChu";
            this.Text = "Xem Thông Tin Đăng Ký Chuyên Đề";
            this.Load += new System.EventHandler(this.TrangChu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spcGiaoVuGiaoVien)).EndInit();
            this.spcGiaoVuGiaoVien.ResumeLayout(false);
            this.spChucNang.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spChucNang)).EndInit();
            this.spChucNang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer spcGiaoVuGiaoVien;
        public System.Windows.Forms.Panel pnlChinh;
        private System.Windows.Forms.SplitContainer spChucNang;
        private System.Windows.Forms.Label lbPhanHe;
        private System.Windows.Forms.Button btnDangXuat;
    }
}