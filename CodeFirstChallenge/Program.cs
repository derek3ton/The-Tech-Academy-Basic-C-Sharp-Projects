using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                Console.WriteLine("Please enter your fist name.");
                string fName = Console.ReadLine();
                Console.WriteLine("Please enter your last name.");
                string lName = Console.ReadLine();

                var student = new Student() { FirstName = fName, LastName = lName };
                db.Students.Add(student);
                db.SaveChanges();
            }
            Console.ReadLine();
        }
    }
}
