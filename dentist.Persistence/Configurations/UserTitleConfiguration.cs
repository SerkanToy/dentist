using dentist.domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace dentist.Persistence.Configurations
{
    public class UserTitleConfiguration : IEntityTypeConfiguration<UserTitle>
    {
        public void Configure(EntityTypeBuilder<UserTitle> builder)
        {
            builder.HasKey(x => new { x.UserId, x.TitleId });
            builder.HasOne(x => x.User).WithMany(y => y.UserTitle).HasForeignKey(x => x.UserId).IsRequired(false);
            builder.HasData(new UserTitle
            {
                TitleId = 8,
                UserId = 1,
            });
        }
    }
}
