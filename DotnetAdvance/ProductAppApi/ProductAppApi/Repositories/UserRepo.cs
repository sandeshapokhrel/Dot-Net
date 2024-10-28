using ProductAppApi.Models;
using Microsoft.EntityFrameworkCore;
using ProductAppApi.Data;

namespace ProductAppApi.Repositories
{
    public class UserRepo : IUserRepo
    {
        private readonly DemoDbContext _context;

        public UserRepo(DemoDbContext context)
        {
            _context = context;
        }

        public async Task<User> AuthenticateAsync(string username, string password)
        {
            // Use _context.Users to access the Users DbSet
            return await _context.Users.FirstOrDefaultAsync(x => x.Username == username && x.Password == password);
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
