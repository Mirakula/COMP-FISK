﻿using COMP_FISK.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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
            //dbfFileWatcher.EnableRaisingEvents = ToggleRisingEvents(dbfFileWatcher);
        }

        private bool ToggleRisingEvents(FileSystemWatcher dbfFileWatcher)
        {
            throw new NotImplementedException();
        }

        private void dbfWatcher_Created(object sender, FileSystemEventArgs e)
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
                var ControllerFiskalnihRacuna = new FiskalizacijaController();

                var brojRacuna = ControllerFiskalnihRacuna.PreuzmiRasporediStampaj(dbfRacun.Name, dbfRacun.FullName);
            }
        }

        // Metoda koja provjerajva da li je fajl zakljucan 
        // Pravi pauzu dok se fajl ne otkljuca
        // Slucaj za stampanje preko mreze.
        private bool WaitForFile(FileInfo fullFajlPath)
        {

            FileStream stream = null;
            bool FileReady = false;
            while (!FileReady)
            {
                try
                {
                    using (stream = fullFajlPath.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None))
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
