using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizza_application
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //pizza Selection App

            Console.WriteLine("What kind of pizza do you want to eat?");
            string pizza = Console.ReadLine();

            switch (pizza)
            {
                case "fajita":
                    Console.WriteLine("You have Selected the Fajita type...");
                    break;
                case "supremme":
                    Console.WriteLine("You have Selected the Supremme type...");
                    break;
                case "cheese":
                    Console.WriteLine("You have Selected the Cheese type...");
                    break;
                case "vegitable":
                    Console.WriteLine("what Vegitable type do you want to eat...");
                    string vegi = Console.ReadLine();
                    switch (vegi)
                    {
                        case "olive":
                            Console.WriteLine("You have selected the Olive Vegitable Pizza type...");
                            break;
                        case "Grilled":
                            Console.WriteLine("You have selected the Grilled Vegitable Pizza type...");
                            break;
                        case "white":
                            Console.WriteLine("You have selected the White Vegitable Pizza type...");
                            break;
                        default: Console.WriteLine("plzzz, Select the Valid Vegitable Pizza type !!!");
                            break;
                    }
                    break;
                default: Console.WriteLine("plzzz, Enter valid pizza type !!!");
                    break;

            }
        }
    }
}
