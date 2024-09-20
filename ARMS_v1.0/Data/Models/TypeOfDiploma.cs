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
        public int AdmissionPlanID { get; set; }
        public virtual AdmissionPlan AdmissionPlan { get; set; }
    }
}
