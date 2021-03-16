using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AssignmentPg365
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter any number.");  //Asks user for input from console

            string userInput = Console.ReadLine(); //stores user input in var
            File.WriteAllText(@"C:\Users\derek\source\repos\AssignmentPg365\Log.txt", userInput); //Writes text to new .txt file using specified path


            string readBack = File.ReadAllText(@"C:\Users\derek\source\repos\AssignmentPg365\Log.txt");  // declaring new string var to store user input saved to file
            userInput = readBack;  //storing user input into new var   
            Console.WriteLine("You chose the number: " + readBack);  //Writing text that the user saved into file, to the console.

            Console.ReadLine();
        }
    }
}
            