using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP_FISK.Controllers
{
    public static class FolderController
    {
        public static void KreirajDirektorije()
        {
            if (!Directory.Exists(Path.GetPathRoot(Environment.SystemDirectory) + "\\fiskcomp\\exch\\lnk\\TO_FP"))
                Directory.CreateDirectory(Path.GetPathRoot(Environment.SystemDirectory) + "\\fiskcomp\\exch\\lnk\\TO_FP");

            if (!Directory.Exists(Path.GetPathRoot(Environment.SystemDirectory) + "\\fiskcomp\\exch\\lnk\\FROM_FP"))
                Directory.CreateDirectory(Path.GetPathRoot(Environment.SystemDirectory) + "\\fiskcomp\\exch\\lnk\\FROM_FP");

            if (!Directory.Exists(Path.GetPathRoot(Environment.SystemDirectory) + "\\fiskcomp\\exch\\lnk\\comp"))
                Directory.CreateDirectory(Path.GetPathRoot(Environment.SystemDirectory) + "\\fiskcomp\\exch\\lnk\\comp");

            if (!Directory.Exists(Path.GetPathRoot(Environment.SystemDirectory) + "\\fiskcomp\\exch\\lnk\\Neodstampani"))
                Directory.CreateDirectory(Path.GetPathRoot(Environment.SystemDirectory) + "\\fiskcomp\\exch\\lnk\\Neodstampani");

            if (!File.Exists(Path.GetPathRoot(Environment.SystemDirectory) + "\\fiskcomp\\log.txt"))
                File.Create(Path.GetPathRoot(Environment.SystemDirectory) + "\\fiskcomp\\log.txt");
        }
    }
}
