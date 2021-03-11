using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsAssignmentPg324
{
    class Program
    {
        enum weekDays  //creating enum 
        {
            Monday,  //Defining value
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
 
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current day of week.");  //Getting user input 
            string result = Console.ReadLine();  //storing user input in variable

            try  //try/catch block to catch an exception
            {       
                weekDays userInput = (weekDays)Enum.Parse(typeof(weekDays), result); //converting user input from string to enum
                weekDays weekDay = weekDays.Saturday;

                Console.WriteLine("Have a nice " + userInput); //outputting result
            }
            catch  //Catch block to throw an exception in case user input is other than defined values
            {
                Console.WriteLine("Please enter an actual day of the week.");  //Outputs exception thrown
            }
            

            Console.ReadLine();
        }
        

    }    
}
