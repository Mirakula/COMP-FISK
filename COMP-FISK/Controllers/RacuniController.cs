using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace COMP_FISK.Controllers
{
    public static class RacuniController
    {
        public static string ProvjeriStampan(string nazivFajla)
        {
            var putanjaOKFajl = @"C:\fiskcomp\exch\lnk\FROM_FP\" + Path.GetFileNameWithoutExtension(nazivFajla) + ".OK";

            if (File.Exists(putanjaOKFajl))
                return File.ReadAllText(putanjaOKFajl);
            else
                return null;
        }

        public static void UpisiOdgovorOK(string brojRacuna, string nazivFajla)
        {
            var putanjaFROM_FP = @"C:\fiskcomp\exch\lnk\FROM_FP";
            TextWriter odgovor = new StreamWriter(putanjaFROM_FP + @"\" + Path.GetFileNameWithoutExtension(nazivFajla) + ".OK");
            odgovor.WriteLine(brojRacuna);
            odgovor.Close();
            PremjestiDbf(@"C:\fiskcomp\exch\lnk\TO_FP\" + nazivFajla, @"C:\fiskcomp\exch\lnk\comp\" + nazivFajla);
            
        }

        public static void PremjestiDbf(string putanjaFajla, string destinacija)
        {
            var fajlBezExtenzije = Path.GetFileNameWithoutExtension(putanjaFajla);
            var fullPutanja = @"C:\fiskcomp\exch\lnk\Neodstampani\" + fajlBezExtenzije + ".dbf";

            if (File.Exists(fullPutanja))
            {
                File.Delete(fullPutanja);
                File.Move(putanjaFajla, destinacija);
            }
            else
                File.Move(putanjaFajla, destinacija);
        }

        public static void UpisiOdgovorERR(string greska, string nazivFajla)
        {
            var putanjaFROM_FP = @"C:\fiskcomp\exch\lnk\FROM_FP";
            TextWriter odgovor = new StreamWriter(putanjaFROM_FP + @"\" + Path.GetFileNameWithoutExtension(nazivFajla) + ".ERR");
            odgovor.Write(greska);
            odgovor.Close();
            PremjestiDbf(@"C:\fiskcomp\exch\lnk\TO_FP\" + nazivFajla, @"C:\fiskcomp\exch\lnk\Neodstampani\" + nazivFajla);
        }
    }
}
