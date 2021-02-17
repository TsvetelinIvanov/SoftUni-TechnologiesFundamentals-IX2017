using System;

namespace _14MagicLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char forbidenLetter = char.Parse(Console.ReadLine());
            for (char i = firstLetter; i <= secondLetter; i++)
            {
                for (char j = firstLetter; j <= secondLetter; j++)
                {
                    for (char k = firstLetter; k <= secondLetter; k++)
                    {
                        //string result = $"{i}{j}{k} ";
                        //if (!result.Contains(forbidenLetter))
                        //    Console.Write(result);
                        if (i == forbidenLetter || j == forbidenLetter || k == forbidenLetter)
                        { }
                        else
                        {
                            Console.Write($"{i}{j}{k} ");
                        }
                    }
                }
            }
        }
    }
}
