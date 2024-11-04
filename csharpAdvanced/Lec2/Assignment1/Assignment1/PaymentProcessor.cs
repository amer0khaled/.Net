using Assignment1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec2
{
    internal class PaymentProcessor
    {

        public void CheckOut(User user, double amount)
        {
            Console.WriteLine($"{user.Name} is checking out...");
            user.PaymentMethod.PayBill(amount);
        }

    }
}
