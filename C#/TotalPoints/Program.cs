using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalPoints
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("================Quizzes================");

            Console.Write("Enter the score of the first quiz: ");
            int FirstQuiz = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the score of the second quiz: ");
            int SecondQuiz = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the score of the third quiz: ");
            int ThirdQuiz = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n================Mid-Term================");

            Console.Write("Enter the score of the Mid-Term: ");
            int MidTerm = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n================Final================");

            Console.Write("Enter the score of the Final: ");
            int Final = Convert.ToInt32(Console.ReadLine());


            int TotalQuiz = FirstQuiz + SecondQuiz + ThirdQuiz;
            Console.WriteLine($"\nQuiz Total: {TotalQuiz}");
            Console.WriteLine($"Mid-Term: {MidTerm}");
            Console.WriteLine($"Final: {Final}");
            Console.WriteLine("................");
            Console.WriteLine($"Total: {TotalQuiz + MidTerm + Final}");
        }
    }
}
