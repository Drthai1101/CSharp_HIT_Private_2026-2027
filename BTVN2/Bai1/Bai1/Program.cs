namespace Bai1
{
    public class Program
    {
        static int CalculateDamage(int attack, int armor)
        {
            int damage = attack - armor;
            if (damage <= 0)
                return damage = 0;
            return damage;
        }
        static int CalculateRemainingHp(int currentHp, int damage)
        {
            int newHp = currentHp - damage;
            if (newHp <=0 )
                return newHp = 0;
            return newHp;
        }
        public static void Main(string[] args)
        {
            int initialHp = int.Parse(Console.ReadLine() ?? "0");
            int armor = int.Parse(Console.ReadLine() ?? "0");
            int n = int.Parse(Console.ReadLine() ?? "0");
            int[] attackDamage = new int[n];

            for (int i=0; i<n; i++)
                attackDamage[i] = int.Parse(Console.ReadLine() ?? "0");
 
            int currentHp = initialHp;
            int dem = 0;
            for (int i = 0; i < n && currentHp > 0; i++)
            {
                int damage = CalculateDamage(attackDamage[i], armor);
                currentHp = CalculateRemainingHp(currentHp, damage);
                dem++;

                Console.WriteLine($"Don {i+1}: Sat thuong {damage} | HP {currentHp}");
            }

            Console.WriteLine($"So don xu ly: {dem}");
            Console.WriteLine($"Tong HP da mat: {initialHp-currentHp}");

            Console.Write("Trangthai: ");
            if (currentHp > 0)
                Console.WriteLine("Song sot");
            else
            {
                Console.WriteLine("Da bi ha");
                Console.WriteLine($"So don ket lieu: {dem}");
            }
        }
    }
}