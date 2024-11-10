
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
            AdmissionInformation AI = await _admissionInformationService.GetAdmissionInformation(request.Campus);
            decimal fee = AI.FeeRegister;
            DateTime timecreate = DateTime.UtcNow;
            if (request == null)
            {
                return BadRequest("Invalid payment request!");
            }

            var paymentUrl = _vnPayService.CreatePaymentUrl(HttpContext, codePay, fee, timecreate);

            return Ok(new { PaymentUrl = paymentUrl });
        }
        //[HttpGet("vnpay_return")]
        //public IActionResult VNPayReturnTest()
        //{

        //    var checkrespone = _vnPayService.PaymentExecute(Request.Query);

        //    if (checkrespone.Success == true)
        //    {

        //        return Ok(new { message = "Giao dịch thành công", checkrespone});
        //    }
        //    else
        //    {
        //        return BadRequest(new { message = "Giao dịch thất bại", checkrespone.TransactionStatus });
        //    }
        //}
        [HttpGet("vnpay_return")]
        public IActionResult VNPayReturn()
        {
            // Lấy tất cả các tham số trả về từ VNPAY
            var queryParams = Request.Query;

            // Kiểm tra phản hồi thanh toán từ VNPAY
            var checkResponse = _vnPayService.PaymentExecute(queryParams);

            // Tạo chuỗi truy vấn để chuyển tiếp đến frontend với tất cả các tham số
            var queryString = new StringBuilder();
            foreach (var param in queryParams)
            {
                // Sử dụng UrlEncode để mã hóa giá trị tham số
                var encodedValue = Uri.EscapeDataString(param.Value);
                queryString.Append($"{param.Key}={encodedValue}&");
            }
            // Thêm trạng thái thanh toán vào chuỗi truy vấn
            queryString.Append(checkResponse.Success == true ? "status=success" : "status=fail");

            return Redirect($"https://7732-2001-ee0-41c1-f67-9d57-4757-9d17-c2bd.ngrok-free.app/nop-ho-so?{queryString}");
        }
    }
}
