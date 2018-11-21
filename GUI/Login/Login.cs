using QLCD.Views.TrangChu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCD
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

     

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           if(tbMatKhau.PasswordChar == tbTaiKhoan.PasswordChar)
            {
                tbMatKhau.PasswordChar = '*';
            }
           else
            {
                tbMatKhau.PasswordChar = tbTaiKhoan.PasswordChar;
            }
        }

        private void btnMatKhau_Click(object sender, EventArgs e)
        {
            TrangChu form = new TrangChu(); 
            form.Visible = true;
            form.Show();
            this.Dispose(false);
        }



       

        }
}
