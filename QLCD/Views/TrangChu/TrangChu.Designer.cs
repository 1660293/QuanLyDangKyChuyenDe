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
            this.spcChucNang = new System.Windows.Forms.SplitContainer();
            this.pnlChinh = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.spcChucNang)).BeginInit();
            this.spcChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // spcChucNang
            // 
            this.spcChucNang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.spcChucNang.IsSplitterFixed = true;
            this.spcChucNang.Location = new System.Drawing.Point(0, 1);
            this.spcChucNang.Name = "spcChucNang";
            // 
            // spcChucNang.Panel1
            // 
            this.spcChucNang.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.spcChucNang.Panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.spcChucNang.Size = new System.Drawing.Size(713, 100);
            this.spcChucNang.SplitterDistance = 535;
            this.spcChucNang.TabIndex = 0;
            // 
            // pnlChinh
            // 
            this.pnlChinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlChinh.AutoSize = true;
            this.pnlChinh.BackColor = System.Drawing.SystemColors.Control;
            this.pnlChinh.Location = new System.Drawing.Point(0, 107);
            this.pnlChinh.Name = "pnlChinh";
            this.pnlChinh.Size = new System.Drawing.Size(713, 341);
            this.pnlChinh.TabIndex = 2;
            this.pnlChinh.TabStop = true;
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 447);
            this.Controls.Add(this.pnlChinh);
            this.Controls.Add(this.spcChucNang);
            this.Name = "TrangChu";
            this.Text = "Xem Thông Tin Đăng Ký Chuyên Đề";
            ((System.ComponentModel.ISupportInitialize)(this.spcChucNang)).EndInit();
            this.spcChucNang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer spcChucNang;
        public System.Windows.Forms.Panel pnlChinh;
    }
}