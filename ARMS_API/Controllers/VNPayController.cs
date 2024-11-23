
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Security.Cryptography;
using System.Text;
using Data.DTO;
using Service;
using Service.VnPaySer;
using Service.AdmissionInformationSer;
using Data.Models;

namespace ARMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VNPayController : ControllerBase
    {
        private readonly IVnPayService _vnPayService;
        private readonly IAdmissionInformationService _admissionInformationService;

        public VNPayController(IVnPayService vnPayService,IAdmissionInformationService admissionInformationService)
        {
            _vnPayService = vnPayService;
            _admissionInformationService = admissionInformationService;
        }
        [HttpPost("pay-register-admission")]
        public async Task<IActionResult> CreatePayment([FromBody] VnPaymentRequestModel request)
        {
            Guid codePay = Guid.NewGuid();
            AdmissionInformation AI = await _admissionInformationService.GetAdmissionInformationByStatus(request.Campus);
            decimal fee = AI.FeeRegister;
            DateTime timecreate = DateTime.UtcNow;
            if (request == null)
            {
                return BadRequest("Invalid payment request!");
            }

            var paymentUrl = _vnPayService.CreatePaymentUrl(HttpContext, codePay, fee, timecreate);

            return Ok(new { PaymentUrl = paymentUrl });
        }
        [HttpGet("vnpay_return")]
        public IActionResult VNPayReturn()
        {
            var queryParams = Request.Query;
            var checkResponse = _vnPayService.PaymentExecute(queryParams);
            var queryString = new StringBuilder();
            foreach (var param in queryParams)
            {
                var encodedValue = Uri.EscapeDataString(param.Value);
                queryString.Append($"{param.Key}={encodedValue}&");
            }
            queryString.Append(checkResponse.Success == true ? "status=success" : "status=fail");

            return Redirect($"http://localhost:3000/thanh-toan?{queryString}");
        }
        // api thanh toán học phí và phí giữ chỗ
        [HttpPost("pay-admission")]
        public async Task<IActionResult> CreatePaymentFeeAdmission([FromBody] VnPaymentRequestModel request)
        {
            Guid codePay = Guid.NewGuid();
            AdmissionInformation AI = await _admissionInformationService.GetAdmissionInformationByStatus(request.Campus);
            decimal fee = AI.FeeRegister;
            DateTime timecreate = DateTime.UtcNow;
            if (request == null)
            {
                return BadRequest("Invalid payment request!");
            }

            var paymentUrl = _vnPayService.CreatePaymentUrlAdmission(HttpContext, codePay, fee, timecreate);

            return Ok(new { PaymentUrl = paymentUrl });
        }
        [HttpGet("vnpay_return_admission")]
        public IActionResult VNPayReturnAdmission()
        {
            var queryParams = Request.Query;

            var checkResponse = _vnPayService.PaymentExecute(queryParams);

            var queryString = new StringBuilder();
            foreach (var param in queryParams)
            {
                var encodedValue = Uri.EscapeDataString(param.Value);
                queryString.Append($"{param.Key}={encodedValue}&");
            }
            queryString.Append(checkResponse.Success == true ? "status=success" : "status=fail");

            return Redirect($"http://localhost:3000/thanh-toan?{queryString}");
        }
    }
}
