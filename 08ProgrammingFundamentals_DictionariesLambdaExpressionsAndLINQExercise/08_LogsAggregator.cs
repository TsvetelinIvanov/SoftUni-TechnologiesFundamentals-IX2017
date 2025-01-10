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
            int logsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < logsCount; i++)
            {
                List<string> logData = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                string userName = logData[1];
                string userIP = logData[0];
                double duration = double.Parse(logData[2]);

                if (!userIPs.ContainsKey(userName))
                {
                    userIPs[userName] = new List<string>();
                    users[userName] = 0;
                }

                userIPs[userName].Add(userIP);
                userIPs[userName] = userIPs[userName].Distinct().OrderBy(u => u).ToList();
                users[userName] += duration;
            }
        }
    }
}
