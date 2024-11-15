using ARMS_API.ValidData;
using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.MajorSer;

namespace ARMS_API.Controllers.AdmissionCouncil
{
    [Route("api/admission-council/[controller]")]
    [ApiController]
    //[Authorize(Roles = "AdmissionCouncil")]
    public class MajorController : ControllerBase
    {

        private IMajorService _majorService;
        private ValidMajor _validMajor;
        private readonly IMapper _mapper;
        private UserInput _userInput;
        public MajorController(IMajorService majorService, IMapper mapper, ValidMajor validMajor, UserInput userInput)
        {
            _majorService = majorService;
            _mapper = mapper;
            _validMajor = validMajor;
            _userInput = userInput;
        }
        [HttpPut("update-major")]
        public async Task<IActionResult> UpdateMajor(Major_Admission_DTO MajorDTO)
        {
            try
            {
                Major major = _mapper.Map<Major>(MajorDTO);
                await _majorService.UpdateMajorAdmission(major);
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
        [HttpGet("get-majors")]
        public async Task<IActionResult> GetMajors(string CampusId, string? Search, int CurrentPage, bool? isVocationalSchool)
        {
            try
            {
                //respone data
                ResponeModel<Major_Admission_Council_DTO> result = new ResponeModel<Major_Admission_Council_DTO>();
                result.CurrentPage = CurrentPage;
                result.CampusId = CampusId;
                result.Search = Search;

                List<Major> response = await _majorService.GetMajorsAdmin(CampusId);
                if (!string.IsNullOrEmpty(Search))
                {
                    string searchTerm = _userInput.NormalizeText(Search);
                    response = response
                                .Where(major =>
                                {
                                    string MajorName = _userInput.NormalizeText(major?.MajorName ?? "");
                                    string MajorCode = _userInput.NormalizeText(major?.MajorCode ?? "");
                                    string Description = _userInput.NormalizeText(major?.Description ?? "");
                                    string TimeStudy = _userInput.NormalizeText(major?.TimeStudy ?? "");
                                    return MajorName.Contains(searchTerm) 
                                    || MajorCode.Contains(searchTerm) 
                                    || Description.Contains(searchTerm)
                                    || TimeStudy.Contains(searchTerm);
                                })
                                .ToList();
                }

                if (isVocationalSchool != null)
                {
                    response = response
                                .Where(major => major.isVocationalSchool == isVocationalSchool)
                                .ToList();
                };
                result.PageCount = (int)Math.Ceiling(response.Count() / (double)result.PageSize);
                var majors = response
                    .Skip(((int)result.CurrentPage - 1) * (int)result.PageSize)
                    .Take((int)result.PageSize)
                    .ToList();

                List<Major_Admission_Council_DTO> responeResult = _mapper.Map<List<Major_Admission_Council_DTO>>(majors);
                result.Item = responeResult;
                result.TotalItems = response.Count;
                return Ok(result);

            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
        [HttpGet("get-major-details")]
        public async Task<IActionResult> GetMajorDetail(string MajorId)
        {
            try
            {

                Major response = await _majorService.GetMajorDetail(MajorId);
                Major_Admission_Council_DTO responeResult = _mapper.Map<Major_Admission_Council_DTO>(response);
                return Ok(responeResult);

            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
    }
}
