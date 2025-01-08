using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_in_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Encapsulation

            employee emp = new employee();

            emp.setData(101, "Ali", "Manager", 100000);

            Console.ReadKey();

        }
    }
}
