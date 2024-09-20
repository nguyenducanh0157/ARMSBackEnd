using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class StudentProfile
    {
        public int Id { get; set; }
        public string? StudentCode { get; set; }
        public string Fullname { get; set; }
        public DateTime? Dob { get; set; }
        public bool? Gender { get; set; }
        public string? Nation { get; set; }
        public string? CitizenIentificationNumber { get; set; }
        public DateTime? CIDate { get; set; }
        public string? CIAddress { get; set; }
        public string? Province { get; set; }
        public string? District { get; set; }
        public string? Ward { get; set; }
        public string? SpecificAddress { get; set; }
        public string? EmailStudent { get; set; }
        public string? PhoneStudent { get; set; }
        public string FullnameParents { get; set; }
        public string? PhoneParents { get; set; }
        public string CampusId { get; set; }
        public string? Major1 { get; set; }
        public string? SpecializeMajor1 { get; set; }
        public string? Major2 { get; set; }
        public string? SpecializeMajor2 { get; set; }
        public int? YearOfGraduation { get; set; }
        public bool? RecipientResults { get; set; }
        public bool? PermanentAddress { get; set; }
        public string? AddressRecipientResults { get; set; }
        public string? SchoolName { get; set; }
        public string? FacebookUrl { get; set; }
        public string? ImgCitizenIdentification1 { get; set; }
        public string? ImgCitizenIdentification2 { get; set; }
        public string? Diploma { get; set; }

        public Guid? AccountId { get; set; }

        public virtual Account? Account { get; set; }
        public virtual Campus Campus { get; set; }

    }
}
