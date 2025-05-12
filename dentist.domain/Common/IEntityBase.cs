using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dentist.domain.Common
{
    public interface IEntityBase
    {
        Guid Id { get; set; }
        string Name { get; set; }        
        string CreatedBy { get; set; }
        DateTime CreatedDate { get; set; }
        string? UpdatedBy { get; set; }
        DateTime? UpdateDate { get; set; }
        string? DeleteBy { get; set; }
        DateTime? DeleteDate { get; set; }
        bool IsDeleted { get; set; }
    }
}
