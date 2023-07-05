using Microsoft.Extensions.Caching.Memory;
using Supermarket.API.Domain.Repositories;
using Supermarket.API.Domain.Services;
using Supermarket.API.Domain.Services.Communication;
using Supermarket.API.Infrastructure;

namespace Supermarket.API.Services
{
	public class CategoryService : ICategoryService
	{
		private readonly ICategoryRepository _categoryRepository;
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMemoryCache _cache;
		private readonly ILogger<CategoryService> _logger;

		public CategoryService
		(
			ICategoryRepository categoryRepository,
			IUnitOfWork unitOfWork,
			IMemoryCache cache,
			ILogger<CategoryService> logger
		)
		{
			_categoryRepository = categoryRepository;
			_unitOfWork = unitOfWork;
			_cache = cache;
			_logger = logger;
		}

		public async Task<IEnumerable<Category>> ListAsync()
		{
			// Here I try to get the categories list from the memory cache. If there is no data in cache, the anonymous method will be
			// called, setting the cache to expire one minute ahead and returning the Task that lists the categories from the repository.
			var categories = await _cache.GetOrCreateAsync(CacheKeys.CategoriesList, (entry) =>
			{
				entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(1);
				return _categoryRepository.ListAsync();
			});

			return categories ?? new List<Category>();
		}

		public async Task<Response<Category>> SaveAsync(Category category)
		{
			try
			{
				await _categoryRepository.AddAsync(category);
				await _unitOfWork.CompleteAsync();

				return new Response<Category>(category);
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "Could not save category.");
				return new Response<Category>($"An error occurred when saving the category: {ex.Message}");
			}
		}

		public async Task<Response<Category>> UpdateAsync(int id, Category category)
		{
			var existingCategory = await _categoryRepository.FindByIdAsync(id);
			if (existingCategory == null)
			{
				return new Response<Category>("Category not found.");
			}

			existingCategory.Name = category.Name;

			try
			{
				await _unitOfWork.CompleteAsync();
				return new Response<Category>(existingCategory);
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "Could not update category with ID {id}.", id);
				return new Response<Category>($"An error occurred when updating the category: {ex.Message}");
			}
		}

		public async Task<Response<Category>> DeleteAsync(int id)
		{
			var existingCategory = await _categoryRepository.FindByIdAsync(id);
			if (existingCategory == null)
			{
				return new Response<Category>("Category not found.");
			}

			try
			{
				_categoryRepository.Remove(existingCategory);
				await _unitOfWork.CompleteAsync();

				return new Response<Category>(existingCategory);
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "Could not delete category with ID {id}.", id);
				return new Response<Category>($"An error occurred when deleting the category: {ex.Message}");
			}
		}
	}
}
