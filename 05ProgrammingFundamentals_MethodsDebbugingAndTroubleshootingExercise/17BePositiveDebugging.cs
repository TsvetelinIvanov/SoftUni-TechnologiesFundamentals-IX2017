using System;
using System.Collections.Generic;

namespace _17BePositiveDebugging
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int sequencesCount = int.Parse(Console.ReadLine());
                for (int i = 0; i < sequencesCount; i++)
                {
                    string[] input = Console.ReadLine().Trim().Split(' ');
                    List<int> numbers = new List<int>();
                    for (int j = 0; j < input.Length; j++)
                    {
                        if (!input[j].Equals(string.Empty))
                        {
                            int number = int.Parse(input[j]);
                            numbers.Add(number);
                        }
                    }

                    bool found = false;
                    for (int j = 0; j < numbers.Count; j++)
                    {
                        int currentNumber = numbers[j];
                        if (currentNumber >= 0)
                        {
                            if (found)
                            {
                                Console.Write(" ");
                            }

                            Console.Write(currentNumber);
                            found = true;
                        }
                        else if(j + 1 < numbers.Count)
                        {
                            currentNumber += numbers[j + 1];
                            if (currentNumber >= 0)
                            {
                                if (found)
                                {
                                    Console.Write(" ");
                                }

                                Console.Write(currentNumber);
                                found = true;
                            }
                            
                            j++;
                        }
                    }

                    if (!found)
                    {
                        Console.WriteLine("(empty)");
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
