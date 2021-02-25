using System;
using System.Collections.Generic;
using System.Numerics;

namespace _01_AnonymousDownsite
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int key = int.Parse(Console.ReadLine());
            BigInteger securityToken = BigInteger.Pow(new BigInteger(key), n);
            List<string> websiteNames = new List<string>();
            decimal totalLoss = 0;
            for (int i = 0; i < n; i++)
            {
                string[] websitesData = Console.ReadLine().Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries);
                string websiteName = websitesData[0];
                websiteNames.Add(websiteName);
                decimal loss = CalculateLoss(websitesData);
                totalLoss += loss;
            }

            Console.WriteLine(string.Join("\n", websiteNames));
            Console.WriteLine($"Total Loss: {totalLoss:f20}");
            Console.WriteLine("Security Token: " + securityToken);
        }
                
        private static decimal CalculateLoss(string[] websitesData)
        {
            decimal loss = decimal.Parse(websitesData[1]) * decimal.Parse(websitesData[2]);

            return loss;
        }
    }
}
