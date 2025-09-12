using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetPay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Employee Name:");
            string employee_name = Console.ReadLine();
            Console.Write("Input Number of Hours:");
            int employee_num_hour = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Rates Per Work:");
            int employee_rate_work = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input SSS:");
            int employee_sss = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Tax:");
             int employee_tax = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Medicare:");
            int employee_med = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Pag-ibig:");
            int employee_pagibig = Convert.ToInt32(Console.ReadLine());

            int gross_pay = employee_num_hour * employee_rate_work;
            int total_deduct = employee_sss + employee_med + employee_tax + employee_pagibig;
            int net_pay = gross_pay - total_deduct;

            Console.WriteLine($"\nThe Gross Pay: {gross_pay}");
            Console.WriteLine($"The Total Deduction: {total_deduct}");
            Console.WriteLine($"The Net Pay: {net_pay}");
        }
    }
}
