﻿using ARMS_API.Helper;
using ARMS_API.ValidData;
using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Repository.StudentProfileRepo;
using Service.EmailSer;
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
        private readonly IMapper _mapper;
        private ValidRegisterAdmission _validInput;
        private UserInput _userInput;
        private readonly IEmailService _emailService;
        private readonly IMemoryCache _cache;
        private readonly TimeSpan _otpLifetime = TimeSpan.FromMinutes(5);
        private readonly TokenHealper _tokenHealper;
        public RegisterAdmissionController(IStudentProfileService studentProfileService,
            IMapper mapper,
            ValidRegisterAdmission validInput,
            UserInput userInput,
            IEmailService emailService,
            IMemoryCache cache,
            TokenHealper tokenHealper,
            IPayFeeAdmissionService payFeeAdmissionService)
        {
            _studentProfileService = studentProfileService;
            _mapper = mapper;
            _validInput = validInput;
            _userInput = userInput;
            _emailService = emailService;
            _cache = cache;
            _tokenHealper = tokenHealper;
            _payFeeAdmissionService = payFeeAdmissionService;
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
                // Map registerAdmissionProfileDTO sang StudentProfile
                StudentProfile studentProfile = _mapper.Map<StudentProfile>(registerAdmissionProfileDTO);
                studentProfile.TypeofStatusMajor1 = TypeofStatusForMajor.Inprocess;
                studentProfile.TypeofStatusMajor2 = TypeofStatusForMajor.Inprocess;
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
            await _emailService.SendEmailAsync(emailRequest);
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
    }
}
