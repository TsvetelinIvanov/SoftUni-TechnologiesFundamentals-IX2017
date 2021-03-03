using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _01Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<BigInteger, List<int>> snowballData = new Dictionary<BigInteger, List<int>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                BigInteger snowballValue =
                    BigInteger.Pow(new BigInteger(snowballSnow / snowballTime), snowballQuality);
                snowballData.Add(snowballValue, new List<int>());
                snowballData[snowballValue].Add(snowballSnow);
                snowballData[snowballValue].Add(snowballTime);
                snowballData[snowballValue].Add(snowballQuality);
            }

            foreach (KeyValuePair<BigInteger, List<int>> snowball in snowballData.OrderByDescending(x => x.Key))
            {
                Console.WriteLine($"{snowball.Value[0]} : {snowball.Value[1]} = {snowball.Key} ({snowball.Value[2]})");
                break;
            }
        }
    }
}
