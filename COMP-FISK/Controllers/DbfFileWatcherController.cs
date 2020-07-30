using COMP_FISK.Models;
using COMP_FISK.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace COMP_FISK.Controllers
{
    public class DbfFileWatcherController
    {
        public DbfFileWatcherController(string putanja)
        {
            var dbfFileWatcher = new FileSystemWatcher(putanja, "*.dbf");
            dbfFileWatcher.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.CreationTime |
                                          NotifyFilters.FileName;
            dbfFileWatcher.Created += dbfWatcher_Created;

            // provjere oko inicajlizacije i dobavljanje podataka.
            var resultDnevniIzvjestaji = FiskalniPrinterController.BrojDnevnihIzvjestaja();
            var resultStatusPrintera = FiskalniPrinterController.StatusPrintera();
            int brojDnevnihIzvjestaja = 0;

            if (!resultStatusPrintera.Result)
            {

            }
            else
            {
                brojDnevnihIzvjestaja = Convert.ToInt32(resultDnevniIzvjestaji.Result);
            }
            if (brojDnevnihIzvjestaja <= 1995 )
                dbfFileWatcher.EnableRaisingEvents = true;
            else
                dbfFileWatcher.EnableRaisingEvents = false;
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
                if(stampan == null)
                {
                    var ControllerFiskalnihRacuna = new FiskalizacijaController();
                    var brojRacuna = await ControllerFiskalnihRacuna.PreuzmiRasporediStampaj(dbfRacun.Name, dbfRacun.FullName);
                    var rezultatFiskalizacije = char.IsNumber(brojRacuna[0]);

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

        // Metoda koja provjerajva da li je fajl zakljucan 
        // Pravi pauzu dok se fajl ne otkljuca
        // Slucaj za stampanje preko mreze.
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
    }
}
