using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 15, speed = 3;
            bool DUI = false;

            Console.WriteLine("Welcome to TTA Car Insurance. \nYou will be asked a few questions to determine if you qualify. \n");

            Console.WriteLine("What is your age?");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI? \nPlease enter true or false.");
            DUI = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");
            speed = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qualified?");
            Console.WriteLine(age > 15 && speed <= 3 && !DUI);

            Console.ReadLine();
        }
    }
}
