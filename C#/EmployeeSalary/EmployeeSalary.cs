using System;

namespace EmployeeSalary
{
    public class EmployeeSalary
    {
        public string Name { get; set; }
        public int HoursWorked { get; set; }

        public EmployeeSalary(string name, int hoursWorked)
        {
            Name = name;
            HoursWorked = hoursWorked;
        }

        public double ComputeSalary()
        {
            int regularHours = 40;
            double regularRate = 50;
            double overtimeRate = 30;

            if (HoursWorked <= regularHours)
            {
                return HoursWorked * regularRate;
            }
            else
            {
                int overtimeHours = HoursWorked - regularHours;
                return (regularHours * regularRate) + (overtimeHours * overtimeRate);
            }
        }

        public override string ToString()
        {
            return $"Employee Name: {Name}\n" +
                   $"Hours Worked: {HoursWorked}\n" +
                   $"\n{Name}`s Salary is {ComputeSalary():N2}";
        }
        public void display()
        {
            Console.WriteLine(this.ToString());
        }
    }

}

