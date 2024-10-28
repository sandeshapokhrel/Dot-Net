
using ProductAppApi.Models;
using ProductAppApi.Services;
using ProductAppApi.Repositories;

namespace ProductApi.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepo _userRepostiory;
        public UserService(IUserRepo userRepository)
        {
            _userRepostiory = userRepository;
        }

        public async Task<User> AuthenticateAsync(string username, string password)
        {
            return await _userRepostiory.AuthenticateAsync(username, password);
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await _userRepostiory.GetByIdAsync(id);
        }
    }
}
