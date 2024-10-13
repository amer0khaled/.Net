using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec2
{
    public class BankTransfer : IPayment
    {
        public void PayBill()
        {
            Console.WriteLine("bill has paid via Bank Transfer");
        }
    }
}
