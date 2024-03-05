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

        //public async Task<object> InsertAsync(LogTaskProject item)
        //{
        //    var tarefa = _dataset.FirstOrDefault(t => t.TaskProjectId == item.TaskProjectId);
        //    if (tarefa != null)
        //    {
        //        // Armazene os valores anteriores
        //        string? tituloAnterior = tarefa.Title;
        //        string? descricaoAnterior = tarefa.Description;
        //        int? statusAnterior = tarefa.Status;
        //        DateTime? dueDateAnterior = tarefa.DueDate;

        //        // Atualize apenas os campos não nulos/brancos
        //        if (!string.IsNullOrWhiteSpace(item.Title))
        //            tarefa.Title = item.Title;

        //        if (!string.IsNullOrWhiteSpace(item.Description))
        //            tarefa.Description = item.Description;

        //        if (item.Status.HasValue)
        //            tarefa.Status = item.Status;

        //        if (item.DueDate.HasValue)
        //            tarefa.DueDate = item.DueDate;

        //         await _context.SaveChangesAsync();

        //        return item;
        //    }
        //    else
        //    {
        //        return null;
                
        //    }
        //}
    }
}
