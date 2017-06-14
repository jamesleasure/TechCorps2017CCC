using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.make = "Ford";
            car1.model = "Focus";
            car1.color = "Red";
            car1.year = 2010;

            Car car2 = new Car();
            car2.make = "Kia";
            car2.model = "Spectra";
            car2.color = "Black";
            car2.year = 2007;

            car1.MSRP = 9000f;
            float commissionCar1 = car1.sellCar("Ani", 8000f);

            car2.MSRP = 5200f;
            float commissionCar2 = car2.sellCar("Justin", 4900f);

            Console.WriteLine("Ani sold a " + car1.make + " " +
                car1.model + " and received $" + commissionCar1 +
                " for his commission.");

            Console.WriteLine("Justin sold a " + car2.make + " " +
                car2.model + " and received $" + commissionCar2 +
                " for his commission.");


        }
    }
}
