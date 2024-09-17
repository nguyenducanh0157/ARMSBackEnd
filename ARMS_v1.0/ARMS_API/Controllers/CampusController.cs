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
    }
}
