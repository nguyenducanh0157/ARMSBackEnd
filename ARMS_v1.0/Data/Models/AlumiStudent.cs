using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class AlumiStudent
    {
        public int AlumiStudentId { get; set; }
        public string FullName { get; set; }
        public string Desciption { get; set; }
        public string Img { get; set; }
        public string SpecializeMajorID { get; set; }
        public string CampusId { get; set; }
        public virtual Campus Campus { get; set; }
        public virtual SpecializeMajor SpecializeMajor { get; set; }

    }
}
