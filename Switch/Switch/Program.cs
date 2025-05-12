using System.Xml.Linq;

namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            p.Ukedag(3);
            p.Ukedag(5);
            p.Ukedag(6);
            p.LesUkedag();
        }
        public void Ukedag(int dag)
        {
            switch (dag)
            {
                case 1:
                    Console.WriteLine("Det er mandag.");
                    break;
                case 2:
                    Console.WriteLine("Det er tirsdag.");
                    break;
                case 3:
                    Console.WriteLine("Det er onsdag.");
                    break;
                case 4:
                    Console.WriteLine("Det er torsdag.");
                    break;
                case 5:
                    Console.WriteLine("Det er fredag! Endelig helg!");
                    break;
                case 6:
                    Console.WriteLine("Det er lørdag.");
                    break;
                case 7:
                    Console.WriteLine("Det er søndag.");
                    break;
                default:
                    Console.WriteLine("Skriv et nytt tall mellom 1 og 7.");
                    LesUkedag();
                    break;
            }
        }

        public void LesUkedag()
        {
            Console.WriteLine("Hvor mange dager inn i uka har vi kommet?");

            var dag = Console.ReadLine();
            bool tall = int.TryParse(dag, out int i);
            
            switch (tall)
            {
                case true:
                    Ukedag(i);
                    break;
                case false:
                    Console.WriteLine("Skriv inn et tall!");
                    LesUkedag();
                    break;
            }
        }
    }
}
