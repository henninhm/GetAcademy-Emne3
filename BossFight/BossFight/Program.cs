namespace BossFight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            GameCharacter player = new GameCharacter(180, 20, 40, true);
            GameCharacter boss = new GameCharacter(400, 0, 10);

            player.Fight(boss);
        }
    }
}
