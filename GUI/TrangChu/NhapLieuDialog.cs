﻿using System;
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
    public partial class NhapLieuDialog : Form
    {
        public NhapLieuDialog(UserControl ctl,string name)
        {
            InitializeComponent();
            ctl.Dock = DockStyle.Fill;
            pnlDialog.Controls.Add(ctl);
            this.Text = name;
        }

    }
}
