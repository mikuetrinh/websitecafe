namespace DoAnLapTrinhTrucQuan
{
    /// <summary>
    /// Form dialog "Đổi mật khẩu tài khoản".
    /// Demo password: Cafe@123
    /// Closes with DialogResult.OK on success.
    /// </summary>
    public partial class A04ChangePassword : Form
    {
        private const string DemoCurrentPassword = "Cafe@123";

        public A04ChangePassword()
        {
            InitializeComponent();
        }

        // ── Toggle eye icons ─────────────────────────────────────────────
        private void ToggleEye(TextBox txt, Button btn)
        {
            txt.UseSystemPasswordChar = !txt.UseSystemPasswordChar;
            btn.Text = txt.UseSystemPasswordChar ? "👁" : "🙈";
        }

        private void btnEye1_Click(object sender, EventArgs e) => ToggleEye(txtCurrentPassword, btnEye1);
        private void btnEye2_Click(object sender, EventArgs e) => ToggleEye(txtNewPassword, btnEye2);
        private void btnEye3_Click(object sender, EventArgs e) => ToggleEye(txtConfirmPassword, btnEye3);

        // ── Live confirm match check ─────────────────────────────────────
        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            bool match = txtConfirmPassword.Text.Length > 0 &&
                         txtConfirmPassword.Text == txtNewPassword.Text;
            lblMatchMessage.Visible   = match;
        }

        // ── Close button ─────────────────────────────────────────────────
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        // ── Hủy bỏ ──────────────────────────────────────────────────────
        private void btnCancelChange_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        // ── Xác nhận đổi mật khẩu ───────────────────────────────────────
        private void btnConfirmChange_Click(object sender, EventArgs e)
        {
            lblErrorCurrent.Visible = false;
            lblErrorNew.Visible     = false;
            lblErrorConfirm.Visible = false;

            bool ok = true;

            if (txtCurrentPassword.Text != DemoCurrentPassword)
            {
                lblErrorCurrent.Text    = "Mật khẩu hiện tại không đúng.";
                lblErrorCurrent.Visible = true;
                ok = false;
            }

            if (txtNewPassword.Text.Length < 8 ||
                !System.Text.RegularExpressions.Regex.IsMatch(txtNewPassword.Text, @"[A-Z]") ||
                !System.Text.RegularExpressions.Regex.IsMatch(txtNewPassword.Text, @"[a-z]") ||
                !System.Text.RegularExpressions.Regex.IsMatch(txtNewPassword.Text, @"[0-9]"))
            {
                lblErrorNew.Text    = "Mật khẩu mới chưa đủ yêu cầu (≥8 ký tự, chữ hoa, chữ thường, số).";
                lblErrorNew.Visible = true;
                ok = false;
            }

            if (txtConfirmPassword.Text != txtNewPassword.Text)
            {
                lblErrorConfirm.Text    = "Mật khẩu xác nhận không khớp.";
                lblErrorConfirm.Visible = true;
                ok = false;
            }

            if (ok)
            {
                MessageBox.Show("Đổi mật khẩu thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
