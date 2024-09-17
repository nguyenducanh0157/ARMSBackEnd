using ARMS_API.Models;
using AutoMapper;
using Data.DTO;
using Repository.StudentConsultationRepo;

namespace ARMS_API.ValidData
{
    public class ValidStudentConsultation
    {
        private UserInput _userInput;
        public ValidStudentConsultation(UserInput userInput)
        {
            _userInput = userInput;
        }
        public void InputStudentConsultation(StudentConsultationDTO studentConsultationDTO)
        {
            ResponseViewModel result = new ResponseViewModel();
            try
            {
                if (studentConsultationDTO == null) throw new Exception("Không nhận được dữ liệu");
                if (string.IsNullOrEmpty(studentConsultationDTO.FullName)) throw new Exception("Không được để trống họ và tên");
                if (string.IsNullOrEmpty(studentConsultationDTO.Email)) throw new Exception("Không được để trống email");
                if (!_userInput.IsValidEmail(studentConsultationDTO.Email)) throw new Exception("Email không hợp lệ!");
                if (string.IsNullOrEmpty(studentConsultationDTO.PhoneNumber)) throw new Exception("Không được để trống số điện thoại");
                if (!_userInput.IsValidPhoneNumber(studentConsultationDTO.PhoneNumber)) throw new Exception("Số điện thoại không hợp lệ!");
                if (studentConsultationDTO.SpecializeMajorID == null) throw new Exception("Không được để trống ngành học");
                if (string.IsNullOrEmpty(studentConsultationDTO.LinkFB)) throw new Exception("Không được để trống link facebook");
            }
            catch (Exception ex)
            {
                result.Status = false;
                result.Message = ex.Message;
            }
        }
    }
}
