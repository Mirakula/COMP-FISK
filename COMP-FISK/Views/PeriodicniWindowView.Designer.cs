namespace COMP_FISK.Views
{
    partial class PeriodicniWindowView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PeriodicniWindowView));
            this.grpBoxOdabirDatuma = new System.Windows.Forms.GroupBox();
            this.lblDoDatuma = new System.Windows.Forms.Label();
            this.dtpDatumDo = new System.Windows.Forms.DateTimePicker();
            this.lblDatumOd = new System.Windows.Forms.Label();
            this.dtpDatumOd = new System.Windows.Forms.DateTimePicker();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.pnGreskaKomunikacija = new Tulpep.NotificationWindow.PopupNotifier();
            this.pnDnevniIzvjestaj = new Tulpep.NotificationWindow.PopupNotifier();
            this.grpBoxOdabirDatuma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxOdabirDatuma
            // 
            this.grpBoxOdabirDatuma.Controls.Add(this.lblDoDatuma);
            this.grpBoxOdabirDatuma.Controls.Add(this.dtpDatumDo);
            this.grpBoxOdabirDatuma.Controls.Add(this.lblDatumOd);
            this.grpBoxOdabirDatuma.Controls.Add(this.dtpDatumOd);
            this.grpBoxOdabirDatuma.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.grpBoxOdabirDatuma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.grpBoxOdabirDatuma.Location = new System.Drawing.Point(13, 23);
            this.grpBoxOdabirDatuma.Name = "grpBoxOdabirDatuma";
            this.grpBoxOdabirDatuma.Size = new System.Drawing.Size(357, 130);
            this.grpBoxOdabirDatuma.TabIndex = 0;
            this.grpBoxOdabirDatuma.TabStop = false;
            this.grpBoxOdabirDatuma.Text = "Odabir datuma";
            // 
            // lblDoDatuma
            // 
            this.lblDoDatuma.AutoSize = true;
            this.lblDoDatuma.Location = new System.Drawing.Point(15, 81);
            this.lblDoDatuma.Name = "lblDoDatuma";
            this.lblDoDatuma.Size = new System.Drawing.Size(75, 14);
            this.lblDoDatuma.TabIndex = 3;
            this.lblDoDatuma.Text = "Do datuma";
            // 
            // dtpDatumDo
            // 
            this.dtpDatumDo.Location = new System.Drawing.Point(95, 78);
            this.dtpDatumDo.Name = "dtpDatumDo";
            this.dtpDatumDo.Size = new System.Drawing.Size(252, 22);
            this.dtpDatumDo.TabIndex = 2;
            // 
            // lblDatumOd
            // 
            this.lblDatumOd.AutoSize = true;
            this.lblDatumOd.Location = new System.Drawing.Point(14, 38);
            this.lblDatumOd.Name = "lblDatumOd";
            this.lblDatumOd.Size = new System.Drawing.Size(75, 14);
            this.lblDatumOd.TabIndex = 1;
            this.lblDatumOd.Text = "Od datuma";
            // 
            // dtpDatumOd
            // 
            this.dtpDatumOd.Location = new System.Drawing.Point(95, 34);
            this.dtpDatumOd.Name = "dtpDatumOd";
            this.dtpDatumOd.Size = new System.Drawing.Size(252, 22);
            this.dtpDatumOd.TabIndex = 0;
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnOdustani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdustani.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnOdustani.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOdustani.Location = new System.Drawing.Point(100, 163);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 25);
            this.btnOdustani.TabIndex = 1;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnPotvrdi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPotvrdi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnPotvrdi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPotvrdi.Location = new System.Drawing.Point(203, 163);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(75, 25);
            this.btnPotvrdi.TabIndex = 2;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = false;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // pbClose
            // 
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(349, 4);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(23, 22);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClose.TabIndex = 3;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
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
            this.pnDnevniIzvjestaj.ContentPadding = new System.Windows.Forms.Padding(35, 15, 0, 0);
            this.pnDnevniIzvjestaj.ContentText = "Periodični izvještaj isprintan !";
            this.pnDnevniIzvjestaj.Delay = 5000;
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
            // PeriodicniWindowView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(382, 200);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.grpBoxOdabirDatuma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PeriodicniWindowView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PeriodicniWindowView";
            this.grpBoxOdabirDatuma.ResumeLayout(false);
            this.grpBoxOdabirDatuma.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxOdabirDatuma;
        private System.Windows.Forms.DateTimePicker dtpDatumOd;
        private System.Windows.Forms.Label lblDoDatuma;
        private System.Windows.Forms.DateTimePicker dtpDatumDo;
        private System.Windows.Forms.Label lblDatumOd;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.PictureBox pbClose;
        private Tulpep.NotificationWindow.PopupNotifier pnGreskaKomunikacija;
        private Tulpep.NotificationWindow.PopupNotifier pnDnevniIzvjestaj;
    }
}