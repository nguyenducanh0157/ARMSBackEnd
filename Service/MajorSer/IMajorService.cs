using Data.DTO;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.MajorSer
{
    public interface IMajorService
    {

        Task<List<MajorAdmission>> GetMajorsIsCollege(string campusId);
        Task<List<MajorAdmission>> GetMajorsIsVocationalSchool(string campusId);
        Task<Major> GetMajorDetail(string MajorID);
        Task<MajorAdmission> GetMajorDetail(string MajorID, int AdmissionInformationID);
        Task AddNewMajor(Major major);
        Task UpdateMajor(Major major);
        Task<List<MajorAdmission>> GetMajorsAdmin(string campusId);
        Task UpdateMajorAdmission(Major Major);
    }
}
