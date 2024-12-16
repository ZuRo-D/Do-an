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
    public partial class HoaDon : Form
    {
        private decimal tongTien; // Tổng tiền hóa đơn
        private Dictionary<string, HangHoa> danhSachHangHoa; // Dữ liệu hàng hóa từ Form Nhập Hàng
        public HoaDon(Dictionary<string, HangHoa> hangHoa)
        {
            InitializeComponent();
            tongTien = 0;
            danhSachHangHoa = hangHoa;

            // Tạo mã khách hàng tự động
            txtMaHang.Text = TaoMaKhachHang();
        }

        private string TaoMaKhachHang()
        {
            return "KH" + DateTime.Now.Ticks.ToString().Substring(10);
        }



        private void HoaDon_Load(object sender, EventArgs e)
        {

        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maHang = txtMaHang.Text;
            string loai = cboLoai.SelectedItem?.ToString();
            int soLuong = int.Parse(numsoluong.Text);

            // Kiểm tra mã hàng có tồn tại trong danh sách không
            if (!danhSachHangHoa.ContainsKey(maHang))
            {
                MessageBox.Show("Mã hàng không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HangHoa sp = danhSachHangHoa[maHang];

            // Kiểm tra loại và số lượng hợp lệ
            if (sp.Loai != loai)
            {
                MessageBox.Show("Loại hàng không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (soLuong > sp.SoLuong)
            {
                MessageBox.Show("Số lượng vượt quá tồn kho!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Tính thành tiền và cập nhật tổng tiền
            decimal thanhTien = soLuong * sp.Gia;
            tongTien += thanhTien;

            // Thêm sản phẩm vào DataGridView
            dvgHoaDon.Rows.Add(maHang, loai, soLuong, sp.Gia, thanhTien);

            // Cập nhật tổng tiền trên giao diện
            lbntong.Text = $"Tổng tiền: {tongTien:C}";

            // Trừ số lượng trong kho
            sp.SoLuong -= soLuong;
        }

        private void btnIHD_Click(object sender, EventArgs e)
        {
            if (dvgHoaDon.Rows.Count == 0)
            {
                MessageBox.Show("Hóa đơn trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hiển thị thông báo xuất hóa đơn
            MessageBox.Show("Hóa đơn đã được xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // In hoặc lưu hóa đơn nếu cần
            InHoaDon();
        }

        private void InHoaDon()
        {
            string hoaDon = $"HÓA ĐƠN\nMã khách hàng: {txtMaHang.Text}\nNgày: {DateTime.Now}\n\n";
            hoaDon += "Mã hàng\tLoại\tSố lượng\tĐơn giá\tThành tiền\n";

            foreach (DataGridViewRow row in dvgHoaDon.Rows)
            {
                string maHang = row.Cells[0].Value.ToString();
                string loai = row.Cells[1].Value.ToString();
                string soLuong = row.Cells[2].Value.ToString();
                string donGia = row.Cells[3].Value.ToString();
                string thanhTien = row.Cells[4].Value.ToString();

                hoaDon += $"{maHang}\t{loai}\t{soLuong}\t{donGia}\t{thanhTien}\n";
            }
            hoaDon += $"\nTỔNG TIỀN: {tongTien:C}";

            // Hiển thị hóa đơn trong MessageBox (hoặc lưu vào file, in ra nếu cần)
            MessageBox.Show(hoaDon, "Hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
