using Data.ArmsContext;
using Data.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.AccountSer
{
    public class AccountService : IAccountService
    {
        private readonly AccountRepository _accountRepository;
        public AccountService(ArmsDbContext context)
        {
            _accountRepository = new AccountRepository(context);
        }
        public Task<Account> GetAccountByUserId(Guid userId)
       => _accountRepository.GetAccountByUserId(userId); 
    }
}
