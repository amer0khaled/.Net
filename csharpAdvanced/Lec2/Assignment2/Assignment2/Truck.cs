using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Truck : Vehicle
    {
        public void Start()
        {
            Console.WriteLine("Truck Start ...");
        }

        public void Stop()
        {
            Console.WriteLine("Truck Stop ...");
        }
        
        public void Describe()
        {
            Console.WriteLine("this is Truck");
        }

    }
}
