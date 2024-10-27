using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Car : Vehicle
    {
        public void Start()
        {
            Console.WriteLine("Car Start ...");
        }

        public void Stop()
        {
            Console.WriteLine("Car Stop ...");
        }

        public void Describe()
        {
            Console.WriteLine("this is Car");
        }
    }
}
