namespace DoAnLapTrinhTrucQuan
{
    partial class A04ChangePassword
    {
        private System.ComponentModel.IContainer? components = null;

        // ── Controls ─────────────────────────────────────────────────────
        private Panel   pnlHeader          = null!;
        private Label   lblTitle           = null!;
        private Button  btnClose           = null!;

        private Panel   pnlInfo            = null!;
        private Label   lblInfoText        = null!;

        // Current password row
        private Panel   pnlRowCurrent      = null!;
        private Label   lblCurrentPwd      = null!;
        private LinkLabel lnkForgot        = null!;
        private Panel   pnlCurrentInput    = null!;
        private TextBox txtCurrentPassword = null!;
        private Button  btnEye1            = null!;
        private Label   lblErrorCurrent    = null!;

        // New password row
        private Label   lblNewPwd          = null!;
        private Panel   pnlNewInput        = null!;
        private TextBox txtNewPassword     = null!;
        private Button  btnEye2            = null!;
        private Label   lblErrorNew        = null!;

        // Confirm row
        private Label   lblConfirmPwd      = null!;
        private Panel   pnlConfirmInput    = null!;
        private TextBox txtConfirmPassword = null!;
        private Button  btnEye3            = null!;
        private Label   lblErrorConfirm    = null!;
        private Label   lblMatchMessage    = null!;

        // Action buttons
        private Button  btnCancelChange    = null!;
        private Button  btnConfirmChange   = null!;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlHeader          = new Panel();
            lblTitle           = new Label();
            btnClose           = new Button();
            pnlInfo            = new Panel();
            lblInfoText        = new Label();
            pnlRowCurrent      = new Panel();
            lblCurrentPwd      = new Label();
            lnkForgot          = new LinkLabel();
            pnlCurrentInput    = new Panel();
            txtCurrentPassword = new TextBox();
            btnEye1            = new Button();
            lblErrorCurrent    = new Label();
            lblNewPwd          = new Label();
            pnlNewInput        = new Panel();
            txtNewPassword     = new TextBox();
            btnEye2            = new Button();
            lblErrorNew        = new Label();
            lblConfirmPwd      = new Label();
            pnlConfirmInput    = new Panel();
            txtConfirmPassword = new TextBox();
            btnEye3            = new Button();
            lblErrorConfirm    = new Label();
            lblMatchMessage    = new Label();
            btnCancelChange    = new Button();
            btnConfirmChange   = new Button();

            pnlHeader.SuspendLayout();
            pnlInfo.SuspendLayout();
            SuspendLayout();

            // ── Form ────────────────────────────────────────────────────
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode       = AutoScaleMode.Font;
            BackColor           = Color.White;
            ClientSize          = new Size(520, 480);
            FormBorderStyle     = FormBorderStyle.FixedSingle;
            MaximizeBox         = false;
            MinimizeBox         = false;
            Name                = "A04ChangePassword";
            StartPosition       = FormStartPosition.CenterParent;
            Text                = "Đổi mật khẩu";

            // ── pnlHeader ───────────────────────────────────────────────
            pnlHeader.BackColor = Color.White;
            pnlHeader.Dock      = DockStyle.Top;
            pnlHeader.Height    = 56;
            pnlHeader.Name      = "pnlHeader";
            pnlHeader.Padding   = new Padding(20, 0, 8, 0);

            lblTitle.AutoSize  = false;
            lblTitle.Font      = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(60, 40, 20);
            lblTitle.Dock      = DockStyle.Fill;
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            lblTitle.Text      = "Đổi mật khẩu tài khoản";
            lblTitle.Name      = "lblTitle";

            btnClose.FlatStyle             = FlatStyle.Flat;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.BackColor             = Color.White;
            btnClose.ForeColor             = Color.FromArgb(100, 80, 60);
            btnClose.Font                  = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClose.Text                  = "×";
            btnClose.Size                  = new Size(40, 40);
            btnClose.Dock                  = DockStyle.Right;
            btnClose.Name                  = "btnClose";
            btnClose.Cursor                = Cursors.Hand;
            btnClose.Click                += btnClose_Click;

            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(btnClose);

            // ── pnlInfo (blue-tinted hint) ──────────────────────────────
            pnlInfo.BackColor = Color.FromArgb(240, 249, 255);
            pnlInfo.Bounds    = new Rectangle(20, 64, 476, 52);
            pnlInfo.Name      = "pnlInfo";

            lblInfoText.AutoSize  = false;
            lblInfoText.Dock      = DockStyle.Fill;
            lblInfoText.Font      = new Font("Segoe UI", 9F);
            lblInfoText.ForeColor = Color.FromArgb(30, 100, 160);
            lblInfoText.TextAlign = ContentAlignment.MiddleLeft;
            lblInfoText.Padding   = new Padding(8, 0, 8, 0);
            lblInfoText.Text      = "⚹  Mật khẩu mới phải có tối thiểu 8 ký tự, bao gồm chữ hoa, chữ thường và chữ số.";
            lblInfoText.Name      = "lblInfoText";

            pnlInfo.Controls.Add(lblInfoText);

            // ── Current password ────────────────────────────────────────
            int x = 20, fieldW = 476, y = 128;

            pnlRowCurrent.Bounds = new Rectangle(x, y, fieldW, 22);
            pnlRowCurrent.Name   = "pnlRowCurrent";

            lblCurrentPwd.AutoSize  = false;
            lblCurrentPwd.Dock      = DockStyle.Left;
            lblCurrentPwd.Width     = 240;
            lblCurrentPwd.Font      = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblCurrentPwd.ForeColor = Color.FromArgb(60, 40, 20);
            lblCurrentPwd.TextAlign = ContentAlignment.MiddleLeft;
            lblCurrentPwd.Text      = "Mật khẩu hiện tại *";
            lblCurrentPwd.Name      = "lblCurrentPwd";

            lnkForgot.AutoSize         = false;
            lnkForgot.Dock             = DockStyle.Fill;
            lnkForgot.TextAlign        = ContentAlignment.MiddleRight;
            lnkForgot.Font             = new Font("Segoe UI", 9F);
            lnkForgot.Text             = "Quên mật khẩu?";
            lnkForgot.LinkColor        = Color.FromArgb(100, 70, 40);
            lnkForgot.Name             = "lnkForgot";

            pnlRowCurrent.Controls.Add(lnkForgot);
            pnlRowCurrent.Controls.Add(lblCurrentPwd);

            MakePasswordRow(out pnlCurrentInput, out txtCurrentPassword, out btnEye1,
                x, y + 28, fieldW, "txtCurrentPassword", "btnEye1");
            btnEye1.Click += btnEye1_Click;

            lblErrorCurrent.AutoSize  = false;
            lblErrorCurrent.Font      = new Font("Segoe UI", 8.5F);
            lblErrorCurrent.ForeColor = Color.Firebrick;
            lblErrorCurrent.Bounds    = new Rectangle(x, y + 72, fieldW, 18);
            lblErrorCurrent.Name      = "lblErrorCurrent";
            lblErrorCurrent.Visible   = false;

            // ── New password ─────────────────────────────────────────────
            y += 100;
            lblNewPwd.AutoSize  = false;
            lblNewPwd.Font      = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblNewPwd.ForeColor = Color.FromArgb(60, 40, 20);
            lblNewPwd.Bounds    = new Rectangle(x, y, fieldW, 22);
            lblNewPwd.Text      = "Mật khẩu mới *";
            lblNewPwd.Name      = "lblNewPwd";

            MakePasswordRow(out pnlNewInput, out txtNewPassword, out btnEye2,
                x, y + 28, fieldW, "txtNewPassword", "btnEye2");
            btnEye2.Click += btnEye2_Click;

            lblErrorNew.AutoSize  = false;
            lblErrorNew.Font      = new Font("Segoe UI", 8.5F);
            lblErrorNew.ForeColor = Color.Firebrick;
            lblErrorNew.Bounds    = new Rectangle(x, y + 72, fieldW, 18);
            lblErrorNew.Name      = "lblErrorNew";
            lblErrorNew.Visible   = false;

            // ── Confirm password ─────────────────────────────────────────
            y += 100;
            lblConfirmPwd.AutoSize  = false;
            lblConfirmPwd.Font      = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblConfirmPwd.ForeColor = Color.FromArgb(60, 40, 20);
            lblConfirmPwd.Bounds    = new Rectangle(x, y, fieldW, 22);
            lblConfirmPwd.Text      = "Nhập lại mật khẩu mới *";
            lblConfirmPwd.Name      = "lblConfirmPwd";

            MakePasswordRow(out pnlConfirmInput, out txtConfirmPassword, out btnEye3,
                x, y + 28, fieldW, "txtConfirmPassword", "btnEye3");
            btnEye3.Click += btnEye3_Click;
            txtConfirmPassword.TextChanged += txtConfirmPassword_TextChanged;

            lblErrorConfirm.AutoSize  = false;
            lblErrorConfirm.Font      = new Font("Segoe UI", 8.5F);
            lblErrorConfirm.ForeColor = Color.Firebrick;
            lblErrorConfirm.Bounds    = new Rectangle(x, y + 72, fieldW, 18);
            lblErrorConfirm.Name      = "lblErrorConfirm";
            lblErrorConfirm.Visible   = false;

            lblMatchMessage.AutoSize  = false;
            lblMatchMessage.Font      = new Font("Segoe UI", 8.5F);
            lblMatchMessage.ForeColor = Color.FromArgb(27, 134, 100);
            lblMatchMessage.Bounds    = new Rectangle(x, y + 72, fieldW, 18);
            lblMatchMessage.Text      = "✓ Mật khẩu xác nhận khớp";
            lblMatchMessage.Name      = "lblMatchMessage";
            lblMatchMessage.Visible   = false;

            // ── Action buttons ───────────────────────────────────────────
            y += 102;
            btnCancelChange.FlatStyle            = FlatStyle.Flat;
            btnCancelChange.FlatAppearance.BorderColor = Color.FromArgb(180, 155, 130);
            btnCancelChange.BackColor            = Color.White;
            btnCancelChange.ForeColor            = Color.FromArgb(85, 55, 34);
            btnCancelChange.Font                 = new Font("Segoe UI", 9.5F);
            btnCancelChange.Text                 = "× Hủy bỏ";
            btnCancelChange.Bounds               = new Rectangle(x, y, 140, 36);
            btnCancelChange.Name                 = "btnCancelChange";
            btnCancelChange.Cursor               = Cursors.Hand;
            btnCancelChange.Click               += btnCancelChange_Click;

            btnConfirmChange.FlatStyle            = FlatStyle.Flat;
            btnConfirmChange.FlatAppearance.BorderSize = 0;
            btnConfirmChange.BackColor            = Color.FromArgb(85, 55, 34);
            btnConfirmChange.ForeColor            = Color.White;
            btnConfirmChange.Font                 = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnConfirmChange.Text                 = "✓ Xác nhận đổi mật khẩu";
            btnConfirmChange.Bounds               = new Rectangle(x + 496 - 220, y, 220, 36);
            btnConfirmChange.Name                 = "btnConfirmChange";
            btnConfirmChange.Cursor               = Cursors.Hand;
            btnConfirmChange.Click               += btnConfirmChange_Click;

            // ── Add all controls ─────────────────────────────────────────
            Controls.AddRange(new Control[]
            {
                pnlHeader,
                pnlInfo,
                pnlRowCurrent,
                pnlCurrentInput, lblErrorCurrent,
                lblNewPwd,
                pnlNewInput, lblErrorNew,
                lblConfirmPwd,
                pnlConfirmInput, lblErrorConfirm, lblMatchMessage,
                btnCancelChange, btnConfirmChange
            });

            pnlHeader.ResumeLayout(false);
            pnlInfo.ResumeLayout(false);
            ResumeLayout(false);
        }

        // ── Helper: build a password text box with eye toggle ────────────
        private static void MakePasswordRow(
            out Panel container, out TextBox txt, out Button eye,
            int x, int y, int w,
            string txtName, string eyeName)
        {
            container          = new Panel();
            txt                = new TextBox();
            eye                = new Button();

            container.Bounds   = new Rectangle(x, y, w, 36);
            container.Name     = txtName + "Panel";
            container.BorderStyle = BorderStyle.FixedSingle;

            txt.BorderStyle    = BorderStyle.None;
            txt.Font           = new Font("Segoe UI", 10.5F);
            txt.Dock           = DockStyle.Fill;
            txt.UseSystemPasswordChar = true;
            txt.Name           = txtName;
            txt.Padding        = new Padding(4, 0, 0, 0);

            eye.FlatStyle             = FlatStyle.Flat;
            eye.FlatAppearance.BorderSize = 0;
            eye.BackColor             = Color.White;
            eye.Text                  = "👁";
            eye.Size                  = new Size(36, 34);
            eye.Dock                  = DockStyle.Right;
            eye.Name                  = eyeName;
            eye.Cursor                = Cursors.Hand;

            container.Controls.Add(txt);
            container.Controls.Add(eye);
        }
    }
}
