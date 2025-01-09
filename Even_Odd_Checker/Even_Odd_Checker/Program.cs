using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Even_Odd_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a Number : ");

            int number;
            bool IsValid = int.TryParse(Console.ReadLine(), out number);

            if (IsValid)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine($"{number} is Even.");
                }
                else
                {
                    Console.WriteLine($"{number} is Odd.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
            }

            Console.ReadKey();

        }
    }
}
