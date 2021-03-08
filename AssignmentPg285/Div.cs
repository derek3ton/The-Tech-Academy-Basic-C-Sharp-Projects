using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPg285
{
    public class Div
    {
        public void Division(int Number1)  //Defines method and variable
        {
            int result = Number1 / 2; //Creates var to store result of calculation
            Console.WriteLine(Number1 + " / 2 is: " + result); //Outputs result when called
        }

        public void Output(out int x) //Method with output parameters
        {
            x = 100;  //Stores value to variable
            Console.WriteLine("Output parameter called is: " + x); //Outputs result when called
        }
        
        public void Output(out string y) //Overloaded method to be called
        {
            y = "My favorite color is green.";  // Declaring variable
            Console.WriteLine("Output from overload method is: " + y);  // Outputs when called
        }
    }

    public static class Multiply  // Declaring a static class
    {
        public static void Multiplication(int Num1) //Creating a static method to be called 
        {
            int product = Num1 * 10;  //Declaring variable 
            Console.WriteLine(Num1 + " * 10 is: " + product);  //Outputs when called
        } 

    }
}
