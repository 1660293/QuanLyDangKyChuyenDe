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
    public partial class MenuChung : UserControl, IDisposable
    {
        private Form formParent;
        public MenuChung()
        {

            int x = 5;

            InitializeComponent();
        }
        public MenuChung(Form form)
        {
            InitializeComponent();
            formParent = form;
        }



        private void btnXemTTChuyenDe_Click(object sender, EventArgs e)
        {
            ((QLCD.Views.TrangChu.TrangChu)formParent).pnlChinh.Controls.Clear();
            ((QLCD.Views.TrangChu.TrangChu)formParent).pnlChinh.Controls.Add(new DanhSachMonHoc());
        }

        private void btnXemDSMonHoc_Click(object sender, EventArgs e)
        {
            ((QLCD.Views.TrangChu.TrangChu)formParent).pnlChinh.Controls.Clear();
            ((QLCD.Views.TrangChu.TrangChu)formParent).pnlChinh.Controls.Add(new DanhSachMonHoc());
        }

        private void btnCapNhatMonHoc_Click(object sender, EventArgs e)
        {
            ((QLCD.Views.TrangChu.TrangChu)formParent).pnlChinh.Controls.Clear();
            ((QLCD.Views.TrangChu.TrangChu)formParent).pnlChinh.Controls.Add(new DanhSachMonHoc());
        }
    }
}