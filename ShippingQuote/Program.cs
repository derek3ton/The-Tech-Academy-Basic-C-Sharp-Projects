using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express.  Please follow the instructions below.");

            Console.WriteLine("Please enter the package weight: ");
            int pweight = Convert.ToInt32(Console.ReadLine());

            if (pweight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.  Have a good day.");               
            }
            else
            {
                Console.WriteLine("Please enter the package width: ");
                int pwidth = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("Please enter the package height: ");
                int pheight = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package length: ");
                int plength = Convert.ToInt32(Console.ReadLine());

                int totalDim = pwidth + pheight + plength;
                if (totalDim > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express. ");
                }
                else
                {
                    decimal quote = (pwidth * pheight * plength * pweight) / 100;
                    quote = Convert.ToDecimal(quote);
                    Console.WriteLine("Your estimated total for shipping this package is: $" + quote);                   
                }


            }

            Console.ReadLine();
        }
    }
}
