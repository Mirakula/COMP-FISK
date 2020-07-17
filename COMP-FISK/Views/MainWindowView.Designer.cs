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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindowView));
            this.leftPnl = new System.Windows.Forms.Panel();
            this.topPnl = new System.Windows.Forms.Panel();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.closeBox = new System.Windows.Forms.PictureBox();
            this.minimizeBox = new System.Windows.Forms.PictureBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnOdstampani = new System.Windows.Forms.Button();
            this.btnNeodstampani = new System.Windows.Forms.Button();
            this.grbInformacije = new System.Windows.Forms.GroupBox();
            this.lblTipPrintera = new System.Windows.Forms.Label();
            this.lblBrjDnevnihIzvjestaja = new System.Windows.Forms.Label();
            this.lblTipPrinteraVar = new System.Windows.Forms.Label();
            this.lblBrojIzvjestajaVar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.leftPnl.SuspendLayout();
            this.topPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBox)).BeginInit();
            this.grbInformacije.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPnl
            // 
            this.leftPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.leftPnl.Controls.Add(this.label1);
            this.leftPnl.Controls.Add(this.grbInformacije);
            this.leftPnl.Controls.Add(this.btnNeodstampani);
            this.leftPnl.Controls.Add(this.btnOdstampani);
            this.leftPnl.Controls.Add(this.logoBox);
            this.leftPnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPnl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftPnl.Location = new System.Drawing.Point(0, 0);
            this.leftPnl.Name = "leftPnl";
            this.leftPnl.Size = new System.Drawing.Size(200, 320);
            this.leftPnl.TabIndex = 0;
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
            // logoBox
            // 
            this.logoBox.Image = ((System.Drawing.Image)(resources.GetObject("logoBox.Image")));
            this.logoBox.Location = new System.Drawing.Point(68, 30);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(63, 57);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoBox.TabIndex = 0;
            this.logoBox.TabStop = false;
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
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "COMP-FISK";
            this.notifyIcon.Visible = true;
            // 
            // btnOdstampani
            // 
            this.btnOdstampani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnOdstampani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdstampani.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdstampani.Location = new System.Drawing.Point(8, 122);
            this.btnOdstampani.Name = "btnOdstampani";
            this.btnOdstampani.Size = new System.Drawing.Size(185, 30);
            this.btnOdstampani.TabIndex = 1;
            this.btnOdstampani.Text = "Odštampani računi";
            this.btnOdstampani.UseVisualStyleBackColor = false;
            // 
            // btnNeodstampani
            // 
            this.btnNeodstampani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnNeodstampani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNeodstampani.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNeodstampani.Location = new System.Drawing.Point(8, 166);
            this.btnNeodstampani.Name = "btnNeodstampani";
            this.btnNeodstampani.Size = new System.Drawing.Size(185, 30);
            this.btnNeodstampani.TabIndex = 3;
            this.btnNeodstampani.Text = "Neodštampani računi";
            this.btnNeodstampani.UseVisualStyleBackColor = false;
            // 
            // grbInformacije
            // 
            this.grbInformacije.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.grbInformacije.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grbInformacije.Controls.Add(this.lblBrojIzvjestajaVar);
            this.grbInformacije.Controls.Add(this.lblTipPrinteraVar);
            this.grbInformacije.Controls.Add(this.lblBrjDnevnihIzvjestaja);
            this.grbInformacije.Controls.Add(this.lblTipPrintera);
            this.grbInformacije.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbInformacije.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInformacije.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.grbInformacije.Location = new System.Drawing.Point(8, 219);
            this.grbInformacije.Name = "grbInformacije";
            this.grbInformacije.Size = new System.Drawing.Size(185, 89);
            this.grbInformacije.TabIndex = 4;
            this.grbInformacije.TabStop = false;
            this.grbInformacije.Text = "Informacije";
            // 
            // lblTipPrintera
            // 
            this.lblTipPrintera.AutoSize = true;
            this.lblTipPrintera.Location = new System.Drawing.Point(6, 30);
            this.lblTipPrintera.Name = "lblTipPrintera";
            this.lblTipPrintera.Size = new System.Drawing.Size(82, 14);
            this.lblTipPrintera.TabIndex = 0;
            this.lblTipPrintera.Text = "Tip printera:";
            // 
            // lblBrjDnevnihIzvjestaja
            // 
            this.lblBrjDnevnihIzvjestaja.AutoSize = true;
            this.lblBrjDnevnihIzvjestaja.Location = new System.Drawing.Point(7, 56);
            this.lblBrjDnevnihIzvjestaja.Name = "lblBrjDnevnihIzvjestaja";
            this.lblBrjDnevnihIzvjestaja.Size = new System.Drawing.Size(97, 14);
            this.lblBrjDnevnihIzvjestaja.TabIndex = 1;
            this.lblBrjDnevnihIzvjestaja.Text = "Broj izvjestaja:";
            // 
            // lblTipPrinteraVar
            // 
            this.lblTipPrinteraVar.AutoSize = true;
            this.lblTipPrinteraVar.Location = new System.Drawing.Point(143, 30);
            this.lblTipPrinteraVar.Name = "lblTipPrinteraVar";
            this.lblTipPrinteraVar.Size = new System.Drawing.Size(0, 14);
            this.lblTipPrinteraVar.TabIndex = 2;
            // 
            // lblBrojIzvjestajaVar
            // 
            this.lblBrojIzvjestajaVar.AutoSize = true;
            this.lblBrojIzvjestajaVar.Location = new System.Drawing.Point(143, 56);
            this.lblBrojIzvjestajaVar.Name = "lblBrojIzvjestajaVar";
            this.lblBrojIzvjestajaVar.Size = new System.Drawing.Size(0, 14);
            this.lblBrojIzvjestajaVar.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(55, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "COMP - 2000";
            // 
            // MainWindowView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 320);
            this.Controls.Add(this.topPnl);
            this.Controls.Add(this.leftPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindowView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COMP-FISK";
            this.leftPnl.ResumeLayout(false);
            this.leftPnl.PerformLayout();
            this.topPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBox)).EndInit();
            this.grbInformacije.ResumeLayout(false);
            this.grbInformacije.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPnl;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Panel topPnl;
        private System.Windows.Forms.PictureBox minimizeBox;
        private System.Windows.Forms.PictureBox closeBox;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button btnOdstampani;
        private System.Windows.Forms.Button btnNeodstampani;
        private System.Windows.Forms.GroupBox grbInformacije;
        private System.Windows.Forms.Label lblBrjDnevnihIzvjestaja;
        private System.Windows.Forms.Label lblTipPrintera;
        private System.Windows.Forms.Label lblBrojIzvjestajaVar;
        private System.Windows.Forms.Label lblTipPrinteraVar;
        private System.Windows.Forms.Label label1;
    }
}

