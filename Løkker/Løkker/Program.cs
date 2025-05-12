using System.Runtime.CompilerServices;

namespace Løkker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Jeg er kul!");
            }

            String setning = "Jeg er kul";

            foreach (var ord in setning)
            {
                Console.WriteLine(ord);
            }

            int runde = 1;

            while (runde < 10)
            {
                Console.WriteLine($"Runde nummer: {runde}.");
                runde++;
            }
        }
    }
}
