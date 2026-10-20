using System;
using System.Globalization;

namespace CSharp_HIT_Private_2026_2027
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            const int CURRENTYEAR = 2026;
            const int PASSSCORE = 5;

            string name = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double lt = double.Parse(Console.ReadLine());
            double th = double.Parse(Console.ReadLine());

            int age = CURRENTYEAR - year;
            bool isPass = lt >= PASSSCORE && th >= PASSSCORE;
            double totalScore = 0.3*lt + 0.7*th;
            int roundTotalScore = (int)totalScore;

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Pass: {isPass}");
            Console.WriteLine($"Total Score: {totalScore:F2}");
            Console.WriteLine($"Rounded Total Score: {roundTotalScore}");
        }
    }
}