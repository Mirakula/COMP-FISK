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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dgvRacuniDataView = new System.Windows.Forms.DataGridView();
            this.colRacuni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBrjFisk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVrijeme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            contextMenu.Size = new System.Drawing.Size(207, 186);
            // 
            // prikaziProzorToolStripMenuItem
            // 
            this.prikaziProzorToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.prikaziProzorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("prikaziProzorToolStripMenuItem.Image")));
            this.prikaziProzorToolStripMenuItem.Name = "prikaziProzorToolStripMenuItem";
            this.prikaziProzorToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.prikaziProzorToolStripMenuItem.Text = "Prikaži prozor";
            this.prikaziProzorToolStripMenuItem.Click += new System.EventHandler(this.prikaziProzorToolStripMenuItem_Click);
            // 
            // provjeriStatusPrinteraToolStripMenuItem
            // 
            this.provjeriStatusPrinteraToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.provjeriStatusPrinteraToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("provjeriStatusPrinteraToolStripMenuItem.Image")));
            this.provjeriStatusPrinteraToolStripMenuItem.Name = "provjeriStatusPrinteraToolStripMenuItem";
            this.provjeriStatusPrinteraToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.provjeriStatusPrinteraToolStripMenuItem.Text = "Provjeri status printera";
            // 
            // dnevniIzvještajToolStripMenuItem
            // 
            this.dnevniIzvještajToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.dnevniIzvještajToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dnevniIzvještajToolStripMenuItem.Image")));
            this.dnevniIzvještajToolStripMenuItem.Name = "dnevniIzvještajToolStripMenuItem";
            this.dnevniIzvještajToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.dnevniIzvještajToolStripMenuItem.Text = "Dnevni izvještaj";
            // 
            // periodičniIzvještajToolStripMenuItem
            // 
            this.periodičniIzvještajToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.periodičniIzvještajToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("periodičniIzvještajToolStripMenuItem.Image")));
            this.periodičniIzvještajToolStripMenuItem.Name = "periodičniIzvještajToolStripMenuItem";
            this.periodičniIzvještajToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.periodičniIzvještajToolStripMenuItem.Text = "Periodični izvještaj";
            // 
            // presjekStanjaToolStripMenuItem
            // 
            this.presjekStanjaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.presjekStanjaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("presjekStanjaToolStripMenuItem.Image")));
            this.presjekStanjaToolStripMenuItem.Name = "presjekStanjaToolStripMenuItem";
            this.presjekStanjaToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.presjekStanjaToolStripMenuItem.Text = "Presjek stanja";
            // 
            // restartTringServeraToolStripMenuItem
            // 
            this.restartTringServeraToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.restartTringServeraToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("restartTringServeraToolStripMenuItem.Image")));
            this.restartTringServeraToolStripMenuItem.Name = "restartTringServeraToolStripMenuItem";
            this.restartTringServeraToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.restartTringServeraToolStripMenuItem.Text = "Restart tring servera";
            // 
            // zatvoriAplikacijuToolStripMenuItem
            // 
            this.zatvoriAplikacijuToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.zatvoriAplikacijuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("zatvoriAplikacijuToolStripMenuItem.Image")));
            this.zatvoriAplikacijuToolStripMenuItem.Name = "zatvoriAplikacijuToolStripMenuItem";
            this.zatvoriAplikacijuToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
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
            this.leftPnl.Name = "leftPnl";
            this.leftPnl.Size = new System.Drawing.Size(200, 320);
            this.leftPnl.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(61, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 14);
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
            this.grbInformacije.Location = new System.Drawing.Point(8, 125);
            this.grbInformacije.Name = "grbInformacije";
            this.grbInformacije.Size = new System.Drawing.Size(185, 184);
            this.grbInformacije.TabIndex = 4;
            this.grbInformacije.TabStop = false;
            this.grbInformacije.Text = "Informacije";
            // 
            // lblIBFMVar
            // 
            this.lblIBFMVar.AutoSize = true;
            this.lblIBFMVar.Location = new System.Drawing.Point(95, 142);
            this.lblIBFMVar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIBFMVar.Name = "lblIBFMVar";
            this.lblIBFMVar.Size = new System.Drawing.Size(0, 14);
            this.lblIBFMVar.TabIndex = 9;
            // 
            // lblJIBVar
            // 
            this.lblJIBVar.AutoSize = true;
            this.lblJIBVar.Location = new System.Drawing.Point(94, 116);
            this.lblJIBVar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJIBVar.Name = "lblJIBVar";
            this.lblJIBVar.Size = new System.Drawing.Size(0, 14);
            this.lblJIBVar.TabIndex = 8;
            // 
            // lblFactoryIdVar
            // 
            this.lblFactoryIdVar.AutoSize = true;
            this.lblFactoryIdVar.Location = new System.Drawing.Point(89, 91);
            this.lblFactoryIdVar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFactoryIdVar.Name = "lblFactoryIdVar";
            this.lblFactoryIdVar.Size = new System.Drawing.Size(0, 14);
            this.lblFactoryIdVar.TabIndex = 7;
            // 
            // lblJIB
            // 
            this.lblJIB.AutoSize = true;
            this.lblJIB.Location = new System.Drawing.Point(7, 116);
            this.lblJIB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJIB.Name = "lblJIB";
            this.lblJIB.Size = new System.Drawing.Size(30, 14);
            this.lblJIB.TabIndex = 6;
            this.lblJIB.Text = "JIB:";
            // 
            // lblIBFM
            // 
            this.lblIBFM.AutoSize = true;
            this.lblIBFM.Location = new System.Drawing.Point(5, 142);
            this.lblIBFM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIBFM.Name = "lblIBFM";
            this.lblIBFM.Size = new System.Drawing.Size(41, 14);
            this.lblIBFM.TabIndex = 5;
            this.lblIBFM.Text = "IBFM:";
            // 
            // lblFactoryId
            // 
            this.lblFactoryId.AutoSize = true;
            this.lblFactoryId.Location = new System.Drawing.Point(7, 91);
            this.lblFactoryId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFactoryId.Name = "lblFactoryId";
            this.lblFactoryId.Size = new System.Drawing.Size(73, 14);
            this.lblFactoryId.TabIndex = 4;
            this.lblFactoryId.Text = "Factory Id:";
            // 
            // lblBrojIzvjestajaVar
            // 
            this.lblBrojIzvjestajaVar.AutoSize = true;
            this.lblBrojIzvjestajaVar.Location = new System.Drawing.Point(98, 64);
            this.lblBrojIzvjestajaVar.Name = "lblBrojIzvjestajaVar";
            this.lblBrojIzvjestajaVar.Size = new System.Drawing.Size(0, 14);
            this.lblBrojIzvjestajaVar.TabIndex = 3;
            // 
            // lblTipPrinteraVar
            // 
            this.lblTipPrinteraVar.AutoSize = true;
            this.lblTipPrinteraVar.Location = new System.Drawing.Point(98, 38);
            this.lblTipPrinteraVar.Name = "lblTipPrinteraVar";
            this.lblTipPrinteraVar.Size = new System.Drawing.Size(0, 14);
            this.lblTipPrinteraVar.TabIndex = 2;
            // 
            // lblBrjDnevnihIzvjestaja
            // 
            this.lblBrjDnevnihIzvjestaja.AutoSize = true;
            this.lblBrjDnevnihIzvjestaja.Location = new System.Drawing.Point(6, 64);
            this.lblBrjDnevnihIzvjestaja.Name = "lblBrjDnevnihIzvjestaja";
            this.lblBrjDnevnihIzvjestaja.Size = new System.Drawing.Size(88, 14);
            this.lblBrjDnevnihIzvjestaja.TabIndex = 1;
            this.lblBrjDnevnihIzvjestaja.Text = "No. izvjestaji:";
            // 
            // lblTipPrintera
            // 
            this.lblTipPrintera.AutoSize = true;
            this.lblTipPrintera.Location = new System.Drawing.Point(7, 38);
            this.lblTipPrintera.Name = "lblTipPrintera";
            this.lblTipPrintera.Size = new System.Drawing.Size(82, 14);
            this.lblTipPrintera.TabIndex = 0;
            this.lblTipPrintera.Text = "Tip printera:";
            // 
            // logoBox
            // 
            this.logoBox.Image = ((System.Drawing.Image)(resources.GetObject("logoBox.Image")));
            this.logoBox.Location = new System.Drawing.Point(74, 30);
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
            this.topPnl.Location = new System.Drawing.Point(200, 0);
            this.topPnl.Name = "topPnl";
            this.topPnl.Size = new System.Drawing.Size(500, 20);
            this.topPnl.TabIndex = 1;
            // 
            // minimizeBox
            // 
            this.minimizeBox.Image = ((System.Drawing.Image)(resources.GetObject("minimizeBox.Image")));
            this.minimizeBox.Location = new System.Drawing.Point(457, 2);
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
            this.closeBox.Location = new System.Drawing.Point(478, 2);
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRacuniDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvRacuniDataView.ColumnHeadersHeight = 29;
            this.dgvRacuniDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRacuniDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRacuni,
            this.colBrjFisk,
            this.colVrijeme,
            this.colStatus});
            this.dgvRacuniDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRacuniDataView.EnableHeadersVisualStyles = false;
            this.dgvRacuniDataView.GridColor = System.Drawing.Color.White;
            this.dgvRacuniDataView.Location = new System.Drawing.Point(200, 20);
            this.dgvRacuniDataView.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRacuniDataView.Name = "dgvRacuniDataView";
            this.dgvRacuniDataView.ReadOnly = true;
            this.dgvRacuniDataView.RowHeadersVisible = false;
            this.dgvRacuniDataView.RowHeadersWidth = 51;
            this.dgvRacuniDataView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.dgvRacuniDataView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvRacuniDataView.RowTemplate.Height = 24;
            this.dgvRacuniDataView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvRacuniDataView.Size = new System.Drawing.Size(500, 300);
            this.dgvRacuniDataView.TabIndex = 2;
            // 
            // colRacuni
            // 
            this.colRacuni.HeaderText = "Račun";
            this.colRacuni.MinimumWidth = 6;
            this.colRacuni.Name = "colRacuni";
            this.colRacuni.ReadOnly = true;
            this.colRacuni.Width = 125;
            // 
            // colBrjFisk
            // 
            this.colBrjFisk.HeaderText = "Broj računa";
            this.colBrjFisk.MinimumWidth = 6;
            this.colBrjFisk.Name = "colBrjFisk";
            this.colBrjFisk.ReadOnly = true;
            this.colBrjFisk.Width = 125;
            // 
            // colVrijeme
            // 
            this.colVrijeme.HeaderText = "Vrijeme";
            this.colVrijeme.MinimumWidth = 6;
            this.colVrijeme.Name = "colVrijeme";
            this.colVrijeme.ReadOnly = true;
            this.colVrijeme.Width = 125;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 125;
            // 
            // MainWindowView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 320);
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
        private System.Windows.Forms.DataGridView dgvRacuniDataView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRacuni;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBrjFisk;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVrijeme;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.Label lblIBFM;
        private System.Windows.Forms.Label lblFactoryId;
        private System.Windows.Forms.Label lblFactoryIdVar;
        private System.Windows.Forms.Label lblJIB;
        private System.Windows.Forms.Label lblJIBVar;
        private System.Windows.Forms.Label lblIBFMVar;
    }
}

