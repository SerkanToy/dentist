using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace dentist.domain.Entities
{
    public class Role: IdentityRole<Guid>
    {
        [NotMapped]
        public ICollection<IdentityUserRole> IdentityUserRoles { get; set; }
    }
}
