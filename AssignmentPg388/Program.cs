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
            int age = Convert.ToInt32(Console.ReadLine());
            var currentYear = DateTime.Now.Year;
            
            if (age <= 0)
            {
                try
                {
                    var yearBorn = currentYear - age;
                    Console.WriteLine("Your birth year is: {0}", yearBorn);
                    Console.ReadLine();
                    return;
                }
                catch (Exception)
                {
                    Console.WriteLine("Ooops");
                }
            }
            

            Console.ReadLine();

        }
    }
}
