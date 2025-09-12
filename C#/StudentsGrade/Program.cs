using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsGrade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("INPUT THE CURRENT GRADE: ");
            int currentgrade = Convert.ToInt32(Console.ReadLine());

            if (currentgrade > 90)

            {
                Console.WriteLine("THE NEW GRADE:" + currentgrade); 

            }

            else
            {
                Console.WriteLine("THE NEW GRADE: " + (currentgrade + 5));
            }

               
        }
    }
}
