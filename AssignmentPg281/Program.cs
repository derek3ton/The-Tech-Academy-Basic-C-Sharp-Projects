using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPg281
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math(); //Instantiates 

            Console.WriteLine("Please enter a whole number."); //Takes integer in
            int Number1 = Convert.ToInt32(Console.ReadLine()); // and stores in variable
            
            Console.WriteLine("Please enter a second whole number."); // Takes in second integer
            int Number2 = Convert.ToInt32(Console.ReadLine());   // and stores in variable

            math.Output(Number1, Number2); // Calls method and outputs result


            Console.ReadLine();
        }
    }
}
