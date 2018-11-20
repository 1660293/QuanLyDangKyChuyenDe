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
    public partial class ThongTinDangKyChuyenDe : UserControl
    {
        
        public ThongTinDangKyChuyenDe()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            
            
        }

        private void ThongTinDangKyChuyenDe_Load(object sender, EventArgs e)
        {
            dgvThongTinChuyenDe.ColumnCount = 4;
            dgvThongTinChuyenDe.Columns[0].HeaderText = "Mã Chuyên Đề";
            dgvThongTinChuyenDe.Columns[0].Name = "maCD";
            dgvThongTinChuyenDe.Columns[1].HeaderText = "Tên Chuyên Đề";
            dgvThongTinChuyenDe.Columns[1].Name = "tenCD";
            dgvThongTinChuyenDe.Columns[2].HeaderText = "Sỉ Số Tối Đa";
            dgvThongTinChuyenDe.Columns[2].Name = "siso";
            
            dgvThongTinChuyenDe.Columns[3].HeaderText = "SL Đăng ký";
            dgvThongTinChuyenDe.Columns[3].Name = "slDangKy";

            dgvThongTinChuyenDe.Rows.Add("CD0001", "Thể Thức Ca reo",30,10);
            dgvThongTinChuyenDe.Rows.Add("CD0002", "Nguyên  Lý Xa Gần",35,3);
            dgvThongTinChuyenDe.Rows.Add("CD0003", "Trái Đắng", 33, 24);
            dgvThongTinChuyenDe.Rows.Add("CD0004", "Năng Sói", 32,32);
            dgvThongTinChuyenDe.Rows.Add("CD0005", "Cái Chết Trắng", 29, 28);
            dgvThongTinChuyenDe.Rows.Add("CD0006", "Thế Giới Phẳng", 31, 0);
            //DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            //btn.UseColumnTextForButtonValue = true;
            //btn.HeaderText = "Chi Tiết";
            //btn.Name = "btnChiTiet";
            //btn.Text = "Xem";
            //dgvThongTinChuyenDe.Columns.Add(btn);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // HERE we handler click button chi tiet and trang thai
            int a = dgvThongTinChuyenDe.CurrentRow.Index;
            if(dgvThongTinChuyenDe.Columns[dgvThongTinChuyenDe.CurrentCell.ColumnIndex].Name =="btnChiTiet")
            {
                int index = dgvThongTinChuyenDe.CurrentRow.Index;

                //ChiTietChuyenDe ctcd = new ChiTietChuyenDe(dgvThongTinChuyenDe.Rows[index], dgvThongTinChuyenDe.Co, dgvThongTinChuyenDe.Rows[index].Cells[0], dgvThongTinChuyenDe.Rows[index].Cells[0]);
                //ctcd.Dock = DockStyle.Fill;
                //NhapLieuDialog nld = new NhapLieuDialog(ctcd);
                //nld.ShowDialog();
                

            }
        }
    }
}
