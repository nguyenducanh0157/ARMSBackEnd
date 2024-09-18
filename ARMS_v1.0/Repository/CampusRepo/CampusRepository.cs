using Data.ArmsContext;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.CampusRepo
{
    public class CampusRepository : ICampusRepository
    {
        private readonly ArmsDbContext _context;
        public CampusRepository(ArmsDbContext context) { _context = context; }
        public async Task<int> CountCampus()
        {
            try
            {
               int campus = _context.Campuses.Count();
                return campus;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public async Task<List<AlumiStudent>> GetAlumiStudents()
        {
            try
            {
                List<AlumiStudent> AlumiStudents = await _context.AlumiStudents
                    .Include(x=>x.SpecializeMajor)
                    .Include(x => x.Campus)
                    .ToListAsync();
                return AlumiStudents;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public async Task<List<Banner>> GetBanners(string campusId)
        {
            try
            {
                List<Banner> banners = await _context.Banners
                    .Where(x=>x.CampusId.Equals(campusId))
                    .ToListAsync();
                return banners;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public async Task<List<Campus>> GetCampuses()
        {
            try
            {
                List<Campus> campuses = await _context.Campuses
                    .ToListAsync();
                return campuses;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

        }

        public async Task<IntroduceCampus> GetIntroduce(string campusId)
        {
            try
            {
                IntroduceCampus intro = await _context.IntroduceCampuses.FirstOrDefaultAsync(x => x.CampusId.Equals(campusId));
                return intro;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
