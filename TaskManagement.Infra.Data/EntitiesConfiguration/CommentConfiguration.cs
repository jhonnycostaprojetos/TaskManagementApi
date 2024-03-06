using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManagement.Domain.Entities;

namespace TaskManagement.Infra.Data.EntitiesConfiguration
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {

        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(hk => hk.Id);
            builder.Property(p => p.TaskComment).HasMaxLength(1000).HasColumnType("varchar(1000)");
            builder.Property(p => p.CreateAt);
            builder.Property(p => p.UpdateAt);

            builder.HasOne(ho => ho.TaskProject);

        }
    }
}

