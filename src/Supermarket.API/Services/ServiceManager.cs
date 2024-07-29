using Microsoft.Extensions.Caching.Memory;
using Supermarket.API.Domain.Repositories;
using Supermarket.API.Domain.Services;

namespace Supermarket.API.Services
{
    public class ServiceManager(
        IUnitOfWork unitOfWork,  
        IMemoryCache cache, 
        ILogger<ProductService> loggerProduct, 
        ILogger<CategoryService> loggerCategory) : IServiceManager
    {
        private readonly IUnitOfWork _unitOfWork= unitOfWork;
        private readonly IMemoryCache _cache= cache;
        private readonly ILogger<ProductService> _logger=loggerProduct;
        private readonly ILogger<CategoryService> _loggerCategory=loggerCategory;

        private readonly Lazy<IProductService> _productService = new Lazy<IProductService>(() => new ProductService(unitOfWork, cache, loggerProduct));
        private readonly Lazy<ICategoryService> _categoryService= new Lazy<ICategoryService>(() => new CategoryService(unitOfWork, cache,loggerCategory));

        public IProductService ProductService => _productService.Value;

        public ICategoryService CategoryService => _categoryService.Value;
    }
}
