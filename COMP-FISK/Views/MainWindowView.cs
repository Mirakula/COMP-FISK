using COMP_FISK.Controllers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP_FISK
{
    public partial class MainWindowView : Form
    {
        public MainWindowView()
        {
            InitializeComponent();
            var resultKonekcijaFiskalni = ProvjeriStatusFiskalnogPrintera();

            if (!resultKonekcijaFiskalni.Result)
            {
                // Poruka da fiskalni nije spojen.
            }
            else
            {
                // Daj inforamcije iz fiskalnog
                InicijalizacijaInformacija();
            }
        }

        private async Task<bool> ProvjeriStatusFiskalnogPrintera()
        {
            bool result = await FiskalniPrinterController.StatusPrintera();

            return await Task.FromResult(result);
        }

        private async void InicijalizacijaInformacija()
        {
            List<string> printerInformacije = await FiskalniPrinterController.FiskalniPrinterInformacije();

            lblFactoryIdVar.Text = printerInformacije[0].ToString();
            lblTipPrinteraVar.Text = printerInformacije[1].ToString();
            lblIBFMVar.Text = printerInformacije[2].ToString();
            lblJIBVar.Text = printerInformacije[3].ToString();
            lblBrojIzvjestajaVar.Text = printerInformacije[4].ToString();
        }

        private void closeBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.ShowInTaskbar = false;
        }

        private void prikaziProzorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.ShowInTaskbar = true;
        }
    }
}
