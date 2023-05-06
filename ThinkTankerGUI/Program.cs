using ThinkTankerGUI.LogInForm;
using ThinkTankerClasses;
using ThinkTankerClasses.Databases;
using ThinkTankerGUI.SignUpForm;
using ThinkTankerGUI.MainMenuForm;

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

            // Please don't change
            // If mo run mo ari, e comment ras ubos.

            ProjectDatabase.UserRecord.Add(new User("Salem", DateTime.Now, 'M', "buggernut04", "Gwapoko-123"));
            ProjectDatabase.SaveUserRecord();

            ProjectDatabase.Init();
            
            Application.Run(new LogIn());
        }
    }
}