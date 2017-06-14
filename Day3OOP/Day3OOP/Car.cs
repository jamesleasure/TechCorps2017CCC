using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3OOP
{
    class Car
    {
        public string make;
        public string model;
        public string color;
        public int year;
        public float MSRP;
        public int VIN;

        public float sellCar(string person, float salesPrice)
        {
            return this.MSRP / salesPrice * 1000;
        }
    }
}
