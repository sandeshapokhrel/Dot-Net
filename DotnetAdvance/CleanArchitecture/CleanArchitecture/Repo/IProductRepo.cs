using CleanArchitecture.Entities;

namespace CleanArchitecture.Repo
{
    public interface IProductRepo
    {
        Task<Product> GetByIdAsync(int id);
        Task<IEnumerable<Product>> GetAllAsync();
        Task AddAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(int id);
    }
}