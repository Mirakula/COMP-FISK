using COMP_FISK.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP_FISK.Controllers
{
    public class FiskalniDataGridViewController
    {
        public List<FolderItemsModel> DajSvePodatke(string putanja)
        {
            DirectoryInfo directory = new DirectoryInfo(putanja);
            FileInfo[] fileInfo = directory.GetFiles();
            var listaOdgovora = new List<FolderItemsModel>();

            foreach (FileInfo item in fileInfo)
            {
                var podaciOK = new FolderItemsModel
                {
                    Racun = item.Name.Trim(),
                    BR = File.ReadAllText(item.FullName.Trim()),
                    Vrijeme = item.LastWriteTime,
                    Status = item.Extension.Trim(),
                };

                listaOdgovora.Add(podaciOK);
            }
            return listaOdgovora;
        }
    }
}
