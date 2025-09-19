using System;

namespace EmployeeNetPay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Employee Name: ");
            string name = Console.ReadLine();

            Console.Write("Hours Worked: ");
            int hoursworked = Convert.ToInt32(Console.ReadLine());
            Console.Write("Rate: ");
            double rate = Convert.ToDouble(Console.ReadLine());
            Console.Write("SSS: ");
            double sss = Convert.ToDouble(Console.ReadLine());
            Console.Write("Tax: ");
            double tax = Convert.ToDouble(Console.ReadLine());
            Console.Write("Medicare: ");
            double medicare = Convert.ToDouble(Console.ReadLine());
            Console.Write("Pagibig: ");
            double pagibig = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("-------------------------");

            EmployeeNetPay employee = new EmployeeNetPay(name, hoursworked, rate, sss, tax, medicare, pagibig);

            employee.display();
            Console.ReadKey();
        }
    }
}
