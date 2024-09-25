using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class TypeOfDiploma
    {
        public int DiplomaId { get; set; }
        public string DiplomaName { get; set; }
        public virtual ICollection<TypeAcademicRecord>? TypeAcademicRecords { get; set; }
        public virtual ICollection<StudentProfile>? StudentProfiles { get; set; }
        public virtual ICollection<TypeAdmissionForMajor>? TypeAdmissionForMajors { get; set; }
    }
}
