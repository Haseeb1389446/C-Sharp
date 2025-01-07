using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_And__Generics
{

    public delegate int calculation(int num1, int num2);

    internal class operations
    {

        public static int addition(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int subtraction(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int multiplication(int num1, int num2)
        {
            return num1 * num2;
        }

    }
}
