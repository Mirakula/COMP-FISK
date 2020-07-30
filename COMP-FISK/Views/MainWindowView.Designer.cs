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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.prikaziProzorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.provjeriStatusPrinteraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dnevniIzvještajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.periodičniIzvještajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presjekStanjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartTringServeraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zatvoriAplikacijuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftPnl = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.grbInformacije = new System.Windows.Forms.GroupBox();
            this.lblIBFMVar = new System.Windows.Forms.Label();
            this.lblJIBVar = new System.Windows.Forms.Label();
            this.lblFactoryIdVar = new System.Windows.Forms.Label();
            this.lblJIB = new System.Windows.Forms.Label();
            this.lblIBFM = new System.Windows.Forms.Label();
            this.lblFactoryId = new System.Windows.Forms.Label();
            this.lblBrojIzvjestajaVar = new System.Windows.Forms.Label();
            this.lblTipPrinteraVar = new System.Windows.Forms.Label();
            this.lblBrjDnevnihIzvjestaja = new System.Windows.Forms.Label();
            this.lblTipPrintera = new System.Windows.Forms.Label();
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
            this.dgvRacuniDataView = new System.Windows.Forms.DataGridView();
            this.pnRestartTringServisa = new Tulpep.NotificationWindow.PopupNotifier();
            this.pnDnevniIzvjestaji = new Tulpep.NotificationWindow.PopupNotifier();
            contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            contextMenu.SuspendLayout();
            this.leftPnl.SuspendLayout();
            this.grbInformacije.SuspendLayout();
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
            contextMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikaziProzorToolStripMenuItem,
            this.provjeriStatusPrinteraToolStripMenuItem,
            this.dnevniIzvještajToolStripMenuItem,
            this.periodičniIzvještajToolStripMenuItem,
            this.presjekStanjaToolStripMenuItem,
            this.restartTringServeraToolStripMenuItem,
            this.zatvoriAplikacijuToolStripMenuItem});
            contextMenu.Name = "contextMenuStrip1";
            contextMenu.Size = new System.Drawing.Size(244, 186);
            // 
            // prikaziProzorToolStripMenuItem
            // 
            this.prikaziProzorToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.prikaziProzorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("prikaziProzorToolStripMenuItem.Image")));
            this.prikaziProzorToolStripMenuItem.Name = "prikaziProzorToolStripMenuItem";
            this.prikaziProzorToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.prikaziProzorToolStripMenuItem.Text = "Prikaži prozor";
            this.prikaziProzorToolStripMenuItem.Click += new System.EventHandler(this.prikaziProzorToolStripMenuItem_Click);
            // 
            // provjeriStatusPrinteraToolStripMenuItem
            // 
            this.provjeriStatusPrinteraToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.provjeriStatusPrinteraToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("provjeriStatusPrinteraToolStripMenuItem.Image")));
            this.provjeriStatusPrinteraToolStripMenuItem.Name = "provjeriStatusPrinteraToolStripMenuItem";
            this.provjeriStatusPrinteraToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.provjeriStatusPrinteraToolStripMenuItem.Text = "Provjeri status printera";
            this.provjeriStatusPrinteraToolStripMenuItem.Click += new System.EventHandler(this.provjeriStatusPrinteraToolStripMenuItem_Click);
            // 
            // dnevniIzvještajToolStripMenuItem
            // 
            this.dnevniIzvještajToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.dnevniIzvještajToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dnevniIzvještajToolStripMenuItem.Image")));
            this.dnevniIzvještajToolStripMenuItem.Name = "dnevniIzvještajToolStripMenuItem";
            this.dnevniIzvještajToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.dnevniIzvještajToolStripMenuItem.Text = "Dnevni izvještaj";
            this.dnevniIzvještajToolStripMenuItem.Click += new System.EventHandler(this.dnevniIzvještajToolStripMenuItem_Click);
            // 
            // periodičniIzvještajToolStripMenuItem
            // 
            this.periodičniIzvještajToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.periodičniIzvještajToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("periodičniIzvještajToolStripMenuItem.Image")));
            this.periodičniIzvještajToolStripMenuItem.Name = "periodičniIzvještajToolStripMenuItem";
            this.periodičniIzvještajToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.periodičniIzvještajToolStripMenuItem.Text = "Periodični izvještaj";
            this.periodičniIzvještajToolStripMenuItem.Click += new System.EventHandler(this.periodičniIzvještajToolStripMenuItem_Click);
            // 
            // presjekStanjaToolStripMenuItem
            // 
            this.presjekStanjaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.presjekStanjaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("presjekStanjaToolStripMenuItem.Image")));
            this.presjekStanjaToolStripMenuItem.Name = "presjekStanjaToolStripMenuItem";
            this.presjekStanjaToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.presjekStanjaToolStripMenuItem.Text = "Presjek stanja";
            this.presjekStanjaToolStripMenuItem.Click += new System.EventHandler(this.presjekStanjaToolStripMenuItem_Click);
            // 
            // restartTringServeraToolStripMenuItem
            // 
            this.restartTringServeraToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.restartTringServeraToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("restartTringServeraToolStripMenuItem.Image")));
            this.restartTringServeraToolStripMenuItem.Name = "restartTringServeraToolStripMenuItem";
            this.restartTringServeraToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.restartTringServeraToolStripMenuItem.Text = "Restart tring servera";
            this.restartTringServeraToolStripMenuItem.Click += new System.EventHandler(this.restartTringServeraToolStripMenuItem_Click);
            // 
            // zatvoriAplikacijuToolStripMenuItem
            // 
            this.zatvoriAplikacijuToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.zatvoriAplikacijuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("zatvoriAplikacijuToolStripMenuItem.Image")));
            this.zatvoriAplikacijuToolStripMenuItem.Name = "zatvoriAplikacijuToolStripMenuItem";
            this.zatvoriAplikacijuToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.zatvoriAplikacijuToolStripMenuItem.Text = "Zatvori aplikaciju";
            // 
            // leftPnl
            // 
            this.leftPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.leftPnl.Controls.Add(this.label1);
            this.leftPnl.Controls.Add(this.grbInformacije);
            this.leftPnl.Controls.Add(this.logoBox);
            this.leftPnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPnl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftPnl.Location = new System.Drawing.Point(0, 0);
            this.leftPnl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.leftPnl.Name = "leftPnl";
            this.leftPnl.Size = new System.Drawing.Size(267, 394);
            this.leftPnl.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(81, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "COMP - 2000";
            // 
            // grbInformacije
            // 
            this.grbInformacije.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.grbInformacije.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grbInformacije.Controls.Add(this.lblIBFMVar);
            this.grbInformacije.Controls.Add(this.lblJIBVar);
            this.grbInformacije.Controls.Add(this.lblFactoryIdVar);
            this.grbInformacije.Controls.Add(this.lblJIB);
            this.grbInformacije.Controls.Add(this.lblIBFM);
            this.grbInformacije.Controls.Add(this.lblFactoryId);
            this.grbInformacije.Controls.Add(this.lblBrojIzvjestajaVar);
            this.grbInformacije.Controls.Add(this.lblTipPrinteraVar);
            this.grbInformacije.Controls.Add(this.lblBrjDnevnihIzvjestaja);
            this.grbInformacije.Controls.Add(this.lblTipPrintera);
            this.grbInformacije.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbInformacije.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInformacije.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.grbInformacije.Location = new System.Drawing.Point(11, 154);
            this.grbInformacije.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbInformacije.Name = "grbInformacije";
            this.grbInformacije.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbInformacije.Size = new System.Drawing.Size(247, 226);
            this.grbInformacije.TabIndex = 4;
            this.grbInformacije.TabStop = false;
            this.grbInformacije.Text = "Informacije";
            // 
            // lblIBFMVar
            // 
            this.lblIBFMVar.AutoSize = true;
            this.lblIBFMVar.Location = new System.Drawing.Point(64, 175);
            this.lblIBFMVar.Name = "lblIBFMVar";
            this.lblIBFMVar.Size = new System.Drawing.Size(0, 18);
            this.lblIBFMVar.TabIndex = 9;
            // 
            // lblJIBVar
            // 
            this.lblJIBVar.AutoSize = true;
            this.lblJIBVar.Location = new System.Drawing.Point(64, 143);
            this.lblJIBVar.Name = "lblJIBVar";
            this.lblJIBVar.Size = new System.Drawing.Size(0, 18);
            this.lblJIBVar.TabIndex = 8;
            // 
            // lblFactoryIdVar
            // 
            this.lblFactoryIdVar.AutoSize = true;
            this.lblFactoryIdVar.Location = new System.Drawing.Point(119, 112);
            this.lblFactoryIdVar.Name = "lblFactoryIdVar";
            this.lblFactoryIdVar.Size = new System.Drawing.Size(0, 18);
            this.lblFactoryIdVar.TabIndex = 7;
            // 
            // lblJIB
            // 
            this.lblJIB.AutoSize = true;
            this.lblJIB.Location = new System.Drawing.Point(9, 143);
            this.lblJIB.Name = "lblJIB";
            this.lblJIB.Size = new System.Drawing.Size(38, 18);
            this.lblJIB.TabIndex = 6;
            this.lblJIB.Text = "JIB:";
            // 
            // lblIBFM
            // 
            this.lblIBFM.AutoSize = true;
            this.lblIBFM.Location = new System.Drawing.Point(9, 175);
            this.lblIBFM.Name = "lblIBFM";
            this.lblIBFM.Size = new System.Drawing.Size(52, 18);
            this.lblIBFM.TabIndex = 5;
            this.lblIBFM.Text = "IBFM:";
            // 
            // lblFactoryId
            // 
            this.lblFactoryId.AutoSize = true;
            this.lblFactoryId.Location = new System.Drawing.Point(9, 112);
            this.lblFactoryId.Name = "lblFactoryId";
            this.lblFactoryId.Size = new System.Drawing.Size(90, 18);
            this.lblFactoryId.TabIndex = 4;
            this.lblFactoryId.Text = "Factory Id:";
            // 
            // lblBrojIzvjestajaVar
            // 
            this.lblBrojIzvjestajaVar.AutoSize = true;
            this.lblBrojIzvjestajaVar.Location = new System.Drawing.Point(131, 79);
            this.lblBrojIzvjestajaVar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBrojIzvjestajaVar.Name = "lblBrojIzvjestajaVar";
            this.lblBrojIzvjestajaVar.Size = new System.Drawing.Size(0, 18);
            this.lblBrojIzvjestajaVar.TabIndex = 3;
            // 
            // lblTipPrinteraVar
            // 
            this.lblTipPrinteraVar.AutoSize = true;
            this.lblTipPrinteraVar.Location = new System.Drawing.Point(131, 47);
            this.lblTipPrinteraVar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipPrinteraVar.Name = "lblTipPrinteraVar";
            this.lblTipPrinteraVar.Size = new System.Drawing.Size(0, 18);
            this.lblTipPrinteraVar.TabIndex = 2;
            // 
            // lblBrjDnevnihIzvjestaja
            // 
            this.lblBrjDnevnihIzvjestaja.AutoSize = true;
            this.lblBrjDnevnihIzvjestaja.Location = new System.Drawing.Point(8, 79);
            this.lblBrjDnevnihIzvjestaja.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBrjDnevnihIzvjestaja.Name = "lblBrjDnevnihIzvjestaja";
            this.lblBrjDnevnihIzvjestaja.Size = new System.Drawing.Size(112, 18);
            this.lblBrjDnevnihIzvjestaja.TabIndex = 1;
            this.lblBrjDnevnihIzvjestaja.Text = "No. izvjestaji:";
            // 
            // lblTipPrintera
            // 
            this.lblTipPrintera.AutoSize = true;
            this.lblTipPrintera.Location = new System.Drawing.Point(9, 47);
            this.lblTipPrintera.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipPrintera.Name = "lblTipPrintera";
            this.lblTipPrintera.Size = new System.Drawing.Size(101, 18);
            this.lblTipPrintera.TabIndex = 0;
            this.lblTipPrintera.Text = "Tip printera:";
            // 
            // logoBox
            // 
            this.logoBox.Image = ((System.Drawing.Image)(resources.GetObject("logoBox.Image")));
            this.logoBox.Location = new System.Drawing.Point(99, 37);
            this.logoBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(84, 70);
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
            this.topPnl.Location = new System.Drawing.Point(267, 0);
            this.topPnl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.topPnl.Name = "topPnl";
            this.topPnl.Size = new System.Drawing.Size(483, 25);
            this.topPnl.TabIndex = 1;
            // 
            // minimizeBox
            // 
            this.minimizeBox.Image = ((System.Drawing.Image)(resources.GetObject("minimizeBox.Image")));
            this.minimizeBox.Location = new System.Drawing.Point(431, 2);
            this.minimizeBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.minimizeBox.Name = "minimizeBox";
            this.minimizeBox.Size = new System.Drawing.Size(20, 18);
            this.minimizeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeBox.TabIndex = 2;
            this.minimizeBox.TabStop = false;
            this.minimizeBox.Click += new System.EventHandler(this.minimizeBox_Click);
            // 
            // closeBox
            // 
            this.closeBox.Image = ((System.Drawing.Image)(resources.GetObject("closeBox.Image")));
            this.closeBox.Location = new System.Drawing.Point(459, 2);
            this.closeBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.closeBox.Name = "closeBox";
            this.closeBox.Size = new System.Drawing.Size(20, 18);
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
            this.pnDnevniIzvjestaj.ContentPadding = new System.Windows.Forms.Padding(35, 10, 0, 0);
            this.pnDnevniIzvjestaj.ContentText = "Dnevni izvještaj isprintan !";
            this.pnDnevniIzvjestaj.Delay = 4000;
            this.pnDnevniIzvjestaj.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnDnevniIzvjestaj.Image = global::COMP_FISK.Properties.Resources.iconOK;
            this.pnDnevniIzvjestaj.ImagePadding = new System.Windows.Forms.Padding(15, 23, 0, 0);
            this.pnDnevniIzvjestaj.ImageSize = new System.Drawing.Size(48, 48);
            this.pnDnevniIzvjestaj.IsRightToLeft = false;
            this.pnDnevniIzvjestaj.OptionsMenu = null;
            this.pnDnevniIzvjestaj.ShowGrip = false;
            this.pnDnevniIzvjestaj.Size = new System.Drawing.Size(300, 100);
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
            // dgvRacuniDataView
            // 
            this.dgvRacuniDataView.AllowUserToAddRows = false;
            this.dgvRacuniDataView.AllowUserToDeleteRows = false;
            this.dgvRacuniDataView.AllowUserToOrderColumns = true;
            this.dgvRacuniDataView.AllowUserToResizeColumns = false;
            this.dgvRacuniDataView.AllowUserToResizeRows = false;
            this.dgvRacuniDataView.BackgroundColor = System.Drawing.Color.White;
            this.dgvRacuniDataView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRacuniDataView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRacuniDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRacuniDataView.ColumnHeadersHeight = 29;
            this.dgvRacuniDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRacuniDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRacuniDataView.EnableHeadersVisualStyles = false;
            this.dgvRacuniDataView.GridColor = System.Drawing.Color.White;
            this.dgvRacuniDataView.Location = new System.Drawing.Point(267, 25);
            this.dgvRacuniDataView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRacuniDataView.Name = "dgvRacuniDataView";
            this.dgvRacuniDataView.ReadOnly = true;
            this.dgvRacuniDataView.RowHeadersVisible = false;
            this.dgvRacuniDataView.RowHeadersWidth = 51;
            this.dgvRacuniDataView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.dgvRacuniDataView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRacuniDataView.RowTemplate.Height = 24;
            this.dgvRacuniDataView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvRacuniDataView.Size = new System.Drawing.Size(483, 369);
            this.dgvRacuniDataView.TabIndex = 3;
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
            // pnDnevniIzvjestaji
            // 
            this.pnDnevniIzvjestaji.BodyColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.pnDnevniIzvjestaji.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnDnevniIzvjestaji.ContentColor = System.Drawing.Color.White;
            this.pnDnevniIzvjestaji.ContentFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnDnevniIzvjestaji.ContentHoverColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnDnevniIzvjestaji.ContentPadding = new System.Windows.Forms.Padding(35, 10, 0, 0);
            this.pnDnevniIzvjestaji.ContentText = "Uređaj je potrebno servisirati. Broj dnevnih izvještaja je došao do limita !";
            this.pnDnevniIzvjestaji.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnDnevniIzvjestaji.Image = global::COMP_FISK.Properties.Resources.iconComp;
            this.pnDnevniIzvjestaji.ImagePadding = new System.Windows.Forms.Padding(15, 23, 0, 0);
            this.pnDnevniIzvjestaji.ImageSize = new System.Drawing.Size(48, 48);
            this.pnDnevniIzvjestaji.IsRightToLeft = false;
            this.pnDnevniIzvjestaji.OptionsMenu = null;
            this.pnDnevniIzvjestaji.Scroll = false;
            this.pnDnevniIzvjestaji.ShowGrip = false;
            this.pnDnevniIzvjestaji.Size = new System.Drawing.Size(400, 100);
            this.pnDnevniIzvjestaji.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnDnevniIzvjestaji.TitleFont = new System.Drawing.Font("Segoe UI", 9F);
            this.pnDnevniIzvjestaji.TitleText = "";
            // 
            // MainWindowView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(750, 394);
            this.Controls.Add(this.dgvRacuniDataView);
            this.Controls.Add(this.topPnl);
            this.Controls.Add(this.leftPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MainWindowView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COMP-FISK";
            contextMenu.ResumeLayout(false);
            this.leftPnl.ResumeLayout(false);
            this.leftPnl.PerformLayout();
            this.grbInformacije.ResumeLayout(false);
            this.grbInformacije.PerformLayout();
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
        private System.Windows.Forms.GroupBox grbInformacije;
        private System.Windows.Forms.Label lblBrjDnevnihIzvjestaja;
        private System.Windows.Forms.Label lblTipPrintera;
        private System.Windows.Forms.Label lblBrojIzvjestajaVar;
        private System.Windows.Forms.Label lblTipPrinteraVar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem prikaziProzorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem provjeriStatusPrinteraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dnevniIzvještajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem periodičniIzvještajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presjekStanjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartTringServeraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zatvoriAplikacijuToolStripMenuItem;
        private System.Windows.Forms.Label lblIBFM;
        private System.Windows.Forms.Label lblFactoryId;
        private System.Windows.Forms.Label lblFactoryIdVar;
        private System.Windows.Forms.Label lblJIB;
        private System.Windows.Forms.Label lblJIBVar;
        private System.Windows.Forms.Label lblIBFMVar;
        private Tulpep.NotificationWindow.PopupNotifier pnFiskalniNijeSpojen;
        private Tulpep.NotificationWindow.PopupNotifier pnFiskalniSpojen;
        private Tulpep.NotificationWindow.PopupNotifier pnFiskalniOK;
        private Tulpep.NotificationWindow.PopupNotifier pnFiskalniERR;
        private Tulpep.NotificationWindow.PopupNotifier pnGreskaKomunikacija;
        private Tulpep.NotificationWindow.PopupNotifier pnDnevniIzvjestaj;
        private Tulpep.NotificationWindow.PopupNotifier pnPresjekStanja;
        private Tulpep.NotificationWindow.PopupNotifier pnServisPozadina;
        private System.Windows.Forms.DataGridView dgvRacuniDataView;
        private Tulpep.NotificationWindow.PopupNotifier pnRestartTringServisa;
        private Tulpep.NotificationWindow.PopupNotifier pnDnevniIzvjestaji;
    }
}

