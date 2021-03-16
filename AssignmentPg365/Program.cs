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
            Console.WriteLine("Please enter any number.");
            string userInput = Console.ReadLine();
            File.WriteAllText(@"C:\Users\derek\source\repos\AssignmentPg365\Log.txt", userInput);


            string readBack = File.ReadAllText(@"C:\Users\derek\source\repos\AssignmentPg365\Log.txt");
            userInput = readBack;
            Console.WriteLine("You chose the number: " + readBack);

            Console.ReadLine();
        }
    }
}
            