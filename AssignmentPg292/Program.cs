using System;

namespace AssignmentPg292
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(); //Instantiates person class

            Employee employee = new Employee();  //instantiates employee class
            employee.FirstName = "Sample"; //Initializes Employee object
            employee.LastName = "Student"; //Initializes employee object

            employee.SayName();  //Calls superclass "Person" method on Employee object


            Console.ReadLine();
        }
    }
}


 