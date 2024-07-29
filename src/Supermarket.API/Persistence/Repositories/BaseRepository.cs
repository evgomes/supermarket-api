using Supermarket.API.Persistence.Contexts;

namespace Supermarket.API.Persistence.Repositories
{
    public abstract class BaseRepository(AppDbContext context)
    {
        protected readonly AppDbContext _context = context;
    }
}