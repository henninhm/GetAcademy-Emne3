namespace ParProg5
{
    public class WizardStore
    {

        public void Buying(Wizard buyer)
        {

            Console.WriteLine("""
                
                Choose one of the options to buy something:
                1. Rat
                2. Cat
                3. Owl
                4. Phoenix Wand
                5. Unicorn Wand
                6. Normal Wand

                """);
            var ans = Console.ReadLine();
            switch (ans)
            {
                case "1":
                    buyer.Inventory.Add("Rat");
                    Console.WriteLine($"You bought a Rat.\n");
                    break;
                case "2":
                    buyer.Inventory.Add("Cat");
                    Console.WriteLine($"You bought a Cat.\n");
                    break;
                case "3":
                    buyer.Inventory.Add("Owl");
                    Console.WriteLine($"You bought a Owl.\n");
                    break;
                case "4":
                    buyer.Inventory.Add("Phoenix Wand");
                    Console.WriteLine($"You bought a Phoenix Wand.\n");
                    break;
                case "5":
                    buyer.Inventory.Add("Unicorn Wand");
                    Console.WriteLine($"You bought a Unicorn Wand.\n");
                    break;
                case "6":
                    buyer.Inventory.Add("Normal Wand");
                    Console.WriteLine($"You bought a Normal Wand.\n");
                    break;
            }
        }
    }
}