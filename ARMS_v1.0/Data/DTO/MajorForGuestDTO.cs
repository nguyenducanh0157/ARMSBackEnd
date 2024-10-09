using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO
{
    public class MajorForGuestDTO
    {
        public string MajorID { get; set; }
        public string MajorCode { get; set; }
        public string MajorName { get; set; }
        public string? Description { get; set; }
        public int? Target { get; set; }
        public string? TimeStudy { get; set; }
        public virtual ICollection<SubjectDTO>? Subjects { get; set; }
        public virtual ICollection<TypeAdmissionDTO>? TypeAdmissions { get; set; }
    }
}
