using Lec2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class User
    { 
        public User(string name, IPayment paymentMethod) 
        {
            Name = name;
            PaymentMethod = paymentMethod;
        }

        public string Name {  get; set; }
        public IPayment PaymentMethod { get; set; }

    }
}
