namespace sorgorg
{
    partial class Oglasi
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label lblForma;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtVjestine;
        private System.Windows.Forms.ComboBox cmbNivo;
        private System.Windows.Forms.ComboBox cmbNacinRada;
        private System.Windows.Forms.TextBox txtTrajanje;
        private System.Windows.Forms.TextBox txtBrojRadnika;
        private System.Windows.Forms.CheckBox chkHitno;
        private System.Windows.Forms.RichTextBox txtOpis;
        private System.Windows.Forms.Button btnDodaj;

        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.ListView lvOglasi;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnArhiviraj;
        private System.Windows.Forms.Button btnPauziraj;
        private System.Windows.Forms.Button btnAktiviraj;
        private System.Windows.Forms.Button btnDupliciraj;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblForma = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtVjestine = new System.Windows.Forms.TextBox();
            this.cmbNivo = new System.Windows.Forms.ComboBox();
            this.cmbNacinRada = new System.Windows.Forms.ComboBox();
            this.txtTrajanje = new System.Windows.Forms.TextBox();
            this.txtBrojRadnika = new System.Windows.Forms.TextBox();
            this.chkHitno = new System.Windows.Forms.CheckBox();
            this.txtOpis = new System.Windows.Forms.RichTextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblLista = new System.Windows.Forms.Label();
            this.lvOglasi = new System.Windows.Forms.ListView();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnArhiviraj = new System.Windows.Forms.Button();
            this.btnPauziraj = new System.Windows.Forms.Button();
            this.btnAktiviraj = new System.Windows.Forms.Button();
            this.btnDupliciraj = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1100, 72);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(27, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 52);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Oglasi";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.lblSubtitle.Location = new System.Drawing.Point(32, 48);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(600, 20);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Kreiranje, uređivanje i upravljanje poslovima firme";
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.White;
            this.pnlLeft.Controls.Add(this.lblForma);
            this.pnlLeft.Controls.Add(this.txtNaziv);
            this.pnlLeft.Controls.Add(this.txtVjestine);
            this.pnlLeft.Controls.Add(this.cmbNivo);
            this.pnlLeft.Controls.Add(this.cmbNacinRada);
            this.pnlLeft.Controls.Add(this.txtTrajanje);
            this.pnlLeft.Controls.Add(this.txtBrojRadnika);
            this.pnlLeft.Controls.Add(this.chkHitno);
            this.pnlLeft.Controls.Add(this.txtOpis);
            this.pnlLeft.Controls.Add(this.btnDodaj);
            this.pnlLeft.Location = new System.Drawing.Point(30, 96);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(410, 432);
            this.pnlLeft.TabIndex = 1;
            // 
            // lblForma
            // 
            this.lblForma.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblForma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblForma.Location = new System.Drawing.Point(25, 16);
            this.lblForma.Name = "lblForma";
            this.lblForma.Size = new System.Drawing.Size(300, 28);
            this.lblForma.TabIndex = 0;
            this.lblForma.Text = "Podaci o oglasu";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(25, 56);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(360, 22);
            this.txtNaziv.TabIndex = 1;
            this.txtNaziv.Text = "Naziv pozicije";
            // 
            // txtVjestine
            // 
            this.txtVjestine.Location = new System.Drawing.Point(25, 92);
            this.txtVjestine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVjestine.Name = "txtVjestine";
            this.txtVjestine.Size = new System.Drawing.Size(360, 22);
            this.txtVjestine.TabIndex = 2;
            this.txtVjestine.Text = "Potrebne vještine";
            // 
            // cmbNivo
            // 
            this.cmbNivo.Items.AddRange(new object[] {
            "Student",
            "Praksa",
            "Junior",
            "Medior",
            "Senior"});
            this.cmbNivo.Location = new System.Drawing.Point(25, 128);
            this.cmbNivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbNivo.Name = "cmbNivo";
            this.cmbNivo.Size = new System.Drawing.Size(360, 24);
            this.cmbNivo.TabIndex = 3;
            this.cmbNivo.Text = "Junior";
            // 
            // cmbNacinRada
            // 
            this.cmbNacinRada.Items.AddRange(new object[] {
            "Remote",
            "Hibridno",
            "Kancelarija"});
            this.cmbNacinRada.Location = new System.Drawing.Point(25, 164);
            this.cmbNacinRada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbNacinRada.Name = "cmbNacinRada";
            this.cmbNacinRada.Size = new System.Drawing.Size(360, 24);
            this.cmbNacinRada.TabIndex = 4;
            this.cmbNacinRada.Text = "Hibridno";
            // 
            // txtTrajanje
            // 
            this.txtTrajanje.Location = new System.Drawing.Point(25, 200);
            this.txtTrajanje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTrajanje.Name = "txtTrajanje";
            this.txtTrajanje.Size = new System.Drawing.Size(360, 22);
            this.txtTrajanje.TabIndex = 5;
            this.txtTrajanje.Text = "Trajanje angažmana";
            // 
            // txtBrojRadnika
            // 
            this.txtBrojRadnika.Location = new System.Drawing.Point(25, 236);
            this.txtBrojRadnika.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBrojRadnika.Name = "txtBrojRadnika";
            this.txtBrojRadnika.Size = new System.Drawing.Size(360, 22);
            this.txtBrojRadnika.TabIndex = 6;
            this.txtBrojRadnika.Text = "Broj potrebnih radnika";
            // 
            // chkHitno
            // 
            this.chkHitno.Location = new System.Drawing.Point(25, 268);
            this.chkHitno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkHitno.Name = "chkHitno";
            this.chkHitno.Size = new System.Drawing.Size(250, 20);
            this.chkHitno.TabIndex = 7;
            this.chkHitno.Text = "Označi kao hitan oglas";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(25, 300);
            this.txtOpis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(360, 73);
            this.txtOpis.TabIndex = 8;
            this.txtOpis.Text = "Opis zadataka, uslovi, tehnologije i dodatne informacije...";
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnDodaj.FlatAppearance.BorderSize = 0;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodaj.ForeColor = System.Drawing.Color.White;
            this.btnDodaj.Location = new System.Drawing.Point(25, 388);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(360, 30);
            this.btnDodaj.TabIndex = 9;
            this.btnDodaj.Text = "Dodaj oglas";
            this.btnDodaj.UseVisualStyleBackColor = false;
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.White;
            this.pnlRight.Controls.Add(this.lblLista);
            this.pnlRight.Controls.Add(this.lvOglasi);
            this.pnlRight.Controls.Add(this.btnUredi);
            this.pnlRight.Controls.Add(this.btnObrisi);
            this.pnlRight.Controls.Add(this.btnArhiviraj);
            this.pnlRight.Controls.Add(this.btnPauziraj);
            this.pnlRight.Controls.Add(this.btnAktiviraj);
            this.pnlRight.Controls.Add(this.btnDupliciraj);
            this.pnlRight.Location = new System.Drawing.Point(470, 96);
            this.pnlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(600, 432);
            this.pnlRight.TabIndex = 2;
            // 
            // lblLista
            // 
            this.lblLista.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblLista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblLista.Location = new System.Drawing.Point(25, 16);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(300, 28);
            this.lblLista.TabIndex = 0;
            this.lblLista.Text = "Lista oglasa";
            // 
            // lvOglasi
            // 
            this.lvOglasi.FullRowSelect = true;
            this.lvOglasi.GridLines = true;
            this.lvOglasi.HideSelection = false;
            this.lvOglasi.Location = new System.Drawing.Point(25, 56);
            this.lvOglasi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvOglasi.Name = "lvOglasi";
            this.lvOglasi.Size = new System.Drawing.Size(550, 273);
            this.lvOglasi.TabIndex = 1;
            this.lvOglasi.UseCompatibleStateImageBehavior = false;
            this.lvOglasi.View = System.Windows.Forms.View.Details;
            // 
            // btnUredi
            // 
            this.btnUredi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnUredi.FlatAppearance.BorderSize = 0;
            this.btnUredi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUredi.ForeColor = System.Drawing.Color.White;
            this.btnUredi.Location = new System.Drawing.Point(25, 344);
            this.btnUredi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(105, 28);
            this.btnUredi.TabIndex = 2;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = false;
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnObrisi.FlatAppearance.BorderSize = 0;
            this.btnObrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisi.ForeColor = System.Drawing.Color.White;
            this.btnObrisi.Location = new System.Drawing.Point(145, 344);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(105, 28);
            this.btnObrisi.TabIndex = 3;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = false;
            // 
            // btnArhiviraj
            // 
            this.btnArhiviraj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnArhiviraj.FlatAppearance.BorderSize = 0;
            this.btnArhiviraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArhiviraj.ForeColor = System.Drawing.Color.White;
            this.btnArhiviraj.Location = new System.Drawing.Point(265, 344);
            this.btnArhiviraj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnArhiviraj.Name = "btnArhiviraj";
            this.btnArhiviraj.Size = new System.Drawing.Size(105, 28);
            this.btnArhiviraj.TabIndex = 4;
            this.btnArhiviraj.Text = "Arhiviraj";
            this.btnArhiviraj.UseVisualStyleBackColor = false;
            // 
            // btnPauziraj
            // 
            this.btnPauziraj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnPauziraj.FlatAppearance.BorderSize = 0;
            this.btnPauziraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPauziraj.ForeColor = System.Drawing.Color.White;
            this.btnPauziraj.Location = new System.Drawing.Point(385, 344);
            this.btnPauziraj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPauziraj.Name = "btnPauziraj";
            this.btnPauziraj.Size = new System.Drawing.Size(105, 28);
            this.btnPauziraj.TabIndex = 5;
            this.btnPauziraj.Text = "Pauziraj";
            this.btnPauziraj.UseVisualStyleBackColor = false;
            // 
            // btnAktiviraj
            // 
            this.btnAktiviraj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnAktiviraj.FlatAppearance.BorderSize = 0;
            this.btnAktiviraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAktiviraj.ForeColor = System.Drawing.Color.White;
            this.btnAktiviraj.Location = new System.Drawing.Point(25, 384);
            this.btnAktiviraj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAktiviraj.Name = "btnAktiviraj";
            this.btnAktiviraj.Size = new System.Drawing.Size(105, 28);
            this.btnAktiviraj.TabIndex = 6;
            this.btnAktiviraj.Text = "Aktiviraj";
            this.btnAktiviraj.UseVisualStyleBackColor = false;
            // 
            // btnDupliciraj
            // 
            this.btnDupliciraj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnDupliciraj.FlatAppearance.BorderSize = 0;
            this.btnDupliciraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDupliciraj.ForeColor = System.Drawing.Color.White;
            this.btnDupliciraj.Location = new System.Drawing.Point(145, 384);
            this.btnDupliciraj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDupliciraj.Name = "btnDupliciraj";
            this.btnDupliciraj.Size = new System.Drawing.Size(105, 28);
            this.btnDupliciraj.TabIndex = 7;
            this.btnDupliciraj.Text = "Dupliciraj";
            this.btnDupliciraj.UseVisualStyleBackColor = false;
            // 
            // Oglasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1100, 560);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlRight);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Oglasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oglasi firme";
            this.pnlHeader.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}