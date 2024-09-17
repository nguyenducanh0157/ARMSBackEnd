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
    }
}
