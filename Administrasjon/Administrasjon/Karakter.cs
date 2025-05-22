namespace Administrasjon
{
    internal class Karakter
    {
        public Student Student;
        public Fag Fag;
        public int Karakterverdi;

        public Karakter(Student student, Fag fag, int karakterverdi)
        {
            Student = student;
            Fag = fag;
            Karakterverdi = karakterverdi;
        }

        public void SkrivUtInfo()
        {
            Console.WriteLine("Student:  " + Student.Navn);
            Console.WriteLine("Fagkode   " + Fag.Fagkode);
            Console.WriteLine("Karakter: " + Karakterverdi);
            Console.WriteLine("<><><><><><><><><><>");
        }
    }
}
