using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Major
    {

        public string MajorID { get; set; }
        public string MajorName { get; set; }
        public int? Target { get; set; }
        public string CampusId { get; set; }
        public virtual Campus Campus { get; set; }
        public virtual ICollection<SpecializeMajor> SpecializeMajors { get; set; }
        
    }
}
