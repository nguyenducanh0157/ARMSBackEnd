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
    public class AdmissionInfomationRepository
    {
        private readonly ArmsDbContext _context;
        public AdmissionInfomationRepository(ArmsDbContext context) { _context = context; }
        public async Task<List<AdmissionInformation>> GetAdmissionInformation(string campus)
        {
            try
            {
                List<AdmissionInformation> AdmissionInformation = await _context.AdmissionInformations
                    .Where(x => x.CampusId == campus).ToListAsync();
                return AdmissionInformation;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<AdmissionInformation> GetAdmissionInformationStatusTrue()
        {
            try
            {
                AdmissionInformation AdmissionInformation = await _context.AdmissionInformations
                    .FirstOrDefaultAsync(x => x.Status==TypeOfAdmissionInformation.Process);
                return AdmissionInformation;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task UpdateAdmissionInformation(AdmissionInformation AdmissionInformation)
        {
            try
            {
                _context.Entry<AdmissionInformation>(AdmissionInformation).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new Exception("Chỉnh sửa không thành công");
            }
        }
    }
}
