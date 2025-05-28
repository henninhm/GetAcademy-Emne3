namespace BossFight
{
    internal class GameCharacter
    {
        public int Health;
        private int Strength;
        private int Stamina;
        private bool Player;
        private int turn = 0;

        public GameCharacter(int health, int strength, int stamina, bool player = false)
        {
            Health = health;
            Strength = strength;
            Stamina = stamina;
            Player = player;
        }

        public void Fight(GameCharacter enemy)
        {
            if (Stamina >= 10)
            {
                turn++;
                if (!Player)
                {
                    var r = new Random();
                    Strength = r.Next(0, 31);
                    enemy.Health -= Strength;
                    Console.WriteLine(
                        $"Turn {turn}: Boss attacks player and deals {Strength} damage." +
                        $"\n You have {enemy.Health} health left.");

                } else {
                    enemy.Health -= Strength;
                    Console.WriteLine(
                        $"Turn {turn}: Player attacks boss and deals {Strength} damage." +
                        $"\n The boss has {enemy.Health} health left.");
                }                
                Stamina -= 10;
                if (enemy.Health < 1)
                {
                    if (!Player)
                    {
                        Console.WriteLine("You have been defeated. Game Over!");
                    } else {
                        Console.WriteLine("You have defeated the boss! Victory!");
                    }
                } else
                {
                    enemy.Fight(this);
                }
            }
            else
            {
                Recharge(enemy);
            }

        }

        public void Recharge(GameCharacter enemy)
        {
            turn++;
            if (Player)
            {
                Stamina = 40;
                Console.WriteLine($"Turn {turn}: Player recharging.");
            }
            else 
            { 
                Stamina = 10;
                Console.WriteLine($"Turn {turn}: Boss recharging.");
            }
            enemy.Fight(this);
        }
    }
}
