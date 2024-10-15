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
                await _context.StudentProfiles.AddAsync(StudentProfile);
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
    }
}
