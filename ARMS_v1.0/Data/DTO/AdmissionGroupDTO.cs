using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO
{
    public class AdmissionGroupDTO
    {
        public int AdmissionGroupId { get; set; }
        public string SubjectGroup { get; set; }
        public string SubjectGroupName { get; set; }
        public string Subject1 { get; set; }
        public string Subject2 { get; set; }
        public string Subject3 { get; set; }
    }
}
