﻿using System;
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
    public partial class ThongTin : Form
    {
        public ThongTin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MhChinh a = new MhChinh();
            a.ShowDialog();
            this.Hide();
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            MhChinh main = new MhChinh();
            main.Show();
        }
    }
}
