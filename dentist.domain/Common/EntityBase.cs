using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dentist.domain.Common
{
    public class EntityBase: IEntityBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Flag { get; set; }
        public string CreatedBy { get; set; } = "Sistem";
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string? UpdatedBy { get; set; }
        public DateTime? UpdateDate { get; set; } = DateTime.Now;
        public string? DeleteBy { get; set; }
        public DateTime? DeleteDate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false;
    }
}
