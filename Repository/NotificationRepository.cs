using Data.ArmsContext;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class NotificationRepository
    {
        private readonly ArmsDbContext _context;
        public NotificationRepository(ArmsDbContext context) { _context = context; }
        public async Task<List<Notification>> GetNotifications(Guid AccountId)
        {
            try
            {
                List<Notification> Notifications = await _context.Notifications
                    .Where(x => x.AccountId.Equals(AccountId))
                    .OrderBy(x => x.CreateAt)
                    .ToListAsync();
                return Notifications;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

        }
    }
}
