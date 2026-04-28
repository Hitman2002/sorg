using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace sorgorg
{
    public partial class Oglasi : Form
    {
        private List<Oglas> oglasi = new List<Oglas>();

        public Oglasi()
        {
            InitializeComponent();

            btnDodaj.Click += btnDodaj_Click;
            btnUredi.Click += btnUredi_Click;
            btnObrisi.Click += btnObrisi_Click;
            btnArhiviraj.Click += btnArhiviraj_Click;
            btnPauziraj.Click += btnPauziraj_Click;
            btnAktiviraj.Click += btnAktiviraj_Click;
            btnDupliciraj.Click += btnDupliciraj_Click;
            lvOglasi.SelectedIndexChanged += lvOglasi_SelectedIndexChanged;

            UcitajDemoPodatke();
            OsvjeziListu();
        }

        private void UcitajDemoPodatke()
        {
            oglasi.Add(new Oglas("Junior C# Developer", "C#, SQL, WinForms", "Junior", "Hibridno", "3 mjeseca", 2, "Aktivan", true, "Rad na desktop aplikaciji."));
            oglasi.Add(new Oglas("Web praksa", "HTML, CSS, JS", "Praksa", "Remote", "2 mjeseca", 3, "Pauziran", false, "Izrada web stranica."));
        }

        private void OsvjeziListu()
        {
            lvOglasi.Items.Clear();

            foreach (Oglas o in oglasi)
            {
                ListViewItem item = new ListViewItem(o.Naziv);
                item.SubItems.Add(o.Nivo);
                item.SubItems.Add(o.NacinRada);
                item.SubItems.Add(o.Status);
                item.SubItems.Add(o.Hitno ? "Da" : "Ne");
                item.Tag = o;

                if (o.Status == "Arhiviran")
                    item.ForeColor = Color.Gray;

                lvOglasi.Items.Add(item);
            }
        }

        private Oglas IzabraniOglas()
        {
            if (lvOglasi.SelectedItems.Count == 0)
            {
                MessageBox.Show("Prvo izaberi oglas.");
                return null;
            }

            return lvOglasi.SelectedItems[0].Tag as Oglas;
        }

        private void lvOglasi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvOglasi.SelectedItems.Count == 0)
                return;

            Oglas o = lvOglasi.SelectedItems[0].Tag as Oglas;
            if (o == null)
                return;

            txtNaziv.Text = o.Naziv;
            txtVjestine.Text = o.Vjestine;
            cmbNivo.Text = o.Nivo;
            cmbNacinRada.Text = o.NacinRada;
            txtTrajanje.Text = o.Trajanje;
            txtBrojRadnika.Text = o.BrojRadnika.ToString();
            chkHitno.Checked = o.Hitno;
            txtOpis.Text = o.Opis;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            int broj;
            if (!int.TryParse(txtBrojRadnika.Text, out broj))
                broj = 1;

            oglasi.Add(new Oglas(
                txtNaziv.Text,
                txtVjestine.Text,
                cmbNivo.Text,
                cmbNacinRada.Text,
                txtTrajanje.Text,
                broj,
                "Aktivan",
                chkHitno.Checked,
                txtOpis.Text
            ));

            OsvjeziListu();
            MessageBox.Show("Oglas je dodat.");
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            Oglas o = IzabraniOglas();
            if (o == null) return;

            o.Naziv = txtNaziv.Text;
            o.Vjestine = txtVjestine.Text;
            o.Nivo = cmbNivo.Text;
            o.NacinRada = cmbNacinRada.Text;
            o.Trajanje = txtTrajanje.Text;
            o.Hitno = chkHitno.Checked;
            o.Opis = txtOpis.Text;

            int broj;
            if (int.TryParse(txtBrojRadnika.Text, out broj))
                o.BrojRadnika = broj;

            OsvjeziListu();
            MessageBox.Show("Oglas je uređen.");
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            Oglas o = IzabraniOglas();
            if (o == null) return;

            oglasi.Remove(o);
            OsvjeziListu();
            MessageBox.Show("Oglas je obrisan.");
        }

        private void btnArhiviraj_Click(object sender, EventArgs e)
        {
            Oglas o = IzabraniOglas();
            if (o == null) return;

            o.Status = "Arhiviran";
            OsvjeziListu();
        }

        private void btnPauziraj_Click(object sender, EventArgs e)
        {
            Oglas o = IzabraniOglas();
            if (o == null) return;

            o.Status = "Pauziran";
            OsvjeziListu();
        }

        private void btnAktiviraj_Click(object sender, EventArgs e)
        {
            Oglas o = IzabraniOglas();
            if (o == null) return;

            o.Status = "Aktivan";
            OsvjeziListu();
        }

        private void btnDupliciraj_Click(object sender, EventArgs e)
        {
            Oglas o = IzabraniOglas();
            if (o == null) return;

            oglasi.Add(new Oglas(
                o.Naziv + " - kopija",
                o.Vjestine,
                o.Nivo,
                o.NacinRada,
                o.Trajanje,
                o.BrojRadnika,
                "Aktivan",
                o.Hitno,
                o.Opis
            ));

            OsvjeziListu();
            MessageBox.Show("Oglas je dupliciran.");
        }

        private class Oglas
        {
            public string Naziv;
            public string Vjestine;
            public string Nivo;
            public string NacinRada;
            public string Trajanje;
            public int BrojRadnika;
            public string Status;
            public bool Hitno;
            public string Opis;

            public Oglas(string naziv, string vjestine, string nivo, string nacinRada, string trajanje, int brojRadnika, string status, bool hitno, string opis)
            {
                Naziv = naziv;
                Vjestine = vjestine;
                Nivo = nivo;
                NacinRada = nacinRada;
                Trajanje = trajanje;
                BrojRadnika = brojRadnika;
                Status = status;
                Hitno = hitno;
                Opis = opis;
            }
        }
    }
}