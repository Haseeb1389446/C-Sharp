using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string confirm;

            do
            {
                Console.WriteLine("Welcome to the C# Calculator!");
                Console.WriteLine();


                // Input first number
                Console.WriteLine("Enter the first number:");
                int num1 = int.Parse(Console.ReadLine());

                // Input second number
                Console.WriteLine("Enter the Second number:");
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine();

                // Input operator
                Console.WriteLine("Select an operator:");
                Console.WriteLine("1. +");
                Console.WriteLine("2. -");
                Console.WriteLine("3. *");
                Console.WriteLine("4. /");

                Console.WriteLine();
                int oper = int.Parse(Console.ReadLine());

                Console.WriteLine();

                // Perform calculation
                switch (oper)
                {
                    case 1:
                        Console.WriteLine($"The sum of {num1} and {num2} is: {num1 + num2}");
                        break;
                    case 2:
                        Console.WriteLine($"The sub of {num1} and {num2} is: {num1 - num2}");
                        break;
                    case 3:
                        Console.WriteLine($"The mul of {num1} and {num2} is: {num1 * num2}");
                        break;
                    case 4:

                        if (num1 != 0 && num2 != 0)
                        {
                            Console.WriteLine($"The div of {num1} and {num2} is: {num1 / num2}");
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid operation selected!");
                        break;
                }

                Console.WriteLine("Do you want to recalculate your values ​​or not? yes/no");
                confirm = Console.ReadLine().ToLower();

            }
            while (confirm == "yes");

            Console.WriteLine("You can shut down the Application...");
            Console.ReadKey();


        }
    }
}
