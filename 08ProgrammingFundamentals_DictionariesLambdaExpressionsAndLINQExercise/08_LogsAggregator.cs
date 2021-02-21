using System;
using System.Collections.Generic;
using System.Linq;

namespace _08_LogsAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> userIPs = new Dictionary<string, List<string>>();
            SortedDictionary<string, double> users = new SortedDictionary<string, double>();
            GetUserIPs(userIPs, users);

            foreach (KeyValuePair<string, double> user in users)
            {
                Console.WriteLine($"{user.Key}: {user.Value} [{string.Join(", ", userIPs[user.Key])}]");
            }
        }

        private static void GetUserIPs(Dictionary<string, List<string>> userIPs, SortedDictionary<string, double> users)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                List<string> inputIP = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                string userName = inputIP[1];
                string userIP = inputIP[0];
                double duration = double.Parse(inputIP[2]);

                if (!userIPs.ContainsKey(userName))
                {
                    userIPs[userName] = new List<string>();
                    users[userName] = 0;
                }

                userIPs[userName].Add(userIP);
                userIPs[userName] = userIPs[userName].Distinct().OrderBy(x => x).ToList();
                users[userName] += duration;
            }
        }
    }
}
