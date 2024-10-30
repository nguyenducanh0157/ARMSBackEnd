using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.AdmissionTimeSer;

namespace ARMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
                List<AdmissionTime> response = await _admissionTimeService.GetAdmissionTimes(CampusId, year);
                List<AdmissionTimeDTO> responeResult = _mapper.Map<List<AdmissionTimeDTO>>(response);
                return Ok(responeResult);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
