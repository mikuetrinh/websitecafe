namespace DoAnLapTrinhTrucQuan
{
    partial class FrmThemNhanVien
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
            pnlFooter = new Panel();
            button1 = new Button();
            btnHuy = new Button();
            pnlHeader = new Panel();
            picTieude = new PictureBox();
            btnDong = new Button();
            lbPhu = new Label();
            lbTieude = new Label();
            pnlBody = new Panel();
            tlpForm = new TableLayoutPanel();
            lbNgaynhanviec = new Label();
            lbManv = new Label();
            tbManv = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            pnlHoten = new Panel();
            tbHoten = new TextBox();
            label2 = new Label();
            tbSDT = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            lbVaitro = new Label();
            cbVaitro = new ComboBox();
            lbTaikhoanbaomat = new Label();
            label4 = new Label();
            label5 = new Label();
            pnlUsername = new Panel();
            tbTendangnhap = new TextBox();
            pnlPassword = new Panel();
            tbMatkhau = new TextBox();
            pnlSDT = new Panel();
            pnlEmail = new Panel();
            pnlFooter.SuspendLayout();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTieude).BeginInit();
            pnlBody.SuspendLayout();
            tlpForm.SuspendLayout();
            pnlHoten.SuspendLayout();
            pnlUsername.SuspendLayout();
            pnlPassword.SuspendLayout();
            SuspendLayout();
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.FromArgb(255, 248, 245);
            pnlFooter.Controls.Add(button1);
            pnlFooter.Controls.Add(btnHuy);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 716);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(632, 84);
            pnlFooter.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(43, 27, 23);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(22, 19);
            button1.Name = "button1";
            button1.Size = new Size(456, 46);
            button1.TabIndex = 4;
            button1.Text = "Lưu nhân viên";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.FromArgb(255, 224, 216);
            btnHuy.FlatAppearance.BorderSize = 0;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuy.ForeColor = Color.FromArgb(62, 39, 35);
            btnHuy.Location = new Point(494, 19);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(116, 46);
            btnHuy.TabIndex = 3;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(255, 241, 236);
            pnlHeader.Controls.Add(picTieude);
            pnlHeader.Controls.Add(btnDong);
            pnlHeader.Controls.Add(lbPhu);
            pnlHeader.Controls.Add(lbTieude);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(632, 103);
            pnlHeader.TabIndex = 1;
            // 
            // picTieude
            // 
            picTieude.Image = Properties.Resources.icTieudeThemnhanvien;
            picTieude.Location = new Point(22, 23);
            picTieude.Name = "picTieude";
            picTieude.Size = new Size(73, 61);
            picTieude.SizeMode = PictureBoxSizeMode.Zoom;
            picTieude.TabIndex = 3;
            picTieude.TabStop = false;
            // 
            // btnDong
            // 
            btnDong.BackColor = Color.FromArgb(255, 224, 216);
            btnDong.FlatAppearance.BorderSize = 0;
            btnDong.FlatStyle = FlatStyle.Flat;
            btnDong.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDong.ForeColor = SystemColors.ControlText;
            btnDong.Location = new Point(551, 23);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(50, 50);
            btnDong.TabIndex = 2;
            btnDong.Text = "✕";
            btnDong.UseVisualStyleBackColor = false;
            // 
            // lbPhu
            // 
            lbPhu.AutoSize = true;
            lbPhu.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPhu.ForeColor = Color.FromArgb(62, 39, 35);
            lbPhu.Location = new Point(110, 64);
            lbPhu.Name = "lbPhu";
            lbPhu.Size = new Size(470, 32);
            lbPhu.TabIndex = 1;
            lbPhu.Text = "Điền thông tin để thêm hồ sơ và tài khoản";
            // 
            // lbTieude
            // 
            lbTieude.AutoSize = true;
            lbTieude.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lbTieude.ForeColor = Color.FromArgb(62, 39, 35);
            lbTieude.Location = new Point(110, 23);
            lbTieude.Name = "lbTieude";
            lbTieude.Size = new Size(373, 51);
            lbTieude.TabIndex = 0;
            lbTieude.Text = "Thêm nhân viên mới";
            // 
            // pnlBody
            // 
            pnlBody.Controls.Add(tlpForm);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(0, 103);
            pnlBody.Name = "pnlBody";
            pnlBody.Padding = new Padding(28, 8, 28, 8);
            pnlBody.Size = new Size(632, 613);
            pnlBody.TabIndex = 2;
            // 
            // tlpForm
            // 
            tlpForm.AutoScroll = true;
            tlpForm.ColumnCount = 2;
            tlpForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpForm.Controls.Add(lbNgaynhanviec, 1, 0);
            tlpForm.Controls.Add(lbManv, 0, 0);
            tlpForm.Controls.Add(tbManv, 0, 1);
            tlpForm.Controls.Add(dateTimePicker1, 1, 1);
            tlpForm.Controls.Add(label1, 0, 2);
            tlpForm.Controls.Add(pnlHoten, 0, 3);
            tlpForm.Controls.Add(label2, 0, 4);
            tlpForm.Controls.Add(tbSDT, 0, 5);
            tlpForm.Controls.Add(label3, 0, 6);
            tlpForm.Controls.Add(textBox1, 0, 7);
            tlpForm.Controls.Add(lbVaitro, 0, 8);
            tlpForm.Controls.Add(cbVaitro, 0, 9);
            tlpForm.Controls.Add(lbTaikhoanbaomat, 0, 10);
            tlpForm.Controls.Add(label4, 0, 11);
            tlpForm.Controls.Add(label5, 1, 11);
            tlpForm.Controls.Add(pnlUsername, 0, 12);
            tlpForm.Controls.Add(pnlPassword, 1, 12);
            tlpForm.Dock = DockStyle.Fill;
            tlpForm.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tlpForm.Location = new Point(28, 8);
            tlpForm.Name = "tlpForm";
            tlpForm.RowCount = 13;
            tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tlpForm.Size = new Size(576, 597);
            tlpForm.TabIndex = 0;
            // 
            // lbNgaynhanviec
            // 
            lbNgaynhanviec.AutoSize = true;
            lbNgaynhanviec.Dock = DockStyle.Fill;
            lbNgaynhanviec.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbNgaynhanviec.ForeColor = Color.FromArgb(62, 39, 35);
            lbNgaynhanviec.Location = new Point(291, 0);
            lbNgaynhanviec.Name = "lbNgaynhanviec";
            lbNgaynhanviec.Size = new Size(282, 42);
            lbNgaynhanviec.TabIndex = 3;
            lbNgaynhanviec.Text = "Ngày nhận việc";
            lbNgaynhanviec.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lbManv
            // 
            lbManv.AutoSize = true;
            lbManv.Dock = DockStyle.Fill;
            lbManv.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbManv.ForeColor = Color.FromArgb(62, 39, 35);
            lbManv.Location = new Point(3, 0);
            lbManv.Name = "lbManv";
            lbManv.Size = new Size(282, 42);
            lbManv.TabIndex = 2;
            lbManv.Text = "Mã nhân viên";
            lbManv.TextAlign = ContentAlignment.BottomLeft;
            // 
            // tbManv
            // 
            tbManv.BackColor = Color.FromArgb(255, 241, 237);
            tbManv.Dock = DockStyle.Fill;
            tbManv.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            tbManv.ForeColor = Color.FromArgb(44, 22, 14);
            tbManv.Location = new Point(3, 45);
            tbManv.Name = "tbManv";
            tbManv.ReadOnly = true;
            tbManv.Size = new Size(282, 47);
            tbManv.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Dock = DockStyle.Fill;
            dateTimePicker1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(291, 45);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(282, 47);
            dateTimePicker1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(62, 39, 35);
            label1.Location = new Point(3, 94);
            label1.Name = "label1";
            label1.Size = new Size(282, 42);
            label1.TabIndex = 4;
            label1.Text = "Họ và tên nhân viên (*)";
            label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // pnlHoten
            // 
            pnlHoten.BackColor = Color.White;
            tlpForm.SetColumnSpan(pnlHoten, 2);
            pnlHoten.Controls.Add(tbHoten);
            pnlHoten.Dock = DockStyle.Fill;
            pnlHoten.Location = new Point(3, 138);
            pnlHoten.Margin = new Padding(3, 2, 3, 2);
            pnlHoten.Name = "pnlHoten";
            pnlHoten.Size = new Size(570, 36);
            pnlHoten.TabIndex = 9;
            // 
            // tbHoten
            // 
            tbHoten.BackColor = SystemColors.Window;
            tbHoten.Dock = DockStyle.Fill;
            tbHoten.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            tbHoten.Location = new Point(0, 0);
            tbHoten.Margin = new Padding(0);
            tbHoten.Name = "tbHoten";
            tbHoten.PlaceholderText = "Nhập họ và tên";
            tbHoten.Size = new Size(570, 54);
            tbHoten.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(62, 39, 35);
            label2.Location = new Point(3, 176);
            label2.Name = "label2";
            label2.Size = new Size(282, 42);
            label2.TabIndex = 5;
            label2.Text = "Số điện thoại";
            label2.TextAlign = ContentAlignment.BottomLeft;
            // 
            // tbSDT
            // 
            tbSDT.BackColor = SystemColors.Window;
            tlpForm.SetColumnSpan(tbSDT, 2);
            tbSDT.Dock = DockStyle.Fill;
            tbSDT.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            tbSDT.Location = new Point(3, 222);
            tbSDT.Margin = new Padding(3, 4, 3, 4);
            tbSDT.Name = "tbSDT";
            tbSDT.PlaceholderText = "09xx xxx xxx";
            tbSDT.Size = new Size(570, 47);
            tbSDT.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(62, 39, 35);
            label3.Location = new Point(3, 258);
            label3.Name = "label3";
            label3.Size = new Size(282, 42);
            label3.TabIndex = 6;
            label3.Text = "Email công việc";
            label3.TextAlign = ContentAlignment.BottomLeft;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            tlpForm.SetColumnSpan(textBox1, 2);
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            textBox1.Location = new Point(3, 304);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "ten@moccafe.vn";
            textBox1.Size = new Size(570, 47);
            textBox1.TabIndex = 11;
            // 
            // lbVaitro
            // 
            lbVaitro.AutoSize = true;
            lbVaitro.Dock = DockStyle.Fill;
            lbVaitro.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbVaitro.ForeColor = Color.FromArgb(62, 39, 35);
            lbVaitro.Location = new Point(3, 340);
            lbVaitro.Name = "lbVaitro";
            lbVaitro.Size = new Size(282, 42);
            lbVaitro.TabIndex = 12;
            lbVaitro.Text = "Vai trò (*)";
            lbVaitro.TextAlign = ContentAlignment.BottomLeft;
            // 
            // cbVaitro
            // 
            tlpForm.SetColumnSpan(cbVaitro, 2);
            cbVaitro.Dock = DockStyle.Fill;
            cbVaitro.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVaitro.FormattingEnabled = true;
            cbVaitro.Items.AddRange(new object[] { "Nhân viên", "Quản lý" });
            cbVaitro.Location = new Point(3, 385);
            cbVaitro.Name = "cbVaitro";
            cbVaitro.Size = new Size(570, 53);
            cbVaitro.TabIndex = 13;
            // 
            // lbTaikhoanbaomat
            // 
            lbTaikhoanbaomat.AutoSize = true;
            lbTaikhoanbaomat.Dock = DockStyle.Fill;
            lbTaikhoanbaomat.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbTaikhoanbaomat.ForeColor = Color.FromArgb(62, 39, 35);
            lbTaikhoanbaomat.Location = new Point(3, 434);
            lbTaikhoanbaomat.Name = "lbTaikhoanbaomat";
            lbTaikhoanbaomat.Size = new Size(282, 45);
            lbTaikhoanbaomat.TabIndex = 14;
            lbTaikhoanbaomat.Text = "Tài khoản và bảo mật";
            lbTaikhoanbaomat.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(62, 39, 35);
            label4.Location = new Point(3, 479);
            label4.Name = "label4";
            label4.Size = new Size(282, 45);
            label4.TabIndex = 15;
            label4.Text = "Tên đăng nhập (*)";
            label4.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(62, 39, 35);
            label5.Location = new Point(291, 479);
            label5.Name = "label5";
            label5.Size = new Size(282, 45);
            label5.TabIndex = 16;
            label5.Text = "Mật khẩu (*)";
            label5.TextAlign = ContentAlignment.BottomLeft;
            // 
            // pnlUsername
            // 
            pnlUsername.BackColor = Color.White;
            pnlUsername.Controls.Add(tbTendangnhap);
            pnlUsername.Dock = DockStyle.Fill;
            pnlUsername.Location = new Point(3, 528);
            pnlUsername.Margin = new Padding(3, 4, 3, 4);
            pnlUsername.Name = "pnlUsername";
            pnlUsername.Size = new Size(282, 65);
            pnlUsername.TabIndex = 17;
            // 
            // tbTendangnhap
            // 
            tbTendangnhap.BackColor = SystemColors.Window;
            tbTendangnhap.Dock = DockStyle.Fill;
            tbTendangnhap.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            tbTendangnhap.Location = new Point(0, 0);
            tbTendangnhap.Margin = new Padding(0);
            tbTendangnhap.Name = "tbTendangnhap";
            tbTendangnhap.PlaceholderText = "vd: hung.nv";
            tbTendangnhap.Size = new Size(282, 47);
            tbTendangnhap.TabIndex = 17;
            // 
            // pnlPassword
            // 
            pnlPassword.BackColor = Color.White;
            pnlPassword.Controls.Add(tbMatkhau);
            pnlPassword.Dock = DockStyle.Fill;
            pnlPassword.Location = new Point(291, 528);
            pnlPassword.Margin = new Padding(3, 4, 3, 4);
            pnlPassword.Name = "pnlPassword";
            pnlPassword.Size = new Size(282, 65);
            pnlPassword.TabIndex = 18;
            // 
            // tbMatkhau
            // 
            tbMatkhau.BackColor = SystemColors.Window;
            tbMatkhau.Dock = DockStyle.Fill;
            tbMatkhau.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            tbMatkhau.Location = new Point(0, 0);
            tbMatkhau.Margin = new Padding(0);
            tbMatkhau.Name = "tbMatkhau";
            tbMatkhau.PasswordChar = '●';
            tbMatkhau.PlaceholderText = "Tối thiểu 6 ký tự";
            tbMatkhau.Size = new Size(282, 47);
            tbMatkhau.TabIndex = 18;
            // 
            // pnlSDT
            // 
            pnlSDT.BackColor = Color.White;
            pnlSDT.Dock = DockStyle.Fill;
            pnlSDT.Location = new Point(3, 223);
            pnlSDT.Margin = new Padding(3, 4, 3, 4);
            pnlSDT.Name = "pnlSDT";
            pnlSDT.Size = new Size(570, 32);
            pnlSDT.TabIndex = 10;
            // 
            // pnlEmail
            // 
            pnlEmail.BackColor = Color.White;
            pnlEmail.Dock = DockStyle.Fill;
            pnlEmail.Location = new Point(3, 305);
            pnlEmail.Margin = new Padding(3, 4, 3, 4);
            pnlEmail.Name = "pnlEmail";
            pnlEmail.Size = new Size(570, 30);
            pnlEmail.TabIndex = 11;
            // 
            // FrmThemNhanVien
            // 
            AutoScaleDimensions = new SizeF(16F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(632, 800);
            Controls.Add(pnlBody);
            Controls.Add(pnlHeader);
            Controls.Add(pnlFooter);
            Font = new Font("Segoe UI", 11F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmThemNhanVien";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thêm nhân viên mới";
            pnlFooter.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picTieude).EndInit();
            pnlBody.ResumeLayout(false);
            tlpForm.ResumeLayout(false);
            tlpForm.PerformLayout();
            pnlHoten.ResumeLayout(false);
            pnlHoten.PerformLayout();
            pnlUsername.ResumeLayout(false);
            pnlUsername.PerformLayout();
            pnlPassword.ResumeLayout(false);
            pnlPassword.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlFooter;
        private Panel pnlHeader;
        private Label lbTieude;
        private Panel pnlBody;
        private Button btnDong;
        private Label lbPhu;
        private Button button1;
        private Button btnHuy;
        private TableLayoutPanel tlpForm;
        private Label lbNgaynhanviec;
        private Label lbManv;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbManv;
        private DateTimePicker dateTimePicker1;
        private TextBox tbHoten;
        private TextBox tbSDT;
        private TextBox textBox1;
        private Label lbVaitro;
        private ComboBox cbVaitro;
        private Label lbTaikhoanbaomat;
        private Label label4;
        private Label label5;
        private TextBox tbTendangnhap;
        private TextBox tbMatkhau;
        private Panel pnlHoten;
        private Panel pnlSDT;
        private Panel pnlEmail;
        private Panel pnlUsername;
        private Panel pnlPassword;
        private PictureBox picTieude;
    }
}