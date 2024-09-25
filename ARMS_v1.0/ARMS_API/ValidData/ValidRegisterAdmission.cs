using Data.DTO;

namespace ARMS_API.ValidData
{
    public class ValidRegisterAdmission
    {
        private UserInput _userInput;
        public ValidRegisterAdmission(UserInput userInput)
        {
            _userInput = userInput;
        }

        public void InputAddRegisterAdmission(RegisterAdmissionProfileDTO registerAdmissionProfileDTO)
        {
            if (registerAdmissionProfileDTO == null) throw new Exception("Không nhận được dữ liệu");
            if (string.IsNullOrEmpty(registerAdmissionProfileDTO.Fullname)) throw new Exception("Không được để trống họ và tên");
            if (string.IsNullOrEmpty(registerAdmissionProfileDTO.EmailStudent)) throw new Exception("Không được để trống email của học sinh");
            if (!_userInput.IsValidEmail(registerAdmissionProfileDTO.EmailStudent)) throw new Exception("Email học sinh không hợp lệ!");
            if (string.IsNullOrEmpty(registerAdmissionProfileDTO.PhoneStudent)) throw new Exception("Không được để trống số điện thoại của học sinh");
            if (!_userInput.IsValidPhoneNumber(registerAdmissionProfileDTO.PhoneStudent)) throw new Exception("Số điện thoại học sinh không hợp lệ!");
        }
    }
}
