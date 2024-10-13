using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Assignment2
{
    public abstract class Vehicle : IControllable
    {
        public void Started()
        {
            Console.WriteLine($"{this.GetType()} Started...");
        }
        public void Stop()
        {
            Console.WriteLine($"{this.GetType()} Stopped...");
        }

        public abstract void Describe();
    }
}
