using System;
using System.Collections.Generic;
using System.Linq;

namespace _11_DragonArmy
{
    class Dragon
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Dragon> dragons = new List<Dragon>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] dragonData = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string dragonType = dragonData[0];
                string dragonName = dragonData[1];
                int damage = int.TryParse(dragonData[2], out damage) ? damage : 45;
                int health = int.TryParse(dragonData[3], out health) ? health : 250;
                int armor = int.TryParse(dragonData[4], out armor) ? armor : 10;

                if (!dragons.Any(d => d.Type == dragonType && d.Name == dragonName))
                {
                    Dragon dragon = new Dragon();
                    dragon.Type = dragonType;
                    dragon.Name = dragonName;
                    dragon.Damage = damage;
                    dragon.Health = health;
                    dragon.Armor = armor;
                    dragons.Add(dragon);
                }
                else
                {
                    Dragon dragon = dragons.Single(d => d.Type == dragonType && d.Name == dragonName);
                    dragon.Damage = damage;
                    dragon.Health = health;
                    dragon.Armor = armor;
                }                
            }

            foreach (string type in dragons.Select(d => d.Type).Distinct().ToList())
            {
                double averageDamage = dragons.Where(d => d.Type == type).Average(d => d.Damage);
                double averageHealth = dragons.Where(d => d.Type == type).Average(d => d.Health);
                double averageArmor = dragons.Where(d => d.Type == type).Average(d => d.Armor);
                Console.WriteLine($"{type}::({averageDamage:f2}/{averageHealth:f2}/{averageArmor:f2})");

                foreach (Dragon dragon in dragons.OrderBy(d => d.Name).Where(d => d.Type == type))
                {
                    Console.WriteLine($"-{dragon.Name} -> damage: {dragon.Damage}, health: {dragon.Health}, " +
                        $"armor: {dragon.Armor}");
                }
            }           
        }
    }
}
