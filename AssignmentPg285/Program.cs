using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPg285
{
    class Program
    {
        static void Main(string[] args)
        {
            Div div = new Div(); //Instantiates Class "Div"

            Console.WriteLine("Please enter a number to divide by 2."); // Takes in user input 
            int Number1 = Convert.ToInt32(Console.ReadLine());  // Stores user input into variable

            div.Division(Number1); //Calls method and displays result

            
            div.Output(out int x); // Calling output parameter from method

            
            div.Output(out string y);  // Calling and outputing from overloaded method

            Console.WriteLine("Please enter a number of your choosing."); //Getting user input to be used in static method
            int z = Convert.ToInt32(Console.ReadLine()); //Storing user input into variable
            Multiply.Multiplication(z);  //Calling from static class / method and outputting result

            Console.ReadLine();
        }
    }
}
