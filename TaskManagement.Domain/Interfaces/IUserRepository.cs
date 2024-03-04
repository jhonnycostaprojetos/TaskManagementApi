using TaskManagement.Domain.Entities;

namespace TaskManagement.Domain.Interfaces
{
    public interface IUserRepository : IRepository<User> 
    {
        Task<IEnumerable<User>> GetAll();
        Task<User> Get(int id);
    }
}
