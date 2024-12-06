using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restart_Statement
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //----------------- Restart With Do While Loop---------------

            //string confirm;

            //do {

            //    Console.WriteLine("Enter First Number:");
            //    int num1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter Second Number:");
            //    int num2 = int.Parse(Console.ReadLine());

            //    int total = num1 + num2;
            //    Console.WriteLine("The sum of num and num2 is: " + total);
            //    Console.WriteLine("Do you want to restart the game : yes/no ");
            //    confirm = Console.ReadLine().ToLower();

            //} while (confirm == "yes");

            //Console.WriteLine("Game is over...");
            //Console.ReadKey();


            //----------------- Restart With While Loop & Continue / breake statement---------------


            string confirm;

            while (true)
            {
                Console.WriteLine("Enter First Number:");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second Number:");
                int num2 = int.Parse(Console.ReadLine());

                int total = num1 + num2;
                Console.WriteLine("The sum of num and num2 is: " + total);
                Console.WriteLine("Do you want to restart the game : yes/no ");
                confirm = Console.ReadLine().ToLower();

                if (confirm == "yes")
                {
                    continue;
                }else
                {
                    break;
                }

            }

            Console.WriteLine("The game is over...");
            Console.ReadKey();

        }
    }
}
