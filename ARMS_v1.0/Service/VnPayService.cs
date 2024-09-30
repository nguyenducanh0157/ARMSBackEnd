using Data.DTO;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class VnPayService : IVnPayService
    {
        public string CreatePaymentUrl(HttpContext context, VnPaymentRequestModel model)
        {
            throw new NotImplementedException();
        }

        public VnPaymentResponseModel PaymentExecute(IQueryCollection collections)
        {
            throw new NotImplementedException();
        }
    }
}
