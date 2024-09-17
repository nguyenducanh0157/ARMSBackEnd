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
