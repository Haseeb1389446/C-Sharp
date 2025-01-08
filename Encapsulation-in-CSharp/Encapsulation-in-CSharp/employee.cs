using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_in_CSharp
{
    internal class employee
    {

        private int empID;
        private string empName;
        private string empDesignation;
        private int empSalary;

        public void setData(int id, string name, string designation, int salary)
        {

            empID = id;
            empName = name;
            empDesignation = designation;
            empSalary = salary;

            Console.WriteLine(this.empID);
            Console.WriteLine(this.empName);
            Console.WriteLine(this.empDesignation);
            Console.WriteLine(this.empSalary);

        }

    }
}
