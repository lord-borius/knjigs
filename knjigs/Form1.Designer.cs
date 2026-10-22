namespace knjigs
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label lblAvtor;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblLeto;
        private System.Windows.Forms.Label lblPreveriLeto;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.TextBox txtAvtor;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtLeto;
        private System.Windows.Forms.TextBox txtPreveriLeto;
        private System.Windows.Forms.Button btnUstvari;
        private System.Windows.Forms.Button btnIzposodi;
        private System.Windows.Forms.Button btnVrni;
        private System.Windows.Forms.Button btnStarejsa;
        private System.Windows.Forms.Button btnOpis;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtOpis;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.lblAvtor = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblLeto = new System.Windows.Forms.Label();
            this.lblPreveriLeto = new System.Windows.Forms.Label();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.txtAvtor = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtLeto = new System.Windows.Forms.TextBox();
            this.txtPreveriLeto = new System.Windows.Forms.TextBox();
            this.btnUstvari = new System.Windows.Forms.Button();
            this.btnIzposodi = new System.Windows.Forms.Button();
            this.btnVrni = new System.Windows.Forms.Button();
            this.btnStarejsa = new System.Windows.Forms.Button();
            this.btnOpis = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Location = new System.Drawing.Point(12, 15);
            this.lblNaslov.Text = "Naslov:";
            this.txtNaslov.Location = new System.Drawing.Point(120, 12);
            this.txtNaslov.Size = new System.Drawing.Size(300, 20);
            this.lblAvtor.AutoSize = true;
            this.lblAvtor.Location = new System.Drawing.Point(12, 41);
            this.lblAvtor.Text = "Avtor:";
            this.txtAvtor.Location = new System.Drawing.Point(120, 38);
            this.txtAvtor.Size = new System.Drawing.Size(300, 20);
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(12, 67);
            this.lblISBN.Text = "ISBN:";
            this.txtISBN.Location = new System.Drawing.Point(120, 64);
            this.txtISBN.Size = new System.Drawing.Size(300, 20);
            this.lblLeto.AutoSize = true;
            this.lblLeto.Location = new System.Drawing.Point(12, 93);
            this.lblLeto.Text = "Leto izdaje:";
            this.txtLeto.Location = new System.Drawing.Point(120, 90);
            this.txtLeto.Size = new System.Drawing.Size(100, 20);

            this.btnUstvari.Location = new System.Drawing.Point(12, 125);
            this.btnUstvari.Size = new System.Drawing.Size(120, 28);
            this.btnUstvari.Text = "Ustvari knjigo";
            this.btnUstvari.Click += new System.EventHandler(this.btnUstvari_Click);
            this.btnIzposodi.Location = new System.Drawing.Point(138, 125);
            this.btnIzposodi.Size = new System.Drawing.Size(90, 28);
            this.btnIzposodi.Text = "Izposodi";
            this.btnIzposodi.Click += new System.EventHandler(this.btnIzposodi_Click);
            this.btnVrni.Location = new System.Drawing.Point(234, 125);
            this.btnVrni.Size = new System.Drawing.Size(90, 28);
            this.btnVrni.Text = "Vrni";
            this.btnVrni.Click += new System.EventHandler(this.btnVrni_Click);
            this.btnOpis.Location = new System.Drawing.Point(330, 125);
            this.btnOpis.Size = new System.Drawing.Size(90, 28);
            this.btnOpis.Text = "Prikaži opis";
            this.btnOpis.Click += new System.EventHandler(this.btnOpis_Click);

            this.lblPreveriLeto.AutoSize = true;
            this.lblPreveriLeto.Location = new System.Drawing.Point(12, 170);
            this.lblPreveriLeto.Text = "Preveri starejša od leta:";
            this.txtPreveriLeto.Location = new System.Drawing.Point(170, 167);
            this.txtPreveriLeto.Size = new System.Drawing.Size(100, 20);
            this.btnStarejsa.Location = new System.Drawing.Point(276, 165);
            this.btnStarejsa.Size = new System.Drawing.Size(144, 24);
            this.btnStarejsa.Text = "Preveri";
            this.btnStarejsa.Click += new System.EventHandler(this.btnStarejsa_Click);

            this.txtOpis.Location = new System.Drawing.Point(12, 205);
            this.txtOpis.Multiline = true;
            this.txtOpis.ReadOnly = true;
            this.txtOpis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOpis.Size = new System.Drawing.Size(408, 125);
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 345);
            this.lblStatus.Size = new System.Drawing.Size(0, 13);

            this.ClientSize = new System.Drawing.Size(435, 380);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.txtNaslov);
            this.Controls.Add(this.lblAvtor);
            this.Controls.Add(this.txtAvtor);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.lblLeto);
            this.Controls.Add(this.txtLeto);
            this.Controls.Add(this.btnUstvari);
            this.Controls.Add(this.btnIzposodi);
            this.Controls.Add(this.btnVrni);
            this.Controls.Add(this.btnOpis);
            this.Controls.Add(this.lblPreveriLeto);
            this.Controls.Add(this.txtPreveriLeto);
            this.Controls.Add(this.btnStarejsa);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.lblStatus);
            this.Name = "Form1";
            this.Text = "Knjige";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

