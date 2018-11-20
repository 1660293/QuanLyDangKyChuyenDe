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
            string[] maCD = { "CD0001", "CD0002", "CD0003", "CD0004", "CD0005", "CD0006" };
            string[] tenCD = { "Thể Thức Cá Heo", "Nguyên  Lý Xa Gần", "Trái Đắng", "Năng Sói", "Cái Chết Trắng", "Thế Giới Phẳng" };
            foreach(string i in maCD)
            {
                cbMaCD.Items.Add(i);
            }
            foreach (string i in tenCD)
            {
                cbTenCD.Items.Add(i);
            }
            
        }

        private void ThongTinDangKyChuyenDe_Load(object sender, EventArgs e)
        {
            dgvThongTinDangKyChuyenDe.ColumnCount = 2;
            dgvThongTinDangKyChuyenDe.Columns[0].HeaderText = "Mã Chuyên Đề";
            dgvThongTinDangKyChuyenDe.Columns[0].Name = "maCD";
            dgvThongTinDangKyChuyenDe.Columns[1].HeaderText = "Tên Chuyên Đề";
            dgvThongTinDangKyChuyenDe.Columns[1].Name = "tenCD";
            

            
            dgvThongTinDangKyChuyenDe.Rows.Add("CD0001", "Thể Thức Ca reo");
            dgvThongTinDangKyChuyenDe.Rows.Add("CD0002", "Nguyên  Lý Xa Gần");
            dgvThongTinDangKyChuyenDe.Rows.Add("CD0003", "Trái Đắng");
            dgvThongTinDangKyChuyenDe.Rows.Add("CD0004", "Năng Sói");
            dgvThongTinDangKyChuyenDe.Rows.Add("CD0005", "Cái Chết Trắng");
            dgvThongTinDangKyChuyenDe.Rows.Add("CD0006", "Thế Giới Phẳng");
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.UseColumnTextForButtonValue = true;
            btn.HeaderText = "Chi Tiết";
            btn.Name = "btnChiTiet";
            btn.Text = "Xem";
            dgvThongTinDangKyChuyenDe.Columns.Add(btn);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //HERE we handler click button chi tiet and trang thai

            
        }

        private void dgvThongTinDangKyChuyenDe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dgvThongTinDangKyChuyenDe.Columns[dgvThongTinDangKyChuyenDe.CurrentCell.ColumnIndex].Name == "btnChiTiet")
            {
                int index = dgvThongTinDangKyChuyenDe.CurrentRow.Index;

                ChiTietChuyenDe ctcd = new ChiTietChuyenDe("CD0001", "Thể Thức Ca reo", "30");
                
                ctcd.Dock = DockStyle.Fill;
                NhapLieuDialog nld = new NhapLieuDialog(ctcd,"Chi Tiết Chuyên Đề");
                nld.Size = ctcd.Size;
                nld.ShowDialog();


            }
        }
    }
}
