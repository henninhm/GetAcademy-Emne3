namespace ToDoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool kjører = true;
            OppgaveListe opgListe = new OppgaveListe();
            List<Oppgave> oppgaver = new List<Oppgave>();

            Console.WriteLine("Velkommen til ToDo-List");

            while (kjører)
            {
                Console.WriteLine("---------------------");
                Console.WriteLine($"Velg en handling:");
                Console.WriteLine($"1. Legge til oppgave");
                Console.WriteLine($"2. Slett oppgave");
                Console.WriteLine($"3. Vis alle oppgave");
                Console.WriteLine($"4. Vis detalljer");

                Console.WriteLine("Ditt valg:");
                string valg = Console.ReadLine();

                switch (valg)
                {
                    case "1":
                        LeggTilOppgave(opgListe);
                        break;
                    case "2":
                        SlettOppgave(opgListe);
                        break;
                    case "3":
                        VisOppgaver(opgListe);
                        break;
                    case "4":
                        VisDetaljer(opgListe);
                        break;
                    case "5":
                        kjører = false;
                        break;
                    default:
                        Console.WriteLine("Ugyldig valg.");
                        break;
                }
            }

        }
        static void LeggTilOppgave(OppgaveListe liste)
        {
            Console.WriteLine("Tittel på oppgaven:");
            string tittel = Console.ReadLine();
            Console.WriteLine("Beskrivelse:");
            string beskrivelse = Console.ReadLine();

            int id = liste.AntallOppgaver + 1;
            Oppgave ny = new Oppgave(id, tittel, beskrivelse);
            liste.LeggTilOppgave(ny);
            //oppgaver.Add(ny);
            
            Console.WriteLine("Oppgave lagt til.");
        }
        static void SlettOppgave(OppgaveListe liste)
        {
            //VisAlleOppgaver();
            Console.WriteLine("--------------------");
            liste.VisOppgaver();
            //Console.WriteLine("Hvilken oppgave vil du slette?");
            //bool suksess;
            //suksess = int.TryParse(Console.ReadLine(), out int indeks);
            if (liste.Liste.Count == 0)
            {
                Console.WriteLine("Det finnes ingen oppgaver å slette.");
                return;
            }
            Console.WriteLine("Skriv nummeret på oppgaven du vil slette (1, 2, 3...): ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int indeks))
            {
                liste.SlettOppgave(indeks);
            }
        }
        static void VisOppgaver(OppgaveListe liste)
        {
            Console.WriteLine("---------------------");
            if(liste.Liste.Count == 0)
            {
                Console.WriteLine("Ingen oppgaver.");
                return;
            }
            Console.WriteLine("Opppgaveliste:");
            for (int i=0; i<liste.Liste.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{liste.Liste[i].OppgaveNavn}");
            }
        }
        static void VisDetaljer(OppgaveListe liste)
        {
            Console.WriteLine("Hvlken oppgave vil du se detaljer for?");
            if(int.TryParse(Console.ReadLine(), out int indeks) && indeks>0 && indeks<= liste.Liste.Count )
            {
                Oppgave valgt = liste.Liste[indeks-1];
                Console.WriteLine("-----------------------------");
                Console.WriteLine($"Tittel:      {valgt.OppgaveNavn}");
                Console.WriteLine($"Beskrivelse: {valgt.Beskrivelse}");
            }else
            {
                Console.WriteLine("Ugyldig nummer");
            }
        }
    }
}
