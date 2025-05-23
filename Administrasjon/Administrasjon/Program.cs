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

            Fag ehs = new Fag("Introduksjon til Etthjulssykkel", " EHS100", 10);
            Fag u2  = new Fag("How To Dismantle an Atomic Bomb", "U2-2004", 5);
            Fag sd  = new Fag("Safety Dance", "MWH1995", 10);
            Fag sm  = new Fag("Soul Mining", " TT1983", 10);
            Fag gb  = new Fag("Ghost Busting", " GB1984", 10);

            ehs.SkrivUtInfo();
            u2.SkrivUtInfo();

            List<Fag> fagliste = new List<Fag>();
            fagliste.Add(ehs);
            fagliste.Add(u2);
            fagliste.Add(sd);
            fagliste.Add(sm);
            fagliste.Add(gb);

            en.Fag = fagliste;
            to.Fag = fagliste;

            Karakter testAB = new Karakter(en, u2, 5);
            Karakter navnEHS = new Karakter(to, ehs, 6);

            List <Karakter> karEn = new List<Karakter>
            {new Karakter(en, u2, 5),
            new Karakter(en, ehs, 3),
            new Karakter(en, sd, 6),
            new Karakter(en, sm, 4),
            new Karakter(en, gb, 5) };

            testAB.SkrivUtInfo();
            navnEHS.SkrivUtInfo();

            en.Karakterer = karEn;
            en.SkrivUtKarakterer();

            List<Karakter> karTo = new List<Karakter> {
            new Karakter(to, ehs, 6),
            new Karakter(to, u2, 2),
            new Karakter(to, sd, 3),
            new Karakter(to, sm, 6),
            new Karakter(to, gb, 5) };

            to.Karakterer = karTo;
            to.SkrivUtKarakterer();

            Console.WriteLine(en.OppdaterSnitt());
            Console.WriteLine(to.OppdaterSnitt());

            Console.WriteLine(en.OppdaterStudiePoeng());
        }
    }
}
