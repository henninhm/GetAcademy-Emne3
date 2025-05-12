using System;

namespace Krokodillespill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int poeng = 0;
            var p = new Program();

            p.Spill(poeng);
        }

        public void Spill(int poeng)
        {
            Console.WriteLine($"Antall poeng: {poeng}");
            var random = new Random();
            int i = random.Next(1, 12);
            int j = random.Next(1, 12);
            Console.WriteLine($"{i} _ {j}");

            var svar = Console.ReadLine();

            if (i<j) {
                if (svar == "<")
                {
                    poeng++;
                    Spill(poeng);
                }
                else if (svar == ">" || svar == "=")
                {
                    poeng--;
                    Spill(poeng);
                }
            } else if (i>j) {
                if (svar == ">")
                {
                    poeng++;
                    Spill(poeng);
                } 
                else if (svar == "<" || svar == "=")
                {
                    poeng--;
                    Spill(poeng);
                }
            } else {
                if (svar == "=")
                {
                    poeng++;
                    Spill(poeng);
                }
                else if (svar == "<" || svar == ">")
                {
                    poeng--;
                    Spill(poeng);
                }
            }
        }
    }
}
