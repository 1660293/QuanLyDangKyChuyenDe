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
            this.btnTraDiem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTraDiem
            // 
            this.btnTraDiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnTraDiem.Location = new System.Drawing.Point(12, 15);
            this.btnTraDiem.Name = "btnTraDiem";
            this.btnTraDiem.Size = new System.Drawing.Size(126, 48);
            this.btnTraDiem.TabIndex = 1;
            this.btnTraDiem.Text = "Xem Thông Tin Kết Quả Sinh Viên";
            this.btnTraDiem.UseVisualStyleBackColor = true;
            this.btnTraDiem.Click += new System.EventHandler(this.btnTraDiem_Click);
            // 
            // MenuChung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnTraDiem);
            this.Name = "MenuChung";
            this.Size = new System.Drawing.Size(150, 79);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTraDiem;
    }
}
