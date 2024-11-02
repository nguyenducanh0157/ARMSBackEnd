﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Major
    {
        public string MajorID { get; set; }// mã ngành
        public string MajorCode { get; set; }// số mã ngành
        public string MajorName { get; set; }
        public string? Description { get; set; }
        public int? Target { get; set; }
        public bool Status { get; set; }
        public string? TimeStudy { get; set; }
        public bool isVocationalSchool { get; set; }
        public string CampusId { get; set; }
        public decimal? Tuition { get; set; }
        public virtual Campus? Campus { get; set; }
        public virtual ICollection<AdmissionDetailForMajor>? AdmissionDetailForMajors { get; set; }
        public virtual ICollection<Subject>? Subjects { get; set; }
        public virtual ICollection<StudentConsultation>? StudentConsultations { get; set; }
        public virtual ICollection<TypeAdmission>? TypeAdmissions { get; set; }
        public virtual ICollection<RequestChangeMajor>? RequestChangeMajors { get; set; }

    }
}