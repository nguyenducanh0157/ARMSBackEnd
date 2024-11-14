using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.AccountSer
{
    public interface IAccountService
    {
        Task<Account> GetAccountByUserId(Guid userId);
        Task<List<Account>> GetAccountStudent(string campusId);
    }
}
