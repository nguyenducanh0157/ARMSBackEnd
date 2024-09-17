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
        public string MajorName { get; set; }
        public virtual ICollection<SpecializeMajorDTO> SpecializeMajorDTOs { get; set; }
    }
}
