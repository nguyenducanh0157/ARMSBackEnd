using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO
{
    public class AlumiStudentDTO
    {
        public int AlumiStudentId { get; set; }
        public string FullName { get; set; }
        public string Desciption { get; set; }
        public string Img { get; set; }
        public string CampusName { get; set; }
        public string SpecializeMajorName { get; set; }
    }
}
