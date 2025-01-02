using System;

namespace _01_LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] secondArray = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            
            int leftCount = 0;
            int rightCount = 0;
            for (int i = 0; i < Math.Min(firstArray.Length, secondArray.Length); i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    leftCount++;
                }

                if (firstArray[firstArray.Length - 1 - i] == secondArray[secondArray.Length - 1 - i])
                {
                    rightCount++;
                }
            }

            if (leftCount >= rightCount)
            {
                Console.WriteLine(leftCount);
            }
            else
            {
                Console.WriteLine(rightCount);
            }
        }
    }
}
