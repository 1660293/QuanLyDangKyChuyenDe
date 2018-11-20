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
    public partial class MenuGiaoVu : UserControl
    {
        private Form formParent;
        
        public MenuGiaoVu(Form form)
        {
            InitializeComponent();
            formParent = form;
        }
        private void btnGiaoVu_Click(object sender, EventArgs e)
        {
            ((QLCD.Views.TrangChu.TrangChu)formParent).pnlChinh.Controls.Clear();
            EditChuyenDe edcd = new EditChuyenDe();
            edcd.Dock = DockStyle.Fill;
            ((QLCD.Views.TrangChu.TrangChu)formParent).pnlChinh.Controls.Add(edcd);
        }
    }
}
