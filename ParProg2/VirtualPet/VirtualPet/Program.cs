namespace Virutal_Pet
{
    internal class VirutuelPokémon
    {
        private string navn;
        private int alder;
        private int sultNivå;
        private int kosNivå;
        private int doNivå;
        private bool shiny;

        public VirutuelPokémon(string navn, int alder, int sultnivå = 10, int kosnivå = 5, int donivå = 6)
        {
            this.navn = navn;
            this.alder = alder;
            this.sultNivå = sultnivå; //1-20
            this.kosNivå = kosnivå;
            this.doNivå = donivå; //1-10?
        }

        public void GiMat()
        {
            if (sultNivå <= 9)
            {
                Console.WriteLine($"{navn} er sulten. Vil du gi mat?");
                string svar = Console.ReadLine();
                if (svar == "ja" || svar == "Ja")
                {
                    sultNivå += 10;
                    Console.WriteLine($"{navn} ser god og mett ut.");
                    kosNivå += 2;
                    doNivå -= 2;
                }

            }
            else if (sultNivå >= 10)
            {
                Console.WriteLine($"{navn} er mett og fornøyd");
            }

        }

        public void KosMed()
        {
            kosNivå += 3;
            doNivå -= 1;
            sultNivå -= 2;
            Console.WriteLine($"{navn} koser seg godt");
        }

        public void SjekkDo()
        {
            if (doNivå <= 3)
            {
                Console.WriteLine($"{navn} må veldig på toalettet! Vil du gå tur?");
                string svar = Console.ReadLine();
                if (svar == "ja" || svar == "Ja")
                {
                    sultNivå -= 3;
                    Console.WriteLine($"{navn} gjør fra ser på turen.");
                    kosNivå -= 1;
                    doNivå = 10;
                }

            }
            else
            {
                Console.WriteLine($"{navn} føler ikke for å gå på toalettet!");
            }
        }

        public void MenyForPokémon()
        {
            Console.WriteLine($" 1. Gi {navn} mat!");
            Console.WriteLine($" 2. Kos med {navn}!");
            Console.WriteLine($" 3. Sjekk om {navn} må på toalettet!");
            Console.WriteLine($" 4. Avslutt");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Du har 3 Pokémon: Pikachu, Mudkip og Charmander");
            Console.WriteLine("Hvilken pokémon vil du ta vare på?");
            string navn = Console.ReadLine();

            VirutuelPokémon p1 = new VirutuelPokémon("Pikachu", 1);
            VirutuelPokémon p2 = new VirutuelPokémon("Mudkip", 3, 2);
            VirutuelPokémon p3 = new VirutuelPokémon("Charmander", 3, 2, 0, 2);
            VirutuelPokémon pokémon;
            bool avslutt = false;

            while (!avslutt)
            {
                if (navn == "Pikachu") { pokémon = p1; }
                else if (navn == "Mudkip") { pokémon = p2; }
                else if (navn == "Charmander") { pokémon = p3; }
                else
                {
                    break;
                }
                pokémon.MenyForPokémon();
                string valg = Console.ReadLine();

                switch (valg)
                {
                    case "1":
                        pokémon.GiMat();
                        break;

                    case "2":
                        pokémon.KosMed();
                        break;

                    case "3":
                        pokémon.SjekkDo();
                        break;

                    case "4":
                        avslutt = true;
                        Console.WriteLine("Avslutter denne økten! Ha en forsatt fin dag videre!");
                        break;

                    default:
                        Console.WriteLine("Hva er det du har skrevet? Prøv deg på nytt");
                        break;
                }
            }
        }
    }
}
