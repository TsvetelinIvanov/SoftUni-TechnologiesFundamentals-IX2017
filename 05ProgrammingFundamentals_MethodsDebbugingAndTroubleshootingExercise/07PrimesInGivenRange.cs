using System;
using System.Collections.Generic;

namespace _07PrimesInGivenRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            if (startNumber <= endNumber)
            {
                List<int> primesList = FindPrimesInRange(startNumber, endNumber);                
                for (int i = 0; i <= primesList.Count - 2; i++)
                {
                    Console.Write($"{primesList[i]}, ");
                }

                Console.Write($"{primesList[primesList.Count - 1]}");
            }            
            else
            {
                List<int> primesList = FindPrimesInRange(endNumber, startNumber);
                for (int i = 0; i <= primesList.Count - 2; i++)
                {
                    Console.Write($"{primesList[i]}, ");
                }

                Console.Write($"{primesList[primesList.Count - 1]}");
            }            
        }
        
        static List<int> FindPrimesInRange(int start, int end)
        {
            List<int> primesList = new List<int>();
            for (int i = start; i <= end; i++)
            {
                bool prime = true;
                if (i == 0 || i == 1)
                {
                    prime = false;
                }
                    
                double iSquart = Math.Sqrt(i);
                for (int j = 2; j <= iSquart; j++)
                {
                    if (i % j == 0)
                    {
                        prime = false;
                        break;
                    }
                }

                if (prime)
                {
                    primesList.Add(i);
                }
            }

            return primesList;
        }
    }
}
