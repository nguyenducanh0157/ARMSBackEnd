using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Service.AccountSer;
using Service.AdmissionTimeSer;

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
        public AccountController(IAccountService accountService, IMapper mapper, UserManager<Account> userManager, RoleManager<IdentityRole<Guid>> roleManager, IConfiguration configuration)
        {
            _accountService = accountService;
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
            _mapper = mapper;
        }
        [HttpGet("get-accounts")]
        public async Task<IActionResult> GetAccounts(string CampusId)
        {
            try
            {
                // Lấy danh sách tài khoản
                List<Account> accounts = await _accountService.GetAccounts(CampusId);

                // Lấy vai trò cho từng tài khoản
                var rolesDictionary = new Dictionary<string, string>();
                foreach (var account in accounts)
                {
                    var roles = await _userManager.GetRolesAsync(account);
                    rolesDictionary[account.Id.ToString()] = roles.FirstOrDefault() ?? "No Role"; // Lưu vai trò vào dictionary
                }

                // Ánh xạ Account -> Account_DTO
                var accountDTOs = _mapper.Map<List<Account_DTO>>(accounts);

                // Gán RoleName từ dictionary
                foreach (var dto in accountDTOs)
                {
                    if (rolesDictionary.TryGetValue(dto.Id.ToString(), out var roleName))
                    {
                        dto.RoleName = roleName;
                    }
                }

                return Ok(accountDTOs);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
