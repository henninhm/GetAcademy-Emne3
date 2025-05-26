namespace OrganTransplantasjon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person Bernt = new Person("Bernt");
            Person Kåre = new Person("Kåre");

            Organ Nyre1 = new Organ("Nyre", "Sunn");
            Organ Nyre2 = new Organ("Nyre", "Sunn");

            Kåre.Organer.Add(Nyre1);
            Nyre1.Eier = "Kåre";
            Kåre.Organer.Add(Nyre2);
            Nyre2.Eier = "Kåre";

            Transplantasjon(Kåre, Bernt, "Nyre");
            Organ tp = Bernt.Organer[3];
            Console.WriteLine($"{tp.Eier} har nå en {tp.Status} {tp.Navn}.");
        }

        static void Transplantasjon(Person fra, Person til, string organNavn)
        {
            bool suksess = false;
            var nyre = fra.TaUtOrgan(organNavn);
            if (nyre == null) { Console.WriteLine("Organ transplantasjon feilet"); }
            else
            {
                suksess = til.PuttInnOrgan(nyre);
                if (suksess)
                {
                    Console.WriteLine("Organ transplantasjon var en suksess!");
                }
                else
                {
                    Console.WriteLine("Organ transplantasjon feilet");
                }
            }
        }
    }
}
