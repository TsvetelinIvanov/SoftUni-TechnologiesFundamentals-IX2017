using System;
using System.Collections.Generic;
using System.Linq;

namespace _02ArrayManipulator//in this case a zero is an even number (in Judge tests), without zero - (//) use comments!
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] commands = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                switch (commands[0])
                {
                    case "exchange":
                        int exchangeIndex = int.Parse(commands[1]);
                        if (exchangeIndex < 0 || exchangeIndex >= array.Length)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            array = ExchangeArray(array, exchangeIndex);
                        }

                        break;
                    case "max":
                        if (commands[1] == "even")
                        {
                            PrintIndexOfMaxEven(array);
                        }
                        else if (commands[1] == "odd")
                        {
                            PrintIndexOfMaxOdd(array);
                        }

                        break;
                    case "min":
                        if (commands[1] == "even")
                        {
                            PrintIndexOfMinEven(array);
                        }
                        else if (commands[1] == "odd")
                        {
                            PrintIndexOfMinOdd(array);
                        }

                        break;
                    case "first":
                        int firstElementsCount = int.Parse(commands[1]);
                        if (firstElementsCount > array.Length)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            if (commands[2] == "even")
                            {
                                PrintFirstEvenElements(array, firstElementsCount);
                            }
                            else if (commands[2] == "odd")
                            {
                                PrintFirstOddElements(array, firstElementsCount);
                            }
                        }

                        break;
                    case "last":
                        int lastElementsCount = int.Parse(commands[1]);
                        if (lastElementsCount > array.Length)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            if (commands[2] == "even")
                            {
                                PrintLastEvenElements(array, lastElementsCount);
                            }
                            else if (commands[2] == "odd")
                            {
                                PrintLastOddElements(array, lastElementsCount);
                            }
                        }

                        break;
                }
            }

            Console.WriteLine($"[{string.Join(", ", array)}]");
        }

        private static int[] ExchangeArray(int[] array, int exchangeIndex)
        {
            int[] tacked = array.Take(exchangeIndex + 1).ToArray();
            int[] rest = array.Skip(exchangeIndex + 1).ToArray();
            for (int i = 0; i < rest.Length; i++)
            {
                array[i] = rest[i];
            }

            for (int i = 0; i < taked.Length; i++)
            {
                array[i + rest.Length] = taked[i];
            }

            return array;
        }

        private static void PrintIndexOfMaxEven(int[] array)
        {
            int index = -1;
            int number = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0 && array[i] >= number) //&& array[i] != 0
                {
                    index = i;
                    number = array[i];
                }
            }

            if (index >= 0)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        private static void PrintIndexOfMaxOdd(int[] array)
        {
            int index = -1;
            int number = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0 && array[i] >= number)
                {
                    index = i;
                    number = array[i];
                }
            }

            if (index >= 0)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("No matches");
            }                
        }

        private static void PrintIndexOfMinEven(int[] array)
        {
            int index = -1;
            int number = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0 && array[i] <= number) //&& array[i] != 0 
                {
                    index = i;
                    number = array[i];
                }
            }

            if (index >= 0)
            {
                Console.WriteLine(index);
            }                
            else
            {
                Console.WriteLine("No matches");
            }                
        }

        private static void PrintIndexOfMinOdd(int[] array)
        {
            int index = -1;
            int number = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0 && array[i] <= number)
                {
                    index = i;
                    number = array[i];
                }
            }

            if (index >= 0)
            {
                Console.WriteLine(index);
            }                
            else
            {
                Console.WriteLine("No matches");
            }                
        }

        private static void PrintFirstEvenElements(int[] array, int firstElementsCount)
        {
            List<int> firstEvenElements = new List<int>();
            int[] evenElements = array.Where(e => e % 2 == 0).ToArray();
            for (int i = 0; i < Math.Min(firstElementsCount, evenElements.Length); i++)
            {
                //if (evenElements[i] != 0)
                //{
                firstEvenElements.Add(evenElements[i]);
                //}
                //else
                //{
                //    firstElementsCount++;
                //}                    
            }

            Console.WriteLine($"[{string.Join(", ", firstEvenElements)}]");
        }

        private static void PrintFirstOddElements(int[] array, int firstElementsCount)
        {
            List<int> firstOddElements = new List<int>();
            int[] oddElements = array.Where(e => e % 2 != 0).ToArray();
            for (int i = 0; i < Math.Min(firstElementsCount, oddElements.Length); i++)
            {
                firstOddElements.Add(oddElements[i]);
            }

            Console.WriteLine($"[{string.Join(", ", firstOddElements)}]");
        }

        private static void PrintLastEvenElements(int[] array, int lastElementsCount)
        {
            List<int> lastEvenElements = new List<int>();
            int[] evenElements = array.Where(e => e % 2 == 0).ToArray();
            Array.Reverse(evenElements);
            for (int i = 0; i < Math.Min(lastElementsCount, evenElements.Length); i++)
            {
                //if (evenElements[i] != 0)
                //{
                lastEvenElements.Add(evenElements[i]);
                //}
                //else
                //{
                //    lastElementsCount++;
                //}
            }

            int[] arrayOfLastEvenElements = lastEvenElements.ToArray();
            arrayOfLastEvenElements = arrayOfLastEvenElements.Reverse().ToArray();
            Console.WriteLine($"[{string.Join(", ", arrayOfLastEvenElements)}]");
        }

        private static void PrintLastOddElements(int[] array, int lastElementsCount)
        {
            List<int> lastOddElements = new List<int>();
            int[] oddElements = array.Where(e => e % 2 != 0).ToArray();
            Array.Reverse(oddElements);
            for (int i = 0; i < Math.Min(lastElementsCount, oddElements.Length); i++)
            {
                lastOddElements.Add(oddElements[i]);
            }

            int[] arrayOfLastOddElements = lastOddElements.ToArray();
            arrayOfLastOddElements = arrayOfLastOddElements.Reverse().ToArray();
            Console.WriteLine($"[{string.Join(", ", arrayOfLastOddElements)}]");
        }                                               
    }
}
