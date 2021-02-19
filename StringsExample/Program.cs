using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string fName;
            string bMonth;
            int bYear;

            Console.WriteLine("What is your first name?");
            fName = Convert.ToString(Console.ReadLine());

            Console.WriteLine("What month were you born?");
            bMonth = Convert.ToString(Console.ReadLine());

            Console.WriteLine("What year were you born?");
            bYear = Convert.ToInt32(Console.ReadLine());

            string fullString = ("Hello, " + fName + ", you were born in the month of " + bMonth + ", in the year " + bYear + ".");
           
            fullString = fullString.ToUpper();
            Console.WriteLine(fullString);

            Console.WriteLine('\n');

            StringBuilder sb = new StringBuilder();
            sb.Append("This is an example of how StringBuilder works.\n");
            sb.Append("It will connect multiple strings");
            sb.Append(" and display as one string. \n");
            sb.Append("A key difference in string vs StringBuilder is \n");
            sb.Append("a string is immutable and a StringBuilder is mutable.");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
