using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPg226
{
    public class Math
    {
        public int Add { get; set; }
        public decimal Mult { get; set; }
        public string Div { get; set; }


        public int Addition(int num1)
        {
            return num1 + Add;
        }

        public int Multiply(decimal num2)
        {
            int prod = Convert.ToInt32(num2 * Mult);
            return prod;
        }

        public int Divide(string num3)
        {
            int div1 = Convert.ToInt32(Div);
            int div2 = Convert.ToInt32(num3);
            int quot = Convert.ToInt32(div1 / div2);
            return quot;
        }

    }
}
