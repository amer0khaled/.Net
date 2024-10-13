using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec2
{
    internal class OnlineStore : IPayment
    {
        public IPayment PaymentMethod { get; set; }

        public OnlineStore() { }
        public OnlineStore(IPayment paymentMethod)
        {
            this.PaymentMethod = paymentMethod;
        }

        public void PayBill()
        {
            PaymentMethod.PayBill();
        }

    }
}
