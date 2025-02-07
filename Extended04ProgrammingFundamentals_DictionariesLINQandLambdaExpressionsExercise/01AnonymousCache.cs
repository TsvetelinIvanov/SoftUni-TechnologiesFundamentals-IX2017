using System;
using System.Collections.Generic;
using System.Linq;

namespace _01AnonymousCache
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> dataSets = new List<string>();
            Dictionary<string, Dictionary<string, long>> dataCaches = new Dictionary<string, Dictionary<string, long>>();
            string input = Console.ReadLine();
            while (input != "thetinggoesskrra")
            {
                if (input.Contains("-") && input.Contains(">") && input.Contains("|"))
                {
                    string[] data = input.Split(new string[] { " -> ", " | " }, StringSplitOptions.None);
                    string key = data[0];
                    long size = long.Parse(data[1]);
                    string set = data[2];
                    if (!dataCaches.ContainsKey(set))
                    {
                        dataCaches.Add(set, new Dictionary<string, long>());
                        dataCaches[set].Add(key, size);
                    }
                    else
                    {
                        dataCaches[set].Add(key, size);
                    }
                }
                else
                {
                    dataSets.Add(input);
                }

                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, Dictionary<string, long>> dataSet in dataCaches.OrderByDescending(ds => ds.Value.Values.Sum())) 
            {
                if (dataSets.Contains(dataSet.Key))
                {
                    Console.WriteLine($"Data Set: {dataSet.Key}, Total Size: {dataSet.Value.Values.Sum()}");
                    foreach (KeyValuePair<string, long> dataKey in dataSet.Value)
                    {
                        Console.WriteLine("$." + dataKey.Key);
                    }

                    break;
                }
            }
        }
    }
}
