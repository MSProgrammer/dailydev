using Supermarket.API.Domain.Persistance.Contexts;

namespace server.Persistance.Repositories
{
    public abstract class BaseRepository
    {
        protected readonly AppDbContext _context;
        public BaseRepository(AppDbContext context)
        {
            _context = context
        }
    }
}