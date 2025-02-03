using System;
using System.Linq;

namespace _01RotateArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] rotatedArray = new string[array.Length];
            for (int i = 0; i < array.Length - 1; i++)
            {
                rotatedArray[i + 1] = array[i];
            }

            string rotatedElement = array[array.Length - 1];
            rotated[0] = rotatedElement;
            Console.WriteLine(string.Join(" ", rotatedArray));

            // If we wont to rotate more times:
            //string[] array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            //int rotationsCount = int.Parse(Console.ReadLine());
            //for (int i = 0; i < rotationsCount % array.Length; i++)
            //{
            //    string rotatedElement = array[array.Length - 1];
            //    for (int j = array.Length - 1; j >= 1; j--)
            //    {
            //        array[j] = array[j - 1];
            //    }

            //    array[0] = rotatedElement;
            //}

            //Console.WriteLine(string.Join(" ", array));
        }
    }
}
