namespace variabeltilordning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            Console.WriteLine(p.Summer(17, 32));
            p.ingenting();
        }

        public int Summer(int tall, int number)
        {
            var svar = tall + number;
            return svar;
        }

        public void ingenting()
        {
            Console.WriteLine("Denne metoden returnerer ingenting.");
            return;
        }
    }
}
