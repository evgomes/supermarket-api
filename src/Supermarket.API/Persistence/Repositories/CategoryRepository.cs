using Microsoft.EntityFrameworkCore;
using Supermarket.API.Domain.Repositories;
using Supermarket.API.Persistence.Contexts;

namespace Supermarket.API.Persistence.Repositories
{
    public class CategoryRepository(AppDbContext context) : BaseRepository(context), ICategoryRepository
    {

        // "AsNoTracking" tells Entity Framework that it is not necessary to track changes for listed entities. This makes code run faster.
        public async Task<IEnumerable<Category>> ListAsync()
            => await _context.Categories.AsNoTracking().ToListAsync();

        public async Task AddAsync(Category category)
            => await _context.Categories.AddAsync(category);

        public async Task<Category?> FindByIdAsync(int id)
            => await _context.Categories.FindAsync(id);

        public void Update(Category category)
        {
            _context.Categories.Update(category);
        }

        public void Remove(Category category)
        {
            _context.Categories.Remove(category);
        }
    }
}