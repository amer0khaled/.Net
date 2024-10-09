using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec1
{
    internal class Car
    {
        public Car(string make, string model, int year, int mileage) 
        {
            Make = make;
            Model = model;
            Year = year;
            Mileage = mileage;
        }

        public string Make {  get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Mileage {  get; private set; }

        public int Age
        {
            get
            {
                return DateTime.Now.Year - Year;
            }
        }

        public void Drive(int distance)
        {
            if (distance > 0)
                Mileage += distance;
        }

    }
}
