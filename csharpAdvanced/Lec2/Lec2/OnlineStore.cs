using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec2
{
    internal class OnlineStore : IPayment
    {
        private IPayment paymentMethod;

        public OnlineStore(IPayment paymentMethod)
        {
            this.paymentMethod = paymentMethod;
        }

        public void PayBill()
        {
            paymentMethod.PayBill();
        }

    }
}
