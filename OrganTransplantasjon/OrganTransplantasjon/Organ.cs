namespace OrganTransplantasjon
{
    internal class Organ
    {
        public string Navn;
        public string Status;
        public string Eier;

        public Organ(string navn, string status)
        {
            Navn = navn;
            Status = status;
        }
    }

}
