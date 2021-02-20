using System;

namespace _04SieveOfErathostenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrInput = new int[n + 1];
            bool[] primes = new bool[n + 1];
            string primeNumbers = null;
            for (int i = 0; i < primes.Length; i++)
            {
                arrInput[i] = i;
                primes[i] = true;
            }

            primeNumbers = DoSieveOfErathosten(arrInput, primes, primeNumbers);
            Console.WriteLine(primeNumbers.Trim());                      
        }

        private static string DoSieveOfErathosten(int[] ArrInput, bool[] checkNumbers, string primeNumbers)
        {
            checkNumbers[0] = false;
            checkNumbers[1] = false;
            for (int i = 0; i < ArrInput.Length; i++)
            {
                if (checkNumbers[i])
                {
                    primeNumbers += $"{ArrInput[i]} ";
                    for (int j = i + 1; j < ArrInput.Length; j++)
                    {
                        if (ArrInput[j] % i == 0 && checkNumbers[j] == true)
                        {
                            checkNumbers[j] = false;
                        }
                    }
                }
            }

            return primeNumbers;
        }
    }
}
