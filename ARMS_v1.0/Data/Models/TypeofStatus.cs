﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public enum TypeofStatus
    {
        Inprocess,//0
        PassMajor1,//1
        PassMajor2,//2
        FailMajor1,//3
        FailMajor2,//4
        SuccessProfileRegister,
        SuccessProfileAdmission,
        WaitingPaymentRegister,//5
        WaitingPaymentAdmission,//6
        InProcessAdmission,//7
        Done//8
    }
}
