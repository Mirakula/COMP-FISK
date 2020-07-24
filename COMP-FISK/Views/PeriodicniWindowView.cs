using COMP_FISK.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP_FISK.Views
{
    public partial class PeriodicniWindowView : Form
    {
        public PeriodicniWindowView()
        {
            InitializeComponent();
        }
        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnPotvrdi_Click(object sender, EventArgs e)
        {
            this.Close();
            bool status = await FiskalniPrinterController.PrintajPeriodicniIzvjestaj(dtpDatumOd.Value, dtpDatumDo.Value);
            if (!status)
                pnGreskaKomunikacija.Popup();
            else
                pnDnevniIzvjestaj.Popup();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
