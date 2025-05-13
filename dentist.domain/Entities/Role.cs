using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace dentist.domain.Entities
{
    public class Role: IdentityRole<int>
    {
        [NotMapped]
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
