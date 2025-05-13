using dentist.domain.Common;
using System.Reflection;

namespace dentist.domain.Entities
{
    public class Title : IEntityBase
    {
        public Title()
        {
            CreatedBy = "Sistem";
            CreatedDate = DateTime.Now;
            IsDeleted = false;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? DeleteBy { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<UserTitle>? UserTitle { get; set; }
    }
}
