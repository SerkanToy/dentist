using dentist.domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace dentist.Persistence.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.IdentityUserRoles)
                .WithOne().HasForeignKey(x => x.UserId).IsRequired(false);
            builder.HasData(_data);
        }

        private List<Role> _data()
        {
            List<Role> role = new List<Role>
            {
                new Role
                {
                    Id = Guid.NewGuid(),
                    NormalizedName = "DEAN",
                    Name = "dean",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                },
                new Role
                {
                    Id = Guid.NewGuid(),
                    NormalizedName = "USER",
                    Name = "user",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                },
                new Role
                {
                    Id = Guid.NewGuid(),
                    NormalizedName = "DOCTOR",
                    Name = "doctor",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                },
                new Role
                {
                    Id = Guid.NewGuid(),
                    NormalizedName = "STUDENT",
                    Name = "student",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                }
            };
            return role;
        }
    }
}
