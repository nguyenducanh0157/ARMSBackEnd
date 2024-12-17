using ARMS_API.ValidData;
using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.MajorSer;
using Service.PayFeeAdmissionSer;

namespace ARMS_API.Controllers.User
{
    [Route("api/user/[controller]")]
    [ApiController]
    [Authorize(Roles = "AdmissionCouncil, AdmissionOfficer, Admin")]
    public class PayFeeController : ControllerBase
    {

        private IPayFeeAdmissionService _payFeeAdmissionService;
        private readonly IMapper _mapper;
        private UserInput _userInput;
        public PayFeeController(IPayFeeAdmissionService payFeeAdmissionService, IMapper mapper, UserInput userInput)
        {
            _payFeeAdmissionService = payFeeAdmissionService;
            _mapper = mapper;
            _userInput = userInput;
        }
        [HttpGet("get-payments")]
        public async Task<IActionResult> GetPayments(string? CampusId, string? Search, int CurrentPage)
        {
            try
            {
                ResponeModel<PayFeeAdmissionDTO_Manage> result = new ResponeModel<PayFeeAdmissionDTO_Manage>();
                result.CurrentPage = CurrentPage;
                result.CampusId = CampusId;
                result.Search = Search;

                List<PayFeeAdmission> response = await _payFeeAdmissionService.GetPayFeeAdmissions(CampusId);
                // Search
                if (!string.IsNullOrEmpty(Search))
                {
                    string searchTerm = _userInput.NormalizeText(Search);
                    response = response
                                .Where(x =>
                                    x != null &&
                                    
                                        _userInput.NormalizeText(x.StudentProfile.Fullname ?? "").Contains(searchTerm)
                                    
                                )
                                .ToList();
                }

                result.PageCount = (int)Math.Ceiling(response.Count() / (double)result.PageSize);
                var pays = response
                    .Skip((result.CurrentPage - 1) * result.PageSize)
                    .Take(result.PageSize)
                    .ToList();

                List<PayFeeAdmissionDTO_Manage> responeResult = _mapper.Map<List<PayFeeAdmissionDTO_Manage>>(pays);
                result.TotalItems = response.Count;
                result.Item = responeResult;

                return Ok(result);

            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
    }
}
