using TaskManagement.Domain.Entities;

namespace TaskManagement.Domain.Interfaces
{
    public interface ICommentRepository :  IRepository<Comment>
    {
       // Task<Comment> InsertAsync(Comment item);
    }
}
