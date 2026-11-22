namespace DoAnLapTrinhTrucQuan
{
    public partial class FrmMain : Form
    {
        private A03Personalinfo? profileControl;
        private string  currentUsername;

        public FrmMain(string username)
        {
            InitializeComponent();

            currentUsername     = username;
            WindowState         = FormWindowState.Maximized;

            // Show username in topbar
            lbTentopbar.Text    = username;

            // Layout helpers
            flowLayoutPanel1.Dock       = DockStyle.None;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Anchor     = AnchorStyles.Top | AnchorStyles.Bottom |
                                          AnchorStyles.Left | AnchorStyles.Right;
            btnThongtincanhan.Anchor    = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            pnlSidebar.Resize += (_, _) => LayoutSidebar();
            pnlTopbar.Resize  += (_, _) => LayoutTopbar();
            LayoutSidebar();
            LayoutTopbar();

            // Sidebar navigation
            btnThongtincanhan.Click    += (_, _) => ShowProfile();
            btnDangxuatsidebar.Click   += (_, _) => ConfirmLogout();
            btnQuanlynhanvien.Click    += btnQuanlynhanvien_Click;
        }

        // ── Load profile panel ──────────────────────────────────────────
        private void ShowProfile()
        {
            if (profileControl == null)
            {
                profileControl = new A03Personalinfo();
                profileControl.ProfileUpdated += (name, _) =>
                {
                    lbTentopbar.Text = name;
                    currentUsername  = name;
                };
            }
            LoadControl(profileControl);
        }

        // ── Logout ──────────────────────────────────────────────────────
        private void ConfirmLogout()
        {
            var result = MessageBox.Show(
                "Bạn có muốn đăng xuất không?",
                "Xác nhận đăng xuất",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        // ── Layout helpers ───────────────────────────────────────────────
        private void LayoutSidebar()
        {
            const int navItemHeight = 51;
            flowLayoutPanel1.Location = new Point(0, pnlLogo.Height);
            flowLayoutPanel1.Size = new Size(
                pnlSidebar.ClientSize.Width,
                Math.Max(0, pnlSidebar.ClientSize.Height
                    - pnlLogo.Height
                    - panel1.Height
                    - btnThongtincanhan.Height));
            btnThongtincanhan.Location = new Point(
                0,
                pnlSidebar.ClientSize.Height - panel1.Height - btnThongtincanhan.Height);
            btnThongtincanhan.Width = pnlSidebar.ClientSize.Width;
            flowLayoutPanel1.AutoScrollMinSize =
                new Size(0, flowLayoutPanel1.Controls.Count * navItemHeight);
        }

        private void LayoutTopbar()
        {
            const int rightInset = 16;
            picAvttopbar.Location = new Point(
                pnlTopbar.ClientSize.Width - picAvttopbar.Width - rightInset, 12);

            lbTentopbar.Anchor    = AnchorStyles.Top | AnchorStyles.Right;
            lbTentopbar.AutoSize  = false;
            lbTentopbar.TextAlign = ContentAlignment.MiddleRight;
            lbTentopbar.Size      = new Size(160, 26);
            lbTentopbar.Location  = new Point(picAvttopbar.Left - lbTentopbar.Width - 12, 6);

            lbRoletopbar.Anchor    = AnchorStyles.Top | AnchorStyles.Right;
            lbRoletopbar.AutoSize  = false;
            lbRoletopbar.TextAlign = ContentAlignment.MiddleRight;
            lbRoletopbar.Size      = new Size(160, 26);
            lbRoletopbar.Location  = new Point(picAvttopbar.Left - lbRoletopbar.Width - 12, 34);
        }

        // ── Load UserControl into content panel ──────────────────────────
        private void LoadControl(UserControl uc)
        {
            pnlContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(uc);
        }

        // ── Sidebar click handlers ───────────────────────────────────────
        private void btnQuanlynhanvien_Click(object sender, EventArgs e)
        {
            LoadControl(new UcM05());
        }
    }
}
