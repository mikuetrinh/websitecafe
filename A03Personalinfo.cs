using System.Text.RegularExpressions;

namespace DoAnLapTrinhTrucQuan
{
    public partial class A03Personalinfo : UserControl
    {
        // ── Dữ liệu mẫu (hardcode) ──────────────────────────────────────
        private string fullName  = "Trần Văn An";
        private string username  = "an.tran";
        private string role      = "Nhân viên";
        private string phone     = "0912 345 678";
        private string email     = "tranvanan.pos@lltqcafe.vn";
        private string shift     = "Ca sáng (06:30 - 14:30)";
        private string employeeId = "NV-202308-042";
        private string joinDate  = "15/08/2023";

        public string DisplayName => fullName;

        public event Action<string, string>? ProfileUpdated; // (fullName, email)

        public A03Personalinfo()
        {
            InitializeComponent();
            picAvatar.Image = Properties.Resources.Background__1_;
            LoadData();
        }

        // ── Nạp dữ liệu vào form ────────────────────────────────────────
        private void LoadData()
        {
            lblName.Text        = fullName;
            lblRole.Text        = "Thu ngân chính / Nhân viên bán hàng";
            lblEmployeeId.Text  = "Mã NV: " + employeeId;
            lblJoinDate.Text    = "Ngày vào: " + joinDate;

            txtFullName.Text  = fullName;
            txtUsername.Text  = username;
            txtRole.Text      = role;
            txtPhone.Text     = phone;
            txtEmail.Text     = email;
            txtShift.Text     = shift;
        }

        // ── Lưu thay đổi ────────────────────────────────────────────────
        private void btnSave_Click(object sender, EventArgs e)
        {
            string newName  = txtFullName.Text.Trim();
            string newPhone = txtPhone.Text.Trim();
            string newEmail = txtEmail.Text.Trim();

            if (newName.Length < 2)
            {
                ShowMessage("Họ và tên phải có ít nhất 2 ký tự.", isError: true);
                return;
            }
            if (string.IsNullOrWhiteSpace(newPhone))
            {
                ShowMessage("Số điện thoại không được để trống.", isError: true);
                return;
            }
            if (!IsValidEmail(newEmail))
            {
                ShowMessage("Địa chỉ email không hợp lệ.", isError: true);
                return;
            }

            fullName = newName;
            phone    = newPhone;
            email    = newEmail;

            lblName.Text     = fullName;
            txtFullName.Text = fullName;
            txtPhone.Text    = phone;
            txtEmail.Text    = email;

            ProfileUpdated?.Invoke(fullName, email);
            ShowMessage("✓ Thông tin đã được lưu thành công.", isError: false);
        }

        // ── Hủy bỏ ──────────────────────────────────────────────────────
        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadData();
            lblMessage.Text = string.Empty;
        }

        // ── Đổi mật khẩu ────────────────────────────────────────────────
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            using var dlg = new A04ChangePassword();
            dlg.ShowDialog(this.FindForm());
        }

        // ── Hiện thông báo ───────────────────────────────────────────────
        private void ShowMessage(string text, bool isError)
        {
            lblMessage.Text      = text;
            lblMessage.ForeColor = isError
                ? Color.Firebrick
                : Color.FromArgb(46, 125, 50);
        }

        private static bool IsValidEmail(string s) =>
            Regex.IsMatch(s, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
    }
}
