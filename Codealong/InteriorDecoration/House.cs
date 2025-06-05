namespace InteriorDecoration
{
    internal class House
    {
        public List<Room> Rooms = new List<Room>();

        public void ViewHouse()
        {
            foreach (Room room in Rooms)
            {
                Console.Write(room.RoomName + ": ");
                Console.Write("");
            }
        }

        public void AddRoom(Room newRoom)
        {
            Rooms.Add(newRoom);
        }

        public void PaintRoom()
        {
            Room roomToPaint;
            Console.WriteLine("Which room do you want to paint?");
            foreach (Room room in Rooms)
            {
                Console.WriteLine("1. " + room.RoomName);
            }
            Console.WriteLine("Type the number for the room you would like to paint");
            var ans1 = Console.ReadLine();
            
            switch (ans1)
            {
                case "1":
                    Rooms[0].PaintRoom;
                    break;
            }
        }
    }
}
