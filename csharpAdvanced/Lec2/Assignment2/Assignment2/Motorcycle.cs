using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Motorcycle : Vehicle
    {
        public void Start()
        {
            Console.WriteLine("Motorcycle Start ...");
        }

        public void Stop()
        {
            Console.WriteLine("Motorcycle Stop ...");
        }

        public void Describe()
        {
            Console.WriteLine("this is Motorcycle");
        }
    }
}
