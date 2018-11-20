namespace QLCD.Views.TrangChu.Control
{
    partial class HuyVoHieuHoa
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
            this.btnQuayVe = new System.Windows.Forms.Button();
            this.btnVoHieuHoa = new System.Windows.Forms.Button();
            this.lbTenCD = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnQuayVe
            // 
            this.btnQuayVe.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnQuayVe.Location = new System.Drawing.Point(127, 100);
            this.btnQuayVe.Name = "btnQuayVe";
            this.btnQuayVe.Size = new System.Drawing.Size(75, 23);
            this.btnQuayVe.TabIndex = 9;
            this.btnQuayVe.Text = "Quay Về";
            this.btnQuayVe.UseVisualStyleBackColor = true;
            // 
            // btnVoHieuHoa
            // 
            this.btnVoHieuHoa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnVoHieuHoa.Location = new System.Drawing.Point(21, 100);
            this.btnVoHieuHoa.Name = "btnVoHieuHoa";
            this.btnVoHieuHoa.Size = new System.Drawing.Size(75, 23);
            this.btnVoHieuHoa.TabIndex = 8;
            this.btnVoHieuHoa.Text = "Hủy Vô Hiệu Hóa";
            this.btnVoHieuHoa.UseVisualStyleBackColor = true;
            // 
            // lbTenCD
            // 
            this.lbTenCD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTenCD.AutoSize = true;
            this.lbTenCD.Location = new System.Drawing.Point(110, 70);
            this.lbTenCD.Name = "lbTenCD";
            this.lbTenCD.Size = new System.Drawing.Size(88, 13);
            this.lbTenCD.TabIndex = 7;
            this.lbTenCD.Text = "Thể Thức Ca reo";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên chuyên đề: ";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vô Hiệu Hóa Môn Học";
            // 
            // HuyVoHieuHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnQuayVe);
            this.Controls.Add(this.btnVoHieuHoa);
            this.Controls.Add(this.lbTenCD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HuyVoHieuHoa";
            this.Size = new System.Drawing.Size(207, 143);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuayVe;
        private System.Windows.Forms.Button btnVoHieuHoa;
        private System.Windows.Forms.Label lbTenCD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
