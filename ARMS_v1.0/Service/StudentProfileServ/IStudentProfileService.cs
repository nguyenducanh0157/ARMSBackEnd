using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.StudentProfileServ
{
    public interface IStudentProfileService
    {
        Task AddStudentProfile(StudentProfile StudentProfile);
        Task<bool> isExistCCCDStudent(string CID);
        Task<bool> isExistEmailStudent(string email);
        Task<bool> isExistPhoneNumberStudent(string phonenumber);
    }
}
