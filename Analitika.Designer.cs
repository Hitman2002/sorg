namespace sorgorg
{
    partial class Analitika
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;

        private System.Windows.Forms.Panel pnlKartice;
        private System.Windows.Forms.Label lblPregledi;
        private System.Windows.Forms.Label lblPrijave;
        private System.Windows.Forms.Label lblZaposleni;
        private System.Windows.Forms.Label lblVrijeme;

        private System.Windows.Forms.Panel pnlTabela;
        private System.Windows.Forms.Label lblOglasi;
        private System.Windows.Forms.DataGridView dgvOglasi;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlHeader = new System.Windows.Forms.Panel();
            lblTitle = new System.Windows.Forms.Label();
            lblSubtitle = new System.Windows.Forms.Label();

            pnlKartice = new System.Windows.Forms.Panel();
            lblPregledi = new System.Windows.Forms.Label();
            lblPrijave = new System.Windows.Forms.Label();
            lblZaposleni = new System.Windows.Forms.Label();
            lblVrijeme = new System.Windows.Forms.Label();

            pnlTabela = new System.Windows.Forms.Panel();
            lblOglasi = new System.Windows.Forms.Label();
            dgvOglasi = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(dgvOglasi)).BeginInit();
            SuspendLayout();

            // FORM
            BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            ClientSize = new System.Drawing.Size(1100, 700);
            Text = "Analitika";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            // HEADER
            pnlHeader.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            pnlHeader.Height = 90;

            lblTitle.Text = "Analitika";
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(30, 15);

            lblSubtitle.Text = "Pregled uspješnosti oglasa i zapošljavanja";
            lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(219, 234, 254);
            lblSubtitle.Location = new System.Drawing.Point(32, 55);

            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblSubtitle);

            // KARTICE PANEL
            pnlKartice.Location = new System.Drawing.Point(30, 110);
            pnlKartice.Size = new System.Drawing.Size(1040, 120);

            // KARTICA 1
            lblPregledi.Text = "Pregledi oglasa\n1240";
            lblPregledi.BackColor = System.Drawing.Color.White;
            lblPregledi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            lblPregledi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblPregledi.Location = new System.Drawing.Point(0, 0);
            lblPregledi.Size = new System.Drawing.Size(240, 100);
            lblPregledi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // KARTICA 2
            lblPrijave.Text = "Ukupno prijava\n85";
            lblPrijave.BackColor = System.Drawing.Color.White;
            lblPrijave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            lblPrijave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblPrijave.Location = new System.Drawing.Point(260, 0);
            lblPrijave.Size = new System.Drawing.Size(240, 100);
            lblPrijave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // KARTICA 3
            lblZaposleni.Text = "Zaposleni\n12";
            lblZaposleni.BackColor = System.Drawing.Color.White;
            lblZaposleni.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            lblZaposleni.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblZaposleni.Location = new System.Drawing.Point(520, 0);
            lblZaposleni.Size = new System.Drawing.Size(240, 100);
            lblZaposleni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // KARTICA 4
            lblVrijeme.Text = "Prosjek zapošljavanja\n5 dana";
            lblVrijeme.BackColor = System.Drawing.Color.White;
            lblVrijeme.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            lblVrijeme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblVrijeme.Location = new System.Drawing.Point(780, 0);
            lblVrijeme.Size = new System.Drawing.Size(240, 100);
            lblVrijeme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            pnlKartice.Controls.Add(lblPregledi);
            pnlKartice.Controls.Add(lblPrijave);
            pnlKartice.Controls.Add(lblZaposleni);
            pnlKartice.Controls.Add(lblVrijeme);

            // TABELA
            pnlTabela.BackColor = System.Drawing.Color.White;
            pnlTabela.Location = new System.Drawing.Point(30, 250);
            pnlTabela.Size = new System.Drawing.Size(1040, 400);

            lblOglasi.Text = "Statistika oglasa";
            lblOglasi.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblOglasi.Location = new System.Drawing.Point(25, 20);

            dgvOglasi.Location = new System.Drawing.Point(25, 70);
            dgvOglasi.Size = new System.Drawing.Size(980, 300);
            dgvOglasi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvOglasi.ReadOnly = true;

            dgvOglasi.Columns.Add("Naziv", "Naziv oglasa");
            dgvOglasi.Columns.Add("Pregledi", "Pregledi");
            dgvOglasi.Columns.Add("Prijave", "Prijave");
            dgvOglasi.Columns.Add("Status", "Status");

            pnlTabela.Controls.Add(lblOglasi);
            pnlTabela.Controls.Add(dgvOglasi);

            Controls.Add(pnlHeader);
            Controls.Add(pnlKartice);
            Controls.Add(pnlTabela);

            ((System.ComponentModel.ISupportInitialize)(dgvOglasi)).EndInit();
            ResumeLayout(false);
        }
    }
}