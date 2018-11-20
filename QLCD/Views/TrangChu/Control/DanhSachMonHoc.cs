using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCD.Views.TrangChu.Control
{
    public partial class DanhSachMonHoc : UserControl
    {
        public DanhSachMonHoc()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void cbVoHieuHoa_CheckedChanged(object sender, EventArgs e)
        {
            if(cbVoHieuHoa.Checked == false)
            {
                cbChuaVoHieuHoa.Enabled = true;
            }
            else
            {
                cbChuaVoHieuHoa.Enabled = false;
            }
        }

        private void cbChuaVoHieuHoa_CheckedChanged(object sender, EventArgs e)
        {
            if (cbChuaVoHieuHoa.Checked ==false)
            {
                cbVoHieuHoa.Enabled = true;
            }
            else
            {
                cbVoHieuHoa.Enabled = false;
            }
        }

        private void btnSearchMonHoc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("jdashfkjlasdhfjkl");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DanhSachMonHoc_Load(object sender, EventArgs e)
        {
            dgvDanhSachMonHoc.ColumnCount = 4;
            dgvDanhSachMonHoc.Columns[0].HeaderText = "Mã Môn Học";
            dgvDanhSachMonHoc.Columns[0].Name = "maMH";
            dgvDanhSachMonHoc.Columns[1].HeaderText = "Tên Môn Học";
            dgvDanhSachMonHoc.Columns[1].Name = "tenCD";
            dgvDanhSachMonHoc.Columns[2].HeaderText = "Sỉ Số Tối Đa";
            dgvDanhSachMonHoc.Columns[2].Name = "siso";

            dgvDanhSachMonHoc.Columns[3].HeaderText = "Trạng Thái";
            dgvDanhSachMonHoc.Columns[3].Name = "trangthai";

            dgvDanhSachMonHoc.Rows.Add("CD0001", "Thể Thức Ca reo", 30, "Đã mở");
            dgvDanhSachMonHoc.Rows.Add("CD0002", "Nguyên  Lý Xa Gần", 35, "Chưa mở");
            dgvDanhSachMonHoc.Rows.Add("CD0003", "Trái Đắng", 33, "Đã mở");
            dgvDanhSachMonHoc.Rows.Add("CD0004", "Năng Sói", 32, "Chưa mở");
            dgvDanhSachMonHoc.Rows.Add("CD0005", "Cái Chết Trắng", 29, "Chưa mở");
            dgvDanhSachMonHoc.Rows.Add("CD0006", "Thế Giới Phẳng", 31, "Đã mở");
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.UseColumnTextForButtonValue = true;
            btn.HeaderText = "Chi Tiết";
            btn.Name = "btnChiTiet";
            btn.Text = "Xem";
            dgvDanhSachMonHoc.Columns.Add(btn);
        }
    }
}
