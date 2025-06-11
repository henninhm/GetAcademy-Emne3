namespace PolitiKontroll
{
    internal class Bil
    {
        public bool Mobilbruk;
        public bool SetebeltePå;
        public bool GyldigFørerkort;
        public int Alkoholprosent;
        public int Fart;
        public int AntallBøter;

        public Bil(bool mobilbruk, bool setebeltePå, bool gyldigFørerkort, int alkoholprosent, int fart)
        {
            Mobilbruk = mobilbruk;
            SetebeltePå = setebeltePå;
            GyldigFørerkort = gyldigFørerkort;
            Alkoholprosent = alkoholprosent;
            Fart = fart;
        }
    }
}
