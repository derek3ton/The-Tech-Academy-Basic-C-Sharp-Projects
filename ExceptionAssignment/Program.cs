using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = new List<int>();
            numList.Add(8);
            numList.Add(16);
            numList.Add(32);
            numList.Add(64);

            try
            {
                Console.WriteLine("Please enter a number to divide the list of numbers by: ");
                int userNum = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Dividing numbers from list by " + userNum);

                foreach (int i in numList)
                {
                    int num3 = i / userNum;
                    Console.WriteLine(num3);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please input a whole number.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You cannot divde by zero, please input a whole number.");
            }
            
            
            Console.WriteLine("The program has completed the try/catch block and will now continue. ");


            Console.ReadLine();
            
            
            
            
            
            
            
             



        }
    }
}
