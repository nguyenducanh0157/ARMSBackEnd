using ARMS_API.ValidData;
using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Service.AccountSer;
using Service.AdmissionTimeSer;
using static Google.Apis.Requests.BatchRequest;

namespace ARMS_API.Controllers.Admin
{
    [Route("api/[controller]")]
    [ApiController]
   // [Authorize(Roles = "Admin")]
    public class AccountController : ControllerBase
    {
        private IAccountService _accountService;
        private readonly UserManager<Account> _userManager;
        private readonly RoleManager<IdentityRole<Guid>> _roleManager;
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;
        private UserInput _userInput;
        public AccountController(IAccountService accountService, IMapper mapper, UserManager<Account> userManager, RoleManager<IdentityRole<Guid>> roleManager, IConfiguration configuration, UserInput userInput)
        {
            _accountService = accountService;
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
            _mapper = mapper;
            _userInput = userInput;
        }
        [HttpGet("get-accounts")]
        public async Task<IActionResult> GetAccounts(string? CampusId, string? Search, int CurrentPage, string? role)
        {
            try
            {
                ResponeModel<Account_DTO> result = new ResponeModel<Account_DTO>();
                result.CurrentPage = CurrentPage;
                result.CampusId = CampusId;
                result.Search = Search;

                // Lấy danh sách tài khoản
                List<Account> accounts = await _accountService.GetAccounts(CampusId);
                // Search
                if (!string.IsNullOrEmpty(Search))
                {
                    string searchTerm = _userInput.NormalizeText(Search);
                    accounts = accounts
                    .Where(account =>
                    {
                                    string fullname = _userInput.NormalizeText(account?.Fullname ?? "");
                                    string phone = _userInput.NormalizeText(account?.Phone ?? "");
                                    string major = _userInput.NormalizeText(account?.Major?.MajorName ?? "");
                                    return fullname.Contains(searchTerm) || phone.Contains(searchTerm)|| major.Contains(searchTerm);
                                })
                                .ToList();
                }
                // Lấy vai trò cho từng tài khoản
                var rolesDictionary = new Dictionary<string, string>();
                foreach (var account in accounts)
                {
                    var roles = await _userManager.GetRolesAsync(account);
                    rolesDictionary[account.Id.ToString()] = roles.FirstOrDefault() ?? "No Role";
                }
                // Lọc theo vai trò nếu có tham số 'role'
                if (!string.IsNullOrEmpty(role))
                {
                    accounts = accounts
                        .Where(account =>
                        {
                            if (rolesDictionary.TryGetValue(account.Id.ToString(), out var roleName))
                            {
                                return roleName.Equals(role, StringComparison.OrdinalIgnoreCase);
                            }
                            return false;
                        })
                        .ToList();
                }

                
                // Paging
                result.PageCount = (int)Math.Ceiling(accounts.Count() / (double)result.PageSize);
                var accs = accounts
                    .Skip(((int)result.CurrentPage - 1) * (int)result.PageSize)
                    .Take((int)result.PageSize)
                    .ToList();
                var accountDTOs = _mapper.Map<List<Account_DTO>>(accs);
            
                foreach (var dto in accountDTOs)
                {
                    if (rolesDictionary.TryGetValue(dto.Id.ToString(), out var roleName))
                    {
                        dto.RoleName = roleName;
                    }
                }
                result.Item = accountDTOs;
                result.TotalItems = accounts.Count;

                return Ok(result);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
