using System;
using System.Windows.Forms;

namespace knjigs
{
    public partial class Form1 : Form
    {
        private Knjiga knjiga;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnUstvari_Click(object sender, System.EventArgs e)
        {
            int letoIzdaje;
            if (!int.TryParse(txtLeto.Text, out letoIzdaje))
            {
                PrikaziNapako("Leto izdaje mora biti celo število.");
                return;
            }

            try
            {
                knjiga = new Knjiga(txtNaslov.Text, txtAvtor.Text, txtISBN.Text, letoIzdaje);
                txtOpis.Text = knjiga.PridobiOpis();
                NastaviSporocilo("Knjiga je bila uspešno ustvarjena.");
            }
            catch (System.ArgumentException napaka)
            {
                PrikaziNapako(napaka.Message);
            }
        }

        private void btnIzposodi_Click(object sender, System.EventArgs e)
        {
            if (!PreveriKnjigo())
            {
                return;
            }

            if (knjiga.Izposodi())
            {
                NastaviSporocilo("Knjiga je bila izposojena.");
            }
            else
            {
                PrikaziNapako("Knjiga je že izposojena.");
            }
        }

        private void btnVrni_Click(object sender, System.EventArgs e)
        {
            if (!PreveriKnjigo())
            {
                return;
            }

            if (knjiga.Vrni())
            {
                NastaviSporocilo("Knjiga je bila vrnjena.");
            }
            else
            {
                PrikaziNapako("Knjiga ni izposojena.");
            }
        }

        private void btnStarejsa_Click(object sender, System.EventArgs e)
        {
            if (!PreveriKnjigo())
            {
                return;
            }

            int leto;
            if (!int.TryParse(txtPreveriLeto.Text, out leto))
            {
                PrikaziNapako("Leto za preverjanje mora biti celo število.");
                return;
            }

            NastaviSporocilo(knjiga.JeStarejsaOd(leto)
                ? "Knjiga je starejša od izbranega leta."
                : "Knjiga ni starejša od izbranega leta.");
        }

        private void btnOpis_Click(object sender, System.EventArgs e)
        {
            if (!PreveriKnjigo())
            {
                return;
            }

            txtOpis.Text = knjiga.PridobiOpis();
            NastaviSporocilo("Opis knjige je prikazan.");
        }

        private bool PreveriKnjigo()
        {
            if (knjiga != null)
            {
                return true;
            }

            PrikaziNapako("Najprej ustvarite knjigo.");
            return false;
        }

        private void NastaviSporocilo(string sporocilo)
        {
            lblStatus.Text = sporocilo;
        }

        private void PrikaziNapako(string sporocilo)
        {
            NastaviSporocilo(sporocilo);
            MessageBox.Show(sporocilo, "Napaka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
