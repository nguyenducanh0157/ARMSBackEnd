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
        public async Task<AdmissionInformation> GetAdmissionInformation(string campus)
        {
            try
            {
                AdmissionInformation AdmissionInformation = await _context.AdmissionInformations
                    .FirstOrDefaultAsync(x => x.CampusId == campus);
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
