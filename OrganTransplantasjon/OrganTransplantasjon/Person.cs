namespace OrganTransplantasjon
{
    internal class Person
    {
        public string Navn;
        public List<Organ> Organer = new List<Organ> {
        new Organ("Hjerte", "Sunn" ),
        new Organ("Lunge", "Sunn" ),
        new Organ("Lunge", "Sunn" ),
        };

        public Person(string navn)
        {
            Navn = navn;
        }


        public Organ TaUtOrgan(string organNavn)
        {
            Random r = new Random();
            int overlever = r.Next(0,500);
            Console.WriteLine(overlever);
            int antallOrganer = 0;

            foreach (Organ organ in Organer)
            {
                if (organ.Navn == "Nyre")
                {
                    antallOrganer++;
                    if (antallOrganer == 2)
                    {
                        if (overlever > 0)
                        {
                            Organer.Remove(organ);
                            Console.WriteLine("Fjerner " + organ.Navn +
                                " fra donor " + Navn + ".");
                            organ.Eier = "";
                            return organ;
                        }
                        else
                        {
                            Console.WriteLine("Operasjon vas mislykket." +
                                " Donor eller organ ble alvorlig skadet");
                            return null;
                        }
                    }
                }
            }
            Console.WriteLine($"Donor {Navn} har ikke nok {organNavn}r");
            return null;
        }

        public bool PuttInnOrgan(Organ donert)
        {
            Random r = new Random();
            int overlever = r.Next(0, 50);
            Console.WriteLine(overlever);

            if (overlever > 0)
            {
                Organer.Add(donert);
                Console.WriteLine(donert.Navn + " har blitt transplantert inn i "
                    + Navn + ".");
                donert.Eier = Navn;
                return true;
            }
            else
            {
                Console.WriteLine("Operasjon feilet. Pasient døde.");
                return false;
            }
        }
    }
}
