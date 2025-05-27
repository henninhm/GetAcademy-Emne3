using System.ComponentModel;

namespace FriendFace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.allUsers.Add(p.loggedIn);
            p.loggedIn.Friends.Add(p.allUsers[4]);
            p.CommandMenu();
        }

        public User loggedIn = new User("Ola Nordmann", "OlaN", "1814");
        public List<User> allUsers = new List<User>
        {
            new User("Test1", "en", ""),
            new User("Test2", "to", ""),
            new User("Test3", "tre", ""),
            new User("Test4", "fire", ""),
            new User("Test5", "fem", ""),
            new User("Test6", "seks", ""),
            new User("Test7", "sju", ""),
            new User("Test8", "åtte", ""),
            new User("Test9", "ni", ""),
        };



        public void CommandMenu()
        {
            Console.WriteLine("Logged in as " + loggedIn.Name + ".");
            Console.WriteLine("What do you want to do?:\n" +
                "1. Add friend\n" +
                "2. Remove friend\n" +
                "3. Print out a list of friends\n" +
                "4. Look at a friend's profile information\n" +
                "Enter the desired number");
            var ans1 = Console.ReadLine();

            if (ans1 == "1")
            {
                AddFriend();
            }
            if (ans1 == "2")
            {
                RemoveFriend();
            }
            if (ans1 == "3")
            {
                PrintFriendList();
            }
        }

        public void AddFriend()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Who would you like to add as a friend?");
            List<User> pf = new List<User>();
            int listLength = 0;
            foreach (User ff in allUsers)
            {
                bool alreadyFriend = false;
                if (ff.Username == loggedIn.Username) { alreadyFriend = true; break; }

                foreach (User f in loggedIn.Friends)
                {
                    if (ff.Username == f.Username) { alreadyFriend = true; break; }
                }
                if (!alreadyFriend)
                {
                    pf.Add(ff);
                    listLength++;
                    Console.WriteLine(listLength + ": " + ff.Name);
                }
            }
            Console.WriteLine("Enter the desired number");
            var ans2 = Console.ReadLine();
            int fno;
            bool success = int.TryParse(ans2, out fno);
            if (success)
            {
                loggedIn.AddFriend(pf[fno - 1]);
                Console.WriteLine("Friend successfully added.\n" +
                    "Type 1 to go add more friends, or" +
                    " type 2 to get back to the main menu.");
                var ans3 = Console.ReadLine();
                if (ans3 == "1") { AddFriend(); }
                else if (ans3 == "2") { CommandMenu(); }
            }
            else
            {
                Console.WriteLine("Error. Invalid answer");
                CommandMenu();
            }
        }

        public void RemoveFriend()
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Info here!");
            int listNo = 0;
            foreach (User f in loggedIn.Friends)
            {
                listNo++;
                Console.WriteLine(listNo +": " + f.Name);
            }
            Console.WriteLine("Enter the number of the friend you want to remove,\n" +
                "or X to return to the menu");
            var ans4 = Console.ReadLine();
            if (ans4 == "x" || ans4 == "X") { CommandMenu(); }
            else
            {
                int fno;
                bool success = int.TryParse(ans4, out fno);
                loggedIn.RemoveFriend(loggedIn.Friends[fno-1]);
                RemoveFriend();
            }
        }

        public void PrintFriendList()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine(loggedIn.Name + "'s list of friends:");
            foreach (User f in loggedIn.Friends)
            {
                Console.WriteLine(f.Name);
            }
            Console.WriteLine("--------------------------------------");
            CommandMenu();
        }
    }
}
