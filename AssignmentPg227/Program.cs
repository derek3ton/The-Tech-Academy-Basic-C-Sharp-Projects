using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPg227
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            
            Console.WriteLine("Please enter a number to calculate.");
            int userNum1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Please enter a second number --- Optional.");
            string userNum2 = Console.ReadLine();
            
            if (userNum2 != "")
            {
                int i = Convert.ToInt32(userNum2);
                Console.WriteLine(math.Calculate(userNum1, i));
            }
            else
            {
                Console.WriteLine(math.Calculate(userNum1));
            }
















            Console.ReadLine();
        }
    }
}
