using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6partAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            string userInput;
            string[] cars = { "Ford ", "Chevrolet ", "Dodge " };

            Console.WriteLine("Please enter a color.");
            userInput = Console.ReadLine();

            for (int i = 0; i < cars.Length; i++)
            {
                cars[i] = cars[i] + userInput;
            }


            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            // Infinite loop added and fixed with a break; statement
            for (int i = 0; i < cars.Length;)
            {
                Console.WriteLine(cars[i]);
                break;
            }

            // Loop where the comparison that’s used to determine whether to continue iterating the loop is a “<” operator
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);

            }

            // loop where the comparison that’s used to determine whether to continue iterating the loop is a “<=” operator
            for (int i = 0; i <= cars.Length; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();


            List<string> names = new List<string>();
            names.Add("James");
            names.Add("Mark");
            names.Add("Russel");
            names.Add("Mateo");
            names.Add("Stephen");

            Console.WriteLine("Please enter your name to check if you are on the list. ");
            string uInput = Console.ReadLine();

            if (names.Contains(uInput))
            {
                Console.WriteLine(names.IndexOf(uInput));
            }
            else
            {
                Console.WriteLine("The name you entered is not on the list.");
            }

            Console.WriteLine();

            List<string> brand = new List<string>();
            brand.Add("Nike");
            brand.Add("Reebok");
            brand.Add("Puma");
            brand.Add("Addidas");
            brand.Add("Nike");

            Console.WriteLine("Please enter a brand of shoe you believe to be good quality.");
            string uI = Console.ReadLine();
            bool found = false;
            for (int i = 0; i < brand.Count; i++)
            {
                if (uI == brand[i])
                {
                    found = true;
                    Console.WriteLine(i);
                }
            }

            if (!found)
            {
                Console.WriteLine("The value you entered was not found. ");

            }

            Console.WriteLine();

            List<string> animals = new List<string>();
            animals.Add("Tiger");
            animals.Add("Lion");
            animals.Add("Tiger");
            animals.Add("Bear");
            animals.Add("Gorilla");

            List<string> unique = new List<string>();

            foreach (string animal in animals)
            {
                if (unique.Contains(animal))
                {
                    Console.WriteLine("The " + animal + " has already been seen.");

                }
                else
                {
                    unique.Add(animal);
                    Console.WriteLine("The " + animal + " has not appeared on the list.");
                }



            }



            Console.ReadLine();
        }
        
    }
}
