using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec2
{
    public interface IPayment
    {
        void PayBill(double amount);
    }
}
