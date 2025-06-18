namespace ButikkOversikt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            List<Butikk> Butikker = new List<Butikk>();
            Butikker.AddRange(new List<Butikk>
            {
                new Butikk("Klær", 2, "Klær 1"),
                new Butikk("Dagligvarer", 1, "Dagligvarer 1"),
                new Butikk("Klær", 2, "Klær 2"),
                new Butikk("Vin", 2, "Vinmonopolet"),
                new Butikk("Dagligvarer", 3, "Dagligvarer 2"),
                new Butikk("Leker", 3, "Leker 1"),
                new Butikk("Musikk og film", 2, "Platekompaniet"),
                new Butikk("Klær", 1, "Klær 3"),
                new Butikk("Dagligvarer", 1, "Dagligvarer 3"),
                new Butikk("Leker", 2, "Leker 2"),
                new Butikk("Dagligvarer", 2, "Dagligvarer 4"),
                new Butikk("Klær", 3, "Klær 4"),
                new Butikk("Dagligvarer", 2, "Dagligvarer 5"),
                new Butikk("Musikk og film", 2, "Musikk og greier"),
                new Butikk("Dagligvarer", 2, "Dagligvarer 6"),
                new Butikk("Klær", 3, "Klær 5"),
            });

            p.Command(Butikker);
        }

        public void Command(List<Butikk> butikker)
        {
            Console.WriteLine("""
                Velkommen til butikk-oversikt.
                Hva vil du gjøre?
                1. Se liste over alle butikker?
                2. Søke etter en spesifikk type butikk?
                3. Legge til en ny butikk?
                """);
            var ans = Console.ReadLine();

            switch (ans)
            {
                case "1":
                    foreach(var item in butikker)
                    {
                        Console.WriteLine(item.Navn);
                    }
                    break;
                case "2":
                    Søk(butikker);
                    break;
                case "3":
                    NyButikk(butikker);
                    break;
            }
        }

        public void Søk(List<Butikk> butikker)
        {
            List<Butikk> temp = new List<Butikk>();
            Console.WriteLine("""
                Hva vil du søke etter?
                1. Type butikk
                2. Prisklasse
                3. Begge
                """);
            var ans = Console.ReadLine();

            switch (ans)
            {
                case "1":
                    TypeSøk(butikker);
                    break;
            }
        }

        public void TypeSøk(List<Butikk> butikker)
        {
            Console.WriteLine("Hvilken type butikk er du ute etter?");
            var ans = Console.ReadLine();
            foreach (var item in butikker)
            {
                if (item.Spesialitet == ans)
                {

                }
            }
        }

        public void NyButikk(List<Butikk> butikker)
        {
            Console.WriteLine("Hva skal butikken hete?");
            var navn = Console.ReadLine();
            Console.WriteLine("Hva skal butikken selge?");
            var type = Console.ReadLine();
            Console.WriteLine("Skal butikken være billig (1), middels (2), eller dyr (3)?");
            var prisKlasse = Console.ReadLine();
            int klasse;
            bool suksess = int.TryParse(prisKlasse, out klasse);
            Butikk ny = new Butikk(type, klasse, navn);
            butikker.Add(ny);
        }
    }
}


/*
Butikkoversikt

Denne appen skal gi en oversikt over hvilke butikker som finnes, hva som er spesialiteten deres
(klær, matvarer, leker etc) og prisnivået varene ligger på (1= billig 2=midt på treet 3=sinnsykt dyrt)
Man skal også kunne legge til nye butikker, og få mulighet til å velge å se en liste over alle butikker,
velge å se kun de billigste, velge å se kun de som er midt på treet prismessig eller velge å se bare de 
butikkene som er rangert som sinnsykt dyre.

BONUS
Gjør så man også kan sortere/velge å se butikker som har en viss spesialitet f.eks klær i tillegg til 
å kunne sortere på pris. Kjekt å se hvor man kan kjøpe billig mat og dyre designer klær, hehe

*/