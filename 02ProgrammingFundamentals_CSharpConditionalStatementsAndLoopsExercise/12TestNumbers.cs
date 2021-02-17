using System;

namespace _12TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int boundarySum = int.Parse(Console.ReadLine());
            int counter = 0;
            int sum = 0;
            for (int i = N; i >= 1; i--)
            {
                for (int j = 1; j <= M; j++)
                {
                    counter++;
                    sum += 3 * (i * j);
                    if (sum >= boundarySum)
                        break;
                }
                if (sum >= boundarySum)
                    break;
            }
            if (sum >= boundarySum)
            {
                Console.WriteLine("{0} combinations", counter);
                Console.WriteLine("Sum: {0} >= {1}", sum, boundarySum);
            }
            else
            {
                Console.WriteLine("{0} combinations", counter);
                Console.WriteLine("Sum: {0}", sum);
            }
        }
    }
}
