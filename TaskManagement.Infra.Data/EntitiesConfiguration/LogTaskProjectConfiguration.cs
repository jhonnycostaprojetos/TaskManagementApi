using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManagement.Domain.Entities;

namespace TaskManagement.Infra.Data.EntitiesConfiguration
{
    public class LogTaskProjectConfiguration : IEntityTypeConfiguration<LogTaskProject>
    {
        public void Configure(EntityTypeBuilder<LogTaskProject> builder)
        {
            builder.HasKey(hk => hk.Id);
            builder.Property(p => p.Title);
            builder.Property(p => p.Description);
            builder.Property(p => p.DueDate);
            builder.Property(p => p.TaskComment);
            builder.Property(p => p.UserId);
            builder.Property(p => p.CreateAt);
            builder.Property(p => p.UpdateAt);
            builder.Property(p => p.UpdateAt);

        }
    }
}
