using Data.ArmsContext;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Repository.MajorRepo
{
    public class MajorRepository 
    {
        private readonly ArmsDbContext _context;
        public MajorRepository(ArmsDbContext context) { _context = context; }

        public async Task<List<Major>> GetMajors(string campusId)
        {
            try
            {
                List<Major> majors = await _context.Majors
                    .Include(x => x.AdmissionDetailForMajors)
                    .Include(x => x.TypeAdmissions)
                    .Where(x => x.CampusId.Equals(campusId) )
                    .ToListAsync();
                //&& x.Status==true
                return majors;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

        }
        public async Task<List<MajorAdmission>> GetMajorAdmissions(string campusId)
        {
            try
            {
                var AI = await _context.AdmissionInformations.FirstOrDefaultAsync(x=>x.Status== TypeOfAdmissionInformation.Process && x.CampusId==campusId);
                List<MajorAdmission> majors = await _context.MajorAdmissions
                    .Include(x=>x.Major)
                    .Include(x => x.AdmissionInformation)
                    .Include(x => x.Major.TypeAdmissions)
                    .Include(x => x.Major.AdmissionDetailForMajors)
                    .OrderBy(x => x.Major.isVocationalSchool)
                    .Where(x => x.AdmissionInformationID == AI.AdmissionInformationID).ToListAsync();
                return majors;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

        }
        // cái này sẽ bỏ
        public async Task<List<Major>> GetMajors_Manage(string campusId)
        {
            try
            {
                List<Major> majors = await _context.Majors
                    .Where(x => x.CampusId.Equals(campusId))
                    .OrderBy(x => x.isVocationalSchool)
                    .ToListAsync();
                return majors;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

        }
        public async Task<MajorAdmission> GetMajorDetail(string MajorID, int AdmissionInformationID)
        {

            try
            {
                MajorAdmission major = await _context.MajorAdmissions
                   .Include(x => x.Major)
                   .Include(x=> x.Major.Subjects.OrderBy(s => s.SemesterNumber))
                   .Include(x => x.Major.TypeAdmissions)
                    .Include(x => x.Major.AdmissionDetailForMajors)
                   .Include(x => x.AdmissionInformation)
                   .SingleOrDefaultAsync(x => x.AdmissionInformationID == AdmissionInformationID && x.MajorID == MajorID);
                if (major == null)
                {
                    throw new KeyNotFoundException($"Major with ID {MajorID} not found.");
                }
                return major;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

        }
        public async Task AddNewMajor(Major major)
        {
            try
            {
                await _context.Majors.AddAsync(major);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Tạo mới không thành công");
            }
        }
        public async Task UpdateMajor(Major major)
        {
            try
            {
                _context.Entry<Major>(major).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new Exception("Chỉnh sửa không thành công");
            }
        }
    }
}
