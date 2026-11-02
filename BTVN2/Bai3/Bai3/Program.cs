using System.Runtime.InteropServices;

namespace Bai3
{
    public class Program
    {
        static int CalculateScore(int kills, int assists)
        {
            return kills * 100 + assists * 30;
        }
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine() ?? "0");
            string name;
            int kills;
            int assists;

            int score;
            string topName = "";
            int topScore = -1;
            for (int i = 0; i < n; i++)
            {
                name = Console.ReadLine() ?? "";
                kills = int.Parse(Console.ReadLine() ?? "0");
                assists = int.Parse(Console.ReadLine() ?? "0");

                score = CalculateScore(kills, assists);
                Console.WriteLine($"{name}: {score} diem");

                if (score > topScore)
                {
                    topScore = score;
                    topName = name;
                }
            }

            Console.WriteLine($"Dan dau: {topName}");
            Console.WriteLine($"Diem cao nhat: {topScore}");
        }
    }
}