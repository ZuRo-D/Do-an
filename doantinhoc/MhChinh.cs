using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doantinhoc
{
    public partial class MhChinh : Form
    {
        public MhChinh()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadForm(new QuanAo());
            ChangeColorMainBtn(btnQuanAo, null);
        }

        private void MhChinh_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Dang Xuat Tai Khoan?!", "Thong Bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                DangNhap a=new DangNhap();
                a.Show();
                this.Hide();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongTin main = new ThongTin();
            main.Show();
        }
        private void LoadForm(object Form)
        {
            if (this.pnlmain.Controls.Count > 0)
            {
                this.pnlmain.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnlmain.Controls.Add(f);
            this.pnlmain.Tag = f;
            f.Show();
        }

        void ChangeColorMainBtn(object sender, EventArgs e)
        {
            foreach (Control c in pnlMenu.Controls)
            {
                c.BackColor = Color.FromArgb(24, 30, 54);
            }
            Control cl = (Control)sender;
            cl.BackColor = Color.Gray;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadForm(new PhuKien());
            ChangeColorMainBtn(btnPhuKien, null);
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            LoadForm(new NhapHang());
            ChangeColorMainBtn(btnNhapHang, null);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            LoadForm(new HoaDon());
            ChangeColorMainBtn(btnHoaDon, null);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoadForm(new LichSu());
            ChangeColorMainBtn(btnLS, null);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MhChinh main = new MhChinh();
            main.Show();
        }
    }
}
