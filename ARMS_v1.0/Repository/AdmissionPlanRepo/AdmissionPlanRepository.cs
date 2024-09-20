using Data.ArmsContext;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.AdmissionPlanRepo
{
    public class AdmissionPlanRepository : IAdmissionPlanRepository
    {
        private readonly ArmsDbContext _context;
        public AdmissionPlanRepository(ArmsDbContext context) { _context = context; }
        public async Task<AdmissionPlan> GetAdmissionPlan(string CampusId)
        {
			try
			{
                AdmissionPlan admissionPlan = await _context.AdmissionPlans
                    .Include(x=>x.Campus)
                    .Include(x=>x.AdmissionTimes)
                    .SingleOrDefaultAsync(x=>x.CampusId.Equals(CampusId));
                return admissionPlan;
			}
			catch (Exception)
			{

				throw;
			}
        }
    }
}
