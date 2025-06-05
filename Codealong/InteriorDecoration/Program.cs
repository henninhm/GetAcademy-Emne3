namespace InteriorDecoration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            House house1 = new House();

            Room bathroom = new Room("Bathroom", "White", true, true);
            Room bedroom = new Room("Bedroom", "light blue", false, false);
            Room office = new Room("Office", "Green", false, true);
            Room livingRoom = new Room("Living Room", "White", false, true);
            Room kitchen = new Room("Kitchen", "Light brown", true, false);
            Room entryway = new Room("Entryway", "Dark gray", true, true);

            house1.AddRoom(bathroom);
            house1.AddRoom(bedroom);                
            house1.AddRoom(office);
            house1.AddRoom(livingRoom);
            house1.AddRoom(kitchen);
            house1.AddRoom(entryway);


            Console.WriteLine("Welcome to the house decoration service. Which service do you want to use?");
            Console.WriteLine("1. Paint Room");
            Console.WriteLine("2. Add new door");
            Console.WriteLine("3. Add tiles");
            Console.WriteLine("4. Remove tiles");
            Console.WriteLine("5. Add new furniture");
            Console.WriteLine("Type the number for the service you would like to use");
            var ans1 = Console.ReadLine();

            switch (ans1)
            {
                case "1":
                    house1.PaintRoom();
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                default:
                    break;
            }
        }
    }
}


/*
 Du skal lage en app der du skal kunne dekorere huset ditt. Et hus har en del forskjellige rom man kan innrede eller dekorere. Brukeren skal få opp en meny der de skal kunne velge
Construction - (valg sett inn ny dør, sett inn nytt vindu, legg fliser),
Paint job,
Decorate (Sette inn potteplante, henge opp bilde),
View house,

Brukeren skal ha mulighet til å velge noe de vil gjøre, og deretter hvilken rom de vil fikse på. Når de velger "View house", så får de printet ut rommene og hvilken tilstand de er i.

"View house"-eksempel:

The house has 5 rooms: 
 
Bathroom: Wallcolor: White, Tiles: None, Door: Old door, Decoration Items: Potted plant
Bedroom:  Wallcolor: White, Tiles: None, Door: Old door,Decoration Items: Picture
Office: Wallcolor: Pink, Tiles: None,Door: Old door, Decoration Items: None
Kitchen: Wallcolor: White, Tiles: None, Door: New door, Decoration Items: None
Livingroom Wallcolor: Wallcolor: White, Tiles: None,Door: Old door, Decoration Items: None
 */