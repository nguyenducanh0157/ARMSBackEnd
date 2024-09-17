using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.MajorRepo
{
    public interface IMajorRepository
    {
        Task<List<Major>> GetMajors(string campusId);
    }
}
