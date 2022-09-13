using COMP_FISK.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Threading.Tasks;
using Tring.Fiscal.Driver;

namespace COMP_FISK.Controllers
{
    public class FiskalizacijaController
    {
        OdbcDataAdapter _adapter = new OdbcDataAdapter();

        Kupac _kupac = new Kupac();
        KasaOdgovor _odgovor = new KasaOdgovor();
        DataTable _dataTable = new DataTable();
        bool _fiskalni = false;
        bool _reklamni = false;
        string _brojReklamacijaDuplikacija;

        /// <summary>
        /// Metoda dobije 2 parametra. Naziv fajla i putanja fajla.
        /// Na osnovu toga metoda ima zadatak da izvuce sve podatke iz dbf-a
        /// Proslijedi modelu FiskalniRacun, provjeri podatke, te u koliko je sve
        /// ok sa podacima, forma se salje dalje u StampatiFiskalniRacun metodu.
        /// </summary>
        /// <param name="nazivFajla"></param>
        /// <param name="putanjaFajla"></param>
        /// <returns></returns>
        public async Task<string> PreuzmiRasporediStampaj(string nazivFajla, string putanjaFajla)
        {

             OdbcConnection _connection = new OdbcConnection("Driver={Microsoft Visual FoxPro Driver};SourceType=DBF;Exclusive=No;Collate=Machine;NULL=NO;DELETED=YES;BACKGROUNDFETCH=NO;SourceDB=" + putanjaFajla + ";");
            _adapter.SelectCommand = new OdbcCommand("SELECT * FROM " + putanjaFajla, _connection);
            _connection.Open();
            _adapter.Fill(_dataTable);
            _connection.Close();

            TringFiskalniPrinter _tringFiscal = new TringFiskalniPrinter();
            Racun _racun = new Racun();

            var data = (from rw in _dataTable.AsEnumerable()
                        select new RedDbfModel()
                        {
                            Art_id = Convert.ToString(rw["Art_id"]).Trim(),
                            Tax_id = (rw["Tax_id"].ToString().Trim().Length == 0) ? 0 : Convert.ToInt32(rw["Tax_id"]),
                            Art_desc = Convert.ToString(rw["Art_desc"]).Trim(),
                            Jed_mj = Convert.ToString(rw["Jed_mj"]).Trim(),
                            Art_price = Convert.ToDouble(rw["Art_price"]),
                            Sale_qty = Convert.ToDouble(rw["Sale_qty"]),
                            Disc_perc = Convert.ToDouble(rw["Disc_perc"])
                        }).ToList();

            var _vrstaRacuna = data[0].Art_desc.ToString()[1];

            var podaciArtikli = new List<RedDbfModel>();
            var podaciPlacanje = new List<RedDbfModel>();
            var podaciKupac = new List<RedDbfModel>();

            podaciArtikli = (from obj in data
                             where !string.IsNullOrEmpty(obj.Art_id)
                             where char.IsNumber(obj.Art_id[0])
                             select obj).ToList<RedDbfModel>();

            podaciKupac = (from obj in data
                           where obj.Art_id.StartsWith("Kupac")
                           select obj).ToList<RedDbfModel>();

            podaciPlacanje = (from obj in data
                              where obj.Art_id.StartsWith("PAY") && !(obj.Art_price == 0.0)
                              select obj).ToList<RedDbfModel>();


            // "\n" je za novi red na fiskalnom racunu
            _racun.Napomena = (from obj in data
                               where obj.Art_id.StartsWith("NAPOMENA")
                               select obj).First<RedDbfModel>().Art_desc.Trim() + "\n";


            if (_vrstaRacuna == '1')
            {
                _fiskalni = true;
            }
            else if (_vrstaRacuna == '3')
            {
                _reklamni = true;
                _brojReklamacijaDuplikacija = BrojRacunaReklamacijaDuplikacija(data[0].Art_desc.ToString());
                _racun.BrojRacuna = _brojReklamacijaDuplikacija;
            }
            else
            {
                _brojReklamacijaDuplikacija = BrojRacunaReklamacijaDuplikacija(data[0].Art_desc.ToString());
            }

            List<RedDbfModel>.Enumerator enumeracijaArtikliStavke;

            using (enumeracijaArtikliStavke = podaciArtikli.GetEnumerator())
            {
                while (true)
                {
                    bool prekid = enumeracijaArtikliStavke.MoveNext();

                    if (!prekid)
                        break;

                    RedDbfModel trenutniRed = enumeracijaArtikliStavke.Current;

                    var _artikal = new Artikal();
                    var _stavka = new RacunStavka();

                    if (!nazivFajla.StartsWith("abc_") && !nazivFajla.StartsWith("gee_"))
                        _artikal.Naziv = (trenutniRed.Art_desc.Length > 25) ? trenutniRed.Art_desc.Substring(0, 25) : trenutniRed.Art_desc;
                    else
                        _artikal.Naziv = "RN. " + _racun.Napomena;

                    _artikal.JM = (trenutniRed.Jed_mj.Length > 2) ? trenutniRed.Jed_mj.Substring(0, 2) : trenutniRed.Jed_mj;
                    _artikal.Cijena = trenutniRed.Art_price;
                    _artikal.Sifra = trenutniRed.Art_id;
                    _artikal.Stopa = OdrediVrstuPoreza(trenutniRed.Tax_id.ToString());

                    _stavka.artikal = _artikal;

                    if (trenutniRed.Sale_qty == 0)
                    {
                        return await Task.FromResult("Kolicina 0");
                    }
                    else
                    {
                        _stavka.Kolicina = trenutniRed.Sale_qty;
                    }
                    _stavka.Rabat = trenutniRed.Disc_perc;
                    _racun.StavkeRacuna.Add(_stavka);
                }
            }

            if (!_reklamni)
            {
                List<RedDbfModel>.Enumerator enumeratorPlacanje;
                using (enumeratorPlacanje = podaciPlacanje.GetEnumerator())
                {
                    enumeratorPlacanje.MoveNext();

                    RedDbfModel trenutniRed = enumeratorPlacanje.Current;

                    if (trenutniRed.Art_desc == "Gotovina" && trenutniRed.Art_price != 0.0)
                        _racun.DodajVrstuPlacanja(VrstePlacanja.Gotovina, trenutniRed.Art_price);

                    if (trenutniRed.Art_desc == "Virman" && trenutniRed.Art_price != 0.0)
                        _racun.DodajVrstuPlacanja(VrstePlacanja.Virman, trenutniRed.Art_price);

                    if (trenutniRed.Art_desc == "Cek" && trenutniRed.Art_price != 0.0)
                        _racun.DodajVrstuPlacanja(VrstePlacanja.Cek, trenutniRed.Art_price);

                    if (trenutniRed.Art_desc == "Kartica" && trenutniRed.Art_price != 0.0)
                        _racun.DodajVrstuPlacanja(VrstePlacanja.Kartica, trenutniRed.Art_price);
                }
            }

            if (!_reklamni)
            {
                if (podaciKupac[0].Art_desc.Length != 13 && podaciKupac[1].Art_desc.Length == 0 && podaciKupac[2].Art_desc.Length == 0 && podaciKupac[3].Art_desc.Length != 5 && podaciKupac[4].Art_desc.Length == 0)
                {
                    // podaci o kupcu nisu ispravni poruka
                }
                else
                {
                    _kupac.IDbroj = Convert.ToDouble(podaciKupac[0].Art_desc);
                    _kupac.Naziv = podaciKupac[1].Art_desc.Trim();
                    _kupac.Adresa = podaciKupac[2].Art_desc.Trim();
                    try
                    {
                        _kupac.PostanskiBroj = Convert.ToInt32(podaciKupac[3].Art_desc);
                    }
                    catch
                    {
                        _kupac.PostanskiBroj = 0;
                    }
                    _kupac.Grad = podaciKupac[4].Art_desc.Trim();

                    _racun.Kupac = _kupac;
                }
            }

            if (_fiskalni)
                _odgovor = _tringFiscal.StampatiFiskalniRacun(_racun);

            else if (_reklamni)
            {
                double povrat = 0.0d;
                using (List<RacunStavka>.Enumerator enumeratorStavkeRacuna = _racun.StavkeRacuna.GetEnumerator())
                {

                    while (true)
                    {
                        bool prekid = enumeratorStavkeRacuna.MoveNext();

                        if (!prekid)
                            break;

                        RacunStavka trenutniRed = enumeratorStavkeRacuna.Current;
                        povrat += trenutniRed.artikal.Cijena * trenutniRed.Kolicina;
                    }
                }
                // TODO: naci broj fiskalnog racuna za reklamaciju.
                _tringFiscal.UnosNovca(VrstePlacanja.Gotovina, Math.Round(povrat, 2));
                _odgovor = _tringFiscal.StampatiReklamiraniRacun(_racun);
            }
            else
            {
                _odgovor = _tringFiscal.StampatiDuplikatFiskalnogRacuna(Convert.ToDouble(_brojReklamacijaDuplikacija));
                return await Task.FromResult(_brojReklamacijaDuplikacija);
            }

            string rezultatFiskalizacije = Odgovor(_odgovor);
            return await Task.FromResult(rezultatFiskalizacije);
        }

        /// <summary>
        /// Metoda koja vraca
        /// vrstu poreske stope
        /// 1 -> "Ako je K poreska stopa",
        /// else ili 3 "Ako je E poreska stopa"
        /// </summary>
        /// <param name="broj"></param>
        /// <returns></returns>
        private VrstePoreskihStopa OdrediVrstuPoreza(string broj)
        {
            if (broj.Equals("1"))
                return VrstePoreskihStopa.K_Poreska_stopa_PDV_za_artikle_oslobodjene_PDV;
            else
                return VrstePoreskihStopa.E_Opca_poreska_stopa_PDV;
        }

        /// <summary>
        /// Odgovor sa fiskalnog printera
        /// </summary>
        /// <returns></returns>
        public string Odgovor(KasaOdgovor kasaOdgovor)
        {
            if (kasaOdgovor.VrstaOdgovora == VrsteOdgovora.OK)
            {
                for (int i = 0; i < kasaOdgovor.Odgovori.Count; i++)
                {
                    if (kasaOdgovor.Odgovori[i].Naziv == "BrojFiskalnogRacuna")
                        return kasaOdgovor.Odgovori[i].Vrijednost.ToString();
                }
            }

            else if (kasaOdgovor.VrstaOdgovora == VrsteOdgovora.Greska)
            {
                var odgovorGreske = kasaOdgovor.Odgovori[0].Naziv.ToString() + "\n" + kasaOdgovor.Odgovori[0].Vrijednost.ToString();
                return odgovorGreske;
            }
            else if (kasaOdgovor.VrstaOdgovora == VrsteOdgovora.Upozorenje)
            {
                for (int i = 0; i < kasaOdgovor.Odgovori.Count; i++)
                {
                    if (kasaOdgovor.Odgovori[i].Naziv == "Upozorenje")
                        return kasaOdgovor.Odgovori[i].Vrijednost.ToString();
                }
            }
            else
            {
                return null;
            }
            return null;
        }

        private string BrojRacunaReklamacijaDuplikacija(string broj)
        {
            return broj.Split(new char[] { '-' })[1];
        }
    }
}