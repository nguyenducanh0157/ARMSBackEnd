﻿using Data.DTO;
using Data.DTO;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.EmailSer
{
    public class EmailNotifyService: IEmailNotifyService
    {
        private readonly EmailSetting _emailSettings;

        public EmailNotifyService(IOptions<EmailSetting> emailSettings)
        {
            _emailSettings = emailSettings.Value;
        }
        public async Task<ResponseViewModel> SendEmailByHTMLAsync(EmailRequestNotify emailRequest)
        {
            try
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("ARMS", _emailSettings.Email));
                message.To.Add(new MailboxAddress("", emailRequest.ToEmail));

                message.Subject = emailRequest.Subject;

                message.Body = new TextPart("html")
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