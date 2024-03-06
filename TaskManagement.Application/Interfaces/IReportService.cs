namespace TaskManagement.Application.Interfaces
{
    public interface IReportService
    {
        Task<object> Get(int id);
    }
}
