using COMP_FISK.Controllers;
using COMP_FISK.Views;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP_FISK
{
    public partial class MainWindowView : Form
    {
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

            var result = FiskalniPrinterController.BrojDnevnihIzvjestaja();
            int brojDnevnihIzvjestaja = 0;

            if (result.Result == "gre")
            {
                pnFiskalniNijeSpojen.Popup();
            }
            else
            {
                brojDnevnihIzvjestaja = Convert.ToInt32(result.Result);
            }
            if (brojDnevnihIzvjestaja <= 1995) { }
            else
            {
                pnFiskalniSpojen.ContentText = "Uređaj je potrebno servisirati. Limit dnevnih izvještaja !";
                pnFiskalniSpojen.Popup();
            }

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
            DajPodatkeORacunima();
            StartMinimizirano();
        }

        private void StartMinimizirano()
        {
            this.Visible = false;
            this.ShowInTaskbar = false;
            this.WindowState = FormWindowState.Minimized;
        }

        private void DajPodatkeORacunima()
        {
            var stampaniPodaci = new FiskalniDataGridViewController();
            var podaci = stampaniPodaci.DajSvePodatke(@"C:\fiskcomp\exch\lnk\FROM_FP");
            var source = new BindingSource(podaci, null);
            dgvRacuniDataView.DataSource = source;
            dgvRacuniDataView.RowTemplate.Height = 35;
            dgvRacuniDataView.DefaultCellStyle.Font = new Font("Tahoma", 7, FontStyle.Bold);
            dgvRacuniDataView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
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

            // Provjeri dnevne izvjetaje


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
            DajPodatkeORacunima();
        }

        private void prikaziProzorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.ShowInTaskbar = true;
            DajPodatkeORacunima();
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

        private async void restartTringServeraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await RestartTringServerController.RestartServisa();

            pnRestartTringServisa.Popup();
        }
    }
}
