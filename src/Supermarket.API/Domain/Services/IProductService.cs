using Supermarket.API.Domain.Services.Communication;

namespace Supermarket.API.Domain.Services
{
	public interface IProductService
	{
		Task<QueryResult<Product>> ListAsync(ProductsQuery query);
		Task<Response<Product>> SaveAsync(Product product);
		Task<Response<Product>> UpdateAsync(int id, Product product);
		Task<Response<Product>> DeleteAsync(int id);
	}
}