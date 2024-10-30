using ARMS_API.ValidData;
using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.StudentProfileRepo;
using Service.StudentProfileServ;
using System.Security.Cryptography;

namespace ARMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterAdmissionController : ControllerBase
    {
        private IStudentProfileService _studentProfileService;
        private readonly IMapper _mapper;
        private ValidRegisterAdmission _validInput;
        private UserInput _userInput;
        public RegisterAdmissionController(IStudentProfileService studentProfileService, IMapper mapper, ValidRegisterAdmission validInput, UserInput userInput)
        {
            _studentProfileService = studentProfileService;
            _mapper = mapper;
            _validInput = validInput;
            _userInput = userInput;
        }
        [HttpPost("add-register-admission")]
        public async Task<IActionResult> AddRegisterAdmission([FromBody] RegisterAdmissionProfileDTO registerAdmissionProfileDTO)
        {
            try
            {
                //check data
                _validInput.InputAddRegisterAdmission(registerAdmissionProfileDTO);
                // payment

                // check status pay fee
                if (registerAdmissionProfileDTO.PayFeeAdmission.TransactionStatus !="00")
                {
                    return BadRequest(new ResponseViewModel()
                    {
                        Status = false,
                        Message = "Vui lòng hoàn thành khoản thanh toán!"
                    });
                }
                //mapper
                StudentProfile studentProfile = _mapper.Map<StudentProfile>(registerAdmissionProfileDTO);
                //add new
                await _studentProfileService.AddStudentProfile(studentProfile);
                return Ok(new ResponseViewModel()
                {
                    Status = true,
                    Message = "Đăng ký thành công!"
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseViewModel()
                {
                    Status = false,
                    Message = ex.Message
                });
            }
        }
        [HttpPost("search-register-admission")]
        public async Task<IActionResult> SearchRegisterAdmission([FromBody] RequestSearchRegisterAdmissionProfileDTO requestSearchRegisterAdmissionProfileDTO)
        {
            try
            {
                if (requestSearchRegisterAdmissionProfileDTO.CitizenIentificationNumber == null) throw new Exception("Không được để trống số căn cước công dân!");
                if (!_userInput.IsValidCCCD(requestSearchRegisterAdmissionProfileDTO.CitizenIentificationNumber)) throw new Exception("Định dạng số căn cước công dân không đúng!");
                bool checkCitizenIentificationNumber = await _studentProfileService.isExistCCCDStudent(requestSearchRegisterAdmissionProfileDTO.CitizenIentificationNumber);
                if (checkCitizenIentificationNumber == true)
                    throw new Exception("Không tìm thấy hồ sơ xét tuyển!");
                StudentProfile stf = await _studentProfileService.GetExistCCCDStudent(requestSearchRegisterAdmissionProfileDTO.CitizenIentificationNumber);
                //mapper
                RegisterAdmissionProfileDTO studentProfile = _mapper.Map<RegisterAdmissionProfileDTO>(stf);
                return Ok(studentProfile);
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseViewModel()
                {
                    Status = false,
                    Message = ex.Message
                });
            }
        }
    }
}
