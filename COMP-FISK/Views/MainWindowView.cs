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
        FileSystemWatcher _watcher = new FileSystemWatcher()
        {
            NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.CreationTime,
            Path = @"C:\fiskcomp\exch\lnk\TO_FP",
            EnableRaisingEvents = true,
        };

        public List<string> printerInformacije = new List<string>();

        public MainWindowView()
        {
            InitializeComponent();
            StartMinimizirano();
            ProvjeriKonekcijuFiskalni();
            DajPodatkeORacunima();

            _watcher.SynchronizingObject = this;
            _watcher.EnableRaisingEvents = true;
            _watcher.Created += dbfWatcher_Created;
        }

        private void ProvjeriKonekcijuFiskalni()
        {
            var spojen = Task.Run(async () => await FiskalniPrinterController.StatusPrintera());

            if (spojen.Result)
                pnFiskalniSpojen.Popup();
            else
                pnFiskalniNijeSpojen.Popup();
        }

        private async Task<bool> DnevniIzvjestajiProvjera()
        {
            var printerInformacije = await FiskalniPrinterController.FiskalniPrinterInformacije();
            
            if (printerInformacije.Count != 0)
            {
                if (Convert.ToInt32(printerInformacije[4]) >= 1800 && Convert.ToInt32(printerInformacije[4]) <= 1990)
                {
                    pnDnevniIzvjestajiLimit.Popup();
                    return true;
                }
                else if(Convert.ToInt32(printerInformacije[4]) >= 1992)
                {
                    _watcher.EnableRaisingEvents = false;
                    pnDnevniIzvjestajiBlok.ContentText = "Fiskalizacija onemogućena. Uređaj je prešao dozvoljeni limit dnevnih izvještaja 1990. Kontaktirajte tehničku podršku.";
                    pnDnevniIzvjestajiBlok.Popup();
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        private async void dbfWatcher_Created(object sender, FileSystemEventArgs e)
        {
            // Dobavi samo dbf fajlove iz TO_FP
            DirectoryInfo directory = new DirectoryInfo(@"C:\fiskcomp\exch\lnk\TO_FP");
            FileInfo[] fileInfo = directory.GetFiles();
            
            foreach (FileInfo dbfRacun in fileInfo)
            {
                if (Path.GetExtension(dbfRacun.Name) == ".xxx")
                    Thread.Sleep(200);
            }

            DirectoryInfo directoryWaited = new DirectoryInfo(@"C:\fiskcomp\exch\lnk\TO_FP");
            FileInfo[] fileInfoWaited = directoryWaited.GetFiles();

            foreach (FileInfo dbfRacun in fileInfoWaited)
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
                        pnFiskalniOK.ContentText = "Broj računa: " + brojRacuna;
                        pnFiskalniOK.Popup();
                    }
                    else
                    {
                        RacuniController.UpisiOdgovorERR(brojRacuna, dbfRacun.Name);
                        pnFiskalniERR.ContentText = "Greška: " + brojRacuna;
                        pnFiskalniERR.Popup();
                    }
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

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.Visible = true;
            this.ShowInTaskbar = true;
            this.WindowState = FormWindowState.Normal;
        }

        private async void skenerOnOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = await DnevniIzvjestajiProvjera();
            
            if (result)
            {
                if (_watcher.EnableRaisingEvents == true)
                {
                    _watcher.EnableRaisingEvents = false;
                    pnSkener.ContentText = "Skener isključen !";
                    pnSkener.Popup();
                }
                else
                {
                    _watcher.EnableRaisingEvents = true;
                    pnSkener.ContentText = "Skener uključen !";
                    pnSkener.Popup();
                }
            }
            else
            {
                pnDnevniIzvjestajiBlok.Popup();
                _watcher.EnableRaisingEvents = false;
            }
        }

        private void zatvoriAplikacijuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
