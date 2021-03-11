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
            //Employee employee = new Employee(); //Instantiating employee class 
            //employee.firstName = "Sample";  //Initializing employee class and setting variable
            //employee.lastName = "Student";

            //employee.SayName();  //Calling method and displaying result. 

            //IQuittable quittable = new Employee(); //Instantiating new IQuittable object from Employee class
            //quittable.Quit();  //Calling Method displaying result


            //employee.Id = 21; //Assign value to employee property Id 
            //Employee employee1 = new Employee(); //Instantiating employee1 object
            //employee1.Id = 32; //Assigns value to employee1 property Id

            //Console.WriteLine(employee1 == employee); //Compares the two objects and returns false
            //Console.WriteLine(employee1 != employee); //Compares the two objects and returns true

            Employee<string> list1 = new Employee<string>();  //Instantiates 
            list1.Things = new List<string>();  //Creates new list
            list1.Things.Add("Hammer");
            list1.Things.Add("Basketball");
            list1.Things.Add("Balloon");

            Employee<int> list2 = new Employee<int>();  //Instantiates 
            list2.Things = new List<int>();  //Creates new list
            list2.Things.Add(97865);
            list2.Things.Add(1556);
            list2.Things.Add(345);

            for (int i = 0; i < list1.Things.Count ; i++)  //Loop to iterate through lists and display results
            {
                Console.WriteLine(list1.Things[i].ToString() + ", " + list2.Things[i].ToString());
            }

            Console.ReadLine();
        }
    }
}
