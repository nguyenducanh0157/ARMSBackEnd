using Data.ArmsContext;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.MajorRepo
{
    public class MajorRepository: IMajorRepository
    {
        private readonly ArmsDbContext _context;
        public MajorRepository(ArmsDbContext context) { _context = context; }

        public async Task<SpecializeMajor> GetSpecializeMajorAdmission(string SpecializeMajorID)
        {
            try
            {
                SpecializeMajor major = await _context.SpecializeMajors
                    .Include(x=>x.Subjects.OrderBy(x=>x.SemesterNumber))
                    .Include(x=>x.TypeAdmissionForMajors)
                        .ThenInclude(tafm => tafm.TypeOfDiploma)
                    .Include(x => x.TypeAdmissionForMajors)
                        .ThenInclude(tafm => tafm.TypeAcademicRecord)
                    .Include(x => x.Major)
                    .SingleOrDefaultAsync(x=>x.SpecializeMajorID.Equals(SpecializeMajorID));
                return major;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<Major>> GetMajors(string campusId)
        {
            try
            {
                List<Major> majors = await _context.Majors
                    .Include(a => a.SpecializeMajors)
                    .Where(x => x.CampusId.Equals(campusId))
                    .ToListAsync();
                return majors;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

        }
    }
}
