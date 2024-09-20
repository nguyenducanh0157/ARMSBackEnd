using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class AdmissionTime
    {
        public int AdmissionTimeID { get; set; }
        public string AdmissionTimeName { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }

        public int AdmissionPlanID { get; set; }
        public virtual AdmissionPlan AdmissionPlan { get; set; }
    }
}
