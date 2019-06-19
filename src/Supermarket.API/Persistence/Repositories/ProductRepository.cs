using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Supermarket.API.Domain.Models;
using Supermarket.API.Domain.Repositories;
using Supermarket.API.Persistence.Contexts;

namespace Supermarket.API.Persistence.Repositories
{
    public class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context) { }

        public async Task<IEnumerable<Product>> ListAsync(int? categoryId)
        {
            var queryable = _context.Products
                                    .Include(p => p.Category)
                                    .AsNoTracking(); 
                                    
            // AsNoTracking tells EF Core it doesn't need to track changes on listed entities. Disabling entity
            // tracking makes the code a little faster

            if(categoryId.HasValue && categoryId > 0)
            {
                return await queryable.Where(p => p.CategoryId == categoryId)
                                      .ToListAsync();
            }

            return await queryable.ToListAsync();
        }

        public async Task<Product> FindByIdAsync(int id)
        {
            return await _context.Products
                                 .Include(p => p.Category)
                                 .FirstOrDefaultAsync(p => p.Id == id); // Since Include changes the method return, we can't use FindAsync
        }

        public async Task AddAsync(Product product)
        {
            await _context.Products.AddAsync(product);
        }

        public void Update(Product product)
        {
            _context.Products.Update(product);
        }

        public void Remove(Product product)
        {
            _context.Products.Remove(product);
        }
    }
}