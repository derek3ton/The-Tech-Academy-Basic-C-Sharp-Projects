using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPg388
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your current age.");
            var age = Convert.ToInt32(Console.ReadLine());
            var currentYear = DateTime.Now.Year;
            var yearBorn = currentYear - age;

            try
            {
                if (age <= 0)
                {
                    throw new ArgumentException();
                }

                Console.WriteLine("Your birth year is: {0}", yearBorn);
                Console.ReadLine();
                return;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Please enter whole numbers only!");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("An error has occurred.  Please contact your systems administrator.");
                Console.ReadLine();
                
            }

        }
        
    }    
}
