using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            while (x != 11)
            {
                Console.WriteLine("The value of 'x' is: " + x);
                x++;
            }

            int z = 11;
            do
            {
                Console.WriteLine("The value of 'z' is: " + z);
                z++;
            }
            while (z != 21);
            Console.ReadLine();
        }
    }
}
