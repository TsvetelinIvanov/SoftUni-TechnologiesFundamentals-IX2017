using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06UserLogs
{
    class Program
    {        
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> users = new Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] userData = input.Split(" ='".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                string userName = userData[userData.Length - 1];
                string userIP = userData[1];
                
                if (!users.ContainsKey(userName))
                {
                    users.Add(userName, new Dictionary<string, int>());
                }

                if (!users[userName].ContainsKey(userIP))
                {
                    users[userName].Add(userIP, 0);
                }

                users[userName][userIP]++;

                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, Dictionary<string, int>> user in users.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{user.Key}:");
                StringBuilder userIPsAndMessgesCountsBuilder = new StringBuilder();
                foreach (KeyValuePair<string, int> userIPs in user.Value)
                {
                    userIPsAndMessgesCountsBuilder.Append(userIPs.Key).Append(" => ").Append(userIPs.Value + ", ");
                }

                userIPsAndMessgesCountsBuilder.Remove(userIPsAndMessgesCountsBuilder.Length - 2, 2);
                userIPsAndMessgesCountsBuilder.Append(".");
                Console.WriteLine(userIPsAndMessgesCountsBuilder);
            }
        }
    }
}
