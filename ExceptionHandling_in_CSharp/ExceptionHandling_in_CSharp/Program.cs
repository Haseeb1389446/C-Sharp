using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling_in_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Example 1

            Console.WriteLine("****** Division *****");
            Console.WriteLine();

            // try
            // {
            // Console.WriteLine("Enter NUM1 : ");
            // int num1 = int.Parse(Console.ReadLine());

            // Console.WriteLine("Enter NUM2 : ");
            // int num2 = int.Parse(Console.ReadLine());

            // Console.WriteLine("Division rezult is : " + num1 / num2);
            // }
            // catch(Exception ex)
            // {
            //    Console.WriteLine($"Error: {ex.Message}");
            // }

            try
            {
                Console.WriteLine("Enter NUM1 : ");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter NUM2 : ");
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Division rezult is : " + num1 / num2);
            }
            catch (DivideByZeroException ex1)
            {
                Console.WriteLine($"Error: {ex1.Message}");
            }
            catch (FormatException ex2)
            {
                Console.WriteLine($"Error: {ex2.Message}");
            }
            finally
            {
                Console.WriteLine("Execution Completed...");
            }


            Console.WriteLine("----------------");

            //Example 2

            int[] myArray = { 1, 2, 3 };


            try
            {
                Console.WriteLine(myArray[10]);
            }
            catch(IndexOutOfRangeException ex3)
            {
                Console.WriteLine($"Error: {ex3.Message}");
            }
            finally
            {
                Console.WriteLine("Execution Completed...");
            }

            Console.ReadKey();

        }
    }
}
