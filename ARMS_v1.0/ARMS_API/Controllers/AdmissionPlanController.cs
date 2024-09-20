using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.AdmissionPlanRepo;
using Repository.MajorRepo;

namespace ARMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdmissionPlanController : ControllerBase
    {
        private IAdmissionPlanRepository _admissionPlanRepository;
        private readonly IMapper _mapper;
        public AdmissionPlanController(IAdmissionPlanRepository admissionPlanRepository, IMapper mapper)
        {
            _admissionPlanRepository = admissionPlanRepository;
            _mapper = mapper;
        }
        [HttpGet("get-admission-plan")]
        public async Task<IActionResult> GetAdmissionPlan(string campus)
        {
            try
            {
                AdmissionPlan response = await _admissionPlanRepository.GetAdmissionPlan(campus);
                AdmissionPlanDTO responeResult = _mapper.Map<AdmissionPlanDTO>(response);
                return Ok(responeResult);
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
    }
}
