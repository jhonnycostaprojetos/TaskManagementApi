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
            try
            {
                return await _dataset.Include(i => i.Projects).SingleOrDefaultAsync(s => s.Id.Equals(id));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public async Task<IEnumerable<User>> GetAll()
        {
            try
            {
                return await _dataset.Include(c => c.Projects).ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }
    }
}
