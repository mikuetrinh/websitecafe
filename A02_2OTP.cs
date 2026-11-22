using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DoAnLapTrinhTrucQuan
{
    public partial class A02_2OTP : Form
    {
        private System.Windows.Forms.Timer _countdownTimer;
        private int _secondsLeft = 60;

        public A02_2OTP() : this("số *** *** 678")
        {
        }

        public A02_2OTP(string recipient)
        {
            InitializeComponent();
            lblOTPSubtitle.Text = $"Mã gồm 6 số đã được gửi đến {MaskRecipient(recipient)}";
            CancelButton = btnCancel;
            AcceptButton = btnConfirm;

            _countdownTimer = new System.Windows.Forms.Timer();
            _countdownTimer.Interval = 1000;
            _countdownTimer.Tick += CountdownTimer_Tick;
            _countdownTimer.Start();

            foreach (var box in otpBoxes)
                box.KeyPress += OtpBox_KeyPress;
        }

        private void OtpBox_KeyPress(object? sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private static string MaskRecipient(string recipient)
        {
            if (recipient.Contains('@'))
            {
                int atIndex = recipient.IndexOf('@');
                string visibleStart = recipient.Length > 0 ? recipient[..1] : string.Empty;
                return $"email {visibleStart}***{recipient[atIndex..]}";
            }

            string digits = new string(recipient.Where(char.IsDigit).ToArray());
            if (digits.Length < 4)
                return "số điện thoại đã đăng ký";

            return $"số *** *** {digits[^3..]}";
        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            _secondsLeft--;
            if (_secondsLeft > 0)
            {
                lblCountdown.Text = $"Mã hết hạn sau {_secondsLeft / 60:D2}:{_secondsLeft % 60:D2}";
                lblCountdown.ForeColor = Color.FromArgb(220, 50, 50);
            }
            else
            {
                _countdownTimer.Stop();
                lblCountdown.Text = "Mã đã hết hạn";
                lblCountdown.ForeColor = Color.FromArgb(220, 50, 50);
                btnConfirm.Enabled = false;
            }
        }

        private void OtpBox_TextChanged(object sender, EventArgs e)
        {
            var box = (System.Windows.Forms.TextBox)sender;
            int index = Array.IndexOf(otpBoxes, box);

            if (box.Text.Length > 1)
            {
                box.Text = box.Text.Substring(0, 1);
                box.SelectionStart = 1;
            }

            if (box.Text.Length == 1 && !char.IsDigit(box.Text[0]))
            {
                box.Clear();
                return;
            }

            if (box.Text.Length == 1 && index < 5)
            {
                otpBoxes[index + 1].Focus();
            }
        }

        private void OtpBox_KeyDown(object sender, KeyEventArgs e)
        {
            var box = (System.Windows.Forms.TextBox)sender;
            int index = Array.IndexOf(otpBoxes, box);

            if (e.KeyCode == Keys.Back && box.Text.Length == 0 && index > 0)
            {
                otpBoxes[index - 1].Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _countdownTimer.Stop();
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string otp = string.Concat(otpBoxes.Select(t => t.Text));

            if (otp.Length < 6)
            {
                MessageBox.Show("Vui lòng nhập đủ 6 chữ số OTP.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (otp != "123456")
            {
                MessageBox.Show("Mã OTP không chính xác. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _countdownTimer.Stop();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void lnkResend_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _secondsLeft = 60;
            _countdownTimer.Start();
            lblCountdown.Text = "Mã hết hạn sau 01:00";
            btnConfirm.Enabled = true;

            foreach (var box in otpBoxes)
            {
                box.Text = string.Empty;
            }

            otpBoxes[0].Focus();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _countdownTimer.Stop();
            base.OnFormClosing(e);
        }
    }
}
