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
    }
}
