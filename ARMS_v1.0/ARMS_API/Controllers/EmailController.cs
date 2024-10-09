
//using ARMS_API.Service;
//using Data.DTO;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.Extensions.Caching.Memory;

//namespace ARMS_API.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class EmailController : ControllerBase
//    {
//        private readonly IEmailService _emailService;
//        private readonly IMemoryCache _cache;
//        private readonly TimeSpan _otpLifetime = TimeSpan.FromMinutes(5);
//        public EmailController(IEmailService emailService, IMemoryCache cache)
//        {
//            _emailService = emailService;
//            _cache = cache;
//        }

//        [HttpPost("send-OTP")]
//        public async Task<IActionResult> SendOTPByEmail([FromBody] EmailRequest emailRequest)
//        {
//            if (emailRequest == null || string.IsNullOrEmpty(emailRequest.ToEmail))
//            {
//                return BadRequest("Invalid email request.");
//            }
//            var otp = new Random().Next(100000, 999999).ToString();
//            emailRequest.Subject = "Send OTP";
//            emailRequest.Body = $"OTP của bạn là: {otp}";
//            _cache.Set(emailRequest.ToEmail, otp, _otpLifetime);
//            await _emailService.SendEmailAsync(emailRequest);
//            return Ok("Gửi email thành công!");
//        }
//        [HttpPost("verify-OTP")]
//        public async Task<bool> VerifyOtpAsync(string email, string otp)
//        {
//            if (_cache.TryGetValue(email, out string storedOtp) && storedOtp == otp)
//            {
//                _cache.Remove(email);
//                return true;
//            }
//            return false;
//        }
//    }
//}
