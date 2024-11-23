using ARMS_API.Helper;
using ARMS_API.ValidData;
using AutoMapper;
using Data.DTO;
using Data.Models;
using FirebaseAdmin.Messaging;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Repository.StudentProfileRepo;
using Service.AdmissionInformationSer;
using Service.EmailSer;
using Service.MajorSer;
using Service.PayFeeAdmissionSer;
using Service.StudentProfileServ;
using System.Security.Cryptography;

namespace ARMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterAdmissionController : ControllerBase
    {
        private IStudentProfileService _studentProfileService;
        private IPayFeeAdmissionService _payFeeAdmissionService;
        private IMajorService _majorService;
        private readonly IMapper _mapper;
        private ValidRegisterAdmission _validInput;
        private UserInput _userInput;
        private readonly IEmailService _emailByTextService;
        private readonly IMemoryCache _cache;
        private readonly TimeSpan _otpLifetime = TimeSpan.FromMinutes(5);
        private readonly TokenHealper _tokenHealper;
        private IAdmissionInformationService _admissionInformationService;
        public RegisterAdmissionController(IStudentProfileService studentProfileService,
            IMapper mapper,
            ValidRegisterAdmission validInput,
            UserInput userInput,
            IEmailService emailByTextService,
            IMemoryCache cache,
            TokenHealper tokenHealper,
            IPayFeeAdmissionService payFeeAdmissionService,
            IAdmissionInformationService admissionInformationService,
            IMajorService majorService
            )
        {
            _studentProfileService = studentProfileService;
            _mapper = mapper;
            _validInput = validInput;
            _userInput = userInput;
            _emailByTextService = emailByTextService;
            _cache = cache;
            _tokenHealper = tokenHealper;
            _payFeeAdmissionService = payFeeAdmissionService;
            _admissionInformationService = admissionInformationService;
            _majorService = majorService;
        }


        [HttpPut("done-profile-admission")]
        public async Task<IActionResult> AddRegisterAdmission([FromBody] AdmissionProfileDTO admissionProfileDTO)
        {
            try
            {
                // check status pay fee
                if (admissionProfileDTO.PayFeeAdmission.TransactionStatus !="00")
                {
                    return BadRequest(new ResponseViewModel()
                    {
                        Status = false,
                        Message = "Vui lòng hoàn thành khoản thanh toán!"
                    });
                }
                //mapper

                StudentProfile studentProfile = await _studentProfileService.GetStudentProfileBySpCIIdAsync(admissionProfileDTO.CitizenIentificationNumber);
                if (studentProfile == null)
                {
                    return NotFound(new ResponseViewModel
                    {
                        Status = false,
                        Message = "Không tìm thấy hồ sơ sinh viên!"
                    });
                }
                PayFeeAdmission PayFeeAdmission = _mapper.Map<PayFeeAdmission>(admissionProfileDTO.PayFeeAdmission);
                studentProfile.TypeofStatusProfile = TypeofStatus.SuccessProfileAdmission;
                PayFeeAdmission.isFeeRegister = false;
                studentProfile.PayFeeAdmissions.Add(PayFeeAdmission);
                studentProfile.AdmissionForm = admissionProfileDTO.AdmissionForm;
                studentProfile.BirthCertificate = admissionProfileDTO.BirthCertificate;
                //update profile
                await _studentProfileService.UpdateStudentRegister(studentProfile);
                return Ok(new ResponseViewModel()
                {
                    Status = true,
                    Message = "Thủ tục nhập học thành công!"
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
        
        [HttpPost("add-register-admission")]
        public async Task<IActionResult> AddAdmissionProfile([FromBody] RegisterAdmissionProfileDTO registerAdmissionProfileDTO)
        {
            try
            {
                //check data
               // _validInput.InputAddRegisterAdmission(registerAdmissionProfileDTO);
                // payment

                // check status pay fee
                if (registerAdmissionProfileDTO.PayFeeAdmission.TransactionStatus != "00")
                {
                    return BadRequest(new ResponseViewModel()
                    {
                        Status = false,
                        Message = "Vui lòng hoàn thành khoản thanh toán!"
                    });
                }
                //mapper
                // Map registerAdmissionProfileDTO sang StudentProfile
                StudentProfile studentProfile = _mapper.Map<StudentProfile>(registerAdmissionProfileDTO);
                studentProfile.TypeofStatusMajor1 = TypeofStatusForMajor.Inprocess;
                studentProfile.TypeofStatusMajor2 = TypeofStatusForMajor.Inprocess;
                studentProfile.TimeRegister = DateTime.Now;

                AdmissionInformation response = await _admissionInformationService.GetAdmissionInformationByStatus(registerAdmissionProfileDTO.CampusId);
                studentProfile.AIId = response.AdmissionInformationID;
                if (studentProfile.PayFeeAdmissions == null)
                {
                    studentProfile.PayFeeAdmissions = new List<PayFeeAdmission>();
                }
                PayFeeAdmission PayFeeAdmission = _mapper.Map<PayFeeAdmission>(registerAdmissionProfileDTO.PayFeeAdmission);
                if (registerAdmissionProfileDTO.PayFeeAdmission.TransactionStatus == "00")
                {
                    studentProfile.TypeofStatusProfile = TypeofStatus.SuccessProfileRegister;
                    PayFeeAdmission.isFeeRegister = true;
                    studentProfile.PayFeeAdmissions.Add(PayFeeAdmission);
                }
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
        [HttpPut("update-register-admission")]
        public async Task<IActionResult> UpdateAdmissionProfile([FromBody] RegisterAdmissionProfileDTO_Update registerAdmissionProfileDTO)
        {
            try
            {

                //mapper
                // Map registerAdmissionProfileDTO sang StudentProfile
                StudentProfile studentProfile = await _studentProfileService.GetStudentProfileBySpCIIdAsync(registerAdmissionProfileDTO.CitizenIentificationNumber);
                if (studentProfile == null)
                {
                    return NotFound(new ResponseViewModel { Status = false, Message = "Student profile not found." });
                }
                _mapper.Map(registerAdmissionProfileDTO, studentProfile);

                //add new
                await _studentProfileService.UpdateStudentRegister(studentProfile);
                return Ok(new ResponseViewModel()
                {
                    Status = true,
                    Message = "chỉnh sửa thành công!"
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
        [Authorize(Roles = "guest")]
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
                AdmissionProfile_DTO studentProfile = _mapper.Map<AdmissionProfile_DTO>(stf);
                var payFeeAdmission = stf.PayFeeAdmissions.FirstOrDefault(x => x.isFeeRegister == true);
                studentProfile.PayFeeAdmission = _mapper.Map<PayFeeAdmissionDTO>(payFeeAdmission);

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
        [HttpPost("send-OTP")]
        public async Task<IActionResult> SendOTPByEmail([FromBody] RequestSendOTP requestSendOTP)
        {
            if (requestSendOTP.CitizenIentificationNumber == null) throw new Exception("Không được để trống số căn cước công dân!");
            if (!_userInput.IsValidCCCD(requestSendOTP.CitizenIentificationNumber)) throw new Exception("Định dạng số căn cước công dân không đúng!");
            bool checkCitizenIentificationNumber = await _studentProfileService.isExistCCCDStudent(requestSendOTP.CitizenIentificationNumber);
            if (checkCitizenIentificationNumber == true)

                throw new Exception("Không tìm thấy hồ sơ xét tuyển!");
            //get profile
            StudentProfile sp = await _studentProfileService.GetStudentProfileBySpCIIdAsync(requestSendOTP.CitizenIentificationNumber);
            if (sp == null || string.IsNullOrEmpty(sp.EmailStudent))
            {
                return BadRequest("Không nhận được email của học sinh!");
            }
            var otp = new Random().Next(100000, 999999).ToString();
            EmailRequestByText emailRequest = new EmailRequestByText();
            emailRequest.ToEmail = sp.EmailStudent;
            emailRequest.Subject = "Send OTP";
            emailRequest.Body = $"OTP của bạn là: {otp}";
            _cache.Set(emailRequest.ToEmail, otp, _otpLifetime);
            await _emailByTextService.SendEmailAsync(emailRequest);
            return Ok(new { Message = "Mã OTP đã được gửi đến email của bạn!", Email = sp.EmailStudent });
        }
        [HttpPost("verify-OTP")]
        public async Task<ActionResult<string>> VerifyOtpAsync(string email, string otp)
        {
            if (_cache.TryGetValue(email, out string storedOtp) && storedOtp == otp)
            {
                _cache.Remove(email);

                var token = _tokenHealper.GenerateAccessToken(email);

                return Ok(new { Token = token });
            }

            return Unauthorized("OTP không hợp lệ.");
        }
        [HttpGet("check-slot-profile-admission")]
        public async Task<IActionResult> CountProfile(string major, string campus)
        {
            try
            {

                int countProfile = await _studentProfileService.CountAdmissionMajor(major, campus);
                var majorTarget = await _majorService.GetMajorDetail(major,campus);
                if(countProfile == majorTarget.Target)
                {
                    return BadRequest(new ResponseViewModel()
                    {
                        Status = false,
                        Message = "Số lượng hồ sơ đã đủ!"
                    });
                }

                return Ok();

            }
            catch (Exception)
            {
                return BadRequest(new ResponseViewModel()
                {
                    Status = false,
                    Message = "Server lỗi!"
                });
            }
        }
        [HttpGet("check-cccd")]
        public async Task<IActionResult> CheckCCCD(string CCCD)
        {
            try
            {
                var checkResult = CCCD switch
                {
                    null => "empty",
                    var ccd when !_userInput.IsValidCCCD(ccd) => "invalid",
                    var ccd when await _studentProfileService.isExistCCCDStudent(ccd) => "exists",
                    _ => "valid" 
                };

                return checkResult switch
                {
                    "empty" => BadRequest(new ResponseViewModel()
                    {
                        Status = false,
                        Message = "Không được để trống số căn cước công dân!"
                    }),
                    "invalid" => BadRequest(new ResponseViewModel()
                    {
                        Status = false,
                        Message = "Định dạng số căn cước công dân không đúng!"
                    }),
                    "exists" => BadRequest(new ResponseViewModel()
                    {
                        Status = false,
                        Message = "Căn cước công dân đã tồn tại!"
                    }),
                    _ => Ok()
                };
            }
            catch (Exception)
            {
                return BadRequest(new ResponseViewModel()
                {
                    Status = false,
                    Message = "Server lỗi!"
                });
            }
        }


        [HttpGet("check-email")]
        public async Task<IActionResult> CheckEmail(string email)
        {
            try
            {
                var checkResult = email switch
                {
                    var e when string.IsNullOrEmpty(e) => "empty",
                    var e when !_userInput.IsValidEmail(e) => "invalid",
                    var e when await _studentProfileService.isExistEmailStudent(e) => "exists", 
                    _ => "valid"  
                };

                return checkResult switch
                {
                    "empty" => BadRequest(new ResponseViewModel()
                    {
                        Status = false,
                        Message = "Không được để trống email của học sinh!"
                    }),
                    "invalid" => BadRequest(new ResponseViewModel()
                    {
                        Status = false,
                        Message = "Email học sinh không hợp lệ!"
                    }),
                    "exists" => BadRequest(new ResponseViewModel()
                    {
                        Status = false,
                        Message = "Email đã được đăng ký!"
                    }),
                    _ => Ok()
                };
            }
            catch (Exception)
            {
                return BadRequest(new ResponseViewModel()
                {
                    Status = false,
                    Message = "Server lỗi!"
                });
            }
        }

        [HttpGet("check-phone")]
        public async Task<IActionResult> CheckPhone(string phone)
        {
            try
            {
                var checkResult = phone switch
                {
                    var p when string.IsNullOrEmpty(p) => "empty", 
                    var p when !_userInput.IsValidPhoneNumber(p) => "invalid",
                    var p when await _studentProfileService.isExistEmailStudent(p) => "exists",
                    _ => "valid"
                };

                return checkResult switch
                {
                    "empty" => BadRequest(new ResponseViewModel()
                    {
                        Status = false,
                        Message = "Không được để trống số điện thoại của học sinh!"
                    }),
                    "invalid" => BadRequest(new ResponseViewModel()
                    {
                        Status = false,
                        Message = "Số điện thoại học sinh không hợp lệ!"
                    }),
                    "exists" => BadRequest(new ResponseViewModel()
                    {
                        Status = false,
                        Message = "Số điện thoại đã được đăng ký!"
                    }),
                    _ => Ok()
                };
            }
            catch (Exception)
            {
                return BadRequest(new ResponseViewModel()
                {
                    Status = false,
                    Message = "Server lỗi!"
                });
            }
        }

    }
}
