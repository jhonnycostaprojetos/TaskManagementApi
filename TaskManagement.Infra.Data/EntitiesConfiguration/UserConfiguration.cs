using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Domain.Entities;

namespace TaskManagement.Infra.Data.EntitiesConfiguration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(p => p.Name).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Email).HasMaxLength(100);
            builder.Property(p => p.CreateAt);
            builder.Property(p => p.UpdateAt);


            builder.HasData(
                new User(Guid.NewGuid(), "Jhonny Costa123", "jhonnydscosta@gmail.com", null, DateTime.UtcNow),
                new User(Guid.NewGuid(), "Letica Costa1234", "leticia@gmail.com", null, DateTime.UtcNow)
                );
        }
    }
}
