namespace ToDoList
{
    internal class OppgaveListe
    {
        public int ListeID;
        public List<Oppgave> Liste = new List<Oppgave>();
        public int AntallOppgaver = 0;
        public Oppgave toRemove;

        public void LeggTilOppgave(Oppgave nyOppgave)
        {
            Liste.Add(nyOppgave);
            AntallOppgaver++;
        }

        public void SlettOppgave(Oppgave oppgave)
        {
            Liste.Remove(oppgave);
        }

        public void SlettOppgave(int oppgaveID)
        {
            toRemove = null;
            bool suksess = false;
            foreach (Oppgave o in Liste)
            {
                if (o.OppgaveID == oppgaveID)
                {
                    toRemove = o;
                    suksess = true;
                }
            }
            if (suksess)
            {
                Liste.Remove(toRemove);
            }
        }

        public void VisOppgaver()
        {
            foreach (Oppgave o in Liste)
            {
                Console.Write("ID ");
                if (o.OppgaveID < 10) { Console.Write(" "); }
                Console.WriteLine(o.OppgaveID + ":               " + o.OppgaveNavn);
            }
        }

        public void VisDetaljer(int oppgaveID)
        {
            foreach (Oppgave o in Liste)
            {
                if (o.OppgaveID == oppgaveID)
                {
                    o.VisDetaljer();
                }
            }
        }

        public void VisDetaljer(Oppgave o)
        {
            //o.VisDetaljer();
            Console.WriteLine("Oppgavenavn: " + o.OppgaveNavn);
            Console.WriteLine("Oppgave ID:  " + o.OppgaveID);
            Console.WriteLine("Status:      " + o.Status);
            Console.WriteLine("Beskrivelse: " + o.Beskrivelse);
        }
    }
}
