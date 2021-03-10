using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPgs302and305
{
    public class Employee : Person, IQuittable  //Implementing Employee class and inheriting from class Person and IQuittable
    {
        public void Quit()  // Creating method 
        {
            Console.WriteLine("I quit."); //Outputs result of calling IQuittable
        }

    }
}
