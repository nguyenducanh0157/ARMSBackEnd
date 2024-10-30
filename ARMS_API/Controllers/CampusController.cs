using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.CampusSer;

namespace ARMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampusController : ControllerBase
    {
        private ICampusService _campusService;
        private readonly IMapper _mapper;
        public CampusController(ICampusService campusService, IMapper mapper)
        {
            _campusService = campusService;
            _mapper = mapper;
        }
        [HttpGet("count-campus")]
        public async Task<IActionResult> CountCampus()
        {
            try
            {
                int response = await _campusService.CountCampus();
                return Ok(response);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpGet("get-campuses")]
        public async Task<IActionResult> GetCampuses()
        {
            try
            {
                List<Campus> response = await _campusService.GetCampuses();
                List<CampusDTO> responeResult = _mapper.Map<List<CampusDTO>>(response);
                return Ok(responeResult);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpGet("get-sliders")]
        public async Task<IActionResult> GetSliders(string campusId)
        {
            try
            {
                List<Slider> response = await _campusService.GetSliders(campusId);
                List<SliderDTO> responeResult = _mapper.Map<List<SliderDTO>>(response);
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
                Campus response = await _campusService.GetCampus(campusId);
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
                Campus response = await _campusService.GetCampus(campusId);
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
                Campus response = await _campusService.GetCampus(campusId);
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
                Campus response = await _campusService.GetCampus(campusId);
                return Ok(response.TrainingMotto);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

    }
}
