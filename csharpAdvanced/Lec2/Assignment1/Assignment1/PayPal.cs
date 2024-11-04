using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec2
{
    public class PayPal : IPayment
    {
        public void PayBill(double amount)
        {
            Console.WriteLine($"Processing PayPal payment of {amount:C}");
        }
    }
}
