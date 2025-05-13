using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace dentist.domain.Entities
{
    public class UserRole: IdentityUserRole<int>
    {
        [NotMapped]
        public User? User { get; set; }
        [NotMapped]
        public Role? Role { get; set; }
        public bool Expired { get; set; }
    }
    
}
