using Microsoft.EntityFrameworkCore;
using TaskManagement.Domain.Entities;
using TaskManagement.Domain.Enums;
using TaskManagement.Domain.Interfaces;
using TaskManagement.Infra.Data.Context;
using TaskManagement.Infra.Data.Repositories;

namespace TaskManagement.Infra.Data.Implementations
{
    public class ReportImplementation : BaseRepository<User>, IReportRepository
    {
        private DbSet<User> _userdataset;

        public ReportImplementation(ApplicationDbContext context) : base(context)
        {
            _userdataset = context.Set<User>();
        }

        public async Task<object> Get(int idUser)
        {
            var user = _userdataset.FirstOrDefault(u => u.Id == idUser);

            if (user == null)
                return new { Message = "User not found!" };

            if (user.Profile != UserProfile.Manager)
                return new { Message = "User lacks permission to access this resource!" };


            DateTime dataLimite = DateTime.Now.AddDays(-30);

            return _userdataset.Include(u => u.Projects).ThenInclude(u => u.TaskProject.Where(t => t.Status == StatusTask.Concluded))
                   .GroupBy(t => t.Name)
                   .Select(g => new
                   {
                       User = g.Key,
                       AverageCompletedTasks = Math.Round(g.Count() / 30.0, 2)
                   })
                  .ToList();

        }
    }
}
