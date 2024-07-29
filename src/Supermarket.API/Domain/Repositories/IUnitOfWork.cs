namespace Supermarket.API.Domain.Repositories
{
    public interface IUnitOfWork
    {
        IProductRepository ProductRepository { get; }
        ICategoryRepository CategoryRepository { get; }
         Task CompleteAsync();
    }
}