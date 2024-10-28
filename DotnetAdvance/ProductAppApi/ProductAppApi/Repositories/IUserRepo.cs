using ProductAppApi.Models;

namespace ProductAppApi.Repositories
{
    public interface IUserRepo
    {
        Task<User> AuthenticateAsync(string username, string password);
        Task<User> GetByIdAsync(int id);

    }
}
