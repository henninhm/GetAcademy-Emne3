namespace Administrasjon
{
    internal class Student
    {
        public string Navn;
        public int Alder;
        public string StudieProg;
        public int StudID;
        public List<Fag> Fag;
        public List<Karakter> Karakterer;
        public float Snitt;
        public int AntallFag;
        public int StudiePoeng;

        public Student(string navn, int alder, string studieProg, int studID)
        {
            Navn = navn;
            Alder = alder;
            StudieProg = studieProg;
            StudID = studID;
        }

        public void SkrivUtInfo()
        {
            Console.WriteLine("Student:        " + Navn);
            Console.WriteLine("Alder:          " + Alder);
            Console.WriteLine("StudieProgram:  " + StudieProg);
            Console.WriteLine("ID:             " + StudID);
            Console.WriteLine("-----------------------------");
        }

        public void SkrivUtKarakterer()
        {
            Console.WriteLine("Student: " + Navn);
            foreach (Karakter k in Karakterer)
            {
                Console.WriteLine($"Fagkode: {k.Fag.Fagkode}   Karakter: {k.Karakterverdi}");
            }
            Console.WriteLine("+++++++++++++++++++++++++++++++");
        }

        public float OppdaterSnitt()
        {
            foreach (var k in Karakterer)
            {
                Snitt += k.Karakterverdi;
                AntallFag++;
            }
            Snitt = Snitt / AntallFag;
            return Snitt;
        }

        public int OppdaterStudiePoeng()
        {
            StudiePoeng = 0;
            foreach (Fag f in Fag)
            {
                StudiePoeng += f.AntallStudiepoeng;
            }

            return StudiePoeng;
        }
    }
}
