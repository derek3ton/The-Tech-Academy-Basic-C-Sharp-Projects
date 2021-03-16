using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AssignmentPg369
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime current = DateTime.Now; //defining new var to current date/time just to make it easier to incorporate in code later
            Console.WriteLine(current); //Prints to console the current date and time

            Console.WriteLine("Please enter any number.");  //Asking for user input
            double userInput = Convert.ToDouble(Console.ReadLine()); //Storing user input and converting to double

            var futureTime = current.AddHours(userInput);  //declaring new var for storing result of adding user input to number of hours
            Console.WriteLine("In " + userInput + " hour(s), it will be: " + futureTime); //Printing the results to console

            Console.ReadLine(); //Keeps window from closing
        }
    }
}
