using Microsoft.EntityFrameworkCore;
using TaskManagement.Infra.Data.Context;

namespace TaskManagement.Api.Services
{
    public static class DatabaseManagementService
    {

        public static void MigrationInitialisation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                serviceScope.ServiceProvider.GetService<ApplicationDbContext>().Database.Migrate();
            }
        }
    }
}
