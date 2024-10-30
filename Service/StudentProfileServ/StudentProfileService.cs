using Data.ArmsContext;
using Data.Models;
using Repository;
using Repository.StudentProfileRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Service.StudentProfileServ
{
    public class StudentProfileService : IStudentProfileService
    {
        private readonly StudentProfileRepository _studentProfileRepository;
        public StudentProfileService(ArmsDbContext context)
        {
            _studentProfileRepository = new StudentProfileRepository(context);
        }
        public async Task AddStudentProfile(StudentProfile StudentProfile)
        {
            try
            {

            Guid id = Guid.NewGuid();
            StudentProfile.SpId = id;
            await _studentProfileRepository.AddStudentProfile(StudentProfile);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<StudentProfile> GetExistCCCDStudent(string CID)
            => await _studentProfileRepository.GetExistCCCDStudent(CID);

        public async Task<List<StudentProfile>> GetRegisterAdmission(string CampusId)
            => await _studentProfileRepository.GetRegisterAdmission(CampusId);

        public async Task<StudentProfile?> GetStudentProfileBySpCIIdAsync(string id)
            => await _studentProfileRepository.GetStudentProfileBySpCIIdAsync(id);

        public async Task<StudentProfile?> GetStudentProfileBySpIdAsync(Guid id)
            => await _studentProfileRepository.GetStudentProfileBySpIdAsync(id);

        public async Task<bool> isExistCCCDStudent(string CID) => await _studentProfileRepository.isExistCCCDStudent(CID);

        public async Task<bool> isExistEmailStudent(string email) => await _studentProfileRepository.isExistEmailStudent(email);

        public async Task<bool> isExistPhoneNumberStudent(string phonenumber) => await _studentProfileRepository.isExistPhoneNumberStudent(phonenumber);
    }
}
