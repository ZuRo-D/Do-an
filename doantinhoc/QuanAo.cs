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
    public partial class QuanAo : Form
    {
        public static QuanAo Instance { get; private set; }
        public QuanAo()
        {
            InitializeComponent();
            Instance = this;
        }

        //public void ThemSanPham(HangHoa sp)
        //{
        //    ListViewItem item = new ListViewItem(new[]
        //    {
        //    sp.MaHang, sp.TenHang, sp.SoLuong.ToString(), sp.Gia.ToString("C"), sp.HinhAnh
        //    });
        //    listQuanAo.Items.Add(item);
        //}

        private void listQuanAo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
