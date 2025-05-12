namespace Teksttukling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            Console.WriteLine("Choose program:");
            Console.WriteLine("1. Reverse Text");
            Console.WriteLine("2. Change word \n");

            var prog = Console.ReadLine();

            if (prog == "1") {
                p.ReverseText();
            } else if (prog == "2") {
                p.ChangeWord();
            } else { Console.WriteLine("Invalid answer!");}
        }

        public void ReverseText()
        {
            Console.WriteLine("Type in the word you want to reverse:");
            string word = Console.ReadLine();
            for (int i = word.Length-1; i>=0; i--)
            {
                Console.Write(word[i]);
            } 
        }

        public void ChangeWord()
        {
            Console.WriteLine("Type in the word you want to change:");
            string word = Console.ReadLine();
            foreach (char c in word)
            {
                if (c == 'e')
                {
                    Console.Write('a');
                }
                else
                {
                    Console.Write(c);
                }
            }
        }


    }
}
