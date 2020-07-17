using COMP_FISK.Controllers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace COMP_FISK
{
    public partial class MainWindowView : Form
    {

        // Nadgledaj direktoriji


        public MainWindowView()
        {
            InitializeComponent();
            InicijalizacijaInformacija();
        }

        private async void InicijalizacijaInformacija()
        {
            List<string> printerInformacije = await FiskalniPrinterController.FiskalniPrinterInformacije();

            lblFactoryIdVar.Text = printerInformacije[0].ToString();
            lblTipPrinteraVar.Text = printerInformacije[1].ToString();
            lblIBFMVar.Text = printerInformacije[2].ToString();
            lblJIBVar.Text = printerInformacije[3].ToString();
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

        private void grbInformacije_Enter(object sender, EventArgs e)
        {

        }
    }
}
