using Data.ArmsContext;
using Data.Models;
using Repository;
using Repository.MajorRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.NotificationSer
{
    public class NotificationService : INotificationService
    {
        private readonly NotificationRepository _notificationRepository;
        public NotificationService(ArmsDbContext context)
        {
            _notificationRepository = new NotificationRepository(context);
        }
        public Task<List<Notification>> GetNotifications(Guid AccountId)
        => _notificationRepository.GetNotifications(AccountId);
    }
}
