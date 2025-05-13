using dentist.domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace dentist.Persistence.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(x => x.Id);
            //builder.HasMany(x => x.UserRoles).WithOne(y => y.Role);
            builder.ToTable("Role");
            builder.HasData(new[]
                {
                    new Role
                    {
                        Id = 1,
                        NormalizedName = "ADMIN",
                        Name = "admin",
                        ConcurrencyStamp = Guid.NewGuid().ToString()
                    },
                    new Role
                    {
                        Id = 2,
                        NormalizedName = "USER",
                        Name = "user",
                        ConcurrencyStamp = Guid.NewGuid().ToString()
                    }
                });
        }
    }
}
