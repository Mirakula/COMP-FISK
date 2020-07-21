using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tring.Fiscal.Driver;

namespace COMP_FISK.Controllers
{
    public static class FiskalniPrinterController
    {
        public static async Task<bool> StatusPrintera()
        {
            var fp = new TringFiskalniPrinter();

            if (fp.Inicijalizacija("localhost", 8085, 0, "0"))
                return await Task.FromResult(true);
            else
                return await Task.FromResult(false);
        }

        public static async Task<List<string>> FiskalniPrinterInformacije()
        {
            var fp = new TringFiskalniPrinter();
            var odgovor = fp.OsnovneInformacije();
            var resultsList = new List<string>();

            if (odgovor.VrstaOdgovora == VrsteOdgovora.OK)
            {
                for (int i = 0; i < odgovor.Odgovori.Count - 3; i++)
                {
                    if (odgovor.Odgovori[i].Naziv == "FactoryId")
                        resultsList.Add(odgovor.Odgovori[i].Vrijednost.ToString());

                    if (odgovor.Odgovori[i].Naziv == "FMSignature")
                        resultsList.Add(odgovor.Odgovori[i].Vrijednost.ToString());

                    if (odgovor.Odgovori[i].Naziv == "IBFM")
                        resultsList.Add(odgovor.Odgovori[i].Vrijednost.ToString());

                    if (odgovor.Odgovori[i].Naziv == "JIB")
                        resultsList.Add(odgovor.Odgovori[i].Vrijednost.ToString());

                    if (odgovor.Odgovori[i].Naziv == "NumberOfDailyReports")
                        resultsList.Add(odgovor.Odgovori[i].Vrijednost.ToString());
                }
            }
            return await Task.FromResult(resultsList);
        }

        public static async Task<string> BrojDnevnihIzvjestaja()
        {
            var fp = new TringFiskalniPrinter();
            var odgovor = fp.OsnovneInformacije();

            if(odgovor.VrstaOdgovora == VrsteOdgovora.OK)
            {
                for (int i = 0; i < odgovor.Odgovori.Count; i++)
                {
                    if (odgovor.Odgovori[i].Naziv == "NumberOfDailyReports")
                        return await Task.FromResult(odgovor.Odgovori[i].Vrijednost.ToString());
                }
            }

            return "gre";
        }

        public static async Task<bool> PrintajDnevniIzvjestaj()
        {
            var fp = new TringFiskalniPrinter();
            var odgovor = fp.StampatiDnevniIzvjestaj();

            if (odgovor.VrstaOdgovora == VrsteOdgovora.OK)
                return await Task.FromResult(true);
            else
                return await Task.FromResult(false);
        }

        public static async Task<bool> PrintajPresjekStanja()
        {
            var fp = new TringFiskalniPrinter();
            var odgovor = fp.StampatiPresjekStanja();

            if (odgovor.VrstaOdgovora == VrsteOdgovora.OK)
                return await Task.FromResult(true);
            else
                return await Task.FromResult(false);
        }

        public static async Task<bool> PrintajPeriodicniIzvjestaj(DateTime odDatum, DateTime doDatum)
        {
            var fp = new TringFiskalniPrinter();
            var odgovor = fp.StampatiPeriodicniIzvjestaj(odDatum, doDatum);

            if (odgovor.VrstaOdgovora == VrsteOdgovora.OK)
                return await Task.FromResult(true);
            else
                return await Task.FromResult(false);
        }
    }
}
