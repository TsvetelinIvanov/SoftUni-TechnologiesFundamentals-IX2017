using System;
using System.Collections.Generic;
using System.Linq;

namespace _02HornetArmada
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> legions = new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string, int> legionsLastActivities = new Dictionary<string, int>();
            
            int dataCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < dataCount; i++)
            {
                string[] legionData = Console.ReadLine().Split(new char[] { ' ', '=', '-', '>', ':' }, StringSplitOptions.RemoveEmptyEntries);
                int activity = int.Parse(legionData[0]);
                string name = legionData[1];
                string type = legionData[2];
                long count = long.Parse(legionData[3]);
                if (!legions.ContainsKey(name))
                {
                    legions.Add(name, new Dictionary<string, long>());
                    legions[name].Add(type, count);
                }
                else
                {
                    if(!legions[name].ContainsKey(type))
                    {
                        legions[name].Add(type, count);
                    }
                    else
                    {
                        legions[name][type] += count;
                    }
                }

                if (!legionsLastActivities.ContainsKey(name))
                {
                    legionsLastActivities.Add(name, activity);
                }
                else
                {
                    if (legionsLastActivities[name] < activity)
                    {
                        legionsLastActivities[name] = activity;
                    }
                }
            }

            string comandLine = Console.ReadLine();
            if (comandLine.Contains("\\"))
            {
                string[] comandData = comandLine.Split('\\');
                int activity = int.Parse(comandData[0]);
                string soldierType = comandData[1];
                foreach (KeyValuePair<string, Dictionary<string, long>> legion in legions.Where(l => l.Value.ContainsKey(soldierType)).OrderByDescending(l => l.Value[soldierType]))
                {                    
                        if (legionsLastActivities[legion.Key] < activity && legions[legion.Key].ContainsKey(soldierType))
                        {                            
                            Console.WriteLine("{0} -> {1}", legion.Key, legion.Value[soldierType]);
                        }                    
                }
            }
            else
            {
                string soldierType = comandLine;                
                foreach (KeyValuePair<string, int> lastActivity in legionsLastActivities.OrderByDescending(la => la.Value))
                {
                    if (legions[lastActivity.Key].ContainsKey(soldierType))
                    {
                        Console.WriteLine($"{lastActivity.Value} : {lastActivity.Key}");
                    }
                }
            }
        }       
    }
}
