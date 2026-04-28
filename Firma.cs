using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace sorgorg
{
    public partial class Firma : Form
    {
        private List<Oglas> oglasi = new List<Oglas>();
        private List<Kandidat> kandidati = new List<Kandidat>();
        private int brojPregleda = 0;

        public Firma()
        {
            InitializeComponent();
            PokreniFormu();
        }

        private void PokreniFormu()
        {
            PodesiMeni();
            PodesiTabele();
            UcitajDemoPodatke();
            OsvjeziSve();

            btnSacuvaj.Click += btnSacuvaj_Click;
            btnNoviOglas.Click += btnNoviOglas_Click;
            btnUrediOglas.Click += btnUrediOglas_Click;
            btnArhivirajOglas.Click += btnArhivirajOglas_Click;

            btnDetalji.Click += btnDetalji_Click;
            btnPoruka.Click += btnPoruka_Click;
            btnFavorit.Click += btnFavorit_Click;

            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;

            btnProfil.Click += (s, e) => MessageBox.Show("Ovdje firma uređuje profil i osnovne podatke.");
            btnOglasi.Click += (s, e) =>
            {
                Oglasi forma = new Oglasi();
                forma.ShowDialog(); // ili Show()
            };

            btnPrijave.Click += (s, e) =>
            {
                Prijave forma = new Prijave();
                forma.ShowDialog(); // ili Show()
            };
            btnKandidati.Click += (s, e) => MessageBox.Show("Pretraga kandidata bi bila posebna forma.");
            btnPoruke.Click += (s, e) => MessageBox.Show("Komunikacija sa kandidatima ostaje unutar sistema.");
            btnTim.Click += (s, e) => MessageBox.Show("Ovdje se dodaju HR, menadžeri i administratori.");
            btnAnalitika.Click += (s, e) => PrikaziAnalitiku();
            btnSigurnost.Click += (s, e) => MessageBox.Show("Sigurnost: promjena lozinke, uloge i aktivnosti naloga.");
        }

        private void PodesiMeni()
        {
            SetupMenuButton(btnProfil, "Profil firme", 95);
            SetupMenuButton(btnOglasi, "Oglasi", 145);
            SetupMenuButton(btnPrijave, "Prijave", 195);
            SetupMenuButton(btnKandidati, "Kandidati", 245);
            SetupMenuButton(btnPoruke, "Poruke", 295);
            SetupMenuButton(btnTim, "Tim", 345);
            SetupMenuButton(btnAnalitika, "Analitika", 395);
            SetupMenuButton(btnSigurnost, "Sigurnost", 445);
        }

        private void PodesiTabele()
        {
            lvOglasi.Columns.Clear();
            lvOglasi.Columns.Add("Pozicija", 130);
            lvOglasi.Columns.Add("Način rada", 90);
            lvOglasi.Columns.Add("Status", 90);
            lvOglasi.Columns.Add("Hitno", 70);
            lvOglasi.FullRowSelect = true;
            lvOglasi.GridLines = true;

            dgvKandidati.Rows.Clear();
            dgvKandidati.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKandidati.MultiSelect = false;
            dgvKandidati.AllowUserToAddRows = false;
            dgvKandidati.ReadOnly = true;
        }

        private void UcitajDemoPodatke()
        {
            txtNaziv.Text = "SORG firma";
            txtIndustrija.Text = "IT / Softverski razvoj";
            txtLokacija.Text = "Podgorica";
            cmbTipRada.Text = "Hibridno";
            txtKontakt.Text = "kontakt@sorg.com";
            txtOpis.Text = "Firma traži studente, praktikante i junior developere za rad na realnim projektima.";

            oglasi.Add(new Oglas
            {
                Naziv = "Junior C# Developer",
                Opis = "Rad na desktop aplikaciji u C# i .NET Framework.",
                Vjestine = "C#, WinForms, SQL",
                Nivo = "Junior",
                Trajanje = "3 mjeseca",
                BrojRadnika = 2,
                NacinRada = "Hibridno",
                Status = "Aktivan",
                Hitno = true
            });

            oglasi.Add(new Oglas
            {
                Naziv = "Praksa - Web Developer",
                Opis = "Izrada web stranica i rad sa bazom podataka.",
                Vjestine = "HTML, CSS, JavaScript, SQL",
                Nivo = "Praksa",
                Trajanje = "2 mjeseca",
                BrojRadnika = 3,
                NacinRada = "Remote",
                Status = "Aktivan",
                Hitno = false
            });

            kandidati.Add(new Kandidat
            {
                Ime = "Marko Marković",
                Vjestine = "C#, SQL, Git",
                Status = "Novi",
                Dostupnost = "Odmah",
                Favorit = false,
                Biljeska = "Dobar CV, pogledati portfolio."
            });

            kandidati.Add(new Kandidat
            {
                Ime = "Ana Petrović",
                Vjestine = "HTML, CSS, JavaScript",
                Status = "U razmatranju",
                Dostupnost = "Za 2 sedmice",
                Favorit = true,
                Biljeska = "Odlična za praksu."
            });

            brojPregleda = 124;
        }

        private void OsvjeziSve()
        {
            OsvjeziOglase();
            OsvjeziKandidate();
            OsvjeziStatistiku();
        }

        private void OsvjeziOglase()
        {
            lvOglasi.Items.Clear();

            foreach (Oglas oglas in oglasi)
            {
                ListViewItem item = new ListViewItem(oglas.Naziv);
                item.SubItems.Add(oglas.NacinRada);
                item.SubItems.Add(oglas.Status);
                item.SubItems.Add(oglas.Hitno ? "Da" : "Ne");
                item.Tag = oglas;

                if (oglas.Status == "Arhiviran")
                    item.ForeColor = Color.Gray;

                lvOglasi.Items.Add(item);
            }
        }

        private void OsvjeziKandidate()
        {
            dgvKandidati.Rows.Clear();

            foreach (Kandidat kandidat in kandidati)
            {
                int row = dgvKandidati.Rows.Add(
                    kandidat.Ime,
                    kandidat.Vjestine,
                    kandidat.Status,
                    kandidat.Dostupnost
                );

                if (kandidat.Favorit)
                    dgvKandidati.Rows[row].DefaultCellStyle.BackColor = Color.LightYellow;
            }
        }

        private void OsvjeziStatistiku()
        {
            lblPregledi.Text = "Pregledi oglasa: " + brojPregleda;
            lblPrijave.Text = "Prijave: " + kandidati.Count;
            lblPoruke.Text = "Nove poruke: 0";
            lblOcjena.Text = "Ocjena firme: 4.8";
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                MessageBox.Show("Unesite naziv firme.");
                return;
            }

            MessageBox.Show("Podaci firme su sačuvani.");
        }

        private void btnNoviOglas_Click(object sender, EventArgs e)
        {
            Oglas oglas = new Oglas
            {
                Naziv = "Novi oglas",
                Opis = "Opis posla...",
                Vjestine = "Unesite vještine",
                Nivo = "Junior",
                Trajanje = "1 mjesec",
                BrojRadnika = 1,
                NacinRada = cmbTipRada.Text,
                Status = "Aktivan",
                Hitno = false
            };

            oglasi.Add(oglas);
            OsvjeziSve();

            MessageBox.Show("Kreiran je novi oglas. Možete ga urediti klikom na dugme 'Uredi'.");
        }

        private void btnUrediOglas_Click(object sender, EventArgs e)
        {
            Oglas oglas = IzabraniOglas();

            if (oglas == null)
            {
                MessageBox.Show("Prvo izaberite oglas iz liste.");
                return;
            }

            string noviNaziv = Unos(
                "Unesite naziv pozicije:",
                "Uredi oglas",
                oglas.Naziv
            );

            if (!string.IsNullOrWhiteSpace(noviNaziv))
                oglas.Naziv = noviNaziv;

            string noveVjestine = Unos(
                "Unesite potrebne vještine:",
                "Uredi oglas",
                oglas.Vjestine
            );

            if (!string.IsNullOrWhiteSpace(noveVjestine))
                oglas.Vjestine = noveVjestine;

            OsvjeziSve();
        }

        private void btnArhivirajOglas_Click(object sender, EventArgs e)
        {
            Oglas oglas = IzabraniOglas();

            if (oglas == null)
            {
                MessageBox.Show("Prvo izaberite oglas.");
                return;
            }

            oglas.Status = "Arhiviran";
            OsvjeziSve();

            MessageBox.Show("Oglas je arhiviran.");
        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            Kandidat kandidat = IzabraniKandidat();

            if (kandidat == null)
            {
                MessageBox.Show("Prvo izaberite kandidata.");
                return;
            }

            MessageBox.Show(
                "Ime: " + kandidat.Ime + Environment.NewLine +
                "Vještine: " + kandidat.Vjestine + Environment.NewLine +
                "Status: " + kandidat.Status + Environment.NewLine +
                "Dostupnost: " + kandidat.Dostupnost + Environment.NewLine +
                "Favorit: " + (kandidat.Favorit ? "Da" : "Ne") + Environment.NewLine +
                "Bilješka: " + kandidat.Biljeska,
                "Detalji kandidata"
            );
        }

        private void btnPoruka_Click(object sender, EventArgs e)
        {
            Kandidat kandidat = IzabraniKandidat();

            if (kandidat == null)
            {
                MessageBox.Show("Prvo izaberite kandidata.");
                return;
            }

            string poruka = Unos(
                "Unesite poruku kandidatu:",
                "Pošalji poruku",
                "Poštovani, želimo da Vas kontaktiramo povodom prijave."
            );

            if (!string.IsNullOrWhiteSpace(poruka))
                MessageBox.Show("Poruka je poslata kandidatu: " + kandidat.Ime);
        }

        private void btnFavorit_Click(object sender, EventArgs e)
        {
            Kandidat kandidat = IzabraniKandidat();

            if (kandidat == null)
            {
                MessageBox.Show("Prvo izaberite kandidata.");
                return;
            }

            kandidat.Favorit = !kandidat.Favorit;
            OsvjeziKandidate();

            MessageBox.Show(kandidat.Favorit ? "Kandidat je dodat u favorite." : "Kandidat je uklonjen iz favorita.");
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kandidat kandidat = IzabraniKandidat();

            if (kandidat == null)
                return;

            kandidat.Status = cmbStatus.Text;
            OsvjeziKandidate();
        }

        private Oglas IzabraniOglas()
        {
            if (lvOglasi.SelectedItems.Count == 0)
                return null;

            return lvOglasi.SelectedItems[0].Tag as Oglas;
        }

        private Kandidat IzabraniKandidat()
        {
            if (dgvKandidati.SelectedRows.Count == 0)
                return null;

            int index = dgvKandidati.SelectedRows[0].Index;

            if (index < 0 || index >= kandidati.Count)
                return null;

            return kandidati[index];
        }

        private void PrikaziAnalitiku()
        {
            int aktivni = oglasi.Count(o => o.Status == "Aktivan");
            int arhivirani = oglasi.Count(o => o.Status == "Arhiviran");
            int favoriti = kandidati.Count(k => k.Favorit);

            MessageBox.Show(
                "Analitika firme:" + Environment.NewLine +
                "Aktivni oglasi: " + aktivni + Environment.NewLine +
                "Arhivirani oglasi: " + arhivirani + Environment.NewLine +
                "Ukupno prijava: " + kandidati.Count + Environment.NewLine +
                "Favoriti kandidati: " + favoriti + Environment.NewLine +
                "Pregledi oglasa: " + brojPregleda,
                "Analitika"
            );
        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {
        }
        private string Unos(string naslov, string tekst, string pocetnaVrijednost)
        {
            Form forma = new Form();
            Label labela = new Label();
            TextBox input = new TextBox();
            Button ok = new Button();
            Button cancel = new Button();

            forma.Text = naslov;
            labela.Text = tekst;
            input.Text = pocetnaVrijednost;

            labela.SetBounds(12, 15, 360, 20);
            input.SetBounds(12, 40, 360, 25);
            ok.SetBounds(216, 75, 75, 30);
            cancel.SetBounds(297, 75, 75, 30);

            ok.Text = "OK";
            cancel.Text = "Cancel";

            ok.DialogResult = DialogResult.OK;
            cancel.DialogResult = DialogResult.Cancel;

            forma.ClientSize = new Size(390, 120);
            forma.Controls.AddRange(new Control[] { labela, input, ok, cancel });
            forma.FormBorderStyle = FormBorderStyle.FixedDialog;
            forma.StartPosition = FormStartPosition.CenterParent;
            forma.AcceptButton = ok;
            forma.CancelButton = cancel;

            return forma.ShowDialog() == DialogResult.OK ? input.Text : "";
        }
        private class Oglas
        {
            public string Naziv { get; set; }
            public string Opis { get; set; }
            public string Vjestine { get; set; }
            public string Nivo { get; set; }
            public string Trajanje { get; set; }
            public int BrojRadnika { get; set; }
            public string NacinRada { get; set; }
            public string Status { get; set; }
            public bool Hitno { get; set; }
        }

        private class Kandidat
        {
            public string Ime { get; set; }
            public string Vjestine { get; set; }
            public string Status { get; set; }
            public string Dostupnost { get; set; }
            public bool Favorit { get; set; }
            public string Biljeska { get; set; }
        }
    }
}