namespace sorgorg
{
    partial class Analitika
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;

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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlKartice = new System.Windows.Forms.Panel();
            this.lblPregledi = new System.Windows.Forms.Label();
            this.lblPrijave = new System.Windows.Forms.Label();
            this.lblZaposleni = new System.Windows.Forms.Label();
            this.lblVrijeme = new System.Windows.Forms.Label();
            this.pnlTabela = new System.Windows.Forms.Panel();
            this.lblOglasi = new System.Windows.Forms.Label();
            this.dgvOglasi = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeader.SuspendLayout();
            this.pnlKartice.SuspendLayout();
            this.pnlTabela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOglasi)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1100, 90);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(21, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(215, 55);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Analitika";
            // 
            // pnlKartice
            // 
            this.pnlKartice.Controls.Add(this.lblPregledi);
            this.pnlKartice.Controls.Add(this.lblPrijave);
            this.pnlKartice.Controls.Add(this.lblZaposleni);
            this.pnlKartice.Controls.Add(this.lblVrijeme);
            this.pnlKartice.Location = new System.Drawing.Point(30, 110);
            this.pnlKartice.Name = "pnlKartice";
            this.pnlKartice.Size = new System.Drawing.Size(1040, 120);
            this.pnlKartice.TabIndex = 1;
            // 
            // lblPregledi
            // 
            this.lblPregledi.BackColor = System.Drawing.Color.White;
            this.lblPregledi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPregledi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblPregledi.Location = new System.Drawing.Point(0, 0);
            this.lblPregledi.Name = "lblPregledi";
            this.lblPregledi.Size = new System.Drawing.Size(240, 100);
            this.lblPregledi.TabIndex = 0;
            this.lblPregledi.Text = "Pregledi oglasa\n1240";
            this.lblPregledi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrijave
            // 
            this.lblPrijave.BackColor = System.Drawing.Color.White;
            this.lblPrijave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrijave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblPrijave.Location = new System.Drawing.Point(260, 0);
            this.lblPrijave.Name = "lblPrijave";
            this.lblPrijave.Size = new System.Drawing.Size(240, 100);
            this.lblPrijave.TabIndex = 1;
            this.lblPrijave.Text = "Ukupno prijava\n85";
            this.lblPrijave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblZaposleni
            // 
            this.lblZaposleni.BackColor = System.Drawing.Color.White;
            this.lblZaposleni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblZaposleni.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblZaposleni.Location = new System.Drawing.Point(520, 0);
            this.lblZaposleni.Name = "lblZaposleni";
            this.lblZaposleni.Size = new System.Drawing.Size(240, 100);
            this.lblZaposleni.TabIndex = 2;
            this.lblZaposleni.Text = "Zaposleni\n12";
            this.lblZaposleni.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVrijeme
            // 
            this.lblVrijeme.BackColor = System.Drawing.Color.White;
            this.lblVrijeme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVrijeme.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblVrijeme.Location = new System.Drawing.Point(780, 0);
            this.lblVrijeme.Name = "lblVrijeme";
            this.lblVrijeme.Size = new System.Drawing.Size(240, 100);
            this.lblVrijeme.TabIndex = 3;
            this.lblVrijeme.Text = "Prosjek zapošljavanja\n5 dana";
            this.lblVrijeme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTabela
            // 
            this.pnlTabela.BackColor = System.Drawing.Color.White;
            this.pnlTabela.Controls.Add(this.lblOglasi);
            this.pnlTabela.Controls.Add(this.dgvOglasi);
            this.pnlTabela.Location = new System.Drawing.Point(30, 250);
            this.pnlTabela.Name = "pnlTabela";
            this.pnlTabela.Size = new System.Drawing.Size(1040, 400);
            this.pnlTabela.TabIndex = 2;
            // 
            // lblOglasi
            // 
            this.lblOglasi.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblOglasi.Location = new System.Drawing.Point(25, 20);
            this.lblOglasi.Name = "lblOglasi";
            this.lblOglasi.Size = new System.Drawing.Size(137, 33);
            this.lblOglasi.TabIndex = 0;
            this.lblOglasi.Text = "Statistika oglasa";
            // 
            // dgvOglasi
            // 
            this.dgvOglasi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOglasi.ColumnHeadersHeight = 29;
            this.dgvOglasi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvOglasi.Location = new System.Drawing.Point(25, 70);
            this.dgvOglasi.Name = "dgvOglasi";
            this.dgvOglasi.ReadOnly = true;
            this.dgvOglasi.RowHeadersWidth = 51;
            this.dgvOglasi.Size = new System.Drawing.Size(980, 300);
            this.dgvOglasi.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Naziv oglasa";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Pregledi";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Prijave";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Status";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Analitika
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlKartice);
            this.Controls.Add(this.pnlTabela);
            this.Name = "Analitika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analitika";
            this.pnlHeader.ResumeLayout(false);
            this.pnlKartice.ResumeLayout(false);
            this.pnlTabela.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOglasi)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}