using System;
using System.Windows.Forms;
using COVIDVACCSYSTEM.POO.View;
using COVIDVACCSYSTEM.View;

namespace COVIDVACCSYSTEM
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ManagerLogIn());
         //054789635  
        }
    }
}