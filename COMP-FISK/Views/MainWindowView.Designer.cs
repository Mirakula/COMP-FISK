namespace COMP_FISK
{
    partial class MainWindowView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ContextMenuStrip contextMenu;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindowView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.prikaziProzorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.provjeriStatusPrinteraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dnevniIzvještajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.periodičniIzvještajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presjekStanjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skenerOnOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zatvoriAplikacijuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftPnl = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.topPnl = new System.Windows.Forms.Panel();
            this.minimizeBox = new System.Windows.Forms.PictureBox();
            this.closeBox = new System.Windows.Forms.PictureBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.pnFiskalniNijeSpojen = new Tulpep.NotificationWindow.PopupNotifier();
            this.pnFiskalniSpojen = new Tulpep.NotificationWindow.PopupNotifier();
            this.pnFiskalniOK = new Tulpep.NotificationWindow.PopupNotifier();
            this.pnFiskalniERR = new Tulpep.NotificationWindow.PopupNotifier();
            this.pnGreskaKomunikacija = new Tulpep.NotificationWindow.PopupNotifier();
            this.pnDnevniIzvjestaj = new Tulpep.NotificationWindow.PopupNotifier();
            this.pnPresjekStanja = new Tulpep.NotificationWindow.PopupNotifier();
            this.pnServisPozadina = new Tulpep.NotificationWindow.PopupNotifier();
            this.pnRestartTringServisa = new Tulpep.NotificationWindow.PopupNotifier();
            this.pnDnevniIzvjestajiLimit = new Tulpep.NotificationWindow.PopupNotifier();
            this.pnSkener = new Tulpep.NotificationWindow.PopupNotifier();
            this.pnDnevniIzvjestajiBlok = new Tulpep.NotificationWindow.PopupNotifier();
            this.restartTringServeraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvRacuniDataView = new System.Windows.Forms.DataGridView();
            contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            contextMenu.SuspendLayout();
            this.leftPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.topPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuniDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenu
            // 
            contextMenu.BackColor = System.Drawing.Color.White;
            contextMenu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikaziProzorToolStripMenuItem,
            this.provjeriStatusPrinteraToolStripMenuItem,
            this.dnevniIzvještajToolStripMenuItem,
            this.periodičniIzvještajToolStripMenuItem,
            this.presjekStanjaToolStripMenuItem,
            this.skenerOnOffToolStripMenuItem,
            this.zatvoriAplikacijuToolStripMenuItem});
            contextMenu.Name = "contextMenuStrip1";
            contextMenu.Size = new System.Drawing.Size(224, 186);
            // 
            // prikaziProzorToolStripMenuItem
            // 
            this.prikaziProzorToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.prikaziProzorToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.prikaziProzorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("prikaziProzorToolStripMenuItem.Image")));
            this.prikaziProzorToolStripMenuItem.Name = "prikaziProzorToolStripMenuItem";
            this.prikaziProzorToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.prikaziProzorToolStripMenuItem.Text = "Prikaži prozor";
            this.prikaziProzorToolStripMenuItem.Click += new System.EventHandler(this.prikaziProzorToolStripMenuItem_Click);
            // 
            // provjeriStatusPrinteraToolStripMenuItem
            // 
            this.provjeriStatusPrinteraToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.provjeriStatusPrinteraToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.provjeriStatusPrinteraToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("provjeriStatusPrinteraToolStripMenuItem.Image")));
            this.provjeriStatusPrinteraToolStripMenuItem.Name = "provjeriStatusPrinteraToolStripMenuItem";
            this.provjeriStatusPrinteraToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.provjeriStatusPrinteraToolStripMenuItem.Text = "Provjeri status printera";
            this.provjeriStatusPrinteraToolStripMenuItem.Click += new System.EventHandler(this.provjeriStatusPrinteraToolStripMenuItem_Click);
            // 
            // dnevniIzvještajToolStripMenuItem
            // 
            this.dnevniIzvještajToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.dnevniIzvještajToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.dnevniIzvještajToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dnevniIzvještajToolStripMenuItem.Image")));
            this.dnevniIzvještajToolStripMenuItem.Name = "dnevniIzvještajToolStripMenuItem";
            this.dnevniIzvještajToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.dnevniIzvještajToolStripMenuItem.Text = "Dnevni izvještaj";
            this.dnevniIzvještajToolStripMenuItem.Click += new System.EventHandler(this.dnevniIzvještajToolStripMenuItem_Click);
            // 
            // periodičniIzvještajToolStripMenuItem
            // 
            this.periodičniIzvještajToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.periodičniIzvještajToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.periodičniIzvještajToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("periodičniIzvještajToolStripMenuItem.Image")));
            this.periodičniIzvještajToolStripMenuItem.Name = "periodičniIzvještajToolStripMenuItem";
            this.periodičniIzvještajToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.periodičniIzvještajToolStripMenuItem.Text = "Periodični izvještaj";
            this.periodičniIzvještajToolStripMenuItem.Click += new System.EventHandler(this.periodičniIzvještajToolStripMenuItem_Click);
            // 
            // presjekStanjaToolStripMenuItem
            // 
            this.presjekStanjaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.presjekStanjaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.presjekStanjaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("presjekStanjaToolStripMenuItem.Image")));
            this.presjekStanjaToolStripMenuItem.Name = "presjekStanjaToolStripMenuItem";
            this.presjekStanjaToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.presjekStanjaToolStripMenuItem.Text = "Presjek stanja";
            this.presjekStanjaToolStripMenuItem.Click += new System.EventHandler(this.presjekStanjaToolStripMenuItem_Click);
            // 
            // skenerOnOffToolStripMenuItem
            // 
            this.skenerOnOffToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skenerOnOffToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.skenerOnOffToolStripMenuItem.Image = global::COMP_FISK.Properties.Resources.scanner;
            this.skenerOnOffToolStripMenuItem.Name = "skenerOnOffToolStripMenuItem";
            this.skenerOnOffToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.skenerOnOffToolStripMenuItem.Text = "Skener On/Off";
            this.skenerOnOffToolStripMenuItem.Click += new System.EventHandler(this.skenerOnOffToolStripMenuItem_Click);
            // 
            // zatvoriAplikacijuToolStripMenuItem
            // 
            this.zatvoriAplikacijuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.zatvoriAplikacijuToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.zatvoriAplikacijuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("zatvoriAplikacijuToolStripMenuItem.Image")));
            this.zatvoriAplikacijuToolStripMenuItem.Name = "zatvoriAplikacijuToolStripMenuItem";
            this.zatvoriAplikacijuToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.zatvoriAplikacijuToolStripMenuItem.Text = "Zatvori aplikaciju";
            this.zatvoriAplikacijuToolStripMenuItem.Click += new System.EventHandler(this.zatvoriAplikacijuToolStripMenuItem_Click);
            // 
            // leftPnl
            // 
            this.leftPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.leftPnl.Controls.Add(this.label1);
            this.leftPnl.Controls.Add(this.logoBox);
            this.leftPnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPnl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftPnl.Location = new System.Drawing.Point(0, 0);
            this.leftPnl.Name = "leftPnl";
            this.leftPnl.Size = new System.Drawing.Size(106, 320);
            this.leftPnl.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(10, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "COMP - 2000";
            // 
            // logoBox
            // 
            this.logoBox.Image = ((System.Drawing.Image)(resources.GetObject("logoBox.Image")));
            this.logoBox.Location = new System.Drawing.Point(19, 118);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(63, 57);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoBox.TabIndex = 0;
            this.logoBox.TabStop = false;
            // 
            // topPnl
            // 
            this.topPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.topPnl.Controls.Add(this.minimizeBox);
            this.topPnl.Controls.Add(this.closeBox);
            this.topPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPnl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topPnl.Location = new System.Drawing.Point(106, 0);
            this.topPnl.Name = "topPnl";
            this.topPnl.Size = new System.Drawing.Size(464, 20);
            this.topPnl.TabIndex = 1;
            // 
            // minimizeBox
            // 
            this.minimizeBox.Image = ((System.Drawing.Image)(resources.GetObject("minimizeBox.Image")));
            this.minimizeBox.Location = new System.Drawing.Point(427, 2);
            this.minimizeBox.Name = "minimizeBox";
            this.minimizeBox.Size = new System.Drawing.Size(15, 15);
            this.minimizeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeBox.TabIndex = 2;
            this.minimizeBox.TabStop = false;
            this.minimizeBox.Click += new System.EventHandler(this.minimizeBox_Click);
            // 
            // closeBox
            // 
            this.closeBox.Image = ((System.Drawing.Image)(resources.GetObject("closeBox.Image")));
            this.closeBox.Location = new System.Drawing.Point(446, 2);
            this.closeBox.Name = "closeBox";
            this.closeBox.Size = new System.Drawing.Size(15, 15);
            this.closeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeBox.TabIndex = 0;
            this.closeBox.TabStop = false;
            this.closeBox.Click += new System.EventHandler(this.closeBox_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = contextMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "COMP-FISK";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // pnFiskalniNijeSpojen
            // 
            this.pnFiskalniNijeSpojen.BodyColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.pnFiskalniNijeSpojen.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnFiskalniNijeSpojen.ContentColor = System.Drawing.Color.White;
            this.pnFiskalniNijeSpojen.ContentFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnFiskalniNijeSpojen.ContentHoverColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnFiskalniNijeSpojen.ContentPadding = new System.Windows.Forms.Padding(30, 5, 0, 0);
            this.pnFiskalniNijeSpojen.ContentText = "Komunikacija sa fiskalnim uređajem nije uspostavljena. Provjerite da li je fiskal" +
    "ni uređaj spojen na računar.";
            this.pnFiskalniNijeSpojen.Delay = 5000;
            this.pnFiskalniNijeSpojen.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnFiskalniNijeSpojen.Image = ((System.Drawing.Image)(resources.GetObject("pnFiskalniNijeSpojen.Image")));
            this.pnFiskalniNijeSpojen.ImagePadding = new System.Windows.Forms.Padding(15, 23, 0, 0);
            this.pnFiskalniNijeSpojen.ImageSize = new System.Drawing.Size(48, 48);
            this.pnFiskalniNijeSpojen.IsRightToLeft = false;
            this.pnFiskalniNijeSpojen.OptionsMenu = null;
            this.pnFiskalniNijeSpojen.ShowGrip = false;
            this.pnFiskalniNijeSpojen.Size = new System.Drawing.Size(400, 100);
            this.pnFiskalniNijeSpojen.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnFiskalniNijeSpojen.TitleFont = new System.Drawing.Font("Segoe UI", 9F);
            this.pnFiskalniNijeSpojen.TitleText = "";
            // 
            // pnFiskalniSpojen
            // 
            this.pnFiskalniSpojen.BodyColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.pnFiskalniSpojen.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnFiskalniSpojen.ContentColor = System.Drawing.Color.White;
            this.pnFiskalniSpojen.ContentFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnFiskalniSpojen.ContentHoverColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnFiskalniSpojen.ContentPadding = new System.Windows.Forms.Padding(35, 10, 0, 0);
            this.pnFiskalniSpojen.ContentText = "Komunikacija uspostavljena ! Fiskalizacija inicijalizovana !";
            this.pnFiskalniSpojen.Delay = 4000;
            this.pnFiskalniSpojen.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnFiskalniSpojen.Image = ((System.Drawing.Image)(resources.GetObject("pnFiskalniSpojen.Image")));
            this.pnFiskalniSpojen.ImagePadding = new System.Windows.Forms.Padding(15, 23, 0, 0);
            this.pnFiskalniSpojen.ImageSize = new System.Drawing.Size(48, 48);
            this.pnFiskalniSpojen.IsRightToLeft = false;
            this.pnFiskalniSpojen.OptionsMenu = null;
            this.pnFiskalniSpojen.ShowGrip = false;
            this.pnFiskalniSpojen.Size = new System.Drawing.Size(350, 100);
            this.pnFiskalniSpojen.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnFiskalniSpojen.TitleFont = new System.Drawing.Font("Segoe UI", 9F);
            this.pnFiskalniSpojen.TitleText = "";
            // 
            // pnFiskalniOK
            // 
            this.pnFiskalniOK.BodyColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.pnFiskalniOK.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnFiskalniOK.ContentColor = System.Drawing.Color.White;
            this.pnFiskalniOK.ContentFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnFiskalniOK.ContentHoverColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnFiskalniOK.ContentPadding = new System.Windows.Forms.Padding(25, 20, 0, 0);
            this.pnFiskalniOK.ContentText = "";
            this.pnFiskalniOK.Delay = 5000;
            this.pnFiskalniOK.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnFiskalniOK.Image = global::COMP_FISK.Properties.Resources.iconOK;
            this.pnFiskalniOK.ImagePadding = new System.Windows.Forms.Padding(15, 23, 0, 0);
            this.pnFiskalniOK.ImageSize = new System.Drawing.Size(48, 48);
            this.pnFiskalniOK.IsRightToLeft = false;
            this.pnFiskalniOK.OptionsMenu = null;
            this.pnFiskalniOK.ShowGrip = false;
            this.pnFiskalniOK.Size = new System.Drawing.Size(250, 100);
            this.pnFiskalniOK.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnFiskalniOK.TitleFont = new System.Drawing.Font("Segoe UI", 9F);
            this.pnFiskalniOK.TitleText = "";
            // 
            // pnFiskalniERR
            // 
            this.pnFiskalniERR.BodyColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.pnFiskalniERR.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnFiskalniERR.ContentColor = System.Drawing.Color.White;
            this.pnFiskalniERR.ContentFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnFiskalniERR.ContentHoverColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnFiskalniERR.ContentPadding = new System.Windows.Forms.Padding(25, 20, 0, 0);
            this.pnFiskalniERR.ContentText = "";
            this.pnFiskalniERR.Delay = 5000;
            this.pnFiskalniERR.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnFiskalniERR.Image = global::COMP_FISK.Properties.Resources.iconERR;
            this.pnFiskalniERR.ImagePadding = new System.Windows.Forms.Padding(15, 23, 0, 0);
            this.pnFiskalniERR.ImageSize = new System.Drawing.Size(48, 48);
            this.pnFiskalniERR.IsRightToLeft = false;
            this.pnFiskalniERR.OptionsMenu = null;
            this.pnFiskalniERR.ShowGrip = false;
            this.pnFiskalniERR.Size = new System.Drawing.Size(250, 100);
            this.pnFiskalniERR.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnFiskalniERR.TitleFont = new System.Drawing.Font("Segoe UI", 9F);
            this.pnFiskalniERR.TitleText = "";
            // 
            // pnGreskaKomunikacija
            // 
            this.pnGreskaKomunikacija.BodyColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.pnGreskaKomunikacija.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnGreskaKomunikacija.ContentColor = System.Drawing.Color.White;
            this.pnGreskaKomunikacija.ContentFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnGreskaKomunikacija.ContentHoverColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnGreskaKomunikacija.ContentPadding = new System.Windows.Forms.Padding(35, 10, 0, 0);
            this.pnGreskaKomunikacija.ContentText = "Greška u komunikaciji sa fiskalnim printerom !";
            this.pnGreskaKomunikacija.Delay = 5000;
            this.pnGreskaKomunikacija.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnGreskaKomunikacija.Image = global::COMP_FISK.Properties.Resources.iconERR;
            this.pnGreskaKomunikacija.ImagePadding = new System.Windows.Forms.Padding(15, 23, 0, 0);
            this.pnGreskaKomunikacija.ImageSize = new System.Drawing.Size(48, 48);
            this.pnGreskaKomunikacija.IsRightToLeft = false;
            this.pnGreskaKomunikacija.OptionsMenu = null;
            this.pnGreskaKomunikacija.ShowGrip = false;
            this.pnGreskaKomunikacija.Size = new System.Drawing.Size(350, 100);
            this.pnGreskaKomunikacija.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnGreskaKomunikacija.TitleFont = new System.Drawing.Font("Segoe UI", 9F);
            this.pnGreskaKomunikacija.TitleText = "";
            // 
            // pnDnevniIzvjestaj
            // 
            this.pnDnevniIzvjestaj.BodyColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.pnDnevniIzvjestaj.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnDnevniIzvjestaj.ContentColor = System.Drawing.Color.White;
            this.pnDnevniIzvjestaj.ContentFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnDnevniIzvjestaj.ContentHoverColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnDnevniIzvjestaj.ContentPadding = new System.Windows.Forms.Padding(35, 20, 0, 0);
            this.pnDnevniIzvjestaj.ContentText = "Dnevni izvještaj isprintan !";
            this.pnDnevniIzvjestaj.Delay = 4000;
            this.pnDnevniIzvjestaj.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnDnevniIzvjestaj.Image = global::COMP_FISK.Properties.Resources.iconOK;
            this.pnDnevniIzvjestaj.ImagePadding = new System.Windows.Forms.Padding(15, 23, 0, 0);
            this.pnDnevniIzvjestaj.ImageSize = new System.Drawing.Size(48, 48);
            this.pnDnevniIzvjestaj.IsRightToLeft = false;
            this.pnDnevniIzvjestaj.OptionsMenu = null;
            this.pnDnevniIzvjestaj.ShowGrip = false;
            this.pnDnevniIzvjestaj.Size = new System.Drawing.Size(330, 100);
            this.pnDnevniIzvjestaj.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnDnevniIzvjestaj.TitleFont = new System.Drawing.Font("Segoe UI", 9F);
            this.pnDnevniIzvjestaj.TitleText = "";
            // 
            // pnPresjekStanja
            // 
            this.pnPresjekStanja.BodyColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.pnPresjekStanja.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnPresjekStanja.ContentColor = System.Drawing.Color.White;
            this.pnPresjekStanja.ContentFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnPresjekStanja.ContentHoverColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnPresjekStanja.ContentPadding = new System.Windows.Forms.Padding(35, 20, 0, 0);
            this.pnPresjekStanja.ContentText = "Presjek stanja isprintan !";
            this.pnPresjekStanja.Delay = 4000;
            this.pnPresjekStanja.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnPresjekStanja.Image = global::COMP_FISK.Properties.Resources.iconOK;
            this.pnPresjekStanja.ImagePadding = new System.Windows.Forms.Padding(15, 23, 0, 0);
            this.pnPresjekStanja.ImageSize = new System.Drawing.Size(48, 48);
            this.pnPresjekStanja.IsRightToLeft = false;
            this.pnPresjekStanja.OptionsMenu = null;
            this.pnPresjekStanja.ShowGrip = false;
            this.pnPresjekStanja.Size = new System.Drawing.Size(300, 100);
            this.pnPresjekStanja.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnPresjekStanja.TitleFont = new System.Drawing.Font("Segoe UI", 9F);
            this.pnPresjekStanja.TitleText = "";
            // 
            // pnServisPozadina
            // 
            this.pnServisPozadina.BodyColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.pnServisPozadina.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnServisPozadina.ContentColor = System.Drawing.Color.White;
            this.pnServisPozadina.ContentFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnServisPozadina.ContentHoverColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnServisPozadina.ContentPadding = new System.Windows.Forms.Padding(35, 20, 0, 0);
            this.pnServisPozadina.ContentText = "Servis radi u pozadini.";
            this.pnServisPozadina.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnServisPozadina.Image = global::COMP_FISK.Properties.Resources.iconComp;
            this.pnServisPozadina.ImagePadding = new System.Windows.Forms.Padding(15, 23, 0, 0);
            this.pnServisPozadina.ImageSize = new System.Drawing.Size(48, 48);
            this.pnServisPozadina.IsRightToLeft = false;
            this.pnServisPozadina.OptionsMenu = null;
            this.pnServisPozadina.Scroll = false;
            this.pnServisPozadina.ShowGrip = false;
            this.pnServisPozadina.Size = new System.Drawing.Size(300, 100);
            this.pnServisPozadina.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnServisPozadina.TitleFont = new System.Drawing.Font("Segoe UI", 9F);
            this.pnServisPozadina.TitleText = "";
            // 
            // pnRestartTringServisa
            // 
            this.pnRestartTringServisa.BodyColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.pnRestartTringServisa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnRestartTringServisa.ContentColor = System.Drawing.Color.White;
            this.pnRestartTringServisa.ContentFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnRestartTringServisa.ContentHoverColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnRestartTringServisa.ContentPadding = new System.Windows.Forms.Padding(35, 20, 0, 0);
            this.pnRestartTringServisa.ContentText = "Tring servis restartovan !";
            this.pnRestartTringServisa.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnRestartTringServisa.Image = global::COMP_FISK.Properties.Resources.iconComp;
            this.pnRestartTringServisa.ImagePadding = new System.Windows.Forms.Padding(15, 23, 0, 0);
            this.pnRestartTringServisa.ImageSize = new System.Drawing.Size(48, 48);
            this.pnRestartTringServisa.IsRightToLeft = false;
            this.pnRestartTringServisa.OptionsMenu = null;
            this.pnRestartTringServisa.Scroll = false;
            this.pnRestartTringServisa.ShowGrip = false;
            this.pnRestartTringServisa.Size = new System.Drawing.Size(300, 100);
            this.pnRestartTringServisa.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnRestartTringServisa.TitleFont = new System.Drawing.Font("Segoe UI", 9F);
            this.pnRestartTringServisa.TitleText = "";
            // 
            // pnDnevniIzvjestajiLimit
            // 
            this.pnDnevniIzvjestajiLimit.BodyColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.pnDnevniIzvjestajiLimit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnDnevniIzvjestajiLimit.ContentColor = System.Drawing.Color.White;
            this.pnDnevniIzvjestajiLimit.ContentFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnDnevniIzvjestajiLimit.ContentHoverColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnDnevniIzvjestajiLimit.ContentPadding = new System.Windows.Forms.Padding(35, 10, 0, 0);
            this.pnDnevniIzvjestajiLimit.ContentText = "Fiskalni printer je prešao 1800 dnevnih izvještaja ! Maksimalni broj je 1995. Raz" +
    "mislite o servisiranju uređaja. ";
            this.pnDnevniIzvjestajiLimit.Delay = 6000;
            this.pnDnevniIzvjestajiLimit.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnDnevniIzvjestajiLimit.Image = global::COMP_FISK.Properties.Resources.iconComp;
            this.pnDnevniIzvjestajiLimit.ImagePadding = new System.Windows.Forms.Padding(15, 23, 0, 0);
            this.pnDnevniIzvjestajiLimit.ImageSize = new System.Drawing.Size(48, 48);
            this.pnDnevniIzvjestajiLimit.IsRightToLeft = false;
            this.pnDnevniIzvjestajiLimit.OptionsMenu = null;
            this.pnDnevniIzvjestajiLimit.Scroll = false;
            this.pnDnevniIzvjestajiLimit.ShowGrip = false;
            this.pnDnevniIzvjestajiLimit.Size = new System.Drawing.Size(400, 100);
            this.pnDnevniIzvjestajiLimit.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnDnevniIzvjestajiLimit.TitleFont = new System.Drawing.Font("Segoe UI", 9F);
            this.pnDnevniIzvjestajiLimit.TitleText = "";
            // 
            // pnSkener
            // 
            this.pnSkener.BodyColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.pnSkener.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnSkener.ContentColor = System.Drawing.Color.White;
            this.pnSkener.ContentFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnSkener.ContentHoverColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnSkener.ContentPadding = new System.Windows.Forms.Padding(35, 20, 0, 0);
            this.pnSkener.ContentText = "";
            this.pnSkener.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnSkener.Image = global::COMP_FISK.Properties.Resources.iconComp;
            this.pnSkener.ImagePadding = new System.Windows.Forms.Padding(15, 23, 0, 0);
            this.pnSkener.ImageSize = new System.Drawing.Size(48, 48);
            this.pnSkener.IsRightToLeft = false;
            this.pnSkener.OptionsMenu = null;
            this.pnSkener.Scroll = false;
            this.pnSkener.ShowGrip = false;
            this.pnSkener.Size = new System.Drawing.Size(250, 100);
            this.pnSkener.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnSkener.TitleFont = new System.Drawing.Font("Segoe UI", 9F);
            this.pnSkener.TitleText = "";
            // 
            // pnDnevniIzvjestajiBlok
            // 
            this.pnDnevniIzvjestajiBlok.AnimationDuration = 3000;
            this.pnDnevniIzvjestajiBlok.BodyColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.pnDnevniIzvjestajiBlok.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnDnevniIzvjestajiBlok.ContentColor = System.Drawing.Color.White;
            this.pnDnevniIzvjestajiBlok.ContentFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnDnevniIzvjestajiBlok.ContentHoverColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnDnevniIzvjestajiBlok.ContentPadding = new System.Windows.Forms.Padding(35, 10, 0, 0);
            this.pnDnevniIzvjestajiBlok.ContentText = "Uređaj je potrebno servisirati. Broj dnevnih izvještaja je došao do limita !";
            this.pnDnevniIzvjestajiBlok.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnDnevniIzvjestajiBlok.Image = global::COMP_FISK.Properties.Resources.iconComp;
            this.pnDnevniIzvjestajiBlok.ImagePadding = new System.Windows.Forms.Padding(15, 23, 0, 0);
            this.pnDnevniIzvjestajiBlok.ImageSize = new System.Drawing.Size(48, 48);
            this.pnDnevniIzvjestajiBlok.IsRightToLeft = false;
            this.pnDnevniIzvjestajiBlok.OptionsMenu = null;
            this.pnDnevniIzvjestajiBlok.Scroll = false;
            this.pnDnevniIzvjestajiBlok.ShowGrip = false;
            this.pnDnevniIzvjestajiBlok.Size = new System.Drawing.Size(400, 100);
            this.pnDnevniIzvjestajiBlok.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnDnevniIzvjestajiBlok.TitleFont = new System.Drawing.Font("Segoe UI", 9F);
            this.pnDnevniIzvjestajiBlok.TitleText = "";
            // 
            // restartTringServeraToolStripMenuItem
            // 
            this.restartTringServeraToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.restartTringServeraToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.restartTringServeraToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("restartTringServeraToolStripMenuItem.Image")));
            this.restartTringServeraToolStripMenuItem.Name = "restartTringServeraToolStripMenuItem";
            this.restartTringServeraToolStripMenuItem.Size = new System.Drawing.Size(270, 28);
            this.restartTringServeraToolStripMenuItem.Text = "Restart tring servera";
            // 
            // dgvRacuniDataView
            // 
            this.dgvRacuniDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRacuniDataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRacuniDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRacuniDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRacuniDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRacuniDataView.Location = new System.Drawing.Point(106, 20);
            this.dgvRacuniDataView.Name = "dgvRacuniDataView";
            this.dgvRacuniDataView.Size = new System.Drawing.Size(464, 300);
            this.dgvRacuniDataView.TabIndex = 2;
            // 
            // MainWindowView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(570, 320);
            this.Controls.Add(this.dgvRacuniDataView);
            this.Controls.Add(this.topPnl);
            this.Controls.Add(this.leftPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindowView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COMP-FISK";
            contextMenu.ResumeLayout(false);
            this.leftPnl.ResumeLayout(false);
            this.leftPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.topPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuniDataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPnl;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Panel topPnl;
        private System.Windows.Forms.PictureBox minimizeBox;
        private System.Windows.Forms.PictureBox closeBox;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem prikaziProzorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem provjeriStatusPrinteraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dnevniIzvještajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem periodičniIzvještajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presjekStanjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zatvoriAplikacijuToolStripMenuItem;
        private Tulpep.NotificationWindow.PopupNotifier pnFiskalniNijeSpojen;
        private Tulpep.NotificationWindow.PopupNotifier pnFiskalniSpojen;
        private Tulpep.NotificationWindow.PopupNotifier pnFiskalniOK;
        private Tulpep.NotificationWindow.PopupNotifier pnFiskalniERR;
        private Tulpep.NotificationWindow.PopupNotifier pnGreskaKomunikacija;
        private Tulpep.NotificationWindow.PopupNotifier pnDnevniIzvjestaj;
        private Tulpep.NotificationWindow.PopupNotifier pnPresjekStanja;
        private Tulpep.NotificationWindow.PopupNotifier pnServisPozadina;
        private Tulpep.NotificationWindow.PopupNotifier pnRestartTringServisa;
        private Tulpep.NotificationWindow.PopupNotifier pnDnevniIzvjestajiLimit;
        private System.Windows.Forms.ToolStripMenuItem skenerOnOffToolStripMenuItem;
        private Tulpep.NotificationWindow.PopupNotifier pnSkener;
        private Tulpep.NotificationWindow.PopupNotifier pnDnevniIzvjestajiBlok;
        private System.Windows.Forms.ToolStripMenuItem restartTringServeraToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvRacuniDataView;
    }
}

