﻿using System;
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

            //((TrangChu)formParent).pnlChinh.Controls.Add()
        }
    }
}
