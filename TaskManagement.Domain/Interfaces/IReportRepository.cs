namespace TaskManagement.Domain.Interfaces
{
    public interface IReportRepository /*: IRepository<Comment>*/
    {
        Task<object> Get(int idUser);
    }
}
