using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dynamic_tables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Random Table Generator

            Console.WriteLine("Enter the table value:");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num + " x " + i + " = " +num*i);
            }

            Console.ReadKey();
        }
    }
}
