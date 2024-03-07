using TaskManagement.Domain.Entities;

namespace TaskManagement.Application.Interfaces
{
    public interface IReportService
    {
        Task<object> Get(int id);
        Task<IEnumerable<object>> GetAll();
    }
}
