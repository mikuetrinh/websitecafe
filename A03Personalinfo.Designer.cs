namespace DoAnLapTrinhTrucQuan
{
    partial class A03Personalinfo
    {
        private System.ComponentModel.IContainer? components = null;

        // ── Left panel controls ──────────────────────────────────────────
        private Panel       pnlLeft      = null!;
        private PictureBox  picAvatar    = null!;
        private Label       lblName      = null!;
        private Label       lblRole      = null!;
        private Label       lblStatus    = null!;
        private Label       lblEmployeeId = null!;
        private Label       lblJoinDate  = null!;

        // ── Right panel controls ─────────────────────────────────────────
        private Panel       pnlRight             = null!;
        private Label       lblPageTitle         = null!;
        private Label       lblPageSubtitle      = null!;

        private Label       lblFullNameLabel     = null!;
        private TextBox     txtFullName          = null!;
        private Label       lblUsernameLabel     = null!;
        private Label       lblUsernameNote      = null!;
        private TextBox     txtUsername          = null!;
        private Label       lblRoleLabel         = null!;
        private TextBox     txtRole              = null!;
        private Label       lblPhoneLabel        = null!;
        private TextBox     txtPhone             = null!;
        private Label       lblEmailLabel        = null!;
        private TextBox     txtEmail             = null!;
        private Label       lblShiftLabel        = null!;
        private TextBox     txtShift             = null!;
        private Label       lblShiftNote         = null!;

        private Button      btnChangePassword    = null!;
        private Button      btnCancel            = null!;
        private Button      btnSave              = null!;
        private Label       lblMessage           = null!;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            // ── Instantiate ─────────────────────────────────────────────
            pnlLeft           = new Panel();
            picAvatar         = new PictureBox();
            lblName           = new Label();
            lblRole           = new Label();
            lblStatus         = new Label();
            lblEmployeeId     = new Label();
            lblJoinDate       = new Label();

            pnlRight          = new Panel();
            lblPageTitle      = new Label();
            lblPageSubtitle   = new Label();

            lblFullNameLabel  = new Label();
            txtFullName       = new TextBox();
            lblUsernameLabel  = new Label();
            lblUsernameNote   = new Label();
            txtUsername       = new TextBox();
            lblRoleLabel      = new Label();
            txtRole           = new TextBox();
            lblPhoneLabel     = new Label();
            txtPhone          = new TextBox();
            lblEmailLabel     = new Label();
            txtEmail          = new TextBox();
            lblShiftLabel     = new Label();
            txtShift          = new TextBox();
            lblShiftNote      = new Label();

            btnChangePassword = new Button();
            btnCancel         = new Button();
            btnSave           = new Button();
            lblMessage        = new Label();

            pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            pnlRight.SuspendLayout();
            SuspendLayout();

            // ═══════════════════════════════════════════════════════════════
            // A03Personalinfo (UserControl root)
            // ═══════════════════════════════════════════════════════════════
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode       = AutoScaleMode.Font;
            BackColor           = Color.FromArgb(250, 247, 243);
            Dock                = DockStyle.Fill;
            Name                = "A03Personalinfo";
            Size                = new Size(1100, 700);

            // ═══════════════════════════════════════════════════════════════
            // pnlLeft  (280 px wide, white, right border)
            // ═══════════════════════════════════════════════════════════════
            pnlLeft.BackColor = Color.White;
            pnlLeft.Dock      = DockStyle.Left;
            pnlLeft.Width     = 280;
            pnlLeft.Padding   = new Padding(0, 32, 0, 24);
            pnlLeft.Name      = "pnlLeft";
            pnlLeft.Paint    += (s, e) =>
            {
                using var header = new SolidBrush(Color.FromArgb(125, 91, 66));
                e.Graphics.FillRectangle(header, 0, 0, pnlLeft.Width, 110);
                using var pen = new Pen(Color.FromArgb(230, 224, 218));
                e.Graphics.DrawRectangle(pen, 0, 0, pnlLeft.Width - 1, pnlLeft.Height - 1);
            };

            // picAvatar ─────────────────────────────────────────────────
            picAvatar.Size      = new Size(120, 120);
            picAvatar.SizeMode  = PictureBoxSizeMode.Zoom;
            picAvatar.BackColor = Color.FromArgb(224, 213, 202);
            picAvatar.Location  = new Point((280 - 120) / 2, 36);
            picAvatar.Name      = "picAvatar";
            picAvatar.TabStop   = false;
            // round corners via Paint
            picAvatar.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                using var path = new System.Drawing.Drawing2D.GraphicsPath();
                path.AddEllipse(0, 0, picAvatar.Width - 1, picAvatar.Height - 1);
                e.Graphics.SetClip(path);
            };

            // lblName ───────────────────────────────────────────────────
            lblName.AutoSize  = false;
            lblName.Font      = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblName.ForeColor = Color.FromArgb(60, 40, 20);
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            lblName.Size      = new Size(260, 36);
            lblName.Location  = new Point(10, 170);
            lblName.Name      = "lblName";

            // lblRole ───────────────────────────────────────────────────
            lblRole.AutoSize  = false;
            lblRole.Font      = new Font("Segoe UI", 9F);
            lblRole.ForeColor = Color.FromArgb(100, 80, 60);
            lblRole.TextAlign = ContentAlignment.TopCenter;
            lblRole.Size      = new Size(260, 36);
            lblRole.Location  = new Point(10, 210);
            lblRole.Name      = "lblRole";

            // lblStatus ─────────────────────────────────────────────────
            lblStatus.AutoSize  = false;
            lblStatus.Font      = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatus.ForeColor = Color.FromArgb(27, 134, 100);
            lblStatus.BackColor = Color.FromArgb(224, 247, 240);
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            lblStatus.Size      = new Size(220, 28);
            lblStatus.Location  = new Point(30, 254);
            lblStatus.Text      = "● ĐANG HOẠT ĐỘNG · Ca trực";
            lblStatus.Name      = "lblStatus";

            // lblEmployeeId ─────────────────────────────────────────────
            lblEmployeeId.AutoSize  = false;
            lblEmployeeId.Font      = new Font("Segoe UI", 9F);
            lblEmployeeId.ForeColor = Color.FromArgb(100, 90, 80);
            lblEmployeeId.TextAlign = ContentAlignment.MiddleCenter;
            lblEmployeeId.Size      = new Size(260, 24);
            lblEmployeeId.Location  = new Point(10, 300);
            lblEmployeeId.Name      = "lblEmployeeId";

            // lblJoinDate ───────────────────────────────────────────────
            lblJoinDate.AutoSize  = false;
            lblJoinDate.Font      = new Font("Segoe UI", 9F);
            lblJoinDate.ForeColor = Color.FromArgb(100, 90, 80);
            lblJoinDate.TextAlign = ContentAlignment.MiddleCenter;
            lblJoinDate.Size      = new Size(260, 24);
            lblJoinDate.Location  = new Point(10, 328);
            lblJoinDate.Name      = "lblJoinDate";

            pnlLeft.Controls.Add(picAvatar);
            pnlLeft.Controls.Add(lblName);
            pnlLeft.Controls.Add(lblRole);
            pnlLeft.Controls.Add(lblStatus);
            pnlLeft.Controls.Add(lblEmployeeId);
            pnlLeft.Controls.Add(lblJoinDate);

            // ═══════════════════════════════════════════════════════════════
            // pnlRight  (fill)
            // ═══════════════════════════════════════════════════════════════
            pnlRight.BackColor   = Color.White;
            pnlRight.Dock        = DockStyle.Fill;
            pnlRight.AutoScroll  = true;
            pnlRight.Padding     = new Padding(32, 28, 32, 28);
            pnlRight.Name        = "pnlRight";

            // Title / subtitle ──────────────────────────────────────────
            lblPageTitle.AutoSize  = false;
            lblPageTitle.Font      = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblPageTitle.ForeColor = Color.FromArgb(60, 40, 20);
            lblPageTitle.Size      = new Size(680, 40);
            lblPageTitle.Location  = new Point(32, 28);
            lblPageTitle.Text      = "Thông tin cá nhân & Tài khoản người dùng";
            lblPageTitle.Name      = "lblPageTitle";

            lblPageSubtitle.AutoSize  = false;
            lblPageSubtitle.Font      = new Font("Segoe UI", 9.5F);
            lblPageSubtitle.ForeColor = Color.FromArgb(110, 95, 80);
            lblPageSubtitle.Size      = new Size(680, 24);
            lblPageSubtitle.Location  = new Point(32, 74);
            lblPageSubtitle.Text      = "Chỉnh sửa thông tin liên lạc và thiết lập tài khoản của bạn.";
            lblPageSubtitle.Name      = "lblPageSubtitle";

            // ── Grid row 1: Họ và tên | Tên đăng nhập ──────────────────
            int col1X = 32, col2X = 374, colW = 310, row1Y = 112;

            MakeLabel(lblFullNameLabel, "Họ và tên", col1X, row1Y);
            MakeTxtBox(txtFullName, col1X, row1Y + 26, colW);

            MakeLabel(lblUsernameLabel, "Tên đăng nhập", col2X, row1Y);
            lblUsernameNote.AutoSize  = false;
            lblUsernameNote.Font      = new Font("Segoe UI", 8F);
            lblUsernameNote.ForeColor = Color.FromArgb(140, 120, 100);
            lblUsernameNote.Size      = new Size(130, 20);
            lblUsernameNote.Location  = new Point(col2X + colW - 130, row1Y + 2);
            lblUsernameNote.Text      = "⊘ Không thể sửa";
            lblUsernameNote.Name      = "lblUsernameNote";

            MakeTxtBox(txtUsername, col2X, row1Y + 26, colW);
            txtUsername.ReadOnly    = true;
            txtUsername.BackColor   = Color.FromArgb(242, 240, 237);
            txtUsername.ForeColor   = Color.FromArgb(120, 100, 80);

            // ── Grid row 2: Vai trò | Số điện thoại ────────────────────
            int row2Y = row1Y + 92;
            MakeLabel(lblRoleLabel,  "Vai trò",         col1X, row2Y);
            MakeTxtBox(txtRole,      col1X, row2Y + 26, colW);
            txtRole.ReadOnly  = true;
            txtRole.BackColor = Color.FromArgb(242, 240, 237);

            MakeLabel(lblPhoneLabel, "Số điện thoại",   col2X, row2Y);
            MakeTxtBox(txtPhone,     col2X, row2Y + 26, colW);

            // ── Grid row 3: Email (full width) ──────────────────────────
            int row3Y = row2Y + 92;
            MakeLabel(lblEmailLabel, "Email", col1X, row3Y);
            MakeTxtBox(txtEmail, col1X, row3Y + 26, colW * 2 + (col2X - col1X - colW));

            // ── Grid row 4: Ca làm việc (full width, readonly) ──────────
            int row4Y = row3Y + 92;
            MakeLabel(lblShiftLabel, "Ca làm việc", col1X, row4Y);
            MakeTxtBox(txtShift, col1X, row4Y + 26, colW * 2 + (col2X - col1X - colW));
            txtShift.ReadOnly  = true;
            txtShift.BackColor = Color.FromArgb(242, 240, 237);

            lblShiftNote.AutoSize  = false;
            lblShiftNote.Font      = new Font("Segoe UI", 8.5F);
            lblShiftNote.ForeColor = Color.FromArgb(120, 100, 80);
            lblShiftNote.Size      = new Size(630, 20);
            lblShiftNote.Location  = new Point(col1X, row4Y + 76);
            lblShiftNote.Text      = "🗓 Vui lòng liên hệ Quản lý để thay đổi ca làm việc.";
            lblShiftNote.Name      = "lblShiftNote";

            // ── Buttons row ─────────────────────────────────────────────
            int btnRowY = row4Y + 110;

            btnChangePassword.FlatStyle            = FlatStyle.Flat;
            btnChangePassword.FlatAppearance.BorderColor = Color.FromArgb(180, 155, 130);
            btnChangePassword.BackColor            = Color.White;
            btnChangePassword.ForeColor            = Color.FromArgb(85, 55, 34);
            btnChangePassword.Font                 = new Font("Segoe UI", 9.5F);
            btnChangePassword.Text                 = "⇔ Đổi mật khẩu";
            btnChangePassword.Size                 = new Size(160, 36);
            btnChangePassword.Location             = new Point(col1X, btnRowY);
            btnChangePassword.Name                 = "btnChangePassword";
            btnChangePassword.Cursor               = Cursors.Hand;
            btnChangePassword.Click               += btnChangePassword_Click;

            btnCancel.FlatStyle            = FlatStyle.Flat;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(180, 155, 130);
            btnCancel.BackColor            = Color.White;
            btnCancel.ForeColor            = Color.FromArgb(85, 55, 34);
            btnCancel.Font                 = new Font("Segoe UI", 9.5F);
            btnCancel.Text                 = "Hủy bỏ";
            btnCancel.Size                 = new Size(110, 36);
            btnCancel.Location             = new Point(col2X + colW - 234, btnRowY);
            btnCancel.Name                 = "btnCancel";
            btnCancel.Cursor               = Cursors.Hand;
            btnCancel.Click               += btnCancel_Click;

            btnSave.FlatStyle            = FlatStyle.Flat;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.BackColor            = Color.FromArgb(85, 55, 34);
            btnSave.ForeColor            = Color.White;
            btnSave.Font                 = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSave.Text                 = "✓ Lưu thay đổi";
            btnSave.Size                 = new Size(140, 36);
            btnSave.Location             = new Point(col2X + colW - 140, btnRowY);
            btnSave.Name                 = "btnSave";
            btnSave.Cursor               = Cursors.Hand;
            btnSave.Click               += btnSave_Click;

            // ── lblMessage ──────────────────────────────────────────────
            lblMessage.AutoSize  = false;
            lblMessage.Font      = new Font("Segoe UI", 9.5F);
            lblMessage.Size      = new Size(650, 28);
            lblMessage.Location  = new Point(col1X, btnRowY + 48);
            lblMessage.Name      = "lblMessage";

            // Add all to pnlRight
            pnlRight.Controls.AddRange(new Control[]
            {
                lblPageTitle, lblPageSubtitle,
                lblFullNameLabel, txtFullName,
                lblUsernameLabel, lblUsernameNote, txtUsername,
                lblRoleLabel, txtRole,
                lblPhoneLabel, txtPhone,
                lblEmailLabel, txtEmail,
                lblShiftLabel, txtShift, lblShiftNote,
                btnChangePassword, btnCancel, btnSave,
                lblMessage
            });

            // ── Add panels to UserControl ────────────────────────────────
            Controls.Add(pnlRight);
            Controls.Add(pnlLeft);

            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            pnlLeft.ResumeLayout(false);
            pnlRight.ResumeLayout(false);
            ResumeLayout(false);
        }

        // ── Helpers ─────────────────────────────────────────────────────
        private static void MakeLabel(Label lbl, string text, int x, int y)
        {
            lbl.AutoSize  = false;
            lbl.Font      = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lbl.ForeColor = Color.FromArgb(70, 50, 30);
            lbl.Size      = new Size(310, 22);
            lbl.Location  = new Point(x, y);
            lbl.Text      = text;
        }

        private static void MakeTxtBox(TextBox txt, int x, int y, int w)
        {
            txt.BorderStyle = BorderStyle.FixedSingle;
            txt.Font        = new Font("Segoe UI", 10.5F);
            txt.Size        = new Size(w, 36);
            txt.Location    = new Point(x, y);
        }
    }
}
