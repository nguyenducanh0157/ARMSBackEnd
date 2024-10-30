using Data.ArmsContext;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class AdmissionGroupRepository
    {
        private readonly ArmsDbContext _context;
        public AdmissionGroupRepository(ArmsDbContext context) { _context = context; }
        public async Task<List<AdmissionGroup>> GetAdmissionGroupScroreAsync(string campusId)
        {
            try
            {
                List<AdmissionGroup> AdmissionGroups = await _context.AdmissionGroups
                    .Where(x=>x.CampusId== campusId && x.StatusScore == true)
                    .ToListAsync();
                return AdmissionGroups;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
        public async Task<List<AdmissionGroup>> GetAdmissionGroupScoreAcademicAsync(string campusId)
        {
            try
            {
                List<AdmissionGroup> AdmissionGroups = await _context.AdmissionGroups
                    .Where(x => x.CampusId == campusId && x.StatusScoreAcademic == true)
                    .ToListAsync();
                return AdmissionGroups;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
        public async Task<List<AdmissionGroup>> GetAdmissionGroupAsync(string campusId, int year)
        {
            try
            {
                List<AdmissionGroup> AdmissionGroups = await _context.AdmissionGroups
                    .Where(x => x.CampusId == campusId && x.Year==year)
                    .ToListAsync();
                return AdmissionGroups;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
        public async Task<AdmissionGroup> GetAdmissionGroupByIdAsync(int id)
        {
            try
            {
                AdmissionGroup AdmissionGroups = await _context.AdmissionGroups
                    .SingleOrDefaultAsync(x => x.AdmissionGroupId == id);
                return AdmissionGroups;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
    }
}
