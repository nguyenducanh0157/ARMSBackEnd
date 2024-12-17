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
                    .ThenBy(x => x.isRead)
                    .ToListAsync();
                return Notifications;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

        }
        public async Task UpdateNotification(Guid NotificationId)
        {
            try
            {
                Notification Notification = await _context.Notifications.FirstOrDefaultAsync(x=>x.NotificationId == NotificationId);
                Notification.isRead = true;
                _context.Entry<Notification>(Notification).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new Exception("Chỉnh sửa không thành công");
            }
        }
        public async Task AddNotification(Notification Notification)
        {
            try
            {
                await _context.Notifications.AddAsync(Notification);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Tạo mới không thành công");
            }
        }
    }
}
