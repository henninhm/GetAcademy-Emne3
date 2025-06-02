namespace Bilforhandler
{
    internal class Bil
    {
        public int Årsmådell;
        public string Merke;
        public string Registreringsnummer;
        public int Distansekjørt;
        public string Eier;

        public Bil(string merke, int årsmådell, string registreringsnummer, int distansekjørt, string eier)
        {
            Merke = merke;
            Årsmådell = årsmådell;
            Registreringsnummer = registreringsnummer;
            Distansekjørt = distansekjørt;
            Eier = eier;
        }
    }
}
