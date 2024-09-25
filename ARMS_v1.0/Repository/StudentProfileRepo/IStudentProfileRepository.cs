using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.StudentProfileRepo
{
    public interface IStudentProfileRepository
    {
        Task AddStudentProfile(StudentProfile StudentProfile);
    }
}
