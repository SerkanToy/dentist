using dentist.domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace dentist.Persistence.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            //builder.HasMany(x => x.UserRoles).WithOne(y => y.User);
            builder.HasMany(x => x.UserTitle).WithOne(y => y.User);
            builder.ToTable("User");

            User user = new User
            {
                Id = 1,
                Name = "Serkan",
                SurName = "TOY",
                Email = "stoy@windowslive.com",
                NormalizedEmail = "STOY@WINDOWSLIVE.COM",
                PhoneNumber = "0522 698 56 98",
                UserName = "stoy",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                SecurityStamp = Guid.NewGuid().ToString(),
                NormalizedUserName = "STOY"
            };
            user.PasswordHash = CreatePasswordHash(user, "Qwe123");

            builder.HasData(user);

            

        }

        private string CreatePasswordHash(User user, string password)
        {
            var passwordHash = new PasswordHasher<User>();
            return passwordHash.HashPassword(user, password);
        }
    }
}
