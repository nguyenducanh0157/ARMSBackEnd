using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public enum TypeofStatus
    {
        SuccessProfileRegister,//0
        SuccessProfileAdmission,//1
        WaitingPaymentAdmission,//2
        InProcessAdmission,//3
        Done//4
    }
    public enum TypeofStatusForMajor
    {
        Fail,
        Pass,
        Inprocess
    }
    public enum TypeofRequestChangeMajor
    {
        Accept,
        Reject,
        Inprocess
    }
}
