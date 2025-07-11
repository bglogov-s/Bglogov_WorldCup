using MainClass;
using System.Globalization;

namespace MainForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var settings = DataLibrary.Config.SettingsManager.LoadSettings();
            if (settings == null)
            {
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                ApplicationConfiguration.Initialize();
                Application.Run(new EntryForm());
            }
            else 
            { 
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(settings.SelectedLanguage);
                Thread.CurrentThread.CurrentCulture = new CultureInfo(settings.SelectedLanguage);
                Application.Run(new form_FavoriteTeamForm());
            }
        }
    }
}