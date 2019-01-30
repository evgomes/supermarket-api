using System.Collections.Generic;
using System.Threading.Tasks;
using Supermarket.API.Domain.Models;

namespace Supermarket.API.Domain.Repositories
{
    public interface ICategoryRepository
    {
         Task<IEnumerable<Category>> ListAsync();
         Task<Category> FindByIdAsync(int id);
         Task AddAsync(Category category);
         void Update(Category category);
    }
}