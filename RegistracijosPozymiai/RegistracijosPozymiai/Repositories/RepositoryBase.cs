using Microsoft.EntityFrameworkCore;
using RegistracijosPozymiai.Data;

namespace RegistracijosPozymiai.Repositories
{
    public abstract class RepositoryBase<T> where T: class
    {
        protected DataContext _context;
        private DbSet<T> _dbSet;

        protected RepositoryBase(DataContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
    }
}
