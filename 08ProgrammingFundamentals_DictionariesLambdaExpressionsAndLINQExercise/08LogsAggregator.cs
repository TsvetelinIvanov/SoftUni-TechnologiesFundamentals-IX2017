using System;
using System.Collections.Generic;
using System.Linq;

namespace _08LogsAggregator
{
    class Program
    {        
        static void Main(string[] args)
        {
            SortedDictionary<string, SortedDictionary<string, int>> logs = new SortedDictionary<string, SortedDictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string user = input[1];
                string IP = input[0];
                int duration = int.Parse(input[2]);

                if (!logs.ContainsKey(user))
                {
                    logs.Add(user, new SortedDictionary<string, int>());
                }

                if (!logs[user].ContainsKey(IP))
                {
                    logs[user][IP] = 0;
                }

                logs[user][IP] += duration;
            }

            foreach (KeyValuePair<string, SortedDictionary<string, int>> log in logs)
            {
                Console.WriteLine($"{log.Key}: {log.Value.Values.Sum()} [{string.Join(", ", log.Value.Keys)}]");
            }
        }
    }
}
