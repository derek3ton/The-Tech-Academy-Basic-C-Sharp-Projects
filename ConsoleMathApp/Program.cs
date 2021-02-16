using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMathApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //multiply
            int mult1, mult2 = 50;

            Console.WriteLine("Input your number to multiply by 50: ");
            mult1 = Convert.ToInt32(Console.ReadLine());

            int product = mult1 * mult2;
            Console.WriteLine("{0} x {1} = {2}", mult1, mult2, product);

            Console.WriteLine('\n');

            //add
            int add1, add2 = 25;

            Console.WriteLine("Input your number to add by 25:");
            add1 = Convert.ToInt32(Console.ReadLine());

            int sum = add1 + add2;
            Console.WriteLine("{0} + {1} = {2}", add1, add2, sum);

            Console.WriteLine('\n');

            //divide
            double div1, div2 = 12.5;

            Console.WriteLine("Input your number to divide by 12.5:");
            div1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your answer is: ");

            double quotient = div1 / div2;
            Console.WriteLine("{0} / {1} = {2}", div1, div2, quotient);

            Console.WriteLine('\n');

            //comparison 
            int comp1, comp2 = 50;

            Console.WriteLine("Enter your number to compare to 50: ");
            comp1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(comp1 > comp2);

            Console.WriteLine('\n');

            //modulus
            double mod1, mod2 = 7;

            Console.WriteLine("Input your number to divide by 7:");
            mod1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your answer is: ");

            double remainder = mod1 % mod2;
            Console.WriteLine("{0} % {1} = {2}", mod1, mod2, remainder);

            Console.ReadLine();




        }
    }
}
