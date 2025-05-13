using dentist.domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace dentist.Persistence.Configurations
{
    public class TitleConfiguration : IEntityTypeConfiguration<Title>
    {
        public void Configure(EntityTypeBuilder<Title> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.UserTitle).WithOne(y => y.Title).HasForeignKey(x => x.UserId).IsRequired(false);
            builder.HasData(new[]
            {
                new Title
                {
                    Id = 1,
                    Name = "Dekan",
                },
                new Title
                {
                    Id = 2,
                    Name = "Dekan Yardımcısı",
                },
                new Title
                {
                    Id = 3,
                    Name = "Bölüm Başkanı",
                },
                new Title
                {
                    Id = 4,
                    Name = "Profesör",
                },
                new Title
                {
                    Id = 5,
                    Name = "Doçent",
                },
                new Title
                {
                    Id = 6,
                    Name = "Doktor",
                },
                new Title
                {
                    Id = 7,
                    Name = "Araştırma Görevlisi",
                }
                ,
                new Title
                {
                    Id = 8,
                    Name = "Yazılımcı",
                }
            });
        }
    }
}
