namespace MatchReport;
    class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Match Report!");
        const int PointsPerEnemy = 150;

        Console.Write("Enemy count: ");
        int enemyCount = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Total seconds: ");
        int totalSeconds = int.Parse(Console.ReadLine() ?? "0");

        int totalPoints = enemyCount * PointsPerEnemy;
        int minutes = totalSeconds / 60;
        int seconds = totalSeconds % 60;
        double enemyPerMinute = enemyCount * 60.0 / totalSeconds;

        Console.WriteLine($"Total Points: {totalPoints}");
        Console.WriteLine($"Time: {minutes}:{seconds:D2}");
        Console.WriteLine($"Enemies per minute: {enemyPerMinute:F2}");

    }
}