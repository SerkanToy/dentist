using dentist.domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace dentist.Persistence.Configurations
{
    public class UserTokenConfiguration : IEntityTypeConfiguration<UserToken>
    {
        public void Configure(EntityTypeBuilder<UserToken> builder)
        {
            // Composite primary key consisting of the UserId, LoginProvider and Name
            builder.HasKey(t => new { t.UserId, t.LoginProvider, t.Name });

            // Limit the size of the composite key columns due to common DB restrictions
            builder.Property(t => t.LoginProvider);
            builder.Property(t => t.Name);

            // Maps to the AspNetUserTokens table
            builder.ToTable("UserToken");
        }
    }
}
