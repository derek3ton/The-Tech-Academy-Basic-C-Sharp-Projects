using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //String Array
            string[] stringArray = new string[6];
            stringArray[0] = "Dog";
            stringArray[1] = "Cat";
            stringArray[2] = "Bird";
            stringArray[3] = "Fish";
            stringArray[4] = "Reptile";
            stringArray[5] = "Rodent";

            Console.WriteLine("Please enter a number from 0 - 5");  //Promt to gain user input
            int i = Convert.ToInt32(Console.ReadLine());  

            if (i < 6)  // if/else to display result or to display error
            {
                Console.WriteLine("You chose a: " + stringArray[i]);

            }
            else
            {
                Console.WriteLine("The number you entered is outside of specifed range.");
            }



            Console.WriteLine(); //Starts to a new line 


            //Int Array
            int[] intArray = new int[6];
            intArray[0] = 10;
            intArray[1] = 20;
            intArray[2] = 30;
            intArray[3] = 40;
            intArray[4] = 50;
            intArray[5] = 60;

            Console.WriteLine("Please enter a number from 0-5.");  //Promt to gain user input
            int userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput < 6)  // if/else to display result or to display error
            {
                Console.WriteLine("You chose the number: " + intArray[userInput]);
            }
            else
            {
                Console.WriteLine("The number you entered is outside of specifed range.");
            }

            Console.WriteLine(); // Starts a new line

            //String List
            List<string> petNames = new List<string>();
            petNames.Add("Kingsley");
            petNames.Add("Bruce");
            petNames.Add("Max");
            petNames.Add("Voldemort");
            petNames.Add("Rufus");
            petNames.Add("Steve");

            Console.WriteLine("Please enter a number 0 - 5 to display your new pets name.");  //Promt to gain user input
            int userChoice = Convert.ToInt32(Console.ReadLine());
             
            if (userChoice < 6) // if/else to display result or to display error
            {
                Console.WriteLine("You chose your new pet name to be: " + petNames[userChoice]);
            }
            else
            {
                Console.WriteLine("The number you entered is outside the specified range.");
            }


            Console.ReadLine();

        }
    }
}
