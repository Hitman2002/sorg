namespace sorgorg
{
    partial class Prijave
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button btnFiltriraj;

        private System.Windows.Forms.Panel pnlTabela;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.DataGridView dgvPrijave;

        private System.Windows.Forms.Panel pnlDetalji;
        private System.Windows.Forms.Label lblDetalji;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblVjestine;
        private System.Windows.Forms.Label lblDostupnost;
        private System.Windows.Forms.RichTextBox txtBiljeska;
        private System.Windows.Forms.Button btnDetalji;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btnPoruka;
        private System.Windows.Forms.Button btnFavorit;
        private System.Windows.Forms.Button btnOdbij;
        private System.Windows.Forms.Button btnPrihvati;

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
            this.lblFilter = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnFiltriraj = new System.Windows.Forms.Button();
            this.pnlTabela = new System.Windows.Forms.Panel();
            this.lblLista = new System.Windows.Forms.Label();
            this.dgvPrijave = new System.Windows.Forms.DataGridView();
            this.pnlDetalji = new System.Windows.Forms.Panel();
            this.lblDetalji = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblVjestine = new System.Windows.Forms.Label();
            this.lblDostupnost = new System.Windows.Forms.Label();
            this.txtBiljeska = new System.Windows.Forms.RichTextBox();
            this.btnDetalji = new System.Windows.Forms.Button();
            this.btnPoruka = new System.Windows.Forms.Button();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnFavorit = new System.Windows.Forms.Button();
            this.btnOdbij = new System.Windows.Forms.Button();
            this.btnPrihvati = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeader.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.pnlTabela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrijave)).BeginInit();
            this.pnlDetalji.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1150, 72);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(30, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 69);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Prijave";
            // 
            // pnlFilter
            // 
            this.pnlFilter.BackColor = System.Drawing.Color.White;
            this.pnlFilter.Controls.Add(this.lblFilter);
            this.pnlFilter.Controls.Add(this.txtPretraga);
            this.pnlFilter.Controls.Add(this.cmbStatus);
            this.pnlFilter.Controls.Add(this.btnFiltriraj);
            this.pnlFilter.Location = new System.Drawing.Point(30, 92);
            this.pnlFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(1090, 72);
            this.pnlFilter.TabIndex = 1;
            // 
            // lblFilter
            // 
            this.lblFilter.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblFilter.Location = new System.Drawing.Point(25, 14);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(180, 24);
            this.lblFilter.TabIndex = 0;
            this.lblFilter.Text = "Filter prijava";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(220, 22);
            this.txtPretraga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(280, 22);
            this.txtPretraga.TabIndex = 1;
            this.txtPretraga.Text = "Pretraga po imenu ili vještini";
            // 
            // cmbStatus
            // 
            this.cmbStatus.Items.AddRange(new object[] {
            "Svi statusi",
            "Novi",
            "U razmatranju",
            "Pozvan na intervju",
            "Odbijen",
            "Prihvaćen"});
            this.cmbStatus.Location = new System.Drawing.Point(525, 22);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(220, 24);
            this.cmbStatus.TabIndex = 2;
            this.cmbStatus.Text = "Svi statusi";
            // 
            // btnFiltriraj
            // 
            this.btnFiltriraj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnFiltriraj.FlatAppearance.BorderSize = 0;
            this.btnFiltriraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltriraj.ForeColor = System.Drawing.Color.White;
            this.btnFiltriraj.Location = new System.Drawing.Point(770, 20);
            this.btnFiltriraj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFiltriraj.Name = "btnFiltriraj";
            this.btnFiltriraj.Size = new System.Drawing.Size(140, 28);
            this.btnFiltriraj.TabIndex = 3;
            this.btnFiltriraj.Text = "Filtriraj";
            this.btnFiltriraj.UseVisualStyleBackColor = false;
            // 
            // pnlTabela
            // 
            this.pnlTabela.BackColor = System.Drawing.Color.White;
            this.pnlTabela.Controls.Add(this.lblLista);
            this.pnlTabela.Controls.Add(this.dgvPrijave);
            this.pnlTabela.Location = new System.Drawing.Point(30, 180);
            this.pnlTabela.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTabela.Name = "pnlTabela";
            this.pnlTabela.Size = new System.Drawing.Size(730, 364);
            this.pnlTabela.TabIndex = 2;
            // 
            // lblLista
            // 
            this.lblLista.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblLista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblLista.Location = new System.Drawing.Point(25, 16);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(300, 28);
            this.lblLista.TabIndex = 0;
            this.lblLista.Text = "Lista kandidata";
            // 
            // dgvPrijave
            // 
            this.dgvPrijave.AllowUserToAddRows = false;
            this.dgvPrijave.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrijave.ColumnHeadersHeight = 29;
            this.dgvPrijave.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvPrijave.Location = new System.Drawing.Point(25, 56);
            this.dgvPrijave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPrijave.MultiSelect = false;
            this.dgvPrijave.Name = "dgvPrijave";
            this.dgvPrijave.ReadOnly = true;
            this.dgvPrijave.RowHeadersWidth = 51;
            this.dgvPrijave.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrijave.Size = new System.Drawing.Size(680, 284);
            this.dgvPrijave.TabIndex = 1;
            // 
            // pnlDetalji
            // 
            this.pnlDetalji.BackColor = System.Drawing.Color.White;
            this.pnlDetalji.Controls.Add(this.lblDetalji);
            this.pnlDetalji.Controls.Add(this.lblIme);
            this.pnlDetalji.Controls.Add(this.lblVjestine);
            this.pnlDetalji.Controls.Add(this.lblDostupnost);
            this.pnlDetalji.Controls.Add(this.txtBiljeska);
            this.pnlDetalji.Controls.Add(this.btnDetalji);
            this.pnlDetalji.Controls.Add(this.btnPoruka);
            this.pnlDetalji.Controls.Add(this.btnStatus);
            this.pnlDetalji.Controls.Add(this.btnFavorit);
            this.pnlDetalji.Controls.Add(this.btnOdbij);
            this.pnlDetalji.Controls.Add(this.btnPrihvati);
            this.pnlDetalji.Location = new System.Drawing.Point(790, 180);
            this.pnlDetalji.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlDetalji.Name = "pnlDetalji";
            this.pnlDetalji.Size = new System.Drawing.Size(330, 364);
            this.pnlDetalji.TabIndex = 3;
            // 
            // lblDetalji
            // 
            this.lblDetalji.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblDetalji.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblDetalji.Location = new System.Drawing.Point(25, 16);
            this.lblDetalji.Name = "lblDetalji";
            this.lblDetalji.Size = new System.Drawing.Size(250, 28);
            this.lblDetalji.TabIndex = 0;
            this.lblDetalji.Text = "Detalji prijave";
            // 
            // lblIme
            // 
            this.lblIme.Location = new System.Drawing.Point(25, 60);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(280, 20);
            this.lblIme.TabIndex = 1;
            this.lblIme.Text = "Ime: -";
            // 
            // lblVjestine
            // 
            this.lblVjestine.Location = new System.Drawing.Point(25, 88);
            this.lblVjestine.Name = "lblVjestine";
            this.lblVjestine.Size = new System.Drawing.Size(280, 36);
            this.lblVjestine.TabIndex = 2;
            this.lblVjestine.Text = "Vještine: -";
            // 
            // lblDostupnost
            // 
            this.lblDostupnost.Location = new System.Drawing.Point(25, 132);
            this.lblDostupnost.Name = "lblDostupnost";
            this.lblDostupnost.Size = new System.Drawing.Size(280, 20);
            this.lblDostupnost.TabIndex = 3;
            this.lblDostupnost.Text = "Dostupnost: -";
            // 
            // txtBiljeska
            // 
            this.txtBiljeska.Location = new System.Drawing.Point(25, 164);
            this.txtBiljeska.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBiljeska.Name = "txtBiljeska";
            this.txtBiljeska.Size = new System.Drawing.Size(280, 65);
            this.txtBiljeska.TabIndex = 4;
            this.txtBiljeska.Text = "Interna bilješka o kandidatu...";
            // 
            // btnDetalji
            // 
            this.btnDetalji.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnDetalji.FlatAppearance.BorderSize = 0;
            this.btnDetalji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalji.ForeColor = System.Drawing.Color.White;
            this.btnDetalji.Location = new System.Drawing.Point(25, 244);
            this.btnDetalji.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(130, 28);
            this.btnDetalji.TabIndex = 5;
            this.btnDetalji.Text = "Pregled profila";
            this.btnDetalji.UseVisualStyleBackColor = false;
            // 
            // btnPoruka
            // 
            this.btnPoruka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnPoruka.FlatAppearance.BorderSize = 0;
            this.btnPoruka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPoruka.ForeColor = System.Drawing.Color.White;
            this.btnPoruka.Location = new System.Drawing.Point(175, 244);
            this.btnPoruka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPoruka.Name = "btnPoruka";
            this.btnPoruka.Size = new System.Drawing.Size(130, 28);
            this.btnPoruka.TabIndex = 6;
            this.btnPoruka.Text = "Poruka";
            this.btnPoruka.UseVisualStyleBackColor = false;
            // 
            // btnStatus
            // 
            this.btnStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnStatus.FlatAppearance.BorderSize = 0;
            this.btnStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatus.ForeColor = System.Drawing.Color.White;
            this.btnStatus.Location = new System.Drawing.Point(25, 280);
            this.btnStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(130, 28);
            this.btnStatus.TabIndex = 7;
            this.btnStatus.Text = "Promijeni status";
            this.btnStatus.UseVisualStyleBackColor = false;
            // 
            // btnFavorit
            // 
            this.btnFavorit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnFavorit.FlatAppearance.BorderSize = 0;
            this.btnFavorit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFavorit.ForeColor = System.Drawing.Color.White;
            this.btnFavorit.Location = new System.Drawing.Point(175, 280);
            this.btnFavorit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFavorit.Name = "btnFavorit";
            this.btnFavorit.Size = new System.Drawing.Size(130, 28);
            this.btnFavorit.TabIndex = 8;
            this.btnFavorit.Text = "Favorit";
            this.btnFavorit.UseVisualStyleBackColor = false;
            // 
            // btnOdbij
            // 
            this.btnOdbij.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnOdbij.FlatAppearance.BorderSize = 0;
            this.btnOdbij.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdbij.ForeColor = System.Drawing.Color.White;
            this.btnOdbij.Location = new System.Drawing.Point(25, 316);
            this.btnOdbij.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOdbij.Name = "btnOdbij";
            this.btnOdbij.Size = new System.Drawing.Size(130, 28);
            this.btnOdbij.TabIndex = 9;
            this.btnOdbij.Text = "Odbij";
            this.btnOdbij.UseVisualStyleBackColor = false;
            // 
            // btnPrihvati
            // 
            this.btnPrihvati.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.btnPrihvati.FlatAppearance.BorderSize = 0;
            this.btnPrihvati.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrihvati.ForeColor = System.Drawing.Color.White;
            this.btnPrihvati.Location = new System.Drawing.Point(175, 316);
            this.btnPrihvati.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrihvati.Name = "btnPrihvati";
            this.btnPrihvati.Size = new System.Drawing.Size(130, 28);
            this.btnPrihvati.TabIndex = 10;
            this.btnPrihvati.Text = "Prihvati";
            this.btnPrihvati.UseVisualStyleBackColor = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Ime kandidata";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Oglas";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Vještine";
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
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Dostupnost";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // Prijave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1150, 576);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.pnlTabela);
            this.Controls.Add(this.pnlDetalji);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Prijave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijave kandidata";
            this.pnlHeader.ResumeLayout(false);
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.pnlTabela.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrijave)).EndInit();
            this.pnlDetalji.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}