using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Assignment2
{
    public interface Vehicle : IControllable
    {
        void Describe();
    }
}
