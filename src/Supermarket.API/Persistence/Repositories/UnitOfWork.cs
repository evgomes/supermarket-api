using Supermarket.API.Domain.Repositories;
using Supermarket.API.Persistence.Contexts;

namespace Supermarket.API.Persistence.Repositories
{
    public class UnitOfWork(AppDbContext context) : IUnitOfWork
    {
        private readonly AppDbContext _context = context;
        private readonly Lazy<IProductRepository> _productRepository= new Lazy<IProductRepository>(() => new ProductRepository(context));
        private readonly Lazy<ICategoryRepository> _categoryRepository= new Lazy<ICategoryRepository>(() => new CategoryRepository(context));


        public IProductRepository ProductRepository => _productRepository.Value;
        public ICategoryRepository CategoryRepository => _categoryRepository.Value;

        public async Task CompleteAsync() => await _context.SaveChangesAsync();
    }
}