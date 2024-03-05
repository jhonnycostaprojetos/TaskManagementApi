using TaskManagement.Domain.Entities;

namespace TaskManagement.Domain.Interfaces
{
    public interface ITaskProjectRepository : IRepository<TaskProject>
    {
        Task<IEnumerable<TaskProject>> GetAll(int idProject);

        Task<TaskProject> InsertAsync(TaskProject item);

    }
}
