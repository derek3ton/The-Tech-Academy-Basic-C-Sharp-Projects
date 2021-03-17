using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPg383
{
    public class Person
    {
        public string Name { get; set; } //Defining property of Person class
        public int Age { get; set; }

        public Person(string name) : this(name, 42) //Creating constructor with name parameter and chaining to another
        {           
        }
        public Person(int age) : this("Derek", age) //Creating constructor with age parameter and chaining
        {
        }

        public Person(string name, int age) //Creating construnctor with two parameters and defining variables
        {
            Name = name;
            Age = age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            const string myName = "Derek";  //creating constant variable and giving value
            var myAge = 42;  //creating variable using var keyword and assigning a value
            Console.WriteLine("My name is {0} and I am currently {1} years old.", myName, myAge);  //displaying string on console

            Person person = new Person("Derek", 42);  //instantiating person class and passing in parameters 

            Console.WriteLine(person.Name + ", " + person.Age); //displaying result to console.

            Console.ReadLine();
        }
    }
}
