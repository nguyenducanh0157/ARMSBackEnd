//using AutoMapper;
//using Data.DTO;
//using Data.Models;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Service.AdmissionGroupSer;

//namespace ARMS_API.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class AdmissionGroupController : ControllerBase
//    {
//        private IAdmissionGroupService _admissionGroupService;
//        private readonly IMapper _mapper;
//        public AdmissionGroupController(IAdmissionGroupService admissionGroupService, IMapper mapper)
//        {
//            _admissionGroupService = admissionGroupService;
//            _mapper = mapper;
//        }
//        [HttpGet("get-admission-score")]
//        public async Task<IActionResult> GetAdmissionScore(string CampusId)
//        {
//            try
//            {
//                List<AdmissionGroup> response = await _admissionGroupService.GetAdmissionGroupScroreAsync(CampusId);
//                List<AdmissionGroupDTO> responeResult = _mapper.Map<List<AdmissionGroupDTO>>(response);
//                return Ok(responeResult);
//            }
//            catch (Exception)
//            {
//                return BadRequest();
//            }
//        }
//        [HttpGet("get-admission/{id}")]
//        public async Task<IActionResult> GetAdmissionGroupById(int id)
//        {
//            try
//            {
//                AdmissionGroup response = await _admissionGroupService.GetAdmissionGroupByIdAsync(id);
//                AdmissionGroupDTO responeResult = _mapper.Map<AdmissionGroupDTO>(response);
//                return Ok(responeResult);
//            }
//            catch (Exception)
//            {
//                return BadRequest();
//            }
//        }
//        [HttpGet("get-admission-score-academic")]
//        public async Task<IActionResult> GetAdmissionScoreAcademic(string CampusId)
//        {
//            try
//            {
//                List<AdmissionGroup> response = await _admissionGroupService.GetAdmissionGroupScoreAcademicAsync(CampusId);
//                List<AdmissionGroupDTO> responeResult = _mapper.Map<List<AdmissionGroupDTO>>(response);
//                return Ok(responeResult);
//            }
//            catch (Exception)
//            {
//                return BadRequest();
//            }
//        }
//    }
//}
