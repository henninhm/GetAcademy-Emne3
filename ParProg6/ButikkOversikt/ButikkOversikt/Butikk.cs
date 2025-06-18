namespace ButikkOversikt
{
    internal class Butikk
    {
        public string Spesialitet;
        int PrisKlasse;
        public string Navn;

        public Butikk(string spesialitet, int prisKlasse, string navn)
        {
            Spesialitet = spesialitet;
            PrisKlasse = prisKlasse;
            Navn = navn;
        }

        public void PrintInfo ()
        {

        }
    }
}
