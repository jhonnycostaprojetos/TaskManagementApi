using TaskManagement.Domain.Entities;

namespace TaskManagement.Domain.Interfaces
{
    public interface IProjectRepository : IRepository<Project>
    {
        Task<Project> SelectAsync(int idprojectt);
    }
}
