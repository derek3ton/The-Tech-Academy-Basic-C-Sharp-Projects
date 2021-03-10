using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPgs302and305
{
    public abstract class Person  //Creating abstract class "Person"
    {
        public string firstName { get; set; }  //Setting property to class
        public string lastName { get; set; }

        public void SayName()  //Defining method to be used
        {
            Console.WriteLine("Name: " + firstName + " " + lastName); //Outputting result of the method
        }
    }
}
