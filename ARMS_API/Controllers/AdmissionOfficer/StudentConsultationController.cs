using ARMS_API.ValidData;
using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.StudentConsultationSer;

namespace ARMS_API.Controllers.AdmissionOfficer
{
    [Route("api/admin-officer/[controller]")]

    [ApiController]
    [Authorize(Roles = "AdminOfficer")]
    public class StudentConsultationController : ControllerBase
    {
        private IStudentConsultationService _studentConsultationService;
        private readonly IMapper _mapper;
        private UserInput _userInput;
        private ValidStudentConsultation _validInput;
        public StudentConsultationController(IStudentConsultationService studentConsultationService, IMapper mapper, ValidStudentConsultation validInput, UserInput userInput)
        {
            _studentConsultationService = studentConsultationService;
            _mapper = mapper;
            _validInput = validInput;
            _userInput = userInput;
        }
        [HttpGet("get-list-student-consultation")]
        public async Task<IActionResult> GetStudentConsultation(string campus, string? search, int currentPage, bool? isVocationalSchool)
        {
            try
            {
                ResponeModel<StudentConsultation_AO_DTO> result = new ResponeModel<StudentConsultation_AO_DTO>();
                result.CurrentPage = currentPage;
                result.CampusId = campus;
                result.Search = search;

                List<StudentConsultation> response = await _studentConsultationService.GetListStudentConsultation(campus);
                // Search
                if (!string.IsNullOrEmpty(search))
                {
                    string searchTerm = _userInput.NormalizeText(search);
                    response = response
                                .Where(sc =>
                                    _userInput.NormalizeText(sc.FullName ?? "").Contains(searchTerm) ||
                                    _userInput.NormalizeText(sc.Email ?? "").Contains(searchTerm) ||
                                    _userInput.NormalizeText(sc.Notes ?? "").Contains(searchTerm) ||
                                    _userInput.NormalizeText(sc.LinkFB ?? "").Contains(searchTerm) ||
                                    _userInput.NormalizeText(sc.Major?.MajorName ?? "").Contains(searchTerm)
                                )
                                .ToList();
                }

                if (isVocationalSchool != null)
                {
                    response = response.Where(x => x.Major.isVocationalSchool == isVocationalSchool).ToList();
                }

                // Paging
                result.PageCount = (int)Math.Ceiling(response.Count() / (double)result.PageSize);
                var blogs = response
                    .Skip(((int)result.CurrentPage - 1) * (int)result.PageSize)
                    .Take((int)result.PageSize)
                    .ToList();

                // Map to StudentConsultation_AO_DTO

                List<StudentConsultation_AO_DTO> responeResult = _mapper.Map<List<StudentConsultation_AO_DTO>>(response);
                result.Item = responeResult;

                
                return Ok(responeResult);

            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
        [HttpPut("update-student-consultation")]
        public async Task<IActionResult> UpdateStudentConsultation(StudentConsultation_AO_DTO StudentConsultationDTO)
        {
            try
            {
                _validInput.UpdateStudentConsultation(StudentConsultationDTO);
                StudentConsultation responeResult = _mapper.Map<StudentConsultation>(StudentConsultationDTO);
                await _studentConsultationService.UpdateStudentConsultation(responeResult);

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
    }
}
