namespace Buoi_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter current HP: ");
            int currentHP = int.Parse(Console.ReadLine() ?? "0");

            int[] potions = { 10, 25, 50 };

            for (int i = 0; i < potions.Length; i++)
            {
                currentHP += potions[i];

                if (currentHP >= 100)
                {
                    currentHP = 100;
                    break;
                }
            }

            Console.WriteLine($"So binh thuoc da su dung: {potions.Length}");
            Console.WriteLine($"Your HP after use potions: {currentHP}");

        }
    }
}