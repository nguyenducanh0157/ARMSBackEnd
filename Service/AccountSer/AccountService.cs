using Data.ArmsContext;
using Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
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
        private readonly UserManager<Account> _userManager;
        private readonly RoleManager<IdentityRole<Guid>> _roleManager;
        public AccountService(ArmsDbContext context, UserManager<Account> userManager, RoleManager<IdentityRole<Guid>> roleManager)
        {
            _accountRepository = new AccountRepository(context);
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public Task<Account> GetAccountByUserId(Guid userId)
       => _accountRepository.GetAccountByUserId(userId);

        public async Task<List<Account>> GetAccounts(string campusId)
        {
            var allUsers = await _userManager.Users
                    .Where(user => user.CampusId == campusId)
                    .ToListAsync();

            return allUsers;
        }

        public async Task<List<Account>> GetAccountStudent(string campusId)
        {
            try
            {
                var studentRoleId = Guid.Parse("D2D63C5B-D09B-4828-8322-F18BA103FE86");

                var allUsers = await _userManager.Users
                    .Where(user => user.CampusId == campusId)
                    .ToListAsync();

                var studentAccounts = new List<Account>();
                foreach (var user in allUsers)
                {
                    var roles = await _userManager.GetRolesAsync(user);
                    if (roles.Any(roleName =>
                    {
                        var role = _roleManager.Roles.FirstOrDefault(r => r.Name == roleName);
                        return role != null && role.Id == studentRoleId;
                    }))
                    {
                        studentAccounts.Add(user);
                    }
                }

                return studentAccounts;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while fetching student accounts.", ex);
            }
        }

    }
}
