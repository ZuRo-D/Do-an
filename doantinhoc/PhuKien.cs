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
    public partial class PhuKien : Form
    {
        public static PhuKien Instance { get; private set; }
        public PhuKien()
        {
            InitializeComponent();
            Instance = this;
        }

        //public void ThemSanPham(HangHoa sp)
        //{
        //    ListViewItem item = new ListViewItem(new[]
        //    {
        //    sp.MaHang, sp.TenHang, sp.SoLuong.ToString(), sp.Gia.ToString("C"), sp.HinhAnh
        //});
        //    listPhuKien.Items.Add(item);
        //}

        private void lbTong_Click(object sender, EventArgs e)
        {

        }

        private void lbnTong_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listQuanAo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
