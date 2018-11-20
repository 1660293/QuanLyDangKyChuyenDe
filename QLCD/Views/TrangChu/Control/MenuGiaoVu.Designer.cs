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
            this.btnGiaoVu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGiaoVu
            // 
            this.btnGiaoVu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnGiaoVu.Location = new System.Drawing.Point(0, 18);
            this.btnGiaoVu.Name = "btnGiaoVu";
            this.btnGiaoVu.Size = new System.Drawing.Size(126, 48);
            this.btnGiaoVu.TabIndex = 0;
            this.btnGiaoVu.Text = "Giáo Vụ";
            this.btnGiaoVu.UseVisualStyleBackColor = true;
            // 
            // MenuGiaoVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnGiaoVu);
            this.Name = "MenuGiaoVu";
            this.Size = new System.Drawing.Size(142, 84);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGiaoVu;
    }
}
