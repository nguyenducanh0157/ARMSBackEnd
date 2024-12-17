using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Notification
    {
        public Guid NotificationId { get; set; }
        public string Content { get; set; }
        public bool isRead { get; set; }
        public Guid? SPId { get; set; }
        public Guid AccountId { get; set; }
        public DateTime CreateAt { get; set; }
        public TypeNotification TypeNotification { get; set; }
        public virtual Account? Account { get; set; }
    }
    public enum TypeNotification
    {
        AdmissionOfficer,//0
        AdmissionCouncil,//1
        SchoolService,//2
        Arms,//3
        RegisterAdmission,//4
        DoneAdmission//5
    }
}
