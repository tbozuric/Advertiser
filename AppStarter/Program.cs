using System;
using System.IO;
using System.Windows.Forms;
using Controller;
using DataAccessLayer;
using PresentationLayer;

namespace AppStarter
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SetProcessDPIAware();

            var currentPath = System.Environment.CurrentDirectory;
            var exists = File.Exists($"{currentPath}\\Reklamator.db");

            if (!exists)
            {
                NHibernateService.CreateDatabase();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindowForm(new MainController()));
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}