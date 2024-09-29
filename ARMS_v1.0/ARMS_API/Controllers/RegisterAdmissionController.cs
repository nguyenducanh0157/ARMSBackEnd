﻿using ARMS_API.ValidData;
using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.StudentConsultationRepo;
using Repository.StudentProfileRepo;

namespace ARMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterAdmissionController : ControllerBase
    {
        private IStudentProfileRepository _studentProfileRepository;
        private readonly IMapper _mapper;
        private ValidRegisterAdmission _validInput;
        public RegisterAdmissionController(IStudentProfileRepository studentProfileRepository, IMapper mapper, ValidRegisterAdmission validInput)
        {
            _studentProfileRepository = studentProfileRepository;
            _mapper = mapper;
            _validInput = validInput;
        }
        [HttpPost("add-register-admission")]
        public async Task<IActionResult> AddRegisterAdmission([FromBody] RegisterAdmissionProfileDTO registerAdmissionProfileDTO)
        {
            try
            {
                //check data
                _validInput.InputAddRegisterAdmission(registerAdmissionProfileDTO);
                //mapper
                StudentProfile studentProfile = _mapper.Map<StudentProfile>(registerAdmissionProfileDTO);
                // vnpay here

                //add new
                await _studentProfileRepository.AddStudentProfile(studentProfile);
                return Ok(new ResponseViewModel()
                {
                    Status = true,
                    Message = "Đăng ký thành công!"
                });
            }
            catch (Exception ex)
            {
                return Ok(new ResponseViewModel()
                {
                    Status = false,
                    Message = ex.Message
                });
            }
        }
    }
}
