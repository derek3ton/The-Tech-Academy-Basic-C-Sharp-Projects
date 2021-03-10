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

            IQuittable quittable = new Employee(); //Instantiating new IQuittable object from Employee class
            quittable.Quit();  //Calling Method displaying result



            employee.Id = 21; //Assign value to employee property Id 
            Employee employee1 = new Employee(); //Instantiating employee1 object
            employee1.Id = 32; //Assigns value to employee1 property Id

            Console.WriteLine(employee1 == employee); //Compares the two objects and returns false
            Console.WriteLine(employee1 != employee); //Compares the two objects and returns true

            Console.ReadLine();
        }
    }
}
