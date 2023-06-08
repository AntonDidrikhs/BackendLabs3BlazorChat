using System.Collections;
using System.Collections.Generic;

namespace L23_Lab3_BlazorChat
{
    public interface IUserService
    {
        public void Add(string connectionId, string username);
        public void RemovebyName(string username);

    }
    public class UserService : IUserService
    {
        public class User
        {
            public User(string connectionId, string username)
            {
                this.ConnectionId = connectionId;
                this.Username = username;
            }
            public string ConnectionId;
            public string Username;
        }
        List<User> _users = new List<User>();

        public void Add(string connectionId, string username)
        {
            User nUser = new User(connectionId, username);
            _users.Add(nUser);
        }

        public void RemovebyName(string username)
        {
            User RemUser = _users.Find(x => x.Username == username);
            _users.Remove(RemUser);
        }
        public string GetConnectionIdByName(string username)
        {
            return _users.Find(x => x.Username == username).ConnectionId;
            
        }
        public IEnumerable<User> GetAll()
        {
            return (IEnumerable<User>)_users;
        }
    }
}
