using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class SpecializeMajor
    {
        public string SpecializeMajorID { get; set; }
        public string SpecializeMajorName { get; set; }
        public string MajorID { get; set; }
        public virtual Major Major { get; set; }
        public virtual ICollection<StudentConsultation>? StudentConsultations { get; set; }

    }
}
