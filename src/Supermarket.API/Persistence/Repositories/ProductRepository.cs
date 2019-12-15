using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Supermarket.API.Domain.Models;
using Supermarket.API.Domain.Models.Queries;
using Supermarket.API.Domain.Repositories;
using Supermarket.API.Persistence.Contexts;

namespace Supermarket.API.Persistence.Repositories
{
	public class ProductRepository : BaseRepository, IProductRepository
	{
		public ProductRepository(AppDbContext context) : base(context) { }

		public async Task<QueryResult<Product>> ListAsync(ProductsQuery query)
		{
			IQueryable<Product> queryable = _context.Products
													.Include(p => p.Category)
													.AsNoTracking();

			// AsNoTracking tells EF Core it doesn't need to track changes on listed entities. Disabling entity
			// tracking makes the code a little faster
			if (query.CategoryId.HasValue && query.CategoryId > 0)
			{
				queryable = queryable.Where(p => p.CategoryId == query.CategoryId);
			}

			// Here I count all items present in the database for the given query, to return as part of the pagination data.
			int totalItems = await queryable.CountAsync();

			// Here I apply a simple calculation to skip a given number of items, according to the current page and amount of items per page,
			// and them I return only the amount of desired items. The methods "Skip" and "Take" do the trick here.
			List<Product> products = await queryable.Skip((query.Page - 1) * query.ItemsPerPage)
													.Take(query.ItemsPerPage)
													.ToListAsync();

			// Finally I return a query result, containing all items and the amount of items in the database (necessary for client-side calculations ).
			return new QueryResult<Product>
			{
				Items = products,
				TotalItems = totalItems,
			};
		}

		public async Task<Product> FindByIdAsync(int id)
		{
			return await _context.Products
								 .Include(p => p.Category)
								 .FirstOrDefaultAsync(p => p.Id == id); // Since Include changes the method's return type, we can't use FindAsync
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