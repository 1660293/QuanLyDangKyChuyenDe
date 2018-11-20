namespace QLCD.Views.TrangChu.Control
{
    partial class ThongTinDangKyChuyenDe
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTenCD = new System.Windows.Forms.ComboBox();
            this.cbMaCD = new System.Windows.Forms.ComboBox();
            this.dgvThongTinDangKyChuyenDe = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinDangKyChuyenDe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông Tin Đăng Ký Chuyên Đề";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbTenCD);
            this.panel1.Controls.Add(this.cbMaCD);
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 76);
            this.panel1.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(321, 46);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên chuyên đề";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã chuyên đề";
            // 
            // cbTenCD
            // 
            this.cbTenCD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbTenCD.FormattingEnabled = true;
            this.cbTenCD.Location = new System.Drawing.Point(458, 14);
            this.cbTenCD.Name = "cbTenCD";
            this.cbTenCD.Size = new System.Drawing.Size(121, 21);
            this.cbTenCD.TabIndex = 1;
            // 
            // cbMaCD
            // 
            this.cbMaCD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbMaCD.FormattingEnabled = true;
            this.cbMaCD.Location = new System.Drawing.Point(209, 14);
            this.cbMaCD.Name = "cbMaCD";
            this.cbMaCD.Size = new System.Drawing.Size(121, 21);
            this.cbMaCD.TabIndex = 0;
            // 
            // dgvThongTinDangKyChuyenDe
            // 
            this.dgvThongTinDangKyChuyenDe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvThongTinDangKyChuyenDe.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvThongTinDangKyChuyenDe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinDangKyChuyenDe.Location = new System.Drawing.Point(3, 114);
            this.dgvThongTinDangKyChuyenDe.Name = "dgvThongTinDangKyChuyenDe";
            this.dgvThongTinDangKyChuyenDe.Size = new System.Drawing.Size(717, 268);
            this.dgvThongTinDangKyChuyenDe.TabIndex = 2;
            this.dgvThongTinDangKyChuyenDe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTinDangKyChuyenDe_CellContentClick);
            // 
            // ThongTinDangKyChuyenDe
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.dgvThongTinDangKyChuyenDe);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "ThongTinDangKyChuyenDe";
            this.Size = new System.Drawing.Size(720, 382);
            this.Load += new System.EventHandler(this.ThongTinDangKyChuyenDe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinDangKyChuyenDe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvThongTinDangKyChuyenDe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTenCD;
        private System.Windows.Forms.ComboBox cbMaCD;
        private System.Windows.Forms.Button btnTimKiem;
    }
}
