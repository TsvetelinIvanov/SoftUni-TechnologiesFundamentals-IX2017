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
            Dictionary<BigInteger, List<int>> snowballs = new Dictionary<BigInteger, List<int>>();
            int snowballsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < snowballsCount; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                BigInteger snowballValue = BigInteger.Pow(new BigInteger(snowballSnow / snowballTime), snowballQuality);
                
                snowballs.Add(snowballValue, new List<int>());
                snowballs[snowballValue].Add(snowballSnow);
                snowballs[snowballValue].Add(snowballTime);
                snowballs[snowballValue].Add(snowballQuality);
            }

            foreach (KeyValuePair<BigInteger, List<int>> snowball in snowballs.OrderByDescending(s => s.Key))
            {
                Console.WriteLine($"{snowball.Value[0]} : {snowball.Value[1]} = {snowball.Key} ({snowball.Value[2]})");
                break;
            }
        }
    }
}
