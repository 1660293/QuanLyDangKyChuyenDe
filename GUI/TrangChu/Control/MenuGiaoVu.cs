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
    public partial class MenuGiaoVu : UserControl, IDisposable
    {
        private Form formParent;
        public MenuGiaoVu()
        {

            int x = 5;

            InitializeComponent();
        }
        public MenuGiaoVu(Form form)
        {
            InitializeComponent();
            formParent = form;
        }



        private void btnXemTTDKChuyenDe_Click(object sender, EventArgs e)
        {

            ((QLCD.Views.TrangChu.TrangChu)formParent).pnlChinh.Controls.Clear();
            ThongTinDangKyChuyenDe ttcd = new ThongTinDangKyChuyenDe();
            ttcd.Dock = DockStyle.Fill;
            ((QLCD.Views.TrangChu.TrangChu)formParent).pnlChinh.Controls.Add(ttcd);
           
        }

      

        private void btnXemTTChuyenDe_Click(object sender, EventArgs e)
        {
            
            ((QLCD.Views.TrangChu.TrangChu)formParent).pnlChinh.Controls.Clear();
            EditMonHoc edmh = new EditMonHoc();
            edmh.Dock = DockStyle.Fill;
            ((QLCD.Views.TrangChu.TrangChu)formParent).pnlChinh.Controls.Add(edmh);
        }

        private void btnXemDSChuyenDe_Click(object sender, EventArgs e)
        {
            ((QLCD.Views.TrangChu.TrangChu)formParent).pnlChinh.Controls.Clear();
            DanhSachMonHoc dsmh = new DanhSachMonHoc();
            dsmh.Dock = DockStyle.Fill;
            ((QLCD.Views.TrangChu.TrangChu)formParent).pnlChinh.Controls.Add(new DanhSachMonHoc());

        }
    }
}
