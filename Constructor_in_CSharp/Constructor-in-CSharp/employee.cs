using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_in_CSharp
{
    internal class employee
    {

        public int emp_id;
        public string emp_name;
        public string emp_designation;
        public int emp_salary;

        public employee()
        {
            this.emp_id = 1001;
            this.emp_name = "akber";
            this.emp_designation = "Networking Assistant";
            this.emp_salary = 35000;

            Console.WriteLine("Employee ID: " + emp_id);
            Console.WriteLine("Employee Name: " + emp_name);
            Console.WriteLine("Employee Designation: " + emp_designation);
            Console.WriteLine("Employee Salary: " + emp_salary);
        }

        public employee(int emp_id, string emp_name, string emp_designation, int emp_salary)
        {
            this.emp_id = emp_id;
            this.emp_name = emp_name;
            this.emp_designation = emp_designation;
            this.emp_salary = emp_salary;

            Console.WriteLine("Employee ID: " + emp_id);
            Console.WriteLine("Employee Name: " + emp_name);
            Console.WriteLine("Employee Designation: " + emp_designation);
            Console.WriteLine("Employee Salary: " + emp_salary);
        }

        ~employee()
        {
            Console.WriteLine("Constructor invocked.........");
        }

    }
}
