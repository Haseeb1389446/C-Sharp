using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_Managment_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            employee emp1 = new employee(1001, "Harry", "Frontend Developer", 26000);

            emp1.show_salary();

            Console.WriteLine("-----------------");

            employee emp2 = new employee(1002, "Steave", ".Net developer", 86000);

            emp2.show_salary();

            Console.ReadKey();
        }
    }
}
