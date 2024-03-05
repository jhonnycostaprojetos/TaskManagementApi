using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using TaskManagement.Domain.Entities;
using TaskManagement.Domain.Enums;
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

        public async Task<Project> SelectAsync(int userId)
        {
            return await _dataset.Include(i => i.TaskProject).SingleOrDefaultAsync(s => s.Id.Equals(userId));
        }

        public async Task<object> DeleteAsync(int id)
        {
            try
            {
                var filteredItems = _dataset.Where(i => i.Id == id && i.TaskProject.Any(x => x.Status == StatusTask.Pending || x.Status == StatusTask.Progress));

                if (!filteredItems.IsNullOrEmpty())
                {
                    return new { Message = "Deletion not allowed! Please complete or remove Project tasks : " + filteredItems.Select(x => "ID: " + x.Id + " Project Name: " + x.ProjectName).FirstOrDefault() };
                }
                else
                {
                    var result = await _dataset.SingleOrDefaultAsync(p => p.Id.Equals(id));

                    if (result == null)
                    {
                        return new { Message = "Not Found!" };
                    }

                    _dataset.Remove(result);
                    await _context.SaveChangesAsync();

                    return new { Message = "Sucess" };
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }

    }
}
