using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManagement.Domain.Entities;
using TaskManagement.Domain.Enums;

namespace TaskManagement.Infra.Data.EntitiesConfiguration
{
    public class TaskProjectConfiguration : IEntityTypeConfiguration<TaskProject>
    {
        public void Configure(EntityTypeBuilder<TaskProject> builder)
        {
            builder.HasKey(hk => hk.Id);
            builder.Property(p => p.ProjectId);
            builder.Property(p => p.Title).HasMaxLength(100).HasColumnType("varchar(100)");
            builder.Property(p => p.Description).HasMaxLength(1000).HasColumnType("varchar(1000)");
            builder.Property(p => p.DueDate);
            builder.Property(p => p.Status);
            builder.Property(p => p.Priority);
            builder.Property(p => p.CreateAt);
            builder.Property(p => p.UpdateAt);

            builder.HasOne(ho => ho.Project);
            builder.HasMany(hm => hm.Comments);

            builder.HasData(new TaskProject(1, 1, "Levantamento de Requisitos", "Detalhar cada ponto importante do projeto", DateTime.Now, null, null));
            builder.HasData(new TaskProject(2, 2, "Levantamento de Requisitos", "Detalhar cada ponto importante do projeto", DateTime.Now, null, null));
        }

    }
}
