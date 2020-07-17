using COMP_FISK.Controllers;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace COMP_FISK
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Provjera da li aplikacija vec radi
            String thisprocessname = Process.GetCurrentProcess().ProcessName;
            if (Process.GetProcesses().Count(p => p.ProcessName == thisprocessname) > 1)
                return;

            // Kreira sve potrebne direktorije
            FolderController.KreirajDirektorije();

            // Dodaj ovo u registry za auto startup aplikacije
            RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            key.SetValue("Servis-Fiskalizacija", Application.ExecutablePath);

            DbfFileWatcherController FileWatcher = new DbfFileWatcherController(@"C:\fiskcomp\exch\lnk\TO_FP");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindowView());
        }
    }
}
