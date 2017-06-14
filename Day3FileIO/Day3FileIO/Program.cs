using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Day3FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            String fileLocation = "C:\\tc\\orders.dat";
            StreamReader reader = new StreamReader(fileLocation);
            String nextLine;
            while ((nextLine = reader.ReadLine())!= null)
            {
                // process the file
                if (nextLine.StartsWith("#"))
                {
                    continue;
                }
                String[] orderParts = nextLine.Split(",".ToCharArray());

                string customerID = orderParts[0];
                string productID = orderParts[1];
                int quantity = Convert.ToInt16(orderParts[2]);
                decimal price = Convert.ToDecimal(orderParts[3]);

                Console.WriteLine("Customer " + customerID + " owes $" + (quantity * price));

                string billingDirectory = "C:\\tc";

                StreamWriter writer = new StreamWriter(billingDirectory + "\\" + customerID, true);
                writer.WriteLine("Customer " + customerID + " owes $" + (quantity * price));
                writer.Close();
            }
        }
    }
}
