namespace WindowsDB
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
            //Application.Run(new LoginDemo());
            //Application.Run(new RegisterDemo());   
            //Application.Run(new DBConnection());
             //Application.Run(new ForgotPDemo(" "));
            //Application.Run(new AccountPDemo("123"));
            Application.Run(new GridViewDemo());
        }
    }
}