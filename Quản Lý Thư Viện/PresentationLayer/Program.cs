using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace PresentationLayer
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("vi-VN");

            new MyApplication().Run(Environment.GetCommandLineArgs());
        }
    }
}
