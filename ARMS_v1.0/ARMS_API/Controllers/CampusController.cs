using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.CampusRepo;

namespace ARMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampusController : ControllerBase
    {
        private ICampusRepository _campusRepository;
        private readonly IMapper _mapper;
        public CampusController(ICampusRepository campusRepository, IMapper mapper)
        {
            _campusRepository = campusRepository;
            _mapper = mapper;
        }
        [HttpGet("count-campus")]
        public async Task<IActionResult> CountCampus()
        {
            try
            {
                int response = await _campusRepository.CountCampus();
                return Ok(response);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpGet("get-campus")]
        public async Task<IActionResult> GetCampuses()
        {
            try
            {
                List<Campus> response = await _campusRepository.GetCampuses();
                List<CampusDTO> responeResult = _mapper.Map<List<CampusDTO>>(response);
                return Ok(responeResult);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpGet("get-banners")]
        public async Task<IActionResult> GetBanners(string campusId)
        {
            try
            {
                List<Banner> response = await _campusRepository.GetBanners(campusId);
                List<BannerDTO> responeResult = _mapper.Map<List<BannerDTO>>(response);
                return Ok(responeResult);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpGet("get-history")]
        public async Task<IActionResult> GetHistory(string campusId)
        {
            try
            {
                IntroduceCampus response = await _campusRepository.GetIntroduce(campusId);
                return Ok(response.History);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpGet("get-achievements")]
        public async Task<IActionResult> GetAchievements(string campusId)
        {
            try
            {
                IntroduceCampus response = await _campusRepository.GetIntroduce(campusId);
                return Ok(response.Achievements);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpGet("get-whychooseus")]
        public async Task<IActionResult> GetWhyChooseUs(string campusId)
        {
            try
            {
                IntroduceCampus response = await _campusRepository.GetIntroduce(campusId);
                return Ok(response.WhyChooseUs);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpGet("get-trainingmotto")]
        public async Task<IActionResult> GetTrainingMotto(string campusId)
        {
            try
            {
                IntroduceCampus response = await _campusRepository.GetIntroduce(campusId);
                return Ok(response.TrainingMotto);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpGet("get-alumi")]
        public async Task<IActionResult> GetAlumiStudents()
        {
            try
            {
                List<AlumiStudent> response = await _campusRepository.GetAlumiStudents();
                List<AlumiStudentDTO> responeResult = _mapper.Map<List<AlumiStudentDTO>>(response);
                return Ok(responeResult);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

    }
}
