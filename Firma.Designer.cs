using System.Drawing;
using System.Windows.Forms;

namespace sorgorg
{
    partial class Firma
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlContent;

        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;

        private System.Windows.Forms.Button btnProfil;
        private System.Windows.Forms.Button btnOglasi;
        private System.Windows.Forms.Button btnPrijave;
        private System.Windows.Forms.Button btnKandidati;
        private System.Windows.Forms.Button btnPoruke;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnAnalitika;
        private System.Windows.Forms.Button btnSigurnost;

        private System.Windows.Forms.GroupBox gbOsnovniPodaci;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtIndustrija;
        private System.Windows.Forms.TextBox txtLokacija;
        private System.Windows.Forms.ComboBox cmbTipRada;
        private System.Windows.Forms.TextBox txtKontakt;
        private System.Windows.Forms.RichTextBox txtOpis;

        private System.Windows.Forms.GroupBox gbOglasi;
        private System.Windows.Forms.ListView lvOglasi;
        private System.Windows.Forms.Button btnNoviOglas;
        private System.Windows.Forms.Button btnUrediOglas;
        private System.Windows.Forms.Button btnArhivirajOglas;

        private System.Windows.Forms.GroupBox gbKandidati;
        private System.Windows.Forms.DataGridView dgvKandidati;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnDetalji;
        private System.Windows.Forms.Button btnPoruka;
        private System.Windows.Forms.Button btnFavorit;

        private System.Windows.Forms.GroupBox gbStatistika;
        private System.Windows.Forms.Label lblPregledi;
        private System.Windows.Forms.Label lblPrijave;
        private System.Windows.Forms.Label lblPoruke;
        private System.Windows.Forms.Label lblOcjena;

        private System.Windows.Forms.Button btnSacuvaj;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnProfil = new System.Windows.Forms.Button();
            this.btnOglasi = new System.Windows.Forms.Button();
            this.btnPrijave = new System.Windows.Forms.Button();
            this.btnKandidati = new System.Windows.Forms.Button();
            this.btnPoruke = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnAnalitika = new System.Windows.Forms.Button();
            this.btnSigurnost = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.gbStatistika = new System.Windows.Forms.GroupBox();
            this.lblPregledi = new System.Windows.Forms.Label();
            this.lblPrijave = new System.Windows.Forms.Label();
            this.lblPoruke = new System.Windows.Forms.Label();
            this.lblOcjena = new System.Windows.Forms.Label();
            this.gbOsnovniPodaci = new System.Windows.Forms.GroupBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtIndustrija = new System.Windows.Forms.TextBox();
            this.txtLokacija = new System.Windows.Forms.TextBox();
            this.cmbTipRada = new System.Windows.Forms.ComboBox();
            this.txtKontakt = new System.Windows.Forms.TextBox();
            this.txtOpis = new System.Windows.Forms.RichTextBox();
            this.gbOglasi = new System.Windows.Forms.GroupBox();
            this.lvOglasi = new System.Windows.Forms.ListView();
            this.btnNoviOglas = new System.Windows.Forms.Button();
            this.btnUrediOglas = new System.Windows.Forms.Button();
            this.btnArhivirajOglas = new System.Windows.Forms.Button();
            this.gbKandidati = new System.Windows.Forms.GroupBox();
            this.dgvKandidati = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnDetalji = new System.Windows.Forms.Button();
            this.btnPoruka = new System.Windows.Forms.Button();
            this.btnFavorit = new System.Windows.Forms.Button();
            this.pnlSidebar.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.gbStatistika.SuspendLayout();
            this.gbOsnovniPodaci.SuspendLayout();
            this.gbOglasi.SuspendLayout();
            this.gbKandidati.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKandidati)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlSidebar.Controls.Add(this.lblLogo);
            this.pnlSidebar.Controls.Add(this.btnProfil);
            this.pnlSidebar.Controls.Add(this.btnOglasi);
            this.pnlSidebar.Controls.Add(this.btnPrijave);
            this.pnlSidebar.Controls.Add(this.btnKandidati);
            this.pnlSidebar.Controls.Add(this.btnPoruke);
            this.pnlSidebar.Controls.Add(this.btnTim);
            this.pnlSidebar.Controls.Add(this.btnAnalitika);
            this.pnlSidebar.Controls.Add(this.btnSigurnost);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(230, 687);
            this.pnlSidebar.TabIndex = 2;
            // 
            // lblLogo
            // 
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(22, 20);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(185, 32);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "SORG";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnProfil
            // 
            this.btnProfil.Location = new System.Drawing.Point(50, 310);
            this.btnProfil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Size = new System.Drawing.Size(75, 18);
            this.btnProfil.TabIndex = 1;
            // 
            // btnOglasi
            // 
            this.btnOglasi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOglasi.Location = new System.Drawing.Point(50, 179);
            this.btnOglasi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOglasi.Name = "btnOglasi";
            this.btnOglasi.Size = new System.Drawing.Size(89, 36);
            this.btnOglasi.TabIndex = 2;
            // 
            // btnPrijave
            // 
            this.btnPrijave.Location = new System.Drawing.Point(50, 239);
            this.btnPrijave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrijave.Name = "btnPrijave";
            this.btnPrijave.Size = new System.Drawing.Size(75, 18);
            this.btnPrijave.TabIndex = 3;
            // 
            // btnKandidati
            // 
            this.btnKandidati.Location = new System.Drawing.Point(50, 286);
            this.btnKandidati.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKandidati.Name = "btnKandidati";
            this.btnKandidati.Size = new System.Drawing.Size(75, 18);
            this.btnKandidati.TabIndex = 4;
            // 
            // btnPoruke
            // 
            this.btnPoruke.Location = new System.Drawing.Point(50, 338);
            this.btnPoruke.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPoruke.Name = "btnPoruke";
            this.btnPoruke.Size = new System.Drawing.Size(75, 18);
            this.btnPoruke.TabIndex = 5;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(50, 263);
            this.btnTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 18);
            this.btnTim.TabIndex = 6;
            // 
            // btnAnalitika
            // 
            this.btnAnalitika.Location = new System.Drawing.Point(50, 367);
            this.btnAnalitika.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnalitika.Name = "btnAnalitika";
            this.btnAnalitika.Size = new System.Drawing.Size(75, 18);
            this.btnAnalitika.TabIndex = 7;
            // 
            // btnSigurnost
            // 
            this.btnSigurnost.Location = new System.Drawing.Point(50, 393);
            this.btnSigurnost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSigurnost.Name = "btnSigurnost";
            this.btnSigurnost.Size = new System.Drawing.Size(75, 18);
            this.btnSigurnost.TabIndex = 8;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Controls.Add(this.btnSacuvaj);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(230, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(964, 72);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblTitle.Location = new System.Drawing.Point(40, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(500, 44);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Kontrolna tabla firme";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.Gray;
            this.lblSubtitle.Location = new System.Drawing.Point(40, 50);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(600, 20);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Upravljanje profilom, oglasima, kandidatima i zapošljavanjem";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnSacuvaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSacuvaj.ForeColor = System.Drawing.Color.White;
            this.btnSacuvaj.Location = new System.Drawing.Point(780, 23);
            this.btnSacuvaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(150, 29);
            this.btnSacuvaj.TabIndex = 2;
            this.btnSacuvaj.Text = "Sačuvaj izmjene";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            // 
            // pnlContent
            // 
            this.pnlContent.AutoScroll = true;
            this.pnlContent.Controls.Add(this.gbStatistika);
            this.pnlContent.Controls.Add(this.gbOsnovniPodaci);
            this.pnlContent.Controls.Add(this.gbOglasi);
            this.pnlContent.Controls.Add(this.gbKandidati);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(230, 72);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(260, 88, 25, 20);
            this.pnlContent.Size = new System.Drawing.Size(964, 615);
            this.pnlContent.TabIndex = 0;
            // 
            // gbStatistika
            // 
            this.gbStatistika.Controls.Add(this.lblPregledi);
            this.gbStatistika.Controls.Add(this.lblPrijave);
            this.gbStatistika.Controls.Add(this.lblPoruke);
            this.gbStatistika.Controls.Add(this.lblOcjena);
            this.gbStatistika.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gbStatistika.Location = new System.Drawing.Point(40, 19);
            this.gbStatistika.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbStatistika.Name = "gbStatistika";
            this.gbStatistika.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbStatistika.Size = new System.Drawing.Size(900, 72);
            this.gbStatistika.TabIndex = 0;
            this.gbStatistika.TabStop = false;
            this.gbStatistika.Text = "Brzi pregled";
            // 
            // lblPregledi
            // 
            this.lblPregledi.Location = new System.Drawing.Point(25, 28);
            this.lblPregledi.Name = "lblPregledi";
            this.lblPregledi.Size = new System.Drawing.Size(180, 20);
            this.lblPregledi.TabIndex = 0;
            this.lblPregledi.Text = "Pregledi oglasa: 0";
            // 
            // lblPrijave
            // 
            this.lblPrijave.Location = new System.Drawing.Point(240, 28);
            this.lblPrijave.Name = "lblPrijave";
            this.lblPrijave.Size = new System.Drawing.Size(140, 20);
            this.lblPrijave.TabIndex = 1;
            this.lblPrijave.Text = "Prijave: 0";
            // 
            // lblPoruke
            // 
            this.lblPoruke.Location = new System.Drawing.Point(430, 28);
            this.lblPoruke.Name = "lblPoruke";
            this.lblPoruke.Size = new System.Drawing.Size(160, 20);
            this.lblPoruke.TabIndex = 2;
            this.lblPoruke.Text = "Nove poruke: 0";
            // 
            // lblOcjena
            // 
            this.lblOcjena.Location = new System.Drawing.Point(650, 28);
            this.lblOcjena.Name = "lblOcjena";
            this.lblOcjena.Size = new System.Drawing.Size(160, 20);
            this.lblOcjena.TabIndex = 3;
            this.lblOcjena.Text = "Ocjena firme: -";
            // 
            // gbOsnovniPodaci
            // 
            this.gbOsnovniPodaci.Controls.Add(this.txtNaziv);
            this.gbOsnovniPodaci.Controls.Add(this.txtIndustrija);
            this.gbOsnovniPodaci.Controls.Add(this.txtLokacija);
            this.gbOsnovniPodaci.Controls.Add(this.cmbTipRada);
            this.gbOsnovniPodaci.Controls.Add(this.txtKontakt);
            this.gbOsnovniPodaci.Controls.Add(this.txtOpis);
            this.gbOsnovniPodaci.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gbOsnovniPodaci.Location = new System.Drawing.Point(40, 107);
            this.gbOsnovniPodaci.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbOsnovniPodaci.Name = "gbOsnovniPodaci";
            this.gbOsnovniPodaci.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbOsnovniPodaci.Size = new System.Drawing.Size(430, 264);
            this.gbOsnovniPodaci.TabIndex = 1;
            this.gbOsnovniPodaci.TabStop = false;
            this.gbOsnovniPodaci.Text = "Osnovni podaci firme";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(25, 28);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(370, 30);
            this.txtNaziv.TabIndex = 0;
            this.txtNaziv.Text = "Naziv firme";
            // 
            // txtIndustrija
            // 
            this.txtIndustrija.Location = new System.Drawing.Point(25, 60);
            this.txtIndustrija.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIndustrija.Name = "txtIndustrija";
            this.txtIndustrija.Size = new System.Drawing.Size(370, 30);
            this.txtIndustrija.TabIndex = 1;
            this.txtIndustrija.Text = "Industrija";
            // 
            // txtLokacija
            // 
            this.txtLokacija.Location = new System.Drawing.Point(25, 92);
            this.txtLokacija.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLokacija.Name = "txtLokacija";
            this.txtLokacija.Size = new System.Drawing.Size(370, 30);
            this.txtLokacija.TabIndex = 2;
            this.txtLokacija.Text = "Lokacija";
            // 
            // cmbTipRada
            // 
            this.cmbTipRada.Items.AddRange(new object[] {
            "Remote",
            "Hibridno",
            "Kancelarija"});
            this.cmbTipRada.Location = new System.Drawing.Point(25, 124);
            this.cmbTipRada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTipRada.Name = "cmbTipRada";
            this.cmbTipRada.Size = new System.Drawing.Size(370, 31);
            this.cmbTipRada.TabIndex = 3;
            this.cmbTipRada.Text = "Tip rada";
            // 
            // txtKontakt
            // 
            this.txtKontakt.Location = new System.Drawing.Point(25, 156);
            this.txtKontakt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKontakt.Name = "txtKontakt";
            this.txtKontakt.Size = new System.Drawing.Size(370, 30);
            this.txtKontakt.TabIndex = 4;
            this.txtKontakt.Text = "Kontakt email / telefon";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(25, 188);
            this.txtOpis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(370, 57);
            this.txtOpis.TabIndex = 5;
            this.txtOpis.Text = "Opis djelatnosti, tehnologije, benefiti, kultura rada...";
            // 
            // gbOglasi
            // 
            this.gbOglasi.Controls.Add(this.lvOglasi);
            this.gbOglasi.Controls.Add(this.btnNoviOglas);
            this.gbOglasi.Controls.Add(this.btnUrediOglas);
            this.gbOglasi.Controls.Add(this.btnArhivirajOglas);
            this.gbOglasi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gbOglasi.Location = new System.Drawing.Point(500, 107);
            this.gbOglasi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbOglasi.Name = "gbOglasi";
            this.gbOglasi.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbOglasi.Size = new System.Drawing.Size(440, 264);
            this.gbOglasi.TabIndex = 2;
            this.gbOglasi.TabStop = false;
            this.gbOglasi.Text = "Upravljanje poslovima";
            // 
            // lvOglasi
            // 
            this.lvOglasi.HideSelection = false;
            this.lvOglasi.Location = new System.Drawing.Point(20, 28);
            this.lvOglasi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvOglasi.Name = "lvOglasi";
            this.lvOglasi.Size = new System.Drawing.Size(400, 169);
            this.lvOglasi.TabIndex = 0;
            this.lvOglasi.UseCompatibleStateImageBehavior = false;
            this.lvOglasi.View = System.Windows.Forms.View.Details;
            // 
            // btnNoviOglas
            // 
            this.btnNoviOglas.Location = new System.Drawing.Point(20, 208);
            this.btnNoviOglas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNoviOglas.Name = "btnNoviOglas";
            this.btnNoviOglas.Size = new System.Drawing.Size(120, 28);
            this.btnNoviOglas.TabIndex = 1;
            this.btnNoviOglas.Text = "Novi oglas";
            // 
            // btnUrediOglas
            // 
            this.btnUrediOglas.Location = new System.Drawing.Point(160, 208);
            this.btnUrediOglas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUrediOglas.Name = "btnUrediOglas";
            this.btnUrediOglas.Size = new System.Drawing.Size(100, 28);
            this.btnUrediOglas.TabIndex = 2;
            this.btnUrediOglas.Text = "Uredi";
            // 
            // btnArhivirajOglas
            // 
            this.btnArhivirajOglas.Location = new System.Drawing.Point(280, 208);
            this.btnArhivirajOglas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnArhivirajOglas.Name = "btnArhivirajOglas";
            this.btnArhivirajOglas.Size = new System.Drawing.Size(120, 28);
            this.btnArhivirajOglas.TabIndex = 3;
            this.btnArhivirajOglas.Text = "Arhiviraj";
            // 
            // gbKandidati
            // 
            this.gbKandidati.Controls.Add(this.dgvKandidati);
            this.gbKandidati.Controls.Add(this.cmbStatus);
            this.gbKandidati.Controls.Add(this.btnDetalji);
            this.gbKandidati.Controls.Add(this.btnPoruka);
            this.gbKandidati.Controls.Add(this.btnFavorit);
            this.gbKandidati.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gbKandidati.Location = new System.Drawing.Point(40, 387);
            this.gbKandidati.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbKandidati.Name = "gbKandidati";
            this.gbKandidati.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbKandidati.Size = new System.Drawing.Size(900, 208);
            this.gbKandidati.TabIndex = 3;
            this.gbKandidati.TabStop = false;
            this.gbKandidati.Text = "Prijave i kandidati";
            // 
            // dgvKandidati
            // 
            this.dgvKandidati.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKandidati.ColumnHeadersHeight = 29;
            this.dgvKandidati.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvKandidati.Location = new System.Drawing.Point(20, 28);
            this.dgvKandidati.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvKandidati.Name = "dgvKandidati";
            this.dgvKandidati.RowHeadersWidth = 51;
            this.dgvKandidati.Size = new System.Drawing.Size(860, 120);
            this.dgvKandidati.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Ime kandidata";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Vještine";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Status";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Dostupnost";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // cmbStatus
            // 
            this.cmbStatus.Items.AddRange(new object[] {
            "Novi",
            "U razmatranju",
            "Pozvan na intervju",
            "Odbijen",
            "Prihvaćen"});
            this.cmbStatus.Location = new System.Drawing.Point(20, 164);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(180, 31);
            this.cmbStatus.TabIndex = 1;
            this.cmbStatus.Text = "Promijeni status";
            // 
            // btnDetalji
            // 
            this.btnDetalji.Location = new System.Drawing.Point(230, 160);
            this.btnDetalji.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(150, 28);
            this.btnDetalji.TabIndex = 2;
            this.btnDetalji.Text = "Detalji kandidata";
            // 
            // btnPoruka
            // 
            this.btnPoruka.Location = new System.Drawing.Point(400, 160);
            this.btnPoruka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPoruka.Name = "btnPoruka";
            this.btnPoruka.Size = new System.Drawing.Size(140, 28);
            this.btnPoruka.TabIndex = 3;
            this.btnPoruka.Text = "Pošalji poruku";
            // 
            // btnFavorit
            // 
            this.btnFavorit.Location = new System.Drawing.Point(560, 160);
            this.btnFavorit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFavorit.Name = "btnFavorit";
            this.btnFavorit.Size = new System.Drawing.Size(150, 28);
            this.btnFavorit.TabIndex = 4;
            this.btnFavorit.Text = "Dodaj u favorite";
            // 
            // Firma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1194, 687);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Firma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nalog firme";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.gbStatistika.ResumeLayout(false);
            this.gbOsnovniPodaci.ResumeLayout(false);
            this.gbOsnovniPodaci.PerformLayout();
            this.gbOglasi.ResumeLayout(false);
            this.gbKandidati.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKandidati)).EndInit();
            this.ResumeLayout(false);

        }

        private void SetupMenuButton(System.Windows.Forms.Button button, string text, int top)
        {
            button.Text = "   " + text;
            button.Location = new System.Drawing.Point(18, top);
            button.Size = new System.Drawing.Size(194, 44);

            button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;

            button.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            button.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);

            button.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button.Cursor = System.Windows.Forms.Cursors.Hand;

            button.MouseEnter += (s, e) =>
            {
                button.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
                button.ForeColor = System.Drawing.Color.White;
            };

            button.MouseLeave += (s, e) =>
            {
                button.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
                button.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
            };
        }
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}