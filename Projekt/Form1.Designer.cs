namespace Projekt
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvPodcasts = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtbLank = new System.Windows.Forms.TextBox();
            this.cmbUppdatering = new System.Windows.Forms.ComboBox();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.btnLaggTillPodd = new System.Windows.Forms.Button();
            this.btnTaBortPodd = new System.Windows.Forms.Button();
            this.lvSparadeAvsnitt = new System.Windows.Forms.ListView();
            this.lvKategori = new System.Windows.Forms.ListView();
            this.txtbKategori = new System.Windows.Forms.TextBox();
            this.btnLaggTillKategori = new System.Windows.Forms.Button();
            this.btnTaBortKategori = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSparadeAvsnitt = new System.Windows.Forms.Label();
            this.lblPodcasts = new System.Windows.Forms.Label();
            this.lblKategoriLista = new System.Windows.Forms.Label();
            this.lblUrl = new System.Windows.Forms.Label();
            this.lblUppdatering = new System.Windows.Forms.Label();
            this.lblKategoriCombo = new System.Windows.Forms.Label();
            this.lblNyKategori = new System.Windows.Forms.Label();
            this.btnAndra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvPodcasts
            // 
            this.lvPodcasts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvPodcasts.Font = new System.Drawing.Font("Myanmar Text", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvPodcasts.GridLines = true;
            this.lvPodcasts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvPodcasts.HideSelection = false;
            this.lvPodcasts.HoverSelection = true;
            this.lvPodcasts.Location = new System.Drawing.Point(25, 53);
            this.lvPodcasts.Name = "lvPodcasts";
            this.lvPodcasts.Size = new System.Drawing.Size(746, 150);
            this.lvPodcasts.TabIndex = 0;
            this.lvPodcasts.UseCompatibleStateImageBehavior = false;
            this.lvPodcasts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Avsnitt";
            this.columnHeader5.Width = 90;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Namn";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 210;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Uppdatering";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Kategori";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 100;
            // 
            // txtbLank
            // 
            this.txtbLank.Font = new System.Drawing.Font("Myanmar Text", 8F);
            this.txtbLank.Location = new System.Drawing.Point(25, 250);
            this.txtbLank.Name = "txtbLank";
            this.txtbLank.Size = new System.Drawing.Size(314, 37);
            this.txtbLank.TabIndex = 1;
            this.txtbLank.Text = "https//:";
            // 
            // cmbUppdatering
            // 
            this.cmbUppdatering.Font = new System.Drawing.Font("Myanmar Text", 8F);
            this.cmbUppdatering.FormattingEnabled = true;
            this.cmbUppdatering.Location = new System.Drawing.Point(359, 250);
            this.cmbUppdatering.Name = "cmbUppdatering";
            this.cmbUppdatering.Size = new System.Drawing.Size(197, 37);
            this.cmbUppdatering.TabIndex = 2;
            // 
            // cmbKategori
            // 
            this.cmbKategori.Font = new System.Drawing.Font("Myanmar Text", 8F);
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(574, 250);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(197, 37);
            this.cmbKategori.TabIndex = 3;
            // 
            // btnLaggTillPodd
            // 
            this.btnLaggTillPodd.Font = new System.Drawing.Font("Myanmar Text", 8F, System.Drawing.FontStyle.Bold);
            this.btnLaggTillPodd.Location = new System.Drawing.Point(25, 306);
            this.btnLaggTillPodd.Name = "btnLaggTillPodd";
            this.btnLaggTillPodd.Size = new System.Drawing.Size(112, 36);
            this.btnLaggTillPodd.TabIndex = 4;
            this.btnLaggTillPodd.Text = "Lägg till";
            this.btnLaggTillPodd.UseVisualStyleBackColor = true;
            // 
            // btnTaBortPodd
            // 
            this.btnTaBortPodd.Font = new System.Drawing.Font("Myanmar Text", 8F, System.Drawing.FontStyle.Bold);
            this.btnTaBortPodd.Location = new System.Drawing.Point(159, 306);
            this.btnTaBortPodd.Name = "btnTaBortPodd";
            this.btnTaBortPodd.Size = new System.Drawing.Size(112, 36);
            this.btnTaBortPodd.TabIndex = 5;
            this.btnTaBortPodd.Text = "Ta bort";
            this.btnTaBortPodd.UseVisualStyleBackColor = true;
            // 
            // lvSparadeAvsnitt
            // 
            this.lvSparadeAvsnitt.Font = new System.Drawing.Font("Myanmar Text", 8F);
            this.lvSparadeAvsnitt.HideSelection = false;
            this.lvSparadeAvsnitt.Location = new System.Drawing.Point(27, 419);
            this.lvSparadeAvsnitt.Name = "lvSparadeAvsnitt";
            this.lvSparadeAvsnitt.Size = new System.Drawing.Size(746, 206);
            this.lvSparadeAvsnitt.TabIndex = 6;
            this.lvSparadeAvsnitt.UseCompatibleStateImageBehavior = false;
            // 
            // lvKategori
            // 
            this.lvKategori.Font = new System.Drawing.Font("Myanmar Text", 8F);
            this.lvKategori.HideSelection = false;
            this.lvKategori.Location = new System.Drawing.Point(842, 53);
            this.lvKategori.Name = "lvKategori";
            this.lvKategori.Size = new System.Drawing.Size(282, 150);
            this.lvKategori.TabIndex = 7;
            this.lvKategori.UseCompatibleStateImageBehavior = false;
            // 
            // txtbKategori
            // 
            this.txtbKategori.Font = new System.Drawing.Font("Myanmar Text", 8F);
            this.txtbKategori.Location = new System.Drawing.Point(842, 252);
            this.txtbKategori.Name = "txtbKategori";
            this.txtbKategori.Size = new System.Drawing.Size(282, 37);
            this.txtbKategori.TabIndex = 8;
            // 
            // btnLaggTillKategori
            // 
            this.btnLaggTillKategori.Font = new System.Drawing.Font("Myanmar Text", 8F, System.Drawing.FontStyle.Bold);
            this.btnLaggTillKategori.Location = new System.Drawing.Point(842, 306);
            this.btnLaggTillKategori.Name = "btnLaggTillKategori";
            this.btnLaggTillKategori.Size = new System.Drawing.Size(91, 36);
            this.btnLaggTillKategori.TabIndex = 9;
            this.btnLaggTillKategori.Text = "Lägg till";
            this.btnLaggTillKategori.UseVisualStyleBackColor = true;
            // 
            // btnTaBortKategori
            // 
            this.btnTaBortKategori.Font = new System.Drawing.Font("Myanmar Text", 8F, System.Drawing.FontStyle.Bold);
            this.btnTaBortKategori.Location = new System.Drawing.Point(1043, 306);
            this.btnTaBortKategori.Name = "btnTaBortKategori";
            this.btnTaBortKategori.Size = new System.Drawing.Size(81, 36);
            this.btnTaBortKategori.TabIndex = 10;
            this.btnTaBortKategori.Text = "Ta bort";
            this.btnTaBortKategori.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(901, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(987, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(901, 445);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "label3";
            // 
            // lblSparadeAvsnitt
            // 
            this.lblSparadeAvsnitt.AutoSize = true;
            this.lblSparadeAvsnitt.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold);
            this.lblSparadeAvsnitt.Location = new System.Drawing.Point(21, 379);
            this.lblSparadeAvsnitt.Name = "lblSparadeAvsnitt";
            this.lblSparadeAvsnitt.Size = new System.Drawing.Size(167, 36);
            this.lblSparadeAvsnitt.TabIndex = 14;
            this.lblSparadeAvsnitt.Text = "Sparade avsnitt:";
            // 
            // lblPodcasts
            // 
            this.lblPodcasts.AutoSize = true;
            this.lblPodcasts.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold);
            this.lblPodcasts.Location = new System.Drawing.Point(19, 9);
            this.lblPodcasts.Name = "lblPodcasts";
            this.lblPodcasts.Size = new System.Drawing.Size(103, 36);
            this.lblPodcasts.TabIndex = 15;
            this.lblPodcasts.Text = "Podcasts:";
            // 
            // lblKategoriLista
            // 
            this.lblKategoriLista.AutoSize = true;
            this.lblKategoriLista.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold);
            this.lblKategoriLista.Location = new System.Drawing.Point(836, 14);
            this.lblKategoriLista.Name = "lblKategoriLista";
            this.lblKategoriLista.Size = new System.Drawing.Size(120, 36);
            this.lblKategoriLista.TabIndex = 16;
            this.lblKategoriLista.Text = "Kategorier:";
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Font = new System.Drawing.Font("Myanmar Text", 8F, System.Drawing.FontStyle.Bold);
            this.lblUrl.Location = new System.Drawing.Point(20, 218);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(47, 29);
            this.lblUrl.TabIndex = 17;
            this.lblUrl.Text = "URL:";
            // 
            // lblUppdatering
            // 
            this.lblUppdatering.AutoSize = true;
            this.lblUppdatering.Font = new System.Drawing.Font("Myanmar Text", 8F, System.Drawing.FontStyle.Bold);
            this.lblUppdatering.Location = new System.Drawing.Point(355, 218);
            this.lblUppdatering.Name = "lblUppdatering";
            this.lblUppdatering.Size = new System.Drawing.Size(114, 29);
            this.lblUppdatering.TabIndex = 18;
            this.lblUppdatering.Text = "Uppdatering:";
            // 
            // lblKategoriCombo
            // 
            this.lblKategoriCombo.AutoSize = true;
            this.lblKategoriCombo.Font = new System.Drawing.Font("Myanmar Text", 8F, System.Drawing.FontStyle.Bold);
            this.lblKategoriCombo.Location = new System.Drawing.Point(569, 218);
            this.lblKategoriCombo.Name = "lblKategoriCombo";
            this.lblKategoriCombo.Size = new System.Drawing.Size(82, 29);
            this.lblKategoriCombo.TabIndex = 19;
            this.lblKategoriCombo.Text = "Kategori:";
            // 
            // lblNyKategori
            // 
            this.lblNyKategori.AutoSize = true;
            this.lblNyKategori.Font = new System.Drawing.Font("Myanmar Text", 8F, System.Drawing.FontStyle.Bold);
            this.lblNyKategori.Location = new System.Drawing.Point(837, 218);
            this.lblNyKategori.Name = "lblNyKategori";
            this.lblNyKategori.Size = new System.Drawing.Size(107, 29);
            this.lblNyKategori.TabIndex = 20;
            this.lblNyKategori.Text = "Ny kategori:";
            // 
            // btnAndra
            // 
            this.btnAndra.Font = new System.Drawing.Font("Myanmar Text", 8F, System.Drawing.FontStyle.Bold);
            this.btnAndra.Location = new System.Drawing.Point(948, 306);
            this.btnAndra.Name = "btnAndra";
            this.btnAndra.Size = new System.Drawing.Size(81, 36);
            this.btnAndra.TabIndex = 21;
            this.btnAndra.Text = "Ändra";
            this.btnAndra.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 649);
            this.Controls.Add(this.btnAndra);
            this.Controls.Add(this.lblNyKategori);
            this.Controls.Add(this.lblKategoriCombo);
            this.Controls.Add(this.lblUppdatering);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.lblKategoriLista);
            this.Controls.Add(this.lblPodcasts);
            this.Controls.Add(this.lblSparadeAvsnitt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTaBortKategori);
            this.Controls.Add(this.btnLaggTillKategori);
            this.Controls.Add(this.txtbKategori);
            this.Controls.Add(this.lvKategori);
            this.Controls.Add(this.lvSparadeAvsnitt);
            this.Controls.Add(this.btnTaBortPodd);
            this.Controls.Add(this.btnLaggTillPodd);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.cmbUppdatering);
            this.Controls.Add(this.txtbLank);
            this.Controls.Add(this.lvPodcasts);
            this.Name = "Form1";
            this.Text = "Podcast";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvPodcasts;
        private System.Windows.Forms.TextBox txtbLank;
        private System.Windows.Forms.ComboBox cmbUppdatering;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Button btnLaggTillPodd;
        private System.Windows.Forms.Button btnTaBortPodd;
        private System.Windows.Forms.ListView lvSparadeAvsnitt;
        private System.Windows.Forms.ListView lvKategori;
        private System.Windows.Forms.Button btnLaggTillKategori;
        private System.Windows.Forms.Button btnTaBortKategori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSparadeAvsnitt;
        private System.Windows.Forms.Label lblPodcasts;
        private System.Windows.Forms.Label lblKategoriLista;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Label lblUppdatering;
        private System.Windows.Forms.Label lblKategoriCombo;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label lblNyKategori;
        public System.Windows.Forms.TextBox txtbKategori;
        private System.Windows.Forms.Button btnAndra;
    }
}

