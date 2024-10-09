//using ARMS_API.Service;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.Extensions.Options;
//using System.Security.Cryptography;
//using System.Text;
//using Data.DTO;
//using Service;

//namespace ARMS_API.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class VNPayController : ControllerBase
//    {
//        private readonly IVnPayService _vnPayService;

//        public VNPayController(IVnPayService vnPayService)
//        {
//            _vnPayService = vnPayService;
//        }
//        [HttpPost("pay")]
//        public IActionResult CreatePayment([FromBody] VnPaymentRequestModel request)
//        {
//            if (request == null)
//            {
//                return BadRequest("Invalid payment request");
//            }

//            var paymentUrl = _vnPayService.CreatePaymentUrl(HttpContext, request);

//            return Ok(new { PaymentUrl = paymentUrl });
//        }
//        [HttpGet("vnpay_return")]
//        public IActionResult VNPayReturn()
//        {

//            var checkrespone = _vnPayService.PaymentExecute(Request.Query);

//            if (checkrespone.Success == true)
//            {
               
//                return Ok(new { message = "Giao dịch thành công", checkrespone.OrderId, checkrespone.TransactionId });
//            }
//            else
//            {
//                return BadRequest(new { message = "Giao dịch thất bại", checkrespone.VnPayResponseCode });
//            }
//        }

//    }
//}
