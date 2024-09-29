
using Data.DTO;

namespace ARMS_API.Service
{
    public interface IEmailService
    {
        Task<ResponseViewModel> SendEmailAsync(EmailRequest emailRequest);
        //Task<ResponseViewModel> SendEmailAsync(string recipientEmail, string subject, string body);
    }
}
