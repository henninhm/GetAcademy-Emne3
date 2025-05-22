namespace Administrasjon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student en = new Student("Test Navn", 15, "testProg", 200);
            Student to = new Student("Navn Test", 16, "Glassblåsing", 201);

            en.SkrivUtInfo();
            to.SkrivUtInfo();

            Fag ehs = new Fag("Introduksjon til Etthjulssykkel", "EHS100", 10);
            Fag u2  = new Fag("How To Dismantle an Atomic Bomb", "U2-2004", 5);
            Fag sd  = new Fag("Safety Dance", "MWH1995", 10);
            Fag sm  = new Fag("Soul Mining", "TT1983", 10);
            Fag gb  = new Fag("Ghost Busting", "GB1984", 10);

            ehs.SkrivUtInfo();
            u2.SkrivUtInfo();

            Karakter testAB  = new Karakter(en, u2, 5);
            Karakter navnEHS = new Karakter(to, ehs, 6);

            testAB.SkrivUtInfo();
            navnEHS.SkrivUtInfo();
        }
    }
}
