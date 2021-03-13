using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPgs302and305
{
    public class Employee : Person //IQuittable  //Implementing Employee class and inheriting from class Person and IQuittable
    {
        //Setting properties of Employee class
        public string First { get; set; }
        public string Last { get; set; }
        public int Id { get; set; } 





        //blic List<T> EmployeeList { get; set; }  //creating generic list property







        //public void Quit()  // Creating method 
        //{
        //    Console.WriteLine("I quit."); //Outputs result of calling IQuittable
        //}

        //public static bool operator== (Employee employee, Employee employee1)
        //{
        //    return employee.Id == employee1.Id;
        //}
        //public static bool operator !=(Employee employee, Employee employee1)
        //{
        //    return employee.Id != employee1.Id;
        //}
    }
}
