using System;
using System.Collections.Generic;
using System.Linq;

namespace _02Snowmen
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> snowmen = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            while (snowmen.Count > 1)
            {
                for (int i = 0; i < snowmen.Count; i++)
                {
                    for (int j = 0; j < snowmen.Count; j++)
                    {
                        int target = snowmen[i];
                        if (target >= snowmen.Count)
                        {
                            target %= snowmen.Count;
                        }

                        if (target == j)
                        {
                            int fight = Math.Abs(i - j);
                            if (fight == 0)
                            {
                                Console.WriteLine($"{i} performed harakiri");
                                snowmen[i] = -1;
                            }
                            else if (fight % 2 == 0)
                            {
                                Console.WriteLine($"{i} x {j} -> {i} wins");
                                snowmen[j] = -1;
                            }
                            else if (fight % 2 != 0)
                            {
                                Console.WriteLine($"{i} x {j} -> {j} wins");
                                snowmen[i] = -1;
                            }

                            List<int> currentSnowmen = new List<int>(snowmen.Where(x => x != -1));
                            if (currentSnowmen.Count == 1)
                            {
                                return;
                            }                                
                        }
                    }
                }

                snowmen.RemoveAll(x => x == -1);
            }
        }
    }
}
