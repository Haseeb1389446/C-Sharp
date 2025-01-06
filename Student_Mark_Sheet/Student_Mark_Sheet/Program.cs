using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Mark_Sheet
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("**********Mark Sheet************");
            Console.WriteLine();

            //Get Data

            Console.WriteLine("Enter your ID: ");
            int std_id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Name: ");
            string std_name = Console.ReadLine();

            Console.WriteLine("Enter your english Marks: ");
            int eng = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your comp Marks: ");
            int comp = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Math Marks: ");
            int math = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Physics Marks: ");
            int phy = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Chemistry Marks: ");
            int chem = int.Parse(Console.ReadLine());

            int obt = eng + math + phy + chem + comp;
            double per = obt * 100 / 500;

            Console.WriteLine();

            Console.WriteLine("---------------");

            //Show Data

            Console.WriteLine("Student ID : " + std_id);
            Console.WriteLine("Student Name : " + std_name);
            Console.WriteLine("English : " + eng);
            Console.WriteLine("Computer : " + comp);
            Console.WriteLine("Math : " + math);
            Console.WriteLine("Physics: " + phy);
            Console.WriteLine("Chemistry: " + chem);
            Console.WriteLine("Obtain Marks : " + obt);
            Console.WriteLine("Total Marks : " + 500);
            Console.WriteLine("Percentage : " + per + "%");

            if (eng <= 35 || comp <= 35 || math <= 35 || phy <= 35 || chem <= 35)
            {
                Console.WriteLine("Grade : Fail....");
                Console.WriteLine("Subject Failed in:");

                if (eng <= 35) Console.WriteLine(" - English");
                if (comp <= 35) Console.WriteLine(" - Computer");
                if (math <= 35) Console.WriteLine(" - Math");
                if (phy <= 35) Console.WriteLine(" - Physics");
                if (chem <= 35) Console.WriteLine(" - Chemistry");

            }
            else
            {
                if (per >= 80)
                {
                    Console.WriteLine("Grade : A1");
                }
                else if (per >= 70)
                {
                    Console.WriteLine("Grade : A");
                }
                else if (per >= 60)
                {
                    Console.WriteLine("Grade : B");
                }
                else if (per >= 50)
                {
                    Console.WriteLine("Grade : C");
                }
                else if (per >= 40)
                {
                    Console.WriteLine("Grade : D");
                }
                else
                {
                    Console.WriteLine("Grade : Fail....");
                }
            }


            Console.ReadKey();

        }
    }
}
