using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO
{
    public class AdmissionTimeDTO
    {
        public int AdmissionTimeID { get; set; }
        public string AdmissionTimeName { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
    }
}
