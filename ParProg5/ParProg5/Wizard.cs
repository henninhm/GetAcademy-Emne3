namespace ParProg5
{
    public class Wizard
    {
        public List<string> Inventory = new List<string>();
        public string Name { get; private set; }
        public string House { get; private set; }

        public Wizard(string name, string house)
        {
            Name = name;
            House = house;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"""
                --------------------------
                Wizard name: {Name}
                House:       {House}
                """);
            PrintInventory();
            Console.WriteLine("--------------------------\n");
        }

        public void PrintInventory()
        {
            bool first = true;
            foreach (string item in Inventory)
            {
                if (first)
                {
                    Console.WriteLine("Inventory:   " + item);
                    first = false;
                } else
                {
                    Console.WriteLine("             " + item);
                }
            }
        }

        public void SpellList()
        {
            Console.WriteLine("""
                *****
                Your list of spells:
                Vingardium Leviosa
                Hokus Pokus
                *****
                Write them out in the main menu to cast them.

                """);
        }
    }
}
