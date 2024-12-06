using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_merger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Name Merger

            Console.WriteLine("Enter Your First Name:");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter Your Last Name:");
            string lname = Console.ReadLine();

            Console.WriteLine("Here Is Your Name: " + fname + " " + lname);
            Console.ReadKey();

        }
    }
}
