using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class PushNotification : INotification
    {
        public void Notify(string message)
        {
            Console.WriteLine($"{message} via PushNotification");
        }
    }
}
