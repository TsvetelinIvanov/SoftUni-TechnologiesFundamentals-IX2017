using System;

namespace _05Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int fibonacciN = FindFibonacciN(n);
            Console.WriteLine(fibonacciN);
        }

        static int FindFibonacciN(int n)
        {
            int f0 = 1;
            int f1 = 1;
            for (int i = 1; i < n; i++)
            {
                int fNext = f1;
                f1 = f0 + f1;
                f0 = fNext;
            }

            return f1;
        }
    }
}
