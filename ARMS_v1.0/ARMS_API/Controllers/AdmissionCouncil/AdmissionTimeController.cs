using ARMS_API.ValidData;
using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.AdmissionTimeSer;
using Service.MajorSer;

namespace ARMS_API.Controllers.AdmissionCouncil
{
    [Route("api/admission-council/[controller]")]
    [ApiController]
    [Authorize(Roles = "AdmissionCouncil")]
    public class AdmissionTimeController : ControllerBase
    {
        private IAdmissionTimeService _admissionTimeService;
        private readonly IMapper _mapper;
        public AdmissionTimeController(IAdmissionTimeService admissionTimeService, IMapper mapper)
        {
            _admissionTimeService = admissionTimeService;
            _mapper = mapper;
        }
        [HttpGet("get-admission-time")]
        public async Task<IActionResult> GetAdmissionTimes(string CampusId, int year)
        {
            try
            {
                List<AdmissionTime> response = await _admissionTimeService.GetAdmissionTimes(CampusId,year);
                List<AdmissionTime_Admission_DTO> responeResult = _mapper.Map<List<AdmissionTime_Admission_DTO>>(response);
                return Ok(responeResult);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
