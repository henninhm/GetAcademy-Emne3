namespace UkjentKode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var range = 250;
            var counts = new int[range];
            int total = 0;
            string text = "something";
            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine();
                foreach (var character in text ?? string.Empty)
                {
                    int temp = (int)character;
                    if (temp > 96 && temp < 123)
                    {
                        temp = temp - 32;
                        counts[temp]++;
                    }
                    else
                    {
                        counts[(int)character]++;
                    } 
                }
                total += text.Length;
                for (var i = 0; i < range; i++)
                {
                    if (counts[i] > 0)
                    {
                        var character = (char)i;
                        double perc = (double)counts[i]*100/total;
                        perc = Math.Round(perc, 2);
                        string output = character + " - " + counts[i] + " - " + perc + "%";
                        Console.CursorLeft = Console.BufferWidth - output.Length - 1;
                        Console.WriteLine(output);
                    }
                }
            }
        }
    }
}
