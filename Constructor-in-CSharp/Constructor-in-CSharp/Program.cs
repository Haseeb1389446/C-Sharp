using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_in_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            employee emp1 = new employee();

            Console.WriteLine("----------------");

            employee emp2 = new employee(1002, "danish", "DB Manager", 70000);

            //Console.ReadKey();

        }
    }
}
