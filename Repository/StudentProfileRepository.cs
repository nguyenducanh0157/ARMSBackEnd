using Data.ArmsContext;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.StudentProfileRepo
{
    public class StudentProfileRepository 
    {
        private readonly ArmsDbContext _context;
        public StudentProfileRepository(ArmsDbContext context) { _context = context; }
        public async Task AddStudentProfile(StudentProfile StudentProfile)
        {
            try
            {
                await _context.StudentProfiles.AddRangeAsync(StudentProfile);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> isExistCCCDStudent(string CID)
        {
            try
            {
                var sf = await _context.StudentProfiles.FirstOrDefaultAsync(x => x.CitizenIentificationNumber.Equals(CID));
                if (sf == null) { return true; }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<StudentProfile> GetExistCCCDStudent(string CID)
        {
            try
            {
                var sf = await _context.StudentProfiles
                    .Include(x=>x.AcademicTranscripts)
                    .Include(x=>x.Campus)
                    .Include(x => x.PriorityDetail)
                    .FirstOrDefaultAsync(x => x.CitizenIentificationNumber.Equals(CID));
                
                return sf;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> isExistEmailStudent(string email)
        {
            try
            {
                var sf = await _context.StudentProfiles.FirstOrDefaultAsync(x => x.EmailStudent.ToLower().Equals(email.ToLower()));
                if (sf == null) { return true; }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> isExistPhoneNumberStudent(string phonenumber)
        {
            try
            {
                var sf = await _context.StudentProfiles.FirstOrDefaultAsync(x => x.PhoneStudent.Equals(phonenumber));
                if (sf == null) { return true; }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<int> CountAdmissionMajor(string majorId, string CampusId)
        {
            try
            {
                var majorAdmission = await _context.StudentProfiles
                    .Where(x=>(x.Major1 == majorId 
                    || x.Major2== majorId) && x.CampusId == CampusId 
                    &&( x.TypeofStatusMajor1 == TypeofStatusForMajor.Pass || x.TypeofStatusMajor2 == TypeofStatusForMajor.Pass))
                    .ToListAsync();

                return majorAdmission.Count();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<List<StudentProfile>> GetRegisterAdmission(string CampusId)
        {
            try
            {
                var RegisterAdmission = await _context.StudentProfiles
                    .Include(x=>x.Campus)
                    .Include(x => x.AcademicTranscripts)
                    .Include(x => x.PriorityDetail)
                    .Where(x => x.CampusId == CampusId)
                    .OrderByDescending(x => x.PriorityDetailPriorityID)
                    .OrderBy(x => x.TimeRegister)
                    .ToListAsync();

                return RegisterAdmission;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<StudentProfile?> GetStudentProfileBySpIdAsync(Guid id)
        {
            var studentProfile = await _context.StudentProfiles
                .Include(x => x.Campus)
                .Include(x => x.AcademicTranscripts)
                .Include(x => x.PriorityDetail)
                .FirstOrDefaultAsync(x => x.SpId == id);

            return studentProfile;
        }
        public async Task<StudentProfile?> GetStudentProfileBySpCIIdAsync(string id)
        {
            var studentProfile = await _context.StudentProfiles
                .Include(x => x.Campus)
                .Include(x => x.AcademicTranscripts)
                .Include(x => x.PriorityDetail)
                .FirstOrDefaultAsync(x => x.CitizenIentificationNumber == id);

            return studentProfile;
        }
    }
}
