using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec2
{
    public class BankTransfer : IPayment
    {
        public void PayBill(double amount)
        {
            Console.WriteLine($"Processing BankTransfer payment of {amount:C}");
        }
    }
}
