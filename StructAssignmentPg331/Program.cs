using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignmentPg331
{
    class Program
    {
        public struct Number //Creates struct
        {
            public decimal Amount { get; set; }  //Sets Amount as property of struct Number
        }


        static void Main(string[] args)
        {
            Number number = new Number(); //Instantiates Number
            number.Amount = 120;  //Sets value 

            Console.WriteLine(number.Amount); //Outputs the value to console

            Console.ReadLine();
        }
    }
}
