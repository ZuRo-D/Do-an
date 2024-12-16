using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace doantinhoc
{
   
    public partial class NhapHang : Form
    {
        private QuanAo quanAoForm;
        private PhuKien phuKienForm;

        private DataTable dataTable;
        private QuanAo quanao;
        private PhuKien phukien;
        public NhapHang()
        {
            InitializeComponent();
            khoitao();
            cboLoai.Items.AddRange(new string[] { "Quần áo", "Phụ kiện" });
            cboLoai.SelectedIndex = 0;
            quanao = new QuanAo();
            phukien = new PhuKien();
        }



        private void khoitao()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("Mã hàng");
            dataTable.Columns.Add("Tên hàng");
            dataTable.Columns.Add("Loại");
            dataTable.Columns.Add("Số lượng", typeof(int));
            dataTable.Columns.Add("Giá", typeof(decimal));
            dataTable.Columns.Add("Hình ảnh");
            dvgNhapHang.DataSource = dataTable;
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pctAnh.Image=Image.FromFile(openFileDialog.FileName);
                    pctAnh.Tag= openFileDialog.FileName;
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaHang.Text) || string.IsNullOrWhiteSpace(txtMaHang.Text))
            {
                MessageBox.Show("Yêu cầu nhập đủ thông tin", "Thông báo");
                return;
            }
            DataRow row = dataTable.NewRow();
            row["Mã hàng"] = txtMaHang.Text;
            row["Tên hàng"] = txtTenHang.Text;
            row["Loại"] = cboLoai.SelectedItem.ToString();
            row["Số lượng"] = numsoluong.Value;
            row["Giá"] = decimal.Parse(txtGia.Text);
            if (pctAnh.Image != null && pctAnh.Tag != null)
            {
                row["Hình ảnh"] = pctAnh.Tag.ToString();
            }
            dataTable.Rows.Add(row);

            //HangHoa sp = new HangHoa
            //{
            //    //MaHang = txtMaHang.Text,
            //    //TenHang = txtTenHang.Text,
            //    //Loai = cboLoai.SelectedItem?.ToString(),
            //    //SoLuong = (int)numsoluong.Value,
            //    //Gia = decimal.Parse(txtGia.Text),
            //    //HinhAnh = pctAnh.Tag?.ToString() ?? string.Empty // Đường dẫn ảnh
            //};

            //if (sp.Loai == "Quần áo")
            //{
            //    quanAoForm.ThemSanPham(sp);
            //}
            //else if (sp.Loai == "Phụ kiện")
            //{
            //    phuKienForm.ThemSanPham(sp);
            //}
            ClearFields();


        }

        private void ClearFields()
        {
            txtMaHang.Clear();
            txtTenHang.Clear();
            txtGia.Clear(); 
            pctAnh.Image=null;
            pctAnh.Tag = null;
            numsoluong.Value = 0;
            cboLoai.SelectedItem = 0;
        }

        private void btnRS_Click(object sender, EventArgs e)
        {
            txtTenHang.Clear();
            txtMaHang.Clear();
            txtGia.Clear();
            if (cboLoai.Items.Count > 0)
            {
                cboLoai.SelectedIndex = 0;
            }

            numsoluong.Text = "0";
            pctAnh.Image = null;
            pctAnh.Tag = null;
            dvgNhapHang.ClearSelection();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dvgNhapHang.SelectedRows.Count > 0)
            {
                DataGridViewRow a=dvgNhapHang.SelectedRows[0];
                a.Cells["Mã hàng"].Value=txtMaHang.Text;
                a.Cells["Tên hàng"].Value = txtTenHang.Text;
                a.Cells["Loại"].Value=cboLoai.SelectedItem.ToString();
                a.Cells["Số lượng"].Value=numsoluong.Value;
                a.Cells["Giá"].Value=decimal.Parse(txtGia.Text); //////////
                if (pctAnh.Image != null && pctAnh.Tag != null)
                {
                    a.Cells["Hình ảnh"].Value=pctAnh.Tag.ToString();
                }
            }
            else
            {
                MessageBox.Show("Chọn dòng để sửa", "Thông báo");
            }
        }

        private void dvgNhapHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dvgNhapHang.SelectedRows.Count>0)
            {
                DataGridViewRow b = dvgNhapHang.SelectedRows[0];
                txtMaHang.Text = b.Cells["Mã hàng"].Value.ToString();
                txtTenHang.Text = b.Cells["Tên hàng"].Value.ToString() ;
                cboLoai.SelectedItem = b.Cells["Loại"].Value.ToString();
                numsoluong.Value = Convert.ToInt32(b.Cells["Số lượng"].Value);
                txtGia.Text = b.Cells["Giá"].Value.ToString();

                string c = b.Cells["Hình ảnh"].Value?.ToString();
                if (!string.IsNullOrEmpty(c)&&File.Exists(c))
                {
                    pctAnh.Image=Image.FromFile(c);
                }
                else
                {
                    pctAnh.Image = null;
                }

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dvgNhapHang.SelectedRows.Count > 0)
            {
                foreach(DataGridViewRow row in dvgNhapHang.SelectedRows)
                {
                    dvgNhapHang.Rows.Remove(row);
                }
            }
            else
            {
                MessageBox.Show("Chọn dòng để xóa", "Thông báo");
            }
        }

        private void NhapHang_Load(object sender, EventArgs e)
        {

        }
    }
}
