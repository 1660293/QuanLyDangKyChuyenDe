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
    public partial class ChiTietChuyenDe : UserControl
    {

        public ChiTietChuyenDe(string macd,string tencd,string sisotoida)
        {
            InitializeComponent();
            lbTenCD.Text = lbTenCD1.Text = tencd;
            lbMaCD.Text = macd;
            lbSiSoCD.Text = sisotoida;
            lbSoNguoiDK.Text = "14";
        }

      
    }
}
