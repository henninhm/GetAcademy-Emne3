namespace random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            p.RandomHobby();
            p.RandomHobby();
            p.RandomHobby();
        }

        public void RandomHobby()
        {
            var random = new Random();
            Console.WriteLine("Hvem vil få tildelt en hobby?");
            var navn = Console.ReadLine();
            var randNo = random.Next(0, 5);
            if (randNo == 0)
            {
                string hobby = "musikk";
                Console.WriteLine($"{navn} får hobbyen musikk. Å lytte, synge, " +
                    $"samle eller spille instrument kan {navn} velge selv.");
            }
            else if (randNo == 1)
            {
                string hobby = "spill";
                Console.WriteLine($"{navn} får hobbyen spill. Dataspill, brettspill, " +
                    $"puslespill, kortspill og mye mer. Alternativene er nesten uendelige, så " +
                    $"kanskje {navn} trenger et nytt program for å velge mer spesifikt.");
            }
            else if (randNo == 2)
            {
                string hobby = "film";
                Console.WriteLine($"{navn} får hobbyen film. Analysere eller lage selv? Eller " +
                $"kanskje bare se igjennom hundrevis av klassikere uten å tenke så mye over dem.");
            }
            else if (randNo == 3)
            {
                string hobby = "turer";
                Console.WriteLine($"{navn} får hobbyen turer i fjell og mark. En god kilde " +
                    $"til frisk luft og en frisk kropp. Håper {navn} har noen å gå tur med.");
            }
            else
            {
                string hobby = "kreativ";
                Console.WriteLine($"{navn} får en hobby hvor man lager noe kreativt. Hvilken? " +
                    $"Det er jo så mange å velge mellom! Male, skrive, annen kunst?");
                Console.WriteLine("For 50kr kan vi gi deg et nytt program som vil gi en mer spesifikk hobby.");
            }
        }
    }
}
