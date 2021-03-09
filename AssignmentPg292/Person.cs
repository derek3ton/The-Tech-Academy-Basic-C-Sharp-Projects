using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPg292
{
    public class Person  
    {
        public string FirstName { get; set; }  //Sets property of class Person
        public string LastName { get; set; }  //Sets property of class person

        public void SayName()  //Declares method for class Person
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);  //Outputs result when called
        }

    }
}
