using System;

class Tank
{
    private int _hp = 100;

    public string Name { get; set; } = "Tank";

    public int Hp
    {
        get { return _hp; }
    }

    public bool IsDestroyed
    {
        get { return Hp == 0; }
    }

    public void TakeDamage(int damage)
    {
        if (damage > 0)
        {
            _hp = Math.Max(0, _hp - damage);
        }
    }
}

class Program
{
    static void Main()
    {
        Tank tank = new Tank();
        tank.Name = "Armor";
        Console.WriteLine($"{tank.Name}: {tank.Hp}");

        tank.TakeDamage(30);
        Console.WriteLine($"{tank.Name}: {tank.Hp}");
        Console.WriteLine(tank.IsDestroyed);

        tank.TakeDamage(70);
        Console.WriteLine(tank.IsDestroyed);
    }
}