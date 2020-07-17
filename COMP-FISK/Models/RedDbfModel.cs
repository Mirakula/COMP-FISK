using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP_FISK.Models
{
    public class RedDbfModel
    {
        public string Art_id { get; set; }
        public int Tax_id { get; set; }
        public string Art_desc { get; set; }
        public string Jed_mj { get; set; }
        public double Art_price { get; set; }
        public double Sale_qty { get; set; }
        public double Disc_perc { get; set; }
    }
}
