using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_And__Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Addition

            calculation add = new calculation(operations.addition);
            Console.WriteLine(add(12, 3));

            // Subtraction

            calculation sub = new calculation(operations.subtraction);
            Console.WriteLine(sub(20, 2));

            // Multiplication

            calculation mul = new calculation(operations.multiplication);
            Console.WriteLine(mul(10, 12));

            Console.ReadKey();

        }
    }
}
