using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class TypeAcademicRecord
    {
        public string ARId { get; set; }
        public string ARName { get; set; }
        public int DiplomaId { get; set; }
        public virtual TypeOfDiploma TypeOfDiploma { get; set; }
        public virtual ICollection<StudentProfile>? StudentProfiles { get; set; }
        public virtual ICollection<TypeAdmissionForMajor>? TypeAdmissionForMajors { get; set; }
    }
}
