using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //------------ Example 1 -------------

            string[] myarr = new string[3];

            myarr[0] = "John";
            myarr[1] = "Freddy";
            myarr[2] = "Mic";

            Console.WriteLine(myarr[1]);
            Console.ReadKey();

            //------------ Example 2 -------------

            string[] myarr = new string[] { "John", "Freddy", "Mic" };

            Console.WriteLine(myarr[0]);
            Console.ReadKey();

            //------------ Example 3 -------------

            string[] myarr = { "John", "Freddy", "Mic" };

            Console.WriteLine(myarr[3]);
            Console.ReadKey();

            //------------ Array With For Loop ---------

            int[] myarr = { 20, 50, 75, 32, 14 };

            for (int i = 0; i < myarr.Length; i++)
            {
                Console.WriteLine(myarr[i]);
            }

            Console.ReadKey();

            //----------- Array With ForEach Loop -------

            int[] myarr = { 54, 23, 51, 54, 89 };

            foreach (int index in myarr)
            {
                Console.WriteLine(index);
            }

            Console.ReadKey();

            //----------- Double Dimension Array ------------

            int[,] myarr = new int[3, 4]
            {
                { 45, 20, 75, 50 },
                { 20, 54, 89, 28 },
                { 46, 76, 94, 23 }
            };

            for (int i = 0; i < myarr.GetLength(0); i++)
            {
                for (int j = 0; j < myarr.GetLength(1); j++)
                {
                    Console.WriteLine(myarr[i, j] + " ");    // Verticle  
                    Console.Write(myarr[i, j] + " ");          // Horizontal
                }

                Console.WriteLine();

            }

            Console.ReadKey();

            //----------- Jagged Array -----------------

            int[][] myarr = new int[3][];

            myarr[0] = new[] { 50, 12, 30, 56, 85 };
            myarr[1] = new[] { 12, 45, 23 };
            myarr[2] = new[] { 91, 23, 58, 94, 74, 63 };


            for (int i = 0; i < myarr.GetLength(0); i++)
            {
                for (int j = 0; j < myarr[i].Length; j++)
                {
                    Console.Write(myarr[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();

            //------------- Array With User Input -----------

            Console.WriteLine("Enter The Array Length:");
            int arrlength = int.Parse(Console.ReadLine());

            Console.WriteLine();

            int[] myarr = new int[arrlength];

            for ( int i = 0; i < arrlength; i++ )
            {
                Console.WriteLine($"Enter The {i} Array Value:");
                int arrvalue = int.Parse(Console.ReadLine());
                myarr[i] = arrvalue;
            }

            Console.WriteLine();

            Console.WriteLine("----------- Array Data ---------");

            foreach (int index in myarr)
            {
                Console.WriteLine(index);
            }

            Console.ReadKey();

        }
    }
}
