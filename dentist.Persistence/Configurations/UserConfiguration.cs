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
            builder.HasMany(x => x.IdentityUserRoles).WithOne().HasForeignKey(x => x.UserId).IsRequired(false);
            builder.HasMany(x => x.UserTitle).WithOne(y => y.User).HasForeignKey(x => x.UserId).IsRequired(false);
            builder.HasData(_data);
        }

        private User _data()
        {
            User user = new User
            {
                Id = Guid.NewGuid(),
                Name = "Serkan",
                SurName = "TOY",
                Email = "stoy@windowslive.com",
                NormalizedEmail = "SRKNTY86@GMAIL.COM",
                PhoneNumber = "0522 698 56 98",
                UserName = "stoy",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                SecurityStamp = Guid.NewGuid().ToString(),
                NormalizedUserName = "STOY",
                PasswordHash = ""
            };
            user.PasswordHash = CreatePasswordHash(user,"Qwe123");
            return user;
        }

        private string CreatePasswordHash(User user, string password)
        {
            var passwordHash = new PasswordHasher<User>();
            return passwordHash.HashPassword(user, password);
        }
    }
}
