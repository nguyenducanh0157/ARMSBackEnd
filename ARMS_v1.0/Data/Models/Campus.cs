using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Campus
    {
        public string CampusId { get; set; }
        public string CampusName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string? History { get; set; }
        public string? TrainingMotto { get; set; }
        public string? Achievements { get; set; }
        public string? WhyChooseUs { get; set; }
        public int? IntroduceId { get; set; }
        public int? AdmissionPlanID { get; set; }
        public virtual ICollection<Major>? Majors { get; set; }
        public virtual ICollection<BlogCategory>? BlogCategorys { get; set; }
        public virtual ICollection<Account>? Accounts { get; set; }
        public virtual ICollection<StudentProfile>? StudentProfiles { get; set; }
        public virtual ICollection<StudentConsultation>? StudentConsultations { get; set; }
        public virtual ICollection<Banner>? Banners { get; set; }
        public virtual ICollection<AlumiStudent>? AlumiStudents { get; set; }
        public virtual AdmissionPlan? AdmissionPlan { get; set; }
    }
}
