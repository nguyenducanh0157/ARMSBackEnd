using Data.ArmsContext;
using Data.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.AdmissionInformationSer
{
    public class AdmissionInformationService : IAdmissionInformationService
    {
        private readonly AdmissionInfomationRepository _admissionInfomationRepository;
        public AdmissionInformationService(ArmsDbContext context)
        {
            _admissionInfomationRepository = new AdmissionInfomationRepository(context);
        }
        public async Task<List<AdmissionInformation>> GetAdmissionInformation(string campus)
        {
            try
            {
            var data = await _admissionInfomationRepository.GetAdmissionInformation(campus);
            return data;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<AdmissionInformation> GetAdmissionInformationByStatus(string campus)
        {
            try
            {
            var data = await _admissionInfomationRepository.GetAdmissionInformationStatusTrue(campus);
            return data;

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
                var ValidadmissionInformation = await _admissionInfomationRepository.GetAdmissionInformation(AdmissionInformation.CampusId);
                //ValidadmissionInformation.FeeAdmission = AdmissionInformation.FeeAdmission;
                //ValidadmissionInformation.FeeRegister = AdmissionInformation.FeeRegister;
                //ValidadmissionInformation.AdmissionProfileDescription = AdmissionInformation.AdmissionProfileDescription;
                //await _admissionInfomationRepository.UpdateAdmissionInformation(ValidadmissionInformation);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
