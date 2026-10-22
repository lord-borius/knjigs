using System;

namespace knjigs
{
    public class Knjiga
    {
        private const int NajstarejseDovoljenoLeto = 1450;

        private string naslov;
        private string avtor;
        private string isbn;
        private int letoIzdaje;
        private int steviloIzposoj;

        public string Naslov
        {
            get { return naslov; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Naslov ne sme biti prazen.", "value");
                }

                naslov = value;
            }
        }

        public string Avtor
        {
            get { return avtor; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Avtor ne sme biti prazen.", "value");
                }

                avtor = value;
            }
        }

        public string ISBN
        {
            get { return isbn; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("ISBN ne sme biti prazen.", "value");
                }

                isbn = value;
            }
        }

        public int LetoIzdaje
        {
            get { return letoIzdaje; }
            set
            {
                int trenutnoLeto = DateTime.Now.Year;
                if (value < NajstarejseDovoljenoLeto || value > trenutnoLeto)
                {
                    throw new ArgumentException(
                        "Leto izdaje mora biti med 1450 in trenutnim letom.", "value");
                }

                letoIzdaje = value;
            }
        }

        public bool JeIzposojena { get; private set; }

        public int SteviloIzposoj
        {
            get { return steviloIzposoj; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Število izposoj ne sme biti negativno.", "value");
                }

                steviloIzposoj = value;
            }
        }

        public Knjiga()
            : this("Neznan naslov", "Neznan avtor", "Neznan ISBN", DateTime.Now.Year)
        {
        }

        public Knjiga(string naslov, string avtor, string isbn)
            : this(naslov, avtor, isbn, DateTime.Now.Year)
        {
        }

        public Knjiga(string naslov, string avtor, string isbn, int letoIzdaje)
        {
            Naslov = naslov;
            Avtor = avtor;
            ISBN = isbn;
            LetoIzdaje = letoIzdaje;
            JeIzposojena = false;
            SteviloIzposoj = 0;
        }

        public bool Izposodi()
        {
            if (JeIzposojena)
            {
                return false;
            }

            JeIzposojena = true;
            SteviloIzposoj++;
            return true;
        }

        public bool Vrni()
        {
            if (!JeIzposojena)
            {
                return false;
            }

            JeIzposojena = false;
            return true;
        }

        public bool JeStarejsaOd(int leto)
        {
            return LetoIzdaje < leto;
        }

        public string PridobiOpis()
        {
            return string.Format(
                "Naslov: {0}\r\nAvtor: {1}\r\nISBN: {2}\r\nLeto izdaje: {3}\r\n" +
                "Razpoložljivost: {4}\r\nŠtevilo izposoj: {5}",
                Naslov,
                Avtor,
                ISBN,
                LetoIzdaje,
                JeIzposojena ? "izposojena" : "razpoložljiva",
                SteviloIzposoj);
        }
    }
}
