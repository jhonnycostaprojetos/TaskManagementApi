using Microsoft.EntityFrameworkCore;
using TaskManagement.Domain.Entities;
using TaskManagement.Domain.Interfaces;
using TaskManagement.Infra.Data.Context;
using TaskManagement.Infra.Data.Repositories;

namespace TaskManagement.Infra.Data.Implementations
{
    public class UserImplementation : BaseRepository<User>, IUserRepository
    {
        private DbSet<User> _dataset;

        public UserImplementation(ApplicationDbContext context) : base(context)
        {
            _dataset = context.Set<User>();
        }
        public async Task<User> Get(int id)
        {
            return await _dataset.Include(i => i.Projects).SingleOrDefaultAsync(s => s.Id.Equals(id));
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await _dataset.Include(c => c.Projects).ToListAsync();

        }
    }
}
