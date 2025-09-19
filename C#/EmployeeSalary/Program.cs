using System;

namespace EmployeeSalary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Employee Name: ");
            string empName = Console.ReadLine();

            Console.Write("Enter Hours Worked: ");
            int hrsWorked = Convert.ToInt32(Console.ReadLine());

            EmployeeSalary emp = new EmployeeSalary(empName, hrsWorked);

            emp.display();
        }
    }
}
