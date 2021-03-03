using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPg226
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number. ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Math math = new Math();
            math.Add = userInput;
            math.Mult = userInput;
            

            int sum = math.Addition(10);
            Console.WriteLine("The sum of " + userInput + " + 10 is: " + sum);

            decimal prod = math.Multiply(10);
            Console.WriteLine("The product of " + userInput + " * 10 is: " + prod);

            
            Console.WriteLine("Please enter another number.");
            string userInput2 = Console.ReadLine();

            math.Div = userInput2;

            int quot = math.Divide("10");
            Console.WriteLine("The quotient of " + userInput2 + " / 10 is: " + quot);




            Console.ReadLine();
        }
    }
}
