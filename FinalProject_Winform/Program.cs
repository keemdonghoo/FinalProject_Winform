namespace FinalProject_Winform
{
    internal static class Program
    {
        //이건종
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            LoginForm loginForm = new LoginForm();
            
            Application.Run(new LoginForm());
            if(loginForm.loginSuccessful)
            {
                Application.Run(new MainForm());
            }


            // 나도 바쁘다고!
            // 김동후 체크

        }
    }
}
