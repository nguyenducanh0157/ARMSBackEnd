﻿using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO
{
    public class AdmissionInformationDTO
    {
        public int AdmissionInformationID { get; set; }
        public decimal FeeRegister { get; set; }
        public decimal FeeAdmission { get; set; }
        public string? AdmissionProfileDescription { get; set; }
    }
    public class AdmissionInformation_AC_DTO
    {
        public int AdmissionInformationID { get; set; }
        public decimal FeeRegister { get; set; }
        public decimal FeeAdmission { get; set; }
        public int? Year { get; set; }
        public DateTime? StartAdmission { get; set; }
        public DateTime? EndAdmission { get; set; }
        public TypeOfAdmissionInformation? Status { get; set; }
        public string? AdmissionProfileDescription { get; set; }
    }
    public class AdmissionInformation_Update_DTO
    {
        public decimal FeeRegister { get; set; }
        public decimal FeeAdmission { get; set; }
        public string? AdmissionProfileDescription { get; set; }
        public string CampusId { get; set; }

    }
}
