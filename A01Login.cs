using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DoAnLapTrinhTrucQuan
{
    public partial class A01Login : Form
    {
        /// <summary>Tên / email đăng nhập thành công, dùng bởi Program.cs</summary>
        public string LoggedInUsername { get; private set; } = string.Empty;

        public A01Login()
        {
            InitializeComponent();
            btnLogin.Click += btnLogin_Click;
            btnTogglePassword.Click += btnTogglePassword_Click;
            btnCloseError.Click += (_, _) => pnlError.Visible = false;
            lnkForgotPassword.LinkClicked += lnkForgotPassword_LinkClicked;
            AcceptButton = btnLogin;
            workspace_Resize(this, EventArgs.Empty);
        }

        private void workspace_Resize(object? sender, EventArgs e)
        {
            card.Location = new Point(
                Math.Max(0, (workspace.Width - card.Width) / 2),
                Math.Max(0, (workspace.Height - card.Height) / 2));
        }

        private void btnLogin_Click(object? sender, EventArgs e)
        {
            const string demoUsername = "an.tran";
            const string demoPassword = "Cafe@123";

            if (string.Equals(txtUsername.Text.Trim(), demoUsername, StringComparison.OrdinalIgnoreCase) &&
                txtPassword.Text == demoPassword)
            {
                LoggedInUsername = "Trần Văn An";
                DialogResult = DialogResult.OK;
                Close();
                return;
            }

            lblErrorMsg.Text = "Tên đăng nhập hoặc mật khẩu không chính xác.";
            pnlError.Visible = true;
            txtPassword.Clear();
            txtPassword.Focus();
        }

        private void btnTogglePassword_Click(object? sender, EventArgs e)
        {
            txtPassword.PasswordChar = txtPassword.PasswordChar == '\0' ? '•' : '\0';
        }

        private void lnkForgotPassword_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            using var dialog = new A02ForgotPassword();
            dialog.ShowDialog(this);
        }
    }
}
