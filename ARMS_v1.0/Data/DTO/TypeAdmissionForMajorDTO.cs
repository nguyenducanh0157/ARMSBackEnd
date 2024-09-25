using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO
{
    public class TypeAdmissionForMajorDTO
    {
        public int DiplomaId { get; set; }
        public string? ARId { get; set; }
        public virtual TypeOfDiplomaDTO TypeOfDiploma { get; set; }

        public virtual TypeAcademicRecordDTO? TypeAcademicRecord { get; set; }
    }
}
