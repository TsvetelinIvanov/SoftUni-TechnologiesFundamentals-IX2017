using System;
using System.Collections.Generic;

namespace _11DragonArmy
{
    class Program
    {        
        static void Main(string[] args)
        {
            Dictionary<string, SortedDictionary<string, Dictionary<string, int>>> dragons = new Dictionary<string, SortedDictionary<string, Dictionary<string, int>>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] dragonData = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string dragonType = dragonData[0];
                string dragonName = dragonData[1];
                int damage = int.TryParse(dragonData[2], out damage) ? damage : 45;
                int health = int.TryParse(dragonData[3], out health) ? health : 250;
                int armor = int.TryParse(dragonData[4], out armor) ? armor : 10;

                if (!dragons.ContainsKey(dragonType))
                {
                    dragons.Add(dragonType, new SortedDictionary<string, Dictionary<string, int>>());
                }

                if (!dragons[dragonType].ContainsKey(dragonName))
                {
                    dragons[dragonType][dragonName] = new Dictionary<string, int>();
                    dragons[dragonType][dragonName]["damage"] = 0;
                    dragons[dragonType][dragonName]["health"] = 0;
                    dragons[dragonType][dragonName]["armor"] = 0;
                }
                else
                {
                    dragons[dragonType][dragonName].Clear();
                }

                dragons[dragonType][dragonName]["damage"] = damage;
                dragons[dragonType][dragonName]["health"] = health;
                dragons[dragonType][dragonName]["armor"] = armor;
            }
            
            Dictionary<string, string> dragonStats = new Dictionary<string, string>();
            foreach (KeyValuePair<string, SortedDictionary<string, Dictionary<string, int>>> dragonType in dragons)
            {
                long typeTotalDamage = 0;
                long typeTotalHealth = 0;
                long typeTotalArmor = 0;
                int dragonsCount = 0;
                dragonStats[dragonType.Key] = string.Empty;
                foreach (KeyValuePair<string, Dictionary<string, int>> dragonName in dragonType.Value)
                {
                    dragonsCount++;
                    typeTotalDamage += dragonName.Value["damage"];
                    typeTotalHealth += dragonName.Value["health"];
                    typeTotalArmor += dragonName.Value["armor"];                   
                }

                double typeAverageDamage = (double)typeTotalDamage / dragonsCount;
                double typeAverageHealth = (double)typeTotalHealth / dragonsCount;
                double typeAverageArmor = (double)typeTotalArmor / dragonsCount;
                string typeAverageStatsString = $"{typeAverageDamage:f2}/{typeAverageHealth:f2}/{typeAverageArmor:f2}";
                dragonStats[dragonType.Key] = typeAverageStatsString;
            }

            foreach (KeyValuePair<string, SortedDictionary<string, Dictionary<string, int>>> dragonType in dragons)
            {
                Console.WriteLine($@"{dragonType.Key}::({dragonStats[dragonType.Key]})");
                foreach (KeyValuePair<string, Dictionary<string, int>> dragonName in dragonType.Value)
                {
                    Console.Write($"-{dragonName.Key} -> ");
                    string statsString = string.Empty;
                    foreach (KeyValuePair<string, int> stat in dragonName.Value)
                    {
                        statsString += $"{stat.Key}: {stat.Value}, ";
                    }

                    statsString = statsString.Remove(stats.Length - 2, 2);
                    Console.WriteLine(statsString);
                }
            }
        }
    }
}
