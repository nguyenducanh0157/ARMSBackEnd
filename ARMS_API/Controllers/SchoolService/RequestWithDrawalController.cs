using ARMS_API.ValidData;
using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.AccountSer;
using Service.RequestChangeMajorSer;

namespace ARMS_API.Controllers.SchoolService
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles = "SchoolService")]
    public class RequestWithDrawalController : ControllerBase
    {
        private IRequestService _request;
        private IAccountService _accountService;
        private readonly IMapper _mapper;
        private UserInput _userInput;
        public RequestWithDrawalController(IRequestService requestChangeMajorService, IMapper mapper, IAccountService accountService, UserInput userInput)
        {
            _request = requestChangeMajorService;
            _mapper = mapper;
            _accountService = accountService;
            _userInput = userInput;
        }
        [HttpGet("get-request-withdrawal")]
        public async Task<IActionResult> GetRequestChangeMajor(string CampusId, string? Search, int CurrentPage, TypeofRequestChangeMajor? Status)
        {
            try
            {
                ResponeModel<RequestChangeMajor_SS_DTO> result = new ResponeModel<RequestChangeMajor_SS_DTO>
                {
                    CurrentPage = CurrentPage,
                    CampusId = CampusId,
                    Search = Search
                };

                List<Request> response = await _request.GetRequestWithDrawal(CampusId);

                // Apply Search filter
                if (!string.IsNullOrEmpty(Search))
                {
                    string searchTerm = _userInput.NormalizeText(Search);
                    response = response
                                .Where(request =>
                                    request != null &&
                                    !string.IsNullOrEmpty(request.Description) &&
                                    !string.IsNullOrEmpty(request.MajorNew) &&
                                    !string.IsNullOrEmpty(request.MajorN?.MajorName) &&
                                    !string.IsNullOrEmpty(request.Account?.Fullname) &&
                                    !string.IsNullOrEmpty(request.Account?.StudentCode) &&
                                    !string.IsNullOrEmpty(request.MajorO?.MajorName) &&
                                    (_userInput.NormalizeText(request.Description).Contains(searchTerm) ||
                                     _userInput.NormalizeText(request.MajorNew).Contains(searchTerm) ||
                                     _userInput.NormalizeText(request.Account.Fullname).Contains(searchTerm) ||
                                     _userInput.NormalizeText(request.Account.StudentCode).Contains(searchTerm) ||
                                     _userInput.NormalizeText(request.MajorO.MajorName).Contains(searchTerm) ||
                                     _userInput.NormalizeText(request.MajorN.MajorName).Contains(searchTerm)
                                    )
                                )
                                .ToList();
                }

                // Apply Status filter
                if (Status.HasValue)
                {
                    response = response
                                .Where(request => request != null && request.Status == Status)
                                .ToList();
                }

                // Pagination
                result.PageCount = (int)Math.Ceiling(response.Count / (double)result.PageSize);
                var majors = response
                    .Skip((CurrentPage - 1) * result.PageSize)
                    .Take(result.PageSize)
                    .ToList();

                // Map results to DTOs
                result.Item = _mapper.Map<List<RequestChangeMajor_SS_DTO>>(majors);
                result.TotalItems = response.Count;

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
        [HttpPut("accept-request-withdrawal")]
        public async Task<IActionResult> AddRequest(int RequestID, [FromBody] Reply_Request_DTO Reply_Request_DTO)
        {
            try
            {

                Request request = await _request.GetRequestByID(RequestID);
                request.Status = Reply_Request_DTO.Status;
                request.Reply = Reply_Request_DTO.Reply;
                //add new
                await _request.UpdateRequest(request);
                return Ok(new ResponseViewModel()
                {
                    Status = true,
                    Message = "Chỉnh sửa thành công!"
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseViewModel()
                {
                    Status = false,
                    Message = ex.Message
                });
            }
        }
    }
}
