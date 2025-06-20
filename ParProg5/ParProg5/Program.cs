﻿namespace ParProg5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WizardStore wizardStore = new WizardStore();
            Wizard wizard = new Wizard("Harry", "Hufflepuff");
            Command();

            void Command()
            {
                Console.WriteLine("++++++++++++++++++++++++++++\n");
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("Do you want to go to STORE, PRINT info about your wizard," +
                    " look at the LIST of spells, or cast a spell?\n" +
                    "Write the word in bold for what you want to do.\n");
                var ans = Console.ReadLine();
                switch (ans)
                {
                    case "STORE":
                    case "store":
                        wizardStore.Buying(wizard);
                        break;
                    case "PRINT":
                    case "print":
                        wizard.PrintInfo();
                        break;
                    case "LIST":
                    case "list":
                        wizard.SpellList(); 
                        break;
                    case "vingardium leviosa":
                    case "Vingardium Leviosa":
                        Console.WriteLine("Du får en fjær til å fly!\n");
                        break;
                    case "hokus pokus":
                    case "Hokus Pokus":
                        Console.WriteLine("Du fyrer av fyrverkeri!\n");
                        break;

                }
                Command();
            }
        }
    }
}
// Harry Pottah🥳l33t haxx0r
//
// Du skal starte med å lage en harrypotter character klasse med egenskaper som navn, house, inventory (ex wand eller pet)
//
// Få applikasjonen til å printe ut en introduksjon for karakteren, som sier noe om hva de heter,
// hvilket hus de er medlem av og hvilke items de har

// Karakteren skal ha mulighet til å gå inn i en Magibutikk, der kan de kjøpe et dyr:
// ugle,rotte eller en katt. De har også mulighet til å kjøpe en tryllestav: føniksstav,
// unikornstav eller trollstav. For å få til dette må du lage en egen klasse som er butikken,
// og presentere brukeren med en meny for hva personen skal kjøpe.
//
// Karakteren skal ha mulighet til å trylle - ta inn input fra brukeren,
// og dersom en skriver en riktig trylleformel skal det printes til skjermen at de har utført tryllingen
// trylleformler: 
// vingardium leviosa (får en fjær til å fly)
// hokus pokus (fyrer av fyrverkerier)
