using System;

namespace _01PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            int targetsCount = 0;
            int originalN = N;
            while (N >= M)
            {
                N = N - M;
                targetsCount++;
                if (N == originalN / 2.0 && Y > 0)
                {
                    N = N / Y;
                }
            }

            Console.WriteLine(N);
            Console.WriteLine(targetsCount);
        }
    }
}
