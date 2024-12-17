using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.NotificationSer
{
    public interface INotificationService
    {
        Task<List<Notification>> GetNotifications(Guid AccountId);
        Task UpdateNotification(Guid NotificationId);
        Task AddNotification(Notification Notification);
    }
}
