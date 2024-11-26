using Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.EmailSer
{
    public interface IEmailService
    {
        
        Task<ResponseViewModel> SendEmailAsync(EmailRequestByText emailRequest);
        Task<ResponseViewModel> SendEmailByHTMLAsync(EmailRequest emailRequest);
    }
}
