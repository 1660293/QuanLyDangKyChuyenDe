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
    public partial class EditChuyenDe : UserControl
    {
        public EditChuyenDe()
        {
            InitializeComponent();
        }

        private void EditChuyenDe_Load(object sender, EventArgs e)
        {
            dgvChiTietChuyenDe.ColumnCount = 4;
            dgvChiTietChuyenDe.Columns[0].HeaderText = "Mã Môn Học";
            dgvChiTietChuyenDe.Columns[0].Name = "maMH";
            dgvChiTietChuyenDe.Columns[1].HeaderText = "Tên Môn Học";
            dgvChiTietChuyenDe.Columns[1].Name = "tenCD";
            dgvChiTietChuyenDe.Columns[2].HeaderText = "Sỉ Số Tối Đa";
            dgvChiTietChuyenDe.Columns[2].Name = "siso";

            dgvChiTietChuyenDe.Columns[3].HeaderText = "Trạng Thái";
            dgvChiTietChuyenDe.Columns[3].Name = "trangthai";

            dgvChiTietChuyenDe.Rows.Add("CD0001", "Thể Thức Ca reo", 30, "Đã mở");
            dgvChiTietChuyenDe.Rows.Add("CD0002", "Nguyên  Lý Xa Gần", 35, "Chưa mở");
            dgvChiTietChuyenDe.Rows.Add("CD0003", "Trái Đắng", 33, "Đã mở");
            dgvChiTietChuyenDe.Rows.Add("CD0004", "Năng Sói", 32, "Chưa mở");
            dgvChiTietChuyenDe.Rows.Add("CD0005", "Cái Chết Trắng", 29, "Chưa mở");
            dgvChiTietChuyenDe.Rows.Add("CD0006", "Thế Giới Phẳng", 31, "Đã mở");
            DataGridViewButtonColumn btnCapNhat = new DataGridViewButtonColumn();
            btnCapNhat.UseColumnTextForButtonValue = true;
            btnCapNhat.HeaderText = "Cập Nhật Chuyên Đề";
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Text = "Cập Nhật";
            dgvChiTietChuyenDe.Columns.Add(btnCapNhat);
            DataGridViewButtonColumn btnGiao = new DataGridViewButtonColumn();
            btnGiao.UseColumnTextForButtonValue = true;
            btnGiao.HeaderText = "Giao Chuyên Đề";
            btnGiao.Name = "btnCapNhat";
            btnGiao.Text = "Giao";
            dgvChiTietChuyenDe.Columns.Add(btnGiao);
        }
    }
}
