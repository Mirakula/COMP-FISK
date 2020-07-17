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
            this.lblFactoryId = new System.Windows.Forms.Label();
            this.lblIBFM = new System.Windows.Forms.Label();
            this.lblJIB = new System.Windows.Forms.Label();
            this.lblFactoryIdVar = new System.Windows.Forms.Label();
            this.lblJIBVar = new System.Windows.Forms.Label();
            this.lblIBFMVar = new System.Windows.Forms.Label();
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
            contextMenu.Size = new System.Drawing.Size(240, 172);
            // 
            // prikaziProzorToolStripMenuItem
            // 
            this.prikaziProzorToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.prikaziProzorToolStripMenuItem.Name = "prikaziProzorToolStripMenuItem";
            this.prikaziProzorToolStripMenuItem.Size = new System.Drawing.Size(239, 24);
            this.prikaziProzorToolStripMenuItem.Text = "Prikaži prozor";
            this.prikaziProzorToolStripMenuItem.Click += new System.EventHandler(this.prikaziProzorToolStripMenuItem_Click);
            // 
            // provjeriStatusPrinteraToolStripMenuItem
            // 
            this.provjeriStatusPrinteraToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.provjeriStatusPrinteraToolStripMenuItem.Name = "provjeriStatusPrinteraToolStripMenuItem";
            this.provjeriStatusPrinteraToolStripMenuItem.Size = new System.Drawing.Size(239, 24);
            this.provjeriStatusPrinteraToolStripMenuItem.Text = "Provjeri status printera";
            // 
            // dnevniIzvještajToolStripMenuItem
            // 
            this.dnevniIzvještajToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.dnevniIzvještajToolStripMenuItem.Name = "dnevniIzvještajToolStripMenuItem";
            this.dnevniIzvještajToolStripMenuItem.Size = new System.Drawing.Size(239, 24);
            this.dnevniIzvještajToolStripMenuItem.Text = "Dnevni izvještaj";
            // 
            // periodičniIzvještajToolStripMenuItem
            // 
            this.periodičniIzvještajToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.periodičniIzvještajToolStripMenuItem.Name = "periodičniIzvještajToolStripMenuItem";
            this.periodičniIzvještajToolStripMenuItem.Size = new System.Drawing.Size(239, 24);
            this.periodičniIzvještajToolStripMenuItem.Text = "Periodični izvještaj";
            // 
            // presjekStanjaToolStripMenuItem
            // 
            this.presjekStanjaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.presjekStanjaToolStripMenuItem.Name = "presjekStanjaToolStripMenuItem";
            this.presjekStanjaToolStripMenuItem.Size = new System.Drawing.Size(239, 24);
            this.presjekStanjaToolStripMenuItem.Text = "Presjek stanja";
            // 
            // restartTringServeraToolStripMenuItem
            // 
            this.restartTringServeraToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.restartTringServeraToolStripMenuItem.Name = "restartTringServeraToolStripMenuItem";
            this.restartTringServeraToolStripMenuItem.Size = new System.Drawing.Size(239, 24);
            this.restartTringServeraToolStripMenuItem.Text = "Restart tring servera";
            // 
            // zatvoriAplikacijuToolStripMenuItem
            // 
            this.zatvoriAplikacijuToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.zatvoriAplikacijuToolStripMenuItem.Name = "zatvoriAplikacijuToolStripMenuItem";
            this.zatvoriAplikacijuToolStripMenuItem.Size = new System.Drawing.Size(239, 24);
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
            this.leftPnl.Margin = new System.Windows.Forms.Padding(4);
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
            this.grbInformacije.Margin = new System.Windows.Forms.Padding(4);
            this.grbInformacije.Name = "grbInformacije";
            this.grbInformacije.Padding = new System.Windows.Forms.Padding(4);
            this.grbInformacije.Size = new System.Drawing.Size(247, 226);
            this.grbInformacije.TabIndex = 4;
            this.grbInformacije.TabStop = false;
            this.grbInformacije.Text = "Informacije";
            this.grbInformacije.Enter += new System.EventHandler(this.grbInformacije_Enter);
            // 
            // lblBrojIzvjestajaVar
            // 
            this.lblBrojIzvjestajaVar.AutoSize = true;
            this.lblBrojIzvjestajaVar.Location = new System.Drawing.Point(192, 79);
            this.lblBrojIzvjestajaVar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBrojIzvjestajaVar.Name = "lblBrojIzvjestajaVar";
            this.lblBrojIzvjestajaVar.Size = new System.Drawing.Size(0, 18);
            this.lblBrojIzvjestajaVar.TabIndex = 3;
            // 
            // lblTipPrinteraVar
            // 
            this.lblTipPrinteraVar.AutoSize = true;
            this.lblTipPrinteraVar.Location = new System.Drawing.Point(192, 47);
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
            this.lblBrjDnevnihIzvjestaja.Size = new System.Drawing.Size(121, 18);
            this.lblBrjDnevnihIzvjestaja.TabIndex = 1;
            this.lblBrjDnevnihIzvjestaja.Text = "Broj izvjestaja:";
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
            this.logoBox.Location = new System.Drawing.Point(98, 37);
            this.logoBox.Margin = new System.Windows.Forms.Padding(4);
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
            this.topPnl.Margin = new System.Windows.Forms.Padding(4);
            this.topPnl.Name = "topPnl";
            this.topPnl.Size = new System.Drawing.Size(666, 25);
            this.topPnl.TabIndex = 1;
            // 
            // minimizeBox
            // 
            this.minimizeBox.Image = ((System.Drawing.Image)(resources.GetObject("minimizeBox.Image")));
            this.minimizeBox.Location = new System.Drawing.Point(609, 2);
            this.minimizeBox.Margin = new System.Windows.Forms.Padding(4);
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
            this.closeBox.Location = new System.Drawing.Point(637, 2);
            this.closeBox.Margin = new System.Windows.Forms.Padding(4);
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
            // dgvRacuniDataView
            // 
            this.dgvRacuniDataView.AllowUserToAddRows = false;
            this.dgvRacuniDataView.AllowUserToDeleteRows = false;
            this.dgvRacuniDataView.AllowUserToOrderColumns = true;
            this.dgvRacuniDataView.AllowUserToResizeColumns = false;
            this.dgvRacuniDataView.AllowUserToResizeRows = false;
            this.dgvRacuniDataView.BackgroundColor = System.Drawing.Color.White;
            this.dgvRacuniDataView.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.dgvRacuniDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRacuni,
            this.colBrjFisk,
            this.colVrijeme,
            this.colStatus});
            this.dgvRacuniDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRacuniDataView.EnableHeadersVisualStyles = false;
            this.dgvRacuniDataView.GridColor = System.Drawing.Color.White;
            this.dgvRacuniDataView.Location = new System.Drawing.Point(267, 25);
            this.dgvRacuniDataView.Name = "dgvRacuniDataView";
            this.dgvRacuniDataView.ReadOnly = true;
            this.dgvRacuniDataView.RowHeadersVisible = false;
            this.dgvRacuniDataView.RowHeadersWidth = 51;
            this.dgvRacuniDataView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.dgvRacuniDataView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRacuniDataView.RowTemplate.Height = 24;
            this.dgvRacuniDataView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvRacuniDataView.Size = new System.Drawing.Size(666, 369);
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
            // lblFactoryId
            // 
            this.lblFactoryId.AutoSize = true;
            this.lblFactoryId.Location = new System.Drawing.Point(9, 112);
            this.lblFactoryId.Name = "lblFactoryId";
            this.lblFactoryId.Size = new System.Drawing.Size(90, 18);
            this.lblFactoryId.TabIndex = 4;
            this.lblFactoryId.Text = "Factory Id:";
            // 
            // lblIBFM
            // 
            this.lblIBFM.AutoSize = true;
            this.lblIBFM.Location = new System.Drawing.Point(7, 175);
            this.lblIBFM.Name = "lblIBFM";
            this.lblIBFM.Size = new System.Drawing.Size(52, 18);
            this.lblIBFM.TabIndex = 5;
            this.lblIBFM.Text = "IBFM:";
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
            // lblFactoryIdVar
            // 
            this.lblFactoryIdVar.AutoSize = true;
            this.lblFactoryIdVar.Location = new System.Drawing.Point(192, 112);
            this.lblFactoryIdVar.Name = "lblFactoryIdVar";
            this.lblFactoryIdVar.Size = new System.Drawing.Size(0, 18);
            this.lblFactoryIdVar.TabIndex = 7;
            // 
            // lblJIBVar
            // 
            this.lblJIBVar.AutoSize = true;
            this.lblJIBVar.Location = new System.Drawing.Point(192, 143);
            this.lblJIBVar.Name = "lblJIBVar";
            this.lblJIBVar.Size = new System.Drawing.Size(0, 18);
            this.lblJIBVar.TabIndex = 8;
            // 
            // lblIBFMVar
            // 
            this.lblIBFMVar.AutoSize = true;
            this.lblIBFMVar.Location = new System.Drawing.Point(192, 175);
            this.lblIBFMVar.Name = "lblIBFMVar";
            this.lblIBFMVar.Size = new System.Drawing.Size(0, 18);
            this.lblIBFMVar.TabIndex = 9;
            // 
            // MainWindowView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 394);
            this.Controls.Add(this.dgvRacuniDataView);
            this.Controls.Add(this.topPnl);
            this.Controls.Add(this.leftPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
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

