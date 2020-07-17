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

namespace COMP_FISK
{
    public partial class MainWindowView : Form
    {

        // Nadgledaj direktoriji
        DbfFileWatcherController FileWatcher = new DbfFileWatcherController(@"C:\fiskcomp\exch\lnk\TO_FP");

        public MainWindowView()
        {
            InitializeComponent();
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
    }
}
