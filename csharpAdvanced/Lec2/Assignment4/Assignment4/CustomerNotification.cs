using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class CustomerNotification : INotification
    {
        public CustomerNotification() { }
        public CustomerNotification(INotification notificationMethod) 
        {
            this.NotificationMthod = notificationMethod;
        }
        public INotification NotificationMthod { get; set; }
        public void Notify(string msg)
        {
            NotificationMthod.Notify(msg);
        }
    }
}
