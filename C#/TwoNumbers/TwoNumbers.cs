using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TwoNumbers
{
    internal class TwoNumbers
    {
        public int FirstNum, SecondNum, result;

        public TwoNumbers(int num1, int num2, int num)
        {

            this.FirstNum = num1;
            this.SecondNum = num2;
            this.result = num;
        }
            public int computeSum()
            {
            return result = FirstNum + SecondNum;
            }

        public void displaySum()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return FirstNum + " + " + SecondNum + " = " + result;
        }


        public static void Main(string[] args)
        {

            int num1, num2;
            int result = 0;

            Console.WriteLine("input first number: ");
               num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input second number:");
                num2 = Convert.ToInt32(Console.ReadLine());
          
               

            TwoNumbers total = new TwoNumbers(num1, num2, result);
            total.computeSum();
            total.displaySum();


        }



    }
}
