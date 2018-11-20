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
    public partial class DanhSachMonHoc : UserControl
    {
        public DanhSachMonHoc()
        {
            InitializeComponent();
        }

        private void cbVoHieuHoa_CheckedChanged(object sender, EventArgs e)
        {
            if(cbVoHieuHoa.Checked == false)
            {
                cbChuaVoHieuHoa.Enabled = true;
            }
            else
            {
                cbChuaVoHieuHoa.Enabled = false;
            }
        }

        private void cbChuaVoHieuHoa_CheckedChanged(object sender, EventArgs e)
        {
            if (cbChuaVoHieuHoa.Checked ==false)
            {
                cbVoHieuHoa.Enabled = true;
            }
            else
            {
                cbVoHieuHoa.Enabled = false;
            }
        }
    }
}
