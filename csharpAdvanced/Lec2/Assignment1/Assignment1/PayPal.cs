using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec2
{
    public class PayPal : IPayment
    {
        public void PayBill()
        {
            Console.WriteLine("bill has paid via PayPal");
        }
    }
}
