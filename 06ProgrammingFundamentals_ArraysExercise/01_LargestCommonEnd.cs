using System;

namespace _01_LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] array2 = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int leftLength = 0;
            int rightLength = 0;

            for (int i = 0; i < Math.Min(array1.Length, array2.Length); i++)
            {
                if (array1[i] == array2[i])
                    leftLength++;

                if (array1[array1.Length - 1 - i] == array2[array2.Length - 1 - i])
                    rightLength++;
            }

            if (leftLength >= rightLength)
                Console.WriteLine(leftLength);
            else
                Console.WriteLine(rightLength);
        }
    }
}
