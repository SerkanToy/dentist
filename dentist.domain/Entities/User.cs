using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace dentist.domain.Entities
{
    public class User : IdentityUser<int>
    {
        public User()
        {
            CreatedBy = "Sistem";
            CreatedDate = DateTime.Now;
            IsDeleted = false;
        }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? DeleteBy { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<UserTitle>? UserTitle { get; set; }
        [NotMapped]
        public ICollection<UserRole>? UserRoles { get; set; }
    }
}
