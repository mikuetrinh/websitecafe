namespace DoAnLapTrinhTrucQuan
{
    partial class A01Login
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
            mainLayout = new TableLayoutPanel();
            brandPanel = new Panel();
            picBrandLogo = new PictureBox();
            lblBrandName = new Label();
            lblBrandSubtitle = new Label();
            lblHeroText = new Label();
            lblHeroDesc = new Label();
            pnlStats = new Panel();
            lblStat1 = new Label();
            lblStat2 = new Label();
            lblStat3 = new Label();
            workspace = new Panel();
            card = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            pnlError = new Panel();
            lblErrorIcon = new Label();
            lblErrorMsg = new Label();
            btnCloseError = new Button();
            lblUsernameLabel = new Label();
            pnlUsername = new Panel();
            lblUsernameIcon = new Label();
            txtUsername = new TextBox();
            lblPasswordLabel = new Label();
            pnlPassword = new Panel();
            lblPasswordIcon = new Label();
            txtPassword = new TextBox();
            btnTogglePassword = new Button();
            pnlRemember = new Panel();
            chkRemember = new CheckBox();
            lnkForgotPassword = new LinkLabel();
            btnLogin = new Button();
            pnlBottom = new Panel();
            lnkRegister = new LinkLabel();
            mainLayout.SuspendLayout();
            brandPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBrandLogo).BeginInit();
            pnlStats.SuspendLayout();
            workspace.SuspendLayout();
            card.SuspendLayout();
            pnlError.SuspendLayout();
            pnlUsername.SuspendLayout();
            pnlPassword.SuspendLayout();
            pnlRemember.SuspendLayout();
            pnlBottom.SuspendLayout();
            SuspendLayout();
            // 
            // mainLayout
            // 
            mainLayout.ColumnCount = 2;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42F));
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58F));
            mainLayout.Controls.Add(brandPanel, 0, 0);
            mainLayout.Controls.Add(workspace, 1, 0);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(0, 0);
            mainLayout.Margin = new Padding(0);
            mainLayout.Name = "mainLayout";
            mainLayout.RowCount = 1;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayout.Size = new Size(2537, 1638);
            mainLayout.TabIndex = 0;
            // 
            // brandPanel
            // 
            brandPanel.BackColor = Color.FromArgb(86, 57, 39);
            brandPanel.Controls.Add(picBrandLogo);
            brandPanel.Controls.Add(lblBrandName);
            brandPanel.Controls.Add(lblBrandSubtitle);
            brandPanel.Controls.Add(lblHeroText);
            brandPanel.Controls.Add(lblHeroDesc);
            brandPanel.Controls.Add(pnlStats);
            brandPanel.Dock = DockStyle.Fill;
            brandPanel.Location = new Point(0, 0);
            brandPanel.Margin = new Padding(0);
            brandPanel.Name = "brandPanel";
            brandPanel.Size = new Size(1065, 1638);
            brandPanel.TabIndex = 0;
            // 
            // picBrandLogo
            // 
            picBrandLogo.Image = Properties.Resources.LLTQ_Café_Logo;
            picBrandLogo.Location = new Point(74, 107);
            picBrandLogo.Margin = new Padding(6, 6, 6, 6);
            picBrandLogo.Name = "picBrandLogo";
            picBrandLogo.Size = new Size(149, 171);
            picBrandLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picBrandLogo.TabIndex = 0;
            picBrandLogo.TabStop = false;
            // 
            // lblBrandName
            // 
            lblBrandName.AutoSize = true;
            lblBrandName.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblBrandName.ForeColor = Color.White;
            lblBrandName.Location = new Point(67, 303);
            lblBrandName.Margin = new Padding(6, 0, 6, 0);
            lblBrandName.Name = "lblBrandName";
            lblBrandName.Size = new Size(313, 78);
            lblBrandName.TabIndex = 1;
            lblBrandName.Text = "LTTQ Café";
            // 
            // lblBrandSubtitle
            // 
            lblBrandSubtitle.AutoSize = true;
            lblBrandSubtitle.Font = new Font("Segoe UI", 10F);
            lblBrandSubtitle.ForeColor = Color.FromArgb(210, 190, 170);
            lblBrandSubtitle.Location = new Point(71, 401);
            lblBrandSubtitle.Margin = new Padding(6, 0, 6, 0);
            lblBrandSubtitle.Name = "lblBrandSubtitle";
            lblBrandSubtitle.Size = new Size(390, 37);
            lblBrandSubtitle.TabIndex = 2;
            lblBrandSubtitle.Text = "Enterprise Management System";
            // 
            // lblHeroText
            // 
            lblHeroText.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblHeroText.ForeColor = Color.White;
            lblHeroText.Location = new Point(67, 555);
            lblHeroText.Margin = new Padding(6, 0, 6, 0);
            lblHeroText.Name = "lblHeroText";
            lblHeroText.Size = new Size(910, 192);
            lblHeroText.TabIndex = 3;
            lblHeroText.Text = "Hương vị nguyên bản,\nquản trị thông minh";
            // 
            // lblHeroDesc
            // 
            lblHeroDesc.Font = new Font("Segoe UI", 10F);
            lblHeroDesc.ForeColor = Color.FromArgb(210, 190, 170);
            lblHeroDesc.Location = new Point(71, 779);
            lblHeroDesc.Margin = new Padding(6, 0, 6, 0);
            lblHeroDesc.Name = "lblHeroDesc";
            lblHeroDesc.Size = new Size(910, 171);
            lblHeroDesc.TabIndex = 4;
            lblHeroDesc.Text = "Nền tảng quản lý toàn diện cho chuỗi quán cà phê. Từ POS đến báo cáo, mọi thứ trong tầm tay.";
            // 
            // pnlStats
            // 
            pnlStats.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlStats.BackColor = Color.FromArgb(70, 45, 30);
            pnlStats.Controls.Add(lblStat1);
            pnlStats.Controls.Add(lblStat2);
            pnlStats.Controls.Add(lblStat3);
            pnlStats.Location = new Point(0, 1382);
            pnlStats.Margin = new Padding(0);
            pnlStats.Name = "pnlStats";
            pnlStats.Padding = new Padding(30, 26, 30, 26);
            pnlStats.Size = new Size(1065, 256);
            pnlStats.TabIndex = 5;
            // 
            // lblStat1
            // 
            lblStat1.AutoSize = true;
            lblStat1.Font = new Font("Segoe UI", 8.5F);
            lblStat1.ForeColor = Color.FromArgb(210, 190, 170);
            lblStat1.Location = new Point(30, 30);
            lblStat1.Margin = new Padding(6, 0, 6, 0);
            lblStat1.Name = "lblStat1";
            lblStat1.Size = new Size(349, 31);
            lblStat1.TabIndex = 0;
            lblStat1.Text = "🎯 Điểm chạm POS | Tối ưu WPF";
            // 
            // lblStat2
            // 
            lblStat2.AutoSize = true;
            lblStat2.Font = new Font("Segoe UI", 8.5F);
            lblStat2.ForeColor = Color.White;
            lblStat2.Location = new Point(30, 81);
            lblStat2.Margin = new Padding(6, 0, 6, 0);
            lblStat2.Name = "lblStat2";
            lblStat2.Size = new Size(320, 31);
            lblStat2.TabIndex = 1;
            lblStat2.Text = "☕ Đơn bàn hoạt động: 24/30";
            // 
            // lblStat3
            // 
            lblStat3.AutoSize = true;
            lblStat3.Font = new Font("Segoe UI", 8.5F);
            lblStat3.ForeColor = Color.FromArgb(180, 220, 170);
            lblStat3.Location = new Point(30, 132);
            lblStat3.Margin = new Padding(6, 0, 6, 0);
            lblStat3.Name = "lblStat3";
            lblStat3.Size = new Size(273, 31);
            lblStat3.TabIndex = 2;
            lblStat3.Text = "⚡ Tải hệ thống: Ổn định";
            // 
            // workspace
            // 
            workspace.BackColor = Color.FromArgb(250, 247, 243);
            workspace.Controls.Add(card);
            workspace.Dock = DockStyle.Fill;
            workspace.Location = new Point(1065, 0);
            workspace.Margin = new Padding(0);
            workspace.Name = "workspace";
            workspace.Size = new Size(1472, 1638);
            workspace.TabIndex = 1;
            workspace.Resize += workspace_Resize;
            // 
            // card
            // 
            card.BackColor = Color.White;
            card.Controls.Add(lblTitle);
            card.Controls.Add(lblSubtitle);
            card.Controls.Add(pnlError);
            card.Controls.Add(lblUsernameLabel);
            card.Controls.Add(pnlUsername);
            card.Controls.Add(lblPasswordLabel);
            card.Controls.Add(pnlPassword);
            card.Controls.Add(pnlRemember);
            card.Controls.Add(btnLogin);
            card.Controls.Add(pnlBottom);
            card.Location = new Point(347, 222);
            card.Margin = new Padding(6, 6, 6, 6);
            card.Name = "card";
            card.Padding = new Padding(67, 68, 67, 68);
            card.Size = new Size(780, 1195);
            card.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(86, 57, 39);
            lblTitle.Location = new Point(67, 68);
            lblTitle.Margin = new Padding(6, 0, 6, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(646, 94);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Đăng nhập hệ thống";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.Gray;
            lblSubtitle.Location = new Point(67, 171);
            lblSubtitle.Margin = new Padding(6, 0, 6, 0);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(646, 77);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Vui lòng nhập tài khoản để truy cập ứng dụng";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlError
            // 
            pnlError.BackColor = Color.FromArgb(254, 226, 226);
            pnlError.Controls.Add(lblErrorIcon);
            pnlError.Controls.Add(lblErrorMsg);
            pnlError.Controls.Add(btnCloseError);
            pnlError.Location = new Point(67, 265);
            pnlError.Margin = new Padding(6, 6, 6, 6);
            pnlError.Name = "pnlError";
            pnlError.Size = new Size(646, 115);
            pnlError.TabIndex = 2;
            pnlError.Visible = false;
            // 
            // lblErrorIcon
            // 
            lblErrorIcon.AutoSize = true;
            lblErrorIcon.Font = new Font("Segoe UI", 14F);
            lblErrorIcon.ForeColor = Color.Red;
            lblErrorIcon.Location = new Point(15, 30);
            lblErrorIcon.Margin = new Padding(6, 0, 6, 0);
            lblErrorIcon.Name = "lblErrorIcon";
            lblErrorIcon.Size = new Size(54, 51);
            lblErrorIcon.TabIndex = 0;
            lblErrorIcon.Text = "⊘";
            // 
            // lblErrorMsg
            // 
            lblErrorMsg.Font = new Font("Segoe UI", 9F);
            lblErrorMsg.ForeColor = Color.FromArgb(185, 28, 28);
            lblErrorMsg.Location = new Point(71, 17);
            lblErrorMsg.Margin = new Padding(6, 0, 6, 0);
            lblErrorMsg.Name = "lblErrorMsg";
            lblErrorMsg.Size = new Size(505, 81);
            lblErrorMsg.TabIndex = 1;
            lblErrorMsg.Text = "...";
            // 
            // btnCloseError
            // 
            btnCloseError.FlatAppearance.BorderSize = 0;
            btnCloseError.FlatStyle = FlatStyle.Flat;
            btnCloseError.ForeColor = Color.Red;
            btnCloseError.Location = new Point(594, 4);
            btnCloseError.Margin = new Padding(6, 6, 6, 6);
            btnCloseError.Name = "btnCloseError";
            btnCloseError.Size = new Size(37, 43);
            btnCloseError.TabIndex = 2;
            btnCloseError.Text = "×";
            btnCloseError.UseVisualStyleBackColor = false;
            // 
            // lblUsernameLabel
            // 
            lblUsernameLabel.AutoSize = true;
            lblUsernameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUsernameLabel.ForeColor = Color.FromArgb(60, 40, 20);
            lblUsernameLabel.Location = new Point(67, 410);
            lblUsernameLabel.Margin = new Padding(6, 0, 6, 0);
            lblUsernameLabel.Name = "lblUsernameLabel";
            lblUsernameLabel.Size = new Size(183, 32);
            lblUsernameLabel.TabIndex = 3;
            lblUsernameLabel.Text = "Tên đăng nhập";
            // 
            // pnlUsername
            // 
            pnlUsername.BackColor = Color.White;
            pnlUsername.BorderStyle = BorderStyle.FixedSingle;
            pnlUsername.Controls.Add(lblUsernameIcon);
            pnlUsername.Controls.Add(txtUsername);
            pnlUsername.Location = new Point(67, 452);
            pnlUsername.Margin = new Padding(6, 6, 6, 6);
            pnlUsername.Name = "pnlUsername";
            pnlUsername.Size = new Size(645, 87);
            pnlUsername.TabIndex = 4;
            // 
            // lblUsernameIcon
            // 
            lblUsernameIcon.AutoSize = true;
            lblUsernameIcon.Font = new Font("Segoe UI", 12F);
            lblUsernameIcon.Location = new Point(15, 19);
            lblUsernameIcon.Margin = new Padding(6, 0, 6, 0);
            lblUsernameIcon.Name = "lblUsernameIcon";
            lblUsernameIcon.Size = new Size(64, 45);
            lblUsernameIcon.TabIndex = 0;
            lblUsernameIcon.Text = "👤";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI", 10F);
            txtUsername.Location = new Point(74, 23);
            txtUsername.Margin = new Padding(6, 6, 6, 6);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(557, 36);
            txtUsername.TabIndex = 1;
            // 
            // lblPasswordLabel
            // 
            lblPasswordLabel.AutoSize = true;
            lblPasswordLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPasswordLabel.ForeColor = Color.FromArgb(60, 40, 20);
            lblPasswordLabel.Location = new Point(67, 576);
            lblPasswordLabel.Margin = new Padding(6, 0, 6, 0);
            lblPasswordLabel.Name = "lblPasswordLabel";
            lblPasswordLabel.Size = new Size(121, 32);
            lblPasswordLabel.TabIndex = 5;
            lblPasswordLabel.Text = "Mật khẩu";
            // 
            // pnlPassword
            // 
            pnlPassword.BackColor = Color.White;
            pnlPassword.BorderStyle = BorderStyle.FixedSingle;
            pnlPassword.Controls.Add(lblPasswordIcon);
            pnlPassword.Controls.Add(txtPassword);
            pnlPassword.Controls.Add(btnTogglePassword);
            pnlPassword.Location = new Point(67, 619);
            pnlPassword.Margin = new Padding(6, 6, 6, 6);
            pnlPassword.Name = "pnlPassword";
            pnlPassword.Size = new Size(645, 87);
            pnlPassword.TabIndex = 6;
            // 
            // lblPasswordIcon
            // 
            lblPasswordIcon.AutoSize = true;
            lblPasswordIcon.Font = new Font("Segoe UI", 12F);
            lblPasswordIcon.Location = new Point(15, 19);
            lblPasswordIcon.Margin = new Padding(6, 0, 6, 0);
            lblPasswordIcon.Name = "lblPasswordIcon";
            lblPasswordIcon.Size = new Size(64, 45);
            lblPasswordIcon.TabIndex = 0;
            lblPasswordIcon.Text = "🔒";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.Location = new Point(74, 23);
            txtPassword.Margin = new Padding(6, 6, 6, 6);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(498, 36);
            txtPassword.TabIndex = 1;
            // 
            // btnTogglePassword
            // 
            btnTogglePassword.FlatAppearance.BorderSize = 0;
            btnTogglePassword.FlatStyle = FlatStyle.Flat;
            btnTogglePassword.Location = new Point(579, 15);
            btnTogglePassword.Margin = new Padding(6, 6, 6, 6);
            btnTogglePassword.Name = "btnTogglePassword";
            btnTogglePassword.Size = new Size(56, 55);
            btnTogglePassword.TabIndex = 2;
            btnTogglePassword.Text = "👁";
            btnTogglePassword.UseVisualStyleBackColor = true;
            // 
            // pnlRemember
            // 
            pnlRemember.Controls.Add(chkRemember);
            pnlRemember.Controls.Add(lnkForgotPassword);
            pnlRemember.Location = new Point(67, 742);
            pnlRemember.Margin = new Padding(6, 6, 6, 6);
            pnlRemember.Name = "pnlRemember";
            pnlRemember.Size = new Size(646, 64);
            pnlRemember.TabIndex = 7;
            // 
            // chkRemember
            // 
            chkRemember.AutoSize = true;
            chkRemember.Font = new Font("Segoe UI", 9F);
            chkRemember.Location = new Point(0, 13);
            chkRemember.Margin = new Padding(6, 6, 6, 6);
            chkRemember.Name = "chkRemember";
            chkRemember.Size = new Size(253, 36);
            chkRemember.TabIndex = 0;
            chkRemember.Text = "Ghi nhớ đăng nhập";
            chkRemember.UseVisualStyleBackColor = true;
            // 
            // lnkForgotPassword
            // 
            lnkForgotPassword.ActiveLinkColor = Color.FromArgb(86, 57, 39);
            lnkForgotPassword.AutoSize = true;
            lnkForgotPassword.Font = new Font("Segoe UI", 9F);
            lnkForgotPassword.LinkColor = Color.FromArgb(86, 57, 39);
            lnkForgotPassword.Location = new Point(461, 15);
            lnkForgotPassword.Margin = new Padding(6, 0, 6, 0);
            lnkForgotPassword.Name = "lnkForgotPassword";
            lnkForgotPassword.Size = new Size(191, 32);
            lnkForgotPassword.TabIndex = 1;
            lnkForgotPassword.TabStop = true;
            lnkForgotPassword.Text = "Quên mật khẩu?";
            lnkForgotPassword.VisitedLinkColor = Color.FromArgb(86, 57, 39);
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(86, 57, 39);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(67, 841);
            btnLogin.Margin = new Padding(6, 6, 6, 6);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(646, 98);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "→ Đăng nhập";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // pnlBottom
            // 
            pnlBottom.Controls.Add(lnkRegister);
            pnlBottom.Location = new Point(67, 973);
            pnlBottom.Margin = new Padding(6, 6, 6, 6);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new Size(646, 77);
            pnlBottom.TabIndex = 9;
            // 
            // lnkRegister
            // 
            lnkRegister.ActiveLinkColor = Color.FromArgb(86, 57, 39);
            lnkRegister.Dock = DockStyle.Fill;
            lnkRegister.Font = new Font("Segoe UI", 9F);
            lnkRegister.LinkColor = Color.FromArgb(86, 57, 39);
            lnkRegister.Location = new Point(0, 0);
            lnkRegister.Margin = new Padding(6, 0, 6, 0);
            lnkRegister.Name = "lnkRegister";
            lnkRegister.Size = new Size(646, 77);
            lnkRegister.TabIndex = 0;
            lnkRegister.TabStop = true;
            lnkRegister.Text = "Chưa có tài khoản? Liên hệ quản trị viên";
            lnkRegister.TextAlign = ContentAlignment.MiddleCenter;
            lnkRegister.VisitedLinkColor = Color.FromArgb(86, 57, 39);
            // 
            // A01Login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 247, 243);
            ClientSize = new Size(2537, 1638);
            Controls.Add(mainLayout);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(6, 6, 6, 6);
            MinimumSize = new Size(1835, 1200);
            Name = "A01Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LTTQ Café - Đăng nhập";
            WindowState = FormWindowState.Maximized;
            mainLayout.ResumeLayout(false);
            brandPanel.ResumeLayout(false);
            brandPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBrandLogo).EndInit();
            pnlStats.ResumeLayout(false);
            pnlStats.PerformLayout();
            workspace.ResumeLayout(false);
            card.ResumeLayout(false);
            card.PerformLayout();
            pnlError.ResumeLayout(false);
            pnlError.PerformLayout();
            pnlUsername.ResumeLayout(false);
            pnlUsername.PerformLayout();
            pnlPassword.ResumeLayout(false);
            pnlPassword.PerformLayout();
            pnlRemember.ResumeLayout(false);
            pnlRemember.PerformLayout();
            pnlBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        // Field declarations
        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.Panel brandPanel;
        private System.Windows.Forms.PictureBox picBrandLogo;
        private System.Windows.Forms.Label lblBrandName;
        private System.Windows.Forms.Label lblBrandSubtitle;
        private System.Windows.Forms.Label lblHeroText;
        private System.Windows.Forms.Label lblHeroDesc;
        private System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.Label lblStat1;
        private System.Windows.Forms.Label lblStat2;
        private System.Windows.Forms.Label lblStat3;
        private System.Windows.Forms.Panel workspace;
        private System.Windows.Forms.Panel card;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlError;
        private System.Windows.Forms.Label lblErrorIcon;
        private System.Windows.Forms.Label lblErrorMsg;
        private System.Windows.Forms.Button btnCloseError;
        private System.Windows.Forms.Label lblUsernameLabel;
        private System.Windows.Forms.Panel pnlUsername;
        private System.Windows.Forms.Label lblUsernameIcon;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPasswordLabel;
        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.Label lblPasswordIcon;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnTogglePassword;
        private System.Windows.Forms.Panel pnlRemember;
        private System.Windows.Forms.CheckBox chkRemember;
        private System.Windows.Forms.LinkLabel lnkForgotPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.LinkLabel lnkRegister;
    }
}
