using ARMS_API.Helper;
using Data.DTO;
using Data.Models;
using FirebaseAdmin.Auth;
using Google.Apis.Auth;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.IdentityModel.Tokens;
using Org.BouncyCastle.Asn1.Ocsp;
using Service;
using Service.EmailSer;
using System.Data;
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
        private readonly FirebaseService _firebaseService;
        private readonly SignInManager<Account> _signInManager;
        private readonly IEmailService _emailService;
        private readonly IMemoryCache _cache;
        private readonly TokenHealper _tokenHealper;
        private readonly TimeSpan _otpLifetime = TimeSpan.FromMinutes(5);
        public AuthenticationController(UserManager<Account> userManager,TokenHealper tokenHealper, IEmailService emailService, IMemoryCache cache, RoleManager<IdentityRole<Guid>> roleManager, IConfiguration configuration, FirebaseService firebaseService, SignInManager<Account> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
            _firebaseService = firebaseService;
            _signInManager = signInManager;
            _emailService = emailService;
            _cache = cache;
            _tokenHealper = tokenHealper;
        }
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginDTO model)
        {
            try
            {
                if (model == null || model.username == null || model.CampusId == null)
                {
                    throw new Exception("Không nhận được thông tin người dùng");
                }
                //var user = await _userManager.FindByEmailAsync(model.email);
                var user = await _userManager.Users
                                        .Where(user => user.CampusId == model.CampusId && user.UserName == model.username && user.isAccountActive == true)
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
                var role = userRoles.FirstOrDefault();
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
                respone.CampusId = model.CampusId;
                respone.Role = role;
                return Ok(respone);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseViewModel
                {
                    Status = false,
                    Message = "Đã xảy ra lỗi trong quá trình xử lý"
                });
            }
        }

        [HttpPost("gg/login-with-google")]
        [AllowAnonymous]
        public async Task<IActionResult> LoginWithGoogle([FromBody] GGLoginViewModel GGLoginViewModel)
        {
            try
            {
                var payload = await VerifyGoogleTokenWithFirebase(GGLoginViewModel.idToken);
                if (payload == null)
                {
                    return Unauthorized(new ResponseViewModel
                    {
                        Status = false,
                        Message = "Token không hợp lệ"
                    });
                }

                var uid = payload.Uid;
                var userRecord = await FirebaseAuth.DefaultInstance.GetUserAsync(uid);
                var email = userRecord.Email;
                // Bước 2: Kiểm tra email trong cơ sở dữ liệu
                var user = await _userManager.Users
                    .Where(u => u.Email == email && u.isAccountActive)
                    .FirstOrDefaultAsync();

                if (user == null)
                {
                    return Unauthorized(new ResponseViewModel
                    {
                        Status = false,
                        Message = "Email không tồn tại trong hệ thống hoặc tài khoản đã bị vô hiệu hóa."
                    });
                }

                // Bước 3: Tạo JWT Token
                var userRoles = await _userManager.GetRolesAsync(user);
                var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.Fullname),
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                };

                foreach (var role in userRoles)
                {
                    authClaims.Add(new Claim(ClaimTypes.Role, role));
                }

                var token = GetToken(authClaims);

                return Ok(new ResponseLogin
                {
                    Bear = new JwtSecurityTokenHandler().WriteToken(token),
                    Expiration = token.ValidTo,
                    Role = userRoles.FirstOrDefault()
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseViewModel
                {
                    Status = false,
                    Message = "Đã xảy ra lỗi trong quá trình xử lý"
                });
            }
        }
        [HttpPost("change-password")]
        [Authorize]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var user = await _userManager.GetUserAsync(User);
                if (user == null)
                    return Unauthorized("User not found");

                var result = await _userManager.ChangePasswordAsync(user, model.OldPassword, model.NewPassword);

                if (!result.Succeeded)
                    return BadRequest(result.Errors);

                await _signInManager.RefreshSignInAsync(user);

                return Ok(new ResponseViewModel
                {
                    Status = false,
                    Message = "Cập nhật thành công!"
                });
            }
            catch (Exception)
            {

                return BadRequest(new ResponseViewModel
                {
                    Status = false,
                    Message = "Đã xảy ra lỗi! Vui lòng thử lại sau!"
                });
            }
            
        }
        [HttpPost("send-OTP")]
        public async Task<IActionResult> SendOTPByEmail([FromBody] ForgotPasswordModel_Email requestSendOTP)
        {
            var otp = new Random().Next(100000, 999999).ToString();
            EmailRequest emailRequest = new EmailRequest();
            emailRequest.ToEmail = requestSendOTP.email;
            emailRequest.Subject = "Send OTP";
            emailRequest.Body = $"OTP của bạn là: {otp}";
            _cache.Set(emailRequest.ToEmail, otp, _otpLifetime);
            await _emailService.SendEmailAsync(emailRequest);
            return Ok(new { Message = "Mã OTP đã được gửi đến email của bạn!", Email = requestSendOTP.email });
        }
        [HttpPost("verify-OTP")]
        public async Task<ActionResult<string>> VerifyOtpAsync(string email, string otp)
        {
            if (_cache.TryGetValue(email, out string storedOtp) && storedOtp == otp)
            {
                _cache.Remove(email);

                var token = _tokenHealper.GenerateAccessToken(email);

                return Ok(new { Token = token });
            }

            return Unauthorized("OTP không hợp lệ.");
        }
        [HttpPost("forgot-password")]
        public async Task<IActionResult> ForgotPassword([FromBody] ForgotPasswordModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var user = await _userManager.FindByEmailAsync(model.email);
                if (user == null)
                    return BadRequest("không tìm thấy tài khoản!");

                var resetPasswordResult = await _userManager.RemovePasswordAsync(user);
                if (!resetPasswordResult.Succeeded)
                {
                    return BadRequest(new ResponseViewModel
                    {
                        Status = false,
                        Message = "Đã sảy ra lỗi vui lòng thử lại sau!"
                    });
                }
                var result = await _userManager.AddPasswordAsync(user, "A123@123a");
                if (!result.Succeeded)
                {
                    return BadRequest(new ResponseViewModel
                    {
                        Status = false,
                        Message = "Đăng lại mật khẩu không thành công!"
                    });
                }
                return Ok(new ResponseViewModel()
                {
                    Status = true,
                    Message = "Đổi mật khẩu thành công!"
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseViewModel()
                {
                    Status = true,
                    Message = "Đổi mật khẩu không thành công!"
                });
            }
        }

        private async Task<FirebaseAdmin.Auth.FirebaseToken> VerifyGoogleTokenWithFirebase(string idToken)
        {
            try
            {
                // Khởi tạo Firebase Admin SDK nếu chưa
                FirebaseService.InitializeFirebase();

                // Xác minh token với Firebase
                var decodedToken = await FirebaseAuth.DefaultInstance.VerifyIdTokenAsync(idToken);
                return decodedToken;
            }
            catch (FirebaseAuthException firebaseAuthEx)
            {
                Console.WriteLine($"Firebase authentication error: {firebaseAuthEx.Message}");
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error verifying token: {ex.Message}");
                return null;
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
