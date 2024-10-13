using SupermarkerDefinitive._Repositories;
using SupermarkerDefinitive.Models;
using SupermarkerDefinitive.Presenters;
using SupermarkerDefinitive.Properties;
using SupermarkerDefinitive.Views;
using System.Configuration;

namespace SupermarkerDefinitive
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            string sqlConnectionString = Settings.Default.SqlConnection;
            IMainView view = new MainView();
            new MainPresenter(view, sqlConnectionString);
            Application.Run((Form) view);
        }
    }
}