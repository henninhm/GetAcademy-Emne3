using System.Globalization;

namespace FriendFace
{
    internal class User
    {
        public string Name;
        public string Username;
        public string Password;
        public List<User> Friends = new List<User>();
        public int Age;

        public User(string name, string username, string password)
        {
            Name = name;
            Username = username;
            Password = password;
        }

        public void AddFriend(User user)
        {
            Friends.Add(user);
        }
        public void RemoveFriend(User user)
        {
            Friends.Remove(user);
        }
    }
}
