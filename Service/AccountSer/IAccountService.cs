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
        Task<List<Account>> GetAccounts(string campusId);
        Task<List<Account>> GetAccountsRequest(string campusId);
        Task<List<Account>> GetAO(string campusId);
        Task<List<Account>> GetAC(string campusId);
        Task<List<Account>> GetAdmin(string campusId);
    }
}
