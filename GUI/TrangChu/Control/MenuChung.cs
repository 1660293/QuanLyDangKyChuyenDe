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
    public partial class MenuChung : UserControl
    {
        private Form formParent;
        public MenuChung(Form form)
        {
            InitializeComponent();
            this.formParent = form;
        }
        private void btnTraDiem_Click(object sender, EventArgs e)
        {
            ((QLCD.Views.TrangChu.TrangChu)formParent).pnlChinh.Controls.Clear();
            uc_XemKetQua ucXemKQ = new uc_XemKetQua();
            ucXemKQ.Dock = DockStyle.Fill;
            ((QLCD.Views.TrangChu.TrangChu)formParent).pnlChinh.Controls.Add(ucXemKQ);
        }
    }
}
