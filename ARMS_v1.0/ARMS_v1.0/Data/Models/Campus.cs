using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Campus
    {
        public string CampusId { get; set; }
        public string CampusName { get; set; }
        public virtual ICollection<Account>? Accounts { get; set; }
        public virtual ICollection<StudentProfile>? StudentProfiles { get; set; }
    }
}
