using ARMS_API.ValidData;
using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.StudentProfileRepo;
using Service.StudentProfileServ;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace ARMS_API.Controllers.AdmissionOfficer
{
    [Route("api/admin-officer/[controller]")]
    [ApiController]
    //[Authorize(Roles = "AdminOfficer")]
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

        [HttpGet("list-register-admission")]
        public async Task<IActionResult> ListRegisterAdmission(string campus)
        {
            try
            {
                List<StudentProfile> stf = await _studentProfileService.GetRegisterAdmission(campus);
                //mapper
                List<RegisterAdmissionProfileDTO> studentProfile = _mapper.Map<List<RegisterAdmissionProfileDTO>>(stf);
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
        [HttpGet("get-register-admission/{id}")]
        public async Task<IActionResult> GetRegisterAdmission(string id)
        {
            try
            {
                Guid parseId = Guid.Parse(id);
                StudentProfile stf = await _studentProfileService.GetStudentProfileBySpIdAsync(parseId);
                //mapper
                AdmissionProfile_AO_DTO studentProfile = _mapper.Map<AdmissionProfile_AO_DTO>(stf);
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
        //[HttpPut("update-student-consultation")]
        //public async Task<IActionResult> UpdateStudentConsultation(StudentConsultation_AO_DTO StudentConsultationDTO)
        //{
        //    try
        //    {
        //        _validInput.UpdateStudentConsultation(StudentConsultationDTO);
        //        StudentConsultation responeResult = _mapper.Map<StudentConsultation>(StudentConsultationDTO);
        //        await _studentConsultationService.UpdateStudentConsultation(responeResult);

        //        return Ok(new ResponseViewModel()
        //        {
        //            Status = true,
        //            Message = "Cập nhật thành công!"
        //        });

        //    }
        //    catch (Exception)
        //    {

        //        return BadRequest();
        //    }
        //}
    }
}
