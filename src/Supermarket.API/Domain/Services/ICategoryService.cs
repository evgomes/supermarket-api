using System.Collections.Generic;
using System.Threading.Tasks;
using Supermarket.API.Domain.Models;
using Supermarket.API.Domain.Services.Communication;

namespace Supermarket.API.Domain.Services
{
    public interface ICategoryService
    {
         Task<IEnumerable<Category>> ListAsync();
         Task<SaveCategoryResponse> SaveAsync(Category category);
         Task<SaveCategoryResponse> UpdateAsync(int id, Category category);
    }
}