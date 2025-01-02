using System;

namespace _04SieveOfErathostenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] inputArray = new int[n + 1];
            bool[] arePrimes = new bool[n + 1];
            string primeNumbersString = null;
            for (int i = 0; i < arePrimes.Length; i++)
            {
                inputArray[i] = i;
                arePrimes[i] = true;
            }

            primeNumbersString = MakeSieveOfErathosten(inputArray, arePrimes, primeNumbersString);
            Console.WriteLine(primeNumbersString.Trim());                      
        }

        private static string MakeSieveOfErathosten(int[] inputArray, bool[] arePrimes, string primeNumbersString)
        {
            arePrimes[0] = false;
            arePrimes[1] = false;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (arePrimes[i])
                {
                    primeNumbersString += $"{inputArray[i]} ";
                    for (int j = i + 1; j < inputArray.Length; j++)
                    {
                        if (inputArray[j] % i == 0 && arePrimes[j] == true)
                        {
                            arePrimes[j] = false;
                        }
                    }
                }
            }

            return primeNumbersString;
        }
    }
}
