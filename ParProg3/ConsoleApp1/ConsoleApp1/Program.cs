namespace Bilforhandler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Bil> Biler = new List<Bil>();
            Bil Bullmeister = new Bil("bmw", 2018, "DK102030", 56000, "forhandler");
            Bil Opel = new Bil("opel", 2018, "DK102030", 56000, "forhandler");
            Bil ToyotaCarola = new Bil("toyota", 2018, "DK102030", 56000, "forhandler");
            Bil Ferrarri = new Bil("ferrari", 2018, "DK102030", 56000, "forhandler");
            Biler.Add(Bullmeister);
        }

        public void billiste(List<Bil> biler)
        {
            foreach (var b in biler)
            {

            }
        }
    }
}
