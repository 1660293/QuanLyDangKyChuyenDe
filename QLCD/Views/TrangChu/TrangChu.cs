using QLCD.Views.TrangChu.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCD.Views.TrangChu
{
    public partial class TrangChu : Form
    {
        
        public TrangChu()
        {
            InitializeComponent();
            MenuGiaoVu menuGiaoVu = new MenuGiaoVu(this);
            menuGiaoVu.Dock = DockStyle.Fill;
            MenuGiaoVien menuGiaoVien = new MenuGiaoVien(this);
            menuGiaoVien.Dock = DockStyle.Fill;
            spcGiaoVuGiaoVien.Panel1.Controls.Add(menuGiaoVu);
            spcGiaoVuGiaoVien.Panel2.Controls.Add(menuGiaoVien);
            MenuChung menuChung = new Control.MenuChung(this);
            menuChung.Dock = DockStyle.Fill;
            spChucNang.Panel1.Controls.Add(menuChung);
        }

        private void spcChucNang_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
