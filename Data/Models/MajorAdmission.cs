using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class MajorAdmission
    {
        public int AdmissionInformationID { get; set; }
        public string MajorID { get; set; }
        public bool Status { get; set; }
        public int? Target { get; set; }
        public virtual Major? Major { get; set; }
        public virtual AdmissionInformation? AdmissionInformation { get; set; }
    }
}
