using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            int rateP1, rateP2, grossP1, grossP2, weekP1, weekP2;

            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine('\n');
            
            //Person 1 info:
            Console.WriteLine("Person 1:");

            Console.WriteLine("Enter your hourly rate: ");
            rateP1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your hours per week: ");
            weekP1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine('\n');
            
            //Person 2 info: 
            Console.WriteLine("Person 2:");

            Console.WriteLine("Enter your hourly rate: ");
            rateP2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your hours per week: ");
            weekP2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine('\n');

            //Annual calculation of P1 and P2:
            grossP1 = rateP1 * weekP1 * 52;
            Console.WriteLine("Annual salary of Person 1 is: \n" + grossP1);

            Console.WriteLine('\n');

            grossP2 = rateP2 * weekP2 * 52;
            Console.WriteLine("Annual salary of Person 2 is: \n" + grossP2);

            Console.WriteLine('\n');

            //Comparison of P1 and P2:
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(grossP1 >= grossP2);

            Console.ReadLine();
        }
    }
}
