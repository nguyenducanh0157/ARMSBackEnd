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
using static Google.Apis.Requests.BatchRequest;

namespace ARMS_API.Controllers.AdmissionCouncil
{
    [Route("api/admin-council/[controller]")]
    [ApiController]
    [Authorize(Roles = "AdmissionCouncil")]
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
        public async Task<IActionResult> ListRegisterAdmission(string CampusId, string? Search, int CurrentPage, TypeofStatus? TypeofStatus)
        {
            try
            {
                ResponeModel<AdmissionProfile_AO_DTO> result = new ResponeModel<AdmissionProfile_AO_DTO>();
                result.CurrentPage = CurrentPage;
                result.CampusId = CampusId;
                result.Search = Search;

                List<StudentProfile> response = await _studentProfileService.GetRegisterAdmission(CampusId);
                // Search
                if (!string.IsNullOrEmpty(Search))
                {
                    string searchTerm = _userInput.NormalizeText(Search);
                    response = response
                                .Where(sp => sp != null && (
                                    _userInput.NormalizeText(sp.Fullname ?? "").Contains(searchTerm) ||
                                    _userInput.NormalizeText(sp.FullnameParents ?? "").Contains(searchTerm) ||
                                    _userInput.NormalizeText(sp.CitizenIentificationNumber ?? "").Contains(searchTerm) ||
                                    _userInput.NormalizeText(sp.District ?? "").Contains(searchTerm) ||
                                    _userInput.NormalizeText(sp.EmailStudent ?? "").Contains(searchTerm) ||
                                    _userInput.NormalizeText(sp.Nation ?? "").Contains(searchTerm) ||
                                    _userInput.NormalizeText(sp.Note ?? "").Contains(searchTerm) ||
                                    _userInput.NormalizeText(sp.PhoneParents ?? "").Contains(searchTerm) ||
                                    _userInput.NormalizeText(sp.PhoneStudent ?? "").Contains(searchTerm) ||
                                    _userInput.NormalizeText(sp.SpecificAddress ?? "").Contains(searchTerm) ||
                                    _userInput.NormalizeText(sp.AddressRecipientResults ?? "").Contains(searchTerm) ||
                                    _userInput.NormalizeText(sp.SchoolName ?? "").Contains(searchTerm) ||
                                    _userInput.NormalizeText(sp.Ward ?? "").Contains(searchTerm) ||
                                    _userInput.NormalizeText(sp.CIAddress ?? "").Contains(searchTerm)
                                ))
                                .ToList();
                }
                if (TypeofStatus != null)
                {
                    response = response.Where(x => x.TypeofStatusProfile == TypeofStatus).ToList();
                }

                //mapper

                result.PageCount = (int)Math.Ceiling(response.Count() / (double)result.PageSize);
                var studentProfiles = response
                    .Skip(((int)result.CurrentPage - 1) * (int)result.PageSize)
                    .Take((int)result.PageSize)
                    .ToList();
                List<AdmissionProfile_AO_DTO> studentProfile = _mapper.Map<List<AdmissionProfile_AO_DTO>>(studentProfiles);
                result.Item = studentProfile;
                result.TotalItems = response.Count;
                return Ok(result);
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
        [HttpPut("update-student-register")]
        public async Task<IActionResult> UpdateStudentRegister(AdmissionProfile_AO_DTO AdmissionProfile_DTO)
        {
            try
            {
                StudentProfile responeResult = _mapper.Map<StudentProfile>(AdmissionProfile_DTO);
                await _studentProfileService.UpdateStudentRegister(responeResult);

                return Ok(new ResponseViewModel()
                {
                    Status = true,
                    Message = "Cập nhật thành công!"
                });

            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
        [HttpPut("update-student-register-status")]
        public async Task<IActionResult> UpdateStudentRegisterStatus(AdmissionProfile_UpdateStatus_DTO AdmissionProfile_UpdateStatus_DTO)
        {
            try
            {

                StudentProfile stf = await _studentProfileService.GetStudentProfileBySpIdAsync(AdmissionProfile_UpdateStatus_DTO.SpId);
                if (stf == null)
                {
                    return NotFound(new ResponseViewModel()
                    {
                        Status = false,
                        Message = "Không tìm thấy hồ sơ!"
                    });
                }
                stf.TypeofStatusProfile = AdmissionProfile_UpdateStatus_DTO.TypeofStatusProfile;

                // Save the updated profile
                await _studentProfileService.UpdateStudentRegister(stf);

                return Ok(new ResponseViewModel()
                {
                    Status = true,
                    Message = "Cập nhật thành công!"
                });

            }
            catch (Exception)
            {
                return BadRequest(new ResponseViewModel()
                {
                    Status = false,
                    Message = "Không tìm thấy hồ sơ!"
                });
            }
        }
        
    }
}
