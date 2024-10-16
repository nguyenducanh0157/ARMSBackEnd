using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.AdmissionInformationSer
{
    public interface IAdmissionInformationService
    {
        Task<AdmissionInformation> GetAdmissionInformation(string campus);
        Task UpdateAdmissionInformation(AdmissionInformation AdmissionInformation);
    }
}
