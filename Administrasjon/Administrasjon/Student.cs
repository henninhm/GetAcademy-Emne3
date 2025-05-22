namespace Administrasjon
{
    internal class Student
    {
        public string Navn;
        public int Alder;
        public string StudieProg;
        public int StudID;

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
    }

}
