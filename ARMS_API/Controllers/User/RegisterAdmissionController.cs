using ARMS_API.ValidData;
using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.StudentProfileRepo;
using Service.AdmissionInformationSer;
using Service.EmailSer;
using Service.MajorSer;
using Service.StudentProfileServ;
using System.Collections.Generic;
using System.Security.Cryptography;
using static Google.Apis.Requests.BatchRequest;

namespace ARMS_API.Controllers.User
{
    [Route("api/user/[controller]")]
    [ApiController]
    [Authorize(Roles = "AdmissionCouncil, AdmissionOfficer, Admin, Student")]
    public class RegisterAdmissionController : ControllerBase
    {
        private IStudentProfileService _studentProfileService;
        private IMajorService _majorService;
        public RegisterAdmissionController(
            IStudentProfileService studentProfileService,
            IMajorService majorService
        )
        {
            _studentProfileService = studentProfileService;
            _majorService = majorService;
        }
        [HttpGet("count-register")]
        public async Task<IActionResult> CountRegister(string campus)
        {
            try
            {
                int count = await _studentProfileService.CountAdmission(campus);
                return Ok(count);
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
        [HttpGet("count-register-today")]
        public async Task<IActionResult> CountRegisterToday(string campus)
        {
            try
            {
                int count = await _studentProfileService.CountAdmissionsToday(campus);
                return Ok(count);
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
        [HttpGet("report-admission")]
        public async Task<IActionResult> ReportAdmission(string campus)
        {
            try
            {
                List<object> objs = await _majorService.ReportAdmission(campus);
                return Ok(objs);
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
        [HttpGet("report-register-admission")]
        public async Task<IActionResult> ReportRegisterAdmission(string campus)
        {
            try
            {
                List<object> objs = await _majorService.ReportRegisterAdmission(campus);
                return Ok(objs);
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
        [HttpGet("calculate-pass-rate")]
        public async Task<IActionResult> CalculatePassRate(string campus)
        {
            try
            {
                int count = await _studentProfileService.CalculatePassRate(campus);
                return Ok(count);
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
        [HttpGet("count-register-done")]
        public async Task<IActionResult> CountRegisterDone(string campus)
        {
            try
            {
                int count = await _studentProfileService.CountRegisterDone(campus);
                return Ok(count);
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
        [HttpGet("find-most-submitted-major")]
        public async Task<IActionResult> FindMostSubmittedMajor(string campus)
        {
            try
            {
                var major = await _studentProfileService.FindMostSubmittedMajor(campus);
                return Ok(major);
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
