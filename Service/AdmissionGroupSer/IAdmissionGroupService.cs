using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.AdmissionGroupSer
{
    public interface IAdmissionGroupService
    {
        Task<List<AdmissionGroup>> GetAdmissionGroupScroreAsync(string campusId);
        Task<List<AdmissionGroup>> GetAdmissionGroupScoreAcademicAsync(string campusId);
        Task<List<AdmissionGroup>> GetAdmissionGroupAsync(string campusId, int year);
        Task<AdmissionGroup> GetAdmissionGroupByIdAsync(int id);

    }
}
