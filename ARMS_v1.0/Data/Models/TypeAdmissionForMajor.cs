using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class TypeAdmissionForMajor
    {
        public int DiplomaId { get; set; }
        public string SpecializeMajorID { get; set; }
        public string? ARId { get; set; }
        public virtual TypeOfDiploma TypeOfDiploma { get; set; }
        public virtual SpecializeMajor SpecializeMajor { get; set; }

        public virtual TypeAcademicRecord? TypeAcademicRecord { get; set; }
    }
}
