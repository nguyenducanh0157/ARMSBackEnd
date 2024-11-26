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
using Service.LocationSer;
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
        private readonly IEmailService _emailService;
        private readonly ILocationService _locationService;
        public RegisterAdmissionController(IStudentProfileService studentProfileService,
            IMapper mapper,
            ValidRegisterAdmission validInput,
            UserInput userInput,
            IEmailService emailByTextService,
            IMemoryCache cache,
            TokenHealper tokenHealper,
            IPayFeeAdmissionService payFeeAdmissionService,
            IAdmissionInformationService admissionInformationService,
            IMajorService majorService,
            IEmailService emailService,
            ILocationService locationService
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
            _emailService = emailService;
            _locationService = locationService;
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
                studentProfile.AdmissionTimeId = response.AdmissionInformationID;
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
                var major = await _majorService.GetMajor(registerAdmissionProfileDTO.Major1);
                string major1 = major.MajorName;
                Console.WriteLine(major1);
                var majorn2 = await _majorService.GetMajor(registerAdmissionProfileDTO.Major2);
                string major2 = majorn2.MajorName;
                Console.WriteLine(major2);

                //add new
                await _studentProfileService.AddStudentProfile(studentProfile);
                _ = Task.Run(async () =>
                {
                    var gender = registerAdmissionProfileDTO.Gender == true ? "Nam" : "Nữ";
                    Console.WriteLine(gender);
                    var provinceName = await _locationService.GetProvinceName(registerAdmissionProfileDTO.Province);
                    var districtName = await _locationService.GetDistrictName(registerAdmissionProfileDTO.District);
                    var wardName = await _locationService.GetWardName(registerAdmissionProfileDTO.Ward);
                    var specificAddress = registerAdmissionProfileDTO.SpecificAddress;
                    // Ghép địa chỉ hoàn chỉnh
                    var address = $"{specificAddress}, {wardName}, {districtName}, {provinceName}";
                    Console.WriteLine("địa chỉ " + address);


                    var emailRequest = new EmailRequest
                    {
                        ToEmail = registerAdmissionProfileDTO.EmailStudent,
                        Subject = "Thông báo đăng ký hồ sơ tuyển sinh thành công!",
                        Body = $@"<!DOCTYPE html>
                <html lang=""en"">
                <head>
                    <meta charset=""UTF-8"">
                    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
                    <title>Thông tin Đăng ký Tuyển sinh</title>
                    <style>
                        body {{
                            font-family: Arial, sans-serif;
                            line-height: 1.6;
                            margin: 20px;
                        }}
                        .container {{
                            max-width: 800px;
                            margin: 0 auto;
                            border: 1px solid #ddd;
                            border-radius: 10px;
                            padding: 20px;
                            background-color: #f9f9f9;
                        }}
                        h1 {{
                            text-align: center;
                            color: #333;
                        }}
                        table {{
                            width: 100%;
                            border-collapse: collapse;
                            margin: 20px 0;
                        }}
                        th, td {{
                            padding: 10px;
                            border: 1px solid #ddd;
                            text-align: left;
                        }}
                        th {{
                            background-color: #f4f4f4;
                        }}
                    </style>
                </head>
                <body>
                    <div class=""container"">
                        <h1 style=""color: orange"">Thông tin đăng ký Tuyển sinh</h1>
                        <p>Thân gửi bạn 
                            <strong>{registerAdmissionProfileDTO.Fullname},</strong>
                        </p>
                        <p>Chúng tôi rất vui vì nhận được sự quan tâm từ bạn. 
                            Dưới đây là thông tin đăng ký tuyển sinh của bạn:</p>
                        <table>
                            <tr>
                                <th>Họ và tên</th>
                                <td>{registerAdmissionProfileDTO.Fullname}</td>
                            </tr>
                            <tr>
                                <th>Ngày sinh</th>
                                <td>{registerAdmissionProfileDTO.Dob}</td>
                            </tr>
                            <tr>
                                <th>Giới tính</th>
                                 <td>{gender}</td>
                            </tr>
                            <tr>
                                <th>Dân tộc</th>
                                <td>{registerAdmissionProfileDTO.Nation}</td>
                            </tr>
                            </tr>
                            <tr>
                                <th>Địa chỉ</th>
                                 <td>{address}</td>
                            </tr>
                            <tr>
                                <th>Số căn cước công dân</th>
                                <td>{registerAdmissionProfileDTO.CitizenIentificationNumber}</td>
                            </tr>
                            <tr>
                                <th>Ngày cấp</th>
                                <td>{registerAdmissionProfileDTO.CIDate}</td>
                            </tr>
                            <tr>
                                <th>Nơi cấp</th>
                                <td>{registerAdmissionProfileDTO.CIAddress}</td>
                            </tr>
                            <tr>
                                <th>Email</th>
                                <td>{registerAdmissionProfileDTO.EmailStudent}</td>
                            </tr>
                            <tr>
                                <th>Số điện thoại</th>
                                <td>{registerAdmissionProfileDTO.PhoneStudent}</td>
                            </tr>
                            <tr>
                                <th>Trường THPT</th>
                                <td>{registerAdmissionProfileDTO.SchoolName}</td>
                            </tr>
                            <tr>
                                <th>Năm tốt nghiệp</th>
                                 <td>{registerAdmissionProfileDTO.YearOfGraduation}</td>
                            </tr>

                            <tr>
                                <th>Thông tin phụ huynh</th>
                                <td><strong>Họ và tên:</strong> {registerAdmissionProfileDTO.FullnameParents}<br/>
                                            <strong>Số điện thoại:</strong> {registerAdmissionProfileDTO.PhoneParents}
                                </td>
                            </tr>
                            <tr>
                                <th>Ngành đăng ký</th>
                               <td>
                                    <strong>Ngành 1:</strong> {major1}<br/>
                                    <strong>Ngành 2:</strong> {major2}
                                </td>
                            </tr>
                        </table>    

                        <p>Chúng tôi sẽ xử lý thông tin này và sẽ liên hệ lại với bạn trong thời gian sớm nhất.</p>
                        <p>Trân trọng,</p>
                        <p>Phòng Tuyển sinh</p>
                    </div>
                </body>
                </html>"
                    };
                    await _emailService.SendEmailByHTMLAsync(emailRequest);
                });
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
