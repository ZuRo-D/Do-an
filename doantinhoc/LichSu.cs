using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doantinhoc
{
    public partial class LichSu : Form
    {

        decimal inc = 0;
        decimal outc = 0;
        decimal profit = 0;
        CultureInfo ct = new CultureInfo("vi-VN");
        private DateTimePicker lastSelectedDateTimePicker;
        public LichSu()
        {
            InitializeComponent();
            LoadDate();
            ShowBill(tpBd.MinDate, tpKt.MaxDate);

            rbThu.CheckedChanged += new EventHandler(rbThuChi_CheckedChanged);
            rbChi.CheckedChanged += new EventHandler(rbThuChi_CheckedChanged);
        }



        void ShowBill(DateTime ngaybd, DateTime ngaykt)
        {
            lvBill.Items.Clear();
            List<HangHoa> lb = HangHoa.Instance.loadBillList(ngaybd, ngaykt);
            

        }

        void LoadDate()
        {
            DateTime today = DateTime.Now;
            tpBd.Value = new DateTime(today.Year, today.Month, 1);
            tpKt.Value = tpBd.Value.AddMonths(1);
            tpTs.Value = new DateTime(today.Year, today.Month, 1);
        }

        void ResetValue()
        {
            rbChi.Checked = false;
            rbThu.Checked = false;
        }

        void ApplyDateFilter()
        {
            if (lastSelectedDateTimePicker != null)
            {
                DateTime fday = new DateTime(lastSelectedDateTimePicker.Value.Year, lastSelectedDateTimePicker.Value.Month, 1);
                DateTime lday = fday.AddMonths(1);
                ShowBill(fday, lday);

                if (lastSelectedDateTimePicker == tpTs)
                {
                    txtProfitMonth.Text = (profit).ToString("c", ct);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtOut_TextChanged(object sender, EventArgs e)
        {

        }

        private void LichSu_Load(object sender, EventArgs e)
        {

        }

        private void rbKhoang_CheckedChanged(object sender, EventArgs e)
        {
            if (rbKhoang.Checked)
            {
                gbKhoang.Enabled = true;
                ShowBill(tpBd.Value, tpKt.Value);
                ResetValue();
            }
            else
            {
                gbKhoang.Enabled = false;
            }
        }

        private void rbHai_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHai.Checked)
            {
                gbHai.Enabled = true;
                ResetValue();
            }
            else
            {
                gbHai.Enabled = false;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tpBd_ValueChanged(object sender, EventArgs e)
        {
            ShowBill(tpBd.Value, tpKt.Value);
            txtIn.Text = inc.ToString("c", ct);
            txtOut.Text = outc.ToString("c", ct);
            txtProfit.Text = profit.ToString("c", ct);
            ResetValue();
        }

        private void tpKt_ValueChanged(object sender, EventArgs e)
        {
            ShowBill(tpBd.Value, tpKt.Value);
            txtIn.Text = inc.ToString("c", ct);
            txtOut.Text = outc.ToString("c", ct);
            txtProfit.Text = profit.ToString("c", ct);
            ResetValue();
        }

        private void tpTs_ValueChanged(object sender, EventArgs e)
        {
            lastSelectedDateTimePicker = tpTs;
            ApplyDateFilter();
            ResetValue();
        }
        private void rbThuChi_CheckedChanged(object sender, EventArgs e)
        {
            if (rbKhoang.Checked)
            {
                int? billingType = null;
                if (rbThu.Checked) billingType = 1;
                if (rbChi.Checked) billingType = 0;
                ShowBill(tpBd.Value, tpKt.Value);
                txtIn.Text = inc.ToString("c", ct);
                txtOut.Text = outc.ToString("c", ct);
                txtProfit.Text = profit.ToString("c", ct);
            }
            else if (rbHai.Checked)
            {
                int? billingType = null;
                if (rbThu.Checked) billingType = 1;
                if (rbChi.Checked) billingType = 0;
                DateTime fday = new DateTime(lastSelectedDateTimePicker.Value.Year, lastSelectedDateTimePicker.Value.Month, 1);
                DateTime lday = fday.AddMonths(1);
                ShowBill(fday, lday);

                if (lastSelectedDateTimePicker == tpTs)
                {
                    txtProfitMonth.Text = (profit).ToString("c", ct);
                }
            }
            else
            {
                int? billingType = null;
                if (rbThu.Checked) billingType = 1;
                if (rbChi.Checked) billingType = 0;
                ShowBill(tpBd.MinDate, tpKt.MaxDate);
            }
        }
    }
}
