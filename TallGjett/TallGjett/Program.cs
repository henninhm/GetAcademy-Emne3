namespace TallGjett
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            var r = new Random();
            int target = r.Next(1, 101); 
            p.Gjett(target, 0);
        }

        public void Gjett(int target, int guess)
        {
            //Console.WriteLine("Test:" + target);
            if (guess == 0)
            {
                Console.WriteLine("Gjettelek. Prøv å finne tallet.");
                NyttTall(target);
            }
            else if (guess < target)
            {
                Console.WriteLine("For lavt. Prøv igjen.");
                NyttTall(target);
            }
            else if (guess > target) 
            {
                Console.WriteLine("For høyt. Prøv igjen.");
                NyttTall(target);
            }
            else
            {
                Console.WriteLine("Du fant tallet! \nVil du spille på nytt? Svar y eller n");
                var answer = Console.ReadLine();
                if (answer ==  "y" || answer == "Y" || answer == "Yes" || answer == "yes")
                {
                    var r = new Random();
                    Gjett(r.Next(1, 101), 0);
                }

            }

        }
        public void NyttTall(int target)
        {
            var newGuess = Console.ReadLine();
            bool tall = int.TryParse(newGuess, out int newGuessInt);
            if (tall)
            {
                Gjett(target, newGuessInt);
            } 
            else
            {
                Console.WriteLine("Skriv et tall");
                NyttTall(target);
            }

        }
    }
}
