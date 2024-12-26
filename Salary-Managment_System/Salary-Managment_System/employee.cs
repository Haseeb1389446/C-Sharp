using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_Managment_System
{
    internal class employee
    {
        public int emp_id;
        public string emp_name;
        public string emp_designation;
        public double gross_salary;
        public double tex_deduction = 0.1;
        public double net_salary;

        public employee(int id, string name, string designation, double g_salary)
        {
            emp_id = id;
            emp_name = name;
            emp_designation = designation;
            gross_salary = g_salary;
        }

        private void calculate_net_salary()
        {
            if (gross_salary >= 30000)
            {
                net_salary = gross_salary - (gross_salary * tex_deduction);
                Console.WriteLine("Your total salary is: " + net_salary);
            }
            else
            {
                Console.WriteLine("Your total salary is: " + gross_salary);
            }
        }

        public void show_salary()
        {
            Console.WriteLine(emp_id);
            Console.WriteLine(emp_name);
            Console.WriteLine(emp_designation);
            Console.WriteLine(gross_salary);

            calculate_net_salary();
        }

    }
}
