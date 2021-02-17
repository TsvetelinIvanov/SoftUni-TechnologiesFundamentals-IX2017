using System;

namespace _13GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int counter = 0;
            bool isFound = false;
            string expression = string.Empty;
            //int n = 0;
            //int m = 0;
            for (int i = N; i <= M; i++)
            {
                for (int j = N; j <= M; j++)
                {
                    counter++;
                    if ((i + j) == magicNumber)
                    {
                        expression = $"{i} + {j} = {magicNumber}";
                        //n = i;
                        //m = j;
                        isFound = true;
                    }
                }
            }
            if (isFound)
            {
                Console.WriteLine("Number found! {0}", expression);
                //Console.WriteLine($"Number Found! {n} + {m} = {magicNumber}");
            }
            else
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
            }
        }
    }
}
