using COMP_FISK.Controllers;
using COMP_FISK.Models;
using COMP_FISK.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace COMP_FISK
{
    public partial class MainWindowView : Form
    {
        public MainWindowView()
        {
            InitializeComponent();
            StartMinimizirano();
            DbfSystemWatcher();
            OkSystemWatcher();
            ErrSystemWatcher();
            InicijalizacijaInformacija();
            DajPodatkeORacunima();
        }

        private void ErrSystemWatcher()
        {
            string putanja = @"C:\fiskcomp\exch\lnk\FROM_FP";
            string ekstenzija = "*.ERR";

            var ErrWatcher = new FileSystemWatcher(putanja, ekstenzija);
            ErrWatcher.EnableRaisingEvents = true;
            ErrWatcher.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.CreationTime |
                              NotifyFilters.FileName;
            ErrWatcher.Created += ErrWatcher_Created;
        }

        private void OkSystemWatcher()
        {
            string putanja = @"C:\fiskcomp\exch\lnk\FROM_FP";
            string ekstenzija = "*.OK";

            var OkWatcher = new FileSystemWatcher(putanja, ekstenzija);
            OkWatcher.EnableRaisingEvents = true;
            OkWatcher.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.CreationTime |
                              NotifyFilters.FileName;
            OkWatcher.Created += OkWatcher_Created;
        }

        private void DbfSystemWatcher()
        {
            string putanja = @"C:\fiskcomp\exch\lnk\TO_FP";
            string ekstenzija = "*.dbf";

            var dbfWatcher = new FileSystemWatcher(putanja, ekstenzija);
            dbfWatcher.EnableRaisingEvents = true;
            dbfWatcher.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.CreationTime |
                                          NotifyFilters.FileName;
            dbfWatcher.Created += dbfWatcher_Created;
        }

        private void ErrWatcher_Created(object sender, FileSystemEventArgs e)
        {
            DirectoryInfo directory = new DirectoryInfo(@"C:\fiskcomp\exch\lnk\TO_FP");
            FileInfo[] fileInfo = directory.GetFiles("*.ERR");

            foreach (FileInfo file in fileInfo)
            {
                bool unlocked = false;

                while (!unlocked)
                {
                    unlocked = WaitForFile(file);
                }
            }

            pnFiskalniERR.ContentText = File.ReadAllText(e.FullPath);
            pnFiskalniERR.Popup();
        }

        private void OkWatcher_Created(object sender, FileSystemEventArgs e)
        {
            DirectoryInfo directory = new DirectoryInfo(@"C:\fiskcomp\exch\lnk\TO_FP");
            FileInfo[] fileInfo = directory.GetFiles("*.OK");

            foreach (FileInfo file in fileInfo)
            {
                bool unlocked = false;

                while (!unlocked)
                {
                    unlocked = WaitForFile(file);
                }
            }

            pnFiskalniOK.ContentText = File.ReadAllText(e.FullPath);
            pnFiskalniOK.Popup();
        }

        private async void dbfWatcher_Created(object sender, FileSystemEventArgs e)
        {
            // Dobavi samo dbf fajlove iz TO_FP
            DirectoryInfo directory = new DirectoryInfo(@"C:\fiskcomp\exch\lnk\TO_FP");
            FileInfo[] fileInfo = directory.GetFiles("*.dbf");

            // Provjeri da li je fajl zakljucan
            foreach (FileInfo file in fileInfo)
            {
                bool unlocked = false;

                while (!unlocked)
                {
                    unlocked = WaitForFile(file);
                }
            }

            // Za svaki racun pravimo novu instancu
            // Preuzimamo podatke, sortiramo ih
            // Onda saljemo sortirane podatke u objekat FiskalniRacun 
            // Taj objekat saljemo na stampu
            foreach (FileInfo dbfRacun in fileInfo)
            {
                var stampan = RacuniController.ProvjeriStampan(dbfRacun.Name);
                if (stampan == null)
                {
                    var ControllerFiskalnihRacuna = new FiskalizacijaController();
                    var brojRacuna = await ControllerFiskalnihRacuna.PreuzmiRasporediStampaj(dbfRacun.Name, dbfRacun.FullName);
                    var rezultatFiskalizacije = char.IsNumber(brojRacuna[0]);

                    Thread.Sleep(1000);
                    if (rezultatFiskalizacije)
                    {
                        RacuniController.UpisiOdgovorOK(brojRacuna, dbfRacun.Name);
                    }
                    else
                        RacuniController.UpisiOdgovorERR(brojRacuna, dbfRacun.Name);
                }
                else
                {
                    string putanjaFajla = dbfRacun.FullName;
                    string destinacija = @"C:\fiskcomp\exch\lnk\comp\" + dbfRacun.Name;
                    RacuniController.PremjestiDbf(putanjaFajla, destinacija);
                    break;
                }
            }
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
            dgvRacuniDataView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvRacuniDataView.Columns[1].Width = 75;
        }

        private bool WaitForFile(FileInfo fullFajlPath)
        {
            bool FileReady = false;
            while (!FileReady)
            {
                try
                {
                    using (FileStream stream = fullFajlPath.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None))
                    {
                        FileReady = true;
                    }
                }
                catch (IOException)
                {
                    //File isn't ready yet, so we need to keep on waiting until it is.
                }
                //We'll want to wait a bit between polls, if the file isn't ready.
                if (!FileReady) Thread.Sleep(2000);
            }
            return FileReady;
        }

        private async void InicijalizacijaInformacija()
        {
            List<string> printerInformacije = await FiskalniPrinterController.FiskalniPrinterInformacije();

            if (printerInformacije.Count != 0)
            {
                lblFactoryIdVar.Text = printerInformacije[0].ToString();
                lblTipPrinteraVar.Text = printerInformacije[1].ToString();
                lblIBFMVar.Text = printerInformacije[2].ToString();
                lblJIBVar.Text = printerInformacije[3].ToString();
                lblBrojIzvjestajaVar.Text = printerInformacije[4].ToString();
            }
            else
            {
                pnFiskalniNijeSpojen.Popup();
            }

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
            this.WindowState = FormWindowState.Minimized;
            DajPodatkeORacunima();
        }

        private void prikaziProzorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.Visible = true;
            this.ShowInTaskbar = true;
            this.WindowState = FormWindowState.Normal;
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
