using Microsoft.EntityFrameworkCore;
using TaskManagement.Domain.Entities;
using TaskManagement.Domain.Interfaces;
using TaskManagement.Infra.Data.Context;
using TaskManagement.Infra.Data.Repositories;

namespace TaskManagement.Infra.Data.Implementations
{
    public class TaskProjectImplemantion : BaseRepository<TaskProject>, ITaskProjectRepository
    {
        private DbSet<TaskProject> _dataset;

        public TaskProjectImplemantion(ApplicationDbContext context) : base(context)
        {
            _dataset = context.Set<TaskProject>();
        }

        public async Task<IEnumerable<TaskProject>> GetAll(int idProject)
        {
            return await _dataset.Include(c => c.Project).ThenInclude(t => t.TaskProject).ThenInclude(t => t.Comments).Where(w => w.ProjectId == idProject).ToListAsync();
        }

        public async Task<TaskProject> InsertAsync(TaskProject item)
        {

            int countTasks = _dataset.Where(i => i.ProjectId == item.ProjectId).Count();

            if (countTasks <= 19)
            {
                item.CreateAt = DateTime.UtcNow;
                _dataset.Add(item);

                await _context.SaveChangesAsync();
                return item;
            }
            else
            {
                return new TaskProject("Maximum number of Tasks!");

            }
        }
    }
}
