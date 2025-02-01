using System;

namespace _03PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            
            int targetsCount = 0;
            int originalN = n;
            while (n >= m)
            {              
                n = n - m;
                targetsCount++;
                if (n == originalN / 2.0 && y > 0)
                {
                    n = n / y;
                }
            }

            Console.WriteLine(n);
            Console.WriteLine(targetsCount);
        }
    }
}
