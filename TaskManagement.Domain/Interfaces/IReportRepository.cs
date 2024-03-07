using TaskManagement.Domain.Entities;

namespace TaskManagement.Domain.Interfaces
{
    public interface IReportRepository
    {
        Task<object> Get(int idUser);
    }
}
