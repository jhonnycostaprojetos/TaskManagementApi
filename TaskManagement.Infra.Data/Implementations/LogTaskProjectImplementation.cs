using Microsoft.EntityFrameworkCore;
using TaskManagement.Domain.Entities;
using TaskManagement.Domain.Interfaces;
using TaskManagement.Infra.Data.Context;
using TaskManagement.Infra.Data.Repositories;

namespace TaskManagement.Infra.Data.Implementations
{
    public class LogTaskProjectImplementation : BaseRepository<LogTaskProject>, ILogTaskProjectRepository
    {
        private DbSet<LogTaskProject> _dataset;

        public LogTaskProjectImplementation(ApplicationDbContext context) : base(context)
        {
            _dataset = context.Set<LogTaskProject>();
        }
    }
}
