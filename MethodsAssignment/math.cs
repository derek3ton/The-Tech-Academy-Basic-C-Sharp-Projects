using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssignment
{
    public class Math
    {

        public int Add { get; set; }
        public int Sub { get; set; }
        public int Mult { get; set; }

        public int Addition(int num1)
        {
            return num1 + Add;
        }

        public int Subtraction(int num2)
        {
            return num2 - Sub;
        }
       
        public int Multiplication(int num3)
        {
            return num3 * Mult;
        }
    }
     
}
