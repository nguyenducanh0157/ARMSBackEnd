using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class AdmissionPlan
    {
        public int AdmissionPlanID { get; set; }
        public int TotalTarget { get; set; }
        public string? Prioritize { get; set; }
        public int? YearAdmission { get; set; }
        public string CampusId { get; set; }
        public virtual Campus? Campus { get; set; }
        public virtual ICollection<AdmissionTime>? AdmissionTimes { get; set; }
        public virtual ICollection<TypeOfDiploma>? TypeOfDiplomas { get; set; }
    }
}
