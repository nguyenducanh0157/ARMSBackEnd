using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class StudentConsultation
    {
        public int SCId { get; set; }
        public string FullName { get; set;}
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string LinkFB { get; set; }
        public bool Status { get; set; }
        public DateTime DateReceive { get; set; }
        public DateTime? ProcessDate { get; set; }
        
        //FK
        public string CampusId { get; set; }
        public string SpecializeMajorID { get; set; }
        public Guid? UserID { get; set; }
        public virtual Campus Campus { get; set; }
        public virtual SpecializeMajor SpecializeMajor { get; set; }
        public virtual Account? Account { get; set; }
    }
}
