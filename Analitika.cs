using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace sorgorg
{
    public partial class Analitika : Form
    {
        public Analitika()
        {
            InitializeComponent();
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            List<OglasStat> lista = new List<OglasStat>()
            {
                new OglasStat("Junior C# Developer", 500, 30, "Aktivan"),
                new OglasStat("Web praksa", 320, 25, "Zatvoren"),
                new OglasStat("Frontend Developer", 420, 20, "Aktivan")
            };

            foreach (var o in lista)
            {
                dgvOglasi.Rows.Add(o.Naziv, o.Pregledi, o.Prijave, o.Status);
            }
        }

        class OglasStat
        {
            public string Naziv;
            public int Pregledi;
            public int Prijave;
            public string Status;

            public OglasStat(string n, int p, int pr, string s)
            {
                Naziv = n;
                Pregledi = p;
                Prijave = pr;
                Status = s;
            }
        }
    }
}