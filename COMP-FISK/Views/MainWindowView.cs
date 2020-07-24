using COMP_FISK.Controllers;
using COMP_FISK.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP_FISK
{
    public partial class MainWindowView : Form
    {
        #region Ovaj kod sluzi za pomjeranje prozora
        // Ovaj dio koda omogucava da se forma moza pomjeriti kada se drzi desni klik na comp ikonu
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        // Ovaj dio koda omogucava da se forma moza pomjeriti kada se drzi desni klik na comp ikonu
        private new void Move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        public MainWindowView()
        {
            InitializeComponent();
            var systemWatcherFROM_FPok = new FileSystemWatcher(@"C:\fiskcomp\exch\lnk\FROM_FP", "*.OK");
            systemWatcherFROM_FPok.NotifyFilter = NotifyFilters.CreationTime | NotifyFilters.FileName |
                                                NotifyFilters.LastWrite;
            systemWatcherFROM_FPok.Created += SystemWatcherFROM_FPok_Created;
            systemWatcherFROM_FPok.EnableRaisingEvents = true;
            systemWatcherFROM_FPok.SynchronizingObject = this;

            var systemWatcherFROM_FPerr = new FileSystemWatcher(@"C:\fiskcomp\exch\lnk\FROM_FP", "*.ERR");
            systemWatcherFROM_FPerr.NotifyFilter = NotifyFilters.CreationTime | NotifyFilters.FileName |
                                                     NotifyFilters.LastWrite;
            systemWatcherFROM_FPerr.Created += SystemWatcherFROM_FPerr_Created;
            systemWatcherFROM_FPerr.EnableRaisingEvents = true;
            systemWatcherFROM_FPerr.SynchronizingObject = this;

            var resultKonekcijaFiskalni = ProvjeriStatusFiskalnogPrintera();

            if (!resultKonekcijaFiskalni.Result)
            {
                // Poruka da fiskalni nije spojen.
                pnFiskalniNijeSpojen.Popup();
            }
            else
            {
                // Daj inforamcije iz fiskalnog
                InicijalizacijaInformacija();
                pnFiskalniSpojen.Popup();
            }
        }

        private void SystemWatcherFROM_FPerr_Created(object sender, FileSystemEventArgs e)
        {
            string value = File.ReadAllText(e.FullPath);

            bool unlocked = false;

            while (!unlocked)
            {
                unlocked = WaitForFile(e.FullPath);
            }

            pnFiskalniERR.ContentText = "Greška: " + value;
            pnFiskalniERR.Popup();
        }

        private void SystemWatcherFROM_FPok_Created(object sender, FileSystemEventArgs e)
        {
            string value = File.ReadAllText(e.FullPath);
            
            bool unlocked = false;

            while (!unlocked)
            {
                unlocked = WaitForFile(e.FullPath);
            }

            pnFiskalniOK.ContentText = "Broj računa: " + value;
            pnFiskalniOK.Popup();
        }

        private bool WaitForFile(string fullPath)
        {
            bool FileReady = false;
            while (!FileReady)
            {
                try
                {
                    using (File.Open(fullPath, FileMode.Open))
                    {
                        FileReady = true;
                    }
                }
                catch (IOException)
                {
                    //File isn't ready yet, so we need to keep on waiting until it is.
                }
                //We'll want to wait a bit between polls, if the file isn't ready.
                if (!FileReady) Thread.Sleep(1000);
            }
            return FileReady;
        }

        private async Task<bool> ProvjeriStatusFiskalnogPrintera()
        {
            bool result = await FiskalniPrinterController.StatusPrintera();

            return await Task.FromResult(result);
        }

        private async void InicijalizacijaInformacija()
        {
            List<string> printerInformacije = await FiskalniPrinterController.FiskalniPrinterInformacije();

            lblFactoryIdVar.Text = printerInformacije[0].ToString();
            lblTipPrinteraVar.Text = printerInformacije[1].ToString();
            lblIBFMVar.Text = printerInformacije[2].ToString();
            lblJIBVar.Text = printerInformacije[3].ToString();
            lblBrojIzvjestajaVar.Text = printerInformacije[4].ToString();
        }

        private void closeBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeBox_Click(object sender, EventArgs e)
        {
            pnServisPozadina.Popup();
            this.Hide();
            this.ShowInTaskbar = false;
        }

        private void prikaziProzorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.ShowInTaskbar = true;
        }

        private async void provjeriStatusPrinteraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool status = await FiskalniPrinterController.StatusPrintera();
            if (!status)
                pnFiskalniNijeSpojen.Popup();
            else
                pnFiskalniSpojen.Popup();
        }

        private async void dnevniIzvještajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool status = await FiskalniPrinterController.PrintajDnevniIzvjestaj();
            if (!status)
                pnGreskaKomunikacija.Popup();
            else
                pnDnevniIzvjestaj.Popup();
        }

        private async void presjekStanjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool status = await FiskalniPrinterController.PrintajPresjekStanja();
            if (!status)
                pnGreskaKomunikacija.Popup();
            else
                pnPresjekStanja.Popup();
        }

        private void periodičniIzvještajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var noviPeriodicniIzvjestajProzor = new PeriodicniWindowView();
            noviPeriodicniIzvjestajProzor.Show();
        }
    }
}
