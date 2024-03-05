using Microsoft.EntityFrameworkCore;
using TaskManagement.Domain.Entities;
using TaskManagement.Domain.Enums;
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

        public async Task<TaskProject> UpdateAsync(TaskProject taskProject)
        {
            var tarefa = _dataset.FirstOrDefault(t => t.Id == taskProject.Id);
            if (tarefa != null)
            {
                // Armazene os valores anteriores
                string? tituloAnterior = tarefa.Title;
                string? descricaoAnterior = tarefa.Description;
                TaskStatus? statusAnterior = (TaskStatus?)tarefa.Status;
                DateTime? dueDateAnterior = tarefa.DueDate;

                tarefa.Title = !string.IsNullOrWhiteSpace(taskProject.Title) ? taskProject.Title : tarefa.Title;
                tarefa.Description = !string.IsNullOrWhiteSpace(taskProject.Description) ? taskProject.Description : tarefa.Description;
                tarefa.Status = taskProject.Status ?? tarefa.Status;
                tarefa.Priority = taskProject.Priority ?? tarefa.Priority;
                tarefa.DueDate = taskProject.DueDate ?? tarefa.DueDate;
                tarefa.UpdateAt = DateTime.Now;

                await _context.SaveChangesAsync();

                return taskProject;
            }
            else
            {
                return null;

            }
        }
    }
}
