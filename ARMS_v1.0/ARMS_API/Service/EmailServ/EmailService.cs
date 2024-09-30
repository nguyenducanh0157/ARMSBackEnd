
using Data.DTO;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Util.Store;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;
using System.Threading.Tasks;

namespace ARMS_API.Service
{
    public class EmailService : IEmailService
    {
        private readonly EmailSetting _emailSettings;

        public EmailService(IOptions<EmailSetting> emailSettings)
        {
            _emailSettings = emailSettings.Value;
        }

        public async Task<ResponseViewModel> SendEmailAsync(EmailRequest emailRequest)
        {
            try
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("ARMS", _emailSettings.Email));
                message.To.Add(new MailboxAddress("", emailRequest.ToEmail));

                message.Subject = emailRequest.Subject;

                message.Body = new TextPart("plain")
                {
                    Text = emailRequest.Body
                };

                using (var client = new SmtpClient())
                {
                    await client.ConnectAsync(_emailSettings.SmtpServer, _emailSettings.Port, SecureSocketOptions.StartTls);
                    await client.AuthenticateAsync(_emailSettings.Email, _emailSettings.AppPassword);
                    await client.SendAsync(message);
                    await client.DisconnectAsync(true);
                }

                return new ResponseViewModel() { Status = true, Message = "Gửi mail thành công" };
            }
            catch (Exception ex)
            {
                return new ResponseViewModel() { Status = false, Message = ex.Message };
            }
        }
    }
}
