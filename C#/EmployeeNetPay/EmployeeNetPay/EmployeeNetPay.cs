using System;

namespace EmployeeNetPay
{
    public class EmployeeNetPay
    {
        string empname;
        int hoursworked;
        double rate, sss, tax, medicare, pagibig;

        public EmployeeNetPay(string empname, int hoursworked, double rate, double sss, double tax, double medicare, double pagibig)
        {
            this.empname = empname;
            this.hoursworked = hoursworked;
            this.rate = rate;
            this.sss = sss;
            this.tax = tax;
            this.medicare = medicare;
            this.pagibig = pagibig;
        }

        
        public double computeGross()
        {
            return hoursworked * rate;
        }

      
        public double computeDeduction()
        {
            return sss + tax + medicare + pagibig;
        }

        
        public double computeNetPay()
        {
            return computeGross() - computeDeduction();
        }

        public override string ToString()
        {
            return "\n" + empname + " Gross is " + computeGross().ToString("N2") + "\nTotal Deduction is " + computeDeduction().ToString("N2") + "\nNetpay will be " + computeNetPay().ToString("N2");                   
        }

        public void display()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
