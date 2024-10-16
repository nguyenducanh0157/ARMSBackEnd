using Data.DTO;
using Service.AdmissionInformationSer;
using Service.StudentProfileServ;

namespace ARMS_API.ValidData
{
    public class ValidAdmissionInformation
    {
        private UserInput _userInput;

        private IAdmissionInformationService _admissionInformationService;
        public ValidAdmissionInformation(UserInput userInput,IAdmissionInformationService admissionInformationService)
        {
            _userInput = userInput;
            _admissionInformationService = admissionInformationService;
        }

        internal void ValidDataAdmissionInfor(AdmissionInformation_Update_DTO admissionInformationDTO)
        {
            try
            {

            if (admissionInformationDTO.FeeRegister<100000)
                throw new Exception("Phí xét tuyển phải trên 100.000 VND");
            if (admissionInformationDTO.FeeAdmission < 100000)
                throw new Exception("Phí nhập học phải trên 100.000 VND");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
