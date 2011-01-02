using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Configuration;

namespace diggBeep
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (ConfigurationManager.AppSettings["User"] == "")
            {
                (new Settings()).ShowDialog();
            }
            Application.Run(new Form1());
        }
    }
}
