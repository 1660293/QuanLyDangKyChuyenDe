namespace QLCD.Views.TrangChu
{
    partial class NhapLieuDialog
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
            this.pnlDialog = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlDialog
            // 
            this.pnlDialog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDialog.Location = new System.Drawing.Point(0, 0);
            this.pnlDialog.Name = "pnlDialog";
            this.pnlDialog.Size = new System.Drawing.Size(284, 150);
            this.pnlDialog.TabIndex = 0;
            // 
            // NhapLieuDialog
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(284, 150);
            this.Controls.Add(this.pnlDialog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NhapLieuDialog";
            this.Text = "a";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDialog;
    }
}