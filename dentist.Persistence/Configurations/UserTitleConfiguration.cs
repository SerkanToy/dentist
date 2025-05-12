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
            builder.HasData(_data);
        }

        private List<Title> _data()
        {
            List<Title> title = new List<Title>
            {
                new Title
                {
                    Id = Guid.NewGuid(),
                    Name = "Dekan",
                },
                new Title
                {
                    Id = Guid.NewGuid(),
                    Name = "Dekan Yardımcısı",
                },
                new Title
                {
                    Id = Guid.NewGuid(),
                    Name = "Profesör",
                },
                new Title
                {
                    Id = Guid.NewGuid(),
                    Name = "Doktor",
                },
                new Title
                {
                    Id = Guid.NewGuid(),
                    Name = "Araştırma Görevlisi",
                }
            };
            return title;
        }
    }
}
