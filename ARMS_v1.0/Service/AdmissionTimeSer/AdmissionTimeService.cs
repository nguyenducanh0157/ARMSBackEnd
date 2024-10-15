using Data.ArmsContext;
using Data.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.AdmissionTimeSer
{
    public class AdmissionTimeService : IAdmissionTimeService
    {
        private readonly AdmissionTimeRepository _admissionTimeRepository;
        public AdmissionTimeService(ArmsDbContext context)
        {
            _admissionTimeRepository = new AdmissionTimeRepository(context);
        }

        public async Task AddAdmissionTime(AdmissionTime AdmissionTime)
        {
            var data = await _admissionTimeRepository.GetAdmissionTimes(AdmissionTime.CampusId);
            var checkdata = data.Where(x=>x.Year== AdmissionTime.Year).ToList();

            if (checkdata.Any())
            {
                var checkEndDate = checkdata.Max(x => x.EndRegister);
                if (AdmissionTime.StartRegister <= checkEndDate)
                    throw new Exception("Thời gian bắt đầu không được trước hoặc bằng thời gian kết thúc của đợt tuyển sinh trước!");
                if (AdmissionTime.StartAdmission <= AdmissionTime.EndRegister || AdmissionTime.EndAdmission <= AdmissionTime.EndRegister)
                {
                    throw new Exception("Thời gian nhập học phải sau thời gian đăng ký!");
                }
                await _admissionTimeRepository.AddAdmissionTime(AdmissionTime);

            }
        }

        public Task<AdmissionTime> GetAdmissionTime(int AIId) 
            => _admissionTimeRepository.GetAdmissionTime(AIId);

        public async Task<List<AdmissionTime>> GetAdmissionTimes(string CampusId, int year)
        {
            var result = await _admissionTimeRepository.GetAdmissionTimes(CampusId);
            var respone = result.Where(x=>x.Year== year).ToList();
            return respone;
        }

    }
}
