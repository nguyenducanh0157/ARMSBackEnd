﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class TypeAdmission
    {
        public string MajorID { get; set; }
        public TypeOfDiploma TypeDiploma { get; set; }
        public TypeOfTranscript? TypeOfTranscript { get; set; }
        public virtual Major Major { get; set; }
    }
}
