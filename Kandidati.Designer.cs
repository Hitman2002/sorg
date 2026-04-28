namespace sorgorg
{
    partial class Kandidati
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.ComboBox cmbIskustvo;
        private System.Windows.Forms.ComboBox cmbDostupnost;
        private System.Windows.Forms.Button btnPretrazi;

        private System.Windows.Forms.DataGridView dgvKandidati;

        private System.Windows.Forms.Panel pnlDesno;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblVjestine;
        private System.Windows.Forms.Label lblIskustvo;
        private System.Windows.Forms.Label lblDostupnost;

        private System.Windows.Forms.Button btnDetalji;
        private System.Windows.Forms.Button btnShortlist;
        private System.Windows.Forms.Button btnKontakt;

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
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.cmbIskustvo = new System.Windows.Forms.ComboBox();
            this.cmbDostupnost = new System.Windows.Forms.ComboBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.dgvKandidati = new System.Windows.Forms.DataGridView();
            this.pnlDesno = new System.Windows.Forms.Panel();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblVjestine = new System.Windows.Forms.Label();
            this.lblIskustvo = new System.Windows.Forms.Label();
            this.lblDostupnost = new System.Windows.Forms.Label();
            this.btnDetalji = new System.Windows.Forms.Button();
            this.btnShortlist = new System.Windows.Forms.Button();
            this.btnKontakt = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeader.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKandidati)).BeginInit();
            this.pnlDesno.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1100, 80);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(242, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Kandidati";
            // 
            // pnlFilter
            // 
            this.pnlFilter.BackColor = System.Drawing.Color.White;
            this.pnlFilter.Controls.Add(this.txtPretraga);
            this.pnlFilter.Controls.Add(this.cmbIskustvo);
            this.pnlFilter.Controls.Add(this.cmbDostupnost);
            this.pnlFilter.Controls.Add(this.btnPretrazi);
            this.pnlFilter.Location = new System.Drawing.Point(30, 100);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(1040, 80);
            this.pnlFilter.TabIndex = 1;
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(20, 25);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(250, 22);
            this.txtPretraga.TabIndex = 0;
            this.txtPretraga.Text = "Pretraga...";
            // 
            // cmbIskustvo
            // 
            this.cmbIskustvo.Items.AddRange(new object[] {
            "Svi nivoi",
            "Student",
            "Junior",
            "Medior",
            "Senior"});
            this.cmbIskustvo.Location = new System.Drawing.Point(290, 25);
            this.cmbIskustvo.Name = "cmbIskustvo";
            this.cmbIskustvo.Size = new System.Drawing.Size(180, 24);
            this.cmbIskustvo.TabIndex = 1;
            this.cmbIskustvo.Text = "Svi nivoi";
            // 
            // cmbDostupnost
            // 
            this.cmbDostupnost.Items.AddRange(new object[] {
            "Svi",
            "Odmah",
            "Za 2 sedmice",
            "Za mjesec"});
            this.cmbDostupnost.Location = new System.Drawing.Point(490, 25);
            this.cmbDostupnost.Name = "cmbDostupnost";
            this.cmbDostupnost.Size = new System.Drawing.Size(180, 24);
            this.cmbDostupnost.TabIndex = 2;
            this.cmbDostupnost.Text = "Svi";
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(700, 22);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(120, 35);
            this.btnPretrazi.TabIndex = 3;
            this.btnPretrazi.Text = "Pretraži";
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
            this.dgvKandidati.Location = new System.Drawing.Point(30, 200);
            this.dgvKandidati.Name = "dgvKandidati";
            this.dgvKandidati.ReadOnly = true;
            this.dgvKandidati.RowHeadersWidth = 51;
            this.dgvKandidati.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKandidati.Size = new System.Drawing.Size(650, 450);
            this.dgvKandidati.TabIndex = 2;
            // 
            // pnlDesno
            // 
            this.pnlDesno.BackColor = System.Drawing.Color.White;
            this.pnlDesno.Controls.Add(this.lblIme);
            this.pnlDesno.Controls.Add(this.lblVjestine);
            this.pnlDesno.Controls.Add(this.lblIskustvo);
            this.pnlDesno.Controls.Add(this.lblDostupnost);
            this.pnlDesno.Controls.Add(this.btnDetalji);
            this.pnlDesno.Controls.Add(this.btnShortlist);
            this.pnlDesno.Controls.Add(this.btnKontakt);
            this.pnlDesno.Location = new System.Drawing.Point(700, 200);
            this.pnlDesno.Name = "pnlDesno";
            this.pnlDesno.Size = new System.Drawing.Size(370, 450);
            this.pnlDesno.TabIndex = 3;
            // 
            // lblIme
            // 
            this.lblIme.Location = new System.Drawing.Point(20, 20);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(300, 25);
            this.lblIme.TabIndex = 0;
            // 
            // lblVjestine
            // 
            this.lblVjestine.Location = new System.Drawing.Point(20, 60);
            this.lblVjestine.Name = "lblVjestine";
            this.lblVjestine.Size = new System.Drawing.Size(300, 40);
            this.lblVjestine.TabIndex = 1;
            // 
            // lblIskustvo
            // 
            this.lblIskustvo.Location = new System.Drawing.Point(20, 110);
            this.lblIskustvo.Name = "lblIskustvo";
            this.lblIskustvo.Size = new System.Drawing.Size(300, 25);
            this.lblIskustvo.TabIndex = 2;
            // 
            // lblDostupnost
            // 
            this.lblDostupnost.Location = new System.Drawing.Point(20, 150);
            this.lblDostupnost.Name = "lblDostupnost";
            this.lblDostupnost.Size = new System.Drawing.Size(300, 25);
            this.lblDostupnost.TabIndex = 3;
            // 
            // btnDetalji
            // 
            this.btnDetalji.Location = new System.Drawing.Point(20, 200);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(120, 35);
            this.btnDetalji.TabIndex = 4;
            this.btnDetalji.Text = "Profil";
            // 
            // btnShortlist
            // 
            this.btnShortlist.Location = new System.Drawing.Point(160, 200);
            this.btnShortlist.Name = "btnShortlist";
            this.btnShortlist.Size = new System.Drawing.Size(120, 35);
            this.btnShortlist.TabIndex = 5;
            this.btnShortlist.Text = "Shortlist";
            // 
            // btnKontakt
            // 
            this.btnKontakt.Location = new System.Drawing.Point(20, 250);
            this.btnKontakt.Name = "btnKontakt";
            this.btnKontakt.Size = new System.Drawing.Size(260, 35);
            this.btnKontakt.TabIndex = 6;
            this.btnKontakt.Text = "Kontakt";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Ime";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Vještine";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Iskustvo";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Dostupnost";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Kandidati
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.dgvKandidati);
            this.Controls.Add(this.pnlDesno);
            this.Name = "Kandidati";
            this.Text = "Kandidati";
            this.pnlHeader.ResumeLayout(false);
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKandidati)).EndInit();
            this.pnlDesno.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}