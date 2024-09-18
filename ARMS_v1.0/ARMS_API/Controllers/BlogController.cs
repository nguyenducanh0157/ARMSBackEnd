using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.BlogRepo;
using Repository.CampusRepo;

namespace ARMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private IBlogRepository _blogRepository;
        private readonly IMapper _mapper;
        public BlogController(IBlogRepository blogRepository, IMapper mapper)
        {
            _blogRepository = blogRepository;
            _mapper = mapper;
        }
        [HttpGet("get-blogcategories")]
        public async Task<IActionResult> GetBlogCategories(string CampusId)
        {
            try
            {
                List<BlogCategory> response = await _blogRepository.GetBlogCategories(CampusId);
                List<BlogCategoryDTO> responeResult = _mapper.Map<List<BlogCategoryDTO>>(response);
                return Ok(responeResult);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
