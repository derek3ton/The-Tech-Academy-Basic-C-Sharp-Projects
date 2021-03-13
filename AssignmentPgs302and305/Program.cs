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

            List<Employee> employeeList = new List<Employee>();  //Creating a list 
            employeeList.Add(new Employee() { First = "Joe", Last = "Smith", Id = 1 });
            employeeList.Add(new Employee() { First = "Craig", Last = "Johnson", Id = 2 });
            employeeList.Add(new Employee() { First = "Joe", Last = "Matthews", Id = 3 });
            employeeList.Add(new Employee() { First = "Sam", Last = "Lowe", Id = 4 });
            employeeList.Add(new Employee() { First = "Julie", Last = "Goodall", Id = 5 });
            employeeList.Add(new Employee() { First = "Veronica", Last = "Black", Id = 6 });
            employeeList.Add(new Employee() { First = "Harry", Last = "Jones", Id = 7 });
            employeeList.Add(new Employee() { First = "Brian", Last = "Williams", Id = 8 });
            employeeList.Add(new Employee() { First = "Red", Last = "Caples", Id = 9 });
            employeeList.Add(new Employee() { First = "Nick", Last = "West", Id = 10 });

            List<Employee> duplicates = new List<Employee>(); //Defining a new list for duplicates

            foreach (Employee employee in employeeList) //Foreach loop to iterate through list
            {
                if (employee.First == "Joe")  //If statement to catch and add duplicates to new list
                {
                    duplicates.Add(employee);  //Adding duplicates to new list
                    Console.WriteLine(employee.First);  //Outputting to check result
                }
            }


            List<Employee> duplicates2 = employeeList.Where(x => x.First == "Joe").ToList(); //Lamda function to add duplicates to new list
            foreach (Employee employee in duplicates2) //Foreach to iterate through list 
            {
                Console.WriteLine(employee.First); //Outputs duplicates to console.
            }

            List<Employee> list2 = employeeList.Where(x => (x.Id > 5)).ToList();  //Lamda function to add all greater than ID 5 and add to new list
            foreach (Employee employee in list2)  //ForEach to iterate through
            {
                Console.WriteLine("Name: " + employee.First + " " + employee.Last + " " + "Id: " + employee.Id); //outputs result to console.
            } 
            




            //Employee<> employee = new Employee<>(); //Instantiating employee class

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

            //Employee<string> list1 = new Employee<string>();  //Instantiates 
            //list1.Things = new List<string>();  //Creates new list
            //list1.Things.Add("Hammer");
            //list1.Things.Add("Basketball");
            //list1.Things.Add("Balloon");

            //Employee<int> list2 = new Employee<int>();  //Instantiates 
            //list2.Things = new List<int>();  //Creates new list
            //list2.Things.Add(97865);
            //list2.Things.Add(1556);
            //list2.Things.Add(345);

            //for (int i = 0; i < list1.Things.Count ; i++)  //Loop to iterate through lists and display results
            //{
            //    Console.WriteLine(list1.Things[i].ToString() + ", " + list2.Things[i].ToString());
            //}



            Console.ReadLine();
        }
    }
}
