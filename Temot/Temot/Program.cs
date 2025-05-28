namespace Temot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.SkrivUt();
        }
        void SkrivUt(string melding = "Ingen melding")
        {
            Console.WriteLine(melding);
        }
    }
}
