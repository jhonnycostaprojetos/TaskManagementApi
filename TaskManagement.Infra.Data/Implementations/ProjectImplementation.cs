using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Domain.Entities;
using TaskManagement.Domain.Interfaces;
using TaskManagement.Infra.Data.Context;
using TaskManagement.Infra.Data.Repositories;

namespace TaskManagement.Infra.Data.Implementations
{
    public class ProjectImplementation : BaseRepository<Project>, IProjectRepository
    {
        private DbSet<Project> _dataset;

        public ProjectImplementation(ApplicationDbContext context) : base(context)
        {
            _dataset = context.Set<Project>();
        }

        public async Task<Project> SelectAsync(int idproject)
        {
           return await _dataset.Include(i => i.User)
                                 .SingleOrDefaultAsync(s => s.Id.Equals(idproject));
        }
    }
}
