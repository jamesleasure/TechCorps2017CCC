using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            bool ageInvalid = true;
            while (ageInvalid)
            {
                Console.WriteLine("Age?");
                try
                {
                    ageInvalid = false;
                    age = Convert.ToInt16(Console.ReadLine());
                }
                catch (Exception e)
                {
                    ageInvalid = true;
                    Console.WriteLine("Invalid age");
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    Console.WriteLine("... processing ...");

                }
            }
            Console.WriteLine("You are " + age + " years old.");
        }
    }
}
