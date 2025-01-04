using System;

namespace _06ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine().Split(' ');
            for (int i = 0; i < elements.Length / 2; i++)
            {
                SwapElements(elements, i, elements.Length - 1 - i);
            }

            Console.WriteLine(string.Join(" ", elements));
        }

        static void SwapElements(string[] elements, int i, int j)
        {
            string oldElement = elements[i];
            elements[i] = elements[j];
            elements[j] = oldElement;
        }
    }
}
