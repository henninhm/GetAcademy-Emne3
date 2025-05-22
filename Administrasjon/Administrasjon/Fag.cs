namespace Administrasjon
{
    internal class Fag
    {
        public string Fagkode;
        public string Fagnavn;
        public int AntallStudiepoeng;

        public Fag(string fagnavn, string fagkode, int antallStudiepoeng)
        {
            Fagkode = fagkode;
            Fagnavn = fagnavn;
            AntallStudiepoeng = antallStudiepoeng;
        }

        public void SkrivUtInfo()
        {
            Console.WriteLine("Fagnavn:            " + Fagnavn);
            Console.WriteLine("Kode:               " + Fagkode);
            Console.WriteLine("Mulige studiepoeng: " + AntallStudiepoeng);
            Console.WriteLine("****************************************************");
        }
    }
}
