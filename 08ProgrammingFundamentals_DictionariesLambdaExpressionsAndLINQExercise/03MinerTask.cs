using System;
using System.Collections.Generic;

namespace _03MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();
            string resource = Console.ReadLine();
            while (resource != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if (!resources.ContainsKey(resource))
                {
                    resources[resource] = 0;
                }

                resources[resource] += quantity;

                resource = Console.ReadLine();
            }

            foreach (KeyValuePair<string, int> item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
