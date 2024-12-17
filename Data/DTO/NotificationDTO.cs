using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO
{
    public class NotificationDTO
    {
        public Guid NotificationId { get; set; }
        public string Content { get; set; }
        public bool isRead { get; set; }
        public Guid? SPId { get; set; }
        public DateTime CreateAt { get; set; }
        public TypeNotification TypeNotification { get; set; }
    }
}
