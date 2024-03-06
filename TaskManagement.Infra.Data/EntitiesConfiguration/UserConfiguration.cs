using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Domain.Entities;
using TaskManagement.Domain.Enums;

namespace TaskManagement.Infra.Data.EntitiesConfiguration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(hk => hk.Id);
            builder.Property(p => p.Name).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Email).HasMaxLength(100);
            builder.Property(p => p.Profile);
            builder.Property(p => p.CreateAt);
            builder.Property(p => p.UpdateAt);

            builder.HasMany(hm => hm.Projects);

            builder.HasData(new User(1, "Admin", "admin@gmail.com", DateTime.UtcNow, null));
        }
    }
}
