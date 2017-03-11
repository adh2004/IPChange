using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Security.Principal;
using System.Diagnostics;
using System.Reflection;
using System.Threading;

namespace IPChange
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!IsAdministrator())
            {
                ProcessStartInfo proc = new ProcessStartInfo();
                proc.UseShellExecute = true;
                proc.WorkingDirectory = Environment.CurrentDirectory;
                proc.FileName = Application.ExecutablePath;
                proc.Verb = "runas";

                Process.Start(proc);
                Application.Exit();
                
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            
        }

        private static bool IsAdministrator()
        {
            WindowsIdentity wI = WindowsIdentity.GetCurrent();

            WindowsPrincipal wP = new WindowsPrincipal(wI);
            return wP.IsInRole(WindowsBuiltInRole.Administrator);
        }

        private static void RunAsAdmin()
        {
            if (!IsAdministrator())
            {
                ProcessStartInfo proc = new ProcessStartInfo();
                proc.UseShellExecute = true;
                proc.WorkingDirectory = Environment.CurrentDirectory;
                proc.FileName = Application.ExecutablePath;
                proc.Verb = "runas";

                Process.Start(proc);
                Application.Exit();
                Thread.Sleep(500);
                
                
                
                
                
            }
        }
        
    }
}
