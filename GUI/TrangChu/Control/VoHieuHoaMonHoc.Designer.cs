namespace QLCD.Views.TrangChu.Control
{
    partial class VoHieuHoaMonHoc
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTenCD = new System.Windows.Forms.Label();
            this.btnVoHieuHoa = new System.Windows.Forms.Button();
            this.btnQuayVe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vô Hiệu Hóa Môn Học";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên chuyên đề: ";
            // 
            // lbTenCD
            // 
            this.lbTenCD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTenCD.AutoSize = true;
            this.lbTenCD.Location = new System.Drawing.Point(109, 62);
            this.lbTenCD.Name = "lbTenCD";
            this.lbTenCD.Size = new System.Drawing.Size(88, 13);
            this.lbTenCD.TabIndex = 2;
            this.lbTenCD.Text = "Thể Thức Ca reo";
            // 
            // btnVoHieuHoa
            // 
            this.btnVoHieuHoa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnVoHieuHoa.Location = new System.Drawing.Point(20, 99);
            this.btnVoHieuHoa.Name = "btnVoHieuHoa";
            this.btnVoHieuHoa.Size = new System.Drawing.Size(75, 23);
            this.btnVoHieuHoa.TabIndex = 3;
            this.btnVoHieuHoa.Text = "Vô hiệu hóa";
            this.btnVoHieuHoa.UseVisualStyleBackColor = true;
            // 
            // btnQuayVe
            // 
            this.btnQuayVe.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnQuayVe.Location = new System.Drawing.Point(126, 99);
            this.btnQuayVe.Name = "btnQuayVe";
            this.btnQuayVe.Size = new System.Drawing.Size(75, 23);
            this.btnQuayVe.TabIndex = 4;
            this.btnQuayVe.Text = "Quay Về";
            this.btnQuayVe.UseVisualStyleBackColor = true;
            // 
            // VoHieuHoaMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnQuayVe);
            this.Controls.Add(this.btnVoHieuHoa);
            this.Controls.Add(this.lbTenCD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VoHieuHoaMonHoc";
            this.Size = new System.Drawing.Size(227, 136);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTenCD;
        private System.Windows.Forms.Button btnVoHieuHoa;
        private System.Windows.Forms.Button btnQuayVe;
    }
}
