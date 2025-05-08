namespace ifelse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            p.Like();
            p.Tall(p.a, p.b);
            p.Tall(p.a, p.c);
            Console.WriteLine(p.Tretti(p.a, p.b));
            Console.WriteLine(p.Tretti(30, 21));
            Console.WriteLine(p.Tretti(331, 30));
            Console.WriteLine(p.Tretti(12, 18));
        }

        int a = 3;
        int b = 4;
        int c = 3;
        
        public void Like()
        {
            if (a == b)
            {
                Console.WriteLine("a og b er like!");
            }
            else
            {
                Console.WriteLine("a og b er ikke Like!");
            }
            if (a == c)
            {
                Console.WriteLine("a og c er like!");
            }
            else
            {
                Console.WriteLine("a og c er ikke Like!");
            }
        }

        public void Tall(int i, int j)
        {
            if (i == j)
            {
                Console.WriteLine(i * j);
            }
            else
            {
                Console.WriteLine(i + j);
            }
        }

        public bool Tretti(int i, int j)
        {
            if(i == 30 || j == 30 || i+j == 30) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
