namespace InteriorDecoration
{
    internal class Room
    {
        public string RoomName;
        public string Color;
        public bool Tiles;
        public bool NewDoor;
        public List<string> Furniture = new List<string>();

        public Room(string roomname, string color, bool tiles, bool newDoor)
        {
            RoomName = roomname;
            Color = color;
            Tiles = tiles;
            NewDoor = newDoor;
        }

        public void AddFurniture(string furniture)
        {
            Furniture.Add(furniture);
        }

        public void PaintRoom(string color)
        {
            Color = color;
        }

        public void ChangeTiles(bool tiles)
        {
            Tiles = tiles;
        }

        public void AddNewDoor()
        {
            NewDoor = true;
        }
    }
}
