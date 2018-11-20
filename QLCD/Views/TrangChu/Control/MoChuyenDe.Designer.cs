namespace QLCD.Views.TrangChu.Control
{
    partial class MoChuyenDe
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
            this.btnMoChuyenDe = new System.Windows.Forms.Button();
            this.btnQuayVe = new System.Windows.Forms.Button();
            this.lbTenCD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông Tin Chuyên Đề";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên chuyên đề:";
            // 
            // btnMoChuyenDe
            // 
            this.btnMoChuyenDe.Location = new System.Drawing.Point(11, 69);
            this.btnMoChuyenDe.Name = "btnMoChuyenDe";
            this.btnMoChuyenDe.Size = new System.Drawing.Size(75, 23);
            this.btnMoChuyenDe.TabIndex = 2;
            this.btnMoChuyenDe.Text = "Mở";
            this.btnMoChuyenDe.UseVisualStyleBackColor = true;
            // 
            // btnQuayVe
            // 
            this.btnQuayVe.Location = new System.Drawing.Point(106, 69);
            this.btnQuayVe.Name = "btnQuayVe";
            this.btnQuayVe.Size = new System.Drawing.Size(75, 23);
            this.btnQuayVe.TabIndex = 3;
            this.btnQuayVe.Text = "Quay Về";
            this.btnQuayVe.UseVisualStyleBackColor = true;
            // 
            // lbTenCD
            // 
            this.lbTenCD.AutoSize = true;
            this.lbTenCD.Location = new System.Drawing.Point(98, 39);
            this.lbTenCD.Name = "lbTenCD";
            this.lbTenCD.Size = new System.Drawing.Size(88, 13);
            this.lbTenCD.TabIndex = 4;
            this.lbTenCD.Text = "Thể Thức Ca reo";
            // 
            // MoChuyenDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbTenCD);
            this.Controls.Add(this.btnQuayVe);
            this.Controls.Add(this.btnMoChuyenDe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MoChuyenDe";
            this.Size = new System.Drawing.Size(197, 95);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMoChuyenDe;
        private System.Windows.Forms.Button btnQuayVe;
        private System.Windows.Forms.Label lbTenCD;
    }
}
