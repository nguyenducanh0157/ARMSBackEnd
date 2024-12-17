using ARMS_API.ValidData;
using AutoMapper;
using Data.DTO;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;
using Service.MajorSer;
using Service.NotificationSer;
using Service.PayFeeAdmissionSer;

namespace ARMS_API.Controllers.User
{
    [Route("api/user/[controller]")]
    [ApiController]
    [Authorize(Roles = "AdmissionCouncil, AdminOfficer, Admin, Student")]
    public class NotificationController : ControllerBase
    {

        private INotificationService _notificationService;
        private readonly IMapper _mapper;
        private UserInput _userInput;
        public NotificationController(INotificationService notificationService, IMapper mapper, UserInput userInput)
        {
            _notificationService = notificationService;
            _mapper = mapper;
            _userInput = userInput;
        }
        [HttpGet("get-notifications")]
        public async Task<IActionResult> GetNotifications()
        {
            try
            {
                var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                if (string.IsNullOrEmpty(userId)) return Unauthorized("Không tìm thấy ID người dùng!");
                List<Notification> response = await _notificationService.GetNotifications(Guid.Parse(userId));
                List<NotificationDTO> responeResult = _mapper.Map<List<NotificationDTO>>(response);
                return Ok(responeResult);

            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
        [HttpPut("update-notification")]
        public async Task<IActionResult> UpdateNotification(Guid NotificationId)
        {
            try
            {
                await _notificationService.UpdateNotification(NotificationId);
                return Ok(new ResponseViewModel()
                {
                    Status = true,
                    Message = "Cập nhật thành công!"
                });

            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
    }
}
