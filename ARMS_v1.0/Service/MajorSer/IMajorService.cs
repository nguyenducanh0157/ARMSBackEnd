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
        Task<List<Major>> GetMajorsIsCollege(string campusId);
        Task<List<Major>> GetMajorsIsVocationalSchool(string campusId);
        Task<Major> GetMajorDetail(string MajorID);
    }
}
