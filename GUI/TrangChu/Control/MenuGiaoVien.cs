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
    public partial class MenuGiaoVien : UserControl
    {
        private Form formParent;
        
        public MenuGiaoVien(Form form)
        {
            InitializeComponent();
            formParent = form;
        }
        private void btnGiaoVu_Click(object sender, EventArgs e)
        {
            ((QLCD.Views.TrangChu.TrangChu)formParent).pnlChinh.Controls.Clear();
            CapNhatVaGiaoChuyenDe edcd = new CapNhatVaGiaoChuyenDe();
            edcd.Dock = DockStyle.Fill;
            ((QLCD.Views.TrangChu.TrangChu)formParent).pnlChinh.Controls.Add(edcd);
        }
    }
}
