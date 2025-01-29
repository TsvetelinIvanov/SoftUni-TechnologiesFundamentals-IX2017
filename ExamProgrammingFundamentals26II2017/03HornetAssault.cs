using System;
using System.Collections.Generic;
using System.Linq;

namespace _03HornetAssault
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] beehives = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(long.Parse).ToArray();
            List<long> hornets = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                  .Select(long.Parse).ToList();

            for (int i = 0; i < beehives.Length; i++)
            {
                long hornetsPower = hornets.Sum();
                if (hornetsPower <= beehives[i])
                {
                    beehives[i] -= hornetsPower;
                    hornets.RemoveAt(0);
                }
                else
                {
                    beehives[i] = 0;
                }

                if (hornets.Count == 0)
                {
                    break;
                }                    
            }

            if (beehives.Sum() > 0)
            {
                Console.WriteLine(string.Join(" ", beehives.Where(x => x > 0)));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets.Where(x => x > 0)));
            }                
        }
    }
}
