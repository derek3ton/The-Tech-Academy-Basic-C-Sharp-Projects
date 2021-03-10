using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPgs302and305
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(); //Instantiating employee class
            employee.firstName = "Sample";  //Initializing employee class and setting variable
            employee.lastName = "Student";

            employee.SayName();  //Calling method and displaying result. 

            Console.ReadLine();
        }
    }
}
