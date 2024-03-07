using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManagement.Domain.Entities;

namespace TaskManagement.Infra.Data.EntitiesConfiguration
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasKey(hk => hk.Id);
            builder.Property(p => p.ProjectName).HasMaxLength(100).HasColumnType("varchar(100)").IsRequired();
            builder.Property(p => p.UserId);
            builder.Property(p => p.CreateAt);
            builder.Property(p => p.UpdateAt);

            builder.HasMany(ho => ho.TaskProject).WithOne(wo => wo.Project);

            builder.HasData(new Project(1, "Projeto do Banco Master", 1, null, null));
            builder.HasData(new Project(2, "Projeto Grupo Rede D’or", 1, null, null));
        }
    }
}
