using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssignment
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
            math.Sub = userInput;
            math.Mult = userInput;

            int sum = math.Addition(5);
            Console.WriteLine("The sum of " + userInput + " + 5" + " is:  " + sum);

            int diff = math.Subtraction(5);
            Console.WriteLine("The difference of " + userInput + " - 5 is: " + diff);

            int prod = math.Multiplication(5);
            Console.WriteLine("The product of " + userInput + " * 5 is: " + prod);



            Console.ReadLine();
        }
        

    }
}

