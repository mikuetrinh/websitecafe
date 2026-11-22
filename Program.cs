namespace DoAnLapTrinhTrucQuan
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// Shows A01Login first; on successful login opens FrmMain.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Run login dialog; A01Login must set DialogResult = OK and
            // expose LoggedInUsername when login succeeds.
            var login = new A01Login();
            var result = login.ShowDialog();

            if (result == DialogResult.OK)
            {
                Application.Run(new FrmMain(login.LoggedInUsername));
            }
            // If the user closes the login dialog without logging in,
            // the application simply exits.
        }
    }
}
