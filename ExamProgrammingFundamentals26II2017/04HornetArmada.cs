using System;
using System.Collections.Generic;
using System.Linq;

namespace _04HornetArmada
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> soldierTypeAndCountLegions =
                new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string, int> legionLastActivities = new Dictionary<string, int>();
            int legionDataCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < legionDataCount; i++)
            {
                string[] legionData = Console.ReadLine()
                    .Split(new char[] { ' ', '=', '-', '>', ':' }, StringSplitOptions.RemoveEmptyEntries);
                int activity = int.Parse(legionData[0]);
                string name = legionData[1];
                string type = legionData[2];
                long count = long.Parse(legionData[3]);
                if (!soldierTypeAndCountLegions.ContainsKey(name))
                {
                    soldierTypeAndCountLegions.Add(name, new Dictionary<string, long>());
                    soldierTypeAndCountLegions[name].Add(type, count);
                }
                else
                {
                    if (!soldierTypeAndCountLegions[name].ContainsKey(type))
                    {
                        soldierTypeAndCountLegions[name].Add(type, count);
                    }
                    else
                    {
                        soldierTypeAndCountLegions[name][type] += count;
                    }
                }

                if (!legionLastActivities.ContainsKey(name))
                {
                    legionLastActivities.Add(name, activity);
                }
                else
                {
                    if (legionLastActivities[name] < activity)
                    {
                        legionLastActivities[name] = activity;
                    }
                }
            }

            string comandLine = Console.ReadLine();
            if (comandLine.Contains("\\"))
            {
                string[] comands = comandLine.Split('\\');
                int activity = int.Parse(comands[0]);
                string soldierType = comands[1];
                foreach (KeyValuePair<string, Dictionary<string, long>> legion in soldierTypeAndCountLegions.Where(x => x.Value.ContainsKey(soldierType)).OrderByDescending(x => x.Value[soldierType]))
                {
                    if (legionLastActivities[legion.Key] < activity && soldierTypeAndCountLegions[legion.Key].ContainsKey(soldierType))
                    {
                        Console.WriteLine("{0} -> {1}", legion.Key, legion.Value[soldierType]);
                    }
                }
            }
            else
            {
                string soldierType = comandLine;
                foreach (KeyValuePair<string, int> lastActivity in legionLastActivities.OrderByDescending(x => x.Value))
                {
                    if (soldierTypeAndCountLegions[lastActivity.Key].ContainsKey(soldierType))
                    {
                        Console.WriteLine($"{lastActivity.Value} : {lastActivity.Key}");
                    }
                }
            }
        }
    }
}
