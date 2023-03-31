using projekt_topAPP.tøídy;

namespace projekt_topAPP
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
            User? user = formLogin.LoggedUser;
            if (user != null)
            {
                if (user.Role == "admin") Application.Run(new formAdmin());
                else if (user.Role == "user") Application.Run(new formUser());
            }
        }
    }
}