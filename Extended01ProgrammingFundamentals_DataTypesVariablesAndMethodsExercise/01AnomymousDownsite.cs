using System;
using System.Collections.Generic;
using System.Numerics;

namespace _01AnomymousDownsite
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger key = BigInteger.Parse(Console.ReadLine());
            BigInteger securityToken = Power(key, n);
            
            List<string> websiteNames = new List<string>();
            decimal totalLoss = 0;
            for (int i = 0; i < n; i++)
            {
                string[] websiteData = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string websiteName = websiteData[0];
                websiteNames.Add(websiteName);
                
                decimal loss = CalculateLoss(websiteData);
                totalLoss += loss;
            }

            Console.WriteLine(string.Join("\n", websiteNames));
            Console.WriteLine($"Total Loss: {totalLoss:f20}");
            Console.WriteLine("Security Token: " + securityToken);
        }

        private static BigInteger Power(BigInteger key, BigInteger power)
        {
            BigInteger powered = 1;
            for (int i = 1; i <= power; i++)
            {
                powered *= key;
            }

            return powered;
        }

        private static decimal CalculateLoss(string[] websiteData)
        {
            decimal loss = decimal.Parse(websiteData[1]) * decimal.Parse(websiteData[2]);

            return loss;
        }
    }
}
