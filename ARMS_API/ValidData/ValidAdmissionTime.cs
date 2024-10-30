using Data.DTO;
using Data.Models;
using Service.StudentProfileServ;

namespace ARMS_API.ValidData
{
    public class ValidAdmissionTime
    {
        private UserInput _userInput;

        private IStudentProfileService _studentProfileService;
        public ValidAdmissionTime(UserInput userInput, IStudentProfileService studentProfileService)
        {
            _userInput = userInput;
            _studentProfileService = studentProfileService;
        }

        internal void ValidDataAdmissionTime(int Year,DateTime StartAdmission, DateTime EndAdmission, DateTime EndRegister, DateTime StartRegister, string AdmissionInformationName)
        {
            if (string.IsNullOrEmpty(AdmissionInformationName)) throw new Exception("Không được để trống tên của đợt tuyển sinh!");
            if (StartAdmission == null ||StartAdmission == default(DateTime) ||
                EndAdmission == null || EndAdmission == default(DateTime) ||
                EndRegister == null || EndRegister == default(DateTime)||
                StartRegister == null || StartRegister == default(DateTime))
            {
                throw new Exception("Thời gian không được bỏ trống!");
            }
            if (Year < DateTime.Now.Year) 
                throw new Exception("Năm tuyển sinh không được trong quá khứ!");

            if (StartAdmission < DateTime.Now.Date || 
                EndAdmission < DateTime.Now.Date || 
                EndRegister < DateTime.Now.Date || 
                StartRegister < DateTime.Now.Date)

                throw new Exception("Thời gian không được ở trong quá khứ!");

            if (StartAdmission < EndRegister || 
                EndAdmission < EndRegister)

                throw new Exception("Thời gian nhập học phải sau thời gian đăng ký!");
        }
    }
}
