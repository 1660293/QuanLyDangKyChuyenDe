namespace QLCD.Views.TrangChu.Control
{
    partial class DanhSachMonHoc
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
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.pnlNhapDSMH = new System.Windows.Forms.Panel();
            this.btnResetSeachMH = new System.Windows.Forms.Button();
            this.btnSearchMonHoc = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbChuaVoHieuHoa = new System.Windows.Forms.CheckBox();
            this.cbVoHieuHoa = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDanhSachMonHoc = new System.Windows.Forms.DataGridView();
            this.pnlNhapDSMH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Chuyên Đề";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên môn học:";
            // 
            // txtTenMH
            // 
            this.txtTenMH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenMH.Location = new System.Drawing.Point(142, 10);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(124, 20);
            this.txtTenMH.TabIndex = 2;
            // 
            // pnlNhapDSMH
            // 
            this.pnlNhapDSMH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlNhapDSMH.BackColor = System.Drawing.SystemColors.Control;
            this.pnlNhapDSMH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlNhapDSMH.Controls.Add(this.btnResetSeachMH);
            this.pnlNhapDSMH.Controls.Add(this.btnSearchMonHoc);
            this.pnlNhapDSMH.Controls.Add(this.textBox2);
            this.pnlNhapDSMH.Controls.Add(this.label4);
            this.pnlNhapDSMH.Controls.Add(this.cbChuaVoHieuHoa);
            this.pnlNhapDSMH.Controls.Add(this.cbVoHieuHoa);
            this.pnlNhapDSMH.Controls.Add(this.textBox1);
            this.pnlNhapDSMH.Controls.Add(this.label3);
            this.pnlNhapDSMH.Controls.Add(this.label2);
            this.pnlNhapDSMH.Controls.Add(this.txtTenMH);
            this.pnlNhapDSMH.Location = new System.Drawing.Point(0, 26);
            this.pnlNhapDSMH.Name = "pnlNhapDSMH";
            this.pnlNhapDSMH.Size = new System.Drawing.Size(720, 113);
            this.pnlNhapDSMH.TabIndex = 3;
            // 
            // btnResetSeachMH
            // 
            this.btnResetSeachMH.Location = new System.Drawing.Point(400, 87);
            this.btnResetSeachMH.Name = "btnResetSeachMH";
            this.btnResetSeachMH.Size = new System.Drawing.Size(91, 23);
            this.btnResetSeachMH.TabIndex = 10;
            this.btnResetSeachMH.Text = "Hủy Điều Kiện";
            this.btnResetSeachMH.UseVisualStyleBackColor = true;
            // 
            // btnSearchMonHoc
            // 
            this.btnSearchMonHoc.Location = new System.Drawing.Point(193, 87);
            this.btnSearchMonHoc.Name = "btnSearchMonHoc";
            this.btnSearchMonHoc.Size = new System.Drawing.Size(99, 23);
            this.btnSearchMonHoc.TabIndex = 9;
            this.btnSearchMonHoc.Text = "Tìm Kiếm";
            this.btnSearchMonHoc.UseVisualStyleBackColor = true;
            this.btnSearchMonHoc.Click += new System.EventHandler(this.btnSearchMonHoc_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(472, 10);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(116, 20);
            this.textBox2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(408, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // cbChuaVoHieuHoa
            // 
            this.cbChuaVoHieuHoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbChuaVoHieuHoa.AutoSize = true;
            this.cbChuaVoHieuHoa.Location = new System.Drawing.Point(409, 69);
            this.cbChuaVoHieuHoa.Name = "cbChuaVoHieuHoa";
            this.cbChuaVoHieuHoa.Size = new System.Drawing.Size(99, 17);
            this.cbChuaVoHieuHoa.TabIndex = 6;
            this.cbChuaVoHieuHoa.Text = "Đã vô hiệu hóa";
            this.cbChuaVoHieuHoa.UseVisualStyleBackColor = true;
            this.cbChuaVoHieuHoa.CheckedChanged += new System.EventHandler(this.cbChuaVoHieuHoa_CheckedChanged);
            // 
            // cbVoHieuHoa
            // 
            this.cbVoHieuHoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbVoHieuHoa.AutoSize = true;
            this.cbVoHieuHoa.Location = new System.Drawing.Point(186, 69);
            this.cbVoHieuHoa.Name = "cbVoHieuHoa";
            this.cbVoHieuHoa.Size = new System.Drawing.Size(95, 17);
            this.cbVoHieuHoa.TabIndex = 5;
            this.cbVoHieuHoa.Text = "Chưa hiệu hóa";
            this.cbVoHieuHoa.UseVisualStyleBackColor = true;
            this.cbVoHieuHoa.CheckedChanged += new System.EventHandler(this.cbVoHieuHoa_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Location = new System.Drawing.Point(142, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã môn học:";
            // 
            // dgvDanhSachMonHoc
            // 
            this.dgvDanhSachMonHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvDanhSachMonHoc.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDanhSachMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachMonHoc.Location = new System.Drawing.Point(0, 145);
            this.dgvDanhSachMonHoc.Name = "dgvDanhSachMonHoc";
            this.dgvDanhSachMonHoc.Size = new System.Drawing.Size(720, 234);
            this.dgvDanhSachMonHoc.TabIndex = 4;
            this.dgvDanhSachMonHoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DanhSachMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.dgvDanhSachMonHoc);
            this.Controls.Add(this.pnlNhapDSMH);
            this.Controls.Add(this.label1);
            this.Name = "DanhSachMonHoc";
            this.Size = new System.Drawing.Size(720, 382);
            this.Load += new System.EventHandler(this.DanhSachMonHoc_Load);
            this.pnlNhapDSMH.ResumeLayout(false);
            this.pnlNhapDSMH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMonHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.Panel pnlNhapDSMH;
        private System.Windows.Forms.CheckBox cbChuaVoHieuHoa;
        private System.Windows.Forms.CheckBox cbVoHieuHoa;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnResetSeachMH;
        private System.Windows.Forms.Button btnSearchMonHoc;
        private System.Windows.Forms.DataGridView dgvDanhSachMonHoc;
    }
}
