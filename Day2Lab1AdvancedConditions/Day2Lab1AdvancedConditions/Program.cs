using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Lab1AdvancedConditions
{
    class Program
    {
        static void Main(string[] args)
        {
            double waterTemp;
            double airTemp;
            int probOfRain;
            int timeOfDay;

            Console.Write("Please enter water temperature: ");
            waterTemp = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter air temperature: ");
            airTemp = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter probability of rain: ");
            probOfRain = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter time of day (military): ");
            timeOfDay = Convert.ToInt32(Console.ReadLine());

            if (timeOfDay >= 12 && timeOfDay <= 16 && waterTemp > 70 && airTemp > 80 && probOfRain < 30)
            {
                Console.WriteLine("Take the kids swimming");
            }
            else if (airTemp > 60 && probOfRain < 50 && timeOfDay >= 10 && timeOfDay <= 18)
            {
                Console.WriteLine("Play soccer");
            }
            else if (probOfRain > 60 || timeOfDay > 18)
            {
                Console.WriteLine("Play board games");
            }
            else if (timeOfDay > 20)
            {
                Console.WriteLine("Watch movies");
            }
            else
            {
                Console.WriteLine("No activities");
            }
        }
    }
}
