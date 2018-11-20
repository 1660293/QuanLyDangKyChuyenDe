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
            this.pnlChinh.Location = new System.Drawing.Point(1, 107);
            this.pnlChinh.Name = "pnlChinh";
            this.pnlChinh.Size = new System.Drawing.Size(725, 404);
            this.pnlChinh.TabIndex = 2;
            this.pnlChinh.TabStop = true;
            // 
            // spChucNang
            // 
            this.spChucNang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.spChucNang.Location = new System.Drawing.Point(1, 1);
            this.spChucNang.Name = "spChucNang";
            // 
            // spChucNang.Panel2
            // 
            this.spChucNang.Panel2.Controls.Add(this.spcGiaoVuGiaoVien);
            this.spChucNang.Size = new System.Drawing.Size(719, 100);
            this.spChucNang.SplitterDistance = 158;
            this.spChucNang.TabIndex = 3;
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 510);
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
    }
}