using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.CampusRepo
{
    public interface ICampusRepository
    {
        Task<int> CountCampus();
        Task<List<Campus>> GetCampuses();
        Task<List<Banner>> GetBanners(string campusId);
        Task<Campus> GetCampus(string campusId);
        Task<List<AlumiStudent>> GetAlumiStudents();
    }
}
