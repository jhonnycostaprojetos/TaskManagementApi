using Microsoft.EntityFrameworkCore;
using TaskManagement.Domain.Entities;
using TaskManagement.Domain.Interfaces;
using TaskManagement.Infra.Data.Context;
using TaskManagement.Infra.Data.Repositories;

namespace TaskManagement.Infra.Data.Implementations
{
    public class CommentImplementation : BaseRepository<Comment>, ICommentRepository
    {
        private DbSet<Comment> _dataset;

        public CommentImplementation(ApplicationDbContext context) : base(context)
        {
            _dataset = context.Set<Comment>();
        }

        //public async Task<Comment> InsertAsync(Comment item)
        //{

            //int countTasks = _dataset.Where(i => i.IdTaskProject == item).Count();

            //if (countTasks <= 19)
            //{
            //    item.CreateAt = DateTime.UtcNow;
            //    _dataset.Add(item);

            //    await _context.SaveChangesAsync();
            //    return item;
            //}
            //else
            //{
            //    return new Comment("Maximum number of Tasks!");

          //  }
        //}
    }
}
