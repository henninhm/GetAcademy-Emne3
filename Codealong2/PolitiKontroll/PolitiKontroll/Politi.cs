namespace PolitiKontroll
{
    internal class Politi
    {
        public void SjekkMobilOgbelte(Bil bil)
        {
            bool bot = false;
            int antBøter = 0;
            if (bil.Mobilbruk)
            {
                antBøter += 1;
                bot = true;
            }
            if (!bil.SetebeltePå)
            {
                antBøter += 1;
                bot = true;
            }
            if (bot)
            {
                Console.WriteLine("Må betale bot");
            } else
            {
                Console.WriteLine("Bare å kjøre videre.");
            }

        }

        public bool SjekkFart(Bil bil)
        {
            if (bil.Fart < 61)
            {
                Console.WriteLine("Bare å kjøre videre.");
                return false;
            } else if (bil.Fart > 81)
            {
                Console.WriteLine("Du må betale bot!");
                return false;
            } else
            {
                Console.WriteLine("Indratt førerkort");
                bil.GyldigFørerkort = false;
                return true;
            }
        }

        public void SjekkLappOgPromille(Bil bil)
        {
            if (!bil.GyldigFørerkort)
            {
                Console.WriteLine("Bot!");
            }
            if (bil.Alkoholprosent>0.02)
            {
                Console.WriteLine("Indratt førerkort");
                return;
            }
        }
    }
}
