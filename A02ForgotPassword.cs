using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DoAnLapTrinhTrucQuan
{
    public partial class A02ForgotPassword : Form
    {
        private bool _isStep2 = false;

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public A02ForgotPassword()
        {
            InitializeComponent();
            ShowStep1();

            // Allow dragging the borderless form via pnlMain
            pnlMain.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(this.Handle, 0xA1, 2, 0);
                }
            };
        }

        private void ShowStep1()
        {
            _isStep2 = false;
            stepOne.Visible = true;
            stepTwo.Visible = false;
        }

        private void ShowStep2()
        {
            _isStep2 = true;
            stepOne.Visible = false;
            stepTwo.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSendOTP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFPUsername.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFPUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFPContact.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại hoặc email.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFPContact.Focus();
                return;
            }

            using (A02_2OTP formOTP = new A02_2OTP(txtFPContact.Text.Trim()))
            {
                DialogResult result;
                Opacity = 0.62;
                try
                {
                    result = formOTP.ShowDialog(this);
                }
                finally
                {
                    Opacity = 1;
                }

                if (result == DialogResult.OK)
                {
                    ShowStep2();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ShowStep1();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string newPassword = txtNewPassword.Text.Trim();
            if (newPassword.Length < 8 ||
                !System.Text.RegularExpressions.Regex.IsMatch(newPassword, "[A-Z]") ||
                !System.Text.RegularExpressions.Regex.IsMatch(newPassword, "[0-9]"))
            {
                MessageBox.Show("Mật khẩu mới cần ít nhất 8 ký tự, gồm chữ hoa và số.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPassword.Focus();
                return;
            }

            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp. Vui lòng nhập lại.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Focus();
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnToggleNewPwd_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.PasswordChar == '\0')
            {
                txtNewPassword.PasswordChar = '•';
            }
            else
            {
                txtNewPassword.PasswordChar = '\0';
            }
        }

        private void btnToggleConfirmPwd_Click(object sender, EventArgs e)
        {
            if (txtConfirmPassword.PasswordChar == '\0')
            {
                txtConfirmPassword.PasswordChar = '•';
            }
            else
            {
                txtConfirmPassword.PasswordChar = '\0';
            }
        }
    }
}
