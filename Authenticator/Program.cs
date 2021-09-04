using Authenticator.Classes;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Authenticator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //using (RegistryKey key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
            //{
            //    //key.SetValue("My ApplicationStartUpDemo", "\"" + System.Reflection.Assembly.GetExecutingAssembly().Location + "\"");
            //    key.DeleteValue("My ApplicationStartUpDemo");
            //}
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(ErrorHandler);

            Classes.Authenticator authenticator = new Classes.Authenticator();
            if (authenticator.IsTowFactorEnabled)
            {
                Application.Run(new FrmValidator(authenticator));
            }
            else
            {
                Application.Run(new FrmMain(authenticator));
            }

        }

        private static void ErrorHandler(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = (Exception)e.ExceptionObject;
            MessageBox.Show(ex.ToString());
        }
    }
}
