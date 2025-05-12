using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dentist.domain.Entities
{
    public class UserTitle
    {
        public UserTitle()
        {
            StartDate = DateTime.Now;
        }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Guid TitleId { get; set; }
        public Title Title { get; set; }
        public DateTime StartDate { get; set; }
    }
}
