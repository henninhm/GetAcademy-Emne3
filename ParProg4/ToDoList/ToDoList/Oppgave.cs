namespace ToDoList
{
    internal class Oppgave
    {
        public int OppgaveID;
        public string OppgaveNavn;
        public string Beskrivelse;
        public string Status;

        public Oppgave(int oppgaveID, string oppgaveNavn, string beskrivelse)
        {
            OppgaveID = oppgaveID;
            OppgaveNavn = oppgaveNavn;
            Beskrivelse = beskrivelse;
        }

        public void OppdaterBeskrivelse(string beskrivelse)
        {
            Beskrivelse = beskrivelse;
        }

        public void OppdaterStatus(string status)
        {
            Status = status;
        }

        public void VisDetaljer()
        {
            Console.WriteLine("Oppgavenavn: " + OppgaveNavn);
            Console.WriteLine("Oppgave ID:  " + OppgaveID);
            Console.WriteLine("Status:      " + Status);
            Console.WriteLine("Beskrivelse: " + Beskrivelse);
        }
    }
}
