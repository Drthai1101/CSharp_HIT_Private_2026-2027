using System.Globalization;

namespace CharacterCard
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your Character!");
            Console.Write("Name: ");
            string name = Console.ReadLine() ?? "";

            Console.Write("HP: ");
            int hp = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Speed: ");
            double speed = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);

            Console.Write("Rank: ");
            char rank = char.Parse(Console.ReadLine() ?? "");

            bool isAlive = hp > 0;

            Console.WriteLine("Here is your character:");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"HP: {hp}");
            Console.WriteLine($"Speed: {speed:F1}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Is Alive: {isAlive}");
        }
    }
}