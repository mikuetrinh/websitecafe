namespace DoAnLapTrinhTrucQuan
{
    partial class A02ForgotPassword
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.stepOne = new System.Windows.Forms.Panel();
            this.lblFPTitle = new System.Windows.Forms.Label();
            this.lblFPSubtitle = new System.Windows.Forms.Label();
            this.lblFPUsernameLabel = new System.Windows.Forms.Label();
            this.pnlFPUsername = new System.Windows.Forms.Panel();
            this.txtFPUsername = new System.Windows.Forms.TextBox();
            this.lblFPContactLabel = new System.Windows.Forms.Label();
            this.pnlFPContact = new System.Windows.Forms.Panel();
            this.txtFPContact = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSendOTP = new System.Windows.Forms.Button();
            this.stepTwo = new System.Windows.Forms.Panel();
            this.lblRPTitle = new System.Windows.Forms.Label();
            this.lblRPSubtitle = new System.Windows.Forms.Label();
            this.lblNewPwdLabel = new System.Windows.Forms.Label();
            this.pnlNewPwd = new System.Windows.Forms.Panel();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.btnToggleNewPwd = new System.Windows.Forms.Button();
            this.lblConfirmPwdLabel = new System.Windows.Forms.Label();
            this.pnlConfirmPwd = new System.Windows.Forms.Panel();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnToggleConfirmPwd = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();

            this.pnlMain.SuspendLayout();
            this.stepOne.SuspendLayout();
            this.pnlFPUsername.SuspendLayout();
            this.pnlFPContact.SuspendLayout();
            this.stepTwo.SuspendLayout();
            this.pnlNewPwd.SuspendLayout();
            this.pnlConfirmPwd.SuspendLayout();
            this.SuspendLayout();

            // ─────────────────────────────────────────────
            // pnlMain  (outer card; 10px offset creates shadow illusion)
            // ─────────────────────────────────────────────
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Location = new System.Drawing.Point(20, 56);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(440, 340);
            this.pnlMain.TabIndex = 0;

            // ─────────────────────────────────────────────
            // stepOne
            // ─────────────────────────────────────────────
            this.stepOne.BackColor = System.Drawing.Color.White;
            this.stepOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stepOne.Name = "stepOne";
            this.stepOne.TabIndex = 0;
            this.stepOne.Visible = true;

            // lblFPTitle
            this.lblFPTitle.AutoSize = true;
            this.lblFPTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblFPTitle.ForeColor = System.Drawing.Color.FromArgb(86, 57, 39);
            this.lblFPTitle.Location = new System.Drawing.Point(24, 20);
            this.lblFPTitle.Name = "lblFPTitle";
            this.lblFPTitle.Text = "Quên mật khẩu";

            // lblFPSubtitle
            this.lblFPSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFPSubtitle.ForeColor = System.Drawing.Color.Gray;
            this.lblFPSubtitle.Location = new System.Drawing.Point(24, 59);
            this.lblFPSubtitle.Name = "lblFPSubtitle";
            this.lblFPSubtitle.Size = new System.Drawing.Size(392, 40);
            this.lblFPSubtitle.Text = "Nhập tên đăng nhập và số điện thoại hoặc email đã đăng ký để nhận mã OTP.";

            // lblFPUsernameLabel
            this.lblFPUsernameLabel.AutoSize = true;
            this.lblFPUsernameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFPUsernameLabel.Location = new System.Drawing.Point(24, 112);
            this.lblFPUsernameLabel.Name = "lblFPUsernameLabel";
            this.lblFPUsernameLabel.Text = "Tên đăng nhập";

            // pnlFPUsername
            this.pnlFPUsername.BackColor = System.Drawing.Color.White;
            this.pnlFPUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFPUsername.Location = new System.Drawing.Point(24, 137);
            this.pnlFPUsername.Name = "pnlFPUsername";
            this.pnlFPUsername.Size = new System.Drawing.Size(392, 38);
            this.pnlFPUsername.TabIndex = 1;

            // txtFPUsername
            this.txtFPUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFPUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFPUsername.Location = new System.Drawing.Point(10, 8);
            this.txtFPUsername.Name = "txtFPUsername";
            this.txtFPUsername.PlaceholderText = "Nhập tên đăng nhập";
            this.txtFPUsername.Size = new System.Drawing.Size(370, 22);
            this.txtFPUsername.TabIndex = 0;

            // lblFPContactLabel
            this.lblFPContactLabel.AutoSize = true;
            this.lblFPContactLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFPContactLabel.Location = new System.Drawing.Point(24, 192);
            this.lblFPContactLabel.Name = "lblFPContactLabel";
            this.lblFPContactLabel.Text = "Số điện thoại hoặc email";

            // pnlFPContact
            this.pnlFPContact.BackColor = System.Drawing.Color.White;
            this.pnlFPContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFPContact.Location = new System.Drawing.Point(24, 215);
            this.pnlFPContact.Name = "pnlFPContact";
            this.pnlFPContact.Size = new System.Drawing.Size(392, 38);
            this.pnlFPContact.TabIndex = 2;

            // txtFPContact
            this.txtFPContact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFPContact.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFPContact.Location = new System.Drawing.Point(10, 8);
            this.txtFPContact.Name = "txtFPContact";
            this.txtFPContact.PlaceholderText = "0912 345 678 hoặc email@moccafe.vn";
            this.txtFPContact.Size = new System.Drawing.Size(370, 22);
            this.txtFPContact.TabIndex = 0;

            // btnCancel
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(255, 235, 230);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(86, 57, 39);
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.Location = new System.Drawing.Point(24, 274);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 40);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "× Hủy bỏ";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // btnSendOTP
            this.btnSendOTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendOTP.FlatAppearance.BorderSize = 0;
            this.btnSendOTP.BackColor = System.Drawing.Color.FromArgb(86, 57, 39);
            this.btnSendOTP.ForeColor = System.Drawing.Color.White;
            this.btnSendOTP.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSendOTP.Location = new System.Drawing.Point(300, 274);
            this.btnSendOTP.Name = "btnSendOTP";
            this.btnSendOTP.Size = new System.Drawing.Size(116, 40);
            this.btnSendOTP.TabIndex = 4;
            this.btnSendOTP.Text = "Gửi mã OTP →";
            this.btnSendOTP.UseVisualStyleBackColor = false;
            this.btnSendOTP.Click += new System.EventHandler(this.btnSendOTP_Click);

            // Add controls to pnlFPUsername
            this.pnlFPUsername.Controls.Add(this.txtFPUsername);

            // Add controls to pnlFPContact
            this.pnlFPContact.Controls.Add(this.txtFPContact);

            // Add controls to stepOne
            this.stepOne.Controls.Add(this.lblFPTitle);
            this.stepOne.Controls.Add(this.lblFPSubtitle);
            this.stepOne.Controls.Add(this.lblFPUsernameLabel);
            this.stepOne.Controls.Add(this.pnlFPUsername);
            this.stepOne.Controls.Add(this.lblFPContactLabel);
            this.stepOne.Controls.Add(this.pnlFPContact);
            this.stepOne.Controls.Add(this.btnCancel);
            this.stepOne.Controls.Add(this.btnSendOTP);

            // ─────────────────────────────────────────────
            // stepTwo
            // ─────────────────────────────────────────────
            this.stepTwo.BackColor = System.Drawing.Color.White;
            this.stepTwo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stepTwo.Name = "stepTwo";
            this.stepTwo.TabIndex = 1;
            this.stepTwo.Visible = false;

            // lblRPTitle
            this.lblRPTitle.AutoSize = true;
            this.lblRPTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblRPTitle.ForeColor = System.Drawing.Color.FromArgb(86, 57, 39);
            this.lblRPTitle.Location = new System.Drawing.Point(24, 20);
            this.lblRPTitle.Name = "lblRPTitle";
            this.lblRPTitle.Text = "Đặt lại mật khẩu";

            // lblRPSubtitle
            this.lblRPSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRPSubtitle.ForeColor = System.Drawing.Color.Gray;
            this.lblRPSubtitle.Location = new System.Drawing.Point(24, 59);
            this.lblRPSubtitle.Name = "lblRPSubtitle";
            this.lblRPSubtitle.Size = new System.Drawing.Size(392, 40);
            this.lblRPSubtitle.Text = "Tạo mật khẩu mới cho tài khoản.\nTối thiểu 8 ký tự, gồm chữ hoa và số.";

            // lblNewPwdLabel
            this.lblNewPwdLabel.AutoSize = true;
            this.lblNewPwdLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNewPwdLabel.Location = new System.Drawing.Point(24, 112);
            this.lblNewPwdLabel.Name = "lblNewPwdLabel";
            this.lblNewPwdLabel.Text = "Mật khẩu mới";

            // pnlNewPwd
            this.pnlNewPwd.BackColor = System.Drawing.Color.White;
            this.pnlNewPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNewPwd.Location = new System.Drawing.Point(24, 137);
            this.pnlNewPwd.Name = "pnlNewPwd";
            this.pnlNewPwd.Size = new System.Drawing.Size(392, 38);
            this.pnlNewPwd.TabIndex = 1;

            // txtNewPassword
            this.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNewPassword.Location = new System.Drawing.Point(10, 8);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '•';
            this.txtNewPassword.Size = new System.Drawing.Size(335, 22);
            this.txtNewPassword.TabIndex = 0;

            // btnToggleNewPwd
            this.btnToggleNewPwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleNewPwd.FlatAppearance.BorderSize = 0;
            this.btnToggleNewPwd.BackColor = System.Drawing.Color.White;
            this.btnToggleNewPwd.Location = new System.Drawing.Point(355, 6);
            this.btnToggleNewPwd.Name = "btnToggleNewPwd";
            this.btnToggleNewPwd.Size = new System.Drawing.Size(25, 25);
            this.btnToggleNewPwd.TabIndex = 1;
            this.btnToggleNewPwd.Text = "👁";
            this.btnToggleNewPwd.UseVisualStyleBackColor = false;
            this.btnToggleNewPwd.Click += new System.EventHandler(this.btnToggleNewPwd_Click);

            // lblConfirmPwdLabel
            this.lblConfirmPwdLabel.AutoSize = true;
            this.lblConfirmPwdLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblConfirmPwdLabel.Location = new System.Drawing.Point(24, 192);
            this.lblConfirmPwdLabel.Name = "lblConfirmPwdLabel";
            this.lblConfirmPwdLabel.Text = "Xác nhận mật khẩu mới";

            // pnlConfirmPwd
            this.pnlConfirmPwd.BackColor = System.Drawing.Color.White;
            this.pnlConfirmPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlConfirmPwd.Location = new System.Drawing.Point(24, 215);
            this.pnlConfirmPwd.Name = "pnlConfirmPwd";
            this.pnlConfirmPwd.Size = new System.Drawing.Size(392, 38);
            this.pnlConfirmPwd.TabIndex = 2;

            // txtConfirmPassword
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtConfirmPassword.Location = new System.Drawing.Point(10, 8);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '•';
            this.txtConfirmPassword.Size = new System.Drawing.Size(335, 22);
            this.txtConfirmPassword.TabIndex = 0;

            // btnToggleConfirmPwd
            this.btnToggleConfirmPwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleConfirmPwd.FlatAppearance.BorderSize = 0;
            this.btnToggleConfirmPwd.BackColor = System.Drawing.Color.White;
            this.btnToggleConfirmPwd.Location = new System.Drawing.Point(355, 6);
            this.btnToggleConfirmPwd.Name = "btnToggleConfirmPwd";
            this.btnToggleConfirmPwd.Size = new System.Drawing.Size(25, 25);
            this.btnToggleConfirmPwd.TabIndex = 1;
            this.btnToggleConfirmPwd.Text = "👁";
            this.btnToggleConfirmPwd.UseVisualStyleBackColor = false;
            this.btnToggleConfirmPwd.Click += new System.EventHandler(this.btnToggleConfirmPwd_Click);

            // btnBack
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(255, 235, 230);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(86, 57, 39);
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBack.Location = new System.Drawing.Point(24, 274);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(76, 40);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "← Quay lại";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // btnChangePassword
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(86, 57, 39);
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnChangePassword.Location = new System.Drawing.Point(284, 274);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(132, 40);
            this.btnChangePassword.TabIndex = 4;
            this.btnChangePassword.Text = "Đổi mật khẩu ✓";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);

            // Add controls to pnlNewPwd
            this.pnlNewPwd.Controls.Add(this.txtNewPassword);
            this.pnlNewPwd.Controls.Add(this.btnToggleNewPwd);

            // Add controls to pnlConfirmPwd
            this.pnlConfirmPwd.Controls.Add(this.txtConfirmPassword);
            this.pnlConfirmPwd.Controls.Add(this.btnToggleConfirmPwd);

            // Add controls to stepTwo
            this.stepTwo.Controls.Add(this.lblRPTitle);
            this.stepTwo.Controls.Add(this.lblRPSubtitle);
            this.stepTwo.Controls.Add(this.lblNewPwdLabel);
            this.stepTwo.Controls.Add(this.pnlNewPwd);
            this.stepTwo.Controls.Add(this.lblConfirmPwdLabel);
            this.stepTwo.Controls.Add(this.pnlConfirmPwd);
            this.stepTwo.Controls.Add(this.btnBack);
            this.stepTwo.Controls.Add(this.btnChangePassword);

            // Add both step panels to pnlMain
            this.pnlMain.Controls.Add(this.stepOne);
            this.pnlMain.Controls.Add(this.stepTwo);

            // ─────────────────────────────────────────────
            // A02ForgotPassword
            // ─────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(220, 210, 200);
            this.ClientSize = new System.Drawing.Size(480, 452);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "A02ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quên mật khẩu";

            this.pnlConfirmPwd.ResumeLayout(false);
            this.pnlConfirmPwd.PerformLayout();
            this.pnlNewPwd.ResumeLayout(false);
            this.pnlNewPwd.PerformLayout();
            this.stepTwo.ResumeLayout(false);
            this.stepTwo.PerformLayout();
            this.pnlFPContact.ResumeLayout(false);
            this.pnlFPContact.PerformLayout();
            this.pnlFPUsername.ResumeLayout(false);
            this.pnlFPUsername.PerformLayout();
            this.stepOne.ResumeLayout(false);
            this.stepOne.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        // Field declarations
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel stepOne;
        private System.Windows.Forms.Label lblFPTitle;
        private System.Windows.Forms.Label lblFPSubtitle;
        private System.Windows.Forms.Label lblFPUsernameLabel;
        private System.Windows.Forms.Panel pnlFPUsername;
        private System.Windows.Forms.TextBox txtFPUsername;
        private System.Windows.Forms.Label lblFPContactLabel;
        private System.Windows.Forms.Panel pnlFPContact;
        private System.Windows.Forms.TextBox txtFPContact;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSendOTP;
        private System.Windows.Forms.Panel stepTwo;
        private System.Windows.Forms.Label lblRPTitle;
        private System.Windows.Forms.Label lblRPSubtitle;
        private System.Windows.Forms.Label lblNewPwdLabel;
        private System.Windows.Forms.Panel pnlNewPwd;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Button btnToggleNewPwd;
        private System.Windows.Forms.Label lblConfirmPwdLabel;
        private System.Windows.Forms.Panel pnlConfirmPwd;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnToggleConfirmPwd;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnChangePassword;
    }
}
