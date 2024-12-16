namespace doantinhoc
{
    partial class LichSu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbHai = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tpTs = new System.Windows.Forms.DateTimePicker();
            this.txtProfitMonth = new System.Windows.Forms.TextBox();
            this.rbHai = new System.Windows.Forms.RadioButton();
            this.gbKhoang = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tpKt = new System.Windows.Forms.DateTimePicker();
            this.tpBd = new System.Windows.Forms.DateTimePicker();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.txtProfit = new System.Windows.Forms.TextBox();
            this.txtIn = new System.Windows.Forms.TextBox();
            this.rbKhoang = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.rbChi = new System.Windows.Forms.RadioButton();
            this.rbThu = new System.Windows.Forms.RadioButton();
            this.lvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.gbHai.SuspendLayout();
            this.gbKhoang.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.gbHai);
            this.panel1.Controls.Add(this.rbHai);
            this.panel1.Controls.Add(this.gbKhoang);
            this.panel1.Controls.Add(this.rbKhoang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(558, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 551);
            this.panel1.TabIndex = 0;
            // 
            // gbHai
            // 
            this.gbHai.Controls.Add(this.label6);
            this.gbHai.Controls.Add(this.label5);
            this.gbHai.Controls.Add(this.tpTs);
            this.gbHai.Controls.Add(this.txtProfitMonth);
            this.gbHai.Enabled = false;
            this.gbHai.Location = new System.Drawing.Point(9, 337);
            this.gbHai.Margin = new System.Windows.Forms.Padding(5);
            this.gbHai.Name = "gbHai";
            this.gbHai.Padding = new System.Windows.Forms.Padding(5);
            this.gbHai.Size = new System.Drawing.Size(335, 154);
            this.gbHai.TabIndex = 74;
            this.gbHai.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(9, 41);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 67;
            this.label6.Text = "Tháng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(9, 101);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 66;
            this.label5.Text = "Lợi nhuận";
            // 
            // tpTs
            // 
            this.tpTs.CustomFormat = "MM/yyyy ";
            this.tpTs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpTs.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tpTs.Location = new System.Drawing.Point(116, 34);
            this.tpTs.Margin = new System.Windows.Forms.Padding(5);
            this.tpTs.Name = "tpTs";
            this.tpTs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tpTs.Size = new System.Drawing.Size(191, 26);
            this.tpTs.TabIndex = 55;
            this.tpTs.Value = new System.DateTime(2024, 5, 25, 19, 10, 0, 0);
            this.tpTs.ValueChanged += new System.EventHandler(this.tpTs_ValueChanged);
            // 
            // txtProfitMonth
            // 
            this.txtProfitMonth.Enabled = false;
            this.txtProfitMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfitMonth.Location = new System.Drawing.Point(116, 97);
            this.txtProfitMonth.Margin = new System.Windows.Forms.Padding(5);
            this.txtProfitMonth.Name = "txtProfitMonth";
            this.txtProfitMonth.Size = new System.Drawing.Size(191, 26);
            this.txtProfitMonth.TabIndex = 62;
            this.txtProfitMonth.Text = "0";
            this.txtProfitMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rbHai
            // 
            this.rbHai.AutoSize = true;
            this.rbHai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHai.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rbHai.Location = new System.Drawing.Point(9, 298);
            this.rbHai.Margin = new System.Windows.Forms.Padding(5);
            this.rbHai.Name = "rbHai";
            this.rbHai.Size = new System.Drawing.Size(213, 29);
            this.rbHai.TabIndex = 75;
            this.rbHai.TabStop = true;
            this.rbHai.Text = "Thống kê theo tháng";
            this.rbHai.UseVisualStyleBackColor = true;
            this.rbHai.CheckedChanged += new System.EventHandler(this.rbHai_CheckedChanged);
            // 
            // gbKhoang
            // 
            this.gbKhoang.Controls.Add(this.label4);
            this.gbKhoang.Controls.Add(this.label3);
            this.gbKhoang.Controls.Add(this.label2);
            this.gbKhoang.Controls.Add(this.label1);
            this.gbKhoang.Controls.Add(this.label7);
            this.gbKhoang.Controls.Add(this.tpKt);
            this.gbKhoang.Controls.Add(this.tpBd);
            this.gbKhoang.Controls.Add(this.txtOut);
            this.gbKhoang.Controls.Add(this.txtProfit);
            this.gbKhoang.Controls.Add(this.txtIn);
            this.gbKhoang.Enabled = false;
            this.gbKhoang.Location = new System.Drawing.Point(9, 49);
            this.gbKhoang.Margin = new System.Windows.Forms.Padding(5);
            this.gbKhoang.Name = "gbKhoang";
            this.gbKhoang.Padding = new System.Windows.Forms.Padding(5);
            this.gbKhoang.Size = new System.Drawing.Size(335, 214);
            this.gbKhoang.TabIndex = 73;
            this.gbKhoang.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(9, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 69;
            this.label4.Text = "Đến ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(9, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 68;
            this.label3.Text = "Tổng thu";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(9, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 67;
            this.label2.Text = "Tổng chi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(9, 174);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 66;
            this.label1.Text = "Lợi nhuận";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(9, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 65;
            this.label7.Text = "Từ ngày";
            // 
            // tpKt
            // 
            this.tpKt.CustomFormat = "dd/MM/yyyy HH:mm";
            this.tpKt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpKt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tpKt.Location = new System.Drawing.Point(116, 57);
            this.tpKt.Margin = new System.Windows.Forms.Padding(5);
            this.tpKt.Name = "tpKt";
            this.tpKt.Size = new System.Drawing.Size(191, 26);
            this.tpKt.TabIndex = 54;
            this.tpKt.Value = new System.DateTime(2024, 5, 26, 22, 11, 0, 0);
            this.tpKt.ValueChanged += new System.EventHandler(this.tpKt_ValueChanged);
            // 
            // tpBd
            // 
            this.tpBd.CustomFormat = "dd/MM/yyyy HH:mm";
            this.tpBd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpBd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tpBd.Location = new System.Drawing.Point(116, 15);
            this.tpBd.Margin = new System.Windows.Forms.Padding(5);
            this.tpBd.Name = "tpBd";
            this.tpBd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tpBd.Size = new System.Drawing.Size(191, 26);
            this.tpBd.TabIndex = 55;
            this.tpBd.Value = new System.DateTime(2024, 5, 25, 19, 10, 0, 0);
            this.tpBd.ValueChanged += new System.EventHandler(this.tpBd_ValueChanged);
            // 
            // txtOut
            // 
            this.txtOut.Enabled = false;
            this.txtOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOut.Location = new System.Drawing.Point(116, 134);
            this.txtOut.Margin = new System.Windows.Forms.Padding(5);
            this.txtOut.Name = "txtOut";
            this.txtOut.Size = new System.Drawing.Size(191, 26);
            this.txtOut.TabIndex = 64;
            this.txtOut.Text = "0";
            this.txtOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOut.TextChanged += new System.EventHandler(this.txtOut_TextChanged);
            // 
            // txtProfit
            // 
            this.txtProfit.Enabled = false;
            this.txtProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfit.Location = new System.Drawing.Point(116, 174);
            this.txtProfit.Margin = new System.Windows.Forms.Padding(5);
            this.txtProfit.Name = "txtProfit";
            this.txtProfit.Size = new System.Drawing.Size(191, 26);
            this.txtProfit.TabIndex = 62;
            this.txtProfit.Text = "0";
            this.txtProfit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtIn
            // 
            this.txtIn.Enabled = false;
            this.txtIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIn.Location = new System.Drawing.Point(116, 95);
            this.txtIn.Margin = new System.Windows.Forms.Padding(5);
            this.txtIn.Name = "txtIn";
            this.txtIn.Size = new System.Drawing.Size(191, 26);
            this.txtIn.TabIndex = 60;
            this.txtIn.Text = "0";
            this.txtIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rbKhoang
            // 
            this.rbKhoang.AutoSize = true;
            this.rbKhoang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbKhoang.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rbKhoang.Location = new System.Drawing.Point(9, 17);
            this.rbKhoang.Margin = new System.Windows.Forms.Padding(5);
            this.rbKhoang.Name = "rbKhoang";
            this.rbKhoang.Size = new System.Drawing.Size(229, 29);
            this.rbKhoang.TabIndex = 72;
            this.rbKhoang.TabStop = true;
            this.rbKhoang.Text = "Thống kê theo khoảng";
            this.rbKhoang.UseVisualStyleBackColor = true;
            this.rbKhoang.CheckedChanged += new System.EventHandler(this.rbKhoang_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.rbChi);
            this.panel2.Controls.Add(this.rbThu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(558, 79);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(3, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(258, 31);
            this.label11.TabIndex = 105;
            this.label11.Text = "Lịch Sử Hoạt Động";
            // 
            // rbChi
            // 
            this.rbChi.AutoSize = true;
            this.rbChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbChi.ForeColor = System.Drawing.SystemColors.Control;
            this.rbChi.Location = new System.Drawing.Point(461, 38);
            this.rbChi.Margin = new System.Windows.Forms.Padding(5);
            this.rbChi.Name = "rbChi";
            this.rbChi.Size = new System.Drawing.Size(79, 35);
            this.rbChi.TabIndex = 107;
            this.rbChi.TabStop = true;
            this.rbChi.Text = "Chi";
            this.rbChi.UseVisualStyleBackColor = true;
            // 
            // rbThu
            // 
            this.rbThu.AutoSize = true;
            this.rbThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbThu.ForeColor = System.Drawing.SystemColors.Control;
            this.rbThu.Location = new System.Drawing.Point(320, 38);
            this.rbThu.Margin = new System.Windows.Forms.Padding(5);
            this.rbThu.Name = "rbThu";
            this.rbThu.Size = new System.Drawing.Size(85, 35);
            this.rbThu.TabIndex = 106;
            this.rbThu.TabStop = true;
            this.rbThu.Text = "Thu";
            this.rbThu.UseVisualStyleBackColor = true;
            // 
            // lvBill
            // 
            this.lvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader7,
            this.columnHeader9,
            this.columnHeader11,
            this.columnHeader12});
            this.lvBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvBill.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lvBill.HideSelection = false;
            this.lvBill.Location = new System.Drawing.Point(24, 87);
            this.lvBill.Margin = new System.Windows.Forms.Padding(4);
            this.lvBill.Name = "lvBill";
            this.lvBill.Size = new System.Drawing.Size(516, 451);
            this.lvBill.TabIndex = 2;
            this.lvBill.UseCompatibleStateImageBehavior = false;
            this.lvBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ngày thanh toán";
            this.columnHeader1.Width = 135;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Mã khách hàng";
            this.columnHeader7.Width = 134;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Tên hàng";
            this.columnHeader9.Width = 80;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Số lượng";
            this.columnHeader11.Width = 79;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Tổng tiền";
            this.columnHeader12.Width = 88;
            // 
            // LichSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 551);
            this.Controls.Add(this.lvBill);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LichSu";
            this.Text = "CapNhat";
            this.Load += new System.EventHandler(this.LichSu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbHai.ResumeLayout(false);
            this.gbHai.PerformLayout();
            this.gbKhoang.ResumeLayout(false);
            this.gbKhoang.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gbHai;
        private System.Windows.Forms.DateTimePicker tpTs;
        private System.Windows.Forms.TextBox txtProfitMonth;
        private System.Windows.Forms.RadioButton rbHai;
        private System.Windows.Forms.GroupBox gbKhoang;
        private System.Windows.Forms.DateTimePicker tpKt;
        private System.Windows.Forms.DateTimePicker tpBd;
        private System.Windows.Forms.TextBox txtOut;
        private System.Windows.Forms.TextBox txtProfit;
        private System.Windows.Forms.TextBox txtIn;
        private System.Windows.Forms.RadioButton rbKhoang;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rbChi;
        private System.Windows.Forms.RadioButton rbThu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lvBill;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
    }
}