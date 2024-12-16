using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doantinhoc
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
            txtpass.PasswordChar = '*';
            chkpass.Click += checkBox1_CheckedChanged;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (txtpass.PasswordChar == '*') 
            {
                txtpass.PasswordChar = '\0';
            }
            else
            {
                txtpass.PasswordChar = '*';
            }
        }

        private void txtadmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string usr=txtadmin.Text.Trim();
            string pwd=txtpass.Text;
            if (taikhoan(usr, pwd))
            {
                this.Hide();
                MhChinh main = new MhChinh();
                main.Show();
            }
            else 
            {
                MessageBox.Show("Nhap lai mat khau hoac ten nguoi dung!", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private bool taikhoan(string usr, string pwd)
        {
            string a = "tduongg";
            string b = "12345";
            return usr==a && pwd==b;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
