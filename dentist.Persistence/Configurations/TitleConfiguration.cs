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
                    Name = "Bölüm Başkanı",
                },
                new Title
                {
                    Id = Guid.NewGuid(),
                    Name = "Profesör",
                },
                new Title
                {
                    Id = Guid.NewGuid(),
                    Name = "Doçent",
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
