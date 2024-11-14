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
    public class AdmissionTimeRepository
    {
        private readonly ArmsDbContext _context;
        public AdmissionTimeRepository(ArmsDbContext context) { _context = context; }

        public async Task<List<AdmissionTime>> GetAdmissionTimes(string CampusId)
        {
            try
            {
                
                List<AdmissionTime> AdmissionTimes = await _context.AdmissionTimes.Where(x => x.CampusId.Equals(CampusId)).ToListAsync();
                return AdmissionTimes;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<AdmissionTime> GetAdmissionTime(int AIId)
        {
            try
            {
                AdmissionTime AdmissionTime = await _context.AdmissionTimes
                    .FirstOrDefaultAsync(x => x.AIId == AIId);
                return AdmissionTime;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task AddAdmissionTime(AdmissionTime AdmissionTime)
        {
            try
            {
                await _context.AdmissionTimes.AddAsync(AdmissionTime);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Tạo mới không thành công");
            }
        }
        public async Task UpdateAdmissionTime(AdmissionTime AdmissionTime)
        {
            try
            {
                _context.Entry<AdmissionTime>(AdmissionTime).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new Exception("Chỉnh sửa không thành công");
            }
        }
    }
}
