using System;
using System.Collections.Generic;
using System.Linq;

namespace _02HornetArmada
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> legionSoldierTypeAndCount = 
                new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string, int> legionLastActivity = new Dictionary<string, int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] legionData = Console.ReadLine()
                    .Split(new char[] { ' ', '=', '-', '>', ':' }, StringSplitOptions.RemoveEmptyEntries);
                int activity = int.Parse(legionData[0]);
                string name = legionData[1];
                string type = legionData[2];
                long count = long.Parse(legionData[3]);
                if (!legionSoldierTypeAndCount.ContainsKey(name))
                {
                    legionSoldierTypeAndCount.Add(name, new Dictionary<string, long>());
                    legionSoldierTypeAndCount[name].Add(type, count);
                }
                else
                {
                    if(!legionSoldierTypeAndCount[name].ContainsKey(type))
                    {
                        legionSoldierTypeAndCount[name].Add(type, count);
                    }
                    else
                    {
                        legionSoldierTypeAndCount[name][type] += count;
                    }
                }

                if (!legionLastActivity.ContainsKey(name))
                {
                    legionLastActivity.Add(name, activity);
                }
                else
                {
                    if (legionLastActivity[name] < activity)
                    {
                        legionLastActivity[name] = activity;
                    }
                }
            }

            string comandLine = Console.ReadLine();
            if (comandLine.Contains("\\"))
            {
                string[] comands = comandLine.Split('\\');
                int activity = int.Parse(comands[0]);
                string soldierType = comands[1];
                foreach (KeyValuePair<string, Dictionary<string, long>> legion in legionSoldierTypeAndCount.Where(x => x.Value.ContainsKey(soldierType))
                .OrderByDescending(x => x.Value[soldierType]))
                {                    
                        if (legionLastActivity[legion.Key] < activity && 
                        legionSoldierTypeAndCount[legion.Key].ContainsKey(soldierType))
                        {                            
                            Console.WriteLine("{0} -> {1}", legion.Key, legion.Value[soldierType]);
                        }                    
                }
            }
            else
            {
                string soldierType = comandLine;                
                foreach (KeyValuePair<string, int> lastActivity in legionLastActivity.OrderByDescending(x => x.Value))
                {
                    if (legionSoldierTypeAndCount[lastActivity.Key].ContainsKey(soldierType))
                    {
                        Console.WriteLine($"{lastActivity.Value} : {lastActivity.Key}");
                    }
                }
            }
        }       
    }
}
