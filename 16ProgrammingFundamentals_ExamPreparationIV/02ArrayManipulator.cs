using System;
using System.Collections.Generic;
using System.Linq;

namespace _02ArrayManipulator//in this case the zero is an even number (in Judge tests), without zero - (//) use comments!
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] commands = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                switch (commands[0])
                {
                    case "exchange":
                        int indexExchange = int.Parse(commands[1]);
                        if (indexExchange < 0 || indexExchange >= array.Length)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            array = ExchangeArray(array, indexExchange);
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
                                PrintNFirstEvenElements(array, firstElementsCount);
                            }
                            else if (commands[2] == "odd")
                            {
                                PrintNFirstOddElements(array, firstElementsCount);
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
                                PrintNLastEvenElements(array, lastElementsCount);
                            }
                            else if (commands[2] == "odd")
                            {
                                PrintNLastOddElements(array, lastElementsCount);
                            }
                        }

                        break;
                }
            }

            Console.WriteLine($"[{string.Join(", ", array)}]");
        }

        private static int[] ExchangeArray(int[] array, int indexExchange)
        {
            int[] arrayTaked = array.Take(indexExchange + 1).ToArray();
            int[] arrayRest = array.Skip(indexExchange + 1).ToArray();
            for (int i = 0; i < arrayRest.Length; i++)
            {
                array[i] = arrayRest[i];
            }

            for (int i = 0; i < arrayTaked.Length; i++)
            {
                array[i + arrayRest.Length] = arrayTaked[i];
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

        private static void PrintNFirstEvenElements(int[] array, int countOfNFirstElements)
        {
            List<int> firstNEvenElementsInArray = new List<int>();
            int[] evenElementsInArray = array.Where(x => x % 2 == 0).ToArray();
            for (int i = 0; i < Math.Min(countOfNFirstElements, evenElementsInArray.Length); i++)
            {
                //if (evenElementsInArray[i] != 0)
                //{
                firstNEvenElementsInArray.Add(evenElementsInArray[i]);
                //}
                //else
                //{
                //    countOfNFirstElements++;
                //}                    
            }

            Console.WriteLine($"[{string.Join(", ", firstNEvenElementsInArray)}]");
        }

        private static void PrintNFirstOddElements(int[] array, int countOfNFirstElements)
        {
            List<int> firstNOddElementsInArray = new List<int>();
            int[] oddElementsInArray = array.Where(x => x % 2 != 0).ToArray();
            for (int i = 0; i < Math.Min(countOfNFirstElements, oddElementsInArray.Length); i++)
            {
                firstNOddElementsInArray.Add(oddElementsInArray[i]);
            }

            Console.WriteLine($"[{string.Join(", ", firstNOddElementsInArray)}]");
        }

        private static void PrintNLastEvenElements(int[] array, int countOfNLastElements)
        {
            List<int> lastNEvenElementsInArray = new List<int>();
            int[] evenElementsInArray = array.Where(x => x % 2 == 0).ToArray();
            Array.Reverse(evenElementsInArray);
            for (int i = 0; i < Math.Min(countOfNLastElements, evenElementsInArray.Length); i++)
            {
                //if (evenElementsInArray[i] != 0)
                //{
                lastNEvenElementsInArray.Add(evenElementsInArray[i]);
                //}
                //else
                //{
                //    countOfNLastElements++;
                //}
            }

            int[] arrayOfLastNEvenElementsInArray = lastNEvenElementsInArray.ToArray();
            arrayOfLastNEvenElementsInArray = arrayOfLastNEvenElementsInArray.Reverse().ToArray();
            Console.WriteLine($"[{string.Join(", ", arrayOfLastNEvenElementsInArray)}]");
        }

        private static void PrintNLastOddElements(int[] array, int countOfNLastElements)
        {
            List<int> LastNOddElementsInArray = new List<int>();
            int[] oddElementsInArray = array.Where(x => x % 2 != 0).ToArray();
            Array.Reverse(oddElementsInArray);
            for (int i = 0; i < Math.Min(countOfNLastElements, oddElementsInArray.Length); i++)
            {
                LastNOddElementsInArray.Add(oddElementsInArray[i]);
            }

            int[] arrayOfLastNOddElementsInArray = LastNOddElementsInArray.ToArray();
            arrayOfLastNOddElementsInArray = arrayOfLastNOddElementsInArray.Reverse().ToArray();
            Console.WriteLine($"[{string.Join(", ", arrayOfLastNOddElementsInArray)}]");
        }                                               
    }
}
