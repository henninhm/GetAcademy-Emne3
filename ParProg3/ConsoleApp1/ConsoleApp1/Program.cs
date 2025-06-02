using System.Runtime.Intrinsics.X86;

namespace Bilforhandler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            List<Bil> Biler = new List<Bil>();
            Bil Bullmeister = new Bil("bmw", 2015, "DK42632", 25000, "forhandler");
            Bil Opel = new Bil("opel", 2013, "DJ97675", 65000, "forhandler");
            Bil ToyotaCarola = new Bil("toyota", 2017, "DK10203", 45000, "forhandler");
            Bil Ferrarri = new Bil("ferrari", 2018, "DK35724", 20000, "forhandler");
            Biler.Add(Bullmeister);
            Biler.Add(Opel);
            Biler.Add(ToyotaCarola);
            Biler.Add(Ferrarri);

            p.SePåBiler(Biler);
        }


        public void SePåBiler(List<Bil> biler)
        {
            Console.WriteLine("Velkommen til sjappa mi\n" +
                          "Ønsker du å se på bilene mine?\n" +
                          "1) Ja.\n" +
                          "2) Jeg vet allerede hva jeg er ute etter.\n" +
                          "3) Nei takk. Jeg skal ikke ha noe.");

            var ans = Console.ReadLine();
            List<Bil> tempListe = new List<Bil>();
            if (ans == "1")
            {
                billiste(biler);
            }
            if (ans == "1"|| ans == "2")
            {
                tempListe = VelgÅrsModell(biler);
                tempListe = VelgDistanseKjørt(tempListe);
            }
            Console.WriteLine("Hvis du har bestemt deg for en bil du vil kjøpe, " +
                "så kan du taste inn registreringsnummeret nå?\n" +
                "Hvis ikke. Tast inn Nei");
            var ans2 = Console.ReadLine();
            if (ans2 == "Nei" || ans2 == "nei")
            {
                Console.WriteLine("Vil du se på bilene igjen?");
                var ans3 = Console.ReadLine();
                if (ans3 == "Ja" || ans3 == "ja")
                {
                    SePåBiler(biler);
                }
            }
            else
            {
                Bil kjøpes;
                foreach (var b in biler)
                {
                    if (b.Registreringsnummer == ans2)
                    {
                        string navn;
                        Console.WriteLine("Hvilket navn vil du at bilen skal registreres under?");
                        navn = Console.ReadLine();
                        KjøpBil(b, navn);
                    }
                }
            }
        }
        public void billiste(List<Bil> biler)
        {
            Console.WriteLine("-------------------");
            foreach (var b in biler)
            {
                Console.WriteLine($"{b.Merke}, {b.Årsmådell}, {b.Registreringsnummer}, {b.Distansekjørt} kr");
            }
            Console.WriteLine("-------------------");
        }

        public List<Bil> VelgÅrsModell(List<Bil> biler)
        {
            int startÅr;
            int sluttÅr;
            Console.WriteLine("Har du en bestemt årsmodell du er ute etter?\n" +
                "Skriv først inn tidligste år.");
            var fra = Console.ReadLine();
            bool success = int.TryParse(fra, out startÅr);
            if (!success)
            {
                Console.WriteLine("Svar må være et heltall. Prøv igjen!");
                VelgÅrsModell(biler);
            }
            Console.WriteLine("Skriv inn seneste år.");
            var til = Console.ReadLine();
            bool success2 = int.TryParse(til, out sluttÅr);
            if (!success2)
            {
                Console.WriteLine("Svar må være et heltall. Prøv igjen!");
                VelgÅrsModell(biler);
            }

            List<Bil> tempListe = new List<Bil>();
            foreach (var b in biler)
            {
                if (b.Årsmådell >= startÅr)
                {
                    if (b.Årsmådell <= sluttÅr)
                    {
                        tempListe.Add(b);
                    }
                }
            }
            billiste(tempListe);
            return tempListe;
        }

        public List<Bil> VelgDistanseKjørt(List<Bil> biler)
        {
            bool mindre = false;
            int distanseKjørt;

            Console.WriteLine("Hvor mye vil du at bilen skal ha kjørt?\n" +
            "Skriv et tall og deretter om du vil ha mer eller mindre enn det tallet.\n" +
            "Skriv x hvis du ikke bryr deg.");
            var distanse = Console.ReadLine();
            if (distanse == "x" || distanse == "X")
            {
                return biler;
            }

            bool success = int.TryParse(distanse, out distanseKjørt);
            if (!success)
            {
                Console.WriteLine("Svar må være et heltall. Prøv igjen!");
                VelgDistanseKjørt(biler);
            }
            var mm = Console.ReadLine();
            if (mm == "mindre" || mm == "Mindre")
            {
                mindre = true;
            }
            List<Bil> tempListe = new List<Bil>();
            foreach (var b in biler)
            {
                if (mindre)
                {
                    if (b.Distansekjørt <= distanseKjørt)
                    {
                        tempListe.Add(b);
                    }
                }
                else
                {
                    if (b.Distansekjørt >= distanseKjørt)
                    {
                        tempListe.Add(b);
                    }
                }
            }
            billiste(tempListe);
            return tempListe;
        }

        public void KjøpBil(Bil bil, String navnKunde)
        {
            bil.Eier = navnKunde;
            Console.WriteLine("Takk for handelen!");
        }
    }
}
