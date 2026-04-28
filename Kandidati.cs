using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace sorgorg
{
    public partial class Kandidati : Form
    {
        private List<Kandidat> lista = new List<Kandidat>();

        public Kandidati()
        {
            InitializeComponent();

            btnPretrazi.Click += btnPretrazi_Click;
            dgvKandidati.SelectionChanged += dgvKandidati_SelectionChanged;
            btnShortlist.Click += btnShortlist_Click;
            btnKontakt.Click += btnKontakt_Click;
            btnDetalji.Click += btnDetalji_Click;

            Ucitaj();
            Osvjezi(lista);
        }

        private void Ucitaj()
        {
            lista.Add(new Kandidat("Marko", "C#, SQL", "Junior", "Odmah"));
            lista.Add(new Kandidat("Ana", "HTML, CSS", "Student", "Za 2 sedmice"));
            lista.Add(new Kandidat("Ivan", "React, JS", "Medior", "Odmah"));
        }

        private void Osvjezi(List<Kandidat> podaci)
        {
            dgvKandidati.Rows.Clear();

            foreach (var k in podaci)
            {
                dgvKandidati.Rows.Add(k.Ime, k.Vjestine, k.Iskustvo, k.Dostupnost);
            }
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            var filtrirano = lista.Where(k =>
                (txtPretraga.Text == "" || k.Ime.ToLower().Contains(txtPretraga.Text.ToLower())) &&
                (cmbIskustvo.Text == "Svi nivoi" || k.Iskustvo == cmbIskustvo.Text) &&
                (cmbDostupnost.Text == "Svi" || k.Dostupnost == cmbDostupnost.Text)
            ).ToList();

            Osvjezi(filtrirano);
        }

        private void dgvKandidati_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKandidati.SelectedRows.Count == 0) return;

            var row = dgvKandidati.SelectedRows[0];

            lblIme.Text = "Ime: " + row.Cells[0].Value;
            lblVjestine.Text = "Vještine: " + row.Cells[1].Value;
            lblIskustvo.Text = "Iskustvo: " + row.Cells[2].Value;
            lblDostupnost.Text = "Dostupnost: " + row.Cells[3].Value;
        }

        private void btnShortlist_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dodan u shortlist.");
        }

        private void btnKontakt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Poruka poslana kandidatu.");
        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Otvaranje profila kandidata...");
        }

        class Kandidat
        {
            public string Ime;
            public string Vjestine;
            public string Iskustvo;
            public string Dostupnost;

            public Kandidat(string i, string v, string iskus, string d)
            {
                Ime = i;
                Vjestine = v;
                Iskustvo = iskus;
                Dostupnost = d;
            }
        }
    }
}