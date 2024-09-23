using DemoMvcApp.Models;

namespace DemoMvcApp.Repositories
{


    public class UserRepository : IUserRepository
    {
        private List<User> _users = new List<User>
        {
          new User { Id = 1, Username = "admin", Password = "password", Role = "Admin" },
          new User { Id = 2, Username = "user", Password = "password", Role = "User" }
        };

        public User Authenticate(string username, string password)
        {
            return _users.FirstOrDefault(x => x.Username == username && x.Password == password);
        }

        public User GetById(int id)
        {
            return _users.FirstOrDefault(x => x.Id == id);
        }
    }
}
