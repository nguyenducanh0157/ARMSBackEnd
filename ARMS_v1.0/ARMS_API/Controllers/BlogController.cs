using ARMS_API.ValidData;
using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.BlogRepo;
using Repository.CampusRepo;
using System.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ARMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private IBlogRepository _blogRepository;
        private UserInput _userInput;
        private readonly IMapper _mapper;
        public BlogController(IBlogRepository blogRepository, IMapper mapper, UserInput userInput)
        {
            _blogRepository = blogRepository;
            _userInput = userInput;
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
        [HttpGet("get-blogs")]
        public async Task<IActionResult> GetBlogs(string? CampusId, string? Search, int CurrentPage, int PageSize)
        {
            try
            {
                //respone data
                ResponeModel<BlogDTO> result = new ResponeModel<BlogDTO>();
                result.CurrentPage = CurrentPage;
                result.PageSize = PageSize;
                result.CampusId = CampusId; 
                result.Search = Search;

                List<Blog> response = await _blogRepository.GetBlogs(CampusId);

                // Search
                if (!string.IsNullOrEmpty(Search))
                {
                    string searchTerm = _userInput.NormalizeText(Search);
                    response = response
                                .Where(blog =>
                                    blog != null &&
                                    !string.IsNullOrEmpty(blog.Title) &&
                                    !string.IsNullOrEmpty(blog.Description) &&
                                    (_userInput.NormalizeText(blog.Title).Contains(searchTerm) ||
                                     _userInput.NormalizeText(blog.Description).Contains(searchTerm) ||
                                     blog.BlogDetails != null &&
                                     blog.BlogDetails.Any(detail =>
                                         _userInput.NormalizeText(detail.Description).Contains(searchTerm))
                                    )
                                )
                                .ToList();
                                    };

                // Paging
                result.PageCount = (int)Math.Ceiling(response.Count() / (double)result.PageSize);
                var blogs = response
                    .Skip(((int)result.CurrentPage - 1) * (int)result.PageSize)
                    .Take((int)result.PageSize)
                    .ToList();

                // Map to BlogDTO
                List<BlogDTO> responseResult = _mapper.Map<List<BlogDTO>>(blogs);
                result.Item = responseResult;

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("get-blog")]
        public async Task<IActionResult> GetBlog(int BlogId)
        {
            try
            {
                Blog response = await _blogRepository.GetBlog(BlogId);
                if (response == null || BlogId == 0) return NotFound();
                BlogDTO responeResult = _mapper.Map<BlogDTO>(response);
                return Ok(responeResult);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPost("add-comment")]
        public async Task<IActionResult> AddComment(int BlogId, CommentDTO commentDTO)
        {
            try
            {
                Comment comment = _mapper.Map<Comment>(commentDTO);
                comment.BlogId = BlogId;
                Comment newComment = await _blogRepository.AddComment(comment);
                CommentDTO respone  = _mapper.Map<CommentDTO>(newComment);
                return Ok(respone);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPut("update-comment")]
        public async Task<IActionResult> UpdateComment(int CommentId, string Content, string FacebookUserId)
        {
            try
            {
                if (CommentId == 0) return NotFound();
                //check user
                bool check = await _blogRepository.CheckFBID(FacebookUserId);
                if (!check) { return BadRequest(); }
                //get comment
                var comment = await _blogRepository.GetComment(CommentId);
                if (comment==null) return NotFound();
                comment.Content = Content;
                //update
                Comment updateComment = await _blogRepository.UpdateComment(comment);
                CommentDTO resspone = _mapper.Map<CommentDTO>(updateComment);
                return Ok(resspone);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpDelete("delete-comment")]
        public async Task<IActionResult> DeleteComment(int CommentId, string FacebookUserId)
        {
            try
            {
                if (CommentId == 0) return NotFound();
                //check user
                bool check = await _blogRepository.CheckFBID(FacebookUserId);
                if (!check) { return BadRequest(); }
                //get comment
                var comment = await _blogRepository.GetComment(CommentId);
                if (comment==null) return NotFound();
                //delete comment
                await _blogRepository.DeleteComment(CommentId);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpGet("get-top5blogs")]
        public async Task<IActionResult> GetBlogs(string? CampusId, int BlogCategoryId)
        {
            try
            {

                List<Blog> response = await _blogRepository.GetBlogs(CampusId);
                response = response
                    .Where(x => x.BlogCategoryId == BlogCategoryId)
                    .OrderByDescending(x => x.DateCreate)
                    .Take(5)
                    .ToList();
                // Map to BlogDTO
                List<BlogDTO> responseResult = _mapper.Map<List<BlogDTO>>(response);
                return Ok(responseResult);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
