using dentist.domain.Common;
using Microsoft.AspNetCore.Identity;

namespace dentist.domain.Entities
{
    public class User : IdentityUser<Guid>, IEntityBase
    {
        public User()
        {
            Id = Guid.NewGuid();
            CreatedBy = "Sistem";
            CreatedDate = DateTime.Now;
            IsDeleted = false;
        }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Flag { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? DeleteBy { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
