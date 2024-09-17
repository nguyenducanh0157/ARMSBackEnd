using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.MajorRepo;

namespace ARMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MajorController : ControllerBase
    {
        private IMajorRepository _majorRepository;
        private readonly IMapper _mapper;
        public MajorController(IMajorRepository majorRepository, IMapper mapper)
        {
            _majorRepository = majorRepository;
            _mapper = mapper;
        }
        [HttpGet("get-majors")]
        public async Task<IActionResult> GetMajors(string campus)
        {
            try
            {

                List<Major> response = await _majorRepository.GetMajors(campus);

                List<MajorForGuestDTO> responeResult = _mapper.Map<List<MajorForGuestDTO>>(response);
                return Ok(responeResult);

            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
    }
}
