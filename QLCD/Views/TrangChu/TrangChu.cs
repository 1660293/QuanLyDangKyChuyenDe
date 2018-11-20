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
            MenuChung menuChung = new MenuChung(this);
            menuChung.Dock = DockStyle.Fill;
            MenuGiaoVu menuGiaoVu = new MenuGiaoVu();
            menuGiaoVu.Dock = DockStyle.Fill;
            spcChucNang.Panel1.Controls.Add(menuChung);
            spcChucNang.Panel2.Controls.Add(menuGiaoVu);

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
