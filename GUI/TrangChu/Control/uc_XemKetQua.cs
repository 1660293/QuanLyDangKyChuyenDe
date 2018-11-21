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
    public partial class uc_XemKetQua : UserControl
    {
        public uc_XemKetQua()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void uc_XemKetQua_Load(object sender, EventArgs e)
        {
            dgvTraCuDiem.ColumnCount = 3;
            dgvTraCuDiem.Columns[0].HeaderText = "Mã sinh viên";
            dgvTraCuDiem.Columns[0].Name = "maSV";
            dgvTraCuDiem.Columns[1].HeaderText = "Mã môn học";
            dgvTraCuDiem.Columns[1].Name = "maMH";
            dgvTraCuDiem.Columns[2].HeaderText = "Điểm";
            dgvTraCuDiem.Columns[2].Name = "Diem";

            dgvTraCuDiem.Rows.Add("1660123", "MH0001", "7");
            dgvTraCuDiem.Rows.Add("1660146", "MH0003", "4");
            dgvTraCuDiem.Rows.Add("1660193", "MH0002", "10");
            dgvTraCuDiem.Rows.Add("1660303", "MH0004", "3");
            dgvTraCuDiem.Rows.Add("1660453", "MH0005", "5");
        }
    }
}
