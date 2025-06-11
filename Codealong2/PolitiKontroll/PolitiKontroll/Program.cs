namespace PolitiKontroll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bil bil1 = new Bil(false, true, true, 0, 58);
            Politi politi1 = new Politi();
            Politi politi2 = new Politi();
            Politi politi3 = new Politi();

            politi1.SjekkMobilOgbelte(bil1);
            politi2.SjekkFart(bil1);
            politi3.SjekkLappOgPromille(bil1);
        }
    }
}
