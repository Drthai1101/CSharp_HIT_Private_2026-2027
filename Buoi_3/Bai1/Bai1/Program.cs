using System;
using System.Collections.Generic;

namespace Bai1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> bag = new List<string> { "ammo", "shield", "ammo", "potion" };
            bag.Add("shield");
            bag.RemoveAt(4);
            Console.WriteLine("Cac vat pham con lai: ");

            foreach (string item in bag)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Tong so mon: {bag.Count}");

            Dictionary<string, int> inventory = new Dictionary<string, int>();

            HashSet<string> UItem = new HashSet<string>();

            foreach (string item in bag)
            {
                if (inventory.ContainsKey(item))
                {
                    inventory[item]++;
                }
                else
                {
                    inventory.Add(item, 1);
                }

                inventory.Add(item, inventory[item]);
            }



        }
    }
}