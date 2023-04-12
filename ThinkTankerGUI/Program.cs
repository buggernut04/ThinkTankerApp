using ThinkTankerGUI.LogInForm;
using ThinkTankerClasses;
using ThinkTankerClasses.Databases;
using ThinkTankerGUI.SignUpForm;

namespace ThinkTankerGUI
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

            ProjectDatabase.LoadUserRecord();
            //Application.Run(new LogIn());

            //Application.Run(new SignUp());

            Application.Run(new TowerOfHanoiBT());
        }
    }
}