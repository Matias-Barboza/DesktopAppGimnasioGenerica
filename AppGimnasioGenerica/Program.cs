using DesktopAppGimnasio.Presenters;
using DesktopAppGimnasio.Views;
using System.Configuration;

namespace DesktopAppGimnasio
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

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            String SqlConnectionString = ConfigurationManager.ConnectionStrings["DesktopAppGimnasioGenerica.Properties.Settings.SQLConnection"].ConnectionString;

            IMainView mainView = new MainView();
            new MainPresenter(mainView, SqlConnectionString);
            Application.Run((Form) mainView);
        }
    }
}