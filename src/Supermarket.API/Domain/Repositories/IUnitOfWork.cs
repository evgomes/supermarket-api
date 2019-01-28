using System.Threading.Tasks;

namespace Supermarket.API.Domain.Repositories
{
    public interface IUnitOfWork
    {
         Task CompleteAsync();
    }
}