using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Org.BouncyCastle.Asn1.Ocsp;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ARMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly UserManager<Account> _userManager;
        private readonly RoleManager<IdentityRole<Guid>> _roleManager;
        private readonly IConfiguration _configuration;
        public AuthenticationController(UserManager<Account> userManager, RoleManager<IdentityRole<Guid>> roleManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
        }
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginDTO model)
        {
            if (model == null || model.email == null || model.CampusId == null)
            {
                throw new Exception("Không nhận được thông tin người dùng");
            }
            //var user = await _userManager.FindByEmailAsync(model.email);
            var user = await _userManager.Users
                                    .Where(user => user.CampusId == model.CampusId && user.Email == model.email && user.isAccountActive == true)
                                    .FirstOrDefaultAsync();
            if (user == null)
            {
                throw new Exception("Tài khoản của bạn không tồn tại trong campus hiện tại");
            }

            //login by password
            if (model.password != null)
            {
                if (user != null && !await _userManager.CheckPasswordAsync(user, model.password))
                {
                    return Unauthorized();
                }
            }
            var userRoles = await _userManager.GetRolesAsync(user);

            var authClaims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, user.Fullname),
                        new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    };

            foreach (var userRole in userRoles)
            {
                authClaims.Add(new Claim(ClaimTypes.Role, userRole));
            }

            if (!String.IsNullOrEmpty(user.AvatarURL))
            {
                authClaims.Add(new Claim("AvatarUrl", user.AvatarURL));
            }
            var Bear = GetToken(authClaims);

            ResponseLogin respone = new ResponseLogin();
            respone.Bear = new JwtSecurityTokenHandler().WriteToken(Bear);
            respone.Expiration = Bear.ValidTo;
            return Ok(respone);
        }
        [HttpPost("login-by-email")]
        [AllowAnonymous]
        public async Task<IActionResult> AccessByEmail([FromBody] EmailLoginViewModel request)
        {
            ResponseViewModel response = new ResponseViewModel();
            try
            {
                // Check if model state is valid or not
                if (request == null || request.Email == null || request.CampusId == null)
                {
                    throw new Exception("Không nhận được thông tin người dùng");
                }

                string email = request.Email;
                string campusId = request.CampusId;
                var user = await _userManager.Users
                                    .Where(user => user.CampusId == campusId && user.Email == email && user.isAccountActive==true)
                                    .FirstOrDefaultAsync();


                if (user == null)
                    {
                        throw new Exception("Tài khoản của bạn không tồn tại trong campus hiện tại");
                    }

                var roles = await _userManager.GetRolesAsync(user);

                List<Claim> claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),

            };

                foreach (string role in roles)
                {
                    claims.Add(new Claim(ClaimTypes.Role, role));
                }

                if (!String.IsNullOrEmpty(user.AvatarURL))
                {
                    claims.Add(new Claim("AvatarUrl", user.AvatarURL));
                }

                return Ok(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return Ok(new ResponseViewModel() { Status = false, Message = ex.Message });
            }
        }
        private JwtSecurityToken GetToken(List<Claim> authClaims)
        {
            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));
            var expirationTimeUtc = DateTime.UtcNow.AddHours(72);

            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudience"],
                expires: DateTime.SpecifyKind(expirationTimeUtc, DateTimeKind.Utc),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
            );

            return token;
        }

    }
}
