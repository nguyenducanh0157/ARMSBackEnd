﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class AdmissionTime
    {
        public int AIId { get; set; }
        public string AdmissionInformationName { get; set; }
        public DateTime StartRegister { get; set;}
        public DateTime EndRegister { get; set; }
        public DateTime StartAdmission { get; set; }
        public DateTime EndAdmission { get; set; }
        public int AdmissionInformationID { get; set; }
        public virtual AdmissionInformation? AdmissionInformation { get; set; }
    }
}