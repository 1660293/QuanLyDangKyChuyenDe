namespace QLCD.Views.TrangChu.Control
{
    partial class EditMonHoc
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
            this.btnXoaMonHoc = new System.Windows.Forms.Button();
            this.btnSuaMonHoc = new System.Windows.Forms.Button();
            this.btnThemMonHoc = new System.Windows.Forms.Button();
            this.nudSoChi = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTenChuyenDe = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtTenMonHoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSuaMonHoc = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuaMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông Tin Chuyên Đề Chi Tiết";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnXoaMonHoc);
            this.panel1.Controls.Add(this.btnSuaMonHoc);
            this.panel1.Controls.Add(this.btnThemMonHoc);
            this.panel1.Controls.Add(this.nudSoChi);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbTenChuyenDe);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.txtTenMonHoc);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 100);
            this.panel1.TabIndex = 2;
            // 
            // btnXoaMonHoc
            // 
            this.btnXoaMonHoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoaMonHoc.Location = new System.Drawing.Point(451, 67);
            this.btnXoaMonHoc.Name = "btnXoaMonHoc";
            this.btnXoaMonHoc.Size = new System.Drawing.Size(100, 25);
            this.btnXoaMonHoc.TabIndex = 11;
            this.btnXoaMonHoc.Text = "Xóa";
            this.btnXoaMonHoc.UseVisualStyleBackColor = true;
            // 
            // btnSuaMonHoc
            // 
            this.btnSuaMonHoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSuaMonHoc.Location = new System.Drawing.Point(314, 67);
            this.btnSuaMonHoc.Name = "btnSuaMonHoc";
            this.btnSuaMonHoc.Size = new System.Drawing.Size(100, 25);
            this.btnSuaMonHoc.TabIndex = 10;
            this.btnSuaMonHoc.Text = "Sửa";
            this.btnSuaMonHoc.UseVisualStyleBackColor = true;
            // 
            // btnThemMonHoc
            // 
            this.btnThemMonHoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThemMonHoc.Location = new System.Drawing.Point(156, 68);
            this.btnThemMonHoc.Name = "btnThemMonHoc";
            this.btnThemMonHoc.Size = new System.Drawing.Size(100, 25);
            this.btnThemMonHoc.TabIndex = 9;
            this.btnThemMonHoc.Text = "Thêm";
            this.btnThemMonHoc.UseVisualStyleBackColor = true;
            // 
            // nudSoChi
            // 
            this.nudSoChi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudSoChi.Location = new System.Drawing.Point(462, 39);
            this.nudSoChi.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudSoChi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoChi.Name = "nudSoChi";
            this.nudSoChi.Size = new System.Drawing.Size(120, 20);
            this.nudSoChi.TabIndex = 3;
            this.nudSoChi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số Chỉ:";
            // 
            // cbTenChuyenDe
            // 
            this.cbTenChuyenDe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbTenChuyenDe.FormattingEnabled = true;
            this.cbTenChuyenDe.Location = new System.Drawing.Point(193, 43);
            this.cbTenChuyenDe.Name = "cbTenChuyenDe";
            this.cbTenChuyenDe.Size = new System.Drawing.Size(133, 21);
            this.cbTenChuyenDe.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên chuyên đề:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Location = new System.Drawing.Point(461, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 20);
            this.textBox1.TabIndex = 5;
            // 
            // txtTenMonHoc
            // 
            this.txtTenMonHoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenMonHoc.Location = new System.Drawing.Point(193, 13);
            this.txtTenMonHoc.Name = "txtTenMonHoc";
            this.txtTenMonHoc.Size = new System.Drawing.Size(133, 20);
            this.txtTenMonHoc.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã môn học:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên môn học:";
            // 
            // dgvSuaMonHoc
            // 
            this.dgvSuaMonHoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvSuaMonHoc.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSuaMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuaMonHoc.Location = new System.Drawing.Point(0, 133);
            this.dgvSuaMonHoc.Name = "dgvSuaMonHoc";
            this.dgvSuaMonHoc.Size = new System.Drawing.Size(720, 247);
            this.dgvSuaMonHoc.TabIndex = 3;
            // 
            // EditMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvSuaMonHoc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "EditMonHoc";
            this.Size = new System.Drawing.Size(720, 382);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuaMonHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXoaMonHoc;
        private System.Windows.Forms.Button btnSuaMonHoc;
        private System.Windows.Forms.Button btnThemMonHoc;
        private System.Windows.Forms.NumericUpDown nudSoChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTenChuyenDe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtTenMonHoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvSuaMonHoc;
    }
}
