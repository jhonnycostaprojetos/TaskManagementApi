using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManagement.Domain.Entities;

namespace TaskManagement.Infra.Data.EntitiesConfiguration
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(p => p.ProjectName).HasMaxLength(100).HasColumnType("varchar(100)").IsRequired();
            builder.Property(u => u.UserId);            
            builder.Property(p => p.CreateAt);
            builder.Property(p => p.UpdateAt);

            builder.HasOne(p => p.User);
            builder.HasMany(p => p.TaskProject).WithOne(s => s.Project);

            builder.HasData(new Project(1,"Projeto",1, null, null));
        }
    }
}
