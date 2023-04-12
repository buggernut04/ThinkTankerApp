using ThinkTankerGUI.LogInForm;
using ThinkTankerClasses;
using ThinkTankerClasses.Databases;

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
            ProjectDatabase.SaveUserRecord();
            Application.Run(new TowerOfHanoiBT());
            
        }
    }
}