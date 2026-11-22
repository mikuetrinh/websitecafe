namespace DoAnLapTrinhTrucQuan
{
    partial class A02_2OTP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Controls
        private System.Windows.Forms.Label lblOTPTitle;
        private System.Windows.Forms.Label lblOTPSubtitle;
        private System.Windows.Forms.Panel pnlOTPBoxes;
        private System.Windows.Forms.TextBox[] otpBoxes;
        private System.Windows.Forms.Label lblCountdown;
        private System.Windows.Forms.LinkLabel lnkResend;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;

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
            this.components = new System.ComponentModel.Container();
            this.lblOTPTitle = new System.Windows.Forms.Label();
            this.lblOTPSubtitle = new System.Windows.Forms.Label();
            this.pnlOTPBoxes = new System.Windows.Forms.Panel();
            this.lblCountdown = new System.Windows.Forms.Label();
            this.lnkResend = new System.Windows.Forms.LinkLabel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();

            this.SuspendLayout();
            this.pnlOTPBoxes.SuspendLayout();
            this.pnlButtons.SuspendLayout();

            // 
            // Form
            // 
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ClientSize = new System.Drawing.Size(440, 270);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.BackColor = System.Drawing.Color.FromArgb(250, 247, 243);
            this.Text = "Xác nhận OTP";
            this.Font = new System.Drawing.Font("Segoe UI", 9f);

            // 
            // lblOTPTitle
            // 
            this.lblOTPTitle.AutoSize = true;
            this.lblOTPTitle.Font = new System.Drawing.Font("Segoe UI", 16f, System.Drawing.FontStyle.Bold);
            this.lblOTPTitle.ForeColor = System.Drawing.Color.FromArgb(86, 57, 39);
            this.lblOTPTitle.Location = new System.Drawing.Point(24, 16);
            this.lblOTPTitle.Name = "lblOTPTitle";
            this.lblOTPTitle.Text = "Nhập mã OTP";

            // 
            // lblOTPSubtitle
            // 
            this.lblOTPSubtitle.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblOTPSubtitle.ForeColor = System.Drawing.Color.Gray;
            this.lblOTPSubtitle.Location = new System.Drawing.Point(24, 48);
            this.lblOTPSubtitle.Name = "lblOTPSubtitle";
            this.lblOTPSubtitle.Size = new System.Drawing.Size(392, 32);
            this.lblOTPSubtitle.Text = "Mã gồm 6 số đã được gửi đến\nsố *** *** 678";

            // 
            // pnlOTPBoxes
            // 
            this.pnlOTPBoxes.BackColor = System.Drawing.Color.Transparent;
            this.pnlOTPBoxes.Location = new System.Drawing.Point(24, 84);
            this.pnlOTPBoxes.Name = "pnlOTPBoxes";
            this.pnlOTPBoxes.Size = new System.Drawing.Size(392, 54);

            // Create OTP TextBoxes
            otpBoxes = new System.Windows.Forms.TextBox[6];
            for (int i = 0; i < 6; i++)
            {
                otpBoxes[i] = new System.Windows.Forms.TextBox();
                otpBoxes[i].Size = new System.Drawing.Size(48, 48);
                otpBoxes[i].Location = new System.Drawing.Point(18 + i * 60, 2);
                otpBoxes[i].Font = new System.Drawing.Font("Segoe UI", 18f, System.Drawing.FontStyle.Bold);
                otpBoxes[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                otpBoxes[i].MaxLength = 1;
                otpBoxes[i].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                otpBoxes[i].BackColor = System.Drawing.Color.FromArgb(255, 235, 230);
                otpBoxes[i].Name = "otpBox" + i;
                this.pnlOTPBoxes.Controls.Add(otpBoxes[i]);
            }

            // 
            // lblCountdown
            // 
            this.lblCountdown.AutoSize = true;
            this.lblCountdown.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblCountdown.ForeColor = System.Drawing.Color.Red;
            this.lblCountdown.Location = new System.Drawing.Point(24, 150);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Text = "Mã hết hạn sau 01:00";

            // 
            // lnkResend
            // 
            this.lnkResend.AutoSize = true;
            this.lnkResend.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lnkResend.LinkColor = System.Drawing.Color.Brown;
            this.lnkResend.Location = new System.Drawing.Point(330, 150);
            this.lnkResend.Name = "lnkResend";
            this.lnkResend.Text = "Gửi lại mã";

            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.Transparent;
            this.pnlButtons.Location = new System.Drawing.Point(24, 188);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(392, 42);

            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(255, 235, 230);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(86, 57, 39);
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10f);
            this.btnCancel.Location = new System.Drawing.Point(0, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(164, 40);
            this.btnCancel.Text = "Hủy";

            // 
            // btnConfirm
            // 
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(86, 57, 39);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            this.btnConfirm.Location = new System.Drawing.Point(176, 0);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(216, 40);
            this.btnConfirm.Text = "XÁC NHẬN";

            // 
            // Wire up events
            // 
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            this.lnkResend.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkResend_LinkClicked);

            for (int i = 0; i < 6; i++)
            {
                otpBoxes[i].TextChanged += new System.EventHandler(this.OtpBox_TextChanged);
                otpBoxes[i].KeyDown += new System.Windows.Forms.KeyEventHandler(this.OtpBox_KeyDown);
            }

            // 
            // Add controls to panels
            // 
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Controls.Add(this.btnConfirm);

            // 
            // Add controls to form
            // 
            this.Controls.Add(this.lblOTPTitle);
            this.Controls.Add(this.lblOTPSubtitle);
            this.Controls.Add(this.pnlOTPBoxes);
            this.Controls.Add(this.lblCountdown);
            this.Controls.Add(this.lnkResend);
            this.Controls.Add(this.pnlButtons);

            this.pnlButtons.ResumeLayout(false);
            this.pnlOTPBoxes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
