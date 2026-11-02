namespace Bai2
{
    public class Program
    {
        static int CalculateTotalDamage(int[] damage)
        {
            int totalDamage = 0;
            for (int i = 0; i < damage.Length; i++)
            {
                totalDamage += damage[i];
            }
            return totalDamage;
        }
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine() ?? "0");
            int[] attack = new int[n];
            int danhTrung = 0;
            for (int i = 0; i < n; i++)
                attack[i] = int.Parse(Console.ReadLine() ?? "0");
            int attackLonNhat = attack[0];
            int tongDamage = CalculateTotalDamage(attack);
            for (int i = 0; i < n; i++)
            {

                if (attack[i] != 0)
                    danhTrung++;

                if (attack[i] > attackLonNhat)
                    attackLonNhat = attack[i];

            }
            int danhTruot = n - danhTrung;

            Console.WriteLine($"Tong sat thuong: {tongDamage}");
            Console.WriteLine($"So don danh trung: {danhTrung}");
            Console.WriteLine($"So don danh truot: {danhTruot}");
            Console.WriteLine($"Sat thuong lon nhat: {attackLonNhat}");

        }
    }
}