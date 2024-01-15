namespace MI6
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DialogResult result = DialogResult.None;
            string agentCode = string.Empty;

            while (true)
            {

                /*
                 * When started the log in form (Form1) will display
                 */
                if (result == DialogResult.None)
                {
                    using (frmLogIn loginForm = new frmLogIn())
                    {
                        result = loginForm.ShowDialog();
                        if (result != DialogResult.OK)
                        {
                            break;
                        }
                        agentCode = loginForm.AgentCode;
                    }
                }

                /*
                 * When the user entered the correct details the dashboard will open or when they quit the shooting gallery
                 */
                if (result == DialogResult.OK)
                {
                    using (LogInDashboard logInDashboard = new LogInDashboard(agentCode))
                    {
                        result = logInDashboard.ShowDialog();
                        if (result != DialogResult.Retry)
                        {
                            break;
                        }
                    }
                }

                /*
                 * When user presses start button the dashboard will close and open the shooting gallery
                 */
                if (result == DialogResult.Retry)
                {
                    using (ShootingGallery shootingGallery = new ShootingGallery(int.Parse(agentCode)))
                    {
                        result = shootingGallery.ShowDialog();
                        if (result != DialogResult.OK)
                        {
                            break;
                        }
                    }
                }
            }
        }
    }

}