using dentist.domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace dentist.Persistence.Configurations
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.HasKey(x => new { x.UserId, x.RoleId });
            /*builder.HasOne(x => x.User)
                .WithMany(y => y.UserRoles);
            builder.HasOne(x => x.Role)
                .WithMany(y => y.UserRoles);*/
            builder.ToTable("UserRole");
            builder.HasData(new UserRole
            {
                RoleId = 1,
                UserId = 1
            });
        }
    }
}
